﻿using System;
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

namespace PB_SN_AlesBrelih_27091327.Resources.ViewModels.ProstorWindows
{
    public class MainProstorViewModel:INotifyPropertyChanged
    {
        #region privates

        private ProstorView _prostor;

        #endregion

        #region props

        public ProstorView IzbraniProstor
        {
            get { return _prostor; }
            set
            {
                _prostor = value;
                RaisePropertyChanged("IzbraniProstor");
            }
        }

        public ObservableCollection<ProstorView> VsiProstori { get; set; } 
        #endregion




        #region constructor

        public MainProstorViewModel()
        {
            VsiProstori = ManageProstorDB.VrniVseProstore();
        }


        #endregion



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

        internal void NastaviIzbranoPodjetje(int idProstora)
        {
            IzbraniProstor = VsiProstori.First(prostor => prostor.Id == idProstora);
        }

        internal void UrediProstor()
        {
            var urediProstor = new ProstorManage(IzbraniProstor,Enums.ActionState.Edit);
            urediProstor.ShowDialog();
        }

        internal void IzbrisiProstor(ref ComboBox cBox)
        {
            var izbrisiProstor = new DialogWindows("Izbrišem prostor?");
            izbrisiProstor.ShowDialog();
            if (izbrisiProstor.DialogResult.HasValue && izbrisiProstor.DialogResult.Value)
            {
                cBox.SelectedIndex = -1;
                VsiProstori.Remove(IzbraniProstor);
                IzbraniProstor = null;
            }
            

        }
    }
}
