#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_Log_In_ASP.NET.Data;

namespace Web_Log_In_ASP.NET.Models
{
    public class IndexModel : PageModel
    {
        private readonly Web_Log_In_ASP.NET.Data.Web_Log_In_ASPNETContext _context;

        public IndexModel(Web_Log_In_ASP.NET.Data.Web_Log_In_ASPNETContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
