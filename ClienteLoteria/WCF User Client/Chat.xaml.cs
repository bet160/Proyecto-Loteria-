using System;
using System.ServiceModel;
using System.Windows;
using System.Windows.Threading;
using WCF_User_Client.Model;
using WCF_User_Client.ServidorLoteria;

namespace ClienteLoteria
{

    public partial class Chat : Window, IServicioCuentaUsuarioCallback
    {

        private Tabla tabla;
        private CuentaSet cuenta;
        private string nombreUsuario;
        private int tiempoDisponible = 60;
        private DispatcherTimer timer;
        private string tematica;
        private const int TIEMPOLIMITE = 0;

        public Chat(Tabla tablaDePartida, CuentaSet cuenta, string nombreDeUsuario, string tematicaElegida)
        {
            InitializeComponent();
            tabla = tablaDePartida;
            this.cuenta = cuenta;
            tematica = tematicaElegida;
            nombreUsuario = nombreDeUsuario;
            IniciarCuentaRegresiva();
        }

        private void IniciarCuentaRegresiva()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            if (tiempoDisponible >= TIEMPOLIMITE)
            {
                segundosDisponibles.Content = tiempoDisponible.ToString();
                tiempoDisponible--;
            }
            else
            {
                timer.Stop();
                Partida ventana = new Partida(cuenta, nombreUsuario, tabla, tematica);
                DesplegarVentana(ventana);
            }
        }

        private void DesplegarVentana(Window ventana)
        {
            ventana.Show();
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
            throw new NotImplementedException();
        }

        public void DevuelvePuntajes(PuntajeUsuario[] puntajes)
        {
            throw new NotImplementedException();
        }

        public void RecibirInvitacion(string nombreUsuario, string mensaje, string tematica)
        {
            throw new NotImplementedException();
        }

        public void RecibirConfirmacion(bool opcion, string tematica, string nombreUsuario)
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(this);
            ServicioCuentaUsuarioClient cliente = new ServicioCuentaUsuarioClient(instanceContext);
            cliente.EnviarMensajeChat(nombreUsuario,"mensaje de chat",cuenta.nombreUsuario);
        }
    }
}
