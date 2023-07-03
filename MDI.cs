using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Inventory_Management_System
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(path + "\\connect"))
            {
                Login log = new Login();
                MainClass.showWindows(log, this);
            }
            else
            {
                setting set = new setting();
                MainClass.showWindows(set, this);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setting set = new setting();
            MainClass.showWindows(set, this);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI.logoutToolStripMenuItem.Enabled = false;
            Login set = new Login();
            MainClass.showWindows(set, this);

        }
    }
}
