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
using WCF_User_Client.Model;
using WCF_User_Client.ServidorLoteria;

namespace WCF_User_Client
{
    /// <summary>
    /// Lógica de interacción para Verificacion.xaml
    /// </summary>
    public partial class ConsultaPuntajes : Window, ServidorLoteria.IServicioCuentaUsuarioCallback
    {
        //private string codigoVerificacion;

        public ConsultaPuntajes()
        {
            InitializeComponent();
         
        }

        private void DesplegarPrincipal(object sender, RoutedEventArgs e)
        {

            Principal ventana = new Principal();
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

        private void Puntajes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
            List<Puntajes> puntaje1 = new List<Puntajes>();
            Puntajes modelo = new Puntajes();
            foreach (var valor in puntajes)
            {
                modelo.NombreUsuario = valor.nombreUsuario;
                modelo.Puntaje = valor.puntajeMaximo;
                puntaje1.Add(modelo);
                

            }
        }

        public void MensajeChat(string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
