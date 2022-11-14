using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCMB.DataAccesLayer.Configurations;
using TCMB.EntityLayer.Concrate;

namespace TCMB.DataAccesLayer.Contexts
{
    public class TCMBContext:DbContext
    {
        public TCMBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasIndex(a => a.currencyName).IsUnique();
        }

        

        public DbSet<Currency> Currencies { get; set; }

    }
}
