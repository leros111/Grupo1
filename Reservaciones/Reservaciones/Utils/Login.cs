using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones.Utils
{
    public class Login
    {
        public static string l_Usuario;
        public static string l_Clave;
        public static string l_Rol;

        public void IniciarSesion(string usuario, string clave, string rol)
        {
            l_Usuario = usuario;
            l_Clave = clave;
            l_Rol = rol;
        }
    }
}
