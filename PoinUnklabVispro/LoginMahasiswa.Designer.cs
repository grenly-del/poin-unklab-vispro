namespace PoinUnklabVispro
{
    partial class LoginMahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMahasiswa));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mahasiswaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPasswordMhs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegisMhs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mahasiswaToolStripMenuItem,
            this.monitorToolStripMenuItem});
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.registerToolStripMenuItem.Text = "Register";
            // 
            // mahasiswaToolStripMenuItem
            // 
            this.mahasiswaToolStripMenuItem.Name = "mahasiswaToolStripMenuItem";
            this.mahasiswaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.mahasiswaToolStripMenuItem.Text = "Mahasiswa";
            // 
            // monitorToolStripMenuItem
            // 
            this.monitorToolStripMenuItem.Name = "monitorToolStripMenuItem";
            this.monitorToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.monitorToolStripMenuItem.Text = "Monitor";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mahasiswaToolStripMenuItem1,
            this.monitorToolStripMenuItem1});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // mahasiswaToolStripMenuItem1
            // 
            this.mahasiswaToolStripMenuItem1.Name = "mahasiswaToolStripMenuItem1";
            this.mahasiswaToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.mahasiswaToolStripMenuItem1.Text = "Mahasiswa";
            // 
            // monitorToolStripMenuItem1
            // 
            this.monitorToolStripMenuItem1.Name = "monitorToolStripMenuItem1";
            this.monitorToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.monitorToolStripMenuItem1.Text = "Monitor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(316, 30);
            this.label11.TabIndex = 41;
            this.label11.Text = "Ini adalah aplikasi yang akan mengelolah sistem poin di \r\nkampus dengan lebih fle" +
    "ksibel.\r\n";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(474, 278);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(179, 30);
            this.btnLogin.TabIndex = 47;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPasswordMhs
            // 
            this.txtPasswordMhs.Location = new System.Drawing.Point(475, 229);
            this.txtPasswordMhs.Name = "txtPasswordMhs";
            this.txtPasswordMhs.PasswordChar = '*';
            this.txtPasswordMhs.Size = new System.Drawing.Size(227, 20);
            this.txtPasswordMhs.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Password";
            // 
            // txtRegisMhs
            // 
            this.txtRegisMhs.Location = new System.Drawing.Point(475, 149);
            this.txtRegisMhs.Name = "txtRegisMhs";
            this.txtRegisMhs.Size = new System.Drawing.Size(227, 20);
            this.txtRegisMhs.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(543, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "(s22313533)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "No.Regis";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(509, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 25);
            this.label10.TabIndex = 48;
            this.label10.Text = "Login Mahasiswa";
            // 
            // LoginMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPasswordMhs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRegisMhs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginMahasiswa";
            this.Text = "LoginMahasiswa";
            this.Load += new System.EventHandler(this.LoginMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mahasiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mahasiswaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem monitorToolStripMenuItem1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPasswordMhs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegisMhs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
    }
}