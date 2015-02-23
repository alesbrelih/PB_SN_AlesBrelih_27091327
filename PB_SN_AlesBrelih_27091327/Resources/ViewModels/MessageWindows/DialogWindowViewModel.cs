using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_SN_AlesBrelih_27091327.Resources.ViewModels.MessageWindows
{
    public class DialogWindowViewModel:INotifyPropertyChanged
    {
        public string MessageLabel { get; set; }
        
        public DialogWindowViewModel(string message = null)
        {
            MessageLabel = message;
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
    }
}
