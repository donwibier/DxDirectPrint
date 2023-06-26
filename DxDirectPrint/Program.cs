using DevExpress.XtraCharts;
using DxDirectPrint;
using DxDirectPrint.Data;
using DxDirectPrint.Data.DTO;
using DxDirectPrint.Data.EF;
using DxDirectPrint.Data.Services;
using DxDirectPrint.Data.Stores;
using FluentValidation;
using Mapster;

using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Net.Http.Headers;

using System.Text;
using Microsoft.EntityFrameworkCore;

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


var app = builder.Build();

//signalR	
app.UseResponseCompression();

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

app.MapBlazorHub();
app.MapHub<PrintHub>("/printhub");
app.MapFallbackToPage("/_Host");
app.MapControllers();

app.Run();



