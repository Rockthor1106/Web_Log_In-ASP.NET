#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web_Log_In_ASP.NET.Models;

namespace Web_Log_In_ASP.NET.Data
{
    public class Web_Log_In_ASPNETContext : DbContext
    {
        public Web_Log_In_ASPNETContext (DbContextOptions<Web_Log_In_ASPNETContext> options)
            : base(options)
        {
        }

        public DbSet<Web_Log_In_ASP.NET.Models.User> User { get; set; }
    }
}
