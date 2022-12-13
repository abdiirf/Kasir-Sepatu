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
    public partial class Pelanggan : Form
    {
        public Pelanggan()
        {
            InitializeComponent();
        }

        private void Pelanggan_Load(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            //MessageBox.Show("Koneksi Sukses");
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tbl_pelanggan``", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            yaya3.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }
    }
}
