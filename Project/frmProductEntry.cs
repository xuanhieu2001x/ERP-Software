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
    public partial class frmProductEntry : Form
    {
        OleDbConnection conn = new OleDbConnection(ConfigurationManager.AppSettings["Con"]);
        public frmProductEntry()
        {
            InitializeComponent();
        }

        private void frmProductEntry_Load(object sender, EventArgs e)
        {
            viewData();
        }
        void viewData()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Product]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void ClearDate()
        {
            txtID.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();

        }
            private void btnSave_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [Product] (Pid,ProductName,Quantity) values ("+txtID.Text + ",'"+ txtProductName.Text+"'," +txtQuantity.Text +")  ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            viewData();
            ClearDate();
        }
           

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("update [Product] set " + " ProductName =" + "'" + txtProductName.Text+ "'" + "," + " Quantity ='" +txtQuantity.Text +"'" + " where Pid ='"+txtID.Text + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            viewData();
            ClearDate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("DELETE FROM [Product] " + " where Pid = '" +txtID.Text + "' ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            viewData();
        }
    }
}
