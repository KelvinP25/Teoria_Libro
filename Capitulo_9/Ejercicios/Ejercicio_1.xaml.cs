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

namespace Capitulo_9.Ejercicios
{
    /// <summary>
    /// Interaction logic for Ejercicio_1.xaml
    /// </summary>
    public partial class Ejercicio_1 : Window
    {
        public int cantidad = 0;
        public struct Productos
        {
            public int Id;
            public string Nombre;
            public float Precio;

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Id: {Id}, Nombre: {Nombre}, Precio: {Precio}");
                return sb.ToString();
            }
        }

        public static int ToInt(string valor)
        {
            int retorno = 0;

            int.TryParse(valor, out retorno);

            return retorno;
        }
        public Ejercicio_1()
        {
            InitializeComponent();
        }

        private void IngresarButton_Click(object sender, RoutedEventArgs e)
        {

            cantidad = ToInt(CantidadTextBox.Text);
            Productos[] productos = new Productos[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                productos[i].Id = ToInt(Microsoft.VisualBasic.Interaction.InputBox($"El id del Producto: {i + 1}", " Id del Producto ", " ", 50, 0));
                productos[i].Nombre = Microsoft.VisualBasic.Interaction.InputBox($"El nombre del Producto : {i + 1}", "Nombre del Producto ", " ", 50, 0);
                productos[i].Precio = Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox($"El Precio del Producto: {i + 1}", " Precio del Producto ", " ", 50, 0));

            }

            for (int i = 0; i < cantidad; i++)
            {

                MostrarListBox.Items.Add( productos[i].ToString());
                //MostrarListBox.Items.Add($"--------------------------------\n");
                //MostrarListBox.Items.Add($"Producto {i + 1}");
                //MostrarListBox.Items.Add("Id");
                //MostrarListBox.Items.Add(productos[i].Id.ToString());
                //MostrarListBox.Items.Add("Nombre");
                //MostrarListBox.Items.Add(productos[i].Nombre);
                //MostrarListBox.Items.Add("Precio");
                //MostrarListBox.Items.Add(productos[i].Precio.ToString());
            }


        }
    }
}
