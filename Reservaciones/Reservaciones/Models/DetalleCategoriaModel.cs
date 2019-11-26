using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones.Models
{
    public class DetalleCategoriaModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Id_Categoria { get; set; }
    }
}
