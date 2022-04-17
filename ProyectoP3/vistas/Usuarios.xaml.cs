using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace ProyectoP3.vistas
{
    /// <summary>
    /// Lógica de interacción para Usuarios.xaml
    /// </summary>
    public partial class Usuarios : UserControl
    {
        public Usuarios()
        {
            InitializeComponent();
            CargarDatos();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server"].ConnectionString);
        void CargarDatos()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Id,Username,Nombre_Completo from Usuarios", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridDatos.ItemsSource = dt.DefaultView;
            con.Close();
        }
        private void Consultar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CRUDUsuarios ventana = new CRUDUsuarios();
            ventana.Id = id;
            ventana.Consultar();
            FrameUsuarios.Content = ventana;
            ventana.Titulo.Text = "Consulta de Usuarios";
            ventana.tbNombre_Completo.IsEnabled = false;
            ventana.tbUsername.IsEnabled = false;
            ventana.tbContrasena.IsEnabled = false;
        }

        private void Actualizar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CRUDUsuarios ventana = new CRUDUsuarios();
            ventana.Id = id;
            ventana.Consultar();
            FrameUsuarios.Content = ventana;
            ventana.Titulo.Text = "Actualizar Usuarios";
            ventana.tbNombre_Completo.IsEnabled = true;
            ventana.tbUsername.IsEnabled = true;
            ventana.tbContrasena.IsEnabled = true;
            ventana.BtnActuliazar.Visibility = Visibility.Visible;
        }

        private void Eliminar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CRUDUsuarios ventana = new CRUDUsuarios();
            ventana.Id = id;
            ventana.Consultar();
            FrameUsuarios.Content = ventana;
            ventana.Titulo.Text = "Eliminar Usuarios";
            ventana.tbNombre_Completo.IsEnabled = true;
            ventana.tbUsername.IsEnabled = true;
            ventana.tbContrasena.IsEnabled = true;
            ventana.BtnEliminar.Visibility = Visibility.Visible;
        }

        private void Agregar(object sender, RoutedEventArgs e)
        {
            CRUDUsuarios ventana = new CRUDUsuarios();
            FrameUsuarios.Content = ventana;
            ventana.BtnCrear.Visibility = Visibility.Visible;
        }
    }
}
