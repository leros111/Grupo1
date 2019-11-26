using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservaciones.Views.Menu
{
    public partial class Menu_User : Form
    {
        public Menu_User()
        {
            InitializeComponent();
        }

        public void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            //Busca en la coleccion un formulario
            Form formulario = Panel_Menu_User.Controls.OfType<MiForm>().FirstOrDefault();

            //Si exite ya una instancia de un formulario o no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                Panel_Menu_User.Controls.Add(formulario);
                Panel_Menu_User.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                //si el formulario existe
                formulario.BringToFront();
            }
        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelReservaciones);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelReportes);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
