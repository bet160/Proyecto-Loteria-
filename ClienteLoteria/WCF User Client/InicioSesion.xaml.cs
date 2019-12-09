using System;
using System.ServiceModel;
using System.Windows;
using ClienteLoteria.Model;
using WCF_User_Client;
using WCF_User_Client.ServidorLoteria;

namespace ClienteLoteria
{
    /// <summary>
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    /// 
    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class InicioSesion : Window, WCF_User_Client.ServidorLoteria.IServicioCuentaUsuarioCallback
    {

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void IniciarSesion(object sender, RoutedEventArgs e)
        {
            string nombreUsuario = textBoxNombreUsuario.Text;
            string contraseña = passwordBoxContraseña.Password;

            try
            {
                InstanceContext instanceContext = new InstanceContext(this);
                WCF_User_Client.ServidorLoteria.ServicioCuentaUsuarioClient client = new WCF_User_Client.ServidorLoteria.ServicioCuentaUsuarioClient(instanceContext);

                if (ValidarDatosIngresados(nombreUsuario, contraseña))
                {
                    client.IniciarSesion(nombreUsuario, contraseña);
                }
                else
                {
                    MessageBox.Show("Datos invalidos");
                }   
            }
            catch (EndpointNotFoundException)
            {
                
            }
        }

        private bool ValidarDatosIngresados(string nombreUsuario, string contraseña)
        {
            bool datosValidos = false;

            if(nombreUsuario != "" && contraseña != "")
            {
                datosValidos = true;
                return datosValidos;
            }
            else
            {
                return datosValidos;
            }
        }

        private void DesplegarVentanaInicio(object sender, RoutedEventArgs e)
        {
            Inicio newForm = new Inicio();
            this.Close();
            newForm.Show();

        }

        private void CerrarVentana(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinimizarVentana(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        public void Respuesta(string mensaje)
        {
            throw new NotImplementedException();
        }

        public void DevuelveCuenta(CuentaSet cuenta)
        {
            Principal ventana = new Principal(cuenta);
            this.Close();
            ventana.Show();
        }

        public void DevuelvePuntajes(PuntajeUsuario[] puntajes)
        {
            throw new NotImplementedException();
        }

        public void MensajeChat(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public void RecibirInvitacion(string mensaje, string nombreUsuario, string tematica)
        {
            this.Dispatcher.Invoke(() =>
            {
                ConfirmarInvitacion ventana = new ConfirmarInvitacion();
                ventana.MensajeInvitacion.Content = nombreUsuario+" "+ mensaje+" en la tematica de "+tematica;
                ventana.Show();
                this.Close();
            });

        }

        public void RecibirConfirmacion(bool opcion)
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
    }
}
