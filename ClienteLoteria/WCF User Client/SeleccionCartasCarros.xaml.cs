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
using System.Windows.Threading;
using WCF_User_Client.Model;

namespace ClienteLoteria

{
    public partial class SeleccionCartasCarros : Window
    {
        private List<Image> imagenesVisiblesUI = new List<Image>();
        private int tiempoDisponible = 60;
        private DispatcherTimer timer;
        private List<int> pos = new List<int>();
        private List<Image> mazo = new List<Image>();
        private int pc = 0;
        public SeleccionCartasCarros()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            if (tiempoDisponible >= 0)
            {
                segundos.Text = string.Format("{0}", tiempoDisponible % 60);
                tiempoDisponible--;
            }
            else
            {
                timer.Stop();
                if (pc <= 51)
                {
                    tiempoDisponible = 60;
                    Partida newForm = new Partida();
                    newForm.Show();
                    this.Close();

                }
            }
        }
        Tabla tabla;
        private List<Image> imagenesOcultas = new List<Image>();

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
            imagenesOcultas.Add(imagen1);
        }

        private void EstablecerImagen2(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen2);        
            imagenesOcultas.Add(imagen2);
        }

        private void EstablecerImagen3(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen3);          
            imagenesOcultas.Add(imagen3);
        }

        private void EstablecerImagen4(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen4);
            imagenesOcultas.Add(imagen4);
        }

        private void EstablecerImagen5(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen5);    
            imagenesOcultas.Add(imagen5);
        }

        private void EstablecerImagen6(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen6);           
            imagenesOcultas.Add(imagen6);
        }

        private void EstablecerImagen7(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen7);           
            imagenesOcultas.Add(imagen7);
        }

        private void EstablecerImagen8(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen8);           
            imagenesOcultas.Add(imagen8);
        }

        private void EstablecerImagen9(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen9);           
            imagenesOcultas.Add(imagen9);
        }

        private void EstablecerImagen10(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen10);           
            imagenesOcultas.Add(imagen10);
        }

        private void EstablecerImagen11(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen11);           
            imagenesOcultas.Add(imagen11);
        }

        private void EstablecerImagen12(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen12);           
            imagenesOcultas.Add(imagen12);
        }

        private void EstablecerImagen13(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen13);
            imagenesOcultas.Add(imagen13);
        }

        private void EstablecerImagen14(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen14);           
            imagenesOcultas.Add(imagen14);
        }

        private void EstablecerImagen15(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen15);           
            imagenesOcultas.Add(imagen15);
        }

        private void EstablecerImagen16(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen16);         
            imagenesOcultas.Add(imagen16);
        }

        private void EstablecerImagen17(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen17);           
            imagenesOcultas.Add(imagen17);
        }

        private void EstablecerImagen18(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen18);           
            imagenesOcultas.Add(imagen18);
        }

        private void EstablecerImagen19(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen19);           
            imagenesOcultas.Add(imagen19);
        }

        private void EstablecerImagen20(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen20);           
            imagenesOcultas.Add(imagen20);
        }

        private void EstablecerImagen21(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen21);           
            imagenesOcultas.Add(imagen21);
        }

        private void EstablecerImagen22(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen22);          
            imagenesOcultas.Add(imagen22);
        }

        private void EstablecerImagen23(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen23);         
            imagenesOcultas.Add(imagen23);
        }

        private void EstablecerImagen24(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen24);         
            imagenesOcultas.Add(imagen24);
        }

        private void EstablecerImagen25(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen25);       
            imagenesOcultas.Add(imagen25);
        }

        private void EstablecerImagen26(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen26);
           
            imagenesOcultas.Add(imagen26);
        }

        private void EstablecerImagen27(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen27);
       
            imagenesOcultas.Add(imagen27);
        }

        private void EstablecerImagen28(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen28);
            
            imagenesOcultas.Add(imagen28);
        }

        private void EstablecerImagen29(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen29);
           
            imagenesOcultas.Add(imagen29);
        }

        private void EstablecerImagen30(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen30);
            
            imagenesOcultas.Add(imagen30);
        }

        private void EstablecerImagen31(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen31);
            
            imagenesOcultas.Add(imagen31);
        }

        private void EstablecerImagen32(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen32);
            
            imagenesOcultas.Add(imagen32);
        }

        private void EstablecerImagen33(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen33);
            
            imagenesOcultas.Add(imagen33);
        }

        private void EstablecerImagen34(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen34);
            
            imagenesOcultas.Add(imagen34);
        }

        private void EstablecerImagen35(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen35);
            
            imagenesOcultas.Add(imagen35);
        }

        private void EstablecerImagen36(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen36);
            
            imagenesOcultas.Add(imagen36);
        }

        private void EstablecerImagen37(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen37);
            
            imagenesOcultas.Add(imagen37);
        }

        private void EstablecerImagen38(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen38);
            
            imagenesOcultas.Add(imagen38);
        }

        private void EstablecerImagen39(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen39);
            
            imagenesOcultas.Add(imagen39);
        }

        private void EstablecerImagen40(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen40);
            
            imagenesOcultas.Add(imagen40);
        }

        private void EstablecerImagen41(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen41);
            
            imagenesOcultas.Add(imagen41);
        }

        private void EstablecerImagen42(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen42);
            
            imagenesOcultas.Add(imagen42);
        }

        private void EstablecerImagen43(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen43);
           
            imagenesOcultas.Add(imagen43);
        }

        private void EstablecerImagen44(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen44);
            
            imagenesOcultas.Add(imagen44);
        }

        private void EstablecerImagen45(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen45);
           
            imagenesOcultas.Add(imagen45);
        }

        private void EstablecerImagen46(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen46);
            
            imagenesOcultas.Add(imagen46);
        }

        private void EstablecerImagen47(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen47);
            
            imagenesOcultas.Add(imagen47);
        }

        private void EstablecerImagen48(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen48);
            
            imagenesOcultas.Add(imagen48);
        }

        private void EstablecerImagen49(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen49);
           
            imagenesOcultas.Add(imagen49);
        }

        private void EstablecerImagen50(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen50);
            
            imagenesOcultas.Add(imagen50);
        }

        private void EstablecerImagen51(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen51);
            
            imagenesOcultas.Add(imagen51);
        }

        private void EstablecerImagen52(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen52);
            
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
            {
                OcultarCarta(imagen);
                imagenSeleccionada1.Source = imagen.Source;
            }else if (imagenSeleccionada2.Source == null)
            {
                OcultarCarta(imagen);
                imagenSeleccionada2.Source = imagen.Source;
            }else if (imagenSeleccionada3.Source == null)
            {
                OcultarCarta(imagen);
                imagenSeleccionada3.Source = imagen.Source;
            }else if (imagenSeleccionada4.Source == null)
            {
                OcultarCarta(imagen);
                imagenSeleccionada4.Source = imagen.Source;
            }else if (imagenSeleccionada5.Source == null)
            {
                OcultarCarta(imagen);
                imagenSeleccionada5.Source = imagen.Source;
            }
            else if (imagenSeleccionada6.Source == null)
            {
                OcultarCarta(imagen);
                imagenSeleccionada6.Source = imagen.Source;
            } else if (imagenSeleccionada7.Source == null)
            {
                OcultarCarta(imagen);
                imagenSeleccionada7.Source = imagen.Source;
            }else if (imagenSeleccionada8.Source == null)
            {
                OcultarCarta(imagen);
                imagenSeleccionada8.Source = imagen.Source;
            } else if (imagenSeleccionada9.Source == null)
            {
                OcultarCarta(imagen);
                imagenSeleccionada9.Source = imagen.Source;
            } else if (imagenSeleccionada10.Source == null)
            {
                OcultarCarta(imagen);
                imagenSeleccionada10.Source = imagen.Source;
            } else if (imagenSeleccionada11.Source == null)
            {
                OcultarCarta(imagen);
                imagenSeleccionada11.Source = imagen.Source;
            }else if (imagenSeleccionada12.Source == null)
            {
                OcultarCarta(imagen);
                imagenSeleccionada12.Source = imagen.Source;
            }else if (imagenSeleccionada13.Source == null)
            {
                OcultarCarta(imagen);
                imagenSeleccionada13.Source = imagen.Source;
            }else if (imagenSeleccionada14.Source == null)
            {
                OcultarCarta(imagen);
                imagenSeleccionada14.Source = imagen.Source;
            } else if (imagenSeleccionada15.Source == null)
            {
                OcultarCarta(imagen);
                imagenSeleccionada15.Source = imagen.Source;
            }
            else if (imagenSeleccionada16.Source == null)
            {
                OcultarCarta(imagen);
                imagenSeleccionada16.Source = imagen.Source;
            }
            else
            {
                MessageBox.Show("Máximo de cartas seleccionado");
            }
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

        private void DesplegarTablasAleaotias(object sender, RoutedEventArgs e)
        {
            SeleccionTablaAleatoriaCarros ventana = new SeleccionTablaAleatoriaCarros();
            ventana.Show();
            this.Close();
        }

        private void DesplegarPartida(object sender, RoutedEventArgs e)
        {
            if (ValidarCantidadDeCartasSeleccionadas())
            {
                Partida ventana = new Partida();
                tabla = new Tabla();
                tabla.CartasDeTabla = imagenesOcultas;
                //ventana.ImagenesTabla = imagenesOcultas;
                ventana.Tabla = tabla;
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
