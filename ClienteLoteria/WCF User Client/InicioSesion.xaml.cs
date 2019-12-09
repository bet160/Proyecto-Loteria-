using System;
using System.ServiceModel;
using System.Windows;
using WCF_User_Client;
using WCF_User_Client.ServidorLoteria;

namespace ClienteLoteria
{

    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class InicioSesion : Window, IServicioCuentaUsuarioCallback
    {
        private CuentaSet cuenta;
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void IniciarSesion(object sender, RoutedEventArgs e)
        {
            string nombreUsuario = textBoxNombreUsuario.Text.Trim();
            string contraseña = passwordBoxContraseña.Password.Trim();

            try
            {
                InstanceContext instanceContext = new InstanceContext(this);
                ServicioCuentaUsuarioClient cliente = new ServicioCuentaUsuarioClient(instanceContext);

                if(ValidarDatosIngresados(nombreUsuario, contraseña))
                {
                    cliente.IniciarSesion(nombreUsuario, contraseña);
                    
                }
                else
                {
                    MessageBox.Show(Application.Current.Resources["DatosInvalidos"].ToString());
                }   
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show(Application.Current.Resources["OperacionInvalida"].ToString());
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
            Inicio ventana = new Inicio();
            DesplegarVentana(ventana);
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
           
            
        }

        public void Respuesta(string mensaje)
        {
            mensaje = Application.Current.Resources["CredencialesInvalidas"].ToString();
            MessageBox.Show(mensaje);
        }

        public void DevuelveCuenta(CuentaSet cuenta)
        {
            Dispatcher.Invoke(() =>
            {
                this.cuenta = cuenta;
                Principal ventana = new Principal(cuenta);
                DesplegarVentana(ventana);
               
            });
        }

        private void DesplegarVentana(Window ventana)
        {
            ventana.Show();
            this.Close();
        }

        public void DevuelvePuntajes(PuntajeUsuario[] puntajes)
        {
            throw new NotImplementedException();
        }

        public void RecibirInvitacion(string nombreUsuario, string mensaje, string tematica)
        {
            Dispatcher.Invoke(() =>
            {
                ConfirmarInvitacion ventana = new ConfirmarInvitacion(cuenta,nombreUsuario,tematica,mensaje);
                DesplegarVentana(ventana);

            });
        }

        public void RecibirConfirmacion(bool opcion, string tematica,string nombreUsuario)
        {
            if (opcion == true)
            {
                if (tematica.Equals("Carros"))
                {
                    Dispatcher.Invoke(() =>
                    {
                        SeleccionCartasCarros ventana = new SeleccionCartasCarros(cuenta, 60, nombreUsuario);
                        this.Close();
                        ventana.Show();

                    });
                }
                if (tematica.Equals("Futbol"))
                {
                    MessageBox.Show("Se ha aceptado su invitación");
                    Dispatcher.Invoke(() =>
                    {
                        SeleccionCartasFutbol ventana = new SeleccionCartasFutbol(cuenta, 60, nombreUsuario);
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

        public void RecibirFinPartida(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
