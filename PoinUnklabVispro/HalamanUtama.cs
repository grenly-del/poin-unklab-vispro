﻿using System;
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
    public partial class HalamanUtama : Form
    {
        public HalamanUtama()
        {
            InitializeComponent();
        }

        private void HalamanUtama_Load(object sender, EventArgs e)
        {

        }

        private void btnMahasiswa_Click(object sender, EventArgs e)
        {
            LoginMahasiswa frmlgnmhs = new LoginMahasiswa();
            frmlgnmhs.Show();
            this.Hide();
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            LoginMonitor frmlgnmonitor = new LoginMonitor();
            frmlgnmonitor.Show();
            this.Hide();
        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisMonitor regisMonitor = new RegisMonitor();
            regisMonitor.Show();
            this.Hide();
        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisMahasiswa regisMahasiswa = new RegisMahasiswa();
            regisMahasiswa.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
