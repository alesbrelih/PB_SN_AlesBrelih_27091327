using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_SN_AlesBrelih_27091327.Resources.ViewModels.MessageWindows
{
    public class WarningWindowViewModel:INotifyPropertyChanged
    {

        private string _messageLabel;

        public string MessageLabel
        {
            get
            {
                return _messageLabel;
            }
            set
            {
                _messageLabel = value;
                RaisePropertyChanged("MessageLabel");
            }
        }

        public WarningWindowViewModel(string message)
        {
            MessageLabel = message;
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
    }
}
