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
using System.Collections.ObjectModel;

namespace PB_SN_AlesBrelih_27091327.Windows
{
    /// <summary>
    /// Interaction logic for PodjetjeManage.xaml
    /// </summary>
    public partial class PodjetjeManage : Window
    {
        private ManagePodjetjeViewModel _viewModel;
        public PodjetjeManage(Enums.ActionState Action=Enums.ActionState.Create, PodjetjeView podjetje=null, ObservableCollection<OsebaView> vseOsebe = null,ComboBox cBox=null)
        {
            InitializeComponent();
            _viewModel = new ManagePodjetjeViewModel(Action,podjetje,vseOsebe,cBox);
            _viewModel.NastaviComboBox(CBoxKontaktnaOseba);
            this.DataContext = _viewModel;
            NastaviPolja(Action);
        }

        private void NastaviPolja(Enums.ActionState action)
        {
            if(action==Enums.ActionState.Delete)
            {
                CBoxKontaktnaOseba.IsEnabled = false;
                TBoxImePodjetja.IsEnabled = false;
                GBoxOsebniPodatki.IsEnabled = false;
            }

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
