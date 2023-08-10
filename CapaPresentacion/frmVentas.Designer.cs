namespace CapaPresentacion
{
    partial class frmVentas
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
            dgvdata = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            btnEliminar = new DataGridViewButtonColumn();
            txtTotalPagar = new TextBox();
            label18 = new Label();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            cboTipoDocumento = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label12 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            txtCambio = new TextBox();
            txtPrecio = new TextBox();
            txtProductos = new TextBox();
            txtFecha = new TextBox();
            txtCodigoProducto = new TextBox();
            label20 = new Label();
            txtCantidad = new NumericUpDown();
            txtProd = new TextBox();
            txtStock = new TextBox();
            label21 = new Label();
            txtCategoria = new TextBox();
            label22 = new Label();
            cboTipoDoc = new ComboBox();
            label23 = new Label();
            label34 = new Label();
            label28 = new Label();
            label24 = new Label();
            label35 = new Label();
            label26 = new Label();
            label25 = new Label();
            txtProducto = new TextBox();
            txtFechaHoy = new TextBox();
            btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            label33 = new Label();
            label8 = new Label();
            label27 = new Label();
            txtDescuentos = new TextBox();
            label9 = new Label();
            txtIdProducto = new TextBox();
            label19 = new Label();
            label5 = new Label();
            txtPagaCon = new TextBox();
            label4 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            groupBox1.SuspendLayout();
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
            dgvdata.Location = new Point(19, 142);
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
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(653, 259);
            dgvdata.TabIndex = 49;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            dgvdata.UserDeletingRow += dgvdata_UserDeletingRow;
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
            Producto.Width = 191;
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
            Cantidad.Width = 121;
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
            btnEliminar.Width = 40;
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.BorderStyle = BorderStyle.None;
            txtTotalPagar.Enabled = false;
            txtTotalPagar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalPagar.Location = new Point(687, 206);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.Size = new Size(111, 18);
            txtTotalPagar.TabIndex = 37;
            txtTotalPagar.Text = "0";
            // 
            // label18
            // 
            label18.BackColor = Color.White;
            label18.Location = new Point(686, 204);
            label18.Name = "label18";
            label18.Size = new Size(112, 22);
            label18.TabIndex = 38;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.MediumVioletRed;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRegistrar.IconColor = Color.Green;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrar.Location = new Point(685, 326);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 35);
            btnRegistrar.TabIndex = 39;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
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
            btnAgregarProducto.Location = new Point(686, 65);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(112, 74);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.FlatStyle = FlatStyle.Flat;
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(148, 46);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(190, 23);
            cboTipoDocumento.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(148, 31);
            label2.Name = "label2";
            label2.Size = new Size(112, 13);
            label2.TabIndex = 28;
            label2.Text = "Tipo de Documento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 31);
            label3.Name = "label3";
            label3.Size = new Size(40, 13);
            label3.TabIndex = 27;
            label3.Text = "Fecha:";
            // 
            // label12
            // 
            label12.BackColor = Color.White;
            label12.Location = new Point(16, 47);
            label12.Name = "label12";
            label12.Size = new Size(111, 22);
            label12.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 11);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 1;
            label1.Text = "REGISTRO DE VENTA";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 463);
            panel1.TabIndex = 50;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 0, 64);
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Fill;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(864, 463);
            panel4.TabIndex = 78;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightPink;
            panel2.Controls.Add(txtCambio);
            panel2.Controls.Add(txtPrecio);
            panel2.Controls.Add(txtProductos);
            panel2.Controls.Add(txtFecha);
            panel2.Controls.Add(txtCodigoProducto);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(txtCantidad);
            panel2.Controls.Add(txtProd);
            panel2.Controls.Add(txtStock);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(dgvdata);
            panel2.Controls.Add(txtCategoria);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(cboTipoDoc);
            panel2.Controls.Add(label23);
            panel2.Controls.Add(label34);
            panel2.Controls.Add(label28);
            panel2.Controls.Add(label24);
            panel2.Controls.Add(label35);
            panel2.Controls.Add(label26);
            panel2.Controls.Add(label25);
            panel2.Controls.Add(txtProducto);
            panel2.Controls.Add(txtFechaHoy);
            panel2.Controls.Add(btnBuscarProducto);
            panel2.Controls.Add(label33);
            panel2.Controls.Add(btnAgregarProducto);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label27);
            panel2.Controls.Add(txtDescuentos);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtIdProducto);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtTotalPagar);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(txtPagaCon);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnRegistrar);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(29, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(810, 412);
            panel2.TabIndex = 0;
            // 
            // txtCambio
            // 
            txtCambio.BorderStyle = BorderStyle.None;
            txtCambio.Enabled = false;
            txtCambio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCambio.Location = new Point(686, 296);
            txtCambio.Name = "txtCambio";
            txtCambio.Size = new Size(112, 18);
            txtCambio.TabIndex = 81;
            // 
            // txtPrecio
            // 
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Enabled = false;
            txtPrecio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(410, 112);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(87, 18);
            txtPrecio.TabIndex = 80;
            // 
            // txtProductos
            // 
            txtProductos.BorderStyle = BorderStyle.None;
            txtProductos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductos.Location = new Point(227, 112);
            txtProductos.Name = "txtProductos";
            txtProductos.Size = new Size(172, 18);
            txtProductos.TabIndex = 79;
            // 
            // txtFecha
            // 
            txtFecha.BorderStyle = BorderStyle.None;
            txtFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFecha.Location = new Point(20, 55);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(224, 18);
            txtFecha.TabIndex = 78;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.BorderStyle = BorderStyle.None;
            txtCodigoProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigoProducto.Location = new Point(19, 112);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(160, 18);
            txtCodigoProducto.TabIndex = 57;
            txtCodigoProducto.TextChanged += txtCodigoProducto_TextChanged;
            txtCodigoProducto.KeyDown += txtCodigoProducto_KeyDown_1;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(605, 92);
            label20.Name = "label20";
            label20.Size = new Size(57, 13);
            label20.TabIndex = 62;
            label20.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.BorderStyle = BorderStyle.None;
            txtCantidad.Location = new Point(605, 109);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(67, 19);
            txtCantidad.TabIndex = 70;
            txtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtProd
            // 
            txtProd.BorderStyle = BorderStyle.None;
            txtProd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtProd.Location = new Point(19, 115);
            txtProd.Name = "txtProd";
            txtProd.Size = new Size(160, 18);
            txtProd.TabIndex = 71;
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.None;
            txtStock.Enabled = false;
            txtStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(507, 111);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(87, 18);
            txtStock.TabIndex = 68;
            // 
            // label21
            // 
            label21.BackColor = Color.White;
            label21.Location = new Point(507, 109);
            label21.Name = "label21";
            label21.Size = new Size(87, 22);
            label21.TabIndex = 69;
            // 
            // txtCategoria
            // 
            txtCategoria.BorderStyle = BorderStyle.None;
            txtCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoria.Location = new Point(571, 53);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(89, 18);
            txtCategoria.TabIndex = 77;
            txtCategoria.Visible = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.White;
            label22.Location = new Point(507, 92);
            label22.Name = "label22";
            label22.Size = new Size(38, 13);
            label22.TabIndex = 67;
            label22.Text = "Stock:";
            // 
            // cboTipoDoc
            // 
            cboTipoDoc.FlatStyle = FlatStyle.Flat;
            cboTipoDoc.FormattingEnabled = true;
            cboTipoDoc.Location = new Point(297, 53);
            cboTipoDoc.Name = "cboTipoDoc";
            cboTipoDoc.Size = new Size(244, 23);
            cboTipoDoc.TabIndex = 76;
            // 
            // label23
            // 
            label23.BackColor = Color.White;
            label23.Location = new Point(410, 109);
            label23.Name = "label23";
            label23.Size = new Size(89, 22);
            label23.TabIndex = 66;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label34.ForeColor = Color.White;
            label34.Location = new Point(22, 38);
            label34.Name = "label34";
            label34.Size = new Size(40, 13);
            label34.TabIndex = 72;
            label34.Text = "Fecha:";
            // 
            // label28
            // 
            label28.BackColor = Color.White;
            label28.Location = new Point(19, 109);
            label28.Name = "label28";
            label28.Size = new Size(160, 22);
            label28.TabIndex = 59;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label24.ForeColor = Color.White;
            label24.Location = new Point(410, 92);
            label24.Name = "label24";
            label24.Size = new Size(41, 13);
            label24.TabIndex = 64;
            label24.Text = "Precio:";
            // 
            // label35
            // 
            label35.BackColor = Color.White;
            label35.Location = new Point(20, 53);
            label35.Name = "label35";
            label35.Size = new Size(224, 22);
            label35.TabIndex = 75;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label26.ForeColor = Color.White;
            label26.Location = new Point(227, 93);
            label26.Name = "label26";
            label26.Size = new Size(57, 13);
            label26.TabIndex = 58;
            label26.Text = "Producto:";
            // 
            // label25
            // 
            label25.BackColor = Color.White;
            label25.Enabled = false;
            label25.Location = new Point(227, 109);
            label25.Name = "label25";
            label25.Size = new Size(172, 22);
            label25.TabIndex = 61;
            // 
            // txtProducto
            // 
            txtProducto.BorderStyle = BorderStyle.None;
            txtProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtProducto.Location = new Point(227, 115);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(172, 18);
            txtProducto.TabIndex = 60;
            // 
            // txtFechaHoy
            // 
            txtFechaHoy.BorderStyle = BorderStyle.None;
            txtFechaHoy.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFechaHoy.Location = new Point(20, 55);
            txtFechaHoy.Name = "txtFechaHoy";
            txtFechaHoy.Size = new Size(224, 18);
            txtFechaHoy.TabIndex = 74;
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
            btnBuscarProducto.Location = new Point(185, 108);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(36, 24);
            btnBuscarProducto.TabIndex = 55;
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click_1;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label33.ForeColor = Color.White;
            label33.Location = new Point(297, 38);
            label33.Name = "label33";
            label33.Size = new Size(112, 13);
            label33.TabIndex = 73;
            label33.Text = "Tipo de Documento:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(688, 142);
            label8.Name = "label8";
            label8.Size = new Size(65, 13);
            label8.TabIndex = 49;
            label8.Text = "Descuento:";
            label8.Click += label8_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label27.ForeColor = Color.White;
            label27.Location = new Point(22, 93);
            label27.Name = "label27";
            label27.Size = new Size(114, 13);
            label27.TabIndex = 56;
            label27.Text = "Codigo de Producto:";
            // 
            // txtDescuentos
            // 
            txtDescuentos.BorderStyle = BorderStyle.None;
            txtDescuentos.Enabled = false;
            txtDescuentos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescuentos.Location = new Point(687, 159);
            txtDescuentos.Name = "txtDescuentos";
            txtDescuentos.Size = new Size(110, 18);
            txtDescuentos.TabIndex = 50;
            txtDescuentos.Text = "0";
            txtDescuentos.TextChanged += txtDescuentos_TextChanged;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Location = new Point(686, 157);
            label9.Name = "label9";
            label9.Size = new Size(112, 22);
            label9.TabIndex = 51;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(179, 83);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(34, 23);
            txtIdProducto.TabIndex = 63;
            txtIdProducto.Visible = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(686, 188);
            label19.Name = "label19";
            label19.Size = new Size(77, 13);
            label19.TabIndex = 36;
            label19.Text = "Total a pagar:";
            label19.Click += label19_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(685, 233);
            label5.Name = "label5";
            label5.Size = new Size(57, 13);
            label5.TabIndex = 43;
            label5.Text = "Paga con:";
            // 
            // txtPagaCon
            // 
            txtPagaCon.BorderStyle = BorderStyle.None;
            txtPagaCon.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPagaCon.Location = new Point(686, 251);
            txtPagaCon.Name = "txtPagaCon";
            txtPagaCon.Size = new Size(112, 18);
            txtPagaCon.TabIndex = 44;
            txtPagaCon.KeyDown += txtPagaCon_KeyDown;
            txtPagaCon.KeyPress += txtPagaCon_KeyPress;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Location = new Point(686, 249);
            label4.Name = "label4";
            label4.Size = new Size(112, 22);
            label4.TabIndex = 45;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Orchid;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Green;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(687, 367);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(112, 33);
            iconButton1.TabIndex = 54;
            iconButton1.Text = "Imprimir Ticket";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(685, 278);
            label7.Name = "label7";
            label7.Size = new Size(49, 13);
            label7.TabIndex = 46;
            label7.Text = "Cambio:";
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Location = new Point(686, 294);
            label6.Name = "label6";
            label6.Size = new Size(112, 22);
            label6.TabIndex = 48;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(cboTipoDocumento);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label12);
            groupBox1.Location = new Point(-14, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 90);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de Compra";
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 463);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "frmVentas";
            Text = "frmVentas";
            Load += frmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvdata;
        private TextBox txtTotalPagar;
        private Label label18;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private ComboBox cboTipoDocumento;
        private Label label2;
        private Label label3;
        private Label label12;
        private Label label1;
        private Panel panel1;
        private Label label19;
        private GroupBox groupBox1;
        private Label label6;
        private Label label7;
        private TextBox txtPagaCon;
        private Label label4;
        private Label label5;
        private Label label8;
        private TextBox txtDescuentos;
        private Label label9;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txtCategoria;
        private ComboBox cboTipoDoc;
        private Label label33;
        private TextBox txtFechaHoy;
        private Label label34;
        private Label label35;
        private TextBox txtProd;
        private NumericUpDown txtCantidad;
        private TextBox txtStock;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label26;
        private Label label28;
        private Label label23;
        private Label label27;
        private Label label24;
        private TextBox txtIdProducto;
        private TextBox txtCodigoProducto;
        private TextBox txtProducto;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private Label label25;
        private Panel panel4;
        private Panel panel2;
        private TextBox txtFecha;
        private TextBox txtProductos;
        private TextBox txtPrecio;
        private TextBox txtCambio;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewButtonColumn btnEliminar;
    }
}