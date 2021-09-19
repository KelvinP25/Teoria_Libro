using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Capitulo_7.Ejercicio
{
    /// <summary>
    /// Interaction logic for Ejercicio_2.xaml
    /// </summary>
    public partial class Ejercicio_2 : Window
    {
        Hashtable diccionarioPalabra = new Hashtable();
        public Ejercicio_2()
        {
            InitializeComponent();
            PalabrasListView.Items.Add("Arreglo\nHardware\nSoftware\nAlgoritmo\nSistema");
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            diccionarioPalabra.Add("arreglo", "En programación, un arreglo es una colección de elementos que tienen como referencia un mismo nombre.");
            diccionarioPalabra.Add("hardware", "Conjunto de elementos físicos o materiales que constituyen una computadora o un sistema informático.");
            diccionarioPalabra.Add("software", "Conjunto de programas y rutinas que permiten a la computadora realizar determinadas tareas.");
            diccionarioPalabra.Add("algoritmo", "Conjunto ordenado de operaciones sistemáticas que permite hacer un cálculo y hallar la solución de un tipo de problemas.");
            diccionarioPalabra.Add("sistema", "Conjunto ordenado de normas y procedimientos que regulan el funcionamiento de un grupo o colectividad.");

            DescripcionTextBox.Text = (String)diccionarioPalabra[PalabraTextBox.Text.ToLower()];
        }
    }
}
