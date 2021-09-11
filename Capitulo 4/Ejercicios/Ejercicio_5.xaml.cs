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

namespace Capitulo_4.Ejercicios
{
    /// <summary>
    /// Interaction logic for Ejercicio_5.xaml
    /// </summary>
    public partial class Ejercicio_5 : Window
    {
        public static int minimo = 1, maximo = 1;
        public static int cont = 0;
        public static float promedio = 0, AcuSuma = 0;

        private void ResultadoButton_Click(object sender, RoutedEventArgs e)
        {
            promedio = (AcuSuma / cont);

            ResultadoListView.Items.Add("Promedio: ");
            ResultadoListView.Items.Add(promedio);

            ResultadoListView.Items.Add("Edad minima: ");
            ResultadoListView.Items.Add(minimo);

            ResultadoListView.Items.Add("Edad Maxima: ");
            ResultadoListView.Items.Add(maximo);


        }

        public Ejercicio_5()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            int n = 0;
            
            if (EdadTextBox.Text != "")
            {
                string str = EdadTextBox.Text;
                int.TryParse(str, out n);
               
                this.EdadListView.Items.Add(n);
                EdadTextBox.Text = "";
                cont++;
                AcuSuma += n;
                EdadTextBox.Focus();

            }
            else
            {
                MessageBox.Show("Campo vacio...", "Advertencia",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                EdadTextBox.Focus();
            }

            minimo = maximo = n;
            for (int i = 0; i < EdadListView.Items.Count; i++)
            {

                if (maximo < Convert.ToInt32(EdadListView.Items[i]))
                {
                    maximo = Convert.ToInt32(EdadListView.Items[i]);

                }
                else if (minimo > Convert.ToInt32(EdadListView.Items[i]))
                {
                    minimo = Convert.ToInt32(EdadListView.Items[i]);
                }
            }
        }
    }
}
