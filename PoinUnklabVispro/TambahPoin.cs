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
using System.Threading;

namespace PoinUnklabVispro
{
    public partial class TambahPoin : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        private int id_mahasiswa;
        private string id_monitor;
        public TambahPoin(string param)
        {
            alamat = "server=localhost; database=universitas; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
            this.id_monitor = param;
        }

        private void TambahPoin_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                MySqlCommand monitorCommand = new MySqlCommand(
                    "SELECT nama_monitor FROM tb_monitor WHERE id_monitor = @idMonitor", koneksi);
                monitorCommand.Parameters.AddWithValue("@idMonitor", id_monitor);
                MySqlDataReader monitorReader = monitorCommand.ExecuteReader();

                if (monitorReader.Read())
                {
                    lblnamaMonitor.Text = monitorReader["nama_monitor"].ToString();
                }

                monitorReader.Close();
                koneksi.Close();
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
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
                    "JOIN tb_poin AS po ON po.id_mahasiswa = mahasiswa.id_pengguna WHERE mahasiswa.no_regis = @idMahasiswa", koneksi);
                cmd.Parameters.AddWithValue("@idMahasiswa", txtNoRegis.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) // Jika data ditemukan
                {
                    while (reader.Read())
                    {
                        lblName.Text = reader["nama_mahasiswa"].ToString();
                        lblFakultas.Text = reader["fakultas"].ToString();
                        lblNIM.Text = reader["nim"].ToString();
                        lblJurusan.Text = reader["prodi"].ToString();
                        lblPoin.Text = reader["poin"].ToString();
                        id_mahasiswa = Convert.ToInt32(reader["id_mahasiswa"].ToString());
                        
                    }
                }
                else // Jika data tidak ditemukan
                {
                    lblName.Text = string.Empty;
                    lblFakultas.Text = string.Empty;
                    lblNIM.Text = string.Empty;
                    lblJurusan.Text = string.Empty;
                    lblPoin.Text = string.Empty;
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

        private void btnPoin_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Membuka koneksi ke database
                koneksi.Open();

                // Query untuk update poin
                MySqlCommand cmd = new MySqlCommand("UPDATE tb_poin SET poin_sisa = poin_sisa + @jumlahPoin, jumlah_poin = jumlah_poin + @jumlahPoin WHERE id_mahasiswa = @idMahasiswa", koneksi);
                cmd.Parameters.AddWithValue("@idMahasiswa", id_mahasiswa);
                cmd.Parameters.AddWithValue("@jumlahPoin", Convert.ToInt32(txtPoin.Text));

                // Menjalankan perintah update
                int rowsAffected = cmd.ExecuteNonQuery();

                // Jika update berhasil (jumlah baris yang terpengaruh lebih dari 0)
                if (rowsAffected > 0)
                {
                    // Query untuk mendapatkan sisa_poin terbaru
                    MySqlCommand cmdSelect = new MySqlCommand("SELECT poin_sisa FROM tb_poin WHERE id_mahasiswa = @idMahasiswa", koneksi);
                    cmdSelect.Parameters.AddWithValue("@idMahasiswa", id_mahasiswa);
                    MySqlDataReader reader = cmdSelect.ExecuteReader();

                    // Menampilkan sisa poin terbaru pada lblPoin
                    if (reader.Read())
                    {
                        lblPoin.Text = reader["poin_sisa"].ToString();
                    }

                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan atau tidak ada perubahan pada data.");
                }
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MonitorPages monitor = new MonitorPages(id_monitor);
            monitor.Show();
            this.Hide();
        }

        private void btnPoin_Click(object sender, EventArgs e)
        {
            try
            {
                // Membuka koneksi ke database
                koneksi.Open();

                // Query untuk mengambil data mahasiswa
                MySqlCommand cmd = new MySqlCommand("INSERT INTO mahasiswa.id_pengguna AS id_mahasiswa, mahasiswa.nama_mahasiswa AS nama_mahasiswa, mahasiswa.no_regis AS no_regis, " +
                    "mahasiswa.nim AS nim, mahasiswa.fakultas AS fakultas, mahasiswa.prodi AS prodi, po.poin_sisa AS poin " +
                    "FROM tb_mahasiswa AS mahasiswa " +
                    "JOIN tb_poin AS po ON po.id_mahasiswa = mahasiswa.id_pengguna WHERE mahasiswa.no_regis = @idMahasiswa", koneksi);
                cmd.Parameters.AddWithValue("@idMahasiswa", txtNoRegis.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) // Jika data ditemukan
                {
                    while (reader.Read())
                    {
                        lblName.Text = reader["nama_mahasiswa"].ToString();
                        lblFakultas.Text = reader["fakultas"].ToString();
                        lblNIM.Text = reader["nim"].ToString();
                        lblJurusan.Text = reader["prodi"].ToString();
                        lblPoin.Text = reader["poin"].ToString();
                    }
                }
                else // Jika data tidak ditemukan
                {
                    lblName.Text = string.Empty;
                    lblFakultas.Text = string.Empty;
                    lblNIM.Text = string.Empty;
                    lblJurusan.Text = string.Empty;
                    lblPoin.Text = string.Empty;
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
    }
}
