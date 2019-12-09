using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Windows;
using WCF_User_Client.Model;
using WCF_User_Client.ServidorLoteria;

namespace WCF_User_Client
{
    [CallbackBehavior(UseSynchronizationContext = false)]
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class RegistroUsuario : Window, ServidorLoteria.IServicioCuentaUsuarioCallback
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void RegistrarUsuario(object sender, RoutedEventArgs e)
        {
            try
            {
                InstanceContext instanceContext = new InstanceContext(this);
                ServidorLoteria.ServicioCuentaUsuarioClient client = new ServidorLoteria.ServicioCuentaUsuarioClient(instanceContext);
                ServidorLoteria.CuentaSet cuenta = new ServidorLoteria.CuentaSet();
                cuenta.nombreUsuario = textBoxNombreUsuario.Text;
                cuenta.correo = textBoxCorreo.Text;
                cuenta.contraseña = passwordBoxContraseña.Password;
                client.GuardarCuentaUsuario(cuenta);
            }
            catch (EndpointNotFoundException)
            {
                
            }
            Principal ventana = new Principal();
            ventana.Show();
            this.Close();
        }

        private void DesplegarVerificacion(object sender, RoutedEventArgs e)
        {
            /*EnvioDeCorreo correo = new EnvioDeCorreo();
            string codigoGenerado = GenerarCodigoVerificacion().ToString();
            string nombreUsuario = textBoxNombreUsuario.Text.Trim();
            string correoIngresado = textBoxCorreo.Text.Trim();
            string contraseña = passwordBoxContraseña.Password.Trim();

            if(ValidarDatosIngresados(nombreUsuario, correoIngresado, contraseña))
            {
                if (correo.EnviarCorreo(correoIngresado, codigoGenerado))
                {
                    Verificacion ventana = new Verificacion();
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
            }*/
            Verificacion ventana = new Verificacion();
            ventana.Show();
            this.Close();
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

        public void Respuesta(string mensaje)
        {
            throw new NotImplementedException();
        }

        public void DevuelveCuenta(CuentaSet cuenta)
        {
            Usuario user = new Usuario();
            user.NombreUsuario = cuenta.nombreUsuario;
            user.Correo = cuenta.correo;
            user.Contraseña = cuenta.contraseña;
            user.Puntaje = cuenta.puntajeMaximo;
            user.FotoPerfil = cuenta.fotoPerfil;

            MessageBox.Show(user.NombreUsuario);
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
                MessageBox.Show(valor.nombreUsuario);
            }
        }
    }
}
