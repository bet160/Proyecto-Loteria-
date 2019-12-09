using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
using WCF_User_Client.Model;
using WCF_User_Client.ServidorLoteria;

namespace WCF_User_Client
{
    /// <summary>
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    /// 
    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class InicioSesion : Window, IServicioCuentaUsuarioCallback
    {
        private Usuario usuario;

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void IniciarSesion(object sender, RoutedEventArgs e)
        {
            string nombreUsuario = textBoxNombreUsuario.Text;
            string contraseña = passwordBoxContraseña.Password;

            try
            {
                InstanceContext instanceContext = new InstanceContext(this);
                ServidorLoteria.ServicioCuentaUsuarioClient client = new ServidorLoteria.ServicioCuentaUsuarioClient(instanceContext);

                if(ValidarDatosIngresados(nombreUsuario, contraseña))
                {
                    client.IniciarSesion(nombreUsuario, contraseña);
                    DesplegarPrincipal(textBoxNombreUsuario.Text);
                }
                else
                {
                    MessageBox.Show("Datos invalidos");
                }   
            }
            catch (EndpointNotFoundException)
            {
                
            }
            
        }

        private void DesplegarPrincipal(string text)
        {
            Principal ventana = new Principal();
            ventana.LabelNombreUsuario.Content = text;
            //ventana.LabelNombreUsuario.Content = usuario.NombreUsuario;
            ventana.Show();
            this.Close();
        }

        private bool ValidarDatosIngresados(string nombreUsuario, string contraseña)
        {
            bool datosValidos = false;

            if(nombreUsuario != "" && contraseña != "")
            {
                datosValidos = true;
                return datosValidos;
            }
            else
            {
                return datosValidos;
            }
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

        public void Response(string mensaje)
        {
            throw new NotImplementedException();
        }

        public void DevuelveObjeto(CuentaSet cuenta)
        {
            usuario = new Usuario() {
                NombreUsuario = cuenta.nombreUsuario,
                Correo = cuenta.correo,
                Contraseña = cuenta.contraseña,
                Puntaje = cuenta.puntajeMaximo,
                FotoPerfil = cuenta.fotoPerfil
            };
        }

        public void Respuesta(string mensaje)
        {
            MessageBox.Show(mensaje);
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

        public void MensajeChat(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
