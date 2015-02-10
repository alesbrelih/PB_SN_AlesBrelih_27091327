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
using PB_SN_AlesBrelih_27091327.Windows.MessageWindows;

namespace PB_SN_AlesBrelih_27091327.Resources.ViewModels.PodjetjeWindows
{
    public class ManagePodjetjeViewModel : INotifyPropertyChanged
    {

        private OsebaView _trenutnaKontaktna;
        private PodjetjeView _podjetje;

        public OsebaView TrenutnaKontaktna
        {
            get
            {
                return _trenutnaKontaktna;
            }
            set
            {
                _trenutnaKontaktna = value;
                RaisePropertyChanged("TrenutnaKontaktna");
            }
        }

        public PodjetjeView Podjetje
        {
            get
            {
                return _podjetje;
            }
            set
            {
                _podjetje = value;
                RaisePropertyChanged("Podjetje");
            }
        }

        public ObservableCollection<OsebaView> VseOsebe { get; set; }

        public Enums.ActionState ActionState { get; set; }

        public ManagePodjetjeViewModel(Data.Enums.ActionState Action, PodjetjeView podjetje, ObservableCollection<OsebaView> vseOsebe)
        {
            Podjetje = podjetje ?? new PodjetjeView();
            VseOsebe = vseOsebe==null?ManageOsebaDB.VrniVseOsebe():vseOsebe;
            TrenutnaKontaktna = Podjetje.KontaktnaOseba;
            ActionState = Action;
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
        private Data.Enums.ActionState Action;

        #endregion    }

        internal void SaveChanges()
        {
            if (ActionState == Enums.ActionState.Create)
            {
                var confirmationWindow = new DialogWindows("Ali ste prepricani da zelite ustvariti to podjetje?");
                confirmationWindow.ShowDialog();
                if (confirmationWindow.DialogResult.HasValue && confirmationWindow.DialogResult.Value)
                {
                    //TRY CATCH
                    ManagePodjetjeDB.UstvariPodjetje(Podjetje);
                }
                
            }
            if (ActionState == Enums.ActionState.Edit)
            {
                var confirmationWindow = new DialogWindows("Shrani spremembe?");
                confirmationWindow.ShowDialog();
                if (confirmationWindow.DialogResult.HasValue && confirmationWindow.DialogResult.Value)
                {
                    ManagePodjetjeDB.UrediPodjetje(Podjetje);
                    Podjetje.KontaktnaOseba = TrenutnaKontaktna;
                }
            }

            if (ActionState == Enums.ActionState.Delete)
            {
                var confirmationWindow = new DialogWindows("Shrani spremembe?");
                confirmationWindow.ShowDialog();
                if (confirmationWindow.DialogResult.HasValue && confirmationWindow.DialogResult.Value)
                {
                    ManagePodjetjeDB.IzbrisiPodjetje(Podjetje);
                }
                
            }
        }

        internal void SpremeniIzbranoKontaktno(int id)
        {
            if (id == -1)
            {
                TrenutnaKontaktna = null;
            }
            else
            {
                TrenutnaKontaktna = VseOsebe.First(x => x.Id == id);
            }
        }

        internal void NastaviComboBox(System.Windows.Controls.ComboBox CBoxKontaktnaOseba)
        {
            CBoxKontaktnaOseba.DisplayMemberPath = "Izpis";
            CBoxKontaktnaOseba.SelectedValuePath = "Id";
            if(TrenutnaKontaktna!=null)
                CBoxKontaktnaOseba.SelectedValue = TrenutnaKontaktna.Id;
        }
    }
}
