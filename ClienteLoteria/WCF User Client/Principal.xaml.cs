using System;

using System.Windows;
using System.ServiceModel;
using WCF_User_Client.ServidorLoteria;
using WCF_User_Client.Model;
using System.Collections.Generic;
using ClienteLoteria.Model;

namespace ClienteLoteria

{
    [CallbackBehavior(UseSynchronizationContext = false)]
    /// <summary>
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    public partial class Principal : Window, WCF_User_Client.ServidorLoteria.IServicioCuentaUsuarioCallback
    {
        private CuentaSet cuenta;

        public Principal(CuentaSet cuenta)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            LabelNombreUsuario.Content = cuenta.nombreUsuario;
            LabelPuntaje.Content = cuenta.puntajeMaximo;
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

        private void DesplegarEditarPerfil(object sender, RoutedEventArgs e)
        {
            EditarPerfil newForm = new EditarPerfil(cuenta);
            newForm.Show();
            this.Close();
        }

        private void DesplegarPuntajes(object sender, RoutedEventArgs e)
        {
            ConsultaPuntajes consulta = new ConsultaPuntajes(cuenta);
            consulta.Show();
            this.Close();

        }

        private void DesplegarTematicas(object sender, RoutedEventArgs e)
        {
            SeleccionTematica newForm = new SeleccionTematica();
            newForm.Show();
            this.Close();
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
           
            this.Dispatcher.Invoke(() =>
            {
                LabelNombreUsuario.Content = user.NombreUsuario;
                LabelPuntaje.Content = " " + user.Puntaje;
            });
        }

        public void DevuelvePuntajes(PuntajeUsuario[] puntajes)
        {
            List<Puntajes> puntajes1 = new List<Puntajes>();
            Puntajes modelo = new Puntajes();
            foreach (var valor in puntajes)
            {
                modelo.NombreUsuario = valor.nombreUsuario;
                modelo.Puntaje = valor.puntajeMaximo;
                puntajes1.Add(modelo);
                MessageBox.Show(valor.nombreUsuario);
            }
        }

        public void MensajeChat(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public void RecibirInvitacion(string mensaje, string nombreUsuario, string tematica)
        {
            MessageBox.Show(nombreUsuario,mensaje, MessageBoxButton.YesNo);

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
