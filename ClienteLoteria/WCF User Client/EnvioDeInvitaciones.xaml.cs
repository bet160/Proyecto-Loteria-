﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LoteriaEmail;

namespace ClienteLoteria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class EnvioDeInvitaciones : Window
    {
        public EnvioDeInvitaciones()
        {
            InitializeComponent();
        }

       

        private void DesplegarSalaDeJuego(object sender, RoutedEventArgs e)
        {
            /*SeleccionTematicaCarros ventana = new SeleccionTematicaCarros();
            ventana.Show();
            this.Close();*/
        }

        private void DesplegarPrincipal(object sender, RoutedEventArgs e)
        {
            Principal ventana = new Principal();
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
    }
}