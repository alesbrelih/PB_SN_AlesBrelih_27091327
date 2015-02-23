using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.Models;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels;

namespace PB_SN_AlesBrelih_27091327.Resources.ManageDatabase
{
    public static class ManageNajemDB
    {
        public static ObservableCollection<NajemViewMain> VrniNajemeForMainWindow()
        {
            var listNajem = new ObservableCollection<NajemViewMain>();
            using (var db = new PBDB())
            {
                db.VsiNajemi.ToList().ForEach(x=>listNajem.Add(new NajemViewMain(x)));
            }
            return listNajem;
        }

        internal static void NovNajem(NajemView najem)
        {
            using (var db = new PBDB())
            {
                var najemDb = new Najem();
                najemDb.Podjetje = db.VsaPodjetja.Find(najem.Podjetje.Id);
                najemDb.PoslovniProstor = db.VsiPoslovniProstori.Find(najem.Prostor.Id);
                najemDb.ZacetekNajema = najem.Zacetni;
                najemDb.KonecNajema = najem.Koncni;
                db.VsiNajemi.Add(najemDb);
                db.SaveChanges();
            }
            
        }

        internal static void IzbrisiNajeme(ObservableCollection<NajemViewMain> observableCollection)
        {
            using (var db = new PBDB())
            {
                foreach (NajemViewMain najem in observableCollection)
                {
                    try
                    {
                        var najemDb = db.VsiNajemi.Find(najem.NajemId);
                        db.VsiNajemi.Remove(najemDb);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Napaka v komunikaciji z bazo");
                        throw;
                    }
                    
                }
            }
        }

        internal static void UrediNajem(NajemView Najem)
        {
            using(var db = new PBDB())
            {
                var najemDb = db.VsiNajemi.Find(Najem.Id);
                if(najemDb.Podjetje.PodjetjeId!=Najem.Podjetje.Id)
                {
                    najemDb.Podjetje = db.VsaPodjetja.Find(Najem.Podjetje.Id);
                }
                if(najemDb.PoslovniProstor.PoslovniProstorID!=Najem.Prostor.Id)
                {
                    najemDb.PoslovniProstor = db.VsiPoslovniProstori.Find(Najem.Id);
                }
                najemDb.ZacetekNajema = Najem.Zacetni;
                najemDb.KonecNajema = Najem.Koncni;
                db.SaveChanges();
            }
        }

        internal static ObservableCollection<NajemView> VrniVseNajeme()
        {
            var listNajem = new ObservableCollection<NajemView>();
            using(var db = new PBDB())
            {
                foreach(var najem in db.VsiNajemi)
                {
                    var najemView = new NajemView(najem);
                    listNajem.Add(najemView);
                }
            }
            return listNajem;
        }

        internal static void IzbrisiNajem(NajemView TrenutniNajem)
        {
            using (var db = new PBDB())
            {
                var najemDb = db.VsiNajemi.Find(TrenutniNajem.Id);
                db.VsiNajemi.Remove(najemDb);
                db.SaveChanges();
            }
        }
    }
}
