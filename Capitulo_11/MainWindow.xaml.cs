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

namespace Capitulo_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Ejercicio_1MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_1 ejercicio = new Ejercicio_1();
            ejercicio.Show();
        }

        private void Ejercicio_2MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_2 ejercicio_2 = new Ejercicio_2();
            ejercicio_2.Show();
        }

        private void Ejercicio_3MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_3 ejercicio_3 = new Ejercicio_3();
            ejercicio_3.Show();
        }

        private void Ejercicio_4MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_4 ejercicio_4 = new Ejercicio_4();
            ejercicio_4.Show();
        }

        private void Ejercicio_5MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_5 ejercicio_5 = new Ejercicio_5();
            ejercicio_5.Show();
        }
    }
}
