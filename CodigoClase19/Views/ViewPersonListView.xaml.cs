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

namespace CodigoClase19
{
    /// <summary>
    /// Lógica de interacción para ViewPersonListView.xaml
    /// </summary>
    public partial class ViewPersonListView : Window
    {
        List<Persona> personas = new List<Persona>();

        public ViewPersonListView()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            personas.Add(new Persona
            {
                Id = 1,
                Apellidos = "Torrico",
                Nombres = "Hugo",
                Edad = 36
            });
            personas.Add(new Persona
            {
                Id = 2,
                Apellidos = "Tapia",
                Nombres = "Guillermo",
                Edad = 36
            });
            personas.Add(new Persona
            {
                Id = 3,
                Apellidos = "Santos",
                Nombres = "Bruno",
                Edad = 36
            });

            personas.Add(new Persona
            {
                Id = 4,
                Apellidos = "Tapia",
                Nombres = "Guillermo",
                Edad = 36
            });
            personas.Add(new Persona
            {
                Id = 5,
                Apellidos = "Santos",
                Nombres = "Bruno",
                Edad = 36
            });


            lvPersona.ItemsSource = personas;

        }
    }
}
