using ClienteLoteria;
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
using WCF_User_Client.ServidorLoteria;

namespace WCF_User_Client
{
    /// <summary>
    /// Lógica de interacción para ConfirmarInvitacion.xaml
    /// </summary>
    public partial class ConfirmarInvitacion : Window, WCF_User_Client.ServidorLoteria.IServicioCuentaUsuarioCallback
    {
        private string nombreUsuario;
        private string tematica;


        public ConfirmarInvitacion(string nombreUsuario, string tematica)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.tematica = tematica;
        }

        private void AceptarInvitacion(object sender, RoutedEventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(this);
            WCF_User_Client.ServidorLoteria.ServicioCuentaUsuarioClient client = new WCF_User_Client.ServidorLoteria.ServicioCuentaUsuarioClient(instanceContext);
            client.ConfirmacionInvitacion(true, nombreUsuario,tematica);
            if (tematica.Equals("Carros"))
            {
                SeleccionCartasCarros ventana = new SeleccionCartasCarros();
                this.Close();
                ventana.Show();
            }
            if (tematica.Equals("Futbol"))
            {
                SeleccionCartasFutbol ventana = new SeleccionCartasFutbol();
                this.Close();
                ventana.Show();
            }

        }

        private void RechazarInvitacion(object sender, RoutedEventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(this);
            WCF_User_Client.ServidorLoteria.ServicioCuentaUsuarioClient client = new WCF_User_Client.ServidorLoteria.ServicioCuentaUsuarioClient(instanceContext);


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

        public void RecibirInvitacion(string mensaje, string nombreUsuario, string tematica)
        {
            throw new NotImplementedException();
        }

        public void RecibirConfirmacion(bool opcion, string tematica)
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
