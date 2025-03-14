using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace lemonPharmacy.Common.Infrastructure.AspNetCore.Authz
{
    public class AuthAttribute : AuthorizeAttribute
    {
        public AuthAttribute(string policy = null)
        {
            AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme;
            Policy = policy;
        }
    }
}
