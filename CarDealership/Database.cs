using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealership.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CarDealership
{
    internal class Database : DbContext
    {

        public DbSet<Car>? Cars { get; set; }
        public DbSet<Insurance>? Insurances { get; set; }
        public DbSet<Installment>? InsuranceInstallments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder builder = new();

            builder.DataSource = ".";
            builder.InitialCatalog = "CarDealership";
            builder.IntegratedSecurity = true;
            builder.TrustServerCertificate = true;
            builder.MultipleActiveResultSets = true;
            builder.ConnectTimeout = 3;

            string? connection = builder.ConnectionString;

            optionsBuilder.UseSqlServer(connection);
        }
    }
}
