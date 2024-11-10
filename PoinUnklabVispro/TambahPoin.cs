using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PoinUnklabVispro
{
    public partial class TambahPoin : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public TambahPoin()
        {
            alamat = "server=localhost; database=universitas; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void TambahPoin_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Membuka koneksi ke database
                koneksi.Open();

                // Query untuk mengambil data mahasiswa
                MySqlCommand cmd = new MySqlCommand("SELECT mahasiswa.id_pengguna AS id_mahasiswa, mahasiswa.nama_mahasiswa AS nama_mahasiswa, mahasiswa.no_regis AS no_regis, " +
                    "mahasiswa.nim AS nim, mahasiswa.fakultas AS fakultas, mahasiswa.prodi AS prodi, po.poin_sisa AS poin " +
                    "FROM tb_mahasiswa AS mahasiswa " +
                    "JOIN tb_poin AS po ON po.id_mahasiswa = mahasiswa.id_pengguna WHERE mahasiswa.id_pengguna = @idMahasiswa", koneksi);
                cmd.Parameters.AddWithValue("@idMahasiswa", Convert.ToInt32(txtNoRegis.Text));

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lblName.Text = reader["nama_mahasiswa"].ToString();
                    lblFakultas.Text = reader["fakultas"].ToString();
                    lblNIM.Text = reader["nim"].ToString();
                    lblJurusan.Text = reader["prodi"].ToString();  // Pastikan menggunakan nama kolom yang benar
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
            finally
            {
                // Pastikan koneksi tertutup setelah selesai
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
