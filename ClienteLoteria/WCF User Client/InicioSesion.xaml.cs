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
using WCF_User_Client;
using WCF_User_Client.ServidorLoteria;

namespace ClienteLoteria
{
    /// <summary>
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    /// 
    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class InicioSesion : Window, WCF_User_Client.ServidorLoteria.IServicioCuentaUsuarioCallback
    {


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
                WCF_User_Client.ServidorLoteria.ServicioCuentaUsuarioClient client = new WCF_User_Client.ServidorLoteria.ServicioCuentaUsuarioClient(instanceContext);

                if(ValidarDatosIngresados(nombreUsuario, contraseña))
                {
                    client.IniciarSesion(nombreUsuario, contraseña);
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
            this.Dispatcher.Invoke(() =>
            {
                Principal ventana = new Principal(cuenta);
                this.Close();
                ventana.Show();
               
            });
        }

        public void DevuelvePuntajes(PuntajeUsuario[] puntajes)
        {
            throw new NotImplementedException();
        }

        public void RecibirInvitacion(string mensaje, string nombreUsuario, string tematica)
        {
            this.Dispatcher.Invoke(() =>
            {
                ConfirmarInvitacion ventana = new ConfirmarInvitacion(nombreUsuario,tematica);
                ventana.MensajeInvitacion.Content = nombreUsuario + " " + mensaje + " en la tematica de " + tematica;
                ventana.Show();
                this.Close();
            });
        }

        public void RecibirConfirmacion(bool opcion, string tematica)
        {
            if (opcion == true)
            {
                if (tematica.Equals("Carros"))
                {
                    MessageBox.Show("Se ha aceptado su invitación");
                    this.Dispatcher.Invoke(() =>
                    {
                        SeleccionCartasCarros ventana = new SeleccionCartasCarros();
                        this.Close();
                        ventana.Show();

                    });
                }
                if (tematica.Equals("Futbol"))
                {
                    MessageBox.Show("Se ha aceptado su invitación");
                    this.Dispatcher.Invoke(() =>
                    {
                        SeleccionCartasFutbol ventana = new SeleccionCartasFutbol();
                        this.Close();
                        ventana.Show();

                    });
                }
            }
            else
            {
                MessageBox.Show("No se acepto la invitación");
            }
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
