using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoP3.vistas
{
    /// <summary>
    /// Lógica de interacción para CRUDUsuarios.xaml
    /// </summary>
    public partial class CRUDUsuarios : Page
    {
        public CRUDUsuarios()
        {
            InitializeComponent();
        }
        private void Regresar(object sender, RoutedEventArgs e)
        {
            Content = new Usuarios();
        }

        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server"].ConnectionString);

        private void Crear(object sender, RoutedEventArgs e)
        {
            if (tbNombre_Completo.Text==""|| tbUsername.Text==""||tbContrasena.Text=="")
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Usuarios (Username,Password,Nombre_Completo) values (@Username,@Password,@Nombre_Completo)", con);
                cmd.Parameters.Add("@username", SqlDbType.VarChar).Value=tbUsername.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = tbContrasena.Text;
                cmd.Parameters.Add("@Nombre_Completo", SqlDbType.VarChar).Value = tbNombre_Completo.Text;
                cmd.ExecuteNonQuery();
                Content = new Usuarios();
            }
            
            con.Close();
        }

        public int Id;
        public void Consultar()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Usuarios where Id=" + Id, con);
            SqlDataReader rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            rdr.Read();
            this.tbUsername.Text = rdr["username"].ToString();
            this.tbContrasena.Text = rdr["password"].ToString();
            this.tbNombre_Completo.Text = rdr["Nombre_Completo"].ToString();
            rdr.Close();
        }
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Usuarios where Id="+Id+"",con);
            cmd.ExecuteNonQuery();
            con.Close();
            Content = new Usuarios();
        }

        private void Actualizar(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Usuarios set Username='" + tbUsername.Text+ 
                "',password='" + tbContrasena.Text + "',Nombre_Completo='" + tbNombre_Completo.Text+
                "'where Id="+Id, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Content = new Usuarios();
        }
    }
}
