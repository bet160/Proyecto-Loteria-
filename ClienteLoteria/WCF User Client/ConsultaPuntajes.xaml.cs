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
using System.Windows.Shapes;
using WCF_User_Client.Model;
using WCF_User_Client.ServidorLoteria;

namespace ClienteLoteria
{
    
    /// <summary>
    /// Lógica de interacción para Verificacion.xaml
    /// </summary>
    public partial class ConsultaPuntajes : Window, WCF_User_Client.ServidorLoteria.IServicioCuentaUsuarioCallback
    {

        private CuentaSet cuenta;
        public ConsultaPuntajes(CuentaSet cuenta)
        {
            InitializeComponent();
            InstanceContext instanceContext = new InstanceContext(this);
            WCF_User_Client.ServidorLoteria.ServicioCuentaUsuarioClient cliente = new WCF_User_Client.ServidorLoteria.ServicioCuentaUsuarioClient(instanceContext);
            cliente.SolicitarPuntajes();
            this.cuenta = cuenta;
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
            throw new NotImplementedException();
        }

        public void DevuelveCuenta(CuentaSet cuenta)
        {
            throw new NotImplementedException();
        }

        public void DevuelvePuntajes(PuntajeUsuario[] puntajes)
        {
            List<Puntajes> puntajes1 = new List<Puntajes>();
            foreach (var valor in puntajes)
            {
                puntajes1.Add(new Puntajes() { NombreUsuario = valor.nombreUsuario, Puntaje = valor.puntajeMaximo });
            }
            this.Dispatcher.Invoke(() =>
            {
                lvUsers.ItemsSource = puntajes1;
            });
        }

        public void RecibirInvitacion(string mensaje, string nombreUsuario, string tematica)
        {
            throw new NotImplementedException();
        }

        public void RecibirConfirmacion(bool opcion,string temtica,string nombreUsuario)
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
