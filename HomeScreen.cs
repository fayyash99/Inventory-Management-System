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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            MDI.logoutToolStripMenuItem.Enabled = true;
            userLabel.Text = retrival.EMP_NAME;
        }

        private void UsersBtn_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.showWindows(u, this, MDI.ActiveForm);
        }

        private void catBtn_Click(object sender, EventArgs e)
        {
            categories u = new categories();
            MainClass.showWindows(u, this, MDI.ActiveForm);
        }

        private void productDD_Click(object sender, EventArgs e)
        {
            products u = new products();
            MainClass.showWindows(u, this, MDI.ActiveForm);
        }

        private void suppBtn_Click(object sender, EventArgs e)
        {
            Supplier u = new Supplier();
            MainClass.showWindows(u, this, MDI.ActiveForm);
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice u = new PurchaseInvoice();
            MainClass.showWindows(u, this, MDI.ActiveForm);
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            Stocks u = new Stocks();
            MainClass.showWindows(u, this, MDI.ActiveForm);
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            Sales u = new Sales();
            MainClass.showWindows(u, this, MDI.ActiveForm);
        }

        private void priceBtn_Click(object sender, EventArgs e)
        {
            ProductPricing u = new ProductPricing();
            MainClass.showWindows(u, this, MDI.ActiveForm);
        }

        private void salereturnBtn_Click(object sender, EventArgs e)
        {
            SalesReturnWindow u = new SalesReturnWindow();
            MainClass.showWindows(u, this, MDI.ActiveForm);
        }
    }
}
