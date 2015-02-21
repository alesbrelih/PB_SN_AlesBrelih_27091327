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

        internal static void NovNajem(Najem x)
        {
            using (var db = new PBDB())
            {
                db.VsiNajemi.Add(x);
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
    }
}
