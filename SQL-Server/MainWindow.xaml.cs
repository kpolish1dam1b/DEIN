using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Data.SqlClient;
using System.Data;

namespace SQL_Server
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection miConexionSql;

        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["SQL_Server.Properties.Settings.ConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);

            MuestraUsuarios();

        }

        public void MuestraUsuarios()
        {
            string consulta = "SELECT * FROM Usuarios WHERE [nombre] = 'Juan'";

            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

            using (miAdaptadorSql)
            {
                DataTable tablaUsuarios = new DataTable();

                miAdaptadorSql.Fill(tablaUsuarios);

                
         
                listaUsuarios.ItemsSource = tablaUsuarios.DefaultView;
            }
        }
    }
}
