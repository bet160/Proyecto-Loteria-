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

namespace ClienteLoteria
{

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


        private void LoadStringResource(string locale)
        {
            var resources = new ResourceDictionary();

            resources.Source = new Uri("pack://application:,,,/Recursos_" + locale + ";component/Strings.xaml", UriKind.Absolute);

            var currentResource = Application.Current.Resources.MergedDictionaries.FirstOrDefault(
                             resource => resource.Source.OriginalString.EndsWith("Strings.xaml"));


            if (currentResource != null)
            {
                Application.Current.Resources.MergedDictionaries.Remove(currentResource);
            }

            Application.Current.Resources.MergedDictionaries.Add(resources);

        }


        private void CambiarIdiomaAIngles(object sender, RoutedEventArgs e)
        {
            LoadStringResource("en-US");
        }

        private void CambiarIdiomaAEspañol(object sender, RoutedEventArgs e)
        {
            var resources = new ResourceDictionary();

            resources.Source = new Uri("pack://application:,,,/RecursosIdiomaPrincipal/Strings.xaml");

            Application.Current.Resources.MergedDictionaries.Add(resources);
        }
    }
}
