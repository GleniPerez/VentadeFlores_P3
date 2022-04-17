using ProyectoP3.datos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoP3.negocio
{
    class LoginService
    {

        
        public bool checkContraBaseDatos(string username, string password)
        {

            UsuariosDao usuariosDao = new UsuariosDao();
            Usuarios user = usuariosDao.buscarUsuarioPorUsername(username, password);
            if (user != null)
            {
                Console.WriteLine("usuario " + user.Username + "existe en la base de datos");
                return true;
            }
            Console.WriteLine("Usuario no existe en la base de datos");
            return false;
        }
    }
}
