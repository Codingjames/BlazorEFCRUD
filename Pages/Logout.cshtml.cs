using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using BlazorDemo.server2.Data;
using Microsoft.Extensions.Logging;

namespace BlazorDemo.server2
{
    public class LogoutModel : PageModel
    {

        SignInManager<AppUser> signMgr;
        ILogger<LogoutModel> logger;
        public LogoutModel(SignInManager<AppUser> signMgr, ILogger<LogoutModel> logger)
        {
            this.signMgr=signMgr;
            this.logger = logger;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            await signMgr.SignOutAsync();


            return Redirect("/");
        }
    }
}
