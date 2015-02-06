using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PB_SN_AlesBrelih_27091327.Resources.Data;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels;
using PB_SN_AlesBrelih_27091327.Resources.ManageDatabase;
using PB_SN_AlesBrelih_27091327.Windows;
using PB_SN_AlesBrelih_27091327.Windows.MessageWindows;

namespace PB_SN_AlesBrelih_27091327.Resources.ViewModels.PodjetjeWindows
{
    public class MainPodjetjeViewModel:INotifyPropertyChanged
    {


        private PodjetjeView _trenutnoPodjetje;

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

        public ObservableCollection<PodjetjeView> VsaPodjetja { get; set; }


        public MainPodjetjeViewModel()
        {
            VsaPodjetja = ManagePodjetjeDB.VrniVsaPodjetja();
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
            IzbranoPodjetje = VsaPodjetja.First(x => x.Id == p);
        }

        internal void UrediKontaktnaOsebo()
        {
            var urediOsebo = new OsebaManage(IzbranoPodjetje.KontaktnaOseba, Enums.ActionState.Edit);
            urediOsebo.ShowDialog();

            if (urediOsebo.DialogResult.HasValue && urediOsebo.DialogResult.Value)
            {
                var successMessage = new WarningWindow("Oseba je bila uspesno shranjena.");
                successMessage.ShowDialog();
            }

        }

        internal void UrediPodjetje()
        {
            var urediPodjetje = new PodjetjeManage(Enums.ActionState.Edit, IzbranoPodjetje);
            urediPodjetje.ShowDialog();

            if (urediPodjetje.DialogResult.HasValue && urediPodjetje.DialogResult.Value)
            {
                //SHRANI IN PREVERI ALI...BACKUP NRD
            }
        }
    }
}
