namespace CapaPresentacion
{
    partial class frmAgregar
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
            panel1 = new Panel();
            cboCategoria = new ComboBox();
            label4 = new Label();
            cboEstado = new ComboBox();
            label6 = new Label();
            txtDescripcion = new TextBox();
            label5 = new Label();
            label7 = new Label();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            txtindice = new TextBox();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            txtEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel2 = new Panel();
            dgvdata = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            IdCategoria = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnExportar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            cbobusqueda = new ComboBox();
            txtbusqueda = new TextBox();
            label9 = new Label();
            label8 = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 172, 192);
            panel1.Controls.Add(cboCategoria);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cboEstado);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(txtindice);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(txtEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 471);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // cboCategoria
            // 
            cboCategoria.FlatStyle = FlatStyle.Flat;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(20, 243);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(177, 23);
            cboCategoria.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 227);
            label4.Name = "label4";
            label4.Size = new Size(60, 13);
            label4.TabIndex = 28;
            label4.Text = "Categoria:";
            // 
            // cboEstado
            // 
            cboEstado.FlatStyle = FlatStyle.Flat;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(19, 289);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(177, 23);
            cboEstado.TabIndex = 27;
            cboEstado.SelectedIndexChanged += cboEstado_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(19, 273);
            label6.Name = "label6";
            label6.Size = new Size(45, 13);
            label6.TabIndex = 23;
            label6.Text = "Estado:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(18, 167);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(177, 52);
            txtDescripcion.TabIndex = 19;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Location = new Point(18, 170);
            label5.Name = "label5";
            label5.Size = new Size(177, 46);
            label5.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(22, 150);
            label7.Name = "label7";
            label7.Size = new Size(70, 13);
            label7.TabIndex = 18;
            label7.Text = "Descripcion:";
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
            btnLimpiar.Size = new Size(36, 22);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
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
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(19, 121);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(177, 18);
            txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.None;
            txtCodigo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(19, 75);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(177, 18);
            txtCodigo.TabIndex = 2;
            // 
            // txtEliminar
            // 
            txtEliminar.BackColor = Color.Crimson;
            txtEliminar.FlatAppearance.BorderSize = 0;
            txtEliminar.FlatStyle = FlatStyle.Flat;
            txtEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtEliminar.ForeColor = Color.White;
            txtEliminar.Location = new Point(22, 424);
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
            btnModificar.Location = new Point(19, 382);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(177, 25);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LimeGreen;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(19, 338);
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
            label3.Location = new Point(22, 103);
            label3.Name = "label3";
            label3.Size = new Size(51, 13);
            label3.TabIndex = 3;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 57);
            label2.Name = "label2";
            label2.Size = new Size(48, 13);
            label2.TabIndex = 1;
            label2.Text = "Codigo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR PRODUCTO";
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Location = new Point(19, 74);
            label11.Name = "label11";
            label11.Size = new Size(177, 22);
            label11.TabIndex = 25;
            // 
            // label12
            // 
            label12.BackColor = Color.White;
            label12.Location = new Point(19, 119);
            label12.Name = "label12";
            label12.Size = new Size(177, 22);
            label12.TabIndex = 26;
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
            panel2.TabIndex = 1;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, Id, Codigo, Nombre, Descripcion, IdCategoria, Categoria, Stock, PrecioCompra, PrecioVenta, EstadoValor, Estado });
            dgvdata.EnableHeadersVisualStyles = false;
            dgvdata.Location = new Point(14, 87);
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
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(622, 372);
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
            Id.HeaderText = "IdProducto";
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 140;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.Width = 80;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 80;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 115;
            // 
            // IdCategoria
            // 
            IdCategoria.HeaderText = "IdCategoria";
            IdCategoria.Name = "IdCategoria";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "PrecioCompra";
            PrecioCompra.Name = "PrecioCompra";
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "PrecioVenta";
            PrecioVenta.Name = "PrecioVenta";
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
            panel3.Controls.Add(label8);
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(648, 73);
            panel3.TabIndex = 0;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(0, 192, 0);
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btnExportar.IconColor = Color.White;
            btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportar.IconSize = 15;
            btnExportar.Location = new Point(17, 25);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(112, 23);
            btnExportar.TabIndex = 7;
            btnExportar.Text = "Descargar Excel";
            btnExportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Violet;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 16;
            btnBuscar.Location = new Point(533, 24);
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
            btnLimpiarBuscador.Location = new Point(573, 24);
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
            cbobusqueda.Location = new Point(290, 25);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(107, 23);
            cbobusqueda.TabIndex = 3;
            // 
            // txtbusqueda
            // 
            txtbusqueda.BorderStyle = BorderStyle.None;
            txtbusqueda.Location = new Point(401, 28);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(131, 16);
            txtbusqueda.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(218, 28);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 1;
            label9.Text = "Buscar por:";
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Location = new Point(401, 24);
            label8.Name = "label8";
            label8.Size = new Size(131, 24);
            label8.TabIndex = 26;
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
            // frmAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(865, 471);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmAgregar";
            Text = "frmAgregar";
            Load += frmAgregar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtCodigo;
        private Label label2;
        private Label label1;
        private Button btnModificar;
        private Button btnAgregar;
        private Button txtEliminar;
        private ComboBox cbobusqueda;
        private TextBox txtbusqueda;
        private Label label9;
        private DataGridView dgvdata;
        private TextBox txtId;
        private TextBox txtindice;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Label label6;
        private TextBox txtDescripcion;
        private Label label5;
        private Label label7;
        private Label label11;
        private Label label12;
        private FontAwesome.Sharp.IconButton btnExportar;
        private ComboBox cboEstado;
        private ComboBox cboCategoria;
        private Label label4;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private Label label8;
        private Panel panel4;
    }
}