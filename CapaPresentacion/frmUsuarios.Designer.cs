namespace CapaPresentacion
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label6 = new Label();
            label10 = new Label();
            txtbusqueda = new TextBox();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            txtId = new TextBox();
            txtClave = new TextBox();
            txtNombre = new TextBox();
            txtDocumento = new TextBox();
            label9 = new Label();
            txtindice = new TextBox();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            txtEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label3 = new Label();
            label1 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            cbobusqueda = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            dgvdata = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            IdRol = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            cboEstado = new ComboBox();
            cboRol = new ComboBox();
            btnExportar = new FontAwesome.Sharp.IconButton();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 284);
            label6.Name = "label6";
            label6.Size = new Size(45, 13);
            label6.TabIndex = 23;
            label6.Text = "Estado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(22, 228);
            label10.Name = "label10";
            label10.Size = new Size(27, 13);
            label10.TabIndex = 21;
            label10.Text = "Rol:";
            // 
            // txtbusqueda
            // 
            txtbusqueda.BorderStyle = BorderStyle.None;
            txtbusqueda.Location = new Point(401, 28);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(131, 16);
            txtbusqueda.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.MediumVioletRed;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnLimpiar.IconColor = Color.White;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 16;
            btnLimpiar.Location = new Point(160, 42);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(36, 21);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.None;
            txtId.Location = new Point(95, 41);
            txtId.Name = "txtId";
            txtId.Size = new Size(26, 16);
            txtId.TabIndex = 13;
            txtId.Text = "0";
            txtId.Visible = false;
            // 
            // txtClave
            // 
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.Location = new Point(19, 185);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(177, 18);
            txtClave.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(19, 130);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(177, 18);
            txtNombre.TabIndex = 4;
            // 
            // txtDocumento
            // 
            txtDocumento.BorderStyle = BorderStyle.None;
            txtDocumento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumento.Location = new Point(19, 74);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(177, 18);
            txtDocumento.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(218, 28);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 1;
            label9.Text = "Buscar por:";
            // 
            // txtindice
            // 
            txtindice.BorderStyle = BorderStyle.None;
            txtindice.Location = new Point(128, 41);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(26, 16);
            txtindice.TabIndex = 14;
            txtindice.Text = "-1";
            txtindice.Visible = false;
            // 
            // btnLimpiarBuscador
            // 
            btnLimpiarBuscador.BackColor = Color.MediumVioletRed;
            btnLimpiarBuscador.FlatAppearance.BorderSize = 0;
            btnLimpiarBuscador.FlatStyle = FlatStyle.Flat;
            btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnLimpiarBuscador.IconColor = Color.White;
            btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarBuscador.IconSize = 16;
            btnLimpiarBuscador.Location = new Point(573, 24);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new Size(36, 24);
            btnLimpiarBuscador.TabIndex = 5;
            btnLimpiarBuscador.UseVisualStyleBackColor = false;
            btnLimpiarBuscador.Click += btnLimpiarBuscador_Click;
            // 
            // txtEliminar
            // 
            txtEliminar.BackColor = Color.Crimson;
            txtEliminar.FlatAppearance.BorderSize = 0;
            txtEliminar.FlatStyle = FlatStyle.Flat;
            txtEliminar.ForeColor = Color.White;
            txtEliminar.Location = new Point(19, 430);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(177, 25);
            txtEliminar.TabIndex = 9;
            txtEliminar.Text = "Eliminar";
            txtEliminar.UseVisualStyleBackColor = false;
            txtEliminar.Click += txtEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Gold;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(19, 388);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(177, 25);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(19, 346);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(177, 25);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 113);
            label3.Name = "label3";
            label3.Size = new Size(51, 13);
            label3.TabIndex = 3;
            label3.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 15);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR USUARIO";
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Location = new Point(19, 73);
            label11.Name = "label11";
            label11.Size = new Size(177, 22);
            label11.TabIndex = 25;
            // 
            // label12
            // 
            label12.BackColor = Color.White;
            label12.Location = new Point(19, 128);
            label12.Name = "label12";
            label12.Size = new Size(177, 22);
            label12.TabIndex = 26;
            // 
            // label13
            // 
            label13.BackColor = Color.White;
            label13.Location = new Point(20, 183);
            label13.Name = "label13";
            label13.Size = new Size(177, 22);
            label13.TabIndex = 27;
            // 
            // cbobusqueda
            // 
            cbobusqueda.FlatStyle = FlatStyle.Flat;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(290, 25);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(107, 23);
            cbobusqueda.TabIndex = 3;
            cbobusqueda.SelectedIndexChanged += cbobusqueda_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 169);
            label4.Name = "label4";
            label4.Size = new Size(37, 13);
            label4.TabIndex = 5;
            label4.Text = "Clave:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 57);
            label2.Name = "label2";
            label2.Size = new Size(91, 13);
            label2.TabIndex = 1;
            label2.Text = "No. Documento:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 152, 192);
            panel3.Controls.Add(btnExportar);
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(btnLimpiarBuscador);
            panel3.Controls.Add(cbobusqueda);
            panel3.Controls.Add(txtbusqueda);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(648, 73);
            panel3.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Orchid;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 16;
            btnBuscar.Location = new Point(532, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(36, 24);
            btnBuscar.TabIndex = 6;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Location = new Point(401, 24);
            label5.Name = "label5";
            label5.Size = new Size(131, 24);
            label5.TabIndex = 27;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvdata.BorderStyle = BorderStyle.None;
            dgvdata.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.PaleVioletRed;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.DeepPink;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, Id, Documento, Nombre, Clave, IdRol, Rol, EstadoValor, Estado });
            dgvdata.EnableHeadersVisualStyles = false;
            dgvdata.Location = new Point(14, 90);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Pink;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightPink;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(622, 365);
            dgvdata.TabIndex = 1;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.Width = 33;
            // 
            // Id
            // 
            Id.HeaderText = "IdUsuario";
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 140;
            // 
            // Documento
            // 
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            Documento.Width = 109;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 109;
            // 
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.Name = "Clave";
            Clave.Width = 109;
            // 
            // IdRol
            // 
            IdRol.HeaderText = "IdRol";
            IdRol.Name = "IdRol";
            IdRol.Visible = false;
            IdRol.Width = 175;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.Width = 109;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.Visible = false;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.Width = 109;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(dgvdata);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(217, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(648, 471);
            panel2.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 0, 64);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(648, 471);
            panel4.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 172, 192);
            panel1.Controls.Add(cboEstado);
            panel1.Controls.Add(cboRol);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(txtindice);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtClave);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtDocumento);
            panel1.Controls.Add(txtEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 471);
            panel1.TabIndex = 2;
            // 
            // cboEstado
            // 
            cboEstado.FlatStyle = FlatStyle.Flat;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(19, 300);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(177, 23);
            cboEstado.TabIndex = 29;
            cboEstado.SelectedIndexChanged += cboEstado_SelectedIndexChanged;
            // 
            // cboRol
            // 
            cboRol.FlatStyle = FlatStyle.Flat;
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(19, 243);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(177, 23);
            cboRol.TabIndex = 28;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(0, 192, 0);
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.ForeColor = Color.White;
            btnExportar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btnExportar.IconColor = Color.White;
            btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportar.IconSize = 15;
            btnExportar.Location = new Point(16, 25);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(112, 23);
            btnExportar.TabIndex = 30;
            btnExportar.Text = "Descargar Excel";
            btnExportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 471);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label6;
        private Label label10;
        private TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private TextBox txtId;
        private TextBox txtClave;
        private TextBox txtNombre;
        private TextBox txtDocumento;
        private Label label9;
        private TextBox txtindice;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private Button txtEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label3;
        private Label label1;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox cbobusqueda;
        private Label label4;
        private Label label2;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private DataGridView dgvdata;
        private Panel panel2;
        private Panel panel1;
        private ComboBox cboEstado;
        private ComboBox cboRol;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn IdRol;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private Label label5;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btnExportar;
    }
}