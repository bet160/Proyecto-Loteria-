using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Windows;
using System.Windows.Controls;
using ClienteLoteria.Model;
using WCF_User_Client.ServidorLoteria;

namespace ClienteLoteria
{

    public partial class Verificacion : Window, WCF_User_Client.ServidorLoteria.IServicioCuentaUsuarioCallback
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
                    InicioSesion inicio = new InicioSesion();
                    inicio.Show();
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

        public void MensajeChat(string mensaje)
        {
            throw new NotImplementedException();
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

        public void RecibirInvitacion(string mensaje, string nombreUsuario, string tematica)
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

        public void RecibirFinPartida(string nombreUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
