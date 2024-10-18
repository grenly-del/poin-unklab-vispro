namespace Monitor_page
{
    partial class Form1
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
            this.lblNama = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblPekerjaan = new System.Windows.Forms.Label();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtWaktu = new System.Windows.Forms.TextBox();
            this.txtPekerjaan = new System.Windows.Forms.TextBox();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.lblInformasi = new System.Windows.Forms.Label();
            this.lblPerminntaan = new System.Windows.Forms.Label();
            this.lblCintami = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pekerjaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mahasiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSetuju3 = new System.Windows.Forms.Button();
            this.btnSetuju2 = new System.Windows.Forms.Button();
            this.btnSetuju1 = new System.Windows.Forms.Button();
            this.btnDitolak3 = new System.Windows.Forms.Button();
            this.btnDitolak2 = new System.Windows.Forms.Button();
            this.btnDitolak1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(39, 19);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(35, 13);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(39, 63);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(31, 13);
            this.lblPoint.TabIndex = 1;
            this.lblPoint.Text = "Point";
            // 
            // lblPekerjaan
            // 
            this.lblPekerjaan.AutoSize = true;
            this.lblPekerjaan.Location = new System.Drawing.Point(39, 107);
            this.lblPekerjaan.Name = "lblPekerjaan";
            this.lblPekerjaan.Size = new System.Drawing.Size(55, 13);
            this.lblPekerjaan.TabIndex = 2;
            this.lblPekerjaan.Text = "Pekerjaan";
            // 
            // lblWaktu
            // 
            this.lblWaktu.AutoSize = true;
            this.lblWaktu.Location = new System.Drawing.Point(286, 19);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.Size = new System.Drawing.Size(39, 13);
            this.lblWaktu.TabIndex = 3;
            this.lblWaktu.Text = "Waktu";
            this.lblWaktu.Click += new System.EventHandler(this.lblWaktu_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(288, 63);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(80, 16);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(152, 20);
            this.txtNama.TabIndex = 5;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(331, 56);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(152, 20);
            this.txtStatus.TabIndex = 6;
            // 
            // txtWaktu
            // 
            this.txtWaktu.Location = new System.Drawing.Point(331, 17);
            this.txtWaktu.Name = "txtWaktu";
            this.txtWaktu.Size = new System.Drawing.Size(152, 20);
            this.txtWaktu.TabIndex = 7;
            // 
            // txtPekerjaan
            // 
            this.txtPekerjaan.Location = new System.Drawing.Point(100, 104);
            this.txtPekerjaan.Name = "txtPekerjaan";
            this.txtPekerjaan.Size = new System.Drawing.Size(152, 20);
            this.txtPekerjaan.TabIndex = 8;
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(80, 60);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(152, 20);
            this.txtPoint.TabIndex = 9;
            // 
            // lblInformasi
            // 
            this.lblInformasi.AutoSize = true;
            this.lblInformasi.Location = new System.Drawing.Point(97, 148);
            this.lblInformasi.Name = "lblInformasi";
            this.lblInformasi.Size = new System.Drawing.Size(182, 13);
            this.lblInformasi.TabIndex = 10;
            this.lblInformasi.Text = "Informasi Mahasiswa dan Permintaan";
            // 
            // lblPerminntaan
            // 
            this.lblPerminntaan.AutoSize = true;
            this.lblPerminntaan.Location = new System.Drawing.Point(97, 329);
            this.lblPerminntaan.Name = "lblPerminntaan";
            this.lblPerminntaan.Size = new System.Drawing.Size(105, 13);
            this.lblPerminntaan.TabIndex = 11;
            this.lblPerminntaan.Text = "Informasi Permintaan";
            // 
            // lblCintami
            // 
            this.lblCintami.AutoSize = true;
            this.lblCintami.Location = new System.Drawing.Point(643, 17);
            this.lblCintami.Name = "lblCintami";
            this.lblCintami.Size = new System.Drawing.Size(80, 13);
            this.lblCintami.TabIndex = 12;
            this.lblCintami.Text = "Cintami Samsini";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(648, 33);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama,
            this.Point,
            this.Pekerjaan,
            this.Waktu,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(58, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahasiswa});
            this.dataGridView2.Location = new System.Drawing.Point(80, 345);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(222, 93);
            this.dataGridView2.TabIndex = 15;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            this.Nama.Width = 180;
            // 
            // Point
            // 
            this.Point.HeaderText = "Point";
            this.Point.Name = "Point";
            this.Point.Width = 60;
            // 
            // Pekerjaan
            // 
            this.Pekerjaan.HeaderText = "Pekerjaan";
            this.Pekerjaan.Name = "Pekerjaan";
            this.Pekerjaan.Width = 180;
            // 
            // Waktu
            // 
            this.Waktu.HeaderText = "Waktu";
            this.Waktu.Name = "Waktu";
            this.Waktu.Width = 80;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 160;
            // 
            // Mahasiswa
            // 
            this.Mahasiswa.HeaderText = "Mahasiswa";
            this.Mahasiswa.Name = "Mahasiswa";
            this.Mahasiswa.Width = 180;
            // 
            // btnSetuju3
            // 
            this.btnSetuju3.Location = new System.Drawing.Point(412, 406);
            this.btnSetuju3.Name = "btnSetuju3";
            this.btnSetuju3.Size = new System.Drawing.Size(75, 23);
            this.btnSetuju3.TabIndex = 16;
            this.btnSetuju3.Text = "Setuju";
            this.btnSetuju3.UseVisualStyleBackColor = true;
            // 
            // btnSetuju2
            // 
            this.btnSetuju2.Location = new System.Drawing.Point(412, 387);
            this.btnSetuju2.Name = "btnSetuju2";
            this.btnSetuju2.Size = new System.Drawing.Size(75, 23);
            this.btnSetuju2.TabIndex = 17;
            this.btnSetuju2.Text = "Setuju";
            this.btnSetuju2.UseVisualStyleBackColor = true;
            // 
            // btnSetuju1
            // 
            this.btnSetuju1.Location = new System.Drawing.Point(412, 368);
            this.btnSetuju1.Name = "btnSetuju1";
            this.btnSetuju1.Size = new System.Drawing.Size(75, 23);
            this.btnSetuju1.TabIndex = 18;
            this.btnSetuju1.Text = "Setuju";
            this.btnSetuju1.UseVisualStyleBackColor = true;
            // 
            // btnDitolak3
            // 
            this.btnDitolak3.Location = new System.Drawing.Point(331, 406);
            this.btnDitolak3.Name = "btnDitolak3";
            this.btnDitolak3.Size = new System.Drawing.Size(75, 23);
            this.btnDitolak3.TabIndex = 19;
            this.btnDitolak3.Text = "Ditolak";
            this.btnDitolak3.UseVisualStyleBackColor = true;
            // 
            // btnDitolak2
            // 
            this.btnDitolak2.Location = new System.Drawing.Point(331, 387);
            this.btnDitolak2.Name = "btnDitolak2";
            this.btnDitolak2.Size = new System.Drawing.Size(75, 23);
            this.btnDitolak2.TabIndex = 20;
            this.btnDitolak2.Text = "Ditolak";
            this.btnDitolak2.UseVisualStyleBackColor = true;
            // 
            // btnDitolak1
            // 
            this.btnDitolak1.Location = new System.Drawing.Point(331, 368);
            this.btnDitolak1.Name = "btnDitolak1";
            this.btnDitolak1.Size = new System.Drawing.Size(75, 23);
            this.btnDitolak1.TabIndex = 21;
            this.btnDitolak1.Text = "Ditolak";
            this.btnDitolak1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDitolak1);
            this.Controls.Add(this.btnDitolak2);
            this.Controls.Add(this.btnDitolak3);
            this.Controls.Add(this.btnSetuju1);
            this.Controls.Add(this.btnSetuju2);
            this.Controls.Add(this.btnSetuju3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblCintami);
            this.Controls.Add(this.lblPerminntaan);
            this.Controls.Add(this.lblInformasi);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.txtPekerjaan);
            this.Controls.Add(this.txtWaktu);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblWaktu);
            this.Controls.Add(this.lblPekerjaan);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.lblNama);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblPekerjaan;
        private System.Windows.Forms.Label lblWaktu;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtWaktu;
        private System.Windows.Forms.TextBox txtPekerjaan;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Label lblInformasi;
        private System.Windows.Forms.Label lblPerminntaan;
        private System.Windows.Forms.Label lblCintami;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pekerjaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahasiswa;
        private System.Windows.Forms.Button btnSetuju3;
        private System.Windows.Forms.Button btnSetuju2;
        private System.Windows.Forms.Button btnSetuju1;
        private System.Windows.Forms.Button btnDitolak3;
        private System.Windows.Forms.Button btnDitolak2;
        private System.Windows.Forms.Button btnDitolak1;
    }
}

