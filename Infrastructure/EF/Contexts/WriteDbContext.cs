using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Entities;
using Domain.ValueObjects;

using Infrastructure.EF.Config;

using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF.Contexts
{
    internal sealed class WriteDbContext : DbContext
    {
        public DbSet<TravelerCheckList> TravelerCheckLists { get; set; }




        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TravelerCheckList");

            var configuration = new WriteConfiguration();
            modelBuilder.ApplyConfiguration<TravelerCheckList>(configuration);
            modelBuilder.ApplyConfiguration<TravelerItem>(configuration);
        }
    }
}
