namespace Accountant_Software.Forms
{
    partial class frmPurchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPOL = new System.Windows.Forms.TabControl();
            this.tbPO = new System.Windows.Forms.TabPage();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIDPO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaterialDes = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clItemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gbTTC = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCredit = new System.Windows.Forms.ComboBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSalesAgent = new System.Windows.Forms.ComboBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDebit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPOL = new System.Windows.Forms.TabPage();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.labFrom = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPOL.SuspendLayout();
            this.tbPO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbTTC.SuspendLayout();
            this.tbPOL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPOL
            // 
            this.tabPOL.Controls.Add(this.tbPO);
            this.tabPOL.Controls.Add(this.tbPOL);
            this.tabPOL.Location = new System.Drawing.Point(3, 2);
            this.tabPOL.Name = "tabPOL";
            this.tabPOL.SelectedIndex = 0;
            this.tabPOL.Size = new System.Drawing.Size(707, 508);
            this.tabPOL.TabIndex = 1;
            // 
            // tbPO
            // 
            this.tbPO.Controls.Add(this.txtTotalMoney);
            this.tbPO.Controls.Add(this.label2);
            this.tbPO.Controls.Add(this.button2);
            this.tbPO.Controls.Add(this.txtIDPO);
            this.tbPO.Controls.Add(this.label3);
            this.tbPO.Controls.Add(this.dataGridView1);
            this.tbPO.Controls.Add(this.label8);
            this.tbPO.Controls.Add(this.btnCreate);
            this.tbPO.Controls.Add(this.gbTTC);
            this.tbPO.Location = new System.Drawing.Point(4, 22);
            this.tbPO.Name = "tbPO";
            this.tbPO.Padding = new System.Windows.Forms.Padding(3);
            this.tbPO.Size = new System.Drawing.Size(699, 482);
            this.tbPO.TabIndex = 0;
            this.tbPO.Text = "Purchase Order";
            this.tbPO.UseVisualStyleBackColor = true;
            this.tbPO.Click += new System.EventHandler(this.tbPO_Click);
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Location = new System.Drawing.Point(492, 400);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.Size = new System.Drawing.Size(144, 20);
            this.txtTotalMoney.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Total Money";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 25);
            this.button2.TabIndex = 27;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtIDPO
            // 
            this.txtIDPO.Location = new System.Drawing.Point(62, 45);
            this.txtIDPO.Name = "txtIDPO";
            this.txtIDPO.ReadOnly = true;
            this.txtIDPO.Size = new System.Drawing.Size(153, 20);
            this.txtIDPO.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PO ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaterial,
            this.clMaterialDes,
            this.clQuantity,
            this.clUnitPrice,
            this.clItemTotal});
            this.dataGridView1.Location = new System.Drawing.Point(6, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(686, 165);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // clMaterial
            // 
            this.clMaterial.HeaderText = "Material";
            this.clMaterial.Name = "clMaterial";
            this.clMaterial.ReadOnly = true;
            this.clMaterial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clMaterialDes
            // 
            this.clMaterialDes.HeaderText = "Material Description";
            this.clMaterialDes.Name = "clMaterialDes";
            this.clMaterialDes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clMaterialDes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clQuantity
            // 
            this.clQuantity.HeaderText = "Quantity";
            this.clQuantity.Name = "clQuantity";
            // 
            // clUnitPrice
            // 
            this.clUnitPrice.HeaderText = "Unit Price";
            this.clUnitPrice.Name = "clUnitPrice";
            // 
            // clItemTotal
            // 
            this.clItemTotal.HeaderText = "Item Total";
            this.clItemTotal.Name = "clItemTotal";
            this.clItemTotal.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "PURCHASE ORDER";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(57, 450);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(131, 25);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gbTTC
            // 
            this.gbTTC.Controls.Add(this.label11);
            this.gbTTC.Controls.Add(this.cbCredit);
            this.gbTTC.Controls.Add(this.txtTime);
            this.gbTTC.Controls.Add(this.label10);
            this.gbTTC.Controls.Add(this.label9);
            this.gbTTC.Controls.Add(this.cbSalesAgent);
            this.gbTTC.Controls.Add(this.cbSupplier);
            this.gbTTC.Controls.Add(this.txtAddress);
            this.gbTTC.Controls.Add(this.txtExplain);
            this.gbTTC.Controls.Add(this.label6);
            this.gbTTC.Controls.Add(this.label5);
            this.gbTTC.Controls.Add(this.cbDebit);
            this.gbTTC.Controls.Add(this.label4);
            this.gbTTC.Controls.Add(this.label1);
            this.gbTTC.Location = new System.Drawing.Point(9, 77);
            this.gbTTC.Name = "gbTTC";
            this.gbTTC.Size = new System.Drawing.Size(683, 141);
            this.gbTTC.TabIndex = 20;
            this.gbTTC.TabStop = false;
            this.gbTTC.Text = "Thông tin chung";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(430, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Credit";
            // 
            // cbCredit
            // 
            this.cbCredit.FormattingEnabled = true;
            this.cbCredit.Location = new System.Drawing.Point(499, 55);
            this.cbCredit.Name = "cbCredit";
            this.cbCredit.Size = new System.Drawing.Size(153, 21);
            this.cbCredit.TabIndex = 30;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(499, 105);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(153, 20);
            this.txtTime.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Debit";
            // 
            // cbSalesAgent
            // 
            this.cbSalesAgent.FormattingEnabled = true;
            this.cbSalesAgent.Location = new System.Drawing.Point(100, 109);
            this.cbSalesAgent.Name = "cbSalesAgent";
            this.cbSalesAgent.Size = new System.Drawing.Size(153, 21);
            this.cbSalesAgent.TabIndex = 13;
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(100, 25);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(153, 21);
            this.cbSupplier.TabIndex = 11;
            this.cbSupplier.SelectedIndexChanged += new System.EventHandler(this.cbSupplier_SelectedIndexChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(100, 55);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(277, 20);
            this.txtAddress.TabIndex = 10;
            // 
            // txtExplain
            // 
            this.txtExplain.Location = new System.Drawing.Point(100, 81);
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(277, 20);
            this.txtExplain.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Explain";
            // 
            // cbDebit
            // 
            this.cbDebit.FormattingEnabled = true;
            this.cbDebit.Location = new System.Drawing.Point(499, 25);
            this.cbDebit.Name = "cbDebit";
            this.cbDebit.Size = new System.Drawing.Size(153, 21);
            this.cbDebit.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sales agent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier";
            // 
            // tbPOL
            // 
            this.tbPOL.Controls.Add(this.dateTimePicker4);
            this.tbPOL.Controls.Add(this.dateTimePicker3);
            this.tbPOL.Controls.Add(this.label7);
            this.tbPOL.Controls.Add(this.labFrom);
            this.tbPOL.Controls.Add(this.btnSearch);
            this.tbPOL.Controls.Add(this.dataGridView2);
            this.tbPOL.Location = new System.Drawing.Point(4, 22);
            this.tbPOL.Name = "tbPOL";
            this.tbPOL.Padding = new System.Windows.Forms.Padding(3);
            this.tbPOL.Size = new System.Drawing.Size(699, 482);
            this.tbPOL.TabIndex = 1;
            this.tbPOL.Text = "PO List";
            this.tbPOL.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(331, 28);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker4.TabIndex = 5;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(58, 29);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker3.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "To";
            // 
            // labFrom
            // 
            this.labFrom.AutoSize = true;
            this.labFrom.Location = new System.Drawing.Point(22, 35);
            this.labFrom.Name = "labFrom";
            this.labFrom.Size = new System.Drawing.Size(30, 13);
            this.labFrom.TabIndex = 2;
            this.labFrom.Text = "From";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(500, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 26);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 75);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(693, 404);
            this.dataGridView2.TabIndex = 0;
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 513);
            this.Controls.Add(this.tabPOL);
            this.Name = "frmPurchase";
            this.Text = "Purchasecs";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            this.tabPOL.ResumeLayout(false);
            this.tbPO.ResumeLayout(false);
            this.tbPO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbTTC.ResumeLayout(false);
            this.gbTTC.PerformLayout();
            this.tbPOL.ResumeLayout(false);
            this.tbPOL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPOL;
        private System.Windows.Forms.TabPage tbPO;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIDPO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaterial;
        private System.Windows.Forms.DataGridViewComboBoxColumn clMaterialDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clItemTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox gbTTC;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSalesAgent;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDebit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbPOL;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labFrom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbCredit;
    }
}