using DevExpress.XtraCharts;
using DX.Blazor.Identity;
using DX.Blazor.Identity.Server.Services;
using DxDirectPrint;
using DxDirectPrint.Data;
using DxDirectPrint.Data.DTO;
using DxDirectPrint.Data.EF;
using DxDirectPrint.Data.Services;
using DxDirectPrint.Data.Stores;
using FluentValidation;
using Mapster;

using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Net.Http.Headers;

using System.Text;
using Microsoft.EntityFrameworkCore;
using DX.Blazor.Identity.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDevExpressBlazor(options => {
    options.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
    options.SizeMode = DevExpress.Blazor.SizeMode.Medium;
});

builder.Services.AddSingleton<WeatherForecastService>();
builder.WebHost.UseWebRoot("wwwroot");
builder.WebHost.UseStaticWebAssets();

builder.Services.AddMapster();

//signalR
builder.Services.AddCors(policy =>
{
    policy.AddPolicy("CorsPolicy", opt => opt
    .AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod()
    .WithExposedHeaders("X-Pagination"));
});
builder.Services.AddResponseCompression(opt =>
{
    opt.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
        new string[] { "application/octet-stream" });
});


var connStr = builder.Configuration.GetConnectionString("ChinookConnection");
builder.Services.AddDbContext<ChinookContext>(options => options.UseSqlServer(connStr));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ChinookContext>();


builder.Services.AddScoped<IDataStore<int, InvoiceModel>, InvoiceStore>();
builder.Services.AddScoped<IValidator<Invoice>, InvoiceValidator>();
builder.Services.AddScoped<IValidator<InvoiceModel>, InvoiceModelValidator>();

builder.Services.AddScoped<IDataStore<int, InvoiceLineModel>, InvoiceLineStore>();
builder.Services.AddScoped<IValidator<InvoiceLine>, InvoiceLineValidator>();
builder.Services.AddScoped<IValidator<InvoiceLineModel>, InvoiceLineModelValidator>();

builder.Services.AddScoped<IDataStore<int, CustomerModel>, CustomerStore>();
builder.Services.AddScoped<IValidator<Customer>, CustomerValidator>();
builder.Services.AddScoped<IValidator<CustomerModel>, CustomerModelValidator>();

builder.Services.AddScoped<IInvoiceService, InvoiceService>();

// DX.Blazor.Identity.Server configuration
builder.Services.AddScoped<IAuthService, MyAuthenticationService<ApplicationUser>>();
builder.Services.AddScoped<DX.Blazor.Identity.Server.TokenProvider>();
builder.Services.AddScoped<AuthenticationStateProvider, DX.Blazor.Identity.Server.AuthStateProvider<ApplicationUser>>();

// token config
builder.Services.AddScoped<ITokenService<string, ApplicationUser>, DX.Blazor.Identity.Wasm.Services.TokenService<string, ApplicationUser>>();
var jwtSettings = builder.Configuration.GetSection("JWTSettings");
builder.Services.AddAuthentication(options => {
    options.DefaultScheme = "JWT_OR_COOKIE";
    options.DefaultChallengeScheme = "JWT_OR_COOKIE";
})
    .AddCookie(options => {
        //options.Cookie.Name = "KwikEat.Identity";
        options.LoginPath = "/Account/Login";
        //options.AccessDeniedPath = "/Account/AccessDenied";            
        // Sliding expiration resets the expiration time for a valid authentication cookie if a request is made and more than half of the 
        // timeout interval has elapsed.If the cookie expires, the user must re - authenticate.Setting the SlidingExpiration property to 
        // false can improve the security of an application by limiting the time for which an authentication cookie is valid, based on the 
        // configured timeout value.
        options.SlidingExpiration = true;
    })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,

            ValidIssuer = jwtSettings["validIssuer"],
            ValidAudience = jwtSettings["validAudience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["securityKey"] ?? string.Empty))
        };
        options.Events = new JwtBearerEvents
        {
            OnMessageReceived = context =>
            {
                var accessToken = context.Request.Query["access_token"];

                //If the request is for our hub...
                var path = context.HttpContext.Request.Path;
                if (!string.IsNullOrEmpty(accessToken) &&
                    (path.StartsWithSegments("/printhub")))
                {
                    //Read the token out of the query string
                    context.Token = accessToken;

                }
                return Task.CompletedTask;
            }
        };
    })
    .AddPolicyScheme("JWT_OR_COOKIE", "JWT_OR_COOKIE", options =>
    {
        options.ForwardDefaultSelector = context =>
        {
            string authorization = context.Request.Headers[HeaderNames.Authorization]!;
            if (!string.IsNullOrEmpty(authorization) && authorization.StartsWith("Bearer "))
                return JwtBearerDefaults.AuthenticationScheme;

            return CookieAuthenticationDefaults.AuthenticationScheme;
        };
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.CheckAndCreateAdmin();

app.MapBlazorHub();
app.MapHub<PrintHub>("/printhub");
app.MapFallbackToPage("/_Host");
app.MapControllers();

app.Run();



public static class DefaultAdminInitializer
{
    public static void CheckAndCreateAdmin(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            //Resolve ASP .NET Core Identity with DI help
            var userManager = (UserManager<ApplicationUser>)scope.ServiceProvider.GetService(typeof(UserManager<ApplicationUser>));
            var roleManager = (RoleManager<IdentityRole>)scope.ServiceProvider.GetService(typeof(RoleManager<IdentityRole>));

            // do you things here
            if (roleManager != null)
                SeedRoles(roleManager);
            if (userManager != null)
                SeedUsers(userManager);
        }
    }

    static void SeedUsers(UserManager<ApplicationUser> userManager)
    {
        ApplicationUser user = userManager.FindByNameAsync("don@anykey.nl").Result;

        if (user == null)
        {
            user = new ApplicationUser();
            user.UserName = "don@anykey.nl";
            user.Email = "don@anykey.nl";

            IdentityResult result = userManager.CreateAsync(user, "Test123!").Result;
            if (result.Succeeded)
                userManager.AddToRoleAsync(user, "Administrator").Wait();
        }
        else
        {
            var isAdmin = userManager.IsInRoleAsync(user, "Administrator").Result;
            if (!isAdmin)
                userManager.AddToRoleAsync(user, "Administrator").Wait();
        }
    }

    static void SeedRoles(RoleManager<IdentityRole> roleManager)
    {
        if (!roleManager.RoleExistsAsync("Administrator").Result)
        {
            IdentityRole role = new IdentityRole();
            role.Name = "Administrator";
            IdentityResult roleResult = roleManager.CreateAsync(role).Result;
        }
    }
}