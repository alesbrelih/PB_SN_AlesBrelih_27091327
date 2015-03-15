using PB_SN_AlesBrelih_27091327.Resources.Data;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels;
using PB_SN_AlesBrelih_27091327.Resources.ViewModels.OsebaWindows;
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
using PB_SN_AlesBrelih_27091327.Windows.MessageWindows;

namespace PB_SN_AlesBrelih_27091327.Windows
{
    /// <summary>
    /// Interaction logic for OsebaManage.xaml
    /// </summary>
    public partial class OsebaManage : Window
    {
        private ManageOsebaViewModel _viewModel;
        public OsebaManage(OsebaView oseba = null, Enums.ActionState Action = Enums.ActionState.Create) //TODO: osebaview model in constructor
        {
            InitializeComponent();
            _viewModel = new ManageOsebaViewModel(this, oseba, Action);
            this.DataContext = _viewModel;
        }



        private void OsebaManage_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnClose_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnMinimiye_OnClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.SaveChanges();
            this.DialogResult = true;
            this.Close();
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
