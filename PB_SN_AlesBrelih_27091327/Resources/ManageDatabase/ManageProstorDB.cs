﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.Models;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels;
using PB_SN_AlesBrelih_27091327.Windows.MessageWindows;

namespace PB_SN_AlesBrelih_27091327.Resources.ManageDatabase
{
    public static class ManageProstorDB
    {
        internal static System.Collections.ObjectModel.ObservableCollection<Data.ContextData.ViewModels.ProstorView> VrniVseProstore()
        {
            var list = new ObservableCollection<ProstorView>();
            using (var db = new PBDB())
            {
                db.VsiPoslovniProstori.ToList().ForEach(prostor=>list.Add(new ProstorView(prostor)));
            }
            return list;

        }

        internal static void UrediProstor(ProstorView prostor)
        {
            using (var db = new PBDB())
            {
                var prostorBaza = db.VsiPoslovniProstori.Find(prostor.Id);
                prostorBaza.ImeProstora = prostor.ImeProstora;
                prostor.DnevnaCena = prostor.DnevnaCena;

                db.Entry(prostorBaza).State = EntityState.Modified;
                db.SaveChanges();



            }
        }

        internal static void IzbrisiProstor(ProstorView prostor)
        {
            using (var db = new PBDB())
            {
                var prostorBaza = db.VsiPoslovniProstori.Find(prostor.Id);
                db.VsiPoslovniProstori.Remove(prostorBaza);
                db.VsiNajemi.Where(najem=>najem.PoslovniProstor.PoslovniProstorID==prostor.Id).ToList().ForEach(najem=>db.VsiNajemi.Remove(najem));
                db.SaveChanges();
            }
        }

        internal static void UstvariProstor(ProstorView prostor)
        {
            using (var db = new PBDB())
            {
                try
                {
                    var prostorDb = new PoslovniProstor()
                    {
                        ImeProstora = prostor.ImeProstora,
                        DnevnaCena = prostor.DnevnaCena
                    };
                    db.VsiPoslovniProstori.Add(prostorDb);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    var warningWindow = new WarningWindow("Napaka v povezavi z bazo");
                    warningWindow.Show();
                }
            }
        }
    }
}
