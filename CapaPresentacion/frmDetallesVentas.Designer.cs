namespace CapaPresentacion
{
    partial class frmDetallesVentas
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
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            label1 = new Label();
            label9 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txtMonto = new TextBox();
            label11 = new Label();
            txtMontoTotal = new Label();
            dgvdata = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            txtNumeroDocumento = new TextBox();
            txtDocumento = new TextBox();
            txtUsuario = new TextBox();
            label5 = new Label();
            label6 = new Label();
            lble = new Label();
            label2 = new Label();
            txtFecha = new TextBox();
            label3 = new Label();
            label12 = new Label();
            txtDescuento = new TextBox();
            label13 = new Label();
            label14 = new Label();
            txtMontoCambio = new TextBox();
            label8 = new Label();
            label10 = new Label();
            txtMontoPago = new TextBox();
            label4 = new Label();
            label7 = new Label();
            label16 = new Label();
            label15 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            btnBuscar.Location = new Point(634, 14);
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
            txtbusqueda.Location = new Point(469, 18);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(161, 16);
            txtbusqueda.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleVioletRed;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 7;
            label1.Text = "DETALLE VENTA";
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
            iconButton1.Location = new Point(589, 381);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(118, 26);
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
            txtMonto.Location = new Point(89, 386);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(57, 18);
            txtMonto.TabIndex = 33;
            txtMonto.Text = "0";
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Location = new Point(89, 384);
            label11.Name = "label11";
            label11.Size = new Size(57, 22);
            label11.TabIndex = 34;
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.AutoSize = true;
            txtMontoTotal.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMontoTotal.ForeColor = Color.White;
            txtMontoTotal.Location = new Point(16, 388);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(73, 13);
            txtMontoTotal.TabIndex = 32;
            txtMontoTotal.Text = "Monto Total:";
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Cantidad, SubTotal, Descuento });
            dgvdata.EnableHeadersVisualStyles = false;
            dgvdata.Location = new Point(19, 129);
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Pink;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightPink;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(688, 240);
            dgvdata.TabIndex = 15;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 140;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 130;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 114;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 130;
            // 
            // Descuento
            // 
            Descuento.HeaderText = "Descuento";
            Descuento.Name = "Descuento";
            Descuento.ReadOnly = true;
            Descuento.Width = 130;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(txtNumeroDocumento);
            panel1.Controls.Add(txtDocumento);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lble);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtFecha);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtDescuento);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(txtMontoCambio);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtMontoPago);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
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
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(59, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 417);
            panel1.TabIndex = 1;
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(651, 84);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(41, 23);
            txtNumeroDocumento.TabIndex = 60;
            txtNumeroDocumento.Visible = false;
            // 
            // txtDocumento
            // 
            txtDocumento.BorderStyle = BorderStyle.None;
            txtDocumento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumento.ForeColor = Color.FromArgb(64, 64, 64);
            txtDocumento.Location = new Point(185, 88);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(205, 18);
            txtDocumento.TabIndex = 64;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            txtUsuario.Location = new Point(424, 89);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(205, 18);
            txtUsuario.TabIndex = 62;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Location = new Point(424, 87);
            label5.Name = "label5";
            label5.Size = new Size(205, 22);
            label5.TabIndex = 63;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(423, 71);
            label6.Name = "label6";
            label6.Size = new Size(50, 13);
            label6.TabIndex = 61;
            label6.Text = "Usuario:";
            // 
            // lble
            // 
            lble.BackColor = Color.White;
            lble.Location = new Point(185, 87);
            lble.Name = "lble";
            lble.Size = new Size(205, 22);
            lble.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(184, 71);
            label2.Name = "label2";
            label2.Size = new Size(112, 13);
            label2.TabIndex = 56;
            label2.Text = "Tipo de Documento:";
            // 
            // txtFecha
            // 
            txtFecha.BorderStyle = BorderStyle.None;
            txtFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFecha.ForeColor = Color.FromArgb(64, 64, 64);
            txtFecha.Location = new Point(26, 89);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(111, 18);
            txtFecha.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 71);
            label3.Name = "label3";
            label3.Size = new Size(40, 13);
            label3.TabIndex = 55;
            label3.Text = "Fecha:";
            // 
            // label12
            // 
            label12.BackColor = Color.White;
            label12.Location = new Point(26, 87);
            label12.Name = "label12";
            label12.Size = new Size(111, 22);
            label12.TabIndex = 58;
            // 
            // txtDescuento
            // 
            txtDescuento.BorderStyle = BorderStyle.None;
            txtDescuento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescuento.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescuento.Location = new Point(216, 387);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(54, 18);
            txtDescuento.TabIndex = 43;
            txtDescuento.Text = "0";
            // 
            // label13
            // 
            label13.BackColor = Color.White;
            label13.Location = new Point(216, 385);
            label13.Name = "label13";
            label13.Size = new Size(54, 22);
            label13.TabIndex = 44;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(153, 389);
            label14.Name = "label14";
            label14.Size = new Size(65, 13);
            label14.TabIndex = 42;
            label14.Text = "Descuento:";
            // 
            // txtMontoCambio
            // 
            txtMontoCambio.BorderStyle = BorderStyle.None;
            txtMontoCambio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtMontoCambio.ForeColor = Color.FromArgb(64, 64, 64);
            txtMontoCambio.Location = new Point(498, 386);
            txtMontoCambio.Name = "txtMontoCambio";
            txtMontoCambio.Size = new Size(58, 18);
            txtMontoCambio.TabIndex = 40;
            txtMontoCambio.Text = "0";
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Location = new Point(498, 384);
            label8.Name = "label8";
            label8.Size = new Size(58, 22);
            label8.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(413, 388);
            label10.Name = "label10";
            label10.Size = new Size(87, 13);
            label10.TabIndex = 39;
            label10.Text = "Monto Cambio:";
            // 
            // txtMontoPago
            // 
            txtMontoPago.BorderStyle = BorderStyle.None;
            txtMontoPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtMontoPago.ForeColor = Color.FromArgb(64, 64, 64);
            txtMontoPago.Location = new Point(350, 387);
            txtMontoPago.Name = "txtMontoPago";
            txtMontoPago.Size = new Size(54, 18);
            txtMontoPago.TabIndex = 37;
            txtMontoPago.Text = "0";
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Location = new Point(350, 385);
            label4.Name = "label4";
            label4.Size = new Size(54, 22);
            label4.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(276, 389);
            label7.Name = "label7";
            label7.Size = new Size(74, 13);
            label7.TabIndex = 36;
            label7.Text = "Monto Pago:";
            // 
            // label16
            // 
            label16.BackColor = Color.White;
            label16.Location = new Point(469, 15);
            label16.Name = "label16";
            label16.Size = new Size(161, 22);
            label16.TabIndex = 65;
            // 
            // label15
            // 
            label15.BackColor = Color.PaleVioletRed;
            label15.Location = new Point(0, 0);
            label15.Name = "label15";
            label15.Size = new Size(731, 52);
            label15.TabIndex = 54;
            label15.Click += label15_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 64);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(849, 450);
            panel2.TabIndex = 2;
            // 
            // frmDetallesVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmDetallesVentas";
            Text = "frmDetallesVentas";
            Load += frmDetallesVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private TextBox txtbusqueda;
        private Label label1;
        private Label label9;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txtMonto;
        private Label label11;
        private Label txtMontoTotal;
        private DataGridView dgvdata;
        private Panel panel1;
        private TextBox txtMontoCambio;
        private Label label8;
        private Label label10;
        private TextBox txtMontoPago;
        private Label label4;
        private Label label7;
        private TextBox txtDescuento;
        private Label label13;
        private Label label14;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn Descuento;
        private Panel panel2;
        private TextBox txtNumeroDocumento;
        private TextBox txtDocumento;
        private TextBox txtUsuario;
        private Label label5;
        private Label label6;
        private Label lble;
        private Label label2;
        private TextBox txtFecha;
        private Label label3;
        private Label label12;
        private Label label15;
        private Label label16;
    }
}