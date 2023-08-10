namespace CapaPresentacion
{
    partial class frmCotizacion
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
            dgvdata = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            btnEliminar = new DataGridViewButtonColumn();
            txtDescuentos = new TextBox();
            label8 = new Label();
            txtTotalPagar = new TextBox();
            btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            label19 = new Label();
            panel1 = new Panel();
            txtCategoria = new TextBox();
            txtFecha = new TextBox();
            btnExportarPDF = new FontAwesome.Sharp.IconButton();
            txtProd = new TextBox();
            txtCantidad = new NumericUpDown();
            txtStock = new TextBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label26 = new Label();
            txtPrecio = new TextBox();
            txtCodigoProd = new Label();
            label23 = new Label();
            label27 = new Label();
            label24 = new Label();
            txtIdProducto = new TextBox();
            txtCodigoProducto = new TextBox();
            txtProducto = new TextBox();
            btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            label25 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, Precio, Cantidad, SubTotal, Descuento, Categoria, btnEliminar });
            dgvdata.EnableHeadersVisualStyles = false;
            dgvdata.Location = new Point(8, 82);
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(697, 307);
            dgvdata.TabIndex = 55;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            dgvdata.Click += dgvdata_Click;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Visible = false;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 200;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Visible = false;
            Precio.Width = 120;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 145;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 160;
            // 
            // Descuento
            // 
            Descuento.HeaderText = "Descuento";
            Descuento.Name = "Descuento";
            Descuento.ReadOnly = true;
            Descuento.Width = 121;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Visible = false;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            btnEliminar.Width = 30;
            // 
            // txtDescuentos
            // 
            txtDescuentos.BorderStyle = BorderStyle.None;
            txtDescuentos.Enabled = false;
            txtDescuentos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescuentos.Location = new Point(711, 276);
            txtDescuentos.Name = "txtDescuentos";
            txtDescuentos.Size = new Size(112, 18);
            txtDescuentos.TabIndex = 57;
            txtDescuentos.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(711, 260);
            label8.Name = "label8";
            label8.Size = new Size(65, 13);
            label8.TabIndex = 56;
            label8.Text = "Descuento:";
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.BorderStyle = BorderStyle.None;
            txtTotalPagar.Enabled = false;
            txtTotalPagar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalPagar.Location = new Point(711, 322);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.Size = new Size(112, 18);
            txtTotalPagar.TabIndex = 53;
            txtTotalPagar.Text = "0";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.Green;
            btnAgregarProducto.FlatAppearance.BorderSize = 0;
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnAgregarProducto.IconColor = Color.White;
            btnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarProducto.Location = new Point(712, 8);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(111, 72);
            btnAgregarProducto.TabIndex = 51;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(711, 306);
            label19.Name = "label19";
            label19.Size = new Size(77, 13);
            label19.TabIndex = 52;
            label19.Text = "Total a pagar:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(txtCategoria);
            panel1.Controls.Add(txtFecha);
            panel1.Controls.Add(btnExportarPDF);
            panel1.Controls.Add(dgvdata);
            panel1.Controls.Add(txtProd);
            panel1.Controls.Add(txtTotalPagar);
            panel1.Controls.Add(txtDescuentos);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtStock);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(label26);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(txtCodigoProd);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(label27);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(txtIdProducto);
            panel1.Controls.Add(txtCodigoProducto);
            panel1.Controls.Add(txtProducto);
            panel1.Controls.Add(btnBuscarProducto);
            panel1.Controls.Add(label25);
            panel1.Controls.Add(btnAgregarProducto);
            panel1.Location = new Point(18, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 404);
            panel1.TabIndex = 58;
            // 
            // txtCategoria
            // 
            txtCategoria.BorderStyle = BorderStyle.None;
            txtCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoria.Location = new Point(722, 149);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(87, 18);
            txtCategoria.TabIndex = 71;
            txtCategoria.Visible = false;
            // 
            // txtFecha
            // 
            txtFecha.BorderStyle = BorderStyle.None;
            txtFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFecha.Location = new Point(722, 125);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(89, 18);
            txtFecha.TabIndex = 70;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.BackColor = Color.Red;
            btnExportarPDF.FlatAppearance.BorderSize = 0;
            btnExportarPDF.FlatStyle = FlatStyle.Flat;
            btnExportarPDF.ForeColor = Color.White;
            btnExportarPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnExportarPDF.IconColor = Color.White;
            btnExportarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportarPDF.IconSize = 16;
            btnExportarPDF.Location = new Point(710, 359);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(113, 30);
            btnExportarPDF.TabIndex = 69;
            btnExportarPDF.Text = "Descargar PDF";
            btnExportarPDF.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportarPDF.UseVisualStyleBackColor = false;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // txtProd
            // 
            txtProd.BorderStyle = BorderStyle.None;
            txtProd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtProd.Location = new Point(13, 39);
            txtProd.Name = "txtProd";
            txtProd.Size = new Size(160, 18);
            txtProd.TabIndex = 68;
            txtProd.TextChanged += txtProd_TextChanged;
            txtProd.KeyDown += txtProd_KeyDown_1;
            // 
            // txtCantidad
            // 
            txtCantidad.BorderStyle = BorderStyle.None;
            txtCantidad.Location = new Point(599, 38);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(91, 19);
            txtCantidad.TabIndex = 67;
            txtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.None;
            txtStock.Enabled = false;
            txtStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(501, 38);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(87, 18);
            txtStock.TabIndex = 65;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(599, 20);
            label20.Name = "label20";
            label20.Size = new Size(57, 13);
            label20.TabIndex = 59;
            label20.Text = "Cantidad:";
            // 
            // label21
            // 
            label21.BackColor = Color.White;
            label21.Location = new Point(501, 36);
            label21.Name = "label21";
            label21.Size = new Size(87, 22);
            label21.TabIndex = 66;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.White;
            label22.Location = new Point(501, 20);
            label22.Name = "label22";
            label22.Size = new Size(38, 13);
            label22.TabIndex = 64;
            label22.Text = "Stock:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label26.ForeColor = Color.White;
            label26.Location = new Point(221, 21);
            label26.Name = "label26";
            label26.Size = new Size(57, 13);
            label26.TabIndex = 55;
            label26.Text = "Producto:";
            // 
            // txtPrecio
            // 
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Enabled = false;
            txtPrecio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(404, 38);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(89, 18);
            txtPrecio.TabIndex = 62;
            // 
            // txtCodigoProd
            // 
            txtCodigoProd.BackColor = Color.White;
            txtCodigoProd.Location = new Point(13, 37);
            txtCodigoProd.Name = "txtCodigoProd";
            txtCodigoProd.Size = new Size(160, 22);
            txtCodigoProd.TabIndex = 56;
            // 
            // label23
            // 
            label23.BackColor = Color.White;
            label23.Location = new Point(404, 36);
            label23.Name = "label23";
            label23.Size = new Size(89, 22);
            label23.TabIndex = 63;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label27.ForeColor = Color.White;
            label27.Location = new Point(16, 21);
            label27.Name = "label27";
            label27.Size = new Size(114, 13);
            label27.TabIndex = 53;
            label27.Text = "Codigo de Producto:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = Color.White;
            label24.Location = new Point(404, 20);
            label24.Name = "label24";
            label24.Size = new Size(41, 13);
            label24.TabIndex = 61;
            label24.Text = "Precio:";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(179, 11);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(34, 23);
            txtIdProducto.TabIndex = 60;
            txtIdProducto.Visible = false;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.BorderStyle = BorderStyle.None;
            txtCodigoProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigoProducto.Location = new Point(13, 39);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(160, 18);
            txtCodigoProducto.TabIndex = 54;
            // 
            // txtProducto
            // 
            txtProducto.BorderStyle = BorderStyle.None;
            txtProducto.Enabled = false;
            txtProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtProducto.Location = new Point(221, 39);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(172, 18);
            txtProducto.TabIndex = 57;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = Color.Orchid;
            btnBuscarProducto.FlatAppearance.BorderSize = 0;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarProducto.IconColor = Color.White;
            btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarProducto.IconSize = 16;
            btnBuscarProducto.Location = new Point(179, 36);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(36, 24);
            btnBuscarProducto.TabIndex = 52;
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click_1;
            // 
            // label25
            // 
            label25.BackColor = Color.White;
            label25.Location = new Point(221, 37);
            label25.Name = "label25";
            label25.Size = new Size(172, 22);
            label25.TabIndex = 58;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 64);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(864, 463);
            panel2.TabIndex = 59;
            // 
            // frmCotizacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 463);
            Controls.Add(panel2);
            Name = "frmCotizacion";
            Text = "frmCotizacion";
            Load += frmCotizacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvdata;
        private TextBox txtDescuentos;
        private Label label8;
        private TextBox txtTotalPagar;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private Label label19;
        private Panel panel1;
        private TextBox txtProd;
        private NumericUpDown txtCantidad;
        private TextBox txtStock;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label26;
        private TextBox txtPrecio;
        private Label txtCodigoProd;
        private Label label23;
        private Label label27;
        private Label label24;
        private TextBox txtIdProducto;
        private TextBox txtCodigoProducto;
        private TextBox txtProducto;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private Label label25;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnExportarPDF;
        private TextBox txtFecha;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewButtonColumn btnEliminar;
        private TextBox txtCategoria;
    }
}