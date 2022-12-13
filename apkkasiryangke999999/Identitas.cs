using MySql.Data.MySqlClient;
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
    public partial class Identitas : Form
    {
        private MySqlCommand cmd;

        public Identitas()
        {
            InitializeComponent();
        }

        void tampil()
        {
            try
            {
                //MessageBox.Show("Ini Muncul Saat FOrm dipanggil");

                Koneksi.conn.Open(); //ini membuka koneksi database

                //ini digunakan untuk mengambil data di tabel siswa
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `tbl_identitas`", Koneksi.conn);
                //membuat objek Dasa Set Baru
                DataSet ds = new DataSet();
                //ini digunakan untuk mengisi dataset dari Data Adapter
                da.Fill(ds);

                //Mengisi DataGrid Siswa dengan DataSet
                fuck.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Duh!!, Ada Error Nih");
            }
        }

        private void Identitas_Load(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            //MessageBox.Show("Koneksi Sukses");
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tbl_identitas`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            fuck.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void fuck_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = fuck.CurrentCell.RowIndex;
            label4.Text = fuck.Rows[baris].Cells[0].Value.ToString();
            textBox1.Text = fuck.Rows[baris].Cells[1].Value.ToString();
            textBox2.Text = fuck.Rows[baris].Cells[2].Value.ToString();
            textBox3.Text = fuck.Rows[baris].Cells[3].Value.ToString();
            textBox4.Text = fuck.Rows[baris].Cells[4].Value.ToString();
            textBox5.Text = fuck.Rows[baris].Cells[5].Value.ToString();
            textBox6.Text = fuck.Rows[baris].Cells[6].Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                cmd = new MySqlCommand("Delete`tbl_identitas` WHERE `tbl_identitas`.`id` = '" + label10.Text + "`", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Delete Data");
                Koneksi.conn.Close();

                tampil();
            }
            catch (Exception)
            {

                MessageBox.Show("Delete Data Gagal");
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                cmd = new MySqlCommand("INSERT INTO `tbl_identitas` (`id_identitas`, `nama_toko`, `alamat_toko`, `no_telp`, `caption1`, `caption2`, caption3`) VALUES (NULL, '" + textBox1 + "', '" + textBox2 + "', '" + textBox3 + "', '" + textBox4 + "', '" + textBox5 + "', '" + textBox6 + "', '" + textBox7 + "', '" + "');", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Submit Data");
                Koneksi.conn.Close();

                tampil();
            }
            catch (Exception)
            {

                MessageBox.Show("Submit Data Gagal");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Master button13 = new Master();
            this.Hide();
            button13.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kategori button4 = new Kategori();
            this.Hide();
            button4.Show(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                cmd = new MySqlCommand("INSERT INTO `tbl_identitas` (`id`, `Nama`, `Kelas`, `Absen`) VALUES (NULL, '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "');", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Siswa");
                Koneksi.conn.Close();

                tampil();
            }
            catch (Exception)
            {

                MessageBox.Show("Tambah Data Gagal");
            }
        }
    }
}