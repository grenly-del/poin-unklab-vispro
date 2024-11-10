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
    public partial class RegisMonitor : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public RegisMonitor()
        {
            alamat = "server=localhost; database=universitas; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisMahasiswa regMhs = new RegisMahasiswa();
            regMhs.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HalamanUtama halamanUtama = new HalamanUtama();
            halamanUtama.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNama.Text != "" && txtPassword.Text != "" && txtNoRegis.Text != "" && txtNIM.Text != "")
                {
                    // Membuat objek Random
                    Random rnd = new Random();

                    // Menghasilkan angka random dari 4001 hingga 9999 (batas atasnya bisa kamu sesuaikan)
                    int id_pengguna = rnd.Next(4001, 10000);
                    query = string.Format("insert into tb_monitor (id_monitor, nama_monitor, password, no_regis, nim) values ('{0}','{1}','{2}','{3}','{4}');", id_pengguna, txtNama.Text, txtPassword.Text, txtNoRegis.Text, txtNIM.Text);


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Monitor berhasil ditambahkan ...");
                        HalamanUtama halamanUtama = new HalamanUtama();
                        halamanUtama.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Gagal inser Data . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
