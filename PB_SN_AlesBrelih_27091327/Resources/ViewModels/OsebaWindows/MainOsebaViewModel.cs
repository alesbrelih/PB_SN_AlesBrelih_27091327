using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PB_SN_AlesBrelih_27091327.Resources.Data;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.Models;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels;
using PB_SN_AlesBrelih_27091327.Resources.ManageDatabase;
using PB_SN_AlesBrelih_27091327.Windows;
using XObservableCollection = PB_SN_AlesBrelih_27091327.Resources.Data.TrullyObservableCollection.TrulyObservableCollection<PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels.OsebaView>;

namespace PB_SN_AlesBrelih_27091327.Resources.ViewModels.OsebaWindows
{
    public class MainOsebaViewModel:INotifyPropertyChanged
    {
        private OsebaView _trenutnoPrikazana;
        


        public OsebaView TrenutnoPrikazana
        {
            get
            {
                return _trenutnoPrikazana;
            }
            set
            {
                _trenutnoPrikazana = value;
                RaisePropertyChanged("TrenutnoPrikazana");
                //RaisePropertyChanged("VseOsebe");
            }
        }

        public ObservableCollection<OsebaView> VseOsebe
        {
            get;
            set;
        }

        public MainOsebaViewModel()
        {
            VseOsebe = ManageOsebaDB.VrniVseOsebe();
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

        internal void SpremeniPrikazanoOsebo(int id)
        {
            TrenutnoPrikazana = VseOsebe.First(x => x.Id == id);
        }

        internal void UrediIzbrano()
        {
            var urediOsebo = new OsebaManage(TrenutnoPrikazana, Enums.ActionState.Edit);
            urediOsebo.ShowDialog();
        }

        internal void IzbrisiIzbrano()
        {
            
        }

        internal void IzbrisiIzbrano(System.Windows.Controls.ComboBox CBoxOsebe)
        {
            ManageOsebaDB.IzbrisiOsebo(TrenutnoPrikazana);
            CBoxOsebe.SelectedIndex = -1;            
            VseOsebe.Remove(TrenutnoPrikazana);
            TrenutnoPrikazana = new OsebaView();
        }
    }
}
