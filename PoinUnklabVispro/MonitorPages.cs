using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PoinUnklabVispro
{
    public partial class MonitorPages : Form
    {
        private MySqlConnection koneksi;
        private List<System.Windows.Forms.CheckBox> checkBoxes; // Menyimpan referensi ke semua checkbox
        private List<string> mahasiswaIds;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        private string idMonitor;
        public MonitorPages(string idMonitor)
        {
            InitializeComponent();
            alamat = "server=localhost; database=universitas; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            checkBoxes = new List<System.Windows.Forms.CheckBox>();
            mahasiswaIds = new List<string>();
            TableInformasiMHS.ColumnCount = 4; // 5 kolom: Nama, NIM, Poin, Pekerjaan, Status
            TableInformasiMHS.RowCount = 1; // Mulai dengan 1 baris (untuk header)
            TableInformasiMHS.AutoSize = true;
            TableInformasiMHS.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            // Mengatur Ukuran Kolom
            TableInformasiMHS.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            TampilkanDataMahasiswa();
            AddHeaderToTable(); // Buat Headnya
            this.idMonitor = idMonitor;
            // Jalankan
        }

        private void AddHeaderToTable()
        {
            TableInformasiMHS.Controls.Add(new Label() { Text = "Nama", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 0, 0);
            TableInformasiMHS.Controls.Add(new Label() { Text = "NIM", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 1, 0);
            TableInformasiMHS.Controls.Add(new Label() { Text = "Poin", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 2, 0);
            //TableInformasiMHS.Controls.Add(new Label() { Text = "Pekerjaan", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 3, 0);
            TableInformasiMHS.Controls.Add(new Label() { Text = "Status", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 3, 0);
        }
        private void TampilkanDataMahasiswa()
        {


            try
            {
                // Membuka koneksi ke database
                koneksi.Open();
                // Query untuk mengambil data mahasiswa

                MySqlCommand cmd = new MySqlCommand("SELECT tb_mahasiswa.id_pengguna, tb_mahasiswa.nama_mahasiswa AS nama_mahasiswa, pe.jumlah_poin_req AS poin, pe.jenis_pekerjaan as pekerjaan " +
                    "FROM tb_mahasiswa " +
                    "JOIN tb_kerja AS pe ON pe.id_mahasiswa = tb_mahasiswa.id_pengguna", koneksi);
                MySqlDataReader reader = cmd.ExecuteReader();

                int posY = 450; // Posisi Y awal untuk setiap baris data
                int margin = 20; // Jarak antar baris data

                while (reader.Read())
                {

                    mahasiswaIds.Add(reader["id_pengguna"].ToString());
                    // Membuat label untuk Nama
                    Label labelNama = new Label();
                    labelNama.Text = reader["nama_mahasiswa"].ToString();
                    labelNama.Location = new Point(25, posY);
                    labelNama.AutoSize = true;
                    this.Controls.Add(labelNama);

                    // Membuat label untuk Umur
                    Label labelUmur = new Label();
                    labelUmur.Text = reader["poin"].ToString();
                    labelUmur.Location = new Point(173, posY);
                    labelUmur.AutoSize = true;
                    this.Controls.Add(labelUmur);

                    // Membuat label untuk jenis pekerjaan
                    Label jkerja = new Label();
                    jkerja.Text = reader["pekerjaan"].ToString();
                    jkerja.Location = new Point(253, posY);
                    jkerja.AutoSize = true;
                    this.Controls.Add(jkerja);

                    // Membuat Radio Button untuk setiap data mahasiswa
                    System.Windows.Forms.CheckBox radiobtn1 = new System.Windows.Forms.CheckBox();
                    radiobtn1.Location = new Point(425, posY);
                    radiobtn1.AutoSize = true;
                    this.Controls.Add(radiobtn1);
                    checkBoxes.Add(radiobtn1);

                    // Membuat Radio Button untuk setiap data mahasiswa
                    System.Windows.Forms.CheckBox radiobtn2 = new System.Windows.Forms.CheckBox();
                    radiobtn2.Location = new Point(480, posY);
                    radiobtn2.AutoSize = true;
                    this.Controls.Add(radiobtn2);
                    checkBoxes.Add(radiobtn2);
                    // RadioButton untuk Setuju
                    //System.Windows.Forms.RadioButton radioButtonSetuju = new System.Windows.Forms.RadioButton();
                    //radioButtonSetuju.Location = new Point(360, posY);
                    //radioButtonSetuju.AutoSize = true;
                    //radioButtonSetuju.Text = "Setuju";
                    //radioButtonSetuju.GroupName = "group_" + reader["id_pengguna"].ToString();
                    //radioButtonSetuju.CheckedChanged += RadioButton_CheckedChanged;
                    //this.Controls.Add(radioButtonSetuju);

                    //// RadioButton untuk Tidak Setuju
                    //RadioButton radioButtonTidakSetuju = new RadioButton();
                    //radioButtonTidakSetuju.Location = new Point(420, posY); // Atur posisi sesuai kebutuhan
                    //radioButtonTidakSetuju.AutoSize = true;
                    //radioButtonTidakSetuju.Text = "Tidak Setuju";
                    //radioButtonTidakSetuju.GroupName = "group_" + reader["id_pengguna"].ToString();
                    //radioButtonTidakSetuju.CheckedChanged += RadioButton_CheckedChanged;
                    //this.Controls.Add(radioButtonTidakSetuju);



                    // Memperbarui posisi Y untuk baris data berikutnya
                    posY += margin;
                }


                reader.Close();
                koneksi.Close();

                //Membuat tombol "Submit" setelah data selesai ditampilkan
                Button btnSubmit = new Button();
                btnSubmit.Text = "Submit";
                btnSubmit.Size = new Size(100, 30);
                btnSubmit.Location = new Point(20, posY + 20); // Letakkan di bawah data yang terakhir ditampilkan
                btnSubmit.Click += new EventHandler(BtnSubmit_Click); // Menambahkan event handler untuk tombol
                this.Controls.Add(btnSubmit);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                MessageBox.Show("idMahasiswa untuk checkbox: ");

                for (int i = 0; i < checkBoxes.Count; i += 2) // Mengambil setiap dua checkbox
                {
                    string idMahasiswa = mahasiswaIds[i / 2]; // Ambil ID mahasiswa sesuai index


                    if (checkBoxes[i].Checked) // Jika checkbox 1 (Berhasil) tercentang
                    {
                        string query = "UPDATE tb_poin SET status = @status, poin_sisa = GREATEST(poin_sisa - (SELECT jumlah_poin_req FROM tb_kerja WHERE id_mahasiswa = @id_mahasiswa LIMIT 1), 0) WHERE id_mahasiswa = @id_mahasiswa";
                        MySqlCommand cmd = new MySqlCommand(query, koneksi);
                        cmd.Parameters.AddWithValue("@status", "Berhasil");
                        cmd.Parameters.AddWithValue("@id_mahasiswa", idMahasiswa);
                        cmd.ExecuteNonQuery();
                    }
                    else if (checkBoxes[i + 1].Checked) // Jika checkbox 2 (Gagal) tercentang
                    {
                        string query = "UPDATE tb_poin SET status = @status WHERE id_mahasiswa = @id_mahasiswa";
                        MySqlCommand cmd = new MySqlCommand(query, koneksi);
                        cmd.Parameters.AddWithValue("@status", "Ditolak");
                        cmd.Parameters.AddWithValue("@id_mahasiswa", idMahasiswa);
                        cmd.ExecuteNonQuery();

                    }
                }

                MessageBox.Show("Data berhasil disimpan!");
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                koneksi.Close(); // Pastikan untuk menutup koneksi pada error
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HalamanUtama halamanUtama = new HalamanUtama();
            halamanUtama.Show();
            this.Hide();
        }

        private void TableInformasiMHS_Paint(object sender, PaintEventArgs e)
        {

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
                    "JOIN tb_kerja as pe ON pe.id_mahasiswa = m.id_pengguna LIMIT 1",
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
                    //TableInformasiMHS.Controls.Add(new Label() { Text = reader["pekerjaan"].ToString(), TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 3, row);
                    TableInformasiMHS.Controls.Add(new Label() { Text = reader["status"].ToString(), TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 3, row);

                    row++; // Pindah ke baris berikutnya
                    TableInformasiMHS.RowCount = row; // Tambah jumlah baris di TableLayoutPanel
                }

                reader.Close(); // Jangan lupa tutup reader setelah selesai
                koneksi.Close(); // Tutup koneksi
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }



    }
}
