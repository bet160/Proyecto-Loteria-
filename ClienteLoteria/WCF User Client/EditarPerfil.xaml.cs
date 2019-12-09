using System;
using System.Drawing;
using System.ServiceModel;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using WCF_User_Client.ServidorLoteria;

namespace ClienteLoteria
{
    /// <summary>
    /// Lógica de interacción para Verificacion.xaml
    /// </summary>
    /// 
    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class EditarPerfil : Window, WCF_User_Client.ServidorLoteria.IServicioCuentaUsuarioCallback
    {
        private CuentaSet cuenta;
        public EditarPerfil(CuentaSet cuenta)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            nombreModificar.Text = cuenta.nombreUsuario;
        }

        private void DesplegarPrincipal(object sender, RoutedEventArgs e)
        {
            try
            {
                InstanceContext instanceContext = new InstanceContext(this);
                WCF_User_Client.ServidorLoteria.ServicioCuentaUsuarioClient client = new WCF_User_Client.ServidorLoteria.ServicioCuentaUsuarioClient(instanceContext);
                cuenta.nombreUsuario = nombreModificar.Text;
                cuenta.contraseña = contraseñaModificar.Text;
                client.ModificarCuentaUsuario(cuenta);
                Principal ventana = new Principal(cuenta);
                ventana.Show();
                this.Close();

            }
            catch (EndpointNotFoundException)
            {

            }
        }

        private void CerrarVentana(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinimizarVentana(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        public void Response(string mensaje)
        {
            throw new NotImplementedException();
        }

        public void DevuelveObjeto(CuentaSet cuenta)
        {

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

        public void RecibirInvitacion(string mensaje, string nombreUsuario, string tematica)
        {
            throw new NotImplementedException();
        }

        public void RecibirConfirmacion(bool opcion, string tematica,string nombreUsuario)
        {
            throw new NotImplementedException();
        }

        public void RecibirOrdenTarjetas(int[] orden)
        {
            throw new NotImplementedException();
        }

        public void RecibirFinPartida(string nombreUsuario)
        {
            throw new NotImplementedException();
        }

        private void VolverPrincipal(object sender, RoutedEventArgs e)
        {
            Principal ventana = new Principal(cuenta);
            ventana.Show();
            this.Close();
        }
    }
}
