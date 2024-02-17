namespace Accountant_Software.Project
{
    partial class frmMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btSale = new System.Windows.Forms.Button();
            this.btGeneralDiary = new System.Windows.Forms.Button();
            this.btPurchase = new System.Windows.Forms.Button();
            this.btSupplier = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSale
            // 
            this.btSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSale.Location = new System.Drawing.Point(34, 18);
            this.btSale.Name = "btSale";
            this.btSale.Size = new System.Drawing.Size(143, 50);
            this.btSale.TabIndex = 0;
            this.btSale.Text = "Sale";
            this.btSale.UseVisualStyleBackColor = true;
            this.btSale.Click += new System.EventHandler(this.btSale_Click);
            // 
            // btGeneralDiary
            // 
            this.btGeneralDiary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGeneralDiary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btGeneralDiary.Location = new System.Drawing.Point(34, 401);
            this.btGeneralDiary.Name = "btGeneralDiary";
            this.btGeneralDiary.Size = new System.Drawing.Size(143, 50);
            this.btGeneralDiary.TabIndex = 1;
            this.btGeneralDiary.Text = "Accounting";
            this.btGeneralDiary.UseVisualStyleBackColor = true;
            this.btGeneralDiary.Click += new System.EventHandler(this.btGeneralDiary_Click);
            // 
            // btPurchase
            // 
            this.btPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPurchase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btPurchase.Location = new System.Drawing.Point(34, 74);
            this.btPurchase.Name = "btPurchase";
            this.btPurchase.Size = new System.Drawing.Size(143, 50);
            this.btPurchase.TabIndex = 2;
            this.btPurchase.Text = "Purchase";
            this.btPurchase.UseVisualStyleBackColor = true;
            this.btPurchase.Click += new System.EventHandler(this.btPurchase_Click);
            // 
            // btSupplier
            // 
            this.btSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSupplier.Location = new System.Drawing.Point(34, 203);
            this.btSupplier.Name = "btSupplier";
            this.btSupplier.Size = new System.Drawing.Size(143, 50);
            this.btSupplier.TabIndex = 3;
            this.btSupplier.Text = "Supplier";
            this.btSupplier.UseVisualStyleBackColor = true;
            this.btSupplier.Click += new System.EventHandler(this.btIncome_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUsers.Location = new System.Drawing.Point(34, 259);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(143, 50);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "Agent";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCustomer.Location = new System.Drawing.Point(34, 147);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(143, 50);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProduct.Location = new System.Drawing.Point(34, 330);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(143, 50);
            this.btnProduct.TabIndex = 8;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProductE_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(183, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 493);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KPI";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 19);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(305, 206);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btSupplier);
            this.Controls.Add(this.btPurchase);
            this.Controls.Add(this.btGeneralDiary);
            this.Controls.Add(this.btSale);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSale;
        private System.Windows.Forms.Button btGeneralDiary;
        private System.Windows.Forms.Button btPurchase;
        private System.Windows.Forms.Button btSupplier;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}