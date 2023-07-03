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
    public partial class ProductPricing : Sample2
    {
        retrival r = new retrival();
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        public ProductPricing()
        {
            InitializeComponent();
            //r.getList("st_getCategorieslist", categoryDD, "Category", "ID");
        }

        private void categoryDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryDD.SelectedIndex != -1)// && categoryDD.SelectedIndex != 0) 
            {
                r.ShowProductWRTCategory(Convert.ToInt32(categoryDD.SelectedValue.ToString()),dataGridView1,proIDGV,proGV,buyingPRGV,finalPRGV,discountGV,ProfitMarginGV);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["ProfitMarginGV"].Value != null && rg.Match(row.Cells["ProfitMarginGV"].Value.ToString()).Success)
                {
                    float buyingPrice = Convert.ToSingle(row.Cells["buyingPRGV"].Value.ToString());
                    float profitMargin = Convert.ToSingle(row.Cells["ProfitMarginGV"].Value.ToString()) / 100;
                    float amountToIncrease = profitMargin * buyingPrice;

                    float finalSellingPrice = buyingPrice + amountToIncrease;
                    float discountPer;
                    if (row.Cells["discountGV"].Value != null && rg.Match(row.Cells["discountGV"].Value.ToString()).Success)
                    {
                        discountPer = finalSellingPrice * (Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) / 100);
                    }
                    else
                    {
                        discountPer = 0;
                    }
                    row.Cells["finalPRGV"].Value = finalSellingPrice-discountPer;
                }
                else 
                {
                    row.Cells["finalPRGV"].Value = null;
                    row.Cells["discountGV"].Value = null;
                    row.Cells["ProfitMarginGV"].Value = null;
                }
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.CurrentCell.ColumnIndex == 4)
            //{   
            //    dataGridView1.BeginEdit(true);
            //}

            if (e.ColumnIndex == 4)
            {
                dataGridView1.BeginEdit(true);
            }
        }
        public override void AddBtn_Click(object sender, EventArgs e)
        {

        }

        public override void EditBtn_Click(object sender, EventArgs e)
        {

        }

        Updation u = new Updation();
        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            int che=0;
            if (categoryDD.SelectedIndex != -1)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((bool)row.Cells["selectGV"].FormattedValue == true)
                    {
                        che++;
                       Int64 proID;
                        float disc, pm, bp, sp;
                        proID = Convert.ToInt32(row.Cells["proIDGV"].Value.ToString());
                        bp = Convert.ToSingle(row.Cells["buyingPRGV"].Value.ToString());
                        disc = row.Cells["discountGV"].Value == null ?0 : Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                        pm = row.Cells["ProfitMarginGV"].Value == null ?0 : Convert.ToSingle(row.Cells["ProfitMarginGV"].Value.ToString());
                        if (disc == 0 && pm == 0)
                        {
                            sp = bp;
                        }
                        else
                        {
                            sp = Convert.ToSingle(row.Cells["finalPRGV"].Value.ToString());

                        }
                        u.updateProductPrice(proID, bp, sp, disc, pm);
                    }
                }
                if (che > 0)
                {
                    MainClass.ShowMSG("Product Pricing updated successfully...", "Success", "Success");
                    che = 0;
                }
                else 
                {
                    MainClass.ShowMSG("Please select check box...", "Error", "Error");
                    che = 0;

                }
            }
        }

        public override void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void ViewBtn_Click(object sender, EventArgs e)
        {

        }

        private void ProductPricing_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            r.getList("st_getCategorieslist", categoryDD, "Category", "ID");
            categoryDD.SelectedIndex = -1;

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
