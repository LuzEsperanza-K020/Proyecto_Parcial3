using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class LoginService
    {
        public bool checkContraBaseDatos(string username, string password)
        {
            UsuariosDao usuariosDao = new UsuariosDao();
            Usuarios user = usuariosDao.buscarUsuarioPorUsername(username, password);
            if(user != null)
            {
                Console.WriteLine("usuario" + user.Username + "Exito en la Base");
                return true;
            }
            else
            {
                Console.WriteLine("Usuario no existente en la Base");
                return false;
            }
        }
    }
}
