using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class setting : Sample
    {
        public setting()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (IntegratedSecurityCB.Checked)
            {
                if (Servertxt.Text != "" && DataBasetxt.Text != "")
                {
                    s = "Data Source=" + Servertxt.Text + ";Initial Catalog=" + DataBasetxt.Text + ";Integrated Security=true;MultipleActiveResultSets=true;";
                    File.WriteAllText(path+"\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings Saved Succesfully.....", "Information.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindows(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please Give complete data to continue");
                }
            }
            else 
            {
                if (Servertxt.Text != "" && DataBasetxt.Text != "" && userIDtxt.Text != "" && passwordtxt.Text != "")
                {
                    s = "Data Source = " + Servertxt.Text + ";Initial Catalog = " + DataBasetxt.Text + ";User Id = " + userIDtxt.Text + ";Password = " + passwordtxt.Text+ ";MultipleActiveResultSets=true;";
                    File.WriteAllText(path + "\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings Saved Succesfully.....", "Information.....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindows(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please Give complete data to continue");
                }
            }

        }

        private void IntegratedSecurityCB_CheckedChanged(object sender, EventArgs e)
        {
            if (IntegratedSecurityCB.Checked)
            {
                userIDtxt.Enabled = false;
                passwordtxt.Enabled = false;
                userIDtxt.Text = "";
                passwordtxt.Text = "";
            }
            else
            {
                userIDtxt.Enabled = true;
                passwordtxt.Enabled = true;
            }
        }

        private void setting_Load(object sender, EventArgs e)
        {

        }
    }
}
