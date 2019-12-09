using System;
using System.Windows;
using WCF_User_Client.ServidorLoteria;

namespace ClienteLoteria

{
    public partial class Principal : Window, IServicioCuentaUsuarioCallback
    {
        private CuentaSet cuenta;

        public Principal(CuentaSet cuentaRecuperada)
        {
            InitializeComponent();
            labelNombreUsuario.Content = cuentaRecuperada.nombreUsuario;
            labelPuntajeMaximo.Content = cuentaRecuperada.puntajeMaximo.ToString();
            this.cuenta = cuentaRecuperada;
        }

        private void DesplegarVentana(Window ventana)
        {
            ventana.Show();
            this.Close();
        }

        private void DesplegarVentanaInicio(object sender, RoutedEventArgs e)
        {
            Inicio ventana = new Inicio();
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

        private void DesplegarEditarPerfil(object sender, RoutedEventArgs e)
        {
            EditarPerfil ventana = new EditarPerfil(cuenta);
            DesplegarVentana(ventana);
        }

        private void DesplegarPuntajes(object sender, RoutedEventArgs e)
        {
            ConsultaPuntajes ventana = new ConsultaPuntajes(cuenta);
            DesplegarVentana(ventana);
        }

        private void DesplegarTematicas(object sender, RoutedEventArgs e)
        {
            SeleccionTematica ventana = new SeleccionTematica(cuenta);
            DesplegarVentana(ventana);
            
        }

        public void MensajeChat(string mensaje)
        {
            throw new NotImplementedException();
        }

        public void Respuesta(string mensaje)
        {
            throw new NotImplementedException();
        }

        public void DevuelveCuenta(CuentaSet cuenta)
        {
            throw new NotImplementedException();
        }

        public void DevuelvePuntajes(PuntajeUsuario[] puntajes)
        {
            throw new NotImplementedException();
        }

        public void RecibirInvitacion(string nombreUsuario, string mensaje, string tematica)
        {
            throw new NotImplementedException();
        }

        public void RecibirConfirmacion(bool opcion, string tematica, string nombreUsuario)
        {
            throw new NotImplementedException();
        }

        public void RecibirOrdenTarjetas(int[] orden)
        {
            throw new NotImplementedException();
        }

        public void RecibirFinPartida(string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
