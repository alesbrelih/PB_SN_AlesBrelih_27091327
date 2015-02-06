using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.Models;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels;

namespace PB_SN_AlesBrelih_27091327.Resources.ManageDatabase
{
    public static class ManagePodjetjeDB
    {
        public static ObservableCollection<PodjetjeView> VrniVsaPodjetja()
        {
            var list = new ObservableCollection<PodjetjeView>();
            try
            {
                using (var db = new PBDB())
                {
                    db.VsaPodjetja.ToList().ForEach(x => list.Add(new PodjetjeView(x)));
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Napaka v povezavi z bazo");
            }
        }

        internal static void UstvariPodjetje(PodjetjeView Podjetje)
        {
            try
            {
                using (var db = new PBDB())
                {
                    db.VsaPodjetja.Add(
                        new Podjetje
                    {
                        ImePodjetja = Podjetje.ImePodjetja,
                        KontaktnaOseba =  Podjetje
                    });
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                
                throw new Exception("Napaka v povezavi z bazo");
            }
            
        }

        internal static void UrediPodjetje(PodjetjeView Podjetje)
        {
            try
            {
                using (var db = new PBDB())
                {
                    var izbranoPodjetje = db.VsaPodjetja.Find(Podjetje.Id);
                    izbranoPodjetje.ImePodjetja = Podjetje.ImePodjetja;
                    izbranoPodjetje.KontaktnaOseba=new Oseba(Podjetje.KontaktnaOseba);
                    db.Entry(izbranoPodjetje).State=EntityState.Modified;
                    
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Napaka v povezavi z bazo");
            }
        }

        internal static void IzbrisiPodjetje(PodjetjeView Podjetje)
        {
            try
            {
                using (var db = new PBDB())
                {
                    var izbranoPodjetje = db.VsaPodjetja.Find(Podjetje.Id);
                    db.VsaPodjetja.Remove(izbranoPodjetje);

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Napaka v povezavi z bazo");
            }
        }
    }
}
