using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.Models;

namespace PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels
{
    public class ProstorView : INotifyPropertyChanged
    {
        #region private
        private int _id;
        private string _imeProstora;
        private int _dnevnaCena;
        #endregion


        #region props
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                RaisePropertyChanged("Id");
            }
        }

        public string ImeProstora
        {
            get
            {
                return _imeProstora;
            }
            set
            {
                _imeProstora = value;
                RaisePropertyChanged("ImeProstora");
            }
        }

        public int DnevnaCena
        {
            get { return _dnevnaCena; }
            set
            {
                _dnevnaCena = value;
                RaisePropertyChanged("DnevnaCena");
            }
        }

        public ObservableCollection<NajemView> VsiNajemi { get; set; }
        #endregion

        public ProstorView()
        {
            VsiNajemi = new ObservableCollection<NajemView>();
        }

        public ProstorView(PoslovniProstor prostor):this()
        {
            Id = prostor.PoslovniProstorID;
            ImeProstora = prostor.ImeProstora;
            DnevnaCena = prostor.DnevnaCena;
            if (prostor.VsiNajemi != null)
            {
                prostor.VsiNajemi.ToList().ForEach(najem=>VsiNajemi.Add(new NajemView(najem)));
            }
        }



        #region INotify
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
}
