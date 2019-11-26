using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservaciones.Views.Salon
{
    public partial class AdministrarCaracteristicas : Form
    {
        public AdministrarCaracteristicas()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            new Nuevo_Editar_Categoria().ShowDialog();
        }

        private void btnNuevoInmueble_Click(object sender, EventArgs e)
        {
            new Nuevo_Editar_Caracteristicas().ShowDialog();
        }

    }
}
