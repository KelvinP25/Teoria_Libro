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

namespace MenuEjercicios5.Ejercicios.NumeroEnLetras
{
    /// <summary>
    /// Interaction logic for nLetras.xaml
    /// </summary>
    public partial class Ejercicio_5 : Window
    {
        Conversion c = new Conversion();
        public Ejercicio_5()
        {
            InitializeComponent();
        }

        private void ConvertirButton_Click(object sender, RoutedEventArgs e)
        {
            string numero = c.ConversionLetras(NumeroTextBox.Text.ToLower());
            MessageBox.Show($"{numero}");
        }
    }
}
