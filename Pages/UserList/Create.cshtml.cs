using AspnetCoreWebApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspnetCoreWebApp.Pages.UserList
{
    public class CreateModel : PageModel
    {
        private readonly WebAppDBContext _db;
        public CreateModel(WebAppDBContext db) 
        {
            _db = db;
        }
        public IdentityUser Users { get; set; }
        public void OnGet()
        {
        }
    }
}
