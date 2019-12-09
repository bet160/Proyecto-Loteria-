using System;
using System.Linq;
using System.ServiceModel;
using System.Windows;
using WCF_User_Client.ServidorLoteria;

namespace ClienteLoteria
{
    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class EditarPerfil : Window, IServicioCuentaUsuarioCallback
    {
        private CuentaSet cuenta;
        public EditarPerfil(CuentaSet cuentaRecibida)
        {
            InitializeComponent();
            cuenta = cuentaRecibida;
            textBoxNombreUsuario.Text = cuentaRecibida.nombreUsuario;
            textBoxContraseña.Text = cuentaRecibida.contraseña;
        }

        private void DesplegarPrincipal(object sender, RoutedEventArgs e)
        {
            string nuevoNombreUsuario = textBoxNombreUsuario.Text.Trim();
            string nuevaContraseña = textBoxContraseña.Text.Trim();

            if (ValidarDatosIngresados(nuevoNombreUsuario, nuevaContraseña))
            {
                ModficarCuenta(nuevoNombreUsuario, nuevaContraseña);
                Principal ventana = new Principal(cuenta);
                DesplegarVentana(ventana);
            }
            else
            {
                MessageBox.Show(Application.Current.Resources["DatosInvalidos"].ToString());
            }
          
        }

        private void ModficarCuenta(string nombreModificado, string contraseñaModificada)
        {
            try
            {
                InstanceContext instanceContext = new InstanceContext(this);
                ServicioCuentaUsuarioClient client = new ServicioCuentaUsuarioClient(instanceContext);
                cuenta.nombreUsuario = nombreModificado;
                cuenta.contraseña = contraseñaModificada;
                client.ModificarCuentaUsuario(cuenta);
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show(Application.Current.Resources["OperacionInvalida"].ToString());
            }
        }

        private bool ValidarDatosIngresados(string nombreUsuario, string contraseña)
        {
            bool datosValidos = false;

            if (nombreUsuario != "" && contraseña != "")
            {
                datosValidos = true;
                return datosValidos;
            }
            else
            {
                return datosValidos;
            }
        }

        private void DesplegarVentana(Window ventana)
        {
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

        public void Response(string mensaje)
        {
            throw new NotImplementedException();
        }

        public void DevuelveObjeto(CuentaSet cuenta)
        {
            throw new NotImplementedException();
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

        public void RecibirInvitacion(string nombreUsuario, string mensaje, string tematica)
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

        public void RecibirFinPartida(string mensaje)
        {
            throw new NotImplementedException();
        }

        private void VolverPrincipal(object sender, RoutedEventArgs e)
        {
            Principal ventana = new Principal(cuenta);
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
