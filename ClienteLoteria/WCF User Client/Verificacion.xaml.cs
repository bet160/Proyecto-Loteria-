using System;
using System.ServiceModel;
using System.Windows;
using ClienteLoteria.Model;
using WCF_User_Client.ServidorLoteria;

namespace ClienteLoteria
{

    public partial class Verificacion : Window, IServicioCuentaUsuarioCallback
    {
        private string codigoVerificacion;
        private Usuario cuentaCreada;

        public Verificacion(string codigoGenrado, Usuario usuarioCreado)
        {
            InitializeComponent();
            codigoVerificacion = codigoGenrado;
            cuentaCreada = usuarioCreado;
        }

        private void DesplegarPrincipal(object sender, RoutedEventArgs e)
        {
            string codigoIngresado = textBoxCodigo.Text.Trim();

            if (ValidarDatosIngresados(codigoIngresado))
            {
                if (String.Equals(codigoIngresado, codigoVerificacion))
                {
                    RegistrarUsuario();
                }
                else
                {
                    MessageBox.Show(Application.Current.Resources["CodigoIncorrecto"].ToString());
                }

            }
            else
            {
                MessageBox.Show(Application.Current.Resources["DatosInvalidosVerificacion"].ToString());
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

        private void DesplegarVentana(Window ventana)
        {
            ventana.Show();
            this.Close();
        }

        private void DesplegarInicio(object sender, RoutedEventArgs e)
        {
            Inicio ventana = new Inicio();
            DesplegarVentana(ventana);
        }

        private void RegistrarUsuario()
         {
            try
            {
                InstanceContext instanceContext = new InstanceContext(this);
                ServicioCuentaUsuarioClient cliente = new ServicioCuentaUsuarioClient(instanceContext);
                CuentaSet cuenta = new CuentaSet() {
                    nombreUsuario = cuentaCreada.NombreUsuario,
                    correo = cuentaCreada.Correo,
                    contraseña = cuentaCreada.Contraseña,
                    puntajeMaximo = 0
                };
                
                cliente.GuardarCuentaUsuario(cuenta);
                cliente.IniciarSesion(cuentaCreada.NombreUsuario, cuentaCreada.Contraseña);
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show(Application.Current.Resources["OperacionInvalida"].ToString());
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

        public void MensajeChat(string mensaje)
        {
            throw new NotImplementedException();
        }

        public void Respuesta(string mensaje)
        {
            mensaje = Application.Current.Resources["MismoUsuario"].ToString();
            MessageBox.Show(mensaje);
        }

        public void DevuelveCuenta(CuentaSet cuenta)
        {
            this.Dispatcher.Invoke(() =>
            {
                Principal ventana = new Principal(cuenta);
                DesplegarVentana(ventana);

            });
        }

        public void DevuelvePuntajes(PuntajeUsuario[] puntajes)
        {
            throw new NotImplementedException();
        }

        public void RecibirInvitacion(string nombreUsuario, string mensaje, string tematica)
        {
            throw new NotImplementedException();
        }

        public void RecibirConfirmacion(bool opcion,string tematica, string nombreUsuario)
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
    }
}
