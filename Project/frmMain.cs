using Accountant_Software.Forms;
using Accountant_Software.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accountant_Software.Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnProductE_Click(object sender, EventArgs e)
        {
            Project.frmProductEntry f = new frmProductEntry();
            f.Show();
        }

        private void btSale_Click(object sender, EventArgs e)
        {
            frmSales a = new frmSales();
            a.Show();

        }

        private void btIncome_Click(object sender, EventArgs e)
        {
            frmSupplier b = new frmSupplier();
            b.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer b = new frmCustomer();
            b.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmAgentList b = new frmAgentList();
            b.Show();
        }

        private void btPurchase_Click(object sender, EventArgs e)
        {
            frmPurchase a = new frmPurchase();
            a.Show();
        }

        private void btGeneralDiary_Click(object sender, EventArgs e)
        {
            frmGeneralDiary a = new frmGeneralDiary();
            a.Show();
        }
    }
}
