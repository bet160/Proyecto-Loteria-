﻿using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Windows;
using WCF_User_Client.Model;
using WCF_User_Client.ServidorLoteria;

namespace WCF_User_Client

{
    [CallbackBehavior(UseSynchronizationContext = false)]
    /// <summary>
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    public partial class Principal : Window, ServidorLoteria.IServicioCuentaUsuarioCallback
    {

        public Principal()
        {
            InitializeComponent();
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
            EditarPerfil newForm = new EditarPerfil();
            newForm.Show();
            this.Close();
        }

        private void DesplegarPuntajes(object sender, RoutedEventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(this);
            ServidorLoteria.ServicioCuentaUsuarioClient client = new ServidorLoteria.ServicioCuentaUsuarioClient(instanceContext);
            client.SolicitarPuntajes();
            ConsultaPuntajes newForm = new ConsultaPuntajes();
            newForm.Show();
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
            throw new NotImplementedException();
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
