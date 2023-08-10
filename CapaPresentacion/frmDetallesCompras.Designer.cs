namespace CapaPresentacion
{
    partial class frmDetallesCompras
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
            txtDocumento = new TextBox();
            txtUsuario = new TextBox();
            label5 = new Label();
            label6 = new Label();
            lble = new Label();
            label2 = new Label();
            txtFecha = new TextBox();
            label3 = new Label();
            label12 = new Label();
            txtNumeroDocumento = new TextBox();
            txtNombreProveedor = new TextBox();
            label7 = new Label();
            label4 = new Label();
            txtDocProveedor = new TextBox();
            label8 = new Label();
            label10 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txtMonto = new TextBox();
            label11 = new Label();
            txtMontoTotal = new Label();
            dgvdata = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            label9 = new Label();
            label1 = new Label();
            label13 = new Label();
            label14 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(txtDocumento);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lble);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtFecha);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtNumeroDocumento);
            panel1.Controls.Add(txtNombreProveedor);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtDocProveedor);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(txtMonto);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtMontoTotal);
            panel1.Controls.Add(dgvdata);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(btnLimpiarBuscador);
            panel1.Controls.Add(txtbusqueda);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Location = new Point(57, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 417);
            panel1.TabIndex = 0;
            // 
            // txtDocumento
            // 
            txtDocumento.BorderStyle = BorderStyle.None;
            txtDocumento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumento.ForeColor = Color.FromArgb(64, 64, 64);
            txtDocumento.Location = new Point(189, 99);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(205, 18);
            txtDocumento.TabIndex = 52;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            txtUsuario.Location = new Point(428, 100);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(205, 18);
            txtUsuario.TabIndex = 50;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Location = new Point(428, 98);
            label5.Name = "label5";
            label5.Size = new Size(205, 22);
            label5.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(427, 82);
            label6.Name = "label6";
            label6.Size = new Size(50, 13);
            label6.TabIndex = 49;
            label6.Text = "Usuario:";
            // 
            // lble
            // 
            lble.BackColor = Color.White;
            lble.Location = new Point(189, 98);
            lble.Name = "lble";
            lble.Size = new Size(205, 22);
            lble.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(188, 82);
            label2.Name = "label2";
            label2.Size = new Size(112, 13);
            label2.TabIndex = 45;
            label2.Text = "Tipo de Documento:";
            // 
            // txtFecha
            // 
            txtFecha.BorderStyle = BorderStyle.None;
            txtFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFecha.ForeColor = Color.FromArgb(64, 64, 64);
            txtFecha.Location = new Point(30, 100);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(111, 18);
            txtFecha.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(33, 82);
            label3.Name = "label3";
            label3.Size = new Size(40, 13);
            label3.TabIndex = 44;
            label3.Text = "Fecha:";
            // 
            // label12
            // 
            label12.BackColor = Color.White;
            label12.Location = new Point(30, 98);
            label12.Name = "label12";
            label12.Size = new Size(111, 22);
            label12.TabIndex = 47;
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(641, 175);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(41, 23);
            txtNumeroDocumento.TabIndex = 43;
            txtNumeroDocumento.Visible = false;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.BorderStyle = BorderStyle.None;
            txtNombreProveedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreProveedor.ForeColor = Color.FromArgb(64, 64, 64);
            txtNombreProveedor.Location = new Point(254, 168);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(222, 18);
            txtNombreProveedor.TabIndex = 41;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Location = new Point(254, 166);
            label7.Name = "label7";
            label7.Size = new Size(222, 22);
            label7.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(254, 150);
            label4.Name = "label4";
            label4.Size = new Size(62, 13);
            label4.TabIndex = 38;
            label4.Text = "Proveedor:";
            // 
            // txtDocProveedor
            // 
            txtDocProveedor.BorderStyle = BorderStyle.None;
            txtDocProveedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocProveedor.ForeColor = Color.FromArgb(64, 64, 64);
            txtDocProveedor.Location = new Point(32, 168);
            txtDocProveedor.Name = "txtDocProveedor";
            txtDocProveedor.Size = new Size(176, 18);
            txtDocProveedor.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(35, 150);
            label8.Name = "label8";
            label8.Size = new Size(91, 13);
            label8.TabIndex = 37;
            label8.Text = "No. Documento:";
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Location = new Point(32, 166);
            label10.Name = "label10";
            label10.Size = new Size(176, 22);
            label10.TabIndex = 40;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Red;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 16;
            iconButton1.Location = new Point(589, 385);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(118, 22);
            iconButton1.TabIndex = 35;
            iconButton1.Text = "Descargar PDF";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // txtMonto
            // 
            txtMonto.BorderStyle = BorderStyle.None;
            txtMonto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonto.ForeColor = Color.FromArgb(64, 64, 64);
            txtMonto.Location = new Point(90, 387);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(79, 18);
            txtMonto.TabIndex = 33;
            txtMonto.Text = "0";
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Location = new Point(90, 385);
            label11.Name = "label11";
            label11.Size = new Size(79, 22);
            label11.TabIndex = 34;
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.AutoSize = true;
            txtMontoTotal.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMontoTotal.ForeColor = Color.White;
            txtMontoTotal.Location = new Point(16, 389);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(72, 13);
            txtMontoTotal.TabIndex = 32;
            txtMontoTotal.Text = "Monto total:";
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
            dataGridViewCellStyle1.SelectionBackColor = Color.HotPink;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Producto, PrecioCompra, PrecioVenta, Cantidad, SubTotal });
            dgvdata.EnableHeadersVisualStyles = false;
            dgvdata.GridColor = Color.White;
            dgvdata.Location = new Point(19, 210);
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(688, 164);
            dgvdata.TabIndex = 15;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 160;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 119;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 119;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 90;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 158;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.PaleVioletRed;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 16;
            btnBuscar.Location = new Point(636, 14);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(36, 24);
            btnBuscar.TabIndex = 12;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiarBuscador
            // 
            btnLimpiarBuscador.BackColor = Color.PaleVioletRed;
            btnLimpiarBuscador.FlatAppearance.BorderSize = 0;
            btnLimpiarBuscador.FlatStyle = FlatStyle.Flat;
            btnLimpiarBuscador.ForeColor = Color.White;
            btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnLimpiarBuscador.IconColor = Color.White;
            btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarBuscador.IconSize = 16;
            btnLimpiarBuscador.Location = new Point(671, 14);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new Size(36, 24);
            btnLimpiarBuscador.TabIndex = 11;
            btnLimpiarBuscador.UseVisualStyleBackColor = false;
            btnLimpiarBuscador.Click += btnLimpiarBuscador_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.BorderStyle = BorderStyle.None;
            txtbusqueda.ForeColor = Color.FromArgb(64, 64, 64);
            txtbusqueda.Location = new Point(469, 19);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(161, 16);
            txtbusqueda.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.PaleVioletRed;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(343, 19);
            label9.Name = "label9";
            label9.Size = new Size(120, 15);
            label9.TabIndex = 8;
            label9.Text = "Numero Documento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleVioletRed;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 17);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 7;
            label1.Text = "DETALLE COMPRA";
            // 
            // label13
            // 
            label13.BackColor = Color.White;
            label13.Location = new Point(469, 16);
            label13.Name = "label13";
            label13.Size = new Size(161, 22);
            label13.TabIndex = 36;
            // 
            // label14
            // 
            label14.BackColor = Color.PaleVioletRed;
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(731, 52);
            label14.TabIndex = 53;
            label14.Click += label14_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 64);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(849, 450);
            panel2.TabIndex = 1;
            // 
            // frmDetallesCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmDetallesCompras";
            Text = "frmDetallesCompras";
            Load += frmDetallesCompras_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private ComboBox cbobusqueda;
        private TextBox txtbusqueda;
        private Label label9;
        private Label label1;

        public TextBox txtTipoDocumento { get; private set; }

        private TextBox textBox1;
        private DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txtMonto;
        private Label label11;
        private Label txtMontoTotal;
        private Label label13;
        private Panel panel2;
        private TextBox txtDocumento;
        private TextBox txtUsuario;
        private Label label5;
        private Label label6;
        private Label lble;
        private Label label2;
        private TextBox txtFecha;
        private Label label3;
        private Label label12;
        private TextBox txtNumeroDocumento;
        private TextBox txtNombreProveedor;
        private Label label7;
        private Label label4;
        private TextBox txtDocProveedor;
        private Label label8;
        private Label label10;
        private Label label14;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
    }
}