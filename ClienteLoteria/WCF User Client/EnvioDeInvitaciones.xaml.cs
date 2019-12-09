using System;
using System.ServiceModel;
using System.Windows;
using WCF_User_Client.ServidorLoteria;

namespace ClienteLoteria
{
    public partial class EnvioDeInvitaciones : Window, IServicioCuentaUsuarioCallback
    {
        private CuentaSet cuenta;
        private string tematica;

        public EnvioDeInvitaciones(CuentaSet cuentaRecibida, string tematicaElegida)
        {
            InitializeComponent();
            tematica = tematicaElegida;
            cuenta = cuentaRecibida;
        }

        private void DesplegarVentana(Window ventana)
        {
            ventana.Show();
            this.Close();
        }

        private void DesplegarSalaDeJuego(object sender, RoutedEventArgs e)
        {
            string invitado = Invitado1.Text.Trim();
            string mensaje = Application.Current.Resources["MensajeInvitacion"].ToString();

            try
            {
                if (ValidarDatosIngresados(invitado))
                {
                    InstanceContext instanceContext = new InstanceContext(this);
                    ServicioCuentaUsuarioClient client = new ServicioCuentaUsuarioClient(instanceContext);
                    client.EnviarInivitacion(mensaje, cuenta.nombreUsuario, tematica, invitado);
                    Principal ventana = new Principal(cuenta);
                    DesplegarVentana(ventana);
                }
                else
                {
                    MessageBox.Show(Application.Current.Resources["DatosInvalidosInvitacion"].ToString());
                }
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show(Application.Current.Resources["OperacionInvalida"].ToString());
            }
        }

        private bool ValidarDatosIngresados(string codigo)
        {
            bool datosValidos = false;

            if (codigo != "")
            {
                datosValidos = true;
                return datosValidos;
            }
            else
            {
                return datosValidos;
            }
        }

        private void DesplegarPrincipal(object sender, RoutedEventArgs e)
        {
            Principal ventana = new Principal(cuenta);
            ventana.Show();
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

        public void MensajeChat(string mensaje)
        {
            throw new NotImplementedException();
        }

        public void Respuesta(string mensaje)
        {
            mensaje = Application.Current.Resources["MensajeUsuarioNoConectado"].ToString();
            MessageBox.Show(mensaje);
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
            string invitado = Invitado1.Text.Trim();
            const int TIEMPOPARASELECCIONARTARJETAS = 60;

            if (opcion)
            {
                if (tematica.Equals("Carros"))
                {
                    this.Dispatcher.Invoke(() =>
                    {
                        SeleccionCartasCarros ventana = new SeleccionCartasCarros(cuenta, TIEMPOPARASELECCIONARTARJETAS, invitado);
                        this.Close();
                        ventana.Show();

                    });
                }
                if (tematica.Equals("Futbol"))
                {
                    this.Dispatcher.Invoke(() =>
                    {
                        SeleccionCartasFutbol ventana = new SeleccionCartasFutbol(cuenta, TIEMPOPARASELECCIONARTARJETAS, invitado);
                        this.Close();
                        ventana.Show();

                    });
                }
            }
            else
            {
                MessageBox.Show(Application.Current.Resources["MensajeInvitacionRechazada"].ToString());
            }
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
