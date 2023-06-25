using DX.Data.Xpo.Identity;
using Microsoft.AspNetCore.Identity;
using System.Collections;

namespace DxDirectPrint.Data.DTO
{
    public class ApplicationUser : IdentityUser, IXPUser<string>
    {
        public ApplicationUser() : base() { }
        public string NormalizedName { get => NormalizedUserName; set => NormalizedUserName = value; }
        public string RefreshToken { get; set; } = default!;
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public DateTime? LockoutEndDateUtc { get; set;}

        public IList RolesList => new string[] { };

        public IList ClaimsList => new string[] { };

        public IList LoginsList => new string[] { };

        public void AssignClaims(IList claims)
        {
            ClaimsList.Clear();
            if (claims != null)
                foreach(var c in claims) ClaimsList.Add(c);
        }

        public void AssignLogins(IList logins)
        {
            LoginsList.Clear();
            if (logins != null)
                foreach (var l in logins) LoginsList.Add(l);
        }

        public void AssignRoles(IList roles)
        {
            RolesList.Clear();
            if (roles != null)
                foreach (var r in roles) RolesList.Add(r);
        }
    }
}
