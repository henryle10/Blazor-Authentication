using Microsoft.AspNetCore.Identity;

namespace BlazorAuthentication.Data
{
    public class AspNetUsers : IdentityUser
    {
        public string School { get; set; }
    }
}
