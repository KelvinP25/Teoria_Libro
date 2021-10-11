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

namespace Capitulo_8.Ejercicios
{
    /// <summary>
    /// Interaction logic for Ejercicio_3.xaml
    /// </summary>
    public partial class Ejercicio_3 : Window
    {
        public Ejercicio_3()
        {
            InitializeComponent();

            if (DateTime.Now.Hour > 12)
            {
              
                FechaTextBlock.Text = String.Format("{0: dd/MM/yyyy} {0: hh:mm} PM", DateTime.Now); ;
            }
            else
            {
                
                FechaTextBlock.Text = String.Format("{0: dd/MM/yyyy} {0: hh:mm} AM", DateTime.Now); ;

            }
            
        }
    }
}
