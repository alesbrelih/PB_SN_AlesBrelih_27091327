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
using PB_SN_AlesBrelih_27091327.Resources.ViewModels.PodjetjeWindows;

namespace PB_SN_AlesBrelih_27091327.Windows
{
    /// <summary>
    /// Interaction logic for PodjetjeMain.xaml
    /// </summary>
    public partial class PodjetjeMain : Window
    {

        private MainPodjetjeViewModel _viewModel;
        public PodjetjeMain()
        {
            InitializeComponent();
            _viewModel = new MainPodjetjeViewModel();
            this.DataContext = _viewModel;
            NastaviComboBox();
            
        }

        

        private void NastaviComboBox()
        {
            CBoxIzborPodjetja.SelectedValuePath = "Id";
            CBoxIzborPodjetja.DisplayMemberPath = "ImePodjetja";
        }

        private void PodjetjeMain_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnClose_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnMinimize_OnClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnOk_OnClick(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void CBoxIzborPodjetja_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CBoxIzborPodjetja.SelectedIndex != -1)
            {
                _viewModel.NastaviIzbranoPodjetje(int.Parse(CBoxIzborPodjetja.SelectedValue.ToString()));
            }
                
        }

        private void BtnUrediOsebo_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.UrediKontaktnaOsebo();
        }

        private void BtnUrediPodjetje_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.UrediPodjetje();
            
            
        }

        private void BtnIzbrisiPodjetje_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.IzbrisiPodjetje(CBoxIzborPodjetja);
        }
    }
}
