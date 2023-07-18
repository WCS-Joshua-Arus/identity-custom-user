using Microsoft.AspNetCore.Identity;

namespace identity_custom.Models
{
    public class CustomUser : IdentityUser
    {
        public String? ProfilPicture { get; set; }

    }
}
