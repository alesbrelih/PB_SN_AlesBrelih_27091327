using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.Models;
using System.ComponentModel;

namespace PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels
{
    public class NajemView : INotifyPropertyChanged
    {
        #region privates
        private PodjetjeView _podjetje;
        private ProstorView _prostor;
        private DateTime _zacetni;
        private DateTime _koncni;
        #endregion


        #region props
        public int Id { get; set; }
        public PodjetjeView Podjetje
        {
            get { return _podjetje; }
            set
            {
                _podjetje = value;
                RaisePropertyChanged("Podjetje");
                RaisePropertyChanged("Izpis");
            }
        }
        public ProstorView Prostor
        {
            get { return _prostor; }
            set { _prostor = value;
            RaisePropertyChanged("Prostor");
            }
        }
        public DateTime Zacetni
        {
            get { return _zacetni; }
            set
            {
                _zacetni = value;
                RaisePropertyChanged("Zacetni");
                RaisePropertyChanged("Izpis");
                RaisePropertyChanged("ZacetniIzpis");
            }
        }
        public DateTime Koncni
        {
            get { return _koncni; }
            set
            {
                _koncni = value;
                RaisePropertyChanged("Koncni");
                RaisePropertyChanged("Izpis");
                RaisePropertyChanged("KoncniIzpis");
            }
        }


        //pomožne lastnosti za izpis podatkov o najemu
        public string ZacetniIzpis { get { return Zacetni.ToShortDateString(); } }
        public string KoncniIzpis { get { return Koncni.ToShortDateString(); } }

        public string Izpis { get { return Podjetje.ImePodjetja + " : " + Zacetni.ToShortDateString() + " - " + Koncni.ToShortDateString(); } }
        #endregion
        public NajemView(Najem najem)
        {
            Id = najem.NajemID;
            Podjetje = new PodjetjeView(najem.Podjetje);
            Prostor = new ProstorView(najem.PoslovniProstor);
            Zacetni = najem.ZacetekNajema;
            Koncni = najem.KonecNajema;
        }
        public NajemView()
        {
            Zacetni = DateTime.Now;
            Koncni = DateTime.Now.AddDays(1);
        }

        #region Inotify
        private void RaisePropertyChanged(string propertyName)
        {
            // take a copy to prevent thread issues
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
    public class NajemViewMain
    {


        public int NajemId { get; set; }



        public string ImePodjetja { get; set; }
        public string KontaktnaOseba { get; set; }
        public DateTime ZacetekNajema { get; set; }
        public DateTime KonecNajema { get; set; }
        public string ImeProstora { get; set; }


        public Najem Najem { get; set; }

        public NajemViewMain(Najem najem)
        {
            NajemId = najem.NajemID;
            ImePodjetja = najem.Podjetje.ImePodjetja;
            KontaktnaOseba = najem.Podjetje.KontaktnaOseba.Ime + " " + najem.Podjetje.KontaktnaOseba.Priimek;
            ZacetekNajema = najem.ZacetekNajema;
            KonecNajema = najem.KonecNajema;
            ImeProstora = najem.PoslovniProstor.ImeProstora;
        }
    }
}
