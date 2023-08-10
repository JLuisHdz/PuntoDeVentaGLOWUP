namespace CapaPresentacion
{
    partial class FrmImpresion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImpresion));
            panel1 = new Panel();
            btnSubir = new FontAwesome.Sharp.IconButton();
            txtFecha = new TextBox();
            dgvdata = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            btnEliminar = new DataGridViewButtonColumn();
            txtDescuentosImprimir = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtCambioImprimir = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtPagaConImprimir = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtTotalPagarImprimir = new TextBox();
            label18 = new Label();
            label19 = new Label();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            btnImprimir = new FontAwesome.Sharp.IconButton();
            pictureBoxLogo = new PictureBox();
            cboImpresoras = new ComboBox();
            label1 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(btnSubir);
            panel1.Controls.Add(txtFecha);
            panel1.Controls.Add(dgvdata);
            panel1.Controls.Add(txtDescuentosImprimir);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtCambioImprimir);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtPagaConImprimir);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtTotalPagarImprimir);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnImprimir);
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Controls.Add(cboImpresoras);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.FromArgb(64, 64, 64);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(693, 393);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // btnSubir
            // 
            btnSubir.BackColor = Color.Magenta;
            btnSubir.FlatAppearance.BorderColor = Color.Black;
            btnSubir.FlatAppearance.BorderSize = 0;
            btnSubir.FlatStyle = FlatStyle.Flat;
            btnSubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            btnSubir.IconColor = Color.White;
            btnSubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSubir.IconSize = 16;
            btnSubir.Location = new Point(527, 79);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(144, 24);
            btnSubir.TabIndex = 66;
            btnSubir.UseVisualStyleBackColor = false;
            btnSubir.Click += btnSubir_Click;
            // 
            // txtFecha
            // 
            txtFecha.BorderStyle = BorderStyle.None;
            txtFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFecha.Location = new Point(417, 26);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(102, 18);
            txtFecha.TabIndex = 65;
            txtFecha.Visible = false;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.PaleVioletRed;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DeepPink;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, Precio, Cantidad, SubTotal, Descuento, btnEliminar });
            dgvdata.EnableHeadersVisualStyles = false;
            dgvdata.Location = new Point(12, 76);
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Pink;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightPink;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(491, 305);
            dgvdata.TabIndex = 64;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // Descuento
            // 
            Descuento.HeaderText = "Descuento";
            Descuento.Name = "Descuento";
            Descuento.ReadOnly = true;
            Descuento.Visible = false;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            btnEliminar.Visible = false;
            // 
            // txtDescuentosImprimir
            // 
            txtDescuentosImprimir.BorderStyle = BorderStyle.None;
            txtDescuentosImprimir.Enabled = false;
            txtDescuentosImprimir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescuentosImprimir.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescuentosImprimir.Location = new Point(527, 134);
            txtDescuentosImprimir.Name = "txtDescuentosImprimir";
            txtDescuentosImprimir.Size = new Size(145, 18);
            txtDescuentosImprimir.TabIndex = 62;
            txtDescuentosImprimir.Text = "0";
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Location = new Point(527, 133);
            label9.Name = "label9";
            label9.Size = new Size(145, 22);
            label9.TabIndex = 63;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(526, 118);
            label8.Name = "label8";
            label8.Size = new Size(65, 13);
            label8.TabIndex = 61;
            label8.Text = "Descuento:";
            // 
            // txtCambioImprimir
            // 
            txtCambioImprimir.BorderStyle = BorderStyle.None;
            txtCambioImprimir.Enabled = false;
            txtCambioImprimir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCambioImprimir.ForeColor = Color.FromArgb(64, 64, 64);
            txtCambioImprimir.Location = new Point(526, 271);
            txtCambioImprimir.Name = "txtCambioImprimir";
            txtCambioImprimir.Size = new Size(145, 18);
            txtCambioImprimir.TabIndex = 59;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Location = new Point(526, 270);
            label6.Name = "label6";
            label6.Size = new Size(145, 22);
            label6.TabIndex = 60;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(526, 255);
            label7.Name = "label7";
            label7.Size = new Size(49, 13);
            label7.TabIndex = 58;
            label7.Text = "Cambio:";
            // 
            // txtPagaConImprimir
            // 
            txtPagaConImprimir.BorderStyle = BorderStyle.None;
            txtPagaConImprimir.Enabled = false;
            txtPagaConImprimir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPagaConImprimir.ForeColor = Color.FromArgb(64, 64, 64);
            txtPagaConImprimir.Location = new Point(526, 225);
            txtPagaConImprimir.Name = "txtPagaConImprimir";
            txtPagaConImprimir.Size = new Size(145, 18);
            txtPagaConImprimir.TabIndex = 56;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Location = new Point(526, 224);
            label4.Name = "label4";
            label4.Size = new Size(145, 22);
            label4.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(526, 209);
            label5.Name = "label5";
            label5.Size = new Size(57, 13);
            label5.TabIndex = 55;
            label5.Text = "Paga con:";
            // 
            // txtTotalPagarImprimir
            // 
            txtTotalPagarImprimir.BorderStyle = BorderStyle.None;
            txtTotalPagarImprimir.Enabled = false;
            txtTotalPagarImprimir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalPagarImprimir.ForeColor = Color.FromArgb(64, 64, 64);
            txtTotalPagarImprimir.Location = new Point(526, 180);
            txtTotalPagarImprimir.Name = "txtTotalPagarImprimir";
            txtTotalPagarImprimir.Size = new Size(145, 18);
            txtTotalPagarImprimir.TabIndex = 53;
            txtTotalPagarImprimir.Text = "0";
            // 
            // label18
            // 
            label18.BackColor = Color.White;
            label18.Location = new Point(526, 179);
            label18.Name = "label18";
            label18.Size = new Size(145, 22);
            label18.TabIndex = 54;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(526, 163);
            label19.Name = "label19";
            label19.Size = new Size(77, 13);
            label19.TabIndex = 52;
            label19.Text = "Total a pagar:";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Orchid;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCerrar.IconColor = Color.Black;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.Location = new Point(525, 354);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(155, 27);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.MediumVioletRed;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.ForeColor = Color.White;
            btnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            btnImprimir.IconColor = Color.Black;
            btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImprimir.Location = new Point(525, 306);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(155, 44);
            btnImprimir.TabIndex = 6;
            btnImprimir.Text = "Imprimir Ticket";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(527, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(144, 67);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // cboImpresoras
            // 
            cboImpresoras.FlatStyle = FlatStyle.Flat;
            cboImpresoras.FormattingEnabled = true;
            cboImpresoras.Location = new Point(167, 26);
            cboImpresoras.Name = "cboImpresoras";
            cboImpresoras.Size = new Size(230, 23);
            cboImpresoras.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 29);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "Selecciona impresora:";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += ImprimirPagina;
            // 
            // FrmImpresion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 393);
            Controls.Add(panel1);
            Name = "FrmImpresion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmImpresion";
            Load += FrmImpresion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxLogo;
        private ComboBox cboImpresoras;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
        private Label label18;
        private Label label19;
        public TextBox txtDescuentosImprimir;
        public TextBox txtCambioImprimir;
        public TextBox txtPagaConImprimir;
        public TextBox txtTotalPagarImprimir;
        public DataGridView dgvdata;
        private System.Drawing.Printing.PrintDocument printDocument1;
        public TextBox txtFecha;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewButtonColumn btnEliminar;
        private FontAwesome.Sharp.IconButton btnSubir;
    }
}