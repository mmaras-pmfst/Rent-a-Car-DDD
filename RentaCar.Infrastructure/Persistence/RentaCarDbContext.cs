using Microsoft.EntityFrameworkCore;
using RentaCar.Domain.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Infrastructure.Persistence
{
    public class RentaCarDbContext : DbContext
    {
        public RentaCarDbContext(DbContextOptions<RentaCarDbContext> options)
            :base(options)
        {

        }

        public DbSet<Color> Colors { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(RentaCarDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
