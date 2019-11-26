using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones.Models
{
    public class SalonModel
    {
        public int Id { get; set; }
        public int Capacidad { get; set; }
        public string Ubicacion { get; set; }
        public string NombreAula { get; set; }
        public string Taller { get; set; }
    }
}
