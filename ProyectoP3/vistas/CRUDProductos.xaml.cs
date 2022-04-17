using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
    /// Lógica de interacción para CRUDProductos.xaml
    /// </summary>
    public partial class CRUDProductos : Page
    {
        public CRUDProductos()
        {
            InitializeComponent();
        }

        private void Regresar(object sender, RoutedEventArgs e)
        {
            Content = new Productos();
        }
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["server"].ConnectionString);

        private void Crear(object sender, RoutedEventArgs e)
        {
            if (tbNombre.Text == "" || tbPrecio.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
            else
            {
                if (imagensubida == true)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Articulos (Nombre ,Precio ,Img ) values (@Nombre ,@Precio ,@Img )", con);
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = tbNombre.Text;
                    cmd.Parameters.Add("@Precio", SqlDbType.VarChar).Value = tbPrecio.Text;
                    cmd.Parameters.Add("@Img ", SqlDbType.VarBinary).Value = data;
                    cmd.ExecuteNonQuery();
                    Content = new Usuarios();
                }
                
            }

            con.Close();
        }
        public int IdArticulo;
        public void Consultar()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Articulos where IdArticulo =" + IdArticulo, con);
            SqlDataReader rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            rdr.Read();
            this.tbNombre.Text = rdr["Nombre"].ToString();
            this.tbPrecio.Text = rdr["Precio"].ToString();
            rdr.Close();

            //IMAGEN
            DataSet ds = new DataSet();
            SqlDataAdapter sqda = new SqlDataAdapter("select Img  from Articulos where IdArticulo ='" + IdArticulo + "'", con);
            sqda.Fill(ds);
            byte[] data = (byte[])ds.Tables[0].Rows[0][0];
            MemoryStream strm = new MemoryStream();
            strm.Write(data, 0, data.Length);
            strm.Position = 0;
            System.Drawing.Image Img = System.Drawing.Image.FromStream(strm);
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            MemoryStream ms = new MemoryStream();
            Img.Save(ms,System.Drawing.Imaging.ImageFormat.Bmp);
            ms.Seek(0, SeekOrigin.Begin);
            bi.StreamSource = ms;
            bi.EndInit();
            imagen.Source = bi;
            con.Close();
        }
        private void Eliminar(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Articulos where IdArticulo =" + IdArticulo + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Content = new Usuarios();
        }

        private void Actualizar(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Articulos set Nombre ='" + tbNombre.Text +
                "',Precio='" + tbPrecio.Text + "'where IdArticulo =" + IdArticulo, con);
            if (imagensubida == true)
            {
                SqlCommand img = new SqlCommand("update Articulos set Img=@Img where IdArticulo='"+IdArticulo+"'", con);
                img.Parameters.AddWithValue("@Img", SqlDbType.VarBinary).Value = data;
                img.ExecuteNonQuery();
            }
            cmd.ExecuteNonQuery();
            con.Close();
            Content = new Usuarios();
        }
        byte[] data;
        private bool imagensubida=false;
        private void Subir(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog()==true)
            {
                FileStream fs = new FileStream(ofd.FileName,FileMode.Open,FileAccess.Read);
                data = new byte[fs.Length];
                fs.Read(data, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                ImageSourceConverter imgs = new ImageSourceConverter();
                imagen.SetValue(Image.SourceProperty, imgs.ConvertFromString(ofd.FileName.ToString()));
            }
            imagensubida = true;
        }
    }
}
