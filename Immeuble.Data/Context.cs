using Immeuble.Data.Configurations;
using Immeuble.Data.CustomConventions;
using Immeuble.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immeuble.Data
{
    public class Context : DbContext 
    {
        public Context():base("name=ImmeubleChaine")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new OptionConfiguration());
            modelBuilder.Conventions.Add(new IdConvention());
            modelBuilder.Conventions.Add(new DateTime2Convention());
            
        }

        public DbSet<Option> Options { get; set; }
        public DbSet<Bungalow> Bungalows { get; set; }
        public DbSet<Locataire> Locataires { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
    }
}
