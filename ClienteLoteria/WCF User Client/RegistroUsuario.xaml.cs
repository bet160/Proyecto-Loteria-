using System;
using System.ServiceModel;
using System.Windows;
using LoteriaEmail;
using ClienteLoteria.Model;
using WCF_User_Client.ServidorLoteria;

namespace ClienteLoteria
{
    [CallbackBehavior(UseSynchronizationContext = false)]
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class RegistroUsuario : Window, WCF_User_Client.ServidorLoteria.IServicioCuentaUsuarioCallback
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void DesplegarVerificacion(object sender, RoutedEventArgs e)
        {
            EnvioDeCorreo correo = new EnvioDeCorreo();
            string codigoGenerado = GenerarCodigoVerificacion().ToString();
            string nombreUsuario = textBoxNombreUsuario.Text.Trim();
            string correoIngresado = textBoxCorreo.Text.Trim();
            string contraseña = passwordBoxContraseña.Password.Trim();

            if(ValidarDatosIngresados(nombreUsuario, correoIngresado, contraseña))
            {
                if (correo.EnviarCorreo(correoIngresado, codigoGenerado))
                {
                    Verificacion ventana = new Verificacion();
                    Usuario cuentaUsuario = new Usuario()
                    {
                        NombreUsuario = nombreUsuario,
                        Correo = correoIngresado,
                        Contraseña = contraseña
                    };
                    
                    ventana.CuentaCreada = cuentaUsuario;
                    ventana.CodigoVerificacion = codigoGenerado;
                    ventana.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
            else
            {
                MessageBox.Show("Datos invalidos");
            }
        }

        private bool ValidarDatosIngresados(string nombreUsuario, string correo, string contraseña)
        {
            bool datosValidos = false;

            if (nombreUsuario != "" && correo != "" && contraseña != "")
            {
                if (correo.Contains("@gmail.com") || correo.Contains("@hotmail.com"))
                {
                    datosValidos = true;
                    return datosValidos;
                }
                else
                {
                    return datosValidos;
                }
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

        private int GenerarCodigoVerificacion()
        {
            int codigoDeVerificacion;
            Random numeroAleatorio = new Random();
            codigoDeVerificacion = numeroAleatorio.Next(1000, 9999);
            return codigoDeVerificacion;
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

        public void MensajeChat(string mensaje)
        {
            throw new NotImplementedException();
        }

        public void RecibirInvitacion(string mensaje, string nombreUsuario, string tematica)
        {
            throw new NotImplementedException();
        }

        public void RecibirConfirmacion(bool opcion)
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
