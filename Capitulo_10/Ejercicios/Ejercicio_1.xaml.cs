using System;
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

namespace Capitulo_10.Ejercicios
{
    /// <summary>
    /// Interaction logic for Ejercicio_1.xaml
    /// </summary>
    public partial class Ejercicio_1 : Window
    {
        public Ejercicio_1()
        {
            InitializeComponent();
        }
        public class Inventario
        {
            public int codigo;
            public string nombreProducto;
            public string descripcionProducto;
            public int existencia;
            public float precio;

            public Inventario(int codi, string nombre, string descripcion, int exi, float pre)
            {
                codigo = codi;
                nombreProducto = nombre;
                descripcionProducto = descripcion;
                existencia = exi;
                precio = pre;
            }

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Codigo: {codigo}\nNombre del Producto: {nombreProducto}\nDescripcion: " +
                    $"{descripcionProducto}\nExistencia: {existencia}\nPrecio:{precio}");
                return sb.ToString();
            }
        }

        private void IngresarButton_Click(object sender, RoutedEventArgs e)
        {
            Inventario inventario = new Inventario(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Codigo del producto: ", "Codigo del Producto", " ", 50, 0)),
               Microsoft.VisualBasic.Interaction.InputBox($"Nombre del producto: ", "Nombre del Producto", " ", 50, 0),
               Microsoft.VisualBasic.Interaction.InputBox($"Descripcion del producto: ", "Descripcion del Producto", " ", 50, 0),
               Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Existencia del producto: ", "Existencia del Producto", " ", 50, 0)),
               Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox($"Precio del producto: ", "Precio del Producto", " ", 50, 0)));
            ResultadoTextBlock.Text = inventario.ToString();
        }
    }
}
