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

namespace VetClinic
{
    /// <summary>
    /// Lógica de interacción para Trabaja.xaml
    /// </summary>
    public partial class Trabaja : Window
    {
        public Trabaja()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            // Mostrar u ocultar el Popup al hacer clic en el botón del menú
            menuPopup.IsOpen = !menuPopup.IsOpen;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el contenido del botón clicado
            var buttonText = (sender as Button)?.Content?.ToString();

            Window nuevaVentana = null;

            if (buttonText == "Home")
            {
                nuevaVentana = new MainWindow();
            }
            else if (buttonText == "Instalaciones")
            {
                nuevaVentana = new Instalaciones();
            }
            else if (buttonText == "Log In")
            {
                nuevaVentana = new LogIn();
            }
            else if (buttonText == "Adopción")
            {
                nuevaVentana = new Adopcion();
            }

            // Cerrar la ventana actual
            Close();

            // Mostrar la nueva ventana si se ha creado
            if (nuevaVentana != null)
            {
                nuevaVentana.Show();
            }

            // Cerrar el Popup después de hacer clic en un elemento del menú
            menuPopup.IsOpen = false;
        }
    }
}
