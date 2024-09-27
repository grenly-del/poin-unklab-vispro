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

        private void btnRegis_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNama.Text != "" && txtPassword.Text != "" && txtNoRegis.Text != "" && txtNIM.Text != "")
                {
                    // Membuat objek Random
                    Random rnd = new Random();

                    // Menghasilkan angka random dari 4001 hingga 9999 (batas atasnya bisa kamu sesuaikan)
                    int id_pengguna = rnd.Next(4001, 10000);
                    query = string.Format("insert into tb_mahasiswa (id_pengguna, nama_mahasiswa, fakultas, prodi, password, no_regis, nim) values ('{0}','{1}','{2}','{3}','{4}', '{5}', '{6}');", id_pengguna, txtNama.Text, cbFakultas.SelectedItem.ToString(), cbJurusan.SelectedItem.ToString(), txtPassword.Text, txtNoRegis.Text, txtNIM.Text);


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Insert Data Suksess ...");
                        LoginPage frmlgn = new LoginPage();
                        frmlgn.Show();
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
