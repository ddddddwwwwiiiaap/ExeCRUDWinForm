using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeCRUDWinForm
{
    public partial class DataGridViewTransaksi : Form
    {
        public DataGridViewTransaksi()
        {
            InitializeComponent();
        }

        private void DataGridViewTransaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orange_SupermarketDataSet2.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.orange_SupermarketDataSet2.Transaksi);

        }
    }
}
