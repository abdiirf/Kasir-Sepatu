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
    public partial class Utama : Form
    {
        public Utama()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Master button3 = new Master();
            this.Hide();
            button3.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transaksi button4 = new Transaksi();
            this.Hide();
            button4.Show(this);
        }
    }
}
