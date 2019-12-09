using System;
using System.Windows;
using WCF_User_Client.ServidorLoteria;
using System.ServiceModel;
using WCF_User_Client.Model;
using System.Collections.Generic;


namespace ClienteLoteria
{
    [CallbackBehavior(UseSynchronizationContext = false)]
    /// <summary>
    /// Lógica de interacción para Verificacion.xaml
    /// </summary>
    
    public partial class ConsultaPuntajes : Window, WCF_User_Client.ServidorLoteria.IServicioCuentaUsuarioCallback
    {
        private CuentaSet cuenta;

        public ConsultaPuntajes(CuentaSet cuenta)
        {
            InitializeComponent();
            InstanceContext instanceContext = new InstanceContext(this);
            WCF_User_Client.ServidorLoteria.ServicioCuentaUsuarioClient cliente = new WCF_User_Client.ServidorLoteria.ServicioCuentaUsuarioClient(instanceContext);
            cliente.SolicitarPuntajes();

        }

        private void DesplegarPrincipal(object sender, RoutedEventArgs e)
        {
            Principal ventana = new Principal(cuenta);
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
            List<Puntajes> puntajes1 = new List<Puntajes>();
            foreach (var valor in puntajes)
            {
                puntajes1.Add(new Puntajes() {NombreUsuario=valor.nombreUsuario,Puntaje=valor.puntajeMaximo });
            }
            this.Dispatcher.Invoke(() =>
            {
                lvUsers.ItemsSource= puntajes1;
            });
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
