using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Stocks : Sample2
    {
        public Stocks()
        {
            InitializeComponent();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {

           // r.ShowStocksDetails(dataGridView1, proIDGV, proGV, barcodeGV, expireGV, bprGV, spGV, catGV, quanGV, statusGV, finalGV);
        //
            base.AddBtn.Enabled = false;
            base.EditBtn.Enabled = false;
            base.SaveBtn.Enabled = false;
            base.DeleteBtn.Enabled = false;
        }
        public override void AddBtn_Click(object sender, EventArgs e)
        {

        }

        public override void EditBtn_Click(object sender, EventArgs e)
        {

        }

        public override void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        public override void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        retrival r = new retrival();
        public override void ViewBtn_Click(object sender, EventArgs e)
        {
            r.ShowStocksDetails(dataGridView1, proIDGV, proGV, barcodeGV, expireGV, bprGV, spGV, catGV, quanGV, statusGV, finalGV);
        }
    }
}
