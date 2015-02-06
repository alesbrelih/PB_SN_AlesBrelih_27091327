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
using PB_SN_AlesBrelih_27091327.Resources.ViewModels.OsebaWindows;

namespace PB_SN_AlesBrelih_27091327.Windows
{
    /// <summary>
    /// Interaction logic for OsebaMain.xaml
    /// </summary>
    public partial class OsebaMain : Window
    {
        private MainOsebaViewModel _viewModel;
        public OsebaMain()
        {
            InitializeComponent();
            _viewModel = new MainOsebaViewModel();
            this.DataContext = _viewModel;
            NastaviComboBox();
        }

        private void NastaviComboBox()
        {
            CBoxOsebe.DisplayMemberPath = "Izpis";
            CBoxOsebe.SelectedValuePath = "Id";
        }

        private void OsebaMain_OnMouseDown(object sender, MouseButtonEventArgs e)
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

        private void CBoxOsebe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(CBoxOsebe.SelectedIndex!=-1)
                _viewModel.SpremeniPrikazanoOsebo(int.Parse(CBoxOsebe.SelectedValue.ToString()));
        }

        private void LblUredi_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.UrediIzbrano();

        }

        private void BtnIzbrisi_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.IzbrisiIzbrano(CBoxOsebe);
        }

        private void BtnOK_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
