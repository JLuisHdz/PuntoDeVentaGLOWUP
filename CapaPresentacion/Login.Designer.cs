namespace CapaPresentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnCerrar = new Button();
            btnLogin = new Button();
            panel4 = new Panel();
            txtUser = new TextBox();
            panel3 = new Panel();
            txtPass = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Plum;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 258);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-34, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Purple;
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(230, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(289, 258);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(192, 0, 0);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(149, 188);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(104, 36);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Violet;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(39, 188);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 36);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(txtUser);
            panel4.ForeColor = Color.FromArgb(64, 64, 64);
            panel4.Location = new Point(39, 51);
            panel4.Name = "panel4";
            panel4.Size = new Size(214, 40);
            panel4.TabIndex = 10;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.WhiteSmoke;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Cursor = Cursors.IBeam;
            txtUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.Black;
            txtUser.Location = new Point(11, 11);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(191, 18);
            txtUser.TabIndex = 14;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(txtPass);
            panel3.ForeColor = Color.FromArgb(64, 64, 64);
            panel3.Location = new Point(39, 127);
            panel3.Name = "panel3";
            panel3.Size = new Size(214, 40);
            panel3.TabIndex = 9;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.WhiteSmoke;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Cursor = Cursors.IBeam;
            txtPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.ForeColor = Color.Black;
            txtPass.Location = new Point(10, 11);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(191, 18);
            txtPass.TabIndex = 8;
            txtPass.TabStop = false;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(39, 104);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(88, 20);
            label2.TabIndex = 7;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 28);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(63, 20);
            label1.TabIndex = 5;
            label1.Text = "Usuario";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(519, 258);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Button btnLogin;
        private Panel panel4;
        private TextBox txtPass;
        private Button btnCerrar;
        private TextBox txtUser;
    }
}