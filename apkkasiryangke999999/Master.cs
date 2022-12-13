using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apkkasiryangke999999
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Identitas button7 = new Identitas();
            this.Hide();
            button7.Show(this);

            try
            {
                Koneksi.conn.Open();
                MessageBox.Show("Koneksi Database Berhasil");
            }
            catch (Exception)
            {

                MessageBox.Show("Koneksi Gagal");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Kategori button8 = new Kategori();
            this.Hide();
            button8.Show(this);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Barang button9 = new Barang();
            this.Hide();
            button9.Show(this);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Pelanggan button10 = new Pelanggan();
            this.Hide();
            button10.Show(this);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Utama button12 = new Utama();
            this.Hide();
            button12.Show(this);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transaksi button4 = new Transaksi();
            this.Hide();
            button4.Show(this);
        }
    }
}
