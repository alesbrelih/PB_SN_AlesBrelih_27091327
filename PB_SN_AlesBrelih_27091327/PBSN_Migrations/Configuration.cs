using System.Collections.Generic;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.Models;

namespace PB_SN_AlesBrelih_27091327.PBSN_Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.PBDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"PBSN_Migrations";
        }

        protected override void Seed(PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.PBDB context)
        {

            new List<Najem>()
            {
                new Najem()
                {
                    Podjetje = new Podjetje()
                    {
                        ImePodjetja = "KrageljDOO",
                        KontaktnaOseba = new Oseba()
                        {
                            Ime = "Jozica",
                            Priimek = "Kragelj",
                            Email = "Jozica.Kragelj@Postojna.si",
                            Telefon = "0808888"
                        }
                    },
                    ZacetekNajema = DateTime.Now,
                    KonecNajema = DateTime.Now.AddMonths(1),
                    PoslovniProstor = new PoslovniProstor()
                    {
                        ImeProstora = "Celovska 138",
                        DnevnaCena = 135
                    }
                }
            }.ForEach(x=>context.VsiNajemi.Add(x));
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
