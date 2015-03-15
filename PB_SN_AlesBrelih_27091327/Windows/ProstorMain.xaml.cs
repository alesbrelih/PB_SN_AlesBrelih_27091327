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
using PB_SN_AlesBrelih_27091327.Resources.ViewModels.ProstorWindows;

namespace PB_SN_AlesBrelih_27091327.Windows
{
    /// <summary>
    /// Interaction logic for ProstorMain.xaml
    /// </summary>
    public partial class ProstorMain : Window
    {
        private MainProstorViewModel _viewModel;
        public ProstorMain()
        {
            InitializeComponent();
            _viewModel=new MainProstorViewModel();
            this.DataContext = _viewModel;
            NastaviComboBox();

        }

        private void NastaviComboBox()
        {
            CBoxProstori.SelectedValuePath = "Id";
            CBoxProstori.DisplayMemberPath = "ImeProstora";
        }

        private void ProstorMain_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton==MouseButton.Left)
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


        private void BtnUredi_OnClick(object sender, RoutedEventArgs e)
        {
            if (_viewModel.UrediProstor())
                this.DialogResult = true;
        }

        private void BtnIzbrisi_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.IzbrisiProstor(ref CBoxProstori);
        }

        private void BtnOk_OnClick(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void CBoxProstori_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(CBoxProstori.SelectedIndex!=-1)
                _viewModel.NastaviIzbraniProstor(int.Parse(CBoxProstori.SelectedValue.ToString()));
        }
    }
}
