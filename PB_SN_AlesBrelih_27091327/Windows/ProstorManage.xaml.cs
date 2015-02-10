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
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels;
using PB_SN_AlesBrelih_27091327.Resources.ViewModels.ProstorWindows;

namespace PB_SN_AlesBrelih_27091327.Windows
{
    /// <summary>
    /// Interaction logic for ProstorManage.xaml
    /// </summary>
    public partial class ProstorManage : Window
    {

        private ManageProstorViewModel _viewModel;
        public ProstorManage(ProstorView prostor, Enums.ActionState action)
        {
            InitializeComponent();
            _viewModel = new ManageProstorViewModel(prostor, action);
            this.DataContext = _viewModel;
            NastaviOkno(action);
        }

        private void NastaviOkno(Enums.ActionState action)
        {
            if (action == Enums.ActionState.Delete)
            {
                TBoxDnevnaCena.IsEnabled = false;
                TBoxImePodjetja.IsEnabled = false;
                BtnShrani.Content = "Izbrisi";
                BtnIzhod.Visibility = Visibility.Hidden;
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
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

        private void BtnShrani_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.SaveChanges();
        }

        private void BtnIzhod_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
