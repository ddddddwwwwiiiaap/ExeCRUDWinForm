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
    public partial class DataGridViewKasir : Form
    {
        public DataGridViewKasir()
        {
            InitializeComponent();
        }

        private void DataGridViewKasir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orange_SupermarketDataSet1.Kasir' table. You can move, or remove it, as needed.
            this.kasirTableAdapter.Fill(this.orange_SupermarketDataSet1.Kasir);

        }
    }
}
