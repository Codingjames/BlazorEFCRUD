using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using BlazorDemo.server2.Data;
using Microsoft.Extensions.Logging;


namespace blazorDemo.Server2
{
    public class LoginModel : PageModel
    {
        SignInManager<AppUser> signinManager;
        ILogger<LoginModel> signLog;
        
        public LoginModel (SignInManager<AppUser> signinManager,ILogger<LoginModel> signLog)
        {
            this.signinManager = signinManager;
            this.signLog = signLog;
        }
        public async Task<IActionResult> OnGetAsync(string username, string password)
        {
            
            var result = await signinManager.PasswordSignInAsync(username,password,false,false);
            
            if(result.Succeeded)
            {
                signLog.LogInformation("Login success.");
                return Redirect("/");
            }
            else
            {
                signLog.LogInformation("Login failed");
                return Redirect("/Error");
            }
        }
    }
}
