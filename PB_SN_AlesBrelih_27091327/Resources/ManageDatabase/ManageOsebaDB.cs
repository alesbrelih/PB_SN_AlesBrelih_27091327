using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.Models;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using XObservableCollection = PB_SN_AlesBrelih_27091327.Resources.Data.TrullyObservableCollection;
using System.Threading.Tasks;

namespace PB_SN_AlesBrelih_27091327.Resources.ManageDatabase
{
    public static class ManageOsebaDB
    {
        public static OsebaView VrniOsebo(int? id)
        {
            using (var db = new PBDB())
            {
                return new OsebaView(db.VseOsebe.Find(id));
            }
        }

        public static ObservableCollection<OsebaView> VrniVseOsebe()
        {
            ObservableCollection<OsebaView> listOseb =
                new ObservableCollection<OsebaView>();
            using (var db = new PBDB())
            {
                db.VseOsebe.ToList().ForEach(oseba => listOseb.Add(new OsebaView(oseba)));
            }
            return listOseb;
        }

        

        internal static void UrediOsebo(OsebaView oseba)
        {
            using(var db = new PBDB())
            {
                try
                {
                    var obstojecaOseba = db.VseOsebe.Find(oseba.Id);
                    obstojecaOseba.OsebaID = oseba.Id;
                    obstojecaOseba.Ime = oseba.Ime;
                    obstojecaOseba.Priimek = oseba.Priimek;
                    obstojecaOseba.Telefon = oseba.Telephone;
                    obstojecaOseba.Email = oseba.EMail;

                    db.Entry(obstojecaOseba).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                catch
                {
                    throw new Exception("Osebe ni v bazi / Tezava s povezavo do baze");
                }
                
            }
        }

        internal static void UstvariOsebo(OsebaView Oseba)
        {
            using (var db = new PBDB())
            {
                try
                {
                    var osebaEntry = new Oseba(Oseba);
                    db.VseOsebe.Add(osebaEntry);
                    db.SaveChanges();
                }
                catch
                {
                    throw new Exception("Napaka v povezavi do base");
                }
            }
        }

        internal static void IzbrisiOsebo(OsebaView Oseba)
        {
            using (var db = new PBDB())
            {
                try
                {
                    var tbdOseba = db.VseOsebe.Remove(db.VseOsebe.Find(Oseba.Id));
                    db.SaveChanges();

                }
                catch
                {
                    throw new Exception("Napaka v povezavi do baze");
                }
            }
        }
    }
}
