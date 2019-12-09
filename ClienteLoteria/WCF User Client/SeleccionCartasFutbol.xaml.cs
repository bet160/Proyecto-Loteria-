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

namespace ClienteLoteria

{

    public partial class SeleccionCartasFutbol : Window
    {
        public SeleccionCartasFutbol()
        {
            InitializeComponent();
        }

        private List<Image> imagenesOcultas = new List<Image>();

        private void DesplegarVentanaInicio(object sender, RoutedEventArgs e)
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

        private void EstablecerImagen1(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen1);
            OcultarCarta(imagen1);
            imagenesOcultas.Add(imagen1);
        }

        private void EstablecerImagen2(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen2);
            OcultarCarta(imagen2);
            imagenesOcultas.Add(imagen2);
        }

        private void EstablecerImagen3(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen3);
            OcultarCarta(imagen3);
            imagenesOcultas.Add(imagen3);
        }

        private void EstablecerImagen4(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen4);
            OcultarCarta(imagen4);
            imagenesOcultas.Add(imagen4);
        }

        private void EstablecerImagen5(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen5);
            OcultarCarta(imagen5);
            imagenesOcultas.Add(imagen5);
        }

        private void EstablecerImagen6(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen6);
            OcultarCarta(imagen6);
            imagenesOcultas.Add(imagen6);
        }

        private void EstablecerImagen7(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen7);
            OcultarCarta(imagen7);
            imagenesOcultas.Add(imagen7);
        }

        private void EstablecerImagen8(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen8);
            OcultarCarta(imagen8);
            imagenesOcultas.Add(imagen8);
        }

        private void EstablecerImagen9(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen9);
            OcultarCarta(imagen9);
            imagenesOcultas.Add(imagen9);
        }

        private void EstablecerImagen10(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen10);
            OcultarCarta(imagen10);
            imagenesOcultas.Add(imagen10);
        }

        private void EstablecerImagen11(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen11);
            OcultarCarta(imagen11);
            imagenesOcultas.Add(imagen11);
        }

        private void EstablecerImagen12(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen12);
            OcultarCarta(imagen12);
            imagenesOcultas.Add(imagen12);
        }

        private void EstablecerImagen13(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen13);
            OcultarCarta(imagen13);
            imagenesOcultas.Add(imagen13);
        }

        private void EstablecerImagen14(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen14);
            OcultarCarta(imagen14);
            imagenesOcultas.Add(imagen14);
        }

        private void EstablecerImagen15(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen15);
            OcultarCarta(imagen15);
            imagenesOcultas.Add(imagen15);
        }

        private void EstablecerImagen16(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen16);
            OcultarCarta(imagen16);
            imagenesOcultas.Add(imagen16);
        }

        private void EstablecerImagen17(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen17);
            OcultarCarta(imagen17);
            imagenesOcultas.Add(imagen17);
        }

        private void EstablecerImagen18(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen18);
            OcultarCarta(imagen18);
            imagenesOcultas.Add(imagen18);
        }

        private void EstablecerImagen19(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen19);
            OcultarCarta(imagen19);
            imagenesOcultas.Add(imagen19);
        }

        private void EstablecerImagen20(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen20);
            OcultarCarta(imagen20);
            imagenesOcultas.Add(imagen20);
        }

        private void EstablecerImagen21(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen21);
            OcultarCarta(imagen21);
            imagenesOcultas.Add(imagen21);
        }

        private void EstablecerImagen22(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen22);
            OcultarCarta(imagen22);
            imagenesOcultas.Add(imagen22);
        }

        private void EstablecerImagen23(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen23);
            OcultarCarta(imagen23);
            imagenesOcultas.Add(imagen23);
        }

        private void EstablecerImagen24(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen24);
            OcultarCarta(imagen24);
            imagenesOcultas.Add(imagen24);
        }

        private void EstablecerImagen25(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen25);
            OcultarCarta(imagen25);
            imagenesOcultas.Add(imagen25);
        }

        private void EstablecerImagen26(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen26);
            OcultarCarta(imagen26);
            imagenesOcultas.Add(imagen26);
        }

        private void EstablecerImagen27(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen27);
            OcultarCarta(imagen27);
            imagenesOcultas.Add(imagen27);
        }

        private void EstablecerImagen28(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen28);
            OcultarCarta(imagen28);
            imagenesOcultas.Add(imagen28);
        }

        private void EstablecerImagen29(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen29);
            OcultarCarta(imagen29);
            imagenesOcultas.Add(imagen29);
        }

        private void EstablecerImagen30(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen30);
            OcultarCarta(imagen30);
            imagenesOcultas.Add(imagen30);
        }

        private void EstablecerImagen31(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen31);
            OcultarCarta(imagen31);
            imagenesOcultas.Add(imagen31);
        }

        private void EstablecerImagen32(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen32);
            OcultarCarta(imagen32);
            imagenesOcultas.Add(imagen32);
        }

        private void EstablecerImagen33(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen33);
            OcultarCarta(imagen33);
            imagenesOcultas.Add(imagen33);
        }

        private void EstablecerImagen34(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen34);
            OcultarCarta(imagen34);
            imagenesOcultas.Add(imagen34);
        }

        private void EstablecerImagen35(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen35);
            OcultarCarta(imagen35);
            imagenesOcultas.Add(imagen35);
        }

        private void EstablecerImagen36(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen36);
            OcultarCarta(imagen36);
            imagenesOcultas.Add(imagen36);
        }

        private void EstablecerImagen37(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen37);
            OcultarCarta(imagen37);
            imagenesOcultas.Add(imagen37);
        }

        private void EstablecerImagen38(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen38);
            OcultarCarta(imagen38);
            imagenesOcultas.Add(imagen38);
        }

        private void EstablecerImagen39(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen39);
            OcultarCarta(imagen39);
            imagenesOcultas.Add(imagen39);
        }

        private void EstablecerImagen40(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen40);
            OcultarCarta(imagen40);
            imagenesOcultas.Add(imagen40);
        }

        private void EstablecerImagen41(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen41);
            OcultarCarta(imagen41);
            imagenesOcultas.Add(imagen41);
        }

        private void EstablecerImagen42(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen42);
            OcultarCarta(imagen42);
            imagenesOcultas.Add(imagen42);
        }

        private void EstablecerImagen43(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen43);
            OcultarCarta(imagen43);
            imagenesOcultas.Add(imagen43);
        }

        private void EstablecerImagen44(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen44);
            OcultarCarta(imagen44);
            imagenesOcultas.Add(imagen44);
        }

        private void EstablecerImagen45(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen45);
            OcultarCarta(imagen45);
            imagenesOcultas.Add(imagen45);
        }

        private void EstablecerImagen46(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen46);
            OcultarCarta(imagen46);
            imagenesOcultas.Add(imagen46);
        }

        private void EstablecerImagen47(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen47);
            OcultarCarta(imagen47);
            imagenesOcultas.Add(imagen47);
        }

        private void EstablecerImagen48(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen48);
            OcultarCarta(imagen48);
            imagenesOcultas.Add(imagen48);
        }

        private void EstablecerImagen49(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen49);
            OcultarCarta(imagen49);
            imagenesOcultas.Add(imagen49);
        }

        private void EstablecerImagen50(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen50);
            OcultarCarta(imagen50);
            imagenesOcultas.Add(imagen50);
        }

        private void EstablecerImagen51(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen51);
            OcultarCarta(imagen51);
            imagenesOcultas.Add(imagen51);
        }

        private void EstablecerImagen52(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen52);
            OcultarCarta(imagen52);
            imagenesOcultas.Add(imagen52);
        }

        private void BorrarImagen(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada1);
            imagenSeleccionada1.Source = null;
        }

        private void BorrarImagen2(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada2);
            imagenSeleccionada2.Source = null;
        }

        private void BorrarImagen3(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada3);
            imagenSeleccionada3.Source = null;
        }

        private void BorrarImagen4(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada4);
            imagenSeleccionada4.Source = null;
        }

        private void BorrarImagen5(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada5);
            imagenSeleccionada5.Source = null;
        }

        private void BorrarImagen6(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada6);
            imagenSeleccionada6.Source = null;
        }

        private void BorrarImagen7(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada7);
            imagenSeleccionada7.Source = null;
        }

        private void BorrarImagen8(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada8);
            imagenSeleccionada8.Source = null;
        }

        private void BorrarImagen9(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada9);
            imagenSeleccionada9.Source = null;
        }

        private void BorrarImagen10(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada10);
            imagenSeleccionada10.Source = null;
        }

        private void BorrarImagen11(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada11);
            imagenSeleccionada11.Source = null;
        }

        private void BorrarImagen12(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada12);
            imagenSeleccionada12.Source = null;
        }

        private void BorrarImagen13(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada13);
            imagenSeleccionada13.Source = null;
        }

        private void BorrarImagen14(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada14);
            imagenSeleccionada14.Source = null;
        }

        private void BorrarImagen15(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada15);
            imagenSeleccionada15.Source = null;
        }

        private void BorrarImagen16(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada16);
            imagenSeleccionada16.Source = null;
        }

        private void OcultarCarta(Image imagen)
        {
            imagen.Visibility = System.Windows.Visibility.Hidden;
        }

        private void RestablecerImagen(Image e)
        {
            foreach (Image ima in imagenesOcultas)
            {
                if (ima.Source.Equals(e.Source))
                    ima.Visibility = System.Windows.Visibility.Visible;
                    imagenesOcultas.Remove(e);
            }
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

        private void DesplegarTablasAleaotias(object sender, RoutedEventArgs e)
        {
            SeleccionTablaAleatoriaFutbol ventana = new SeleccionTablaAleatoriaFutbol();
            ventana.Show();
            this.Close();
        }

        private bool ValidarCantidadDeCartasSeleccionadas()
        {
            bool cantidadValida = false;
            if (imagenesOcultas.Count < 16)
                return cantidadValida;
            else
                cantidadValida = true;
            return cantidadValida;
        }

        private void DesplegarPartida(object sender, RoutedEventArgs e)
        {
            if (ValidarCantidadDeCartasSeleccionadas())
            {
                Partida ventana = new Partida();
                ventana.ImagenesTabla = imagenesOcultas;
                ventana.MostrarImagenesVisibles();
                ventana.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Cantidad de cartas seleccionadas menor a la requerida, minimo debe seleccionar 16 cartas");
            }
        }
    }
}
