using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.Models;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels;
using PB_SN_AlesBrelih_27091327.Resources.ManageDatabase;

namespace PB_SN_AlesBrelih_27091327.Resources.ViewModels
{
    public class MainWindowViewModel:INotifyPropertyChanged
    {
        private ObservableCollection<NajemViewMain> _vsiNajemi;


        public ObservableCollection<NajemViewMain> VsiNajemi
        {
            get { return _vsiNajemi; }
            set { _vsiNajemi = value; }
        }

        public MainWindowViewModel()
        {
            VsiNajemi = ManageNajemDB.VrniNajemeForMainWindow();
            
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
                }
            }.ForEach(x => ManageNajemDB.NovNajem(x));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
