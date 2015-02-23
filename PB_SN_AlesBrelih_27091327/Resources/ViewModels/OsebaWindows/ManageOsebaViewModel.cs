using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels;
using PB_SN_AlesBrelih_27091327.Resources.ManageDatabase;
using PB_SN_AlesBrelih_27091327.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PB_SN_AlesBrelih_27091327.Windows.MessageWindows;
using ActionState = PB_SN_AlesBrelih_27091327.Resources.Data.Enums.ActionState;

namespace PB_SN_AlesBrelih_27091327.Resources.ViewModels.OsebaWindows
{
    public class ManageOsebaViewModel : INotifyPropertyChanged
    {

        private OsebaView _oseba;
        public ActionState WindowAction { get; set; }

        public OsebaView Oseba
        {
            get { return _oseba; }
            set
            {

                _oseba = value;
                RaisePropertyChanged("Oseba");
            }
        }
        public ManageOsebaViewModel(OsebaManage _window = null, OsebaView oseba = null, ActionState Action = ActionState.Create)
        {
            if (oseba != null)
            {
                _oseba = oseba;
            }
            else
            {
                _oseba = new OsebaView();

            }
            WindowAction = Action;
            NastaviGumbe(Action,_window);

        }


        /// <summary>
        /// Nastavi potrditveni gumb na oknu
        /// </summary>
        /// <param name="Action"></param>
        /// <param name="_window"></param>
        private void NastaviGumbe(ActionState Action, OsebaManage _window)
        {
            switch(Action)
            {
                case ActionState.Create:
                    _window.BtnOk.Content="Ustvari";
                    break;
                case ActionState.Edit:
                    _window.BtnOk.Content="Uredi";
                    break;
                case ActionState.Delete:
                    _window.BtnOk.Content="Izbriši";
                    break;
            }
            _window.BtnCancel.Content = "Nazaj";
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

        internal void SaveChanges()
        {
            if(WindowAction == ActionState.Create)
            {
                try
                {
                    var dialogWindow = new DialogWindows("Ustvarim osebo?");
                    dialogWindow.ShowDialog();
                    if (dialogWindow.DialogResult.HasValue && dialogWindow.DialogResult.Value)
                    {
                        ManageOsebaDB.UstvariOsebo(Oseba);

                    }
                }
                catch(Exception ex)
                {
                    var errorWindow = new WarningWindow(ex.Message);
                    errorWindow.Show();

                }
            }
            if(WindowAction == ActionState.Edit)
            {
                try
                {
                    var acceptWindow = new DialogWindows("Ali zelite shraniti spremembe?");
                    acceptWindow.ShowDialog();
                    if (acceptWindow.DialogResult.HasValue && acceptWindow.DialogResult.Value)
                    {
                        ManageOsebaDB.UrediOsebo(Oseba);

                    }

                }
                catch(Exception ex)
                {
                    var errorWindow = new WarningWindow(ex.Message);
                    errorWindow.Show();
                }
            }
            if(WindowAction == ActionState.Delete)
            {
                try
                {
                    var acceptWindow = new DialogWindows("Ali zelite shraniti spremembe?");
                    acceptWindow.ShowDialog();
                    if (acceptWindow.DialogResult.HasValue && acceptWindow.DialogResult.Value)
                    {
                        ManageOsebaDB.IzbrisiOsebo(Oseba);

                    }
                }
                catch(Exception ex)
                {
                    var errorWindow = new WarningWindow(ex.Message);
                    errorWindow.Show();
                }
            }
            

        }
    }
}
