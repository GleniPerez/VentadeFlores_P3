using ProyectoP3.negocio;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoP3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LoginService login = new LoginService();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameValido.Text;
            string password = passwordValido.Password;

            if (login.checkContraBaseDatos(username, password))
            {
                // salidaLabel.Content = "Usuario logeado";
                MessageBox.Show("EXito!!", "Usuario logeado");

                inicio Inicio = new inicio();
                Inicio.Show();
                this.Close();
            }
            else
            {
                //salidaLabel.Content = "Usuario incorrecto";
                MessageBox.Show("ERROR!!", "Usuario incorrecto");
            }
        }
    }
}
