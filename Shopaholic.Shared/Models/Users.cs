using Microsoft.AspNetCore.Identity;

namespace Stopaholic.Shared.Models
{
    public class User : IdentityUser
    {
        // Add any custom properties you may need here
        public string Name { get; set; }
    }
}
