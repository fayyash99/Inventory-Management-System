using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class SalesReturnWindow : Sample2
    {
        public SalesReturnWindow()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Int64 saleIDforInvoice;
        retrival r = new retrival();
        Regex rg = new Regex("^[0-9]+$");
        Hashtable ht = new Hashtable();
        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (saleIDtxt.Text != "")
            {
                if (rg.Match(saleIDtxt.Text).Success)
                {
                    saleIDforInvoice = Convert.ToInt64(saleIDtxt.Text);
                    r.ShowSalesDataViaID(Convert.ToInt64(saleIDtxt.Text), dataGridView1, salesIdGV, BarcodeGV, productGV,
                        quanGV, pRiceGV, perProDisGV, perProTotGV, TotDisGV, totAmtGV, AmtReceivedGV, AmtReturnGV,
                        dateGV, usrGV, payMethodGV, proIdGV);
                    if (dataGridView1.RowCount > 0)
                    {
                        dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells["dateGV"].Value);
                        userTxt.Text = dataGridView1.Rows[0].Cells["usrGV"].Value.ToString();
                        payTypeTxt.Text = dataGridView1.Rows[0].Cells["payMethodGV"].Value.ToString();
                    }
                }
                else
                {
                    saleIDtxt.Text = "";
                    saleIDtxt.Focus();
                    dateTimePicker1.Value = DateTime.Now;
                    userTxt.Text = "";
                    payTypeTxt.Text = "";
                }
            }
            else
            {
                //saleIDtxt.Text = "";
                //saleIDtxt.Focus();
                dateTimePicker1.Value = DateTime.Now;
                userTxt.Text = "";
                payTypeTxt.Text = "";
            }
        }
        Insertion i = new Insertion();
        Updation u = new Updation();


        SalesReturnReceiptWindow srrw = new SalesReturnReceiptWindow();
        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            if (AmtreturnTxt.Text != "" && ht.Count > 0 && saleIDtxt.Text != "")
            {
                DialogResult dr = MessageBox.Show("Are you sure to proceed?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (TransactionScope sc = new TransactionScope())
                    {
                        int x = 0;
                        foreach (DictionaryEntry de in ht)
                        {
                            x += i.insertReturnRefund(Convert.ToInt64(saleIDtxt.Text), DateTime.Now, retrival.USER_ID, Convert.ToInt64(de.Key), Convert.ToInt16(de.Value), Convert.ToSingle(AmtreturnTxt.Text));
                            int currentquantity = (int)r.getProductQuantity(Convert.ToInt32(de.Key));
                            int finalquantity = currentquantity - Convert.ToInt16(de.Value);
                            u.updateStock(Convert.ToInt32(de.Key), finalquantity);
                        }
                        if (x > 0)
                        {
                            DialogResult drr = MainClass.ShowMSG("Return and Refund Successfull", "Success", "Success");
                            if (drr == DialogResult.OK)
                            {
                                srrw.Show();
                            }
                            MainClass.ShowMSG("Return And Refund Successfully", "Success", "Success");
                            x = 0;
                            ht.Clear();
                        }
                        sc.Complete();
                    }
                }
            }
            else
            {
                MainClass.ShowMSG("Please Provide Complete Details", "Error", "Error");

            }
        }
        private void SalesReturnWindow_Load(object sender, EventArgs e)
        {
            saleIDtxt.Focus();
        }

        float amount_refund = 0;
        private void barcoDetxt_Validating(object sender, CancelEventArgs e)
        {
            if (barcoDetxt.Text != "")
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    using (TransactionScope sc = new TransactionScope())
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (barcoDetxt.Text == row.Cells["BarcodeGV"].Value.ToString())
                            {
                                DialogResult dr = MessageBox.Show("Are You Sure you Want to return " + row.Cells["productGV"].Value.ToString() + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dr == DialogResult.Yes)
                                {
                                    Int32 product_id = Convert.ToInt32(row.Cells["proIdGV"].Value.ToString());
                                    float product_price = Convert.ToSingle(row.Cells["pRiceGV"].Value.ToString());
                                    int product_quantity = Convert.ToInt32(row.Cells["quanGV"].Value.ToString()) - 1;
                                    amount_refund += product_price;
                                    AmtreturnTxt.Text = Math.Round(amount_refund, 0).ToString();
                                    if (product_quantity == 0)
                                    {
                                        if (ht.ContainsKey(row.Cells["proIdGV"].Value))
                                        {
                                            Int32 proIDht = Convert.ToInt32(row.Cells["proIdGV"].Value.ToString());
                                            ht[proIDht] = Convert.ToInt32(ht[proIDht]) - 1;
                                        }
                                        else
                                        {
                                            ht.Add(row.Cells["proIdGV"].Value, 1);
                                        }
                                        dataGridView1.Rows.Remove(row);
                                    }
                                    else
                                    {
                                        row.Cells["quanGV"].Value = product_quantity;
                                        row.Cells["perProTotGV"].Value = (Convert.ToSingle(row.Cells["pRiceGV"].Value.ToString()) * Convert.ToInt32(row.Cells["quanGV"].Value.ToString()));
                                        if (ht.ContainsKey(row.Cells["proIdGV"].Value))
                                        {
                                            Int32 proIDht = Convert.ToInt32(row.Cells["proIdGV"].Value.ToString());
                                            ht[proIDht] = Convert.ToInt32(ht[proIDht]) + 1;
                                        }
                                        else
                                        {
                                            ht.Add(row.Cells["proidGV"].Value, 1);
                                        }
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
