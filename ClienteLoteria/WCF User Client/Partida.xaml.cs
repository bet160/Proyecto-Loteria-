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
using System.Windows.Threading;
using WCF_User_Client.Model;

namespace ClienteLoteria

{
    public partial class Partida : Window
    {
        //private List<Image> imagenesTabla = new List<Image>();
        Tabla tabla;
        private List<Image> imagenesVisiblesUI = new List<Image>();
        private int tiempoDisponible = 5;
        private DispatcherTimer timer;
        private List<int> pos = new List<int>();
        private List<Image> mazo = new List<Image>();
        private int pc = 0;

        internal Tabla Tabla { get => tabla; set => tabla = value; }

        //public List<Image> ImagenesTabla { get => imagenesTabla; set => imagenesTabla = value; }

        public Partida()
        {
            InitializeComponent();
            GuardarElementosEnListaDeImagenesVisiblesUI();
            Mazo();
            Lista();
            CambiarCarta(pc);
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            if(tiempoDisponible >= 0)
            {
                segundos.Text = string.Format("{0}", tiempoDisponible % 60);
                tiempoDisponible--;
            }
            else
            {
                timer.Stop();
                if(pc <= 51)
                {
                    tiempoDisponible = 5;
                    CambiarCarta(pc);
                    timer.Start();
                }
            }
        }

        private void ValidarSeleccion(object sender, MouseButtonEventArgs e)
        {
            CompararCartas(imagenSeleccionada1);
        }

        private void CompararCartas(Image imagen)
        {
            if(imagenActual.Source.ToString().Equals(imagen.Source.ToString()))
            {
                imagen.Opacity = .5;  
            }
            else
            {
                MessageBox.Show("Imagen invalida");
            }
        }

        void CambiarCarta(int p)
        {
            imagenActual.Source = mazo[p].Source;
            pc++;
        }

        void Mazo()
        {
            Image imagen;

            for (int i = 1; i <= 52; i++)
            {
                imagen = new Image();
                Uri resourceUri = new Uri("RecursosTematicaCarros/" + i.ToString() + ".jpg", UriKind.Relative);
                imagen.Source = new BitmapImage(resourceUri);
                mazo.Add(imagen);
            }
        }

        void Lista()
        {
            for(int i =1; i<= 50; i++)
            {
                pos.Add(i);
            }
        }

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

        public void MostrarImagenesVisibles()
        {
            for(int i = 0; i<=15; i++)
            {
                imagenesVisiblesUI[i].Source = tabla.CartasDeTabla[i].Source;
                //imagenesVisiblesUI[i].Source = imagenesTabla[i].Source;
            }
        }

        private void DesplegarAleatoria(object sender, RoutedEventArgs e)
        {

        }
    }
}
