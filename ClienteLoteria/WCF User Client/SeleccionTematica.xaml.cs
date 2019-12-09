using System.Windows;
using WCF_User_Client.ServidorLoteria;

namespace ClienteLoteria
{
    public partial class SeleccionTematica : Window
    {
        private CuentaSet cuenta;

        public SeleccionTematica(CuentaSet cuentaRecibida)
        {
            InitializeComponent();
            cuenta = cuentaRecibida;
        }

        private void DesplegarVentana(Window ventana)
        {
            ventana.Show();
            this.Close();
        }

        private void DesplegarSeleccionCartasCarros(object sender, RoutedEventArgs e)
        {
            EnvioDeInvitaciones ventana = new EnvioDeInvitaciones(cuenta,"Carros");
            DesplegarVentana(ventana);
        }

        private void DesplegarSeleccionCartasFutbol(object sender, RoutedEventArgs e)
        {
            EnvioDeInvitaciones ventana = new EnvioDeInvitaciones(cuenta,"Futbol");
            DesplegarVentana(ventana);
        }

        private void DesplegarPrincipal(object sender, RoutedEventArgs e)
        {
            Principal ventana = new Principal(cuenta);
            DesplegarVentana(ventana);
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