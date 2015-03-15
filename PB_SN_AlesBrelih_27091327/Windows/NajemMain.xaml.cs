using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels;
using PB_SN_AlesBrelih_27091327.Resources.ViewModels.NajemWindows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PB_SN_AlesBrelih_27091327.Windows
{
    /// <summary>
    /// Interaction logic for NajemMain.xaml
    /// </summary>
    public partial class NajemMain : Window
    {

        private MainNajemViewModel _viewModel;

        public NajemMain(ObservableCollection<NajemView> vsiNajemi)
        {
            InitializeComponent();

            _viewModel = new MainNajemViewModel(vsiNajemi);
            this.DataContext = _viewModel;

            NastaviComboBoxe();
        }

        private void NastaviComboBoxe()
        {
            CBoxNajemi.SelectedValuePath = "Id";
            CBoxNajemi.DisplayMemberPath = "Izpis";
            
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }


        private void BtnUrediProstor_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.UrediProstor();
        }

        private void BtnUrediPodjetje_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.UrediPodjetje();
        }

        private void BtnUrediNajem_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.UrediTrenutniNajem();
        }

        private void BtnIzbrisiNajem_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.IzbrisiTrenutniNajem(CBoxNajemi);
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void CBoxNajemi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _viewModel.NastaviTrenutniNajem(CBoxNajemi.SelectedIndex);
        }
    }
}
