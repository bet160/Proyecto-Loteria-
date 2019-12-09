using ClienteLoteria;
using System;
using System.ServiceModel;
using System.Windows;
using WCF_User_Client.ServidorLoteria;

namespace WCF_User_Client
{
    public partial class ConfirmarInvitacion : Window, IServicioCuentaUsuarioCallback
    {
        private string nombreUsuario;
        private string tematica;
        private CuentaSet cuenta;
        private string mensaje;

        public ConfirmarInvitacion(CuentaSet cuenta, string nombreUsuario, string tematica,string mensaje)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            this.nombreUsuario = nombreUsuario;
            this.tematica = tematica;
            this.mensaje = mensaje;
            MensajeInvitacion.Content = mensaje;
        }


        private void AceptarInvitacion(object sender, RoutedEventArgs e)
        {
            const int TIEMPOPARASELECIONARCARTAS = 60;

            try
            {
                InstanceContext instanceContext = new InstanceContext(this);
                ServicioCuentaUsuarioClient client = new ServicioCuentaUsuarioClient(instanceContext);
                client.ConfirmacionInvitacion(true,cuenta.nombreUsuario,tematica,nombreUsuario);

                 if (tematica.Equals("Carros"))
                 {
                     SeleccionCartasCarros ventana = new SeleccionCartasCarros(cuenta,TIEMPOPARASELECIONARCARTAS,nombreUsuario);
                     this.Close();
                     ventana.Show();
                 }else if (tematica.Equals("Futbol"))
                 {
                    SeleccionCartasFutbol ventana = new SeleccionCartasFutbol(cuenta, TIEMPOPARASELECIONARCARTAS, nombreUsuario);
                    this.Close();
                    ventana.Show();
                 }
            } 
            catch(InvalidOperationException)
            {
                MessageBox.Show(Application.Current.Resources["OparecionInvalida"].ToString());
            }
        }

        private void RechazarInvitacion(object sender, RoutedEventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(this);
            ServicioCuentaUsuarioClient cliente = new ServicioCuentaUsuarioClient(instanceContext);
            cliente.ConfirmacionInvitacion(false, cuenta.nombreUsuario, tematica, nombreUsuario);
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
