using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    class MainClass
    {
        public static DialogResult ShowMSG(string msg, string heading, string type)
        {
            if(type == "Success")
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void showWindows(Form openwin, Form closewin, Form MDIwin)
        {
            closewin.Close();
            openwin.MdiParent = MDIwin;
            openwin.WindowState = FormWindowState.Maximized;
            openwin.Show();
        }
        public static void showWindows(Form openwin, Form MDIwin)
        {
            openwin.MdiParent = MDIwin;
            openwin.WindowState = FormWindowState.Maximized;
            openwin.Show();
        }
        
        //Disable Reset
        public static void disable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                    cb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                    dtp.Value = DateTime.Now;
                }
            }
        }

        internal static void ShowMSG(string message)
        {
            throw new NotImplementedException();
        }

        //Disable
        public static void disable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                }
            }
        }
        //Enable Reset
        public static void Enable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                    cb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
            }
        }
        //Enable
        public static void Enable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                }
            }
        }

        //for connection
        //base for sql database
        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string s = File.ReadAllText(path+"\\connect");
        public static SqlConnection con = new SqlConnection(s);
        //For groupbox
        public static void Enable_reset(GroupBox gb)
        {
            foreach (Control c in gb.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                    cb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
            }
        }
    }
}
