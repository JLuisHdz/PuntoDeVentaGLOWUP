namespace CapaPresentacion
{
    partial class frmCompra
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
            label1 = new Label();
            dgvdata = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btnEliminar = new DataGridViewButtonColumn();
            btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            txtTotalPagar = new TextBox();
            label18 = new Label();
            label19 = new Label();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            txtCodigoProd = new TextBox();
            txtProveedor = new TextBox();
            label3 = new Label();
            txtFecha = new TextBox();
            label12 = new Label();
            label2 = new Label();
            cboTipoDocumento = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label14 = new Label();
            label16 = new Label();
            label5 = new Label();
            txtDocProveedor = new TextBox();
            label6 = new Label();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtIdProveedor = new TextBox();
            label7 = new Label();
            txtNombreProveedor = new TextBox();
            label17 = new Label();
            txtCantidad = new NumericUpDown();
            label4 = new Label();
            txtPrecioVenta = new TextBox();
            label15 = new Label();
            txtPrecioCompra = new TextBox();
            label13 = new Label();
            txtProducto = new TextBox();
            label8 = new Label();
            txtIdProducto = new TextBox();
            btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            txtCodProducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 10);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 1;
            label1.Text = "REGISTRO DE COMPRA";
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, PrecioCompra, PrecioVenta, Cantidad, SubTotal, btnEliminar });
            dgvdata.EnableHeadersVisualStyles = false;
            dgvdata.Location = new Point(19, 176);
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Pink;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightPink;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(643, 224);
            dgvdata.TabIndex = 4;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
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
            Producto.Width = 141;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 115;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 115;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 80;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.Width = 121;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            btnEliminar.Width = 30;
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
            btnAgregarProducto.Location = new Point(670, 176);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(112, 80);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.BorderStyle = BorderStyle.None;
            txtTotalPagar.Enabled = false;
            txtTotalPagar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalPagar.Location = new Point(670, 326);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.Size = new Size(112, 18);
            txtTotalPagar.TabIndex = 37;
            txtTotalPagar.Text = "0";
            txtTotalPagar.TextChanged += txtTotalPagar_TextChanged;
            // 
            // label18
            // 
            label18.BackColor = Color.White;
            label18.Location = new Point(670, 324);
            label18.Name = "label18";
            label18.Size = new Size(112, 22);
            label18.TabIndex = 38;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(672, 308);
            label19.Name = "label19";
            label19.Size = new Size(77, 13);
            label19.TabIndex = 36;
            label19.Text = "Total a pagar:";
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
            btnRegistrar.Location = new Point(667, 359);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(115, 41);
            btnRegistrar.TabIndex = 39;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 481);
            panel1.TabIndex = 40;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 0, 64);
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(865, 481);
            panel4.TabIndex = 61;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightPink;
            panel2.Controls.Add(txtCodigoProd);
            panel2.Controls.Add(txtProveedor);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtFecha);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cboTipoDocumento);
            panel2.Controls.Add(dgvdata);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtDocProveedor);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(txtIdProveedor);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtNombreProveedor);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(txtCantidad);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtPrecioVenta);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(txtPrecioCompra);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(txtProducto);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnRegistrar);
            panel2.Controls.Add(txtTotalPagar);
            panel2.Controls.Add(txtIdProducto);
            panel2.Controls.Add(btnBuscarProducto);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtCodProducto);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(btnAgregarProducto);
            panel2.Controls.Add(label18);
            panel2.Location = new Point(35, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(790, 407);
            panel2.TabIndex = 0;
            // 
            // txtCodigoProd
            // 
            txtCodigoProd.BorderStyle = BorderStyle.None;
            txtCodigoProd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigoProd.Location = new Point(16, 132);
            txtCodigoProd.Name = "txtCodigoProd";
            txtCodigoProd.Size = new Size(161, 18);
            txtCodigoProd.TabIndex = 62;
            txtCodigoProd.TextChanged += txtCodigoProd_TextChanged;
            txtCodigoProd.KeyDown += txtCodigoProd_KeyDown;
            // 
            // txtProveedor
            // 
            txtProveedor.BorderStyle = BorderStyle.None;
            txtProveedor.Enabled = false;
            txtProveedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedor.Location = new Point(591, 58);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(188, 18);
            txtProveedor.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 41);
            label3.Name = "label3";
            label3.Size = new Size(40, 13);
            label3.TabIndex = 56;
            label3.Text = "Fecha:";
            // 
            // txtFecha
            // 
            txtFecha.BorderStyle = BorderStyle.None;
            txtFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFecha.Location = new Point(16, 60);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(111, 18);
            txtFecha.TabIndex = 58;
            // 
            // label12
            // 
            label12.BackColor = Color.White;
            label12.Location = new Point(16, 57);
            label12.Name = "label12";
            label12.Size = new Size(111, 22);
            label12.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(148, 41);
            label2.Name = "label2";
            label2.Size = new Size(112, 13);
            label2.TabIndex = 57;
            label2.Text = "Tipo de Documento:";
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.FlatStyle = FlatStyle.Flat;
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(148, 56);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(163, 23);
            cboTipoDocumento.TabIndex = 60;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(20, 114);
            label10.Name = "label10";
            label10.Size = new Size(114, 13);
            label10.TabIndex = 41;
            label10.Text = "Codigo de Producto:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(225, 114);
            label9.Name = "label9";
            label9.Size = new Size(57, 13);
            label9.TabIndex = 42;
            label9.Text = "Producto:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(467, 113);
            label14.Name = "label14";
            label14.Size = new Size(84, 13);
            label14.TabIndex = 49;
            label14.Text = "Precio Compra:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(569, 114);
            label16.Name = "label16";
            label16.Size = new Size(73, 13);
            label16.TabIndex = 52;
            label16.Text = "Precio Venta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(368, 39);
            label5.Name = "label5";
            label5.Size = new Size(91, 13);
            label5.TabIndex = 42;
            label5.Text = "No. Documento:";
            // 
            // txtDocProveedor
            // 
            txtDocProveedor.BorderStyle = BorderStyle.None;
            txtDocProveedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocProveedor.Location = new Point(368, 58);
            txtDocProveedor.Name = "txtDocProveedor";
            txtDocProveedor.Size = new Size(173, 18);
            txtDocProveedor.TabIndex = 44;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Location = new Point(368, 56);
            label6.Name = "label6";
            label6.Size = new Size(173, 22);
            label6.TabIndex = 45;
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
            btnBuscar.Location = new Point(546, 55);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(36, 24);
            btnBuscar.TabIndex = 41;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.Location = new Point(695, 29);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(34, 23);
            txtIdProveedor.TabIndex = 48;
            txtIdProveedor.Visible = false;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Location = new Point(591, 56);
            label7.Name = "label7";
            label7.Size = new Size(188, 22);
            label7.TabIndex = 47;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.BorderStyle = BorderStyle.None;
            txtNombreProveedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreProveedor.Location = new Point(591, 58);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(188, 18);
            txtNombreProveedor.TabIndex = 46;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(669, 113);
            label17.Name = "label17";
            label17.Size = new Size(57, 13);
            label17.TabIndex = 46;
            label17.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.BorderStyle = BorderStyle.None;
            txtCantidad.Location = new Point(669, 132);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(57, 19);
            txtCantidad.TabIndex = 55;
            txtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(591, 39);
            label4.Name = "label4";
            label4.Size = new Size(62, 13);
            label4.TabIndex = 43;
            label4.Text = "Proveedor:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.BorderStyle = BorderStyle.None;
            txtPrecioVenta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioVenta.Location = new Point(567, 132);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(92, 18);
            txtPrecioVenta.TabIndex = 53;
            // 
            // label15
            // 
            label15.BackColor = Color.White;
            label15.Location = new Point(567, 130);
            label15.Name = "label15";
            label15.Size = new Size(92, 22);
            label15.TabIndex = 54;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.BorderStyle = BorderStyle.None;
            txtPrecioCompra.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioCompra.Location = new Point(467, 131);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(92, 18);
            txtPrecioCompra.TabIndex = 50;
            // 
            // label13
            // 
            label13.BackColor = Color.White;
            label13.Location = new Point(467, 129);
            label13.Name = "label13";
            label13.Size = new Size(92, 22);
            label13.TabIndex = 51;
            // 
            // txtProducto
            // 
            txtProducto.BorderStyle = BorderStyle.None;
            txtProducto.Enabled = false;
            txtProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtProducto.Location = new Point(225, 132);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(154, 18);
            txtProducto.TabIndex = 45;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Location = new Point(225, 130);
            label8.Name = "label8";
            label8.Size = new Size(154, 22);
            label8.TabIndex = 47;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(143, 103);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(34, 23);
            txtIdProducto.TabIndex = 48;
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
            btnBuscarProducto.Location = new Point(183, 130);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(36, 24);
            btnBuscarProducto.TabIndex = 40;
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click_1;
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Location = new Point(17, 130);
            label11.Name = "label11";
            label11.Size = new Size(160, 22);
            label11.TabIndex = 44;
            // 
            // txtCodProducto
            // 
            txtCodProducto.BorderStyle = BorderStyle.None;
            txtCodProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodProducto.Location = new Point(17, 132);
            txtCodProducto.Name = "txtCodProducto";
            txtCodProducto.Size = new Size(160, 18);
            txtCodProducto.TabIndex = 43;
            // 
            // frmCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 481);
            Controls.Add(panel1);
            Name = "frmCompra";
            Text = "frmCompra";
            Load += frmCompra_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private TextBox txtTotalPagar;
        private Label label18;
        private Label label19;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private Panel panel1;
        private ComboBox cboTipoDocumento;
        private Label label2;
        private TextBox txtFecha;
        private Label label3;
        private Label label12;
        private TextBox txtIdProveedor;
        private NumericUpDown txtCantidad;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtPrecioVenta;
        private TextBox txtNombreProveedor;
        private Label label17;
        private Label label7;
        private Label label15;
        private Label label4;
        private Label label16;
        private TextBox txtDocProveedor;
        private TextBox txtPrecioCompra;
        private Label label5;
        private Label label6;
        private Label label13;
        private Label label14;
        private TextBox txtIdProducto;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private TextBox txtProducto;
        private Label label8;
        private Label label9;
        private TextBox txtCodProducto;
        private Label label10;
        private Label label11;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewButtonColumn btnEliminar;
        private Panel panel4;
        private Panel panel2;
        private TextBox txtCodigoProd;
        private TextBox txtProveedor;
    }
}