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
using ClienteLoteria.Model;

namespace ClienteLoteria
{

    public partial class Verificacion : Window
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
                WCF_User_Client.ServidorLoteria.ServicioCuentaUsuarioClient cliente = new WCF_User_Client.ServidorLoteria.ServicioCuentaUsuarioClient(instanceContext);
                WCF_User_Client.ServidorLoteria.CuentaSet cuenta = new WCF_User_Client.ServidorLoteria.CuentaSet() {
                    nombreUsuario = cuentaCreada.NombreUsuario,
                    correo = cuentaCreada.Correo,
                    contraseña = cuentaCreada.Contraseña
                };
                
                cliente.GuardarCuentaUsuario(cuenta);
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
    }
}
