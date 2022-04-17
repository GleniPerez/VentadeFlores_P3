using ProyectoP3.vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProyectoP3
{
    /// <summary>
    /// Lógica de interacción para inicio.xaml
    /// </summary>
    public partial class inicio : Window
    {
        public Productos DataContent { get; private set; }

        public inicio()
        {
            InitializeComponent();
        }

        private void TBShow(object sender, RoutedEventArgs e)
        {
            GridContent.Opacity = 0.5;
        }

        private void TBHide(object sender, RoutedEventArgs e)
        {
            GridContent.Opacity = 1;
        }

        private void PMLBDown(object sender, MouseButtonEventArgs e)
        {
            BtnShowHide.IsChecked = false;
        }

        private void Minimizar(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void cerrar(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void UsuariosClick(object sender, RoutedEventArgs e)
        {
            DataContext = new Usuarios();
        }

        private void ProductosClick(object sender, RoutedEventArgs e)
        {
            DataContext = new Productos();
        }
    }
}
