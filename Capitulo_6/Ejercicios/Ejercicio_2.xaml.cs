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

namespace Capitulo_6.Ejercicios
{
    /// <summary>
    /// Interaction logic for Ejercicio_2.xaml
    /// </summary>
    public partial class Ejercicio_2 : Window
    {
        int cantidad;
        int curso = 0;
        float[][] calificaciones;


        public static float suma = 0.0f;
        public static float promedio = 0.0f;
        public static int contador = 0;
        public static float menor = 2147483648, aux = 0.0f;
        public Ejercicio_2()
        {
            InitializeComponent();
        }

        public static int ToInt(string valor)
        {
            int retorno = 0;

            int.TryParse(valor, out retorno);

            return retorno;
        }
        private void AgregarCursoButton_Click(object sender, RoutedEventArgs e)
        {
            curso = ToInt(CursosTextBox.Text);
            calificaciones = new float[curso][];

            for (int i = 0; i < curso; i++)
            {
                cantidad = ToInt(Microsoft.VisualBasic.Interaction.InputBox($"Ingrese la cantidad de alumnos del salón: {i + 1}", " Cantidad de Alumnos ", " ", 50, 0));
                calificaciones[i] = new float[cantidad];
                //contador += cantidad;
                //cantidad += cantidad;
            }

            CursosTextBox.Text = "";
        }
        private void AregarCalificaionesButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < curso; i++)
            {
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    calificaciones[i][j] = Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox($"Ingrese la calificación del alumno {j + 1} del salón {i + 1}", "Calificaciones Alumnos"));

                    suma += calificaciones[i][j];
                    contador++;
                    if (calificaciones[i][j] < menor)
                    {
                        menor = calificaciones[i][j];
                    }
                }
            }
            for (int n = 0; n < curso; n++)
            {
                CalificacionesListView.Items.Add($"Salón {n + 1}");

                for (int m = 0; m < calificaciones[n].GetLength(0); m++)
                {
                    CalificacionesListView.Items.Add($"El alumno {m + 1} tiene {calificaciones[n][m]}");
                }
            }

        }

        private void ResultadoButton_Click(object sender, RoutedEventArgs e)
        {
            promedio = suma / contador;
            ResultadosListView.Items.Add("Promedio: ");
            ResultadosListView.Items.Add(promedio);

            ResultadosListView.Items.Add("Menor calificaion ");
            ResultadosListView.Items.Add(menor);
        }
    }
}
