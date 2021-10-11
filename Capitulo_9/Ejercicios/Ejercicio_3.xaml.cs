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
    /// Interaction logic for Ejercicio_3.xaml
    /// </summary>
    public partial class Ejercicio_3 : Window
    {
        public struct Duenio
        {
            string Cedula;
            string Nombre;
            string Telefono;


            public Duenio(string cedula, string nombre, string telefono)
            {
                Cedula = cedula;
                Nombre = nombre;
                Telefono = telefono;
            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Nombre Propietario: {Nombre} Cedula: {Cedula} Telefono: {Telefono}");
                return sb.ToString();
            }
        }

        public struct Mascota
        {
            string Nombre;
            string Raza;
            string Edad;
            string Sexo;
            public Duenio Propietario;

            public Mascota(string nombre, string raza, string edad, string sexo, string Dnombre, string Dcedula, string Dtelefono)
            {
                Nombre = nombre;
                Raza = raza;
                Edad = edad;
                Sexo = sexo;
                Propietario = new Duenio(Dcedula, Dnombre, Dtelefono);
            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Nombre Mascota: {Nombre} Raza: { Raza} Edad: {Edad} Sexo: {Sexo} \n");

                sb.Append(Propietario.ToString());
                return sb.ToString();
            }
        }
        public Ejercicio_3()
        {
            InitializeComponent();
        }

        private void AgendarButton_Click(object sender, RoutedEventArgs e)
        {
            Mascota mascota = new Mascota(Microsoft.VisualBasic.Interaction.InputBox($"Nombre de la mascota: ", "Nombre de la Mascota ", " ", 50, 0),
                Microsoft.VisualBasic.Interaction.InputBox($"Raza de la mascota: ", "Raza de la mascota ", " ", 50, 0),
                Microsoft.VisualBasic.Interaction.InputBox($"Edad de la mascota: ", "Edad de la mascota ", " ", 50, 0),
                Microsoft.VisualBasic.Interaction.InputBox($"Sexo de la mascota: ", "Sexo de la mascota ", " ", 50, 0),
                Microsoft.VisualBasic.Interaction.InputBox($"Nombre del Dueño: ", "Nombre del Dueño ", " ", 50, 0),
                Microsoft.VisualBasic.Interaction.InputBox($"Cedula del Dueño: ", "Cedula del Dueño ", " ", 50, 0),
                Microsoft.VisualBasic.Interaction.InputBox($"Telefono del Dueño: ", "Telefono del Dueño ", " ", 50, 0));

            MostrarListBox.Items.Add(mascota.ToString());


        }
    }
}
