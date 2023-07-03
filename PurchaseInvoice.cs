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
using System.Transactions;

namespace Inventory_Management_System
{
    public partial class PurchaseInvoice : Sample2
    {
        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        retrival r = new retrival();
        int productID;
        float gt, tot;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            r.getList("st_getSupplierList", supplierDD, "Company", "ID");
        }

        string[] productARR = new string[3];
        private void barcodeTXT_TextChanged(object sender, EventArgs e)
        {
            if (barcodeTXT.Text != "")
            {
                productARR = r.getProductWRTbarcode(barcodeTXT.Text);
                productID = Convert.ToInt32(productARR[0]);
                productTXT.Text = productARR[1];
                string barco = productARR[2];
                // productID = Convert.ToInt32(productARR[0]);
                productTXT.Enabled = false;
                if (barco != null)
                {
                    pupTXT.Focus();
                }
            }
            else
            {
                productID = 0;
                productTXT.Text = "";
                pupTXT.Text = "";
                Array.Clear(productARR, 0, productARR.Length);
            }

        }

        private void quantityTXT_TextChanged(object sender, EventArgs e)
        {
            if (quantityTXT.Text != "")
            {
                if (rg.Match(quantityTXT.Text).Success)
                {
                    float quan, price, tot;
                    quan = Convert.ToSingle(quantityTXT.Text);
                    price = Convert.ToSingle(pupTXT.Text);
                    tot = quan * price;
                    totLabel.Text = tot.ToString("#########.##");
                }
                else
                {
                    quantityTXT.SelectAll();
                }
            }
            else
            {
                totLabel.Text = "0.00";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex != -1 && e.ColumnIndex != -1)
            //{
            //    if (e.ColumnIndex == 5)
            //    {
            //        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            //        gt -= Convert.ToSingle(row.Cells["totGV"].Value.ToString());
            //        grossLabel.Text = gt.ToString();
            //        dataGridView1.Rows.Remove(row);
            //    }
            //}
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            //for supplier
            if (supplierDD.SelectedIndex == -1) { supplierErrorLabel.Visible = true; }
            else { supplierErrorLabel.Visible = false; }
            //for quantity
            if (quantityTXT.Text == "") { quantityErrorLabel.Visible = true; }
            else { quantityErrorLabel.Visible = false; }
            //for barcode
            if (barcodeTXT.Text == "") { barErrorLabel.Visible = true; }
            else { barErrorLabel.Visible = false; }

            if (supplierErrorLabel.Visible || quantityErrorLabel.Visible || barErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields With * are mandatory", "stop", "Error");
            }
            else
            {
                dataGridView1.Rows.Add(productID, productTXT.Text, quantityTXT.Text, pupTXT.Text, totLabel.Text);
                gt += Convert.ToSingle(totLabel.Text);
                grossLabel.Text = gt.ToString();
                productID = 0;
                productTXT.Text = "";
                quantityTXT.Text = "";
                pupTXT.Text = "";
                barcodeTXT.Text = "";
                totLabel.Text = "0.00";
                Array.Clear(productARR, 0, productARR.Length);
            }
        }
        public override void AddBtn_Click(object sender, EventArgs e)
        {

        }

        public override void EditBtn_Click(object sender, EventArgs e)
        {

        }

        int co;
        Updation u = new Updation();
        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            { 
                Int64 purchaseInvoiceID;
                Insertion i = new Insertion();
                using (TransactionScope sc = new TransactionScope())
                {
                    purchaseInvoiceID = i.InsertPurchaseInvoice(DateTime.Today, retrival.USER_ID, Convert.ToInt32(supplierDD.SelectedValue));
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        co += i.InsertPurchaseInvoiceDetails(purchaseInvoiceID, Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quanGV"].Value.ToString()), Convert.ToSingle(row.Cells["totGV"].Value.ToString()));
                        object[] arr = r.checkProductPriceExistance(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                        if (arr[3] != null)
                        {
                            float disPercentage = Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) * Convert.ToSingle(arr[3].ToString())/100;
                            float profitPercentage = Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) * Convert.ToSingle(arr[4].ToString()) / 100;
                            float totalAmount = Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) + profitPercentage - disPercentage;
                            u.updateProductPrice(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["pupGV"].Value.ToString()));
                        }
                        else
                        {
                            //check
                            i.InsertProductPrice(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["pupGV"].Value.ToString()));
                        }
                        int q;
                        object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                        if (ob != null && (int)ob!=0)
                        {
                            q = Convert.ToInt32(ob);
                            q += Convert.ToInt32(row.Cells["quanGV"].Value.ToString());
                            u.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()),q);
                        }
                        else 
                        {
                            i.InsertStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quanGV"].Value.ToString()));
                        }
                    }
                    if (co > 0)
                    {
                        MainClass.ShowMSG("Purchase Invoice Created SuccessFully", "Success", "Success");
                    }
                    else
                    {
                        MainClass.ShowMSG("Unable Purchase Invoice Created SuccessFully", "Error", "Error");
                    }
                    sc.Complete();
                }
            }
        }

        public override void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pupTXT_TextChanged(object sender, EventArgs e)
        {
            if(pupTXT.Text != "") 
            {
                if (!rg.Match(pupTXT.Text).Success) 
                {
                    pupTXT.Text = "";
                    pupTXT.Focus();
                }
            }
        }

        string[] prodARR = new string[6];
        private void barcodeTXT_Validating(object sender, CancelEventArgs e)
        {
            //if (barcodeTXT.Text != "")
            //{
            //    productARR = r.getProductWRTbarcode(barcodeTXT.Text);
            //    productID = Convert.ToInt32(prodARR[0]);
            //    productTXT.Text = productARR[1];
            //    string barco = productARR[2];
            //   // productID = Convert.ToInt32(productARR[0]);
            //    productTXT.Enabled = false;
            //    if (barco != null)
            //    {
            //        pupTXT.Focus();
            //    }
            //}
            //else
            //{
            //    productID = 0;
            //    productTXT.Text = "";
            //    pupTXT.Text = "";
            //    Array.Clear(productARR, 0, productARR.Length);
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 5)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    gt -= Convert.ToSingle(row.Cells["totGV"].Value.ToString());
                    grossLabel.Text = gt.ToString();
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        public override void ViewBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceDetails pid = new PurchaseInvoiceDetails();
            MainClass.showWindows(pid, this, MDI.ActiveForm);
        }
    }
}
