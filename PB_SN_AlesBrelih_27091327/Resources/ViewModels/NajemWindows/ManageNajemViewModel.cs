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
using ActionState = PB_SN_AlesBrelih_27091327.Resources.Data.Enums.ActionState;

namespace PB_SN_AlesBrelih_27091327.Resources.ViewModels.NajemWindows
{
    public class ManageNajemViewModel : INotifyPropertyChanged
    {
        #region privates
        private NajemView _najem;
        #endregion
        #region props
        public ObservableCollection<ProstorView> VsiProstori { get; set; }
        public ObservableCollection<PodjetjeView> VsaPodjetja { get; set; }
        public NajemView Najem
        {
            get { return _najem; }
            set
            {
                _najem = value;
                RaisePropertyChanged("Najem");
            }
        }
        public ActionState ActionState { get; set; }
        #endregion

        public ManageNajemViewModel(NajemView najem = null, ActionState actionState = ActionState.Create)
        {
            if (najem == null)
            {
                Najem = new NajemView();
            }
            else
                Najem = najem;
            ActionState = actionState;
            VsaPodjetja = ManagePodjetjeDB.VrniVsaPodjetja();
            VsiProstori = ManageProstorDB.VrniVseProstore();


        }


        #region INotify
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            // take a copy to prevent thread issues
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        internal void SaveChanges()
        {
            if (ActionState == ActionState.Create)
            {
                var confirmationWindow = new DialogWindows("Ustvarim najem?");
                confirmationWindow.ShowDialog();
                if (confirmationWindow.DialogResult.HasValue && confirmationWindow.DialogResult.Value)
                {
                    ManageNajemDB.NovNajem(Najem);
                }
            }
            if(ActionState == ActionState.Edit)
            {
                var confirmationWindow = new DialogWindows("Shranim spremembe?");
                confirmationWindow.ShowDialog();
                if(confirmationWindow.DialogResult.HasValue&&confirmationWindow.DialogResult.Value)
                {
                    ManageNajemDB.UrediNajem(Najem);
                }
            }
        }

        internal void NastaviIzbranoPodjetje(int p)
        {
            if (p != -1)
                Najem.Podjetje = VsaPodjetja[p];
        }

        internal void NastaviIzbraniProstor(int p)
        {
            //TODO: IF -1 SELECTED INDEX DONT DO STUFF.
            if (p != -1)
                Najem.Prostor = VsiProstori[p];
        }
    }
}
