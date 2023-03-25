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
        public IndexModel(WebAppDBContext db)
        {
            _db = db;
        }
        public IEnumerable<IdentityUser> Users { get; set; }
        public async Task OnGet()
        {
            Users=await _db.Users.ToListAsync();
        }
    }
}
