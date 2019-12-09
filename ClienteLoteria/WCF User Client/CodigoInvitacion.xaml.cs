using System;
using System.Windows;


namespace ClienteLoteria
{
    /// <summary>
    /// Lógica de interacción para Verificacion.xaml
    /// </summary>
    public partial class CodigoInvitacion : Window
    {
        public string CodigoVerificacion { get; set; }
        public CodigoInvitacion()
        {
            InitializeComponent();
        }



        private void DesplegarPrincipal(object sender, RoutedEventArgs e)
        {
            string codigoIngresado = textBoxCodigo.Text.Trim();

            if (ValidarDatosIngresados(codigoIngresado))
            {
                if (String.Equals(codigoIngresado, CodigoVerificacion))
                {
                    MessageBox.Show("Validacion exitosa");
                }
                else
                {
                    MessageBox.Show("Codigo incorrecto");
                }

            }
            InicioSesion ventana = new InicioSesion();
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
