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
    /// Interaction logic for Ejercicio_3.xaml
    /// </summary>
    public partial class Ejercicio_3 : Window
    {
        public Ejercicio_3()
        {
            InitializeComponent();
        }
        class Poligono
        {
            public int cantidad;
            public int medidas;
            public int angulos;
            public Poligono(int cant, int med, int ang)
            {
                cantidad = cant;
                medidas = med;
                angulos = ang;
            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Cantidad de lados: {cantidad}\nMedidas de lados: {medidas}\n Angulos: {angulos}");
                return sb.ToString();
            }
        }

        private void IngresarButton_Click(object sender, RoutedEventArgs e)
        {
            Poligono poligono = new Poligono(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Cantidad de lados: ", "Lados", " ", 50, 0)),
               Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Medidas de lados: ", "Medidas", " ", 50, 0)),
               Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Angulos: ", "Angulo", " ", 50, 0)));
            ResultadoTextBlock.Text = poligono.ToString();
        }
    }
}
