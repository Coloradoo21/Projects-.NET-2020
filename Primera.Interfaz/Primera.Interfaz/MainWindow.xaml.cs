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

namespace Primera.Interfaz
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {








        /* bool textonumero = true;
        string ejecutar;
        double num;
        double num2, total;

        public object TxtNumeros { get; private set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textonumero)
            {
                TxtNumeros.Text = "";
                TxtNumeros.Text = "1";
                textonumero = false;
            }
            else
            {
                TxtNumeros.Text = TxtNumeros.Text + "1";
            }
        }*/

        public MainWindow()
        {
            InitializeComponent();

            JuntaNombreYApellido = new JuntaNombre { Nombre = "Juan", Apellido = "Diaz" };

            this.DataContext = JuntaNombreYApellido;

        }

        public JuntaNombre JuntaNombreYApellido;

            /*Grid miGrid = new Grid();

            this.Content = miGrid;

            Button miBoton = new Button();

            WrapPanel miWrap = new WrapPanel();

            TextBlock txt1 = new TextBlock();

            txt1.Background = Brushes.Pink;

            txt1.Foreground = Brushes.Violet;

            txt1.Text = "Click";

            miWrap.Children.Add(txt1);

            TextBlock txt2 = new TextBlock();

            txt2.Background = Brushes.Pink;


            txt2.Text = "Enviar";

            miWrap.Children.Add(txt2);

            TextBlock txt3 = new TextBlock();

            txt3.Background = Brushes.Pink;


            txt3.Text = "Dale";

            miWrap.Children.Add(txt3);

            miBoton.Content = miWrap;

            miGrid.Children.Add(miBoton);

            miBoton.Background = Brushes.Black;


            miBoton.Width = 120;
            miBoton.Height = 25;

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Está corriendo!");
        }
        private void Pannel_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Le has dado al panel!");
        }

        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Le has dado al panel!");
        }

        private void TextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }*/

        
        

        

    }
}
