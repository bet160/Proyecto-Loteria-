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
using WCF_User_Client.Model;

namespace ClienteLoteria

{
    public partial class SeleccionTablaAleatoriaFutbol : Window
    {
        private List<Image> imagenesDisponibles = new List<Image>();
        private List<int> imagenesSeleccionadas = new List<int>();
        private List<Image> imagenesTabla1 = new List<Image>();
        private List<Image> imagenesTabla2 = new List<Image>();
        private List<Image> imagenesTabla3 = new List<Image>();
        private List<Image> imagenesTabla4 = new List<Image>();
        private List<Image> imagenesVisiblesUI = new List<Image>();
        private Tabla tabla = new Tabla(); 

        public SeleccionTablaAleatoriaFutbol()
        {
            InitializeComponent();
            CrearListaImagenesDisponibles();
            GuardarElementosEnListaDeImagenesVisiblesUI();
            guardarImagenesEnListaDeTabla(imagenesTabla1);
            guardarImagenesEnListaDeTabla(imagenesTabla2);
            guardarImagenesEnListaDeTabla(imagenesTabla3);
            guardarImagenesEnListaDeTabla(imagenesTabla4);
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
                Uri resourceUri = new Uri("RecursosTematicaFutbol/" + i.ToString() + ".jpg", UriKind.Relative);
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

            while (imagenes.Count < 16) {
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

        private void DesplegarPartida(object sender, RoutedEventArgs e)
        {
            //Partida ventana = new Partida();
            //ventana.ImagenesTabla = imagenesVisiblesUI;
            //ventana.Tabla = tabla;
            //ventana.MostrarImagenesVisibles();
            //ventana.Show();
            this.Close();
        }

        private void DesplegarSeleccionPersonalizada(object sender, RoutedEventArgs e)
        {
           // SeleccionCartasFutbol ventana = new SeleccionCartasFutbol();
           // ventana.Show();
           // this.Close();
        }
    }
}
