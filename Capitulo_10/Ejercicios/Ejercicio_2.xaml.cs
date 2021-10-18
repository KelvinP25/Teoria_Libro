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

namespace Capitulo_10.Ejercicios
{
    /// <summary>
    /// Interaction logic for Ejercicio_2.xaml
    /// </summary>
    public partial class Ejercicio_2 : Window
    {
        public Ejercicio_2()
        {
            InitializeComponent();
        }
        class Estudiantes
        {
            public int matricula ;
            public string nombre;
            public int edad;
            public string grado;
            public string seccion;
            public Estudiantes(int Codigo, string Nombre, int Edad, string Grado, string Seccion)
            {
                matricula = Codigo;
                nombre = Nombre;
                edad = Edad;
                grado = Grado;
                seccion = Seccion;
            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Matricula: {matricula}\nNombre del Estudiante: " +
                    $"{nombre}\nEdad: {edad}\nGrado: {grado}\nSeccion: {seccion}");
                return sb.ToString();
            }
        }

        private void IngresarButton_Click(object sender, RoutedEventArgs e)
        {
            Estudiantes estudiantes = new Estudiantes(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Codigo del estudiante: ", "Codigo", " ", 50, 0)),
               Microsoft.VisualBasic.Interaction.InputBox($"Nombre del estudiante: ", "Nombre", " ", 50, 0),
               int.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Edad del estudiante: ", "Edad", " ", 50, 0)),
               Microsoft.VisualBasic.Interaction.InputBox($"Grado del estudiante: ", "Grado", " ", 50, 0),
               Microsoft.VisualBasic.Interaction.InputBox($"Seccion del estudiante: ", "Seccion", " ", 50, 0));
            ResultadoTextBlock.Text = estudiantes.ToString();
        }
    }
}
