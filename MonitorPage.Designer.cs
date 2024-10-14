namespace PoinUnklabVispro
{
    partial class MonitorPage
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
            this.lblInformasi = new System.Windows.Forms.Label();
            this.lblPermintaan = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblPekerjaan = new System.Windows.Forms.Label();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.txtPekerjaan = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtWaktu = new System.Windows.Forms.TextBox();
            this.btnDitolak1 = new System.Windows.Forms.Button();
            this.btnSetuju1 = new System.Windows.Forms.Button();
            this.btnDitolak2 = new System.Windows.Forms.Button();
            this.btnSetuju2 = new System.Windows.Forms.Button();
            this.btnDitolak3 = new System.Windows.Forms.Button();
            this.btnSetuju3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mahasiswa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pekerjaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInformasi
            // 
            this.lblInformasi.AutoSize = true;
            this.lblInformasi.Location = new System.Drawing.Point(86, 107);
            this.lblInformasi.Name = "lblInformasi";
            this.lblInformasi.Size = new System.Drawing.Size(182, 13);
            this.lblInformasi.TabIndex = 2;
            this.lblInformasi.Text = "Informasi Mahasiswa dan Permintaan";
            // 
            // lblPermintaan
            // 
            this.lblPermintaan.AutoSize = true;
            this.lblPermintaan.Location = new System.Drawing.Point(86, 314);
            this.lblPermintaan.Name = "lblPermintaan";
            this.lblPermintaan.Size = new System.Drawing.Size(105, 13);
            this.lblPermintaan.TabIndex = 3;
            this.lblPermintaan.Text = "Informasi Permintaan";
            this.lblPermintaan.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(657, 31);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(80, 13);
            this.lblNama.TabIndex = 4;
            this.lblNama.Text = "Cintami Samsini";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(660, 47);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(67, 21);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Nama:";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(32, 47);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(34, 13);
            this.lblPoint.TabIndex = 7;
            this.lblPoint.Text = "Point:";
            // 
            // lblPekerjaan
            // 
            this.lblPekerjaan.AutoSize = true;
            this.lblPekerjaan.Location = new System.Drawing.Point(32, 78);
            this.lblPekerjaan.Name = "lblPekerjaan";
            this.lblPekerjaan.Size = new System.Drawing.Size(58, 13);
            this.lblPekerjaan.TabIndex = 8;
            this.lblPekerjaan.Text = "Pekerjaan:";
            // 
            // lblWaktu
            // 
            this.lblWaktu.AutoSize = true;
            this.lblWaktu.Location = new System.Drawing.Point(262, 18);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.Size = new System.Drawing.Size(42, 13);
            this.lblWaktu.TabIndex = 9;
            this.lblWaktu.Text = "Waktu:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(262, 47);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status:";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(76, 15);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(143, 20);
            this.txtNama.TabIndex = 11;
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(76, 40);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(120, 20);
            this.txtPoint.TabIndex = 12;
            // 
            // txtPekerjaan
            // 
            this.txtPekerjaan.Location = new System.Drawing.Point(89, 71);
            this.txtPekerjaan.Name = "txtPekerjaan";
            this.txtPekerjaan.Size = new System.Drawing.Size(125, 20);
            this.txtPekerjaan.TabIndex = 13;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(310, 40);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(120, 20);
            this.txtStatus.TabIndex = 14;
            // 
            // txtWaktu
            // 
            this.txtWaktu.Location = new System.Drawing.Point(310, 12);
            this.txtWaktu.Name = "txtWaktu";
            this.txtWaktu.Size = new System.Drawing.Size(120, 20);
            this.txtWaktu.TabIndex = 15;
            this.txtWaktu.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnDitolak1
            // 
            this.btnDitolak1.Location = new System.Drawing.Point(283, 364);
            this.btnDitolak1.Name = "btnDitolak1";
            this.btnDitolak1.Size = new System.Drawing.Size(67, 21);
            this.btnDitolak1.TabIndex = 16;
            this.btnDitolak1.Text = "Ditolak";
            this.btnDitolak1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDitolak1.UseVisualStyleBackColor = true;
            // 
            // btnSetuju1
            // 
            this.btnSetuju1.Location = new System.Drawing.Point(356, 364);
            this.btnSetuju1.Name = "btnSetuju1";
            this.btnSetuju1.Size = new System.Drawing.Size(67, 21);
            this.btnSetuju1.TabIndex = 17;
            this.btnSetuju1.Text = "Setuju";
            this.btnSetuju1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetuju1.UseVisualStyleBackColor = true;
            // 
            // btnDitolak2
            // 
            this.btnDitolak2.Location = new System.Drawing.Point(283, 382);
            this.btnDitolak2.Name = "btnDitolak2";
            this.btnDitolak2.Size = new System.Drawing.Size(67, 21);
            this.btnDitolak2.TabIndex = 18;
            this.btnDitolak2.Text = "Ditolak";
            this.btnDitolak2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDitolak2.UseVisualStyleBackColor = true;
            // 
            // btnSetuju2
            // 
            this.btnSetuju2.Location = new System.Drawing.Point(356, 382);
            this.btnSetuju2.Name = "btnSetuju2";
            this.btnSetuju2.Size = new System.Drawing.Size(67, 21);
            this.btnSetuju2.TabIndex = 19;
            this.btnSetuju2.Text = "Setuju";
            this.btnSetuju2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetuju2.UseVisualStyleBackColor = true;
            // 
            // btnDitolak3
            // 
            this.btnDitolak3.Location = new System.Drawing.Point(283, 402);
            this.btnDitolak3.Name = "btnDitolak3";
            this.btnDitolak3.Size = new System.Drawing.Size(67, 21);
            this.btnDitolak3.TabIndex = 20;
            this.btnDitolak3.Text = "Ditolak";
            this.btnDitolak3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDitolak3.UseVisualStyleBackColor = true;
            // 
            // btnSetuju3
            // 
            this.btnSetuju3.Location = new System.Drawing.Point(356, 402);
            this.btnSetuju3.Name = "btnSetuju3";
            this.btnSetuju3.Size = new System.Drawing.Size(67, 21);
            this.btnSetuju3.TabIndex = 21;
            this.btnSetuju3.Text = "Setuju";
            this.btnSetuju3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetuju3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama,
            this.point,
            this.pekerjaan,
            this.waktu,
            this.status});
            this.dataGridView1.Location = new System.Drawing.Point(76, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahasiswa});
            this.dataGridView2.Location = new System.Drawing.Point(76, 341);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(192, 125);
            this.dataGridView2.TabIndex = 23;
            // 
            // mahasiswa
            // 
            this.mahasiswa.HeaderText = "Mahasiswa";
            this.mahasiswa.Name = "mahasiswa";
            this.mahasiswa.Width = 150;
            // 
            // nama
            // 
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 10;
            this.nama.Name = "nama";
            this.nama.Width = 150;
            // 
            // point
            // 
            this.point.HeaderText = "Point";
            this.point.Name = "point";
            // 
            // pekerjaan
            // 
            this.pekerjaan.HeaderText = "Pekerjaan";
            this.pekerjaan.Name = "pekerjaan";
            this.pekerjaan.Width = 150;
            // 
            // waktu
            // 
            this.waktu.HeaderText = "Waktu";
            this.waktu.Name = "waktu";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.Width = 120;
            // 
            // MonitorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSetuju3);
            this.Controls.Add(this.btnDitolak3);
            this.Controls.Add(this.btnSetuju2);
            this.Controls.Add(this.btnDitolak2);
            this.Controls.Add(this.btnSetuju1);
            this.Controls.Add(this.btnDitolak1);
            this.Controls.Add(this.txtWaktu);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtPekerjaan);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblWaktu);
            this.Controls.Add(this.lblPekerjaan);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblPermintaan);
            this.Controls.Add(this.lblInformasi);
            this.Name = "MonitorPage";
            this.Text = "MonitorPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInformasi;
        private System.Windows.Forms.Label lblPermintaan;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblPekerjaan;
        private System.Windows.Forms.Label lblWaktu;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.TextBox txtPekerjaan;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtWaktu;
        private System.Windows.Forms.Button btnDitolak1;
        private System.Windows.Forms.Button btnSetuju1;
        private System.Windows.Forms.Button btnDitolak2;
        private System.Windows.Forms.Button btnSetuju2;
        private System.Windows.Forms.Button btnDitolak3;
        private System.Windows.Forms.Button btnSetuju3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn point;
        private System.Windows.Forms.DataGridViewTextBoxColumn pekerjaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahasiswa;
    }
}