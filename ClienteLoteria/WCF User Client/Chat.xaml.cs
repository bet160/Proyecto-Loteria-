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

    public partial class Chat : Window, WCF_User_Client.ServidorLoteria.IServicioCuentaUsuarioCallback
    {
      
        public Chat()
        {
            InitializeComponent();
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
