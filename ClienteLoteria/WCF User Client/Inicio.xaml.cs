using System;
using System.Linq;
using System.Windows;


namespace ClienteLoteria
{

    public partial class Inicio : Window
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void DesplegarVentana(Window ventana)
        {
            ventana.Show();
            this.Close();
        }

        private void DesplegarInicioSesion(object sender, RoutedEventArgs e)
        {
            InicioSesion ventana = new InicioSesion();
            DesplegarVentana(ventana);
        }

        private void DesplegarRegistroUsuario(object sender, RoutedEventArgs e)
        {
            RegistroUsuario ventana = new RegistroUsuario();
            DesplegarVentana(ventana);
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
            DesplegarVentana(ventana);
        }


        private void CargarRecursosDeIdioma(string locale)
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
            CargarRecursosDeIdioma("en-US");
        }

        private void CambiarIdiomaAEspañol(object sender, RoutedEventArgs e)
        {
            var resources = new ResourceDictionary();

            resources.Source = new Uri("pack://application:,,,/RecursosIdiomaPrincipal/Strings.xaml");

            Application.Current.Resources.MergedDictionaries.Add(resources);
        }
    }
}
