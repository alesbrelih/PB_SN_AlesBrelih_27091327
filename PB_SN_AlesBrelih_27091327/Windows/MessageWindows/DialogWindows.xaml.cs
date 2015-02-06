using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PB_SN_AlesBrelih_27091327.Resources.Data;
using PB_SN_AlesBrelih_27091327.Resources.ViewModels.MessageWindows;

namespace PB_SN_AlesBrelih_27091327.Windows.MessageWindows
{
    /// <summary>
    /// Interaction logic for DialogWindows.xaml
    /// </summary>
    public partial class DialogWindows : Window
    {
        private DialogWindowViewModel _viewModel;
        public DialogWindows(string message=null)
        {
            InitializeComponent();
            _viewModel=new DialogWindowViewModel(message);
            this.DataContext = _viewModel;
        }

        private void DialogWindows_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void BtnClose_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnMinimize_OnClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnYes_OnClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void BtnNo_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
