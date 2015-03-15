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
using ActionState = PB_SN_AlesBrelih_27091327.Resources.Data.Enums.ActionState;

namespace PB_SN_AlesBrelih_27091327.Windows
{
    /// <summary>
    /// Interaction logic for NajemManage.xaml
    /// </summary>
    public partial class NajemManage : Window
    {
        //ViewModel
        private ManageNajemViewModel _viewModel;

        public NajemManage(ObservableCollection<NajemView> vsiNajemi, NajemView najem = null, ActionState actionState=ActionState.Create)
        {
            InitializeComponent();
            _viewModel = new ManageNajemViewModel(vsiNajemi, najem, actionState);
            this.DataContext = _viewModel;
            NastaviComboBoxe();
        }


        //Nastavi display path in value path za comboboxe
        private void NastaviComboBoxe()
        {
            CBoxPodjetja.DisplayMemberPath = "ImePodjetja";
            CBoxPodjetja.SelectedValuePath = "Id";

            CBoxProstori.DisplayMemberPath = "ImeProstora";
            CBoxProstori.SelectedValuePath = "Id";
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }



        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _viewModel.SaveChanges();
                this.DialogResult = true;
                this.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CBoxPodjetja_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _viewModel.NastaviIzbranoPodjetje(CBoxPodjetja.SelectedIndex);
        }

        private void CBoxProstori_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _viewModel.NastaviIzbraniProstor(CBoxProstori.SelectedIndex);
        }
    }
}
