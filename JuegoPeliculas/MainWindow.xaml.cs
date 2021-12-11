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

namespace JuegoPeliculas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowsMv vm = new MainWindowsMv();
        public MainWindow()
        {

            InitializeComponent();
            this.DataContext = vm;
        }

        private void FlecharetrocesoImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            vm.Anterior();
        }

        private void FlechaAdelantar_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            vm.Siguiente();
        }
    }
}
