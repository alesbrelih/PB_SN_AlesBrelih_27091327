using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels;
using PB_SN_AlesBrelih_27091327.Resources.ManageDatabase;
using PB_SN_AlesBrelih_27091327.Windows;
using PB_SN_AlesBrelih_27091327.Windows.MessageWindows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActionState = PB_SN_AlesBrelih_27091327.Resources.Data.Enums.ActionState;

namespace PB_SN_AlesBrelih_27091327.Resources.ViewModels.NajemWindows
{
    public class MainNajemViewModel : INotifyPropertyChanged
    {
        #region privates
        private NajemView _trenutni;
        private bool _podatkiNajemaOmogoceni = false;
        #endregion


        #region props
        public bool PodatkiNajemaOmogoceni
        {
            get { return _podatkiNajemaOmogoceni; }
            set
            {
                _podatkiNajemaOmogoceni = value;
                RaisePropertyChanged("PodatkiNajemaOmogoceni");
            }
        }
        public ObservableCollection<NajemView> VsiNajemi { get; set; }
        public NajemView TrenutniNajem
        {
            get { return _trenutni; }
            set
            {
                _trenutni = value;
                RaisePropertyChanged("TrenutniNajem");
            }
        }


        #endregion

        #region constructor
        public MainNajemViewModel(ObservableCollection<NajemView> vsiNajemi)
        {
            VsiNajemi = vsiNajemi;
        }
        #endregion

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

        internal void NastaviTrenutniNajem(int p)
        {

            // p - selected combobbox najem index
            if (p != -1)
            {
                PodatkiNajemaOmogoceni = true;
                TrenutniNajem = VsiNajemi[p];
            }
        }

        internal void UrediProstor()
        {
            var urediProstor = new ProstorManage(TrenutniNajem.Prostor, ActionState.Edit);
            urediProstor.ShowDialog();
        }

        internal void UrediPodjetje()
        {
            var urediPodjetje = new PodjetjeManage(ActionState.Edit, TrenutniNajem);
            urediPodjetje.ShowDialog();
        }

        internal void UrediTrenutniNajem()
        {
            var urediNajem = new NajemManage(VsiNajemi,TrenutniNajem, ActionState.Edit);
            urediNajem.ShowDialog();
        }

        internal void IzbrisiTrenutniNajem(System.Windows.Controls.ComboBox CBoxNajemi)
        {
            var confirmationWindow = new DialogWindows("Želite izbrisati izbrani najem?");
            confirmationWindow.ShowDialog();
            if (confirmationWindow.DialogResult.HasValue && confirmationWindow.DialogResult.Value)
            {

                ManageNajemDB.IzbrisiNajem(TrenutniNajem);
                CBoxNajemi.SelectedIndex = -1;
                VsiNajemi.Remove(TrenutniNajem);
                TrenutniNajem = null;
            }
        }
    }
}
