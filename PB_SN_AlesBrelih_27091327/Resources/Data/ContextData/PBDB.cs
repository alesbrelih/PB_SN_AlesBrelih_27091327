using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.Models;

namespace PB_SN_AlesBrelih_27091327.Resources.Data.ContextData
{
    public class PBDB:DbContext
    {

        public PBDB():base("PBSN")
        {
            
        }

        public DbSet<Najem> VsiNajemi { get; set; }

        public DbSet<Oseba> VseOsebe { get; set; }

        public DbSet<Podjetje> VsaPodjetja { get; set; }

        public DbSet<PoslovniProstor> VsiPoslovniProstori { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
