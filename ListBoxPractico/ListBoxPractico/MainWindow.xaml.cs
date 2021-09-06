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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListBoxPractico
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> ListaPob = new List<Poblaciones>();

            ListaPob.Add(new Poblaciones() { poblacion1 = "Madrid", poblacion2 = "Barcelona", temperatura1 = 15, temperatura2 = 17, diferenciaTem=2 });
            ListaPob.Add(new Poblaciones() { poblacion1 = "Cordoba", poblacion2 = "Mendoza", temperatura1 = 32, temperatura2 = 28, diferenciaTem=4 });
            ListaPob.Add(new Poblaciones() { poblacion1 = "Sntgo Del Estero", poblacion2 = "BsAires", temperatura1 = 42, temperatura2 = 35, diferenciaTem=7 });
            ListaPob.Add(new Poblaciones() { poblacion1 = "Tucuman", poblacion2 = "Chubut", temperatura1 = 39, temperatura2 = 12, diferenciaTem=27 });

            ListaPoblaciones.ItemsSource = ListaPob;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ListaPoblaciones.SelectedItem != null)
            {

                    MessageBox.Show((ListaPoblaciones.SelectedItem as Poblaciones).poblacion1 + " " +
                    (ListaPoblaciones.SelectedItem as Poblaciones).temperatura1 + " °C - " +
                    (ListaPoblaciones.SelectedItem as Poblaciones).poblacion2 + " " +
                    (ListaPoblaciones.SelectedItem as Poblaciones).temperatura2 + " °C" + " - Dif Temp: "+
                    (ListaPoblaciones.SelectedItem as Poblaciones).diferenciaTem);
            }
            else
            {
                MessageBox.Show("Selecciona un elemento");
            }
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ListaPoblaciones.SelectedItem != null)
            {

                MessageBox.Show((ListaPoblaciones.SelectedItem as Poblaciones).poblacion1 + " " +
                (ListaPoblaciones.SelectedItem as Poblaciones).temperatura1 + " °C - " +
                (ListaPoblaciones.SelectedItem as Poblaciones).poblacion2 + " " +
                (ListaPoblaciones.SelectedItem as Poblaciones).temperatura2 + " °C" + " - Dif Temp: " +
                (ListaPoblaciones.SelectedItem as Poblaciones).diferenciaTem);
            }
        }
    }

    public class Poblaciones
    {

        public string poblacion1 { get; set; }
        public int temperatura1 { get; set; }
        public string poblacion2 { get; set; }
        public int temperatura2 { get; set; }

        public int diferenciaTem { get; set; }
    }

}
