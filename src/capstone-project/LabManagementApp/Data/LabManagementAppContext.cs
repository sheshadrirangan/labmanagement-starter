using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LabManagementApp.Models;

namespace LabManagementApp.Data
{
    public class LabManagementAppContext : DbContext
    {
        public LabManagementAppContext (DbContextOptions<LabManagementAppContext> options)
            : base(options)
        {
        }

        public DbSet<LabManagementApp.Models.Category> Category { get; set; }

        public DbSet<LabManagementApp.Models.Author> Author { get; set; }

        public DbSet<LabManagementApp.Models.Lab> Lab { get; set; }
    }
}
