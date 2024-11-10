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

namespace PoinUnklabVispro
{
    public partial class LoginMahasiswa : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public LoginMahasiswa()
        {
            alamat = "server=localhost; database=universitas; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void LoginMahasiswa_Load(object sender, EventArgs e)
        {

        }

        private void monitorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginMonitor lgnmonitor = new LoginMonitor();
            lgnmonitor.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HalamanUtama halamanUtama = new HalamanUtama();
            halamanUtama.Show();
            this.Hide();
        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisMahasiswa lgnmhs = new RegisMahasiswa();
            lgnmhs.Show();
            this.Hide();

        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisMonitor lgnmonitor = new RegisMonitor();
            lgnmonitor.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtRegisMhs.Text) && !string.IsNullOrEmpty(txtPasswordMhs.Text))
                {
                    query = "SELECT * FROM tb_mahasiswa WHERE no_regis = @no_regis";
                    ds.Clear();
                    koneksi.Open();

                    using (MySqlCommand perintah = new MySqlCommand(query, koneksi))
                    {
                        perintah.Parameters.AddWithValue("@no_regis", txtRegisMhs.Text);
                        adapter = new MySqlDataAdapter(perintah);
                        adapter.Fill(ds);
                    }

                    koneksi.Close();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow kolom = ds.Tables[0].Rows[0];
                        string sandi = kolom["password"].ToString();

                        if (sandi == txtPasswordMhs.Text)
                        {
                            MahasiswaPage frmMain = new MahasiswaPage(kolom["id_pengguna"].ToString());
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
                        MessageBox.Show("No.Regis tidak ditemukan");
                    }
                }
                else
                {
                    MessageBox.Show("Masukkan No. Regis dan Password!");
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
