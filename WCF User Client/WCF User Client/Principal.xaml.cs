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
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    public partial class Principal : Window
    {

        public Principal()
        {
            InitializeComponent();
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
            EditarPerfil newForm = new EditarPerfil();
            newForm.Show();
            this.Close();
        }

        private void DesplegarPuntajes(object sender, RoutedEventArgs e)
        {
            ConsultaPuntajes newForm = new ConsultaPuntajes();
            newForm.Show();
            this.Close();
        }

        private void DesplegarTematicas(object sender, RoutedEventArgs e)
        {
            SeleccionTematica newForm = new SeleccionTematica();
            newForm.Show();
            this.Close();
        }
    }
}
