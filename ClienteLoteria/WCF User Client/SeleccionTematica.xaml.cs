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

namespace ClienteLoteria
{
    /// <summary>
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    public partial class SeleccionTematica : Window
    {

        public SeleccionTematica()
        {
            InitializeComponent();
        }
        
        private void DesplegarSeleccionCartasCarros(object sender, RoutedEventArgs e)
        {
            SeleccionCartasCarros newForm = new SeleccionCartasCarros();
            newForm.Show();
            this.Close();
        }

        private void DesplegarSeleccionCartasFutbol(object sender, RoutedEventArgs e)
        {
            SeleccionCartasFutbol newForm = new SeleccionCartasFutbol();
            newForm.Show();
            this.Close();
        }

        private void DesplegarPrincipal(object sender, RoutedEventArgs e)
        {
            Principal newForm = new Principal();
            newForm.Show();
            this.Close();
        }

        private void CerrarVentana(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinimizarVentana(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}