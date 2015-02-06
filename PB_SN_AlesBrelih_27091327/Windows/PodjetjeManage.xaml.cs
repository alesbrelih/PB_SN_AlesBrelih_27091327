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
    /// Interaction logic for PodjetjeManage.xaml
    /// </summary>
    public partial class PodjetjeManage : Window
    {
        private ManagePodjetjeViewModel _viewModel;
        public PodjetjeManage(Enums.ActionState Action=Enums.ActionState.Create, PodjetjeView podjetje=null)
        {
            InitializeComponent();
            _viewModel = new ManagePodjetjeViewModel(Action,podjetje);
            _viewModel.NastaviComboBox(CBoxKontaktnaOseba);
            this.DataContext = _viewModel;
        }

       

        private void PodjetjeManage_OnMouseDown(object sender, MouseButtonEventArgs e)
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

        private void BtnSave_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.SaveChanges();
            this.DialogResult = true;
            this.Close();

        }

        private void CBoxKontaktnaOseba_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _viewModel.SpremeniIzbranoKontaktno(int.Parse(CBoxKontaktnaOseba.SelectedValue.ToString()));
        }
    }
}
