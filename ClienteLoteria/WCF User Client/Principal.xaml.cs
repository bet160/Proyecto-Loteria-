using System;
using System.Collections.Generic;
using System.Linq;
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
using WCF_User_Client.ServidorLoteria;

namespace ClienteLoteria

{
    /// <summary>
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    public partial class Principal : Window, WCF_User_Client.ServidorLoteria.IServicioCuentaUsuarioCallback
    {
        private CuentaSet cuenta;

        public Principal(CuentaSet cuenta)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            labelNombreUsuario.Content = cuenta.nombreUsuario;
            labelPuntajeMaximo.Content = cuenta.puntajeMaximo;
        }


        private void DesplegarVentanaInicio(object sender, RoutedEventArgs e)
        {
            Inicio newForm = new Inicio();
            newForm.Show();
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

        private void DesplegarEditarPerfil(object sender, RoutedEventArgs e)
        {
            EditarPerfil newForm = new EditarPerfil(cuenta);
            newForm.Show();
            this.Close();
        }

        private void DesplegarPuntajes(object sender, RoutedEventArgs e)
        {
            ConsultaPuntajes newForm = new ConsultaPuntajes(cuenta);
            newForm.Show();
            this.Close();
        }

        private void DesplegarTematicas(object sender, RoutedEventArgs e)
        {
            SeleccionTematica newForm = new SeleccionTematica(cuenta);
            this.Close();
            newForm.Show();
            
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
    }
}
