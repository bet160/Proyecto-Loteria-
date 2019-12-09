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

namespace WCF_User_Client
{
    /// <summary>
    /// Lógica de interacción para Inisio_sesion.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void DesplegarInicioSesion(object sender, RoutedEventArgs e)
        {
            InicioSesion ventana = new InicioSesion();
            ventana.Show(); 
            this.Close();
        }

        private void DesplegarRegistroUsuario(object sender, RoutedEventArgs e)
        {
            RegistroUsuario ventana = new RegistroUsuario();
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

        private void DesplegarCodigoInvitacion(object sender, RoutedEventArgs e)
        {
            CodigoInvitacion ventana = new CodigoInvitacion();
            ventana.Show();
            this.Close();
        }
    }
}
