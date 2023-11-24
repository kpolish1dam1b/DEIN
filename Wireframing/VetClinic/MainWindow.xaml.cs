﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VetClinic
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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
            else if (buttonText == "Cita")
            {
                nuevaVentana = new Cita();
            }
            else if (buttonText == "Sobre nosotros")
            {
                nuevaVentana = new Info();
            }
            else if (buttonText == "Trabaja con nosotros")
            {
                nuevaVentana = new Trabaja();
            }
            else if (buttonText == "Servicios")
            {
                nuevaVentana = new Servicios();
            }
            else if (buttonText == "Mi perfil")
            {
                nuevaVentana = new Perfil();
            }
            else if (buttonText == "Reseervar sala")
            {
                nuevaVentana = new ReservarSala();
            }
            else if (buttonText == "Mis citas")
            {
                nuevaVentana = new Horario();
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
