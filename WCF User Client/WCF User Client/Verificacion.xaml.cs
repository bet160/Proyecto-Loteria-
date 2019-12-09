using System;
using System.ServiceModel;
using System.Windows;
using WCF_User_Client.Model;
using WCF_User_Client.ServidorLoteria;


namespace WCF_User_Client
{
    [CallbackBehavior(UseSynchronizationContext = false)]
    /// <summary>
    /// Lógica de interacción para Verificacion.xaml
    /// </summary>
    public partial class Verificacion : Window, ServidorLoteria.IServicioCuentaUsuarioCallback
    {
        private string codigoVerificacion;
        private Usuario cuentaCreada;

        public Verificacion()
        {
            InitializeComponent();
        }

        public string CodigoVerificacion { get => codigoVerificacion; set => codigoVerificacion = value; }
        internal Usuario CuentaCreada { get => cuentaCreada; set => cuentaCreada = value; }

        private void DesplegarPrincipal(object sender, RoutedEventArgs e)
        {
            string codigoIngresado = textBoxCodigo.Text.Trim();

            if (ValidarDatosIngresados(codigoIngresado))
            {
                if (String.Equals(codigoIngresado, codigoVerificacion))
                {
                    RegistrarUsuario();
                    Principal ventana = new Principal();
                    ventana.LabelNombreUsuario.Content = cuentaCreada.NombreUsuario;
                    ventana.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Codigo incorrecto");
                }

            }
            else
            {
                MessageBox.Show("No puede dejar campos vacios ni llenarlos con espacios");
            }
        }

        private bool ValidarDatosIngresados(string codigo)
        {
            bool datosValidos = false;

            if (codigo != "")
            {
                datosValidos = true;
                return datosValidos;
            }
            else
            {
                return datosValidos;
            }
        }

        private void DesplegarInicio(object sender, RoutedEventArgs e)
        {
            Inicio ventana = new Inicio();
            ventana.Show();
            this.Close();
        }

        private void RegistrarUsuario()
         {
            try
            {
                InstanceContext instanceContext = new InstanceContext(this);
                ServidorLoteria.ServicioCuentaUsuarioClient client = new ServidorLoteria.ServicioCuentaUsuarioClient(instanceContext);
                ServidorLoteria.CuentaSet cuenta = new ServidorLoteria.CuentaSet();
                cuenta.nombreUsuario = cuentaCreada.NombreUsuario;
                cuenta.correo = cuentaCreada.Correo;
                cuenta.contraseña = cuentaCreada.Contraseña;
                
                client.GuardarCuentaUsuario(cuenta);             
            }
            catch (EndpointNotFoundException)
            {

            }
        }

        private void CerrarVentana(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinimizarVentana(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
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

        public void MensajeChat(string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
