using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

using System.Configuration;

namespace Accountant_Software.Project
{
    
     
    public partial class frmCustomer : Form
    {
        OleDbConnection conn = new OleDbConnection(ConfigurationManager.AppSettings["Con"]);
        public frmCustomer()
        {
            InitializeComponent();
        }
        
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            viewData();
        }
        void viewData()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Customer]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void ClearDate()
        {
            txtID.Clear();
            txtCustomerName.Clear();
            txtAddress.Clear();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [Customer] values ('" + txtID.Text + "','" + txtCustomerName.Text + "','" + txtAddress.Text + "','" + txtSO.Text + "','" + txtDP.Text +"')  ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            viewData();
            ClearDate();
        }
    }
}
