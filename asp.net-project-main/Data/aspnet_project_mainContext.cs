using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using asp.net_project_main.Models;

namespace asp.net_project_main.Data
{
    public class aspnet_project_mainContext : DbContext
    {
        public aspnet_project_mainContext (DbContextOptions<aspnet_project_mainContext> options)
            : base(options)
        {
        }

        public DbSet<asp.net_project_main.Models.Category> Category { get; set; } = default!;
        public DbSet<asp.net_project_main.Models.Product> Product { get; set; } = default!;
        public DbSet<asp.net_project_main.Models.User> User { get; set; } = default!;
    }
}
