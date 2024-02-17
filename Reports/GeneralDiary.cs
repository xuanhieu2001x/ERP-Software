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
using System.Security.Cryptography;
using System.Diagnostics;
using System.Security.Principal;


namespace Accountant_Software.Reports
{
    public partial class frmGeneralDiary : Form
    {
        OleDbConnection conn = new OleDbConnection(ConfigurationManager.AppSettings["Con"]);

        public frmGeneralDiary()
        {
            InitializeComponent();

        }


        void viewData()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from GeneralDiary", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvGeneralDiary.DataSource = ds.Tables[0];
        }
        void viewDataTB()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [Trial Balance] ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        void viewDataAB()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [AccountBalance] ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvAB.DataSource = ds.Tables[0];
        }
        void viewDataFS()
        {
            OleDbDataAdapter daFS = new OleDbDataAdapter("SELECT * FROM [FinancialStatement] ", conn);
            DataSet dsFS = new DataSet();
            daFS.Fill(dsFS);
            dgvFS.DataSource = dsFS.Tables[0];
        }
        private void UpdateDebitTotal()
        {
            decimal totalDebit = 0;
            foreach (DataGridViewRow row in dgvGeneralDiary.Rows)
            {
                decimal debit = 0;
                if (decimal.TryParse(row.Cells["Debit"]?.Value?.ToString(), out debit))
                {
                    totalDebit += debit;
                }
            }
            txtTotalDebit.Text = totalDebit.ToString();
        }
        private void UpdateCreditTotal()
        {
            decimal totalCredit = 0;
            foreach (DataGridViewRow row in dgvGeneralDiary.Rows)
            {
                decimal credit = 0;
                if (decimal.TryParse(row.Cells["Credit"]?.Value?.ToString(), out credit))
                {
                    totalCredit += credit;
                }
            }
            txtTotalCredit.Text = totalCredit.ToString();
        }

        private void frmGeneralDiary_Load(object sender, EventArgs e)
        {

            viewData();
            
            
            UpdateDebitTotal();
            UpdateCreditTotal();
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT Account, SUM(Debit) AS totalDebit, SUM(Credit) AS totalCredit FROM GeneralDiary GROUP BY Account", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                // Lấy giá trị của cột "Account"
                string account = row["Account"].ToString();

                // Lấy giá trị của cột "totalDebit"
                double totaldebit = double.Parse(row["totalDebit"].ToString());

                // Lấy giá trị của cột "totalCredit"
                double totalcredit = double.Parse(row["totalCredit"].ToString());

                double total = totaldebit - totalcredit;


                // Câu lệnh SQL UPDATE
                string query = "UPDATE [Trial Balance] SET Mid_Debit=@mid_debit, Mid_Credit=@mid_credit WHERE AccountID = @account";

                // Tạo đối tượng Command
                OleDbCommand command = new OleDbCommand(query, conn);

                // Thêm tham số và giá trị cho câu lệnh SQL
                command.Parameters.AddWithValue("@mid_debit", totaldebit);
                command.Parameters.AddWithValue("@mid_credit", totalcredit);
                command.Parameters.AddWithValue("@account", account);
                // Thực thi câu lệnh SQL
                command.ExecuteNonQuery();
                string queryAB = "UPDATE [AccountBalance] SET EndNumber = @endnumber WHERE AccountNumber = @accountname ";
                using (OleDbCommand commandAB = new OleDbCommand(queryAB, conn))
                {

                    commandAB.Parameters.AddWithValue("@endnumber", total);
                    commandAB.Parameters.AddWithValue("@accountname", account);
                    commandAB.ExecuteNonQuery();
                }
                DataSet dsdt1 = new DataSet();
                dsdt1.Tables.Add(new DataTable());
                dsdt1.Tables[0].Columns.Add("Account", typeof(string));
                dsdt1.Tables[0].Columns.Add("Total", typeof(double));
                dsdt1.Tables[0].Rows.Add(account, totalcredit);

                DataRow[] rowa = dsdt1.Tables[0].Select("Account = '511'");

                if (rowa.Length > 0)
                {
                    double totaldt = (double)rowa[0]["Total"];
                    // Do something with the total
                    string querydt = "UPDATE [FinancialStatement] SET ThisTerm = @endnumber WHERE ID = @id";
                    OleDbCommand commanddt = new OleDbCommand(querydt, conn);
                    commanddt.Parameters.AddWithValue("-" + "@thisterm", totaldt);
                    commanddt.Parameters.AddWithValue("@id", "10");
                    commanddt.ExecuteNonQuery();
                }
                DataSet dsdt = new DataSet();
                dsdt.Tables.Add(new DataTable());
                dsdt.Tables[0].Columns.Add("Account", typeof(string));
                dsdt.Tables[0].Columns.Add("Total", typeof(double));
                dsdt.Tables[0].Rows.Add(account, total);
                DataRow[] rowss = dsdt.Tables[0].Select("Account = '632'");

                if (rowss.Length > 0)
                {
                    double totaldt1 = (double)rowss[0]["Total"];
                    // Do something with the total
                    string querydt = "UPDATE [FinancialStatement] SET ThisTerm =@thisterm WHERE ID = @id";
                    OleDbCommand commanddt = new OleDbCommand(querydt, conn);
                    commanddt.Parameters.AddWithValue("@thisterm", totaldt1);
                    commanddt.Parameters.AddWithValue("@id", "11");
                    commanddt.ExecuteNonQuery();
                }

                OleDbCommand cmd = new OleDbCommand("SELECT ID,ThisTerm FROM FinancialStatement WHERE ID = 10 OR ID = 11", conn);

                OleDbDataReader reader = cmd.ExecuteReader();
                double a = 0;
                double b = 0;
                while (reader.Read())
                {
                    if (reader["ID"].ToString() == "10")
                    {
                        a = Convert.ToDouble(reader["ThisTerm"].ToString());
                    }
                    else if (reader["ID"].ToString() == "11")
                    {
                        b = Convert.ToDouble(reader["ThisTerm"].ToString());
                    }
                }
                double c = a - b;
                string querypf = "UPDATE [FinancialStatement] SET ThisTerm = @thisterm WHERE ID = @id";
                OleDbCommand commandpf = new OleDbCommand(querypf, conn);
                commandpf.Parameters.AddWithValue("@thisterm", c);
                commandpf.Parameters.AddWithValue("@id", "20");
                commandpf.ExecuteNonQuery();
                string querypft = "UPDATE [FinancialStatement] SET ThisTerm = @thisterm WHERE ID = @id";
                OleDbCommand commandpft = new OleDbCommand(querypft, conn);
                commandpft.Parameters.AddWithValue("@thisterm", c);
                commandpft.Parameters.AddWithValue("@id", "30");
                commandpft.ExecuteNonQuery();
                string querytt = "UPDATE [FinancialStatement] SET ThisTerm = @thisterm WHERE ID = @id";
                OleDbCommand commandtt = new OleDbCommand(querytt, conn);
                commandtt.Parameters.AddWithValue("@thisterm", c);
                commandtt.Parameters.AddWithValue("@id", "50");
                commandtt.ExecuteNonQuery();
                OleDbCommand cmdst = new OleDbCommand("SELECT ID,ThisTerm FROM FinancialStatement WHERE ID = 50 OR ID = 51", conn);

                OleDbDataReader readerst = cmdst.ExecuteReader();
                double tt = 0;
                double tax = 0;
                while (readerst.Read())
                {
                    if (readerst["ID"].ToString() == "50")
                    {
                        tt = Convert.ToDouble(readerst["ThisTerm"].ToString());
                    }
                    else if (readerst["ID"].ToString() == "51")
                    {
                        tax = Convert.ToDouble(readerst["ThisTerm"].ToString());
                    }
                }
                double st = tt - (tt*tax);
                string queryst = "UPDATE [FinancialStatement] SET ThisTerm = @thisterm WHERE ID = @id";
                OleDbCommand commandst = new OleDbCommand(queryst, conn);
                commandst.Parameters.AddWithValue("@thisterm", st);
                commandst.Parameters.AddWithValue("@id", "60");
                commandst.ExecuteNonQuery();
            }
            //tính tổng tài sản ngắn hạn
            OleDbDataAdapter datotal = new OleDbDataAdapter("SELECT SUM(EndNumber) AS Total FROM AccountBalance WHERE AccountNumber IN ('111', '112', '131', '152')", conn);
            DataSet dstotal = new DataSet();
            datotal.Fill(dstotal);
            foreach (DataRow row in dstotal.Tables[0].Rows)
            {
                double totalasset = double.Parse(row["Total"].ToString());
                string query = "UPDATE [AccountBalance] SET EndNumber = @endnumber WHERE AccountNumber = @account";
                OleDbCommand command = new OleDbCommand(query, conn);
                command.Parameters.AddWithValue("@endnumber", totalasset);
                command.Parameters.AddWithValue("@account", "100");
                command.ExecuteNonQuery();
            }
            //tính tổng tài sản dài hạn
            //OleDbDataAdapter datotaldh = new OleDbDataAdapter("SELECT SUM(EndNumber) AS Total1 FROM AccountBalance WHERE AccountNumber IN ('155', '156')", conn);
            //DataSet dstotaldh = new DataSet();
            //datotaldh.Fill(dstotaldh);
            //foreach (DataRow row in dstotaldh.Tables[0].Rows)
            //{
                //double totalasset1 = double.Parse(row["Total1"].ToString());
                //string query = "UPDATE [AccountBalance] SET EndNumber = @endnumber WHERE AccountNumber = @account";
                //OleDbCommand command = new OleDbCommand(query, conn);
                //command.Parameters.AddWithValue("@endnumber", totalasset1);
                //command.Parameters.AddWithValue("@account", "200");
                //command.ExecuteNonQuery();
            //}
            //tính tổng tài sản
            OleDbDataAdapter datotalts = new OleDbDataAdapter("SELECT SUM(EndNumber) AS Total FROM AccountBalance WHERE AccountNumber IN ('100', '200')", conn);
            DataSet dstotalts = new DataSet();
            datotalts.Fill(dstotalts);
            foreach (DataRow row in dstotalts.Tables[0].Rows)
            {
            double totalasset = double.Parse(row["Total"].ToString());
            string query = "UPDATE [AccountBalance] SET EndNumber = @endnumber WHERE AccountNumber = @account";
            OleDbCommand command = new OleDbCommand(query, conn);
            command.Parameters.AddWithValue("@endnumber", totalasset);
            command.Parameters.AddWithValue("@account", "270");
            command.ExecuteNonQuery();
            }
            //tính tổng nợ phải trả
            //OleDbDataAdapter totalno = new OleDbDataAdapter("SELECT SUM(EndNumber) AS Total FROM AccountBalance WHERE AccountNumber IN ('331', '334', '338')", conn);
            //DataSet totalno1 = new DataSet();
            //totalno.Fill(totalno1);
            //foreach (DataRow row in totalno1.Tables[0].Rows)
            //{
            //double totalasset = double.Parse(row["Total"].ToString());
            //string query = "UPDATE [AccountBalance] SET EndNumber = @endnumber WHERE AccountNumber = @account";
            //OleDbCommand command = new OleDbCommand(query, conn);
            //command.Parameters.AddWithValue("@endnumber", totalasset);
            //command.Parameters.AddWithValue("@account", "300");
            //command.ExecuteNonQuery();
            // }


                conn.Close();
            viewDataTB();
            viewDataAB();
            viewDataFS();
        }


        private void dgvGeneralDiary_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDebitTotal();
            UpdateCreditTotal();
        }
       
        private void dgvGeneralDiary_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dgvGeneralDiary_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
