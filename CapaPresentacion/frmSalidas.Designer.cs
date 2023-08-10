namespace CapaPresentacion
{
    partial class frmSalidas
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
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            txtindice = new TextBox();
            txtId = new TextBox();
            txtDescripcion = new TextBox();
            txtMonto = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            panel3 = new Panel();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            cbobusqueda = new ComboBox();
            txtbusqueda = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvdata = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            btnExportar = new FontAwesome.Sharp.IconButton();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            btnLimpiar.Location = new Point(158, 49);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(38, 23);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtindice
            // 
            txtindice.BorderStyle = BorderStyle.None;
            txtindice.Location = new Point(111, 57);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(26, 16);
            txtindice.TabIndex = 14;
            txtindice.Text = "-1";
            txtindice.Visible = false;
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.None;
            txtId.Location = new Point(78, 57);
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
            txtDescripcion.Location = new Point(19, 212);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(177, 63);
            txtDescripcion.TabIndex = 6;
            // 
            // txtMonto
            // 
            txtMonto.BorderStyle = BorderStyle.None;
            txtMonto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonto.Location = new Point(19, 149);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(177, 18);
            txtMonto.TabIndex = 4;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Location = new Point(19, 143);
            label7.Name = "label7";
            label7.Size = new Size(177, 29);
            label7.TabIndex = 12;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Location = new Point(19, 209);
            label6.Name = "label6";
            label6.Size = new Size(177, 66);
            label6.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(19, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(177, 18);
            txtNombre.TabIndex = 2;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Location = new Point(19, 80);
            label5.Name = "label5";
            label5.Size = new Size(177, 29);
            label5.TabIndex = 10;
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
            panel3.Controls.Add(label10);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(648, 72);
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
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Location = new Point(399, 24);
            label10.Name = "label10";
            label10.Size = new Size(131, 24);
            label10.TabIndex = 11;
            // 
            // txtEliminar
            // 
            txtEliminar.BackColor = Color.Crimson;
            txtEliminar.FlatAppearance.BorderSize = 0;
            txtEliminar.FlatStyle = FlatStyle.Flat;
            txtEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtEliminar.ForeColor = Color.White;
            txtEliminar.Location = new Point(19, 403);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(177, 31);
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
            btnModificar.Location = new Point(19, 357);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(177, 30);
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
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(19, 309);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(177, 30);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 189);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 5;
            label4.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 123);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "Monto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 60);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
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
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, Id, Nombre, Monto, Descripcion });
            dgvdata.EnableHeadersVisualStyles = false;
            dgvdata.Location = new Point(14, 86);
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
            dgvdata.Size = new Size(622, 378);
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
            Id.HeaderText = "IdSalida";
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 140;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 155;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            Monto.Width = 145;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 245;
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
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 15);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR SALIDAS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 172, 192);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(txtindice);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtMonto);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 471);
            panel1.TabIndex = 2;
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
            btnExportar.Location = new Point(14, 25);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(112, 23);
            btnExportar.TabIndex = 8;
            btnExportar.Text = "Descargar Excel";
            btnExportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // frmSalidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 471);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmSalidas";
            Text = "frmSalidas";
            Load += frmSalidas_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private TextBox txtindice;
        private TextBox txtId;
        private TextBox txtDescripcion;
        private TextBox txtMonto;
        private Label label7;
        private Label label6;
        private TextBox txtNombre;
        private Label label5;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private ComboBox cbobusqueda;
        private TextBox txtbusqueda;
        private Label label9;
        private Button txtEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgvdata;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Descripcion;
        private Label label10;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btnExportar;
    }
}