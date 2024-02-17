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
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Diagnostics;
using Accountant_Software.Reports;
using Accountant_Software.Project;

namespace Accountant_Software.Forms
{
    public partial class frmSales : Form
    {
        OleDbConnection conn = new OleDbConnection(ConfigurationManager.AppSettings["Con"]);
        public frmSales()
        {
            InitializeComponent();
        }

        
            void viewData2()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [SaleList]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            GeneratePOId();
            GetExistingPOIds();
            
            ViewProduct();
            dataGridView1.AutoGenerateColumns = false;
            viewData2();
            OleDbDataAdapter da = new OleDbDataAdapter("Select CustomerID,Name from [Customer]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cbCustomer.DataSource = ds.Tables[0];
            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "CustomerID";
            conn.Close();


            OleDbDataAdapter da1 = new OleDbDataAdapter("Select ALID,Name from [AgentList]", conn);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            cbSalesAgent.DataSource = ds1.Tables[0];
            cbSalesAgent.DisplayMember = "Name";
            cbSalesAgent.ValueMember = "ALID";


            OleDbDataAdapter da2 = new OleDbDataAdapter("Select AccountID,AccountName from [Trial Balance]", conn);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            cbDebit.DataSource = ds2.Tables[0];
            cbDebit.DisplayMember = "AccountName";
            cbDebit.ValueMember = "AccountID";

            OleDbDataAdapter da3 = new OleDbDataAdapter("Select AccountID,AccountName from [Trial Balance]", conn);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            cbCredit.DataSource = ds3.Tables[0];
            cbCredit.DisplayMember = "AccountName";
            cbCredit.ValueMember = "AccountID";

            string dateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            txtTime.Text = dateTime;



        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCustomer_BindingContextChanged(object sender, EventArgs e)
        {

        }
        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                decimal rowTotal;
                if (Decimal.TryParse(row.Cells["Item Total"].Value.ToString(), out rowTotal))
                {
                    total += rowTotal;
                }
            }
            MessageBox.Show("Total money: " + total.ToString());
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbPO_Click(object sender, EventArgs e)
        {

        }

        private void cbCustomer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        
            string selectedName = cbCustomer.Text; // Lấy tên khách hàng đã chọn

            string query = "SELECT Address FROM Customer WHERE Name = @Name"; // Câu truy vấn để lấy địa chỉ từ cơ sở dữ liệu


            using (OleDbCommand command = new OleDbCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Name", selectedName); // Truyền tham số tên khách hàng vào câu truy vấn
                conn.Open();
                string address = (string)command.ExecuteScalar(); // Lấy địa chỉ từ cơ sở dữ liệu
                txtAddress.Text = address; // Hiển thị địa chỉ trong TextBox
                conn.Close();
            }
        }
        void SaleListview()
        {

            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [SaleList]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {


            // Chuỗi kết nối tới database Access
            conn.Open();
            // Tạo đối tượng connection
           

            OleDbDataAdapter da = new OleDbDataAdapter("insert into [SaleList] (POID, TimePO, CustomerName, SalesAgent, Explain, Account, TotalMoney) values ('" + txtIDPO.Text + "','" + txtTime.Text + "','" + cbCustomer.Text + "', '" + cbSalesAgent.Text + "', '" + txtExplain.Text + "', '" + cbDebit.Text + "', '" + txtTotalMoney.Text + "' )", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            SaleListview();

            


            
            //tài khoản nợ tiền
            OleDbDataAdapter da1 = new OleDbDataAdapter("SELECT AccountID FROM [Trial Balance] WHERE AccountName = @NameAccount", conn);
            da1.SelectCommand.Parameters.AddWithValue("@NameAccount", cbDebit.Text);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            string sql = "INSERT INTO GeneralDiary (AccountingDate, POID, Explain, Account, Debit) VALUES (@AccountingDate, @POID, @Explain, @Account, @Debit)";
            OleDbCommand command = new OleDbCommand(sql, conn);
            command.Parameters.AddWithValue("@AccountingDate", txtTime.Text);
            command.Parameters.AddWithValue("@POID", txtIDPO.Text);
            command.Parameters.AddWithValue("@Explain", txtExplain.Text);
            command.Parameters.AddWithValue("@Account", ds1.Tables[0].Rows[0]["AccountID"].ToString());
            command.Parameters.AddWithValue("@Debit", txtTotalMoney.Text);
            command.ExecuteNonQuery();

            //tài khoản có "doanh thu bán hàng"
            OleDbDataAdapter daDT = new OleDbDataAdapter("SELECT AccountID FROM [Trial Balance] WHERE AccountID = '511'", conn);

            DataSet dsDT = new DataSet();
            daDT.Fill(dsDT);
            string sqlDe = "INSERT INTO GeneralDiary (AccountingDate, POID, Explain, Account, Credit) VALUES (@AccountingDate, @POID, @Explain, @Account, @Credit)";
            OleDbCommand commandDe = new OleDbCommand(sqlDe, conn);
            commandDe.Parameters.AddWithValue("@AccountingDate", txtTime.Text);
            commandDe.Parameters.AddWithValue("@POID", txtIDPO.Text);
            commandDe.Parameters.AddWithValue("@Explain", txtExplain.Text);
            commandDe.Parameters.AddWithValue("@Account", dsDT.Tables[0].Rows[0]["AccountID"].ToString()); // assign the value of AccountCredit to AccountC
            commandDe.Parameters.AddWithValue("@Credit", txtTotalMoney.Text);
            commandDe.ExecuteNonQuery();
            //tài khoản nợ TK Giá vốn hàng bán
            OleDbDataAdapter daGVBH = new OleDbDataAdapter("SELECT AccountID FROM [Trial Balance] WHERE AccountID = '632'", conn);
            DataSet dsGVBH = new DataSet();
            daGVBH.Fill(dsGVBH);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string pid = dataGridView1.Rows[i].Cells[0].Value != null ? dataGridView1.Rows[i].Cells[0].Value.ToString() : "";
                int quantity = dataGridView1.Rows[i].Cells[2].Value?.ToString() != null ? int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) : 0;
                OleDbDataAdapter daMN = new OleDbDataAdapter("SELECT Price FROM [Product] WHERE Pid = @pid", conn);
                daMN.SelectCommand.Parameters.AddWithValue("@pid", pid);
                DataSet dsMN = new DataSet();
                string sqlQueryCD = "SELECT Price FROM [Product] WHERE Pid = @pid";
                OleDbCommand accountCommandCD = new OleDbCommand(sqlQueryCD, conn);
                accountCommandCD.Parameters.AddWithValue("@pid", pid);
                int price = Convert.ToInt32(accountCommandCD.ExecuteScalar());
                int money = price * quantity;
                daMN.Fill(dsMN);
                string sqlGVBH = "INSERT INTO GeneralDiary (AccountingDate, POID, Explain, Account, Debit) VALUES (@AccountingDate, @POID, @Explain, @Account, @Debit)";
                OleDbCommand commandGVBH = new OleDbCommand(sqlGVBH, conn);
                commandGVBH.Parameters.AddWithValue("@AccountingDate", txtTime.Text);
                commandGVBH.Parameters.AddWithValue("@POID", txtIDPO.Text);
                commandGVBH.Parameters.AddWithValue("@Explain", txtExplain.Text);
                commandGVBH.Parameters.AddWithValue("@Account", dsGVBH.Tables[0].Rows[0]["AccountID"].ToString());
                commandGVBH.Parameters.AddWithValue("@Debit", money);
                commandGVBH.ExecuteNonQuery();
            }
            //tài khoản có Hàng hóa , nguyên vật liệu
            OleDbDataAdapter daHH = new OleDbDataAdapter("SELECT AccountID FROM [Trial Balance] WHERE AccountName = @NameAccount", conn);
            daHH.SelectCommand.Parameters.AddWithValue("@NameAccount", cbCredit.Text);
            DataSet dsHH = new DataSet();
            daHH.Fill(dsHH);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string pid = dataGridView1.Rows[i].Cells[0].Value != null ? dataGridView1.Rows[i].Cells[0].Value.ToString() : "";
                int quantity = dataGridView1.Rows[i].Cells[2].Value?.ToString() != null ? int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) : 0;
                OleDbDataAdapter daMN = new OleDbDataAdapter("SELECT Price FROM [Product] WHERE Pid = @pid", conn);
                daMN.SelectCommand.Parameters.AddWithValue("@pid", pid);
                DataSet dsMN = new DataSet();
                string sqlQueryCD = "SELECT Price FROM [Product] WHERE Pid = @pid";
                OleDbCommand accountCommandCD = new OleDbCommand(sqlQueryCD, conn);
                accountCommandCD.Parameters.AddWithValue("@pid", pid);
                int price = Convert.ToInt32(accountCommandCD.ExecuteScalar());
                int money = price*quantity;
                daMN.Fill(dsMN);
                string sqlHH = "INSERT INTO GeneralDiary (AccountingDate, POID, Explain, Account, Credit) VALUES (@AccountingDate, @POID, @Explain, @Account, @Credit)";
                OleDbCommand commandHH = new OleDbCommand(sqlHH, conn);
                commandHH.Parameters.AddWithValue("@AccountingDate", txtTime.Text);
                commandHH.Parameters.AddWithValue("@POID", txtIDPO.Text);
                commandHH.Parameters.AddWithValue("@Explain", txtExplain.Text);
                commandHH.Parameters.AddWithValue("@Account", dsHH.Tables[0].Rows[0]["AccountID"].ToString()); // assign the value of AccountCredit to AccountC
                commandHH.Parameters.AddWithValue("@Credit",money);
                commandHH.ExecuteNonQuery();
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string pid = dataGridView1.Rows[i].Cells[0].Value != null ? dataGridView1.Rows[i].Cells[0].Value.ToString() : "";

                int quantity = dataGridView1.Rows[i].Cells[2].Value?.ToString() != null ? int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) : 0;

                string sql1 = "UPDATE Product SET Quantity = Quantity - ? WHERE Pid = a";
                OleDbCommand command1 = new OleDbCommand(sql1, conn);
                command1.Parameters.AddWithValue("?", quantity);
                command1.Parameters.AddWithValue("a", pid);
                command1.ExecuteNonQuery();
            }


            MessageBox.Show("Data inserted successfully!");
            conn.Close();
        }

private void label9_Click(object sender, EventArgs e)
        {

        }
        void ViewProduct()
        {
            OleDbDataAdapter da3 = new OleDbDataAdapter("Select Pid,ProductName from [Product]", conn);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            clMaterialDes.DataSource = ds3.Tables[0];
            clMaterialDes.DisplayMember = "ProductName";
            clMaterialDes.ValueMember = "Pid";
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ViewProduct();
            if (e.ColumnIndex == clMaterialDes.Index && e.RowIndex >= 0)
            {
                DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                DataGridViewTextBoxCell textBoxCell = (DataGridViewTextBoxCell)dataGridView1.Rows[e.RowIndex].Cells[clMaterial.Index];
                textBoxCell.Value = comboBoxCell.Value;
            }
        }

        private void dataGridView1_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {
    
        }

        private void dataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            int quantityIndex = 2; // vị trí cột Quantity
            int unitPriceIndex = 3; // vị trí cột Unit Price
            int itemTotalIndex = 4; // vị trí cột Item Total
            if (e.ColumnIndex == quantityIndex || e.ColumnIndex == unitPriceIndex)
            {
                // Lấy giá trị của ô Quantity và ô Unit Price tương ứng
                int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[quantityIndex].Value);
                decimal unitPrice = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[unitPriceIndex].Value);

                // Tính toán giá trị cho ô Item Total
                decimal itemTotal = quantity * unitPrice;

                // Gán giá trị cho ô Item Total tương ứng
                dataGridView1.Rows[e.RowIndex].Cells[itemTotalIndex].Value = itemTotal;
                
            }
            

            decimal total = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[itemTotalIndex].Value != null)
                    {
                        total += Convert.ToDecimal(row.Cells[itemTotalIndex].Value);
                    }
                }
                // Hiển thị tổng giá trị trong TextBox
                txtTotalMoney.Text = total.ToString();
 
        }
       

        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
    
        }
        private void GeneratePOId()
        {
            // Tạo chuỗi format để tạo ID
            string format = "POBH";
            // Lấy ngày hiện tại dưới dạng chuỗi theo định dạng yyMMdd
            string currentDate = DateTime.Now.ToString("ddMMyyyy");
            // Lấy danh sách các PO Id đã tồn tại trong cơ sở dữ liệu
            List<string> existingIds = GetExistingPOIds();
            // Lấy số thứ tự tiếp theo cho PO Id
            int nextId = GetNextPOId(existingIds);
            // Tạo chuỗi số thứ tự tiếp theo dưới dạng 3 chữ số
            string nextIdString = nextId.ToString("D3");
            // Tạo PO Id từ các thành phần
            string poId = string.Format("{0}{1}{2}", format, currentDate, nextIdString);
            // Gán PO Id vào textbox
            txtIDPO.Text = poId;
        }

        private List<string> GetExistingPOIds()
        {
            List<string> existingIds = new List<string>();


                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand("SELECT POID FROM SaleList", conn))
                {
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                    while (reader.Read())
                    {
                        existingIds.Add(reader.GetValue(0).ToString());
                    }
                }
                conn.Close();
                }
            

            return existingIds;
        }

        private int GetNextPOId(List<string> existingIds)
        {
            // Nếu danh sách existingIds rỗng thì trả về số thứ tự đầu tiên là 1
            if (existingIds.Count == 0)
            {
                return 1;
            }
            else
            {
                // Nếu danh sách existingIds không rỗng thì lấy số thứ tự lớn nhất
                // trong danh sách, tăng lên 1 và trả về
                int maxId = existingIds.Select(id => int.Parse(id.Substring(12))).Max();
                return maxId + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMain m = new frmMain();
            this.Close(); // đóng Sale Form
            m.Show(); // hiển thị Main Form
        }
    }
}
