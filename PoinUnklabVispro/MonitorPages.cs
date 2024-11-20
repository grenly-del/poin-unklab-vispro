using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PoinUnklabVispro
{
    public partial class MonitorPages : Form
    {
        private MySqlConnection koneksi;
        private List<System.Windows.Forms.CheckBox> checkBoxes; // Menyimpan referensi ke semua checkbox
        private List<string> mahasiswaIds;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        private string idMonitor;
        public MonitorPages(string idMonitor)
        {
            InitializeComponent();
            alamat = "server=localhost; database=universitas; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            checkBoxes = new List<System.Windows.Forms.CheckBox>();
            mahasiswaIds = new List<string>();
            //TableInformasiMHS.ColumnCount = 5; // 5 kolom: Nama, NIM, Poin, Pekerjaan, Status
            //TableInformasiMHS.RowCount = 1; // Mulai dengan 1 baris (untuk header)
            //TableInformasiMHS.AutoSize = true;
            //TableInformasiMHS.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            //// Mengatur Ukuran Kolom
            //TableInformasiMHS.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            TampilkanDataMahasiswa();
            //AddHeaderToTable(); // Buat Headnya
            this.idMonitor = idMonitor;
            // Jalankan
        }

        //private void AddHeaderToTable()
        //{
        //    TableInformasiMHS.Controls.Add(new Label() { Text = "Nama", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 0, 0);
        //    TableInformasiMHS.Controls.Add(new Label() { Text = "NIM", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 1, 0);
        //    TableInformasiMHS.Controls.Add(new Label() { Text = "No Regis", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 2, 0);
        //    TableInformasiMHS.Controls.Add(new Label() { Text = "Poin", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 3, 0);
        //    TableInformasiMHS.Controls.Add(new Label() { Text = "Status", TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 4, 0);
        //}
        private void TampilkanDataMahasiswa()
        {


            //try
            //{
            //    // Membuka koneksi ke database
            //    koneksi.Open();
            //    // Query untuk mengambil data mahasiswa

            //    MySqlCommand cmd = new MySqlCommand("SELECT tb_mahasiswa.id_pengguna, tb_mahasiswa.nama_mahasiswa AS nama_mahasiswa, pe.jumlah_poin_req AS poin, pe.jenis_pekerjaan as pekerjaan " +
            //        "FROM tb_mahasiswa " +
            //        "JOIN tb_kerja AS pe ON pe.id_mahasiswa = tb_mahasiswa.id_pengguna", koneksi);
            //    MySqlDataReader reader = cmd.ExecuteReader();

            //    int posY = 450; // Posisi Y awal untuk setiap baris data
            //    int margin = 20; // Jarak antar baris data

            //    while (reader.Read())
            //    {

            //        mahasiswaIds.Add(reader["id_pengguna"].ToString());
            //        // Membuat label untuk Nama
            //        Label labelNama = new Label();
            //        labelNama.Text = reader["nama_mahasiswa"].ToString();
            //        labelNama.Location = new Point(25, posY);
            //        labelNama.AutoSize = true;
            //        this.Controls.Add(labelNama);

            //        // Membuat label untuk Umur
            //        Label labelUmur = new Label();
            //        labelUmur.Text = reader["poin"].ToString();
            //        labelUmur.Location = new Point(173, posY);
            //        labelUmur.AutoSize = true;
            //        this.Controls.Add(labelUmur);

            //        // Membuat label untuk jenis pekerjaan
            //        Label jkerja = new Label();
            //        jkerja.Text = reader["pekerjaan"].ToString();
            //        jkerja.Location = new Point(253, posY);
            //        jkerja.AutoSize = true;
            //        this.Controls.Add(jkerja);

            //        // Membuat Radio Button untuk setiap data mahasiswa
            //        System.Windows.Forms.CheckBox radiobtn1 = new System.Windows.Forms.CheckBox();
            //        radiobtn1.Location = new Point(425, posY);
            //        radiobtn1.AutoSize = true;
            //        this.Controls.Add(radiobtn1);
            //        checkBoxes.Add(radiobtn1);

            //        // Membuat Radio Button untuk setiap data mahasiswa
            //        System.Windows.Forms.CheckBox radiobtn2 = new System.Windows.Forms.CheckBox();
            //        radiobtn2.Location = new Point(480, posY);
            //        radiobtn2.AutoSize = true;
            //        this.Controls.Add(radiobtn2);
            //        checkBoxes.Add(radiobtn2);
            //        // RadioButton untuk Setuju
            //        //System.Windows.Forms.RadioButton radioButtonSetuju = new System.Windows.Forms.RadioButton();
            //        //radioButtonSetuju.Location = new Point(360, posY);
            //        //radioButtonSetuju.AutoSize = true;
            //        //radioButtonSetuju.Text = "Setuju";
            //        //radioButtonSetuju.GroupName = "group_" + reader["id_pengguna"].ToString();
            //        //radioButtonSetuju.CheckedChanged += RadioButton_CheckedChanged;
            //        //this.Controls.Add(radioButtonSetuju);

            //        //// RadioButton untuk Tidak Setuju
            //        //RadioButton radioButtonTidakSetuju = new RadioButton();
            //        //radioButtonTidakSetuju.Location = new Point(420, posY); // Atur posisi sesuai kebutuhan
            //        //radioButtonTidakSetuju.AutoSize = true;
            //        //radioButtonTidakSetuju.Text = "Tidak Setuju";
            //        //radioButtonTidakSetuju.GroupName = "group_" + reader["id_pengguna"].ToString();
            //        //radioButtonTidakSetuju.CheckedChanged += RadioButton_CheckedChanged;
            //        //this.Controls.Add(radioButtonTidakSetuju);



            //        // Memperbarui posisi Y untuk baris data berikutnya
            //        posY += margin;
            //    }


            //    reader.Close();
            //    koneksi.Close();

            //    //Membuat tombol "Submit" setelah data selesai ditampilkan
            //    Button btnSubmit = new Button();
            //    btnSubmit.Text = "Submit";
            //    btnSubmit.Size = new Size(100, 30);
            //    btnSubmit.Location = new Point(20, posY + 20); // Letakkan di bawah data yang terakhir ditampilkan
            //    btnSubmit.Click += new EventHandler(BtnSubmit_Click); // Menambahkan event handler untuk tombol
            //    this.Controls.Add(btnSubmit);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            //}


            try
            {
                // Membuka koneksi ke database
                koneksi.Open();

                // Query untuk mengambil data mahasiswa
                MySqlCommand monitorCommand = new MySqlCommand(
                    "SELECT tb_mahasiswa.id_pengguna, tb_mahasiswa.nama_mahasiswa AS nama_mahasiswa, pe.jumlah_poin_req AS poin, pe.jenis_pekerjaan as pekerjaan " +
                    "FROM tb_mahasiswa " +
                    "JOIN tb_kerja AS pe ON pe.id_mahasiswa = tb_mahasiswa.id_pengguna",
                    koneksi);

                MySqlDataAdapter adapter = new MySqlDataAdapter(monitorCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind data ke DataGridView
                dataGridView2.DataSource = dataTable;

                // Set kolom agar otomatis menyesuaikan lebar kontennya
                dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                koneksi.Close();

                
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show("Error: " + ex.Message);
            }

            //try
            //{
            //    // Mengatur form agar auto size
            //    this.AutoSize = true;
            //    this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            //    // Membuka koneksi ke database
            //    koneksi.Open();

            //    // Query untuk mengambil data mahasiswa
            //    MySqlCommand cmd = new MySqlCommand(
            //        "SELECT tb_mahasiswa.id_pengguna, tb_mahasiswa.nama_mahasiswa AS nama_mahasiswa, pe.jumlah_poin_req AS poin, pe.jenis_pekerjaan as pekerjaan " +
            //        "FROM tb_mahasiswa " +
            //        "JOIN tb_kerja AS pe ON pe.id_mahasiswa = tb_mahasiswa.id_pengguna",
            //        koneksi);
            //    MySqlDataReader reader = cmd.ExecuteReader();

            //    int posY = 450; // Posisi Y awal untuk setiap baris data
            //    int margin = 20; // Jarak antar baris data

            //    while (reader.Read())
            //    {
            //        mahasiswaIds.Add(reader["id_pengguna"].ToString());

            //        // Membuat label untuk Nama
            //        Label labelNama = new Label();
            //        labelNama.Text = reader["nama_mahasiswa"].ToString();
            //        labelNama.Location = new Point(25, posY);
            //        labelNama.AutoSize = true;
            //        this.Controls.Add(labelNama);

            //        // Membuat label untuk Poin
            //        Label labelPoin = new Label();
            //        labelPoin.Text = reader["poin"].ToString();
            //        labelPoin.Location = new Point(173, posY);
            //        labelPoin.AutoSize = true;
            //        this.Controls.Add(labelPoin);

            //        // Membuat label untuk Jenis Pekerjaan
            //        Label jkerja = new Label();
            //        jkerja.Text = reader["pekerjaan"].ToString();
            //        jkerja.Location = new Point(253, posY);
            //        jkerja.AutoSize = true;
            //        this.Controls.Add(jkerja);

            //        // Membuat CheckBox untuk persetujuan
            //        System.Windows.Forms.CheckBox checkBoxSetuju = new System.Windows.Forms.CheckBox();
            //        checkBoxSetuju.Location = new Point(425, posY);
            //        checkBoxSetuju.AutoSize = true;
            //        this.Controls.Add(checkBoxSetuju);
            //        checkBoxes.Add(checkBoxSetuju);

            //        // Membuat CheckBox untuk tidak setuju
            //        System.Windows.Forms.CheckBox checkBoxTidakSetuju = new System.Windows.Forms.CheckBox();
            //        checkBoxTidakSetuju.Location = new Point(480, posY);
            //        checkBoxTidakSetuju.AutoSize = true;
            //        this.Controls.Add(checkBoxTidakSetuju);
            //        checkBoxes.Add(checkBoxTidakSetuju);

            //        // Memperbarui posisi Y untuk baris data berikutnya
            //        posY += margin;
            //    }

            //    reader.Close();
            //    koneksi.Close();

            //    // Membuat tombol "Submit" setelah data selesai ditampilkan
            //    Button btnSubmit = new Button();
            //    btnSubmit.Text = "Submit";
            //    btnSubmit.Size = new Size(100, 30);
            //    btnSubmit.Location = new Point(20, posY + 20); // Letakkan di bawah data yang terakhir ditampilkan
            //    btnSubmit.Click += new EventHandler(BtnSubmit_Click); // Menambahkan event handler untuk tombol
            //    this.Controls.Add(btnSubmit);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            //}

        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HalamanUtama halamanUtama = new HalamanUtama();
            halamanUtama.Show();
            this.Hide();
        }

        private void TableInformasiMHS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TambahPoin addPoinFrm = new TambahPoin(idMonitor);
            addPoinFrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDataMahasiswa frmDataMahasiswa = new FrmDataMahasiswa();
            frmDataMahasiswa.Show();
        }
        private System.Windows.Forms.RadioButton radioButtonSetuju;
        private System.Windows.Forms.RadioButton radioButtonTidakSetuju;
        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtSearchID.Text != "")
                {
                    string cariQuery = "select * from tb_kerja where id_mahasiswa = @id_mahasiswa";
                    ds.Clear();
                    koneksi.Open();
                    MySqlCommand deleteCmd = new MySqlCommand(cariQuery, koneksi);
                    deleteCmd.Parameters.AddWithValue("@id_mahasiswa", Convert.ToInt32(txtSearchID.Text));
                    adapter = new MySqlDataAdapter(deleteCmd);
                    deleteCmd.ExecuteNonQuery();
                    adapter.Fill(ds);
                    koneksi.Close();
                    if (ds.Tables[0].Rows.Count > 0)
                    {


                        radioButtonSetuju = new System.Windows.Forms.RadioButton();
                        radioButtonSetuju.Location = new Point(270, 397);
                        radioButtonSetuju.AutoSize = true;
                        radioButtonSetuju.Text = "Setuju";
                        this.Controls.Add(radioButtonSetuju);

                        // RadioButton untuk Tidak Setuju
                        radioButtonTidakSetuju = new System.Windows.Forms.RadioButton();
                        radioButtonTidakSetuju.Location = new Point(350, 397); // Atur posisi sesuai kebutuhan
                        radioButtonTidakSetuju.AutoSize = true;
                        radioButtonTidakSetuju.Text = "Tidak Setuju";
                        this.Controls.Add(radioButtonTidakSetuju);

                        // Button Submit
                        Button btnSubmit = new Button();
                        btnSubmit.Text = "Submit";
                        btnSubmit.Location = new Point(440, 395); // Posisi tombol Submit
                        btnSubmit.Click += (s, eArgs) => BtnSubmit_Click(s, eArgs, Convert.ToInt32(txtSearchID.Text));
                        this.Controls.Add(btnSubmit);

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
                MessageBox.Show("Error: " + ex.Message);
            }
            
         }
        private void BtnSubmit_Click(object sender, EventArgs e, int idMhs)
        {
            try
            {
                koneksi.Open();

                int idMahasiswa = idMhs; // Ambil ID mahasiswa sesuai index


                if (radioButtonSetuju.Checked) // Jika checkbox 1 (Berhasil) tercentang
                {
                    string query = "UPDATE tb_poin SET status = @status, poin_sisa = GREATEST(poin_sisa - (SELECT jumlah_poin_req FROM tb_kerja WHERE id_mahasiswa = @id_mahasiswa LIMIT 1), 0) WHERE id_mahasiswa = @id_mahasiswa";
                    MySqlCommand cmd = new MySqlCommand(query, koneksi);
                    cmd.Parameters.AddWithValue("@status", "Berhasil");
                    cmd.Parameters.AddWithValue("@id_mahasiswa", idMahasiswa);
                    cmd.ExecuteNonQuery();

                    string deleteQuery = "DELETE FROM tb_kerja WHERE id_mahasiswa = @id_mahasiswa";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, koneksi);
                    deleteCmd.Parameters.AddWithValue("@id_mahasiswa", idMahasiswa);
                    deleteCmd.ExecuteNonQuery();
                    MessageBox.Show("Data disetujui" +
                        "");
                }
                else if (radioButtonTidakSetuju.Checked)
                {
                    string query = "UPDATE tb_poin SET status = @status WHERE id_mahasiswa = @id_mahasiswa";
                    MySqlCommand cmd = new MySqlCommand(query, koneksi);
                    cmd.Parameters.AddWithValue("@status", "Ditolak");
                    cmd.Parameters.AddWithValue("@id_mahasiswa", idMahasiswa);
                    cmd.ExecuteNonQuery();

                    string deleteQuery = "DELETE FROM tb_kerja WHERE id_mahasiswa = @id_mahasiswa";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, koneksi);
                    deleteCmd.Parameters.AddWithValue("@id_mahasiswa", idMahasiswa);
                    deleteCmd.ExecuteNonQuery();
                    MessageBox.Show("Data tidak disetujui");
                }

                
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                koneksi.Close();
            }
        }

        private void MonitorPages_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                // Mendapatkan nama monitor
                MySqlCommand monitorCommand = new MySqlCommand(
                    "SELECT nama_monitor FROM tb_monitor WHERE id_monitor = @idMonitor", koneksi);
                monitorCommand.Parameters.AddWithValue("@idMonitor", idMonitor);
                MySqlDataReader monitorReader = monitorCommand.ExecuteReader();

                if (monitorReader.Read())
                {
                    lblnamaMonitor.Text = monitorReader["nama_monitor"].ToString();
                }

                monitorReader.Close();

                // Membuat query untuk mendapatkan data mahasiswa
                MySqlCommand mahasiswaCommand = new MySqlCommand(
                    "SELECT m.nama_mahasiswa as nama_mahasiswa, m.nim as nim, p.poin_sisa as jumlah_poin, p.status as status, m.no_regis as no_regis " +
                    "FROM tb_mahasiswa as m " +
                    "JOIN tb_poin as p ON p.id_mahasiswa = m.id_pengguna", koneksi);

                // Membaca data menggunakan DataAdapter untuk binding ke DataGridView
                MySqlDataAdapter adapter = new MySqlDataAdapter(mahasiswaCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind data ke DataGridView
                dataGridView1.DataSource = dataTable;

                koneksi.Close();
            }
            catch (Exception ex)
            {
                koneksi.Close();
                MessageBox.Show("Error: " + ex.Message);
            }

        }




    }
}
