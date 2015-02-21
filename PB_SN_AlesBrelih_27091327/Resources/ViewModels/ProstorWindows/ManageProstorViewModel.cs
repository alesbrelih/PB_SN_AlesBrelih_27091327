using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using PB_SN_AlesBrelih_27091327.Resources.Data;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels;
using PB_SN_AlesBrelih_27091327.Resources.ManageDatabase;
using PB_SN_AlesBrelih_27091327.Windows.MessageWindows;

namespace PB_SN_AlesBrelih_27091327.Resources.ViewModels.ProstorWindows
{
    public class ManageProstorViewModel:INotifyPropertyChanged
    {
        private ProstorView _izbraniProstor;

        #region props

        public ProstorView IzbraniProstor
        {
            get
            {
                return _izbraniProstor;
            }
            set
            {
                _izbraniProstor = value;
                RaisePropertyChanged("IzbraniProstor");       
            }
        }

        public ObservableCollection<ProstorView> VsiProstori { get; set; }
        public Enums.ActionState ActionState { get; set; }

        public ComboBox VsiProstoriComboBox { get; set; }

        #endregion



        #region constr

        public ManageProstorViewModel(ProstorView prostor, Enums.ActionState action, ObservableCollection<ProstorView> prostorList = null, ComboBox cBox = null)
        {
            IzbraniProstor = prostor;
            ActionState = action;
            VsiProstori = prostorList;
            VsiProstoriComboBox = cBox;
        }
        #endregion




        internal void SaveChanges()
        {
            if (ActionState == Enums.ActionState.Edit)
            {
                var dialogWindow = new DialogWindows("Shranim spremembe?");
                dialogWindow.ShowDialog();
                if (dialogWindow.DialogResult.HasValue && dialogWindow.DialogResult.Value)
                {
                    try
                    {
                        ManageProstorDB.UrediProstor(IzbraniProstor);
                    }
                    catch (Exception ex)
                    {

                        var errorWindow = new WarningWindow(ex.Message);
                        errorWindow.ShowDialog();
                    }
                }
            }
            if (ActionState == Enums.ActionState.Delete)
            {
                var dialogWindow = new DialogWindows("Izbrisem prostor?");
                dialogWindow.ShowDialog();
                if (dialogWindow.DialogResult.HasValue && dialogWindow.DialogResult.Value)
                {
                    try
                    {
                        ManageProstorDB.IzbrisiProstor(IzbraniProstor);
                        var prostorView = VsiProstori.First(prostor => prostor.Id == IzbraniProstor.Id);
                        VsiProstoriComboBox.SelectedIndex = -1;
                        VsiProstori.Remove(prostorView);
                        //TODO:REMOVE FROM LIST UPDATE STUFF DO STUDFF in CE OBSTAJAJO NAJEMI S TEM PROSTOROM DIALOG WINDOW DELETE?

                    }
                    catch (Exception ex)
                    {
                        var errorWindow = new WarningWindow(ex.Message);
                        errorWindow.Show();
                    }
                }
            }
            if (ActionState == Enums.ActionState.Create)
            {
                var dialogWindow = new DialogWindows("Ustvarim prostor");
                dialogWindow.ShowDialog();
                if (dialogWindow.DialogResult.HasValue && dialogWindow.DialogResult.Value)
                {
                    try
                    {
                        ManageProstorDB.UstvariProstor(IzbraniProstor);
                    }
                    catch (Exception ex)
                    {
                        var errorWindow = new WarningWindow(ex.Message);
                        errorWindow.Show();
                       
                    }
                }
            }
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
}
