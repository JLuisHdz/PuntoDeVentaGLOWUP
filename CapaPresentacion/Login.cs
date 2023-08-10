using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;
using System.Windows;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();
            string nombreUsuario = txtUser.Text;
            string claveUsuario = txtPass.Text;

            Usuario usuario = TEST.FirstOrDefault(u => u.NombreCompleto == nombreUsuario && u.Clave == claveUsuario);

            if (usuario != null)
            {
                Inicio form = new Inicio(usuario);
                form.Show();
                this.Hide();
                form.FormClosing += frm_Closing;
            }
            else
            {
                MessageBox.Show("No se encontró el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void frm_Closing(object sender, FormClosingEventArgs e)
        {

            txtPass.Text = "";
            txtUser.Text = "";
            this.Show();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
