using AspnetCoreWebApp.Areas.Identity.Data;
using AspnetCoreWebApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AspnetCoreWebApp.Pages.UserList
{
    public class IndexModel : PageModel
    {

        private readonly WebAppDBContext _db;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public IndexModel(WebAppDBContext db, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IEnumerable<ApplicationUser> Users { get; set; }

        public string temp { get; set; }
        public async Task OnGet()
        {
            Users = await _userManager.Users.ToListAsync();

        }
    }
}
