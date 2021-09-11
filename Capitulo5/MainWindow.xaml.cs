using MenuEjercicios5.Ejercicios.Factorial;
using MenuEjercicios5.Ejercicios.NumeroEnLetras;
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

namespace MenuEjercicios5
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

        private void Ejercicio5Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_4 factorial = new Ejercicio_4();
            factorial.Show();
        }

        private void Ejercicio1Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio_5 numero = new Ejercicio_5();
            numero.Show();
        }
    }
}
