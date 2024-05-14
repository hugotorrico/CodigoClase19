using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CodigoClase19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Persona> personas = new List<Persona>();
        public MainWindow()
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
                Apellidos = txtApellidos.Text,
                Nombres = txtNombres.Text,
                Edad=36                
            });
            MessageBox.Show("Registro de forma correcta");
        }
        
    }
}