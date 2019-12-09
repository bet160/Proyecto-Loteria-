using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
using LoteriaEmail;
using WCF_User_Client.ServidorLoteria;

namespace ClienteLoteria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class EnvioDeInvitaciones : Window, WCF_User_Client.ServidorLoteria.IServicioCuentaUsuarioCallback
    {
        private CuentaSet cuenta;
        private string v;


        public EnvioDeInvitaciones(CuentaSet cuenta, string v)
        {
            InitializeComponent();
            this.v = v;
            this.cuenta = cuenta;
        }

        private void DesplegarSalaDeJuego(object sender, RoutedEventArgs e)
        {

            InstanceContext instanceContext = new InstanceContext(this);
            WCF_User_Client.ServidorLoteria.ServicioCuentaUsuarioClient client = new WCF_User_Client.ServidorLoteria.ServicioCuentaUsuarioClient(instanceContext);
            client.EnviarInivitacion(cuenta.nombreUsuario,v, Invitado1.Text);
            Principal ventana = new Principal(cuenta);
            this.Close();
            ventana.Show();
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

        public void RecibirInvitacion(string mensaje, string nombreUsuario, string tematica)
        {
            throw new NotImplementedException();
        }

        public void RecibirConfirmacion(bool opcion, string tematica, string nombreUsuario)
        {
            MessageBox.Show("invitaciones");
            if (opcion == true)
            {
                if (tematica.Equals("Carros"))
                {
                    MessageBox.Show("Se ha aceptado su invitación");
                    this.Dispatcher.Invoke(() =>
                    {
                        SeleccionCartasCarros ventana = new SeleccionCartasCarros(60);
                        this.Close();
                        ventana.Show();

                    });
                }
                if (tematica.Equals("Futbol"))
                {
                    MessageBox.Show("Se ha aceptado su invitación");
                    this.Dispatcher.Invoke(() =>
                    {
                        SeleccionCartasFutbol ventana = new SeleccionCartasFutbol();
                        this.Close();
                        ventana.Show();

                    });
                }
            }
            else
            {
                MessageBox.Show("No se acepto la invitación");
            }
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
