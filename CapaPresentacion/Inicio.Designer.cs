namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            panelMenu = new Panel();
            btnCotizacion = new Button();
            btnAgregarTodo = new Button();
            btnCompras = new Button();
            lblusuario = new Label();
            btnVentas = new Button();
            brnCS = new Button();
            btnEstadisticas = new Button();
            btnDetalles = new Button();
            btnSalidas = new Button();
            pictureBox1 = new PictureBox();
            btnNegocio = new Button();
            btnProveedores = new Button();
            btnUsuarios = new Button();
            btnAgregar = new Button();
            pnlInicio = new Panel();
            pAgregar = new Panel();
            btnCategoria = new Button();
            pDetalles = new Panel();
            btnDCompra = new Button();
            btnDVentas = new Button();
            pEstadisticas = new Panel();
            btnReporteSalidas = new Button();
            btnReporteVentas = new Button();
            btnReporteCompras = new Button();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInicio.SuspendLayout();
            pAgregar.SuspendLayout();
            pDetalles.SuspendLayout();
            pEstadisticas.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Pink;
            panelMenu.Controls.Add(btnCotizacion);
            panelMenu.Controls.Add(btnAgregarTodo);
            panelMenu.Controls.Add(btnCompras);
            panelMenu.Controls.Add(lblusuario);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(brnCS);
            panelMenu.Controls.Add(btnEstadisticas);
            panelMenu.Controls.Add(btnDetalles);
            panelMenu.Controls.Add(btnSalidas);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(865, 51);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += Menu_Paint;
            // 
            // btnCotizacion
            // 
            btnCotizacion.FlatAppearance.BorderSize = 0;
            btnCotizacion.FlatStyle = FlatStyle.Flat;
            btnCotizacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCotizacion.ForeColor = Color.White;
            btnCotizacion.Location = new Point(392, 0);
            btnCotizacion.Name = "btnCotizacion";
            btnCotizacion.Size = new Size(92, 51);
            btnCotizacion.TabIndex = 16;
            btnCotizacion.Text = "Cotización";
            btnCotizacion.UseVisualStyleBackColor = true;
            btnCotizacion.Click += btnCorteCaja_Click;
            // 
            // btnAgregarTodo
            // 
            btnAgregarTodo.FlatAppearance.BorderSize = 0;
            btnAgregarTodo.FlatStyle = FlatStyle.Flat;
            btnAgregarTodo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarTodo.ForeColor = Color.White;
            btnAgregarTodo.Location = new Point(485, 0);
            btnAgregarTodo.Name = "btnAgregarTodo";
            btnAgregarTodo.Size = new Size(93, 51);
            btnAgregarTodo.TabIndex = 15;
            btnAgregarTodo.Text = "Agregar";
            btnAgregarTodo.UseVisualStyleBackColor = true;
            btnAgregarTodo.Click += button1_Click_3;
            // 
            // btnCompras
            // 
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompras.ForeColor = Color.White;
            btnCompras.Location = new Point(327, -1);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(64, 51);
            btnCompras.TabIndex = 14;
            btnCompras.Text = "Compras";
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += btnCompras_Click;
            // 
            // lblusuario
            // 
            lblusuario.Location = new Point(676, 18);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(40, 15);
            lblusuario.TabIndex = 13;
            lblusuario.Visible = false;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(95, 0);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(75, 51);
            btnVentas.TabIndex = 12;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // brnCS
            // 
            brnCS.BackColor = Color.DarkOrchid;
            brnCS.FlatAppearance.BorderSize = 0;
            brnCS.FlatStyle = FlatStyle.Flat;
            brnCS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            brnCS.ForeColor = Color.White;
            brnCS.Location = new Point(740, 9);
            brnCS.Name = "brnCS";
            brnCS.Size = new Size(116, 31);
            brnCS.TabIndex = 6;
            brnCS.Text = "Cerrar Sesión";
            brnCS.UseVisualStyleBackColor = false;
            brnCS.Click += brnCS_Click;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.FlatAppearance.BorderSize = 0;
            btnEstadisticas.FlatStyle = FlatStyle.Flat;
            btnEstadisticas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEstadisticas.ForeColor = Color.White;
            btnEstadisticas.Location = new Point(581, 0);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(79, 51);
            btnEstadisticas.TabIndex = 5;
            btnEstadisticas.Text = "Reportes";
            btnEstadisticas.UseVisualStyleBackColor = true;
            btnEstadisticas.Click += btnEstadisticas_Click_1;
            // 
            // btnDetalles
            // 
            btnDetalles.FlatAppearance.BorderSize = 0;
            btnDetalles.FlatStyle = FlatStyle.Flat;
            btnDetalles.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDetalles.ForeColor = Color.White;
            btnDetalles.Location = new Point(247, 0);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(78, 51);
            btnDetalles.TabIndex = 3;
            btnDetalles.Text = "Detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // btnSalidas
            // 
            btnSalidas.FlatAppearance.BorderSize = 0;
            btnSalidas.FlatStyle = FlatStyle.Flat;
            btnSalidas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalidas.ForeColor = Color.White;
            btnSalidas.Location = new Point(171, 0);
            btnSalidas.Name = "btnSalidas";
            btnSalidas.Size = new Size(74, 51);
            btnSalidas.TabIndex = 2;
            btnSalidas.Text = "Salidas";
            btnSalidas.UseVisualStyleBackColor = true;
            btnSalidas.Click += btnSalidas_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnNegocio
            // 
            btnNegocio.FlatAppearance.BorderSize = 0;
            btnNegocio.FlatStyle = FlatStyle.Flat;
            btnNegocio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNegocio.ForeColor = Color.White;
            btnNegocio.Location = new Point(0, 79);
            btnNegocio.Name = "btnNegocio";
            btnNegocio.Size = new Size(114, 39);
            btnNegocio.TabIndex = 14;
            btnNegocio.Text = "Detalles Negocio";
            btnNegocio.UseVisualStyleBackColor = true;
            btnNegocio.Click += txtNegocio_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Location = new Point(0, 41);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(114, 39);
            btnProveedores.TabIndex = 11;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(0, 82);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(114, 39);
            btnUsuarios.TabIndex = 10;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(0, 0);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 39);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Productos";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // pnlInicio
            // 
            pnlInicio.BackColor = Color.FromArgb(64, 0, 64);
            pnlInicio.Controls.Add(pAgregar);
            pnlInicio.Controls.Add(pDetalles);
            pnlInicio.Controls.Add(pEstadisticas);
            pnlInicio.Dock = DockStyle.Fill;
            pnlInicio.Location = new Point(0, 51);
            pnlInicio.Name = "pnlInicio";
            pnlInicio.Size = new Size(865, 474);
            pnlInicio.TabIndex = 1;
            // 
            // pAgregar
            // 
            pAgregar.BackColor = Color.Pink;
            pAgregar.Controls.Add(btnCategoria);
            pAgregar.Controls.Add(btnAgregar);
            pAgregar.Controls.Add(btnProveedores);
            pAgregar.Controls.Add(btnUsuarios);
            pAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pAgregar.Location = new Point(484, 0);
            pAgregar.Name = "pAgregar";
            pAgregar.Size = new Size(114, 165);
            pAgregar.TabIndex = 2;
            pAgregar.Visible = false;
            // 
            // btnCategoria
            // 
            btnCategoria.FlatAppearance.BorderSize = 0;
            btnCategoria.FlatStyle = FlatStyle.Flat;
            btnCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategoria.ForeColor = Color.White;
            btnCategoria.Location = new Point(0, 123);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(114, 39);
            btnCategoria.TabIndex = 17;
            btnCategoria.Text = "Categorias";
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // pDetalles
            // 
            pDetalles.BackColor = Color.Pink;
            pDetalles.Controls.Add(btnDCompra);
            pDetalles.Controls.Add(btnNegocio);
            pDetalles.Controls.Add(btnDVentas);
            pDetalles.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pDetalles.Location = new Point(247, 0);
            pDetalles.Name = "pDetalles";
            pDetalles.Size = new Size(114, 122);
            pDetalles.TabIndex = 1;
            pDetalles.Visible = false;
            pDetalles.Paint += pDetalles_Paint;
            // 
            // btnDCompra
            // 
            btnDCompra.FlatAppearance.BorderSize = 0;
            btnDCompra.FlatStyle = FlatStyle.Flat;
            btnDCompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDCompra.ForeColor = Color.White;
            btnDCompra.Location = new Point(0, 39);
            btnDCompra.Name = "btnDCompra";
            btnDCompra.Size = new Size(114, 39);
            btnDCompra.TabIndex = 15;
            btnDCompra.Text = "Detalles Compras";
            btnDCompra.UseVisualStyleBackColor = true;
            btnDCompra.Click += button1_Click_4;
            // 
            // btnDVentas
            // 
            btnDVentas.FlatAppearance.BorderSize = 0;
            btnDVentas.FlatStyle = FlatStyle.Flat;
            btnDVentas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDVentas.ForeColor = Color.White;
            btnDVentas.Location = new Point(0, -1);
            btnDVentas.Name = "btnDVentas";
            btnDVentas.Size = new Size(114, 39);
            btnDVentas.TabIndex = 6;
            btnDVentas.Text = "Detalles de Venta";
            btnDVentas.UseVisualStyleBackColor = true;
            btnDVentas.Click += btnDVentas_Click;
            // 
            // pEstadisticas
            // 
            pEstadisticas.BackColor = Color.Pink;
            pEstadisticas.Controls.Add(btnReporteSalidas);
            pEstadisticas.Controls.Add(btnReporteVentas);
            pEstadisticas.Controls.Add(btnReporteCompras);
            pEstadisticas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pEstadisticas.Location = new Point(580, 0);
            pEstadisticas.Name = "pEstadisticas";
            pEstadisticas.Size = new Size(135, 122);
            pEstadisticas.TabIndex = 0;
            pEstadisticas.Visible = false;
            // 
            // btnReporteSalidas
            // 
            btnReporteSalidas.FlatAppearance.BorderSize = 0;
            btnReporteSalidas.FlatStyle = FlatStyle.Flat;
            btnReporteSalidas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReporteSalidas.ForeColor = Color.White;
            btnReporteSalidas.Location = new Point(0, 82);
            btnReporteSalidas.Name = "btnReporteSalidas";
            btnReporteSalidas.Size = new Size(136, 39);
            btnReporteSalidas.TabIndex = 8;
            btnReporteSalidas.Text = "Reporte de Salida";
            btnReporteSalidas.UseVisualStyleBackColor = true;
            btnReporteSalidas.Click += btnReporteSalidas_Click;
            // 
            // btnReporteVentas
            // 
            btnReporteVentas.FlatAppearance.BorderSize = 0;
            btnReporteVentas.FlatStyle = FlatStyle.Flat;
            btnReporteVentas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReporteVentas.ForeColor = Color.White;
            btnReporteVentas.Location = new Point(0, -1);
            btnReporteVentas.Name = "btnReporteVentas";
            btnReporteVentas.Size = new Size(135, 39);
            btnReporteVentas.TabIndex = 7;
            btnReporteVentas.Text = "Reporte de Ventas";
            btnReporteVentas.UseVisualStyleBackColor = true;
            btnReporteVentas.Click += btnESalidas_Click;
            // 
            // btnReporteCompras
            // 
            btnReporteCompras.FlatAppearance.BorderSize = 0;
            btnReporteCompras.FlatStyle = FlatStyle.Flat;
            btnReporteCompras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReporteCompras.ForeColor = Color.White;
            btnReporteCompras.Location = new Point(1, 41);
            btnReporteCompras.Name = "btnReporteCompras";
            btnReporteCompras.Size = new Size(135, 39);
            btnReporteCompras.TabIndex = 6;
            btnReporteCompras.Text = "Reporte de Compras";
            btnReporteCompras.UseVisualStyleBackColor = true;
            btnReporteCompras.Click += button1_Click_2;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 525);
            Controls.Add(pnlInicio);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Inicio_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlInicio.ResumeLayout(false);
            pAgregar.ResumeLayout(false);
            pDetalles.ResumeLayout(false);
            pEstadisticas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private PictureBox pictureBox1;
        private Button btnSalidas;
        private Button btnAgregar;
        private Button btnDetalles;
        private Button brnCS;
        private Button btnEstadisticas;
        private Panel pnlInicio;
        private Panel pEstadisticas;
        private Button btnEVentas;
        private Button btnESalidas;
        private Button btnCompras;
        private Button btnCorteCaja;
        private Button btnVentas;
        private Button btnProveedor;
        private Button btnUsuarios;
        private Panel pDetalles;
        private Button btnDVentas;
        private Button btnProveedores;
        private Label lblusuario;
        private Button btnNegocio;
        private Panel pAgregar;
        private Button btnAgregarTodo;
        private Button button1;
        private Button btnReporteSalidas;
        private Button btnCategoria;
        private Button btnDCompra;
        private Button btnCotizacion;
        private Button btnReporteVentas;
        private Button btnReporteCompras;
    }
}