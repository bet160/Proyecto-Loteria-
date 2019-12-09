using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using WCF_User_Client.Model;
using WCF_User_Client.ServidorLoteria;

namespace ClienteLoteria

{
    public partial class SeleccionTablaAleatoriaCarros : Window
    {
        private List<Image> imagenesDisponibles = new List<Image>();
        private List<int> imagenesSeleccionadas = new List<int>();
        private List<Image> imagenesTabla1 = new List<Image>();
        private List<Image> imagenesTabla2 = new List<Image>();
        private List<Image> imagenesTabla3 = new List<Image>();
        private List<Image> imagenesTabla4 = new List<Image>();
        private List<Image> imagenesVisiblesUI = new List<Image>();
        private Tabla tabla = new Tabla();
        private const string TEMATICA = "Carros";
        private int tiempoDisponible;
        private DispatcherTimer timer;
        private CuentaSet cuenta;
        private string nombreUsuario;
        private const int CANTIDADMINIMADECARTAS = 16;
        private const int TIEMPOLIMITEPARAELEGIRCARTAS = 0;

        public SeleccionTablaAleatoriaCarros(int tiempoDisponible, CuentaSet cuenta, string nombreUsuario)
        {
            InitializeComponent();
            this.tiempoDisponible = tiempoDisponible;
            this.cuenta = cuenta;
            this.nombreUsuario = nombreUsuario;
            IniciarCuentaRegresiva();
            CrearListaImagenesDisponibles();
            GuardarElementosEnListaDeImagenesVisiblesUI();
            guardarImagenesEnListaDeTabla(imagenesTabla1);
            guardarImagenesEnListaDeTabla(imagenesTabla2);
            guardarImagenesEnListaDeTabla(imagenesTabla3);
            guardarImagenesEnListaDeTabla(imagenesTabla4);
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
                ValidarSeleccion();
                Chat ventana = new Chat(tabla, cuenta, nombreUsuario, TEMATICA);
                DesplegarVentana(ventana);
            }
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

        private void ValidarSeleccion()
        {
            if(imagenSeleccionada1.Source == null)
            {
                tabla.CartasDeTabla = imagenesTabla1;
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

        private void EstablecerImagenesTabla1(object sender, RoutedEventArgs e)
        {
            MostrarImagenesVisibles(imagenesTabla1);
            tabla.CartasDeTabla = imagenesTabla1;
        }

        private void EstablecerImagenesTabla2(object sender, RoutedEventArgs e)
        {
            MostrarImagenesVisibles(imagenesTabla2);
            tabla.CartasDeTabla = imagenesTabla2;
        }

        private void EstablecerImagenesTabla3(object sender, RoutedEventArgs e)
        {
            MostrarImagenesVisibles(imagenesTabla3);
            tabla.CartasDeTabla = imagenesTabla3;
        }

        private void EstablecerImagenesTabla4(object sender, RoutedEventArgs e)
        {
            MostrarImagenesVisibles(imagenesTabla4);
            tabla.CartasDeTabla = imagenesTabla4;
        }

        private void CrearListaImagenesDisponibles()
        {
            Image imagen;

            for (int i=1; i<=52; i++)
            {
                imagen = new Image();
                Uri resourceUri = new Uri("RecursosTematicaCarros/" + i.ToString() + ".jpg", UriKind.Relative);
                imagen.Source = new BitmapImage(resourceUri);
                imagenesDisponibles.Add(imagen);
            }
        }

        private void GuardarElementosEnListaDeImagenesVisiblesUI()
        {
            imagenesVisiblesUI.Add(imagenSeleccionada1);
            imagenesVisiblesUI.Add(imagenSeleccionada2);
            imagenesVisiblesUI.Add(imagenSeleccionada3);
            imagenesVisiblesUI.Add(imagenSeleccionada4);
            imagenesVisiblesUI.Add(imagenSeleccionada5);
            imagenesVisiblesUI.Add(imagenSeleccionada6);
            imagenesVisiblesUI.Add(imagenSeleccionada7);
            imagenesVisiblesUI.Add(imagenSeleccionada8);
            imagenesVisiblesUI.Add(imagenSeleccionada9);
            imagenesVisiblesUI.Add(imagenSeleccionada10);
            imagenesVisiblesUI.Add(imagenSeleccionada11);
            imagenesVisiblesUI.Add(imagenSeleccionada12);
            imagenesVisiblesUI.Add(imagenSeleccionada13);
            imagenesVisiblesUI.Add(imagenSeleccionada14);
            imagenesVisiblesUI.Add(imagenSeleccionada15);
            imagenesVisiblesUI.Add(imagenSeleccionada16);
        }

        private void MostrarImagenesVisibles(List<Image> lista)
        {
            for(int i = 0; i<=15; i++)
            {
                imagenesVisiblesUI[i].Source = lista[i].Source;
            }
        }
 
        private void guardarImagenesEnListaDeTabla(List<Image> lista)
        {
            CrearAleatorios(imagenesSeleccionadas);

            for(int i = 0; i <= 15; i++)
            {
                lista.Add(AgregarImagenALista(i));
            }

            imagenesSeleccionadas.Clear();
        }

        private Image AgregarImagenALista(int indice)
        {
            Image imagen = imagenesDisponibles[imagenesSeleccionadas[indice]];
            return imagen;
        }

        private void CrearAleatorios(List<int>imagenes)
        {
            int numeroImagen;

            while (imagenes.Count < CANTIDADMINIMADECARTAS) {
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

        private void DesplegarSeleccionPersonalizada(object sender, RoutedEventArgs e)
        {
            SeleccionCartasCarros ventana = new SeleccionCartasCarros(cuenta, tiempoDisponible, nombreUsuario);
            DesplegarVentana(ventana);
        }
    }
}
