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
    /// Lógica de interacción para Productos.xaml
    /// </summary>
    public partial class Productos : UserControl
    {
        public Productos()
        {
            InitializeComponent();
            CargarDatos();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server"].ConnectionString);
        void CargarDatos()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select IdArticulo,Nombre ,Precio  from Articulos", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridDatos.ItemsSource = dt.DefaultView;
            con.Close();
        }
        private void Agregar_Producto(object sender, RoutedEventArgs e)
        {
            CRUDProductos ventana = new CRUDProductos();
            FrameProductos.Content = ventana;
            ventana.BtnCrear.Visibility = Visibility.Visible;
        }

        private void Consultar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CRUDProductos ventana = new CRUDProductos();
            ventana.IdArticulo = id;
            ventana.Consultar();
            FrameProductos.Content = ventana;
            ventana.Titulo.Text = "Consulta de Producto";
            ventana.tbNombre.IsEnabled = false;
            ventana.tbPrecio.IsEnabled = false;
            ventana.BtnSubir.IsEnabled = false;
        }

        private void Actualizar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CRUDProductos ventana = new CRUDProductos();
            ventana.IdArticulo = id;
            ventana.Consultar();
            FrameProductos.Content = ventana;
            ventana.Titulo.Text = "Actualizar Producto";
            ventana.tbNombre.IsEnabled = true;
            ventana.tbPrecio.IsEnabled = true;
            ventana.BtnSubir.IsEnabled = true;
            ventana.BtnActuliazar.Visibility = Visibility.Visible;
        }

        private void Eliminar(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CRUDProductos ventana = new CRUDProductos();
            ventana.IdArticulo = id;
            ventana.Consultar();
            FrameProductos.Content = ventana;
            ventana.Titulo.Text = "Eliminar Producto";
            ventana.tbNombre.IsEnabled = false;
            ventana.tbPrecio.IsEnabled = false;
            ventana.BtnSubir.IsEnabled = false;
            ventana.BtnEliminar.Visibility = Visibility.Visible;
        }
    }
}
