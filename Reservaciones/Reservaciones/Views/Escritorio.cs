using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservaciones.Views
{
    public partial class Escritorio : Form
    {
        public Escritorio()
        {
            InitializeComponent();
        }

        /*
        private void Menu()
        {
            if (Utils.Login.l_Rol == "Administrador")
            {
                new Views.Menu.Menu_Admin()
                {
                    MdiParent = this,
                    Visible = true
                };
            }
            else if (Utils.Login.l_Rol == "Usuario")
            {
                new Views.Menu.Menu_User()
                {
                    MdiParent = this,
                    Visible = true
                };
            }
        }
        */

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Views.Menu.Menu_Admin()
            {
                MdiParent = this,
                Visible = true
            };
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Views.Menu.Menu_User()
            {
                MdiParent = this,
                Visible = true
            };
        }
    }
}
