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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRegisMhs.Text != "" && txtPasswordMhs.Text != "")
                {
                    query = string.Format("select * from tb_mahasiswa where no_regis = '{0}'", txtRegisMhs.Text);
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
                            if (sandi == txtPasswordMhs.Text)
                            {
                                MahasiswaPage frmMain = new MahasiswaPage(kolom["id_pengguna"].ToString());
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
