using System;
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
using System.Windows.Shapes;

namespace WCF_User_Client

{
    /// <summary>
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    public partial class SeleccionCartasCarros : Window
    {

        public SeleccionCartasCarros()
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

        private void EstablecerImagen1(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen1);
            InhabilitarCarta(imagen1);
        }

        private void EstablecerImagen2(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen2);
            InhabilitarCarta(imagen2);
        }

        private void EstablecerImagen3(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen3);
            InhabilitarCarta(imagen3);
        }

        private void EstablecerImagen4(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen4);
            InhabilitarCarta(imagen4);
        }

        private void EstablecerImagen5(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen5);
            InhabilitarCarta(imagen5);
        }

        private void EstablecerImagen6(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen6);
            InhabilitarCarta(imagen6);
        }

        private void EstablecerImagen7(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen7);
            InhabilitarCarta(imagen7);
        }

        private void EstablecerImagen8(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen8);
            InhabilitarCarta(imagen8);
        }

        private void EstablecerImagen9(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen9);
            InhabilitarCarta(imagen9);
        }

        private void EstablecerImagen10(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen10);
            InhabilitarCarta(imagen10);
        }

        private void EstablecerImagen11(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen11);
            InhabilitarCarta(imagen11);
        }

        private void EstablecerImagen12(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen12);
            InhabilitarCarta(imagen12);
        }

        private void EstablecerImagen13(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen13);
            InhabilitarCarta(imagen13);
        }

        private void EstablecerImagen14(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen14);
            InhabilitarCarta(imagen14);
        }

        private void EstablecerImagen15(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen15);
            InhabilitarCarta(imagen15);
        }

        private void EstablecerImagen16(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen16);
            InhabilitarCarta(imagen16);
        }

        private void EstablecerImagen17(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen17);
            InhabilitarCarta(imagen17);
        }

        private void EstablecerImagen18(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen18);
            InhabilitarCarta(imagen18);
        }

        private void EstablecerImagen19(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen19);
            InhabilitarCarta(imagen19);
        }

        private void EstablecerImagen20(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen20);
            InhabilitarCarta(imagen20);
        }

        private void EstablecerImagen21(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen21);
            InhabilitarCarta(imagen21);
        }

        private void EstablecerImagen22(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen22);
            InhabilitarCarta(imagen22);
        }

        private void EstablecerImagen23(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen23);
            InhabilitarCarta(imagen23);
        }

        private void EstablecerImagen24(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen24);
            InhabilitarCarta(imagen24);
        }

        private void EstablecerImagen25(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen25);
            InhabilitarCarta(imagen25);
        }

        private void EstablecerImagen26(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen26);
            InhabilitarCarta(imagen26);
        }

        private void EstablecerImagen27(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen27);
            InhabilitarCarta(imagen27);
        }

        private void EstablecerImagen28(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen28);
            InhabilitarCarta(imagen28);
        }

        private void EstablecerImagen29(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen29);
            InhabilitarCarta(imagen29);
        }

        private void EstablecerImagen30(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen30);
            InhabilitarCarta(imagen30);
        }

        private void EstablecerImagen31(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen31);
            InhabilitarCarta(imagen31);
        }

        private void EstablecerImagen32(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen32);
            InhabilitarCarta(imagen32);
        }

        private void EstablecerImagen33(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen33);
            InhabilitarCarta(imagen33);
        }

        private void EstablecerImagen34(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen34);
            InhabilitarCarta(imagen34);
        }

        private void EstablecerImagen35(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen35);
            InhabilitarCarta(imagen35);
        }

        private void EstablecerImagen36(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen36);
            InhabilitarCarta(imagen36);
        }

        private void EstablecerImagen37(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen37);
            InhabilitarCarta(imagen37);
        }

        private void EstablecerImagen38(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen38);
            InhabilitarCarta(imagen38);
        }

        private void EstablecerImagen39(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen39);
            InhabilitarCarta(imagen39);
        }

        private void EstablecerImagen40(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen40);
            InhabilitarCarta(imagen40);
        }

        private void EstablecerImagen41(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen41);
            InhabilitarCarta(imagen41);
        }

        private void EstablecerImagen42(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen42);
            InhabilitarCarta(imagen42);
        }

        private void EstablecerImagen43(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen43);
            InhabilitarCarta(imagen43);
        }

        private void EstablecerImagen44(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen44);
            InhabilitarCarta(imagen44);
        }

        private void EstablecerImagen45(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen45);
            InhabilitarCarta(imagen45);
        }

        private void EstablecerImagen46(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen46);
            InhabilitarCarta(imagen46);
        }

        private void EstablecerImagen47(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen47);
            InhabilitarCarta(imagen47);
        }

        private void EstablecerImagen48(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen48);
            InhabilitarCarta(imagen48);
        }

        private void EstablecerImagen49(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen49);
            InhabilitarCarta(imagen49);
        }

        private void EstablecerImagen50(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen50);
            InhabilitarCarta(imagen50);
        }


        private void EstablecerImagen51(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen51);
            InhabilitarCarta(imagen51);
        }

        private void EstablecerImagen52(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen52);
            InhabilitarCarta(imagen52);
        }

        private void InhabilitarCarta(Image imagen)
        {
            imagen.IsEnabled = false;
        }

        private void ValidarImagen(Image imagen)
        {
            if (imagenSeleccionada1.Source == null)
                imagenSeleccionada1.Source = imagen.Source;
            else if (imagenSeleccionada2.Source == null)
                imagenSeleccionada2.Source = imagen.Source;
            else if (imagenSeleccionada3.Source == null)
                imagenSeleccionada3.Source = imagen.Source;
            else if (imagenSeleccionada4.Source == null)
                imagenSeleccionada4.Source = imagen.Source;
            else if (imagenSeleccionada5.Source == null)
                imagenSeleccionada5.Source = imagen.Source;
            else if (imagenSeleccionada6.Source == null)
                imagenSeleccionada6.Source = imagen.Source;
            else if (imagenSeleccionada7.Source == null)
                imagenSeleccionada7.Source = imagen.Source;
            else if (imagenSeleccionada8.Source == null)
                imagenSeleccionada8.Source = imagen.Source;
            else if (imagenSeleccionada9.Source == null)
                imagenSeleccionada9.Source = imagen.Source;
            else if (imagenSeleccionada10.Source == null)
                imagenSeleccionada10.Source = imagen.Source;
            else if (imagenSeleccionada11.Source == null)
                imagenSeleccionada11.Source = imagen.Source;
            else if (imagenSeleccionada12.Source == null)
                imagenSeleccionada12.Source = imagen.Source;
            else if (imagenSeleccionada13.Source == null)
                imagenSeleccionada13.Source = imagen.Source;
            else if (imagenSeleccionada14.Source == null)
                imagenSeleccionada14.Source = imagen.Source;
            else if (imagenSeleccionada15.Source == null)
                imagenSeleccionada15.Source = imagen.Source;
            else if (imagenSeleccionada16.Source == null)
                imagenSeleccionada16.Source = imagen.Source;
            else
                MessageBox.Show("Ya selecciono el maximo de imagenes");
        }
    }
}
