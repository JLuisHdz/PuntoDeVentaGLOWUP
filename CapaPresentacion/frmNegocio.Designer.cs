namespace CapaPresentacion
{
    partial class frmNegocio
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
            label1 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            laabel3 = new Label();
            txtDireccion = new TextBox();
            btnGuardar = new Button();
            label2 = new Label();
            label7 = new Label();
            txtRuc = new TextBox();
            btnSubir = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            picLogo = new PictureBox();
            label4 = new Label();
            label13 = new Label();
            txtEliminar = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
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
            label1.Text = "DETALLE DE NEGOCIO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(txtEliminar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(121, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(619, 311);
            panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(laabel3);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtRuc);
            groupBox1.Controls.Add(btnSubir);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(picLogo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label13);
            groupBox1.Location = new Point(22, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(574, 230);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            // 
            // laabel3
            // 
            laabel3.AutoSize = true;
            laabel3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            laabel3.ForeColor = Color.White;
            laabel3.Location = new Point(226, 121);
            laabel3.Name = "laabel3";
            laabel3.Size = new Size(58, 13);
            laabel3.TabIndex = 32;
            laabel3.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.Location = new Point(229, 142);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(304, 18);
            txtDireccion.TabIndex = 31;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkMagenta;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(226, 179);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(307, 25);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Modificar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(226, 70);
            label2.Name = "label2";
            label2.Size = new Size(57, 13);
            label2.TabIndex = 32;
            label2.Text = "Contacto:";
            label2.Click += label2_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Location = new Point(226, 137);
            label7.Name = "label7";
            label7.Size = new Size(307, 28);
            label7.TabIndex = 33;
            // 
            // txtRuc
            // 
            txtRuc.BorderStyle = BorderStyle.None;
            txtRuc.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtRuc.Location = new Point(229, 91);
            txtRuc.Name = "txtRuc";
            txtRuc.Size = new Size(304, 18);
            txtRuc.TabIndex = 31;
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
            btnSubir.Location = new Point(20, 179);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(170, 24);
            btnSubir.TabIndex = 7;
            btnSubir.UseVisualStyleBackColor = false;
            btnSubir.Click += btnSubir_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(226, 86);
            label3.Name = "label3";
            label3.Size = new Size(307, 28);
            label3.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(226, 19);
            label6.Name = "label6";
            label6.Size = new Size(113, 13);
            label6.TabIndex = 23;
            label6.Text = "Nombre de Negocio:";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(229, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(304, 18);
            txtNombre.TabIndex = 6;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.White;
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(20, 35);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(170, 138);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 19);
            label4.Name = "label4";
            label4.Size = new Size(36, 13);
            label4.TabIndex = 5;
            label4.Text = "Logo:";
            // 
            // label13
            // 
            label13.BackColor = Color.White;
            label13.Location = new Point(226, 35);
            label13.Name = "label13";
            label13.Size = new Size(307, 28);
            label13.TabIndex = 27;
            // 
            // txtEliminar
            // 
            txtEliminar.BackColor = Color.Crimson;
            txtEliminar.FlatAppearance.BorderSize = 0;
            txtEliminar.FlatStyle = FlatStyle.Flat;
            txtEliminar.Location = new Point(19, 430);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(177, 25);
            txtEliminar.TabIndex = 9;
            txtEliminar.Text = "Eliminar";
            txtEliminar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 64);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(865, 450);
            panel2.TabIndex = 4;
            // 
            // frmNegocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmNegocio";
            Text = "frmNegocio";
            Load += frmNegocio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label6;
        private TextBox txtNombre;
        private Button txtEliminar;
        private Button btnGuardar;
        private Label label4;
        private Label label13;
        private GroupBox groupBox1;
        private PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btnSubir;
        private Label laabel3;
        private TextBox txtDireccion;
        private Label label2;
        private Label label7;
        private TextBox txtRuc;
        private Label label3;
        private Panel panel2;
    }
}