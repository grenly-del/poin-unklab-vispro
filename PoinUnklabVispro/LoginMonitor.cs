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

namespace PoinUnklabVispro
{
    public partial class LoginMonitor : Form
    {
        private string idMonitor;
        private readonly string alamat;

        public LoginMonitor()
        {
            alamat = "server=localhost; database=universitas; username=root; password=;";
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegisMonitor.Text) || string.IsNullOrWhiteSpace(txtPasswordMonitor.Text))
            {
                MessageBox.Show("Masukkan No. Regis dan Password!");
                return;
            }

            string query = "SELECT * FROM tb_monitor WHERE no_regis = @no_regis";
            using (var koneksi = new MySqlConnection(alamat))
            {
                try
                {
                    koneksi.Open();
                    using (MySqlCommand perintah = new MySqlCommand(query, koneksi))
                    {
                        perintah.Parameters.AddWithValue("@no_regis", txtRegisMonitor.Text);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(perintah))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds);

                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                DataRow kolom = ds.Tables[0].Rows[0];
                                string sandi = kolom["password"].ToString();

                                if (sandi == txtPasswordMonitor.Text) // Bisa ditambahkan hashing untuk keamanan lebih
                                {
                                    idMonitor = kolom["id_monitor"].ToString(); // Simpan id_monitor
                                    MonitorPages frmMain = new MonitorPages(idMonitor); // Kirim id_monitor ke MonitorPages
                                    frmMain.Show();
                                    this.Hide();  // Sembunyikan form login
                                }
                                else
                                {
                                    MessageBox.Show("Anda salah input password");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No. Regis tidak ditemukan");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

        private void LoginMonitor_Load(object sender, EventArgs e)
        {
            // Event handler kosong jika tidak ada fungsi
        }

        private void mahasiswaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginMahasiswa loginMahasiswa = new LoginMahasiswa();
            loginMahasiswa.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HalamanUtama halamanUtama = new HalamanUtama();
            halamanUtama.Show();

        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisMahasiswa regisMahasiswa = new RegisMahasiswa();
            regisMahasiswa.Show();
            this.Hide();
        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisMonitor regisMonitor = new RegisMonitor();
            regisMonitor.Show();
            this.Hide();
        }
    }
}
