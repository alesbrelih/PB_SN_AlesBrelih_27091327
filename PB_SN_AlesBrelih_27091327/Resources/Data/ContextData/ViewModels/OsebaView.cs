using System.ComponentModel;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels
{
    public class OsebaView:INotifyPropertyChanged

{


    private int _id;
    private string _ime;
    private string _priimek;
    private string _email;
    private string _telefon;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                RaisePropertyChanged("Id");
            }
        }

        public string Ime
        {
            get
            {
                return _ime;
            }
            set
            {
                _ime = value;
                RaisePropertyChanged("Ime");
                RaisePropertyChanged("Izpis");
            }
        }

        public string Priimek
        {
            get
            {
                return _priimek;
            }
            set
            {
                _priimek = value;
                RaisePropertyChanged("Priimek");
                RaisePropertyChanged("Izpis");
            }
        }

        public string EMail
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                RaisePropertyChanged("Email");
            }
        }

        public string Telephone
        {
            get
            {
                return _telefon;
            }
            set
            {
                _telefon = value;
                RaisePropertyChanged("Telefon");
            }
        }

        public string Izpis { get { return Ime +" "+ Priimek; } }

    public ObservableCollection<Podjetje> VsaPodjetja { get; set; }

    public OsebaView()
    {
        VsaPodjetja = new ObservableCollection<Podjetje>();
    }


    public OsebaView(Oseba oseba) : this()
    {
        Id = oseba.OsebaID;
        Ime = oseba.Ime;
        Priimek = oseba.Priimek;
        EMail = oseba.Email;
        Telephone = oseba.Telefon;
        if (oseba.VsaPodjetja != null)
        {
            oseba.VsaPodjetja.ToList().ForEach(podjetje => VsaPodjetja.Add(podjetje));
        }
    }


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
}
}
