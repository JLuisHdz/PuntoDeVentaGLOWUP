namespace CapaPresentacion
{
    partial class frmProveedores
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnAgregar = new Button();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            cbobusqueda = new ComboBox();
            txtbusqueda = new TextBox();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            dgvdata = new DataGridView();
            panel3 = new Panel();
            btnExportar = new FontAwesome.Sharp.IconButton();
            label13 = new Label();
            panel4 = new Panel();
            panel1 = new Panel();
            cboEstado = new ComboBox();
            txtTelefono = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtCorreo = new TextBox();
            label6 = new Label();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            txtindice = new TextBox();
            txtId = new TextBox();
            txtRazonSocial = new TextBox();
            label7 = new Label();
            txtDocumento = new TextBox();
            label5 = new Label();
            txtEliminar = new Button();
            btnModificar = new Button();
            label1 = new Label();
            btnseleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(19, 344);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(177, 25);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
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
            btnBuscar.Location = new Point(530, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(36, 24);
            btnBuscar.TabIndex = 6;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
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
            btnLimpiarBuscador.Location = new Point(571, 24);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new Size(36, 24);
            btnLimpiarBuscador.TabIndex = 5;
            btnLimpiarBuscador.UseVisualStyleBackColor = false;
            btnLimpiarBuscador.Click += btnLimpiarBuscador_Click;
            // 
            // cbobusqueda
            // 
            cbobusqueda.FlatStyle = FlatStyle.Flat;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(288, 25);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(107, 23);
            cbobusqueda.TabIndex = 3;
            // 
            // txtbusqueda
            // 
            txtbusqueda.BorderStyle = BorderStyle.None;
            txtbusqueda.Location = new Point(399, 28);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(131, 16);
            txtbusqueda.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(216, 28);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 1;
            label9.Text = "Buscar por:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 160);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 5;
            label4.Text = "Correo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 108);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 3;
            label3.Text = "Razon Social:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 54);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "No. Documento:";
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
            panel2.TabIndex = 5;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvdata.BorderStyle = BorderStyle.None;
            dgvdata.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.PaleVioletRed;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DeepPink;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, Id, Documento, RazonSocial, Correo, Telefono, EstadoValor, Estado });
            dgvdata.EnableHeadersVisualStyles = false;
            dgvdata.Location = new Point(14, 85);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Pink;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightPink;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(622, 371);
            dgvdata.TabIndex = 1;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
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
            panel3.Controls.Add(label13);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(648, 72);
            panel3.TabIndex = 0;
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
            btnExportar.Location = new Point(14, 24);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(112, 23);
            btnExportar.TabIndex = 31;
            btnExportar.Text = "Descargar Excel";
            btnExportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // label13
            // 
            label13.BackColor = Color.White;
            label13.Location = new Point(399, 24);
            label13.Name = "label13";
            label13.Size = new Size(131, 24);
            label13.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 0, 64);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(648, 471);
            panel4.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 172, 192);
            panel1.Controls.Add(cboEstado);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(txtindice);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtRazonSocial);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtDocumento);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 471);
            panel1.TabIndex = 4;
            // 
            // cboEstado
            // 
            cboEstado.FlatStyle = FlatStyle.Flat;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(19, 290);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(177, 23);
            cboEstado.TabIndex = 22;
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(19, 237);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(177, 18);
            txtTelefono.TabIndex = 19;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Location = new Point(19, 235);
            label10.Name = "label10";
            label10.Size = new Size(177, 23);
            label10.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(23, 271);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 20;
            label11.Text = "Estado:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(23, 217);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 18;
            label12.Text = "Telefono:";
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(20, 180);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(177, 18);
            txtCorreo.TabIndex = 16;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Location = new Point(20, 178);
            label6.Name = "label6";
            label6.Size = new Size(177, 23);
            label6.TabIndex = 17;
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
            btnLimpiar.Location = new Point(160, 43);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(36, 23);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtindice
            // 
            txtindice.BorderStyle = BorderStyle.None;
            txtindice.Location = new Point(123, 38);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(26, 16);
            txtindice.TabIndex = 14;
            txtindice.Text = "-1";
            txtindice.Visible = false;
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.None;
            txtId.Location = new Point(91, 38);
            txtId.Name = "txtId";
            txtId.Size = new Size(26, 16);
            txtId.TabIndex = 13;
            txtId.Text = "0";
            txtId.Visible = false;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.BorderStyle = BorderStyle.None;
            txtRazonSocial.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtRazonSocial.Location = new Point(19, 127);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(177, 18);
            txtRazonSocial.TabIndex = 4;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Location = new Point(19, 125);
            label7.Name = "label7";
            label7.Size = new Size(177, 23);
            label7.TabIndex = 12;
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
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Location = new Point(19, 72);
            label5.Name = "label5";
            label5.Size = new Size(177, 23);
            label5.TabIndex = 10;
            // 
            // txtEliminar
            // 
            txtEliminar.BackColor = Color.Crimson;
            txtEliminar.FlatAppearance.BorderSize = 0;
            txtEliminar.FlatStyle = FlatStyle.Flat;
            txtEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtEliminar.ForeColor = Color.White;
            txtEliminar.Location = new Point(19, 429);
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
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(19, 388);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(177, 25);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR PROVEEDORES";
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.Width = 33;
            // 
            // Id
            // 
            Id.HeaderText = "IdProveedor";
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 140;
            // 
            // Documento
            // 
            Documento.HeaderText = "No. Documento";
            Documento.Name = "Documento";
            Documento.Width = 115;
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Nombre";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.Width = 120;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.Width = 110;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.Width = 110;
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
            Estado.Width = 90;
            // 
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 471);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmProveedores";
            Text = "frmProveedores";
            Load += frmProveedores_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private ComboBox cbobusqueda;
        private TextBox txtbusqueda;
        private Label label9;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private DataGridView dgvdata;
        private Panel panel3;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private TextBox txtindice;
        private TextBox txtId;
        private TextBox txtRazonSocial;
        private Label label7;
        private TextBox txtDocumento;
        private Label label5;
        private Button txtEliminar;
        private Button btnModificar;
        private Label label1;
        private TextBox txtCorreo;
        private Label label6;
        private TextBox txtTelefono;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox cboEstado;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private Label label13;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btnExportar;
    }
}