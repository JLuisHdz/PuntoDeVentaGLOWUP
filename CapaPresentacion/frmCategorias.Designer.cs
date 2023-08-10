namespace CapaPresentacion
{
    partial class frmCategorias
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
            label9 = new Label();
            dgvdata = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnExportar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            cbobusqueda = new ComboBox();
            txtbusqueda = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            cboEstado = new ComboBox();
            label6 = new Label();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            txtindice = new TextBox();
            txtId = new TextBox();
            txtDescripcion = new TextBox();
            txtEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label2 = new Label();
            label1 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(218, 30);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 1;
            label9.Text = "Buscar por:";
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, Id, Descripcion, EstadoValor, Estado });
            dgvdata.EnableHeadersVisualStyles = false;
            dgvdata.Location = new Point(14, 89);
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
            dgvdata.Size = new Size(622, 375);
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
            Id.HeaderText = "IdCategoria";
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 140;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 345;
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
            Estado.Width = 200;
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
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
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
            btnExportar.ForeColor = Color.White;
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
            btnBuscar.BackColor = Color.Orchid;
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
            txtbusqueda.Location = new Point(401, 29);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(131, 16);
            txtbusqueda.TabIndex = 2;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(401, 25);
            label3.Name = "label3";
            label3.Size = new Size(131, 23);
            label3.TabIndex = 26;
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
            panel4.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 172, 192);
            panel1.Controls.Add(cboEstado);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(txtindice);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 471);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // cboEstado
            // 
            cboEstado.FlatStyle = FlatStyle.Flat;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(22, 159);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(174, 23);
            cboEstado.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 143);
            label6.Name = "label6";
            label6.Size = new Size(45, 13);
            label6.TabIndex = 23;
            label6.Text = "Estado:";
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
            btnLimpiar.Location = new Point(160, 47);
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
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(19, 94);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(177, 18);
            txtDescripcion.TabIndex = 2;
            // 
            // txtEliminar
            // 
            txtEliminar.BackColor = Color.Crimson;
            txtEliminar.FlatAppearance.BorderSize = 0;
            txtEliminar.FlatStyle = FlatStyle.Flat;
            txtEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtEliminar.ForeColor = Color.White;
            txtEliminar.Location = new Point(19, 418);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(177, 30);
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
            btnModificar.Location = new Point(19, 363);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(177, 31);
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
            btnAgregar.Location = new Point(19, 307);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(177, 30);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 72);
            label2.Name = "label2";
            label2.Size = new Size(70, 13);
            label2.TabIndex = 1;
            label2.Text = "Descripcion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR CATEGORIA";
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Location = new Point(19, 89);
            label11.Name = "label11";
            label11.Size = new Size(177, 28);
            label11.TabIndex = 25;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 471);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmCategorias";
            Text = "frmCategorias";
            Load += frmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label9;
        private DataGridView dgvdata;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnExportar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private ComboBox cbobusqueda;
        private TextBox txtbusqueda;
        private Panel panel2;
        private Panel panel1;
        private ComboBox cboEstado;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private TextBox txtindice;
        private TextBox txtId;
        private TextBox txtDescripcion;
        private Button txtEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label2;
        private Label label1;
        private Label label11;
        private Label label3;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private Panel panel4;
    }
}