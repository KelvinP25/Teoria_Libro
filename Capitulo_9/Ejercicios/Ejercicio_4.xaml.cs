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
    /// Interaction logic for Ejercicio_4.xaml
    /// </summary>
    public partial class Ejercicio_4 : Window
    {
        public enum TiposNeumaticos
        {
            Verano = 1, Invierno, All_Season, Deportivos, Pista, Todo_Terreno
        };
        public Ejercicio_4()
        {
            TiposNeumaticos neumaticos1 = TiposNeumaticos.Verano;
            TiposNeumaticos neumaticos2 = TiposNeumaticos.Invierno;
            TiposNeumaticos neumaticos3 = TiposNeumaticos.Deportivos;
            TiposNeumaticos neumaticos4 = TiposNeumaticos.All_Season;
            TiposNeumaticos neumaticos5 = TiposNeumaticos.Pista;
            TiposNeumaticos neumaticos6 = TiposNeumaticos.Todo_Terreno;


            string neumaticos = "" + neumaticos1.ToString() + "\n" + neumaticos2.ToString() + "\n" + neumaticos3.ToString() + "\n" 
                + neumaticos4.ToString() + "\n" + neumaticos5.ToString() + "\n" + neumaticos6.ToString() + "\n";

            NeumaticosTextBlock.Text = neumaticos;
        }

    }
}
