using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PoinUnklabVispro
{
    public partial class MonitorPages : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public MonitorPages()
        {
            alamat = "server=localhost; database=universitas; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
            TableInformasiMHS.ColumnCount = 5; // 5 kolom: Nama, NIM, Poin, Pekerjaan, Status
            TableInformasiMHS.RowCount = 1; // Mulai dengan 1 baris (untuk header)
            TableInformasiMHS.AutoSize = true;
            TableInformasiMHS.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            // Mengatur Ukuran Kolom
            TableInformasiMHS.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            AddHeaderToTable(); // Buat Headnya
            // Jalankan
        }

        private void AddHeaderToTable()
        {
            TableInformasiMHS.Controls.Add(new Label() { Text = "Nama", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 0, 0);
            TableInformasiMHS.Controls.Add(new Label() { Text = "NIM", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 1, 0);
            TableInformasiMHS.Controls.Add(new Label() { Text = "Poin", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 2, 0);
            TableInformasiMHS.Controls.Add(new Label() { Text = "Pekerjaan", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 3, 0);
            TableInformasiMHS.Controls.Add(new Label() { Text = "Status", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 4, 0);
        }

        private void MonitorPages_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                // Perbaikan: Gunakan MySqlCommand bukan SqlCommand
                MySqlCommand command = new MySqlCommand(
                    "SELECT m.nama_mahasiswa as nama_mahasiswa, m.nim as nim, p.jumlah_poin as jumlah_poin, pe.jenis_pekerjaan as pekerjaan, p.status as status " +
                    "FROM tb_mahasiswa as m " +
                    "JOIN tb_poin as p ON p.id_mahasiswa = m.id_pengguna " +
                    "JOIN tb_kerja as pe ON pe.id_mahasiswa = m.id_pengguna",
                    koneksi);

                // Execute command
                MySqlDataReader reader = command.ExecuteReader();

                int row = 1; // Baris pertama (0) sudah diisi header, mulai dari baris ke-1
                while (reader.Read())
                {
                    // Menambahkan data mahasiswa
                    TableInformasiMHS.Controls.Add(new Label() { Text = reader["nama_mahasiswa"].ToString(), TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 0, row);
                    TableInformasiMHS.Controls.Add(new Label() { Text = reader["nim"].ToString(), TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 1, row);
                    TableInformasiMHS.Controls.Add(new Label() { Text = reader["jumlah_poin"].ToString(), TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 2, row);
                    TableInformasiMHS.Controls.Add(new Label() { Text = reader["pekerjaan"].ToString(), TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 3, row);
                    TableInformasiMHS.Controls.Add(new Label() { Text = reader["status"].ToString(), TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 4, row);

                    row++; // Pindah ke baris berikutnya
                    TableInformasiMHS.RowCount = row; // Tambah jumlah baris di TableLayoutPanel
                }

                reader.Close(); // Jangan lupa tutup reader setelah selesai
                koneksi.Close(); // Tutup koneksi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        

    }
}
