using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityCRUD.Entities;

namespace UtilityCRUD.DataAccess
{
    public class UtilityDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-C7JO21Q; Database=UtilityDb;trusted_connection=true;Encrypt=false");
        }
        public DbSet<Utility> Utilities { get; set; }
    }
}
