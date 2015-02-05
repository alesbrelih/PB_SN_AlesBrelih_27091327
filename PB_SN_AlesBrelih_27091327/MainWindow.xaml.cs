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
using System.Windows.Navigation;
using System.Windows.Shapes;
using PB_SN_AlesBrelih_27091327.Resources.ViewModels;
using PB_SN_AlesBrelih_27091327.Windows;

namespace PB_SN_AlesBrelih_27091327
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainWindowViewModel();
            this.DataContext = _viewModel;
        }

        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void ExitButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void NovaOsebaMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            var novaOseba = new OsebaManage();
            novaOseba.Show();
        }

        private void PregledOsebaMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            var pregledoseba = new OsebaMain();
            pregledoseba.Show();
        }

        private void NovoPodjetjeMenuitem_OnClick(object sender, RoutedEventArgs e)
        {
            var novoPodjetje = new PodjetjeManage();
            novoPodjetje.Show();
        }

        private void PregledPodjetjaMenuItem_OnClick(object sender, RoutedEventArgs e)
        {
            var pregledPodjetje = new PodjetjeMain();
            pregledPodjetje.Show();
            
        }

        
    }
}
