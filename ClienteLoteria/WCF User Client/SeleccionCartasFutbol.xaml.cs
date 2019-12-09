using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using WCF_User_Client.Model;
using WCF_User_Client.ServidorLoteria;

namespace ClienteLoteria

{

    public partial class SeleccionCartasFutbol : Window
    {
        private int tiempoDisponible;
        private DispatcherTimer timer;
        private List<Image> imagenesDisponibles = new List<Image>();
        private List<int> numeroDeImagenSeleccionada = new List<int>();
        private List<Image> imagenesOcultas = new List<Image>();
        private List<Image> imagenesSeleccionadas = new List<Image>();
        private Tabla tabla;
        private CuentaSet cuenta;
        private string nombreUsuario;
        private const string TEMATICA = "Futbol";
        private const int CANTIDADMINIMADECARTAS = 16;
        private const int TIEMPOLIMITEPARAELEGIRCARTAS = 0;

        public SeleccionCartasFutbol(CuentaSet cuenta, int tiempo, string nombreUsuario)
        {
            InitializeComponent();
            CrearListaImagenesDisponibles();
            tiempoDisponible = tiempo;
            this.nombreUsuario = nombreUsuario;
            this.cuenta = cuenta;
            GuardarLugaresDisponibles();
            IniciarCuentaRegresiva();
        }

        private void DesplegarVentana(Window ventana)
        {
            ventana.Show();
            this.Close();
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

            if (tiempoDisponible >= TIEMPOLIMITEPARAELEGIRCARTAS)
            {
                segundos.Text = tiempoDisponible.ToString();
                tiempoDisponible--;
            }
            else
            {
                timer.Stop();
                tabla = new Tabla();

                if (imagenesOcultas.Count < CANTIDADMINIMADECARTAS)
                {
                    GenerarTablaAleatoria();
                    tabla.CartasDeTabla = imagenesSeleccionadas;
                    Chat ventana = new Chat(tabla, cuenta, nombreUsuario, TEMATICA);
                    DesplegarVentana(ventana);
                }
                else
                {
                    tabla.CartasDeTabla = imagenesSeleccionadas;
                    Chat ventana = new Chat(tabla, cuenta, nombreUsuario, TEMATICA);
                    DesplegarVentana(ventana);
                }
            }
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
        }

        private void EstablecerImagen2(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen2);
        }

        private void EstablecerImagen3(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen3);
        }

        private void EstablecerImagen4(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen4);
        }

        private void EstablecerImagen5(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen5);
        }

        private void EstablecerImagen6(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen6);
        }

        private void EstablecerImagen7(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen7);
        }

        private void EstablecerImagen8(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen8);
        }

        private void EstablecerImagen9(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen9);
        }

        private void EstablecerImagen10(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen10);
        }

        private void EstablecerImagen11(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen11);
        }

        private void EstablecerImagen12(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen12);
        }

        private void EstablecerImagen13(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen13);
        }

        private void EstablecerImagen14(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen14);
        }

        private void EstablecerImagen15(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen15);
        }

        private void EstablecerImagen16(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen16);
        }

        private void EstablecerImagen17(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen17);
        }

        private void EstablecerImagen18(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen18);
        }

        private void EstablecerImagen19(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen19);
        }

        private void EstablecerImagen20(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen20);
        }

        private void EstablecerImagen21(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen21);
        }

        private void EstablecerImagen22(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen22);
        }

        private void EstablecerImagen23(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen23);
        }

        private void EstablecerImagen24(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen24);
        }

        private void EstablecerImagen25(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen25);
        }

        private void EstablecerImagen26(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen26);
        }

        private void EstablecerImagen27(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen27);
        }

        private void EstablecerImagen28(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen28);
        }

        private void EstablecerImagen29(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen29);
        }

        private void EstablecerImagen30(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen30);
        }

        private void EstablecerImagen31(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen31);
        }

        private void EstablecerImagen32(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen32);
        }

        private void EstablecerImagen33(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen33);
        }

        private void EstablecerImagen34(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen34);
        }

        private void EstablecerImagen35(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen35);
        }

        private void EstablecerImagen36(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen36);
        }

        private void EstablecerImagen37(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen37);
        }

        private void EstablecerImagen38(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen38);
        }

        private void EstablecerImagen39(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen39);
        }

        private void EstablecerImagen40(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen40);
        }

        private void EstablecerImagen41(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen41);
        }

        private void EstablecerImagen42(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen42);
        }

        private void EstablecerImagen43(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen43);
        }

        private void EstablecerImagen44(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen44);
        }

        private void EstablecerImagen45(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen45);
        }

        private void EstablecerImagen46(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen46);
        }

        private void EstablecerImagen47(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen47);
        }

        private void EstablecerImagen48(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen48);
        }

        private void EstablecerImagen49(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen49);
        }

        private void EstablecerImagen50(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen50);
        }

        private void EstablecerImagen51(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen51);
        }

        private void EstablecerImagen52(object sender, MouseButtonEventArgs e)
        {
            ValidarImagen(imagen52);
        }

        private void BorrarImagen(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada1);
        }

        private void BorrarImagen2(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada2);
        }

        private void BorrarImagen3(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada3);
        }

        private void BorrarImagen4(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada4);
        }

        private void BorrarImagen5(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada5);
        }

        private void BorrarImagen6(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada6);
        }

        private void BorrarImagen7(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada7);
        }

        private void BorrarImagen8(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada8);
        }

        private void BorrarImagen9(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada9);
        }

        private void BorrarImagen10(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada10);
        }

        private void BorrarImagen11(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada11);
        }

        private void BorrarImagen12(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada12);
        }

        private void BorrarImagen13(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada13);
        }

        private void BorrarImagen14(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada14);
        }

        private void BorrarImagen15(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada15);
        }

        private void BorrarImagen16(object sender, MouseButtonEventArgs e)
        {
            RestablecerImagen(imagenSeleccionada16);
        }

        private void OcultarCarta(Image imagen)
        {
            imagen.Visibility = Visibility.Hidden;
            imagenesOcultas.Add(imagen);
        }

        private void RestablecerImagen(Image imagenARestablecer)
        {
            foreach (Image imagen in imagenesOcultas)
            {
                if (imagen.Source.Equals(imagenARestablecer.Source))
                {
                    imagen.Visibility = Visibility.Visible;
                    imagenARestablecer.Source = null;
                    imagenesOcultas.Remove(imagen);
                    break;
                }
            }
        }

        private void GuardarLugaresDisponibles()
        {
            imagenesSeleccionadas.Add(imagenSeleccionada1);
            imagenesSeleccionadas.Add(imagenSeleccionada2);
            imagenesSeleccionadas.Add(imagenSeleccionada3);
            imagenesSeleccionadas.Add(imagenSeleccionada4);
            imagenesSeleccionadas.Add(imagenSeleccionada5);
            imagenesSeleccionadas.Add(imagenSeleccionada6);
            imagenesSeleccionadas.Add(imagenSeleccionada7);
            imagenesSeleccionadas.Add(imagenSeleccionada8);
            imagenesSeleccionadas.Add(imagenSeleccionada9);
            imagenesSeleccionadas.Add(imagenSeleccionada10);
            imagenesSeleccionadas.Add(imagenSeleccionada11);
            imagenesSeleccionadas.Add(imagenSeleccionada12);
            imagenesSeleccionadas.Add(imagenSeleccionada13);
            imagenesSeleccionadas.Add(imagenSeleccionada14);
            imagenesSeleccionadas.Add(imagenSeleccionada15);
            imagenesSeleccionadas.Add(imagenSeleccionada16);
        }

        private void ValidarImagen(Image imagen)
        {
            if (imagenesOcultas.Count < CANTIDADMINIMADECARTAS)
            {
                foreach (var ima in imagenesSeleccionadas)
                {
                    if (ima.Source == null)
                    {
                        OcultarCarta(imagen);
                        ima.Source = imagen.Source;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show(Application.Current.Resources["MensajeMaximoImagenes"].ToString());
            }
        }

        private void DesplegarTablasAleaotias(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            SeleccionTablaAleatoriaFutbol ventana = new SeleccionTablaAleatoriaFutbol(tiempoDisponible, cuenta, nombreUsuario);
            DesplegarVentana(ventana);
        }

        private void CrearListaImagenesDisponibles()
        {
            Image imagen;

            for (int i = 1; i <= 52; i++)
            {
                imagen = new Image();
                Uri resourceUri = new Uri("RecursosTematicaFutbol/" + i.ToString() + ".jpg", UriKind.Relative);
                imagen.Source = new BitmapImage(resourceUri);
                imagenesDisponibles.Add(imagen);
            }
        }

        private void GenerarTablaAleatoria()
        {
            imagenesSeleccionadas.Clear();

            CrearAleatorios(numeroDeImagenSeleccionada);

            for (int i = 0; i <= 15; i++)
            {
                imagenesSeleccionadas.Add(AgregarImagenALista(i));
            }
        }

        private Image AgregarImagenALista(int indice)
        {
            Image imagen = imagenesDisponibles[numeroDeImagenSeleccionada[indice]];
            return imagen;
        }

        private void CrearAleatorios(List<int> imagenes)
        {
            int numeroImagen;

            while (imagenes.Count < CANTIDADMINIMADECARTAS)
            {
                numeroImagen = GenerarNumeroAleatorio();
                if (!imagenes.Contains(numeroImagen))
                {
                    imagenes.Add(numeroImagen);
                }
            }

        }

        private int GenerarNumeroAleatorio()
        {
            int numero;
            Random numeroAleatorio = new Random();
            numero = numeroAleatorio.Next(1, 52);
            return numero;
        }
    }
}
