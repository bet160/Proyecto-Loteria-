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
using WCF_User_Client.ServidorLoteria;

namespace ClienteLoteria
{
    /// <summary>
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    public partial class SeleccionTematica : Window
    {
        private CuentaSet cuenta;

        public SeleccionTematica(CuentaSet cuenta)
        {
            InitializeComponent();
            this.cuenta = cuenta;
        }

        private void DesplegarSeleccionCartasCarros(object sender, RoutedEventArgs e)
        {
            EnvioDeInvitaciones newForm = new EnvioDeInvitaciones(cuenta,"Carros");
            newForm.Show();
            this.Close();
        }

        private void DesplegarSeleccionCartasFutbol(object sender, RoutedEventArgs e)
        {
            EnvioDeInvitaciones newForm = new EnvioDeInvitaciones(cuenta,"Futbol");
            newForm.Show();
            this.Close();
        }

        private void DesplegarPrincipal(object sender, RoutedEventArgs e)
        {
            Principal newForm = new Principal(cuenta);
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