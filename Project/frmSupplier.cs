using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
namespace Accountant_Software.Project
{
    public partial class frmSupplier : Form
    {
        OleDbConnection conn = new OleDbConnection(ConfigurationManager.AppSettings["Con"]);
        public frmSupplier()
        {
            InitializeComponent();
        }
        void viewData()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Supplier]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void ClearDate()
        {
            txtID.Clear();
            txtSupplierName.Clear();
            txtAddress.Clear();
            txtPN.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [Supplier] values ('" + txtID.Text + "','" + txtSupplierName.Text + "','" + txtAddress.Text + "','" + txtPN.Text + "')  ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            viewData();
            ClearDate();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            viewData();
            ClearDate();
        }
    }
}
