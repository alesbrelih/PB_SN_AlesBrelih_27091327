using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using PB_SN_AlesBrelih_27091327.Resources.Data;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels;
using PB_SN_AlesBrelih_27091327.Resources.ManageDatabase;
using PB_SN_AlesBrelih_27091327.Windows;
using PB_SN_AlesBrelih_27091327.Windows.MessageWindows;

namespace PB_SN_AlesBrelih_27091327.Resources.ViewModels.PodjetjeWindows
{
    public class MainPodjetjeViewModel:INotifyPropertyChanged
    {

        #region privates
        private PodjetjeView _trenutnoPodjetje;
        private OsebaView _trenutnaKontaktna;
        private bool _podatkiPodjetjaOmogoceni = false;
        #endregion

        #region props
        public bool PodatkiPodjetjaOmogoceni { get { return _podatkiPodjetjaOmogoceni; } set { _podatkiPodjetjaOmogoceni = value;
        RaisePropertyChanged("PodatkiPodjetjaOmogoceni");
        }
        }
        public PodjetjeView IzbranoPodjetje
        {
            get
            {
                return _trenutnoPodjetje;
            }
            set
            {
                _trenutnoPodjetje = value;
                RaisePropertyChanged("IzbranoPodjetje");
            }
        }

        public OsebaView TrenutnaKontaktna
        {
            get { return _trenutnaKontaktna; }

            set
            {
                _trenutnaKontaktna = value;

                RaisePropertyChanged("TrenutnaKontaktna");
            }
        }

        public ObservableCollection<PodjetjeView> VsaPodjetja { get; set; }
        public ObservableCollection<OsebaView> VseOsebe { get; set; }

        #endregion


        public MainPodjetjeViewModel()
        {
            VsaPodjetja = ManagePodjetjeDB.VrniVsaPodjetja();
            VseOsebe = ManageOsebaDB.VrniVseOsebe();
        }


        #region inotify
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

        internal void NastaviIzbranoPodjetje(int p)
        {
            PodatkiPodjetjaOmogoceni = true;
            IzbranoPodjetje = VsaPodjetja.First(x => x.Id == p);
            TrenutnaKontaktna = IzbranoPodjetje.KontaktnaOseba;
        }

        internal void UrediKontaktnaOsebo()
        {
            var urediOsebo = new OsebaManage(TrenutnaKontaktna, Enums.ActionState.Edit);
            urediOsebo.ShowDialog();

            if (urediOsebo.DialogResult.HasValue && urediOsebo.DialogResult.Value)
            {
                var successMessage = new WarningWindow("Oseba je bila uspesno shranjena.");
                successMessage.ShowDialog();
            }

        }

        internal bool UrediPodjetje()
        {
            var urediPodjetje = new PodjetjeManage(Enums.ActionState.Edit, IzbranoPodjetje, VseOsebe);
            urediPodjetje.ShowDialog();

            if (urediPodjetje.DialogResult.HasValue && urediPodjetje.DialogResult.Value)
            {
                return true;
            }
            TrenutnaKontaktna = IzbranoPodjetje.KontaktnaOseba;
            return false;
        }

        internal void IzbrisiPodjetje(ComboBox cBox)
        {
            var confirmationWindow = new DialogWindows("Izbrišem podjetje?");
            confirmationWindow.ShowDialog();
            if(confirmationWindow.DialogResult.HasValue&&confirmationWindow.DialogResult.Value)
            {
                ManagePodjetjeDB.IzbrisiPodjetje(IzbranoPodjetje);
            }

        }
    }
}
