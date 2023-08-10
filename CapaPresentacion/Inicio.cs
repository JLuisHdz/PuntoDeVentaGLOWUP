using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static Button BtnfActivo = null;
        private static Form FormularioActivo = null;
        public Inicio(Usuario objusuario = null)
        {
            if (objusuario == null)
                usuarioActual = new Usuario() { NombreCompleto = "ADMIN PREDEFINIDO", IdUsuario = 1 };
            else
                usuarioActual = objusuario;

            InitializeComponent();
        }

        Panel p = new Panel();

        private void btnMouseLeave(object sender, EventArgs e)
        {
            panelMenu.Controls.Remove(p);
        }

        private void Abrirformulario(Button btnf, Form formulario)
        {
            if (BtnfActivo != null)
            {
                BtnfActivo.BackColor = Color.Pink;
            }

            btnf.BackColor = Color.LightCoral;
            BtnfActivo = btnf;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.LightCoral;

            pnlInicio.Controls.Add(formulario);
            formulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abrirformulario((Button)sender, new frmVentas());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            int newHeight = 39;
            string usuario = usuarioActual.oRol.Descripcion;
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            foreach (Button button in panelMenu.Controls.OfType<Button>())
            {
                Console.WriteLine("Nombre del botón: " + button.Text);
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == button.Name);

                if (encontrado == false)
                {
                    button.Visible = false;
                }
            }

            foreach (Button buttond in pDetalles.Controls.OfType<Button>())
            {
                Console.WriteLine("Nombre del botón: " + buttond.Text);
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == buttond.Name);

                if (encontrado == false)
                {
                    buttond.Visible = false;
                }
                if (usuario == "Administrador")
                {
                    int numButtonsInpDetalles = pDetalles.Controls.OfType<Button>().Count();
                    int newHeightd = numButtonsInpDetalles * newHeight;
                    pDetalles.Height = newHeightd;
                }
                else
                {
                    pDetalles.Height = newHeight;
                }

            }

            foreach (Button buttone in pEstadisticas.Controls.OfType<Button>())
            {
                Console.WriteLine("Nombre del botón: " + buttone.Text);
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == buttone.Name);

                if (encontrado == false)
                {
                    buttone.Visible = false;
                }
                pEstadisticas.Height = newHeight;
                if (usuario == "Administrador")
                {
                    int numButtonsInpDetalles = pDetalles.Controls.OfType<Button>().Count();
                    int newHeightd = numButtonsInpDetalles * newHeight;
                    pEstadisticas.Height = newHeightd;
                }
                else
                {
                    pEstadisticas.Height = newHeight;
                }
                if (usuario == "Empleado")
                {
                    int newLeft = 320;
                    pEstadisticas.Left = newLeft;
                    btnEstadisticas.Left = newLeft;
                }

            }


            lblusuario.Text = usuarioActual.NombreCompleto;
        }

        private void btnEstadisticas_Click_1(object sender, EventArgs e)
        {
            this.pDetalles.Hide();
            this.pAgregar.Hide();
            this.pEstadisticas.Hide();
            if (!pEstadisticas.Visible)
                pEstadisticas.Visible = true;
            else
                pEstadisticas.Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Abrirformulario(btnEstadisticas, new frmReporteCompra());
            this.pDetalles.Hide();
            this.pAgregar.Hide();
            this.pEstadisticas.Hide();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            this.pDetalles.Hide();
            this.pAgregar.Hide();
            this.pEstadisticas.Hide();
            if (!pDetalles.Visible)
                pDetalles.Visible = true;
            else
                pDetalles.Visible = false;
        }

        private void brnCS_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Close();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblusuario.Text = usuarioActual.NombreCompleto;
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            this.pDetalles.Hide();
            this.pAgregar.Hide();
            this.pEstadisticas.Hide();
            Abrirformulario((Button)sender, new frmSalidas());
        }

        private void btnDVentas_Click(object sender, EventArgs e)
        {
            this.pDetalles.Hide();
            this.pAgregar.Hide();
            this.pEstadisticas.Hide();
            Abrirformulario(btnDetalles, new frmDetallesVentas());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.pDetalles.Hide();
            this.pAgregar.Hide();
            this.pEstadisticas.Hide();
            Abrirformulario(btnAgregarTodo, new frmAgregar());
        }

        private void btnESalidas_Click(object sender, EventArgs e)
        {
            this.pDetalles.Hide();
            this.pAgregar.Hide();
            this.pEstadisticas.Hide();
            Abrirformulario(btnEstadisticas, new frmReporteVenta());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.pDetalles.Hide();
            this.pAgregar.Hide();
            this.pEstadisticas.Hide();
            Abrirformulario((Button)sender, new frmVentas(usuarioActual));
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Abrirformulario(btnAgregarTodo, new frmUsuarios());
            this.pDetalles.Hide();
            this.pAgregar.Hide();
            this.pEstadisticas.Hide();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Abrirformulario(btnAgregarTodo, new frmProveedores());
            this.pDetalles.Hide();
            this.pAgregar.Hide();
            this.pEstadisticas.Hide();
        }

        private void txtNegocio_Click(object sender, EventArgs e)
        {
            this.pDetalles.Hide();
            this.pAgregar.Hide();
            this.pEstadisticas.Hide();
            Abrirformulario(btnDetalles, new frmNegocio());
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.pDetalles.Hide();
            this.pAgregar.Hide();
            this.pEstadisticas.Hide();
            if (!pAgregar.Visible)
                pAgregar.Visible = true;
            else
                pAgregar.Visible = false;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            this.pDetalles.Hide();
            this.pAgregar.Hide();
            this.pEstadisticas.Hide();
            Abrirformulario((Button)sender, new frmCompra(usuarioActual));
        }

        private void btnCorteCaja_Click(object sender, EventArgs e)
        {
            this.pDetalles.Hide();
            this.pAgregar.Hide();
            this.pEstadisticas.Hide();
            Abrirformulario((Button)sender, new frmCotizacion());
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            this.pDetalles.Hide();
            this.pAgregar.Hide();
            this.pEstadisticas.Hide();
            Abrirformulario(btnDetalles, new frmDetallesCompras());
        }

        private void pDetalles_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReporteSalidas_Click(object sender, EventArgs e)
        {
            this.pDetalles.Hide();
            this.pAgregar.Hide();
            this.pEstadisticas.Hide();
            Abrirformulario(btnEstadisticas, new frmReporteSalida());
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            this.pDetalles.Hide();
            this.pAgregar.Hide();
            this.pEstadisticas.Hide();
            Abrirformulario(btnAgregar, new frmCategorias());
        }
    }
}