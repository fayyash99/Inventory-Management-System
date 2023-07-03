using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Sales : Sample2
    {
        public Sales()
        {
            InitializeComponent();
        }
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        //int productID;

        private void Sales_Load(object sender, EventArgs e)
        {

        }
        
        string[] productARR = new string[6];
        retrival r = new retrival();
        float GROSS = 0;
        private void barCodetxt_TextChanged(object sender, EventArgs e)
        {
        }

        bool productCheck;
        private void barCodetxt_Validated(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 6) 
                {
                    grosstotaltxt.Text = "";
                    totaldiscounttxt.Text = "";
                    amounttxt.Text = "";
                    changetxt.Text = "";
                    float gt,total,disc;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int q = Convert.ToInt32(row.Cells["quanGV"].Value.ToString());
                    if (q == 1)
                    {
                        gt = Convert.ToSingle(grossLabel.Text);
                        gt = gt - Convert.ToSingle(row.Cells["totGV"].Value.ToString());
                        grossLabel.Text = gt.ToString();
                        dataGridView1.Rows.Remove(row);
                    }
                    else if (q > 1)
                    {
                        q--;
                        row.Cells["quanGV"].Value = q;
                        disc = Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) - Convert.ToSingle(productARR[4]);
                        row.Cells["discountGV"].Value = disc;
                        total = Convert.ToSingle(row.Cells["quanGV"].Value.ToString()) * Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) - disc;
                        row.Cells["totGV"].Value = total;
                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            GROSS += Convert.ToSingle(item.Cells["totGV"].Value.ToString());
                        }
                        grossLabel.Text = GROSS.ToString();
                        GROSS = 0;


                    }
                }
            }
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) 
            {
                float dis = 0,gross=0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dis += Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                    gross += Convert.ToSingle(row.Cells["totGV"].Value.ToString());
                }
                grosstotaltxt.Text = Math.Round(gross,0).ToString();
                totaldiscounttxt.Text = Math.Round(dis,0).ToString();
            }
        }

        private void amounttxt_TextChanged(object sender, EventArgs e)
        {
            if (amounttxt.Text != "")
            {
                if (!rg.Match(amounttxt.Text).Success)
                {
                    amounttxt.Text = "";
                    amounttxt.Focus();
                }
                else
                {

                }
            }
            else 
            {
                changetxt.Text = "";
            }
        }

        private void amounttxt_Validating(object sender, CancelEventArgs e)
        {
            if (amounttxt.Text != "" && grosstotaltxt.Text != "")
            {
                if (!(Convert.ToSingle(grosstotaltxt.Text) <= Convert.ToSingle(amounttxt.Text)))
                {
                    amounttxt.Text = "";
                    changetxt.Text = "";
                    amounttxt.Focus();
                }
                else 
                {
                    float amountgiven = Convert.ToSingle(amounttxt.Text);
                    float amounttoreturn = amountgiven - Convert.ToSingle(grosstotaltxt.Text);
                    changetxt.Text = Math.Round(amounttoreturn,0).ToString();
                }
            }
        }

        private void barCodetxt_Validating(object sender, CancelEventArgs e)
        {
            if (barCodetxt.Text != "")
            {
                grosstotaltxt.Text = "";
                totaldiscounttxt.Text = "";
                amounttxt.Text = "";
                changetxt.Text = "";
                int qCount = 0, sQuan = 0, nCount = 0;
                productARR = r.getProductWRTbarcode(barCodetxt.Text);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (productARR[0] == row.Cells["proIDGV"].Value.ToString())
                    {
                        qCount = qCount + Convert.ToInt32(row.Cells["quanGV"].Value.ToString());
                    }
                }
                sQuan = Convert.ToInt32(r.getProductQuantity(Convert.ToInt32(productARR[0])));
                nCount = sQuan - qCount;
                if (nCount <= 0)
                {

                }
                else
                {
                    if (dataGridView1.RowCount == 0)
                    {
                        dataGridView1.Rows.Add(Convert.ToInt32(productARR[0]), productARR[1], 1, Convert.ToSingle(productARR[3]), Math.Round(Convert.ToSingle(productARR[4]),2), Convert.ToSingle(productARR[3]));
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["proIDGV"].Value.ToString() == productARR[0])
                            {
                                productCheck = true;
                                break;
                            }
                            else
                            {
                                productCheck = false;
                            }
                        }
                        if (productCheck == true)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["proIDGV"].Value.ToString() == productARR[0])
                                {
                                    float disc = 0;
                                    row.Cells["quanGV"].Value = Convert.ToInt32(row.Cells["quanGV"].Value.ToString()) + 1;
                                    if (row.Cells["discountGV"].Value.ToString() != null)
                                    {
                                        disc = Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) + Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                                        row.Cells["discountGV"].Value = disc;
                                    }
                                    float tot = Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) * Convert.ToInt32(row.Cells["quanGV"].Value.ToString()) - Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                                    row.Cells["totGV"].Value = tot;
                                }

                            }
                        }
                        else
                        {
                            dataGridView1.Rows.Add(Convert.ToInt32(productARR[0]), productARR[1], 1, Convert.ToSingle(productARR[3]), productARR[4], Convert.ToSingle(productARR[5]));

                        }

                    }
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        GROSS += Convert.ToSingle(item.Cells["totGV"].Value.ToString());
                    }
                    grossLabel.Text = Math.Round(GROSS, 0).ToString();
                    GROSS = 0;
                    barCodetxt.Focus();
                    barCodetxt.Text = "";
                }

            }
        }

        Insertion i = new Insertion();
        private void payBtn_Click(object sender, EventArgs e)
        {
            if (amounttxt.Text != "" && totaldiscounttxt.Text != "" && grosstotaltxt.Text != "" && paymenttypeDD.SelectedIndex != -1 && changetxt.Text != "")
            {
                DialogResult dr = MessageBox.Show("\n\t Total Amount : "+grosstotaltxt.Text+"\n\tTotal Discount : "+totaldiscounttxt.Text+"\n\tAmount Given : "+amounttxt.Text+"\n\t Amount Return"+changetxt.Text+"\n\nAre you sure , Submit current Sales?\n", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    i.InsertSales(dataGridView1, "proIDGV", "quanGV","pupGV","discountGV", retrival.USER_ID, DateTime.Now, Convert.ToSingle(grosstotaltxt.Text), Convert.ToSingle(totaldiscounttxt.Text), Convert.ToSingle(amounttxt.Text), Convert.ToSingle(changetxt.Text),paymenttypeDD.SelectedItem.ToString());
                    MainClass.Enable_reset(groupBox2);
                    dataGridView1.Rows.Clear();
                    grossLabel.Text = "0.00";
                    SalesReport sr = new SalesReport();
                    sr.Show();
                }
            }
        }

        public override void ViewBtn_Click(object sender, EventArgs e)
        {
            viewSalesInvoices vsi = new viewSalesInvoices();
            MainClass.showWindows(vsi,this,MDI.ActiveForm);
        }
    }
}
