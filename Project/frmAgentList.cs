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

    public partial class frmAgentList : Form
    {
        OleDbConnection conn = new OleDbConnection(ConfigurationManager.AppSettings["Con"]);
        public frmAgentList()
        {
            InitializeComponent();
        }
        void viewData()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [AgentList]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void ClearDate()
        {
            txtID.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtPosition.Clear();
        }
            private void btnSave_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [AgentList] values ('" + txtID.Text + "','" + txtName.Text + "','" + dtBirthday.Text + "','" + txtAddress.Text + "','" + txtPosition.Text + "')  ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            viewData();
            ClearDate();
        }

        private void frmAgentList_Load(object sender, EventArgs e)
        {
            viewData();
        }
    }
}
