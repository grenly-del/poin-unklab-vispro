using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class RegisMahasiswa : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public RegisMahasiswa()
        {
            alamat = "server=localhost; database=universitas; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisMonitor frmRegMonitor = new RegisMonitor();
            frmRegMonitor.Show();
            this.Hide();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void RegisMahasiswa_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HalamanUtama halamanUtama = new HalamanUtama();
            halamanUtama.Show();
            this.Hide();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNama.Text != "" && txtPassword.Text != "" && txtNoRegis.Text != "" && txtNIM.Text != "")
                {
                    // Membuat objek Random
                    Random rnd = new Random();

                    // Menghasilkan angka random dari 4001 hingga 9999
                    int id_pengguna = rnd.Next(4001, 10000);

                    // Membuka koneksi ke database
                    koneksi.Open();

                    // Query untuk insert ke tabel tb_mahasiswa
                    string query1 = "INSERT INTO tb_mahasiswa (id_pengguna, nama_mahasiswa, fakultas, prodi, password, no_regis, nim) " +
                                    "VALUES (@id_pengguna, @nama_mahasiswa, @fakultas, @prodi, @password, @no_regis, @nim)";
                    MySqlCommand perintah1 = new MySqlCommand(query1, koneksi);
                    perintah1.Parameters.AddWithValue("@id_pengguna", id_pengguna);
                    perintah1.Parameters.AddWithValue("@nama_mahasiswa", txtNama.Text);
                    perintah1.Parameters.AddWithValue("@fakultas", cbFakultas.SelectedItem.ToString());
                    perintah1.Parameters.AddWithValue("@prodi", cbJurusan.SelectedItem.ToString());
                    perintah1.Parameters.AddWithValue("@password", txtPassword.Text);
                    perintah1.Parameters.AddWithValue("@no_regis", txtNoRegis.Text);
                    perintah1.Parameters.AddWithValue("@nim", txtNIM.Text);

                    // Query untuk insert ke tabel tb_poin
                    string query2 = "INSERT INTO tb_poin (id_mahasiswa, jumlah_poin, poin_sisa, status) " +
                                    "VALUES (@id_pengguna, @jumlah_poin, @poin_sisa, @status)";
                    MySqlCommand perintah2 = new MySqlCommand(query2, koneksi);
                    perintah2.Parameters.AddWithValue("@id_pengguna", id_pengguna);
                    perintah2.Parameters.AddWithValue("@jumlah_poin", 0);
                    perintah2.Parameters.AddWithValue("@poin_sisa", 0);
                    perintah2.Parameters.AddWithValue("@status", "belum");

                    // Menjalankan semua query
                    perintah1.ExecuteNonQuery();
                    perintah2.ExecuteNonQuery();

                    // Menampilkan pesan sukses
                    MessageBox.Show("Data berhasil di tambahkan");

                    // Beralih ke halaman login
                    HalamanUtama mainfrm = new HalamanUtama();
                    mainfrm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Data tidak lengkap!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
            finally
            {
                // Pastikan koneksi tertutup
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }

        }
    }
}
