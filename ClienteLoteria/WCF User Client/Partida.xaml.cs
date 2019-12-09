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
    public partial class Partida : Window
    {
        private List<Image> imagenesTabla = new List<Image>();
        private List<Image> imagenesVisiblesUI = new List<Image>();

        public List<Image> ImagenesTabla { get => imagenesTabla; set => imagenesTabla = value; }

        public Partida()
        {
            InitializeComponent();
            GuardarElementosEnListaDeImagenesVisiblesUI();
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
                imagenesVisiblesUI[i].Source = imagenesTabla[i].Source;
            }
        }

        private void DesplegarAleatoria(object sender, RoutedEventArgs e)
        {
            SeleccionTematica newForm = new SeleccionTematica();
            newForm.Show();
            this.Close();
        }
    }
}
