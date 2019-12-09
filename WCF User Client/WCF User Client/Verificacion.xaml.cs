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
    /// Lógica de interacción para Verificacion.xaml
    /// </summary>
    public partial class Verificacion : Window
    {
        private string codigoVerificacion;

        public Verificacion()
        {
            InitializeComponent();
        }

        public string CodigoVerificacion { get => codigoVerificacion; set => codigoVerificacion = value; }

        private void DesplegarPrincipal(object sender, RoutedEventArgs e)
        {
            /*string codigoIngresado = textBoxCodigo.Text.Trim();

            if (ValidarDatosIngresados(codigoIngresado))
            {
                if (String.Equals(codigoIngresado, codigoVerificacion))
                {
                    MessageBox.Show("Validacion exitosa");
                }
                else
                {
                    MessageBox.Show("Codigo incorrecto");
                }

            }*/
            Principal ventana = new Principal();
            ventana.Show();
            this.Close();
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

        /* private void RegistrarUsuario()
         {
             ServidorLoteria.ServicioCuentaUsuarioClient cliente = new ServidorLoteria.ServicioCuentaUsuarioClient();
             ServidorLoteria.Cuenta usuario = new ServidorLoteria.Cuenta();

             usuario.nombreUsuario = textNombreUsuario.Text;
             usuario.correo = textCorreo.Text;
             usuario.contraseña = textContraseña.Text;
             usuario.puntajeMaximo = "1234";
         }*/

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
