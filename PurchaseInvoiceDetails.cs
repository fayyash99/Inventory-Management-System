using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class PurchaseInvoiceDetails : Sample2
    {
        public PurchaseInvoiceDetails()
        {
            InitializeComponent();
        }
        retrival r = new retrival();
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            r.getListWithTwoParameters("st_getPurchaseInvoiceList",purchaseDD, "Company","ID","@month",datePicker.Value.Month,"@year",datePicker.Value.Year);
        }
        public override void BackBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice obj = new PurchaseInvoice();
            MainClass.showWindows(obj, this, MDI.ActiveForm);
        }

        private void PurchaseInvoiceDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purchaseDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);
        }

        private void purchaseDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (purchaseDD.SelectedIndex != -1 && purchaseDD.SelectedIndex != 0)
            {
                float gt = 0;
                r.ShowPurchaseInvoiceDetails(Convert.ToInt64(purchaseDD.SelectedValue.ToString()),dataGridView1, mPIDGV, proIDGV, proGV, quanGV, pupGV, totGV);
                foreach (DataGridViewRow row in dataGridView1.Rows) 
                {
                    gt += Convert.ToSingle(row.Cells["totGV"].Value.ToString());
                }
                grossLabel.Text = gt.ToString();
                gt = 0;
            }
        }

        Insertion i = new Insertion();
        Updation u = new Updation();
        Deletion d = new Deletion();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1) 
            {
                if (e.ColumnIndex == 6) 
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    DialogResult dr = MessageBox.Show("Are you sure, you want to delete", row.Cells["proGV"].Value.ToString()+" from Purchase Invoice?\n\t\tWARNING\nDeletion of Product Will Effect Stock",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    int q;
                    if (dr == DialogResult.Yes ) 
                    {
                        using (TransactionScope sc = new TransactionScope()) 
                        {
                            i.InsertDeletedItem(Convert.ToInt64(purchaseDD.SelectedValue.ToString()), Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quanGV"].Value.ToString()), retrival.USER_ID, DateTime.Today);

                            object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                            if (ob != null)
                            {
                                q = Convert.ToInt32(ob);
                                q -= Convert.ToInt32(row.Cells["quanGV"].Value.ToString());
                                u.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), q);
                                float tot = Convert.ToSingle(grossLabel.Text) - Convert.ToSingle(row.Cells["totGV"].Value.ToString());
                                grossLabel.Text = tot.ToString();
                                d.Delete(Convert.ToInt64(row.Cells["mPIDGV"].Value.ToString()), "st_deleteProductFromPID", "@mPID");
                                dataGridView1.Rows.Remove(row);
                            }
                            sc.Complete();
                        }
                    }
                }
            }
        }
    }
}
