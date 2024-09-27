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

    public partial class LoginPage : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public LoginPage()
        {
            alamat = "server=localhost; database=universitas; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisMahasiswa frm = new RegisMahasiswa();
            frm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNoRegis.Text != "")
                {
                    query = string.Format("select * from tb_mahasiswa where no_regis = '{0}'", txtNoRegis.Text);
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
                            string sandi;
                            sandi = kolom["password"].ToString();
                            if (sandi == txtPassword.Text)
                            {
                                HalamanUtama frmMain = new HalamanUtama();
                                frmMain.Show();
                            }
                            else
                            {
                                MessageBox.Show("Anda salah input password");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("No.Regis tidak ditemukan");
                    }
                }
            }
            catch
            {

            }
        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisMonitor frm1 = new RegisMonitor();
            frm1.Show();
            this.Hide();
        }
    }
}
