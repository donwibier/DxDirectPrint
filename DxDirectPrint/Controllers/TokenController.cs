using DX.Blazor.Identity.Wasm.Controllers;
using DX.Blazor.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DxDirectPrint.Data.DTO;

namespace DxDirectPrint.Controllers
{
    [Route("api/token")]
    [ApiController]
    public class TokenController : TokenControllerBase<string, ApplicationUser>
    {
        public TokenController(UserManager<ApplicationUser> userManager,
            ITokenService<string, ApplicationUser> tokenService) : base(userManager, tokenService)
        {

        }
    }
}
