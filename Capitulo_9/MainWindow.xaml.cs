using Capitulo_9.Ejercicios;
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

namespace Capitulo_9
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
            Ejercicio_1 ejercicios_1 = new Ejercicio_1();
            ejercicios_1.Show();
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
    }
}
