namespace CapaPresentacion
{
    partial class frmReporteCompra
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
            panel3 = new Panel();
            txtFecha = new TextBox();
            cboProveedor = new ComboBox();
            label2 = new Label();
            dtpFechaFin = new DateTimePicker();
            label1 = new Label();
            dtpFechaInicio = new DateTimePicker();
            btnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            btnExportarPDF = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            txtTotal = new TextBox();
            cboBusqueda = new ComboBox();
            txtBusqueda = new TextBox();
            btnExportar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            dgvdata = new DataGridView();
            FechaRegistro = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            UsuarioRegistro = new DataGridViewTextBoxColumn();
            DocumentoProveedor = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label6 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleVioletRed;
            panel3.Controls.Add(txtFecha);
            panel3.Controls.Add(cboProveedor);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dtpFechaFin);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dtpFechaInicio);
            panel3.Controls.Add(btnBuscarProveedor);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(865, 73);
            panel3.TabIndex = 0;
            // 
            // txtFecha
            // 
            txtFecha.BorderStyle = BorderStyle.None;
            txtFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFecha.Location = new Point(736, 3);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(111, 18);
            txtFecha.TabIndex = 30;
            txtFecha.Visible = false;
            // 
            // cboProveedor
            // 
            cboProveedor.FlatStyle = FlatStyle.Flat;
            cboProveedor.FormattingEnabled = true;
            cboProveedor.Location = new Point(544, 27);
            cboProveedor.Name = "cboProveedor";
            cboProveedor.Size = new Size(194, 23);
            cboProveedor.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(210, 42);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 10;
            label2.Text = "Fecha fin:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(268, 36);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(112, 23);
            dtpFechaFin.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 8;
            label1.Text = "Fecha inicio:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(85, 36);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(112, 23);
            dtpFechaInicio.TabIndex = 7;
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.BackColor = Color.MediumVioletRed;
            btnBuscarProveedor.FlatAppearance.BorderSize = 0;
            btnBuscarProveedor.FlatStyle = FlatStyle.Flat;
            btnBuscarProveedor.ForeColor = Color.White;
            btnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarProveedor.IconColor = Color.White;
            btnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarProveedor.IconSize = 16;
            btnBuscarProveedor.Location = new Point(745, 26);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(102, 24);
            btnBuscarProveedor.TabIndex = 6;
            btnBuscarProveedor.Text = "Buscar";
            btnBuscarProveedor.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarProveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarProveedor.UseVisualStyleBackColor = false;
            btnBuscarProveedor.Click += btnBuscarProveedor_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(475, 33);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 1;
            label9.Text = "Proveedor:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 8);
            label8.Name = "label8";
            label8.Size = new Size(131, 20);
            label8.TabIndex = 0;
            label8.Text = "Reporte Compras";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 64);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(865, 471);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(btnExportarPDF);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(cboBusqueda);
            panel1.Controls.Add(txtBusqueda);
            panel1.Controls.Add(btnExportar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(btnLimpiarBuscador);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dgvdata);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 380);
            panel1.TabIndex = 2;
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
            btnExportarPDF.Location = new Point(153, 17);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(118, 24);
            btnExportarPDF.TabIndex = 36;
            btnExportarPDF.Text = "Descargar PDF";
            btnExportarPDF.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportarPDF.UseVisualStyleBackColor = false;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(695, 356);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 15;
            label4.Text = "Total:";
            label4.Click += label4_Click;
            // 
            // txtTotal
            // 
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(733, 353);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(90, 16);
            txtTotal.TabIndex = 14;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // cboBusqueda
            // 
            cboBusqueda.FlatStyle = FlatStyle.Flat;
            cboBusqueda.FormattingEnabled = true;
            cboBusqueda.Location = new Point(413, 19);
            cboBusqueda.Name = "cboBusqueda";
            cboBusqueda.Size = new Size(156, 23);
            cboBusqueda.TabIndex = 13;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BorderStyle = BorderStyle.None;
            txtBusqueda.Location = new Point(575, 22);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(162, 16);
            txtBusqueda.TabIndex = 12;
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
            btnExportar.IconSize = 16;
            btnExportar.Location = new Point(18, 17);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(119, 24);
            btnExportar.TabIndex = 11;
            btnExportar.Text = "Excel";
            btnExportar.TextAlign = ContentAlignment.MiddleRight;
            btnExportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Orchid;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 16;
            btnBuscar.Location = new Point(743, 18);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(36, 24);
            btnBuscar.TabIndex = 10;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiarBuscador
            // 
            btnLimpiarBuscador.BackColor = Color.MediumVioletRed;
            btnLimpiarBuscador.FlatAppearance.BorderSize = 0;
            btnLimpiarBuscador.FlatStyle = FlatStyle.Flat;
            btnLimpiarBuscador.ForeColor = Color.White;
            btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnLimpiarBuscador.IconColor = Color.White;
            btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarBuscador.IconSize = 16;
            btnLimpiarBuscador.Location = new Point(785, 18);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new Size(36, 24);
            btnLimpiarBuscador.TabIndex = 9;
            btnLimpiarBuscador.UseVisualStyleBackColor = false;
            btnLimpiarBuscador.Click += btnLimpiarBuscador_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(341, 22);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 7;
            label3.Text = "Buscar por:";
            label3.Click += label3_Click;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, TipoDocumento, NumeroDocumento, MontoTotal, UsuarioRegistro, DocumentoProveedor, RazonSocial, CodigoProducto, NombreProducto, PrecioCompra, PrecioVenta, Cantidad, SubTotal });
            dgvdata.EnableHeadersVisualStyles = false;
            dgvdata.Location = new Point(0, 54);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(841, 291);
            dgvdata.TabIndex = 2;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.Name = "FechaRegistro";
            // 
            // TipoDocumento
            // 
            TipoDocumento.HeaderText = "Tipo Documento";
            TipoDocumento.Name = "TipoDocumento";
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Numero Documento";
            NumeroDocumento.Name = "NumeroDocumento";
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.Name = "MontoTotal";
            // 
            // UsuarioRegistro
            // 
            UsuarioRegistro.HeaderText = "Usuario Registro";
            UsuarioRegistro.Name = "UsuarioRegistro";
            // 
            // DocumentoProveedor
            // 
            DocumentoProveedor.HeaderText = "Documento Proveedor";
            DocumentoProveedor.Name = "DocumentoProveedor";
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.Name = "RazonSocial";
            // 
            // CodigoProducto
            // 
            CodigoProducto.HeaderText = "Codigo Producto";
            CodigoProducto.Name = "CodigoProducto";
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre Producto";
            NombreProducto.Name = "NombreProducto";
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "PrecioVenta";
            PrecioVenta.Name = "PrecioVenta";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Location = new Point(733, 351);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 37;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Location = new Point(575, 18);
            label6.Name = "label6";
            label6.Size = new Size(162, 24);
            label6.TabIndex = 38;
            // 
            // frmReporteCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 471);
            Controls.Add(panel2);
            Name = "frmReporteCompra";
            Text = "frmEstadisticasCompras";
            Load += frmReporteCompra_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnBuscarProveedor;
        private Label label9;
        private Label label8;
        private Panel panel2;
        private DateTimePicker dtpFechaInicio;
        private Label label2;
        private DateTimePicker dtpFechaFin;
        private Label label1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnExportar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private Label label3;
        private DataGridView dgvdata;
        private TextBox txtBusqueda;
        private ComboBox cboBusqueda;
        private ComboBox cboProveedor;
        private TextBox txtTotal;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnExportarPDF;
        private TextBox txtFecha;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn UsuarioRegistro;
        private DataGridViewTextBoxColumn DocumentoProveedor;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private Label label5;
        private Label label6;
    }
}