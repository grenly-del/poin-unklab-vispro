
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

        private void MahasiswaPage_Load(object sender, EventArgs e)
        {
            try
            {
                if (parameter != "")
                {
                    query = string.Format("select * from tb_mahasiswa where id_pengguna = '{0}'", parameter);
                    ds.Clear();
                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    perintah.ExecuteNonQuery();
                    adapter.Fill(ds);
                    koneksi.Close();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow kolom in ds.Tables[0].Rows)
                        {
                            lblValNamaLengkap.Text = kolom["nama_mahasiswa"].ToString();
                            lblValNim.Text = kolom["nim"].ToString();
                            lblValJurusan.Text = kolom["prodi"].ToString();
                            lblValFakultas.Text = kolom["fakultas"].ToString();

                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Ada !!");
                        
                    }

                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
