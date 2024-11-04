
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
    public partial class MahasiswaPage : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        private string parameter;
        public MahasiswaPage(string id_pengguna)
        {
            alamat = "server=localhost; database=universitas; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
            parameter = id_pengguna;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage frmlogin = new LoginPage();
            frmlogin.Show();
            this.Hide();
        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisMahasiswa frmregisMHS = new RegisMahasiswa();
            frmregisMHS.Show();
            this.Hide();
        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisMonitor frmmonitor = new RegisMonitor();
            frmmonitor.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HalamanUtama halamanUtama = new HalamanUtama();
            halamanUtama.Show();
            this.Hide();
        }

        private void lblNamaMahasiswa_Click(object sender, EventArgs e)
        {

        }

        private void lblValTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginMahasiswa loginMahasiswa = new LoginMahasiswa();
            loginMahasiswa.Show();
            this.Hide();
            parameter = "";
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void LoadPoinMahasiswa(string idPengguna)
        {
            try
            {
                query = "SELECT jumlah_poin, poin_sisa FROM tb_poin WHERE id_mahasiswa = @id_mahasiswa";
                ds.Clear();
                koneksi.Open();

                using (MySqlCommand perintah = new MySqlCommand(query, koneksi))
                {
                    perintah.Parameters.AddWithValue("@id_mahasiswa", idPengguna);
                    adapter = new MySqlDataAdapter(perintah);
                    adapter.Fill(ds);
                }

                koneksi.Close();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow kolom = ds.Tables[0].Rows[0];

                    // Tampilkan Total dan Dikerjakan pada label yang sesuai
                    int jumlahPoin = Convert.ToInt32(kolom["jumlah_poin"]);
                    int poinSisa = Convert.ToInt32(kolom["poin_sisa"]);

                    // Tampilkan Total dan Dikerjakan pada label yang sesuai
                    lblValTotal.Text = jumlahPoin.ToString();
                    lblValDikerjakan.Text = (jumlahPoin - poinSisa).ToString();
                }
                else
                {
                    MessageBox.Show("Data Poin Tidak Ada!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                koneksi.Close();
            }
        }


        private void MahasiswaPage_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(parameter))
                {
                    query = "SELECT * FROM tb_mahasiswa WHERE id_pengguna = @id_pengguna";
                    ds.Clear();
                    koneksi.Open();

                    using (MySqlCommand perintah = new MySqlCommand(query, koneksi))
                    {
                        perintah.Parameters.AddWithValue("@id_pengguna", parameter);
                        adapter = new MySqlDataAdapter(perintah);
                        adapter.Fill(ds);
                    }

                    koneksi.Close();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow kolom = ds.Tables[0].Rows[0];

                        // Info Pribadi
                        lblValNamaLengkap.Text = kolom["nama_mahasiswa"].ToString();
                        lblValNim.Text = kolom["nim"].ToString();
                        lblValJurusan.Text = kolom["prodi"].ToString();
                        lblValFakultas.Text = kolom["fakultas"].ToString();

                        // Nama Mahasiswa di kanan atas
                        lblNamaMahasiswa.Text = kolom["nama_mahasiswa"].ToString();

                        // Load data poin mahasiswa
                        LoadPoinMahasiswa(parameter);
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada!");
                    }
                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                koneksi.Close();
            }
        }



    }
}
