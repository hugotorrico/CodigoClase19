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
    /// Lógica de interacción para ViewPersonCustom.xaml
    /// </summary>
    public partial class ViewPersonCustom : Window
    {
        List<Persona> personas = new List<Persona>();

        public ViewPersonCustom()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            dgDemo.ItemsSource = null;
            dgDemo.ItemsSource = personas;

        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            personas.Add(new Persona
            {
                Id = 1,
                Apellidos = "Torrico",
                Nombres = "Hugo",
                Edad = 36
            });
            //personas.Add(new Persona
            //{
            //    Id = 2,
            //    Apellidos = "Tapia",
            //    Nombres = "Guillermo",
            //    Edad = 36
            //});
            personas.Add(new Persona
            {
                Id = 3,
                Apellidos = "Santos",
                Nombres = "Bruno",
                Edad = 36
            });

            for (int i = 0; i < personas.Count; i++)
            {
                personas[i].Orden = i + 1;
            }




            MessageBox.Show("Registro de forma correcta");
        }
    }
}
