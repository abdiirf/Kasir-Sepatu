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
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Utama button14 = new Utama();
            this.Hide();
            button14.Show(this);
        }
    }
}
