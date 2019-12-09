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
    /// Lógica de interacción para ConfirmarInvitacion.xaml
    /// </summary>
    public partial class ConfirmarInvitacion : Window
    {
        public ConfirmarInvitacion()
        {
            InitializeComponent();
        }

        private void RechazarInvitacion(object sender, RoutedEventArgs e)
        {

        }

        private void AceptarInvitacion(object sender, RoutedEventArgs e)
        {

        }

        private void CerrarVentana(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinimizarVentana(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
