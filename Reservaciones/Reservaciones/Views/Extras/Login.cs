using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reservaciones.Utils;

namespace Reservaciones.Views.Extras
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Utils.Login inicio = new Utils.Login();

            string usuario = txtUsuarioLogin.Text;
            string clave = txtContraseñaLogin.Text;

            inicio.IniciarSesion(usuario, clave, "Administrador");

            this.Close();
        }
    }
}
