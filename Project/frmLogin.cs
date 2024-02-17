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
    public partial class frmLogin : Form
    {
        OleDbConnection conn = new OleDbConnection(ConfigurationManager.AppSettings["Con"]);

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Users] where [Username] ='" + txtUser.Text + "' and [Password]='" + txtPass.Text +"'",conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                frmMain F = new frmMain();
                F.Show();
              
                this.Hide();


            }
            else
            {
                MessageBox.Show(this, "Wrond User Name and Password !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUser.Clear();
                txtPass.Clear();
                txtUser.Focus();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
