using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Capitulo_8.Ejercicios
{
    /// <summary>
    /// Interaction logic for Ejercicio_5.xaml
    /// </summary>
    public partial class Ejercicio_5 : Window
    {
        public Ejercicio_5()
        {
            InitializeComponent();
        }

        private void OrdenarButton_Click(object sender, RoutedEventArgs e)
        {
            string cadena1 = "";
            string cadena2 = "";
            cadena1 = PrimeraCadenaTextBox.Text;
            cadena2 = SegundaCadenaTextBox.Text;

            string ordenado1 = new string(cadena1.OrderBy(x => x).ToArray());
            string ordenado2 = new string(cadena2.OrderBy(x => x).ToArray());

            MessageBox.Show($"La cadena 1 {cadena1} ordenada alfabeticamente es: {ordenado1}\nLa cadena 2 {cadena2} ordenada alfabeticamente es: {ordenado2}",
                "Ordenar", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
