using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones.Models
{
    public class ReservadosModel
    {
        public int Id { get; set; }
        public DateTime FechaReservacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Observaciones { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Salon { get; set; }
    }
}
