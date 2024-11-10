
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
        private string pekerjaanDipilih;
        private int poinPerJam;
        private int idKerja;

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


                    int jumlahPoin = Convert.ToInt32(kolom["jumlah_poin"]);
                    int poinSisa = Convert.ToInt32(kolom["poin_sisa"]);
                    int poinDitebus = jumlahPoin - poinSisa;
                    int poinSaatIni = poinSisa;
                    
                    
                    lblValTotalPoin.Text = jumlahPoin.ToString();
                    lblValPoinDitebus.Text = poinDitebus.ToString();
                    lblValPoinSaatIni.Text = poinSaatIni.ToString();

                    lblValTotal.Text = poinSaatIni.ToString();
                    lblValDikerjakan.Text = poinDitebus.ToString();
                }
                else
                {   
                    // tampilan jika tidak ada data poin
                    lblValTotalPoin.Text = "0";
                    lblValPoinDitebus.Text = "0";
                    lblValPoinSaatIni.Text = "0";

                    lblValTotal.Text = "0";
                    lblValDikerjakan.Text = "0";
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


        private void lblValTotalPoin_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPerkerjaan1.Checked)
            {
                pekerjaanDipilih = "Menggali Lubang";
                poinPerJam = 5;
                idKerja = 1;
            }else if (btnPekerjaan2.Checked)
            {
                pekerjaanDipilih = "Membersihkan Lingkungan";
                poinPerJam = 4;
                idKerja = 1;
            }else if (btnPekerjaan3.Checked)
            {
                pekerjaanDipilih = "Membersihkan Toilet";
                poinPerJam = 3;
                idKerja = 1;
            }
            else if (btnPekerjaan4.Checked)
            {
                pekerjaanDipilih = "Membersihkan Parkiran";
                poinPerJam = 2;
                idKerja = 1;
            }
        }

        private void btnKirimPermintaan_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(pekerjaanDipilih) || string.IsNullOrEmpty(txtJamKerja.Text))
            {
                MessageBox.Show("Pilih pekerjaan dan masukkan jam kerja!");
                return;
            }

            int jamKerja;
            if (!int.TryParse(txtJamKerja.Text, out jamKerja) || jamKerja <= 0)
            {
                MessageBox.Show("Masukkan jam kerja yang valid!");
                return;
            }

            int poinDikerjakan = poinPerJam * jamKerja;


            try
            {
                koneksi.Open();

                int id_mhs = Convert.ToInt32(parameter);
                MessageBox.Show("Type " + id_mhs.GetType());

                // Cek apakah id_mahasiswa sudah ada di tabel tb_kerja
                string checkQuery = "SELECT COUNT(*) FROM tb_kerja WHERE id_mahasiswa = @id_mahasiswa";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, koneksi))
                {
                    checkCmd.Parameters.AddWithValue("@id_mahasiswa", id_mhs);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // Jika id_mahasiswa sudah ada, tampilkan pesan dan batalkan proses insert
                        MessageBox.Show("Gagal melakukan request: Data sudah ada.");
                        return;
                    }
                }

                // Jika id_mahasiswa belum ada, lakukan proses insert
                string query = "INSERT INTO tb_kerja (jenis_pekerjaan, id_mahasiswa, jumlah_poin_req) VALUES (@jenis_pekerjaan, @id_mahasiswa, @jumlah_poin_req)";
                using (MySqlCommand cmd = new MySqlCommand(query, koneksi))
                {
                    cmd.Parameters.AddWithValue("@jenis_pekerjaan", pekerjaanDipilih);
                    cmd.Parameters.AddWithValue("@id_mahasiswa", id_mhs);
                    cmd.Parameters.AddWithValue("@jumlah_poin_req", poinDikerjakan);
                    cmd.ExecuteNonQuery();
                }

                // Ubah status di tb_poin
                string queryUpdateStatus = "UPDATE tb_poin SET status = 'Menunggu' WHERE id_mahasiswa = @id_mahasiswa";
                using (MySqlCommand cmdUpdateStatus = new MySqlCommand(queryUpdateStatus, koneksi))
                {
                    cmdUpdateStatus.Parameters.AddWithValue("@id_mahasiswa", id_mhs);
                    cmdUpdateStatus.ExecuteNonQuery();
                }

                // Ambil status terbaru di tb_poin
                string queryStatus = "SELECT status FROM tb_poin WHERE id_mahasiswa = @id_mahasiswa";
                using (MySqlCommand cmdStatus = new MySqlCommand(queryStatus, koneksi))
                {
                    cmdStatus.Parameters.AddWithValue("@id_mahasiswa", id_mhs);
                    object statusResult = cmdStatus.ExecuteScalar();

                    // Menampilkan status pada lblApproval jika status ditemukan
                    if (statusResult != null)
                    {
                        string status = statusResult.ToString();
                        lblStatusApproval.Text = status;
                    }
                    else
                    {
                        lblStatusApproval.Text = "Status Tidak Ditemukan";
                    }
                }

                MessageBox.Show("Permintaan berhasil dikirim!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengirim permintaan: " + ex.Message);
            }
            finally
            {
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }
        }



        private void btnPekerjaan2_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPekerjaan2.Checked)
            {
                pekerjaanDipilih = "Membersihkan Lingkungan";
                poinPerJam = 4;
                idKerja = 2;
            }
        }

        private void btnPekerjaan3_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPekerjaan3.Checked)
            {
                pekerjaanDipilih = "Membersihkan Toilet";
                poinPerJam = 3;
                idKerja = 3;
            }
        }

        private void btnPekerjaan4_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPekerjaan4.Checked)
            {
                pekerjaanDipilih = "Membersihkan Parkiran";
                poinPerJam = 2;
                idKerja = 4;
            }

        }

        private void lblStatusApproval_Click(object sender, EventArgs e)
        {

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

                        // Menampilkan Info Mahasiswa
                        lblValNamaLengkap.Text = kolom["nama_mahasiswa"].ToString();
                        lblValNim.Text = kolom["nim"].ToString();
                        lblValJurusan.Text = kolom["prodi"].ToString();
                        lblValFakultas.Text = kolom["fakultas"].ToString();
                        lblNamaMahasiswa.Text = kolom["nama_mahasiswa"].ToString();
                        

                        // Memuat data poin mahasiswa
                        LoadPoinMahasiswa(parameter);

                        // Mengambil status dari tabel tb_poin
                        string queryStatus = "SELECT status FROM tb_poin WHERE id_mahasiswa = @id_mahasiswa";
                        using (MySqlCommand cmdStatus = new MySqlCommand(queryStatus, koneksi))
                        {
                            cmdStatus.Parameters.AddWithValue("@id_mahasiswa", parameter);
                            koneksi.Open();
                            object statusResult = cmdStatus.ExecuteScalar();
                            koneksi.Close();

                            // Menampilkan status pada lblApproval jika status ditemukan
                            if (statusResult != null)
                            {
                                string status = statusResult.ToString();
                                lblStatusApproval.Text = status;
                            }
                            else
                            {
                                lblStatusApproval.Text = "Status Tidak Ditemukan";
                            }
                        }
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
