using DX.Blazor.Identity.Server.Controllers;
using DX.Blazor.Identity;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DxDirectPrint.Data.DTO;

namespace DxDirectPrint.Controllers
{
    [Route("api/accounts")]
    public class AccountController : AuthenticationControllerBase<ApplicationUser>
    {
        public AccountController(UserManager<ApplicationUser> userManager,
            ITokenService<string, ApplicationUser> tokenService,
            SignInManager<ApplicationUser> signInManager,
            IDataProtectionProvider dataProtectionProvider,
            ILogger<AuthenticationControllerBase<ApplicationUser>> logger,
            IConfiguration configuration)
            : base(userManager, signInManager, dataProtectionProvider, logger, configuration)
        {

        }
    }
}
