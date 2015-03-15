using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PB_SN_AlesBrelih_27091327.Resources.Data;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.Models;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels;
using PB_SN_AlesBrelih_27091327.Resources.ManageDatabase;
using PB_SN_AlesBrelih_27091327.Windows;
using PB_SN_AlesBrelih_27091327.Windows.MessageWindows;

namespace PB_SN_AlesBrelih_27091327.Resources.ViewModels
{
    public class MainWindowViewModel:INotifyPropertyChanged
    {



        public ObservableCollection<NajemView> VsiNajemi { get; set; }

        public MainWindowViewModel()
        {
            VsiNajemi = ManageNajemDB.VrniVseNajeme();
            
        }

        private void SetUpData()
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
                }};
            //}.ForEach(x => ManageNajemDB.NovNajem(x));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        internal void UstvariProstor()
        {
            var ustvariProstor = new ProstorManage(new ProstorView(), Enums.ActionState.Create);
            ustvariProstor.ShowDialog();
            if (ustvariProstor.DialogResult.HasValue && ustvariProstor.DialogResult.Value)
            {
                var messageWindow = new WarningWindow("Prostor uspesno ustvarjen.");
                messageWindow.ShowDialog();
            }
        }

        internal void PregledNajemov()
        {
            var pregledNajem = new NajemMain(VsiNajemi);
            pregledNajem.ShowDialog();
            //if (pregledNajem.DialogResult.HasValue && pregledNajem.DialogResult.Value)
            //{
            //    VsiNajemi.Clear();
               
            //}
        }

        internal void NovNajem()
        {
            var novNajem = new NajemManage(VsiNajemi);
            novNajem.ShowDialog();

            //if(novNajem.DialogResult.HasValue&&novNajem.DialogResult.Value)
            //{
            //    VsiNajemi = null;
            //    VsiNajemi = ManageNajemDB.VrniNajemeForMainWindow();
            //}
        }

        internal void PregledPodjetje()
        {
            var pregledPodjetje = new PodjetjeMain();
            pregledPodjetje.ShowDialog();
            if(pregledPodjetje.DialogResult.HasValue&&pregledPodjetje.DialogResult.Value)
            {
                
                VsiNajemi.Clear();
                ManageNajemDB.VrniVseNajeme().ToList().ForEach(x=>VsiNajemi.Add(x));
            }
        }

        internal void PregledOseb()
        {
            var pregledOseba = new OsebaMain();
            pregledOseba.ShowDialog();
            if(pregledOseba.DialogResult.HasValue&&pregledOseba.DialogResult.Value)
            {

                VsiNajemi.Clear();
                ManageNajemDB.VrniVseNajeme().ToList().ForEach(x => VsiNajemi.Add(x));
            }
        }

        internal void PregledProstorov()
        {
            var pregledProstorov = new ProstorMain();
            pregledProstorov.ShowDialog();
            if(pregledProstorov.DialogResult.HasValue&&pregledProstorov.DialogResult.Value)
            {
                VsiNajemi.Clear();
                ManageNajemDB.VrniVseNajeme().ToList().ForEach(x => VsiNajemi.Add(x));
            }
        }
    }
}
