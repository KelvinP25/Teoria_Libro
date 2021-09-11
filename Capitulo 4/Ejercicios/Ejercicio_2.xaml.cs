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

namespace Capitulo_4
{
    /// <summary>
    /// Interaction logic for Ejercicio_2.xaml
    /// </summary>
    public partial class Ejercicio_2 : Window
    {
        public static int numeroint=0, potenciaint=0; 
        public Ejercicio_2()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            int resultado = 1, contenedor = 1;
            String numero;
            String potencia;
            potencia = this.PotenciaTextBox.Text;
            numero = this.NumeroTextBox.Text;
            int.TryParse(numero, out numeroint);
            int.TryParse(potencia, out potenciaint);
           
            for (int i = 0; i < potenciaint;i++)
            {
                contenedor = resultado;
                resultado = numeroint * contenedor;

            }
            

            if (NumeroTextBox.Text != "" && PotenciaTextBox.Text != "")
            {
                MessageBox.Show($"{resultado}", "Resultado",
                   MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Wey mi pana ponga un numero", "Advertencia",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                NumeroTextBox.Focus();
            }
            this.PotenciaTextBox.Clear();
            this.NumeroTextBox.Clear();
        }
    }
}
