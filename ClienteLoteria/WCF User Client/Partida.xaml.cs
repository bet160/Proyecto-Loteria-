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
        private List<Image> cartasMarcadas = new List<Image>();

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
                    if(cartasMarcadas.Count < 16)
                    {
                        tiempoDisponible = 5;
                        CambiarCarta(pc);
                        timer.Start();
                    }
                    else
                    {
                        MessageBox.Show("Ganaste!!!!!!!!");
                    }
                }
            }
        }

        private void AgregarCartaMarcada(Image imagen)
        {
            if (CompararCartas(imagen))
            {
                cartasMarcadas.Add(imagen);
            }
        }

        private void ValidarSeleccionImagen1(object sender, MouseButtonEventArgs e)
        {
            AgregarCartaMarcada(imagenSeleccionada1);
        }

        private void ValidarSeleccionImagen2(object sender, MouseButtonEventArgs e)
        {
            AgregarCartaMarcada(imagenSeleccionada2);
        }

        private void ValidarSeleccionImagen3(object sender, MouseButtonEventArgs e)
        {
            AgregarCartaMarcada(imagenSeleccionada3);
        }

        private void ValidarSeleccionImagen4(object sender, MouseButtonEventArgs e)
        {
            AgregarCartaMarcada(imagenSeleccionada4);

        }

        private void ValidarSeleccionImagen5(object sender, MouseButtonEventArgs e)
        {
            AgregarCartaMarcada(imagenSeleccionada5);
        }

        private void ValidarSeleccionImagen6(object sender, MouseButtonEventArgs e)
        {
            AgregarCartaMarcada(imagenSeleccionada6);
        }

        private void ValidarSeleccionImagen7(object sender, MouseButtonEventArgs e)
        {
            AgregarCartaMarcada(imagenSeleccionada7);
        }

        private void ValidarSeleccionImagen8(object sender, MouseButtonEventArgs e)
        {
            AgregarCartaMarcada(imagenSeleccionada8);
        }

        private void ValidarSeleccionImagen9(object sender, MouseButtonEventArgs e)
        {
            AgregarCartaMarcada(imagenSeleccionada9);

        }

        private void ValidarSeleccionImagen10(object sender, MouseButtonEventArgs e)
        {
            AgregarCartaMarcada(imagenSeleccionada10);
        }

        private void ValidarSeleccionImagen11(object sender, MouseButtonEventArgs e)
        {
            AgregarCartaMarcada(imagenSeleccionada11);
        }

        private void ValidarSeleccionImagen12(object sender, MouseButtonEventArgs e)
        {
            AgregarCartaMarcada(imagenSeleccionada12);
        }

        private void ValidarSeleccionImagen13(object sender, MouseButtonEventArgs e)
        {
            AgregarCartaMarcada(imagenSeleccionada13);
        }

        private void ValidarSeleccionImagen14(object sender, MouseButtonEventArgs e)
        {
            AgregarCartaMarcada(imagenSeleccionada14);

        }

        private void ValidarSeleccionImagen15(object sender, MouseButtonEventArgs e)
        {
            AgregarCartaMarcada(imagenSeleccionada15);
        }

        private void ValidarSeleccionImagen16(object sender, MouseButtonEventArgs e)
        {
            AgregarCartaMarcada(imagenSeleccionada16);
        }

        private bool CompararCartas(Image imagen)
        {
            if(imagenActual.Source.ToString().Equals(imagen.Source.ToString()))
            {
                imagen.Opacity = .5;
                return true;
            }
            else
            {
                MessageBox.Show("Imagen invalida");
                return false;
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
                if (i > 52)
                {
                    this.Close();
                }
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
            this.Close();
        }

        private void AbandonarPartida(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
