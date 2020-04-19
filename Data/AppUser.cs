using Microsoft.AspNetCore.Identity;

namespace BlazorDemo.server2.Data
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
    }
}