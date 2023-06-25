using DX.Blazor.Identity;
using DX.Blazor.Identity.Server.Services;
using DX.Data.Xpo.Identity;
using DX.Blazor.Identity.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;

public class MyAuthenticationService<TUser> : AuthenticationService<TUser>, IAuthService 
    where TUser : class, IXPUser<string>, new()
{
    public MyAuthenticationService(UserManager<TUser> userManager, IDataProtectionProvider dataProtectionProvider, 
        NavigationManager navigationManager, HttpClient httpClient,
        ILogger<AuthenticationService<string, TUser, RegistrationModel, AuthenticationModel>> logger) 
        : base(userManager, dataProtectionProvider, navigationManager, httpClient, logger)
    {

    }
}