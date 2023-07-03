using CrystalDecisions.CrystalReports.Engine;
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
    public partial class SalesReturnReceiptWindow : Form
    {
        public SalesReturnReceiptWindow()
        {
            InitializeComponent();
        }

        ReportDocument rd;
        retrival r = new retrival();
        private void SalesReturnReceiptWindow_Load(object sender, EventArgs e)
        {
            rd = new ReportDocument();
            r.showReport("ReturnInvoiceReport.rpt", rd,crystalReportViewer2, "st_getRefundInvoice", "@salesID", "345345345");
        }
    }
}
