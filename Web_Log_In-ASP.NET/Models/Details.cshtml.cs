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
    public class DetailsModel : PageModel
    {
        private readonly Web_Log_In_ASP.NET.Data.Web_Log_In_ASPNETContext _context;

        public DetailsModel(Web_Log_In_ASP.NET.Data.Web_Log_In_ASPNETContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.ID == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
