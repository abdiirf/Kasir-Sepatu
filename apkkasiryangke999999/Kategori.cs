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
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }

        private void Kategori_Load(object sender, EventArgs e)
        {
            Koneksi.conn.Open();
            //MessageBox.Show("Koneksi Sukses");
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tbl_kategori`", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            yaya1.DataSource = ds.Tables[0];
            Koneksi.conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Identitas button3 = new Identitas();
            this.Hide();
            button3.Show(this);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Master button14 = new Master();
            this.Hide();
            button14.Show(this);
        }
    }
}
