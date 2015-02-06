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
    public class PodjetjeView:INotifyPropertyChanged
    {


        private string _imePodjetja;
        private OsebaView _kontaktnaOseba;


        public int Id { get; set; }

        public string ImePodjetja
        {
            get
            {
                return _imePodjetja;
            }
            set
            {
                _imePodjetja = value;
                RaisePropertyChanged("ImePodjetja");
            }
        }

        public OsebaView KontaktnaOseba
        {
            get
            {
                return _kontaktnaOseba;
            }
            set
            {
                _kontaktnaOseba = value;
                RaisePropertyChanged("KontaktnaOseba");
            }
        }

        public ObservableCollection<NajemView> VsiNajemi { get; set; }


        public PodjetjeView()
        {
            VsiNajemi=new ObservableCollection<NajemView>();
        }

        public PodjetjeView(Podjetje podjetje) : this()
        {
            Id = podjetje.PodjetjeId;
            ImePodjetja = podjetje.ImePodjetja;
            KontaktnaOseba = new OsebaView(podjetje.KontaktnaOseba);
            if (podjetje.NajemiPodjetja != null)
            {
                podjetje.NajemiPodjetja.ToList().ForEach(x=>VsiNajemi.Add(new NajemView(x)));
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
