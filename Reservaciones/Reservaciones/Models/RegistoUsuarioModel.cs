using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones.Models
{
    public class RegistoUsuarioModel
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Departamento { get; set; }
        public string Cargo { get; set; }
        public string Username { get; set; }
        public string Userpassword { get; set; }
        public string RolUsuario { get; set; }
    }
}
