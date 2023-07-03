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
    public partial class Supplier : Sample2
    {
        int edit = 0; //this 0 is indication to save operation and 1 in an indication update operation
        int supplierID;
        short stat;
        public Supplier()
        {
            InitializeComponent();
        }
        retrival r = new retrival();

        private void Supplier_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftpanel);
        }

        public override void AddBtn_Click(object sender, EventArgs e)
        {
            MainClass.Enable_reset(leftpanel);
            edit = 0;
        }

        public override void EditBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.Enable(leftpanel);
        }

        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            //---Conpany name---
            if (suppliercompanytxt.Text == "") { suppliercompanyErrorLabel.Visible = true; }
            else { suppliercompanyErrorLabel.Visible = false; }
            //---Person Name---
            if (personnametxt.Text == "") { personnameErrorLabel.Visible = true; }
            else { personnameErrorLabel.Visible = false; }
            //---Phone 1---
            if (phone1txt.Text == "") { phone1ErrorLabel.Visible = true; }
            else { phone1ErrorLabel.Visible = false; }
            /*//---Phone 2---
            if (phone2txt.Text == "") { phone2ErrorLabel.Visible = true; }
            else { phone2ErrorLabel.Visible = false; }*/
            //---Address---
            if (addresstxt.Text == "") { addressErrorLabel.Visible = true; }
            else { addressErrorLabel.Visible = false; }
            //---Status---
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; }
            else { statusErrorLabel.Visible = false; }


            //Error is the type of msg
            if (suppliercompanyErrorLabel.Visible || personnameErrorLabel.Visible || phone1ErrorLabel.Visible || addressErrorLabel.Visible || statusErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields With * are mandatory", "Stop", "Error");
            }
            else
            {
                //For check Status
                if (statusDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (statusDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) //Code for save operation
                {

                    Insertion i = new Insertion();
                    if (phone2txt.Text == "" && ntntxt.Text != "")
                    {
                        i.InsertSupplier(suppliercompanytxt.Text, personnametxt.Text, phone1txt.Text, addresstxt.Text, stat, null, ntntxt.Text);
                    }
                    else if (phone2txt.Text != "" && ntntxt.Text == "")
                    {
                        i.InsertSupplier(suppliercompanytxt.Text, personnametxt.Text, phone1txt.Text, addresstxt.Text, stat, phone2txt.Text, null);
                    }
                    else if (phone2txt.Text == "" && ntntxt.Text == "")
                    {
                        i.InsertSupplier(suppliercompanytxt.Text, personnametxt.Text, phone1txt.Text, addresstxt.Text, stat, null, null);
                    }
                    else 
                    {
                        i.InsertSupplier(suppliercompanytxt.Text, personnametxt.Text, phone1txt.Text, addresstxt.Text, stat, phone2txt.Text, ntntxt.Text);
                    }

                    r.ShowSuppliers(dataGridView1, suppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV,StatusGV);
                    MainClass.disable_reset(leftpanel);

                }
                else if (edit == 1) //Code for upate operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record?", "Question....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        //--------For check update status
                        if (statusDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statusDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        //--------
                        if (phone2txt.Text == "" && ntntxt.Text != "")
                        {
                            u.updateSupplier(supplierID, suppliercompanytxt.Text, personnametxt.Text, phone1txt.Text, addresstxt.Text, stat,null, ntntxt.Text);
                        }
                        else if (phone2txt.Text != "" && ntntxt.Text == "")
                        {
                            u.updateSupplier(supplierID, suppliercompanytxt.Text, personnametxt.Text, phone1txt.Text, addresstxt.Text, stat, phone2txt.Text, null);
                        }
                        else if (phone2txt.Text == "" && ntntxt.Text == "")
                        {
                            u.updateSupplier(supplierID, suppliercompanytxt.Text, personnametxt.Text, phone1txt.Text, addresstxt.Text, stat, null, null);
                        }
                        else
                        {
                            u.updateSupplier(supplierID, suppliercompanytxt.Text, personnametxt.Text, phone1txt.Text, addresstxt.Text, stat, phone2txt.Text, ntntxt.Text);
                        }
                        r.ShowSuppliers(dataGridView1, suppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
                        MainClass.disable_reset(leftpanel);
                    }
                }
            }
        }

        public override void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete record?", "Question....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    d.Delete(supplierID, "st_deleteSupplier", "@suppID");
                    r.ShowSuppliers(dataGridView1, suppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
                }
            }
        }

        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void ViewBtn_Click(object sender, EventArgs e)
        {
            r.ShowSuppliers(dataGridView1, suppIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                supplierID = Convert.ToInt32(row.Cells["suppIDGV"].Value.ToString());
                suppliercompanytxt.Text = row.Cells["companyGV"].Value.ToString();
                personnametxt.Text = row.Cells["personGV"].Value.ToString();
                phone1txt.Text = row.Cells["phone1GV"].Value.ToString();
                phone2txt.Text = row.Cells["phone2GV"].Value.ToString();
                addresstxt.Text = row.Cells["addressGV"].Value.ToString();
                ntntxt.Text = row.Cells["ntnGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftpanel);
            }
        }
    }
}