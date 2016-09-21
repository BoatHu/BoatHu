namespace order.view
{
    partial class Main
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

        #region Windows Form Designer generated codef

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainWindow = new System.Windows.Forms.TabControl();
            this.userInfo = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.userInfoGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.userInfoPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userInfoName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.businessRecord = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.receiverName = new System.Windows.Forms.TextBox();
            this.isInTime = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.businessId = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.Button();
            this.goodsInfo = new System.Windows.Forms.TabPage();
            this.button14 = new System.Windows.Forms.Button();
            this.goodsInfoGridView = new System.Windows.Forms.DataGridView();
            this.button15 = new System.Windows.Forms.Button();
            this.goodId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.goodsName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mainWindow.SuspendLayout();
            this.userInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoGrid)).BeginInit();
            this.businessRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.goodsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsInfoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainWindow
            // 
            this.mainWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainWindow.Controls.Add(this.userInfo);
            this.mainWindow.Controls.Add(this.businessRecord);
            this.mainWindow.Controls.Add(this.goodsInfo);
            this.mainWindow.Location = new System.Drawing.Point(12, 35);
            this.mainWindow.Name = "mainWindow";
            this.mainWindow.SelectedIndex = 0;
            this.mainWindow.Size = new System.Drawing.Size(1232, 587);
            this.mainWindow.TabIndex = 1;
            this.mainWindow.TabStop = false;
            this.mainWindow.Tag = "主窗体";
            this.mainWindow.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // userInfo
            // 
            this.userInfo.Controls.Add(this.button2);
            this.userInfo.Controls.Add(this.userInfoGrid);
            this.userInfo.Controls.Add(this.button1);
            this.userInfo.Controls.Add(this.userInfoPhone);
            this.userInfo.Controls.Add(this.label2);
            this.userInfo.Controls.Add(this.userInfoName);
            this.userInfo.Controls.Add(this.label1);
            this.userInfo.Location = new System.Drawing.Point(4, 22);
            this.userInfo.Name = "userInfo";
            this.userInfo.Padding = new System.Windows.Forms.Padding(3);
            this.userInfo.Size = new System.Drawing.Size(1183, 526);
            this.userInfo.TabIndex = 0;
            this.userInfo.Text = "会员信息";
            this.userInfo.UseVisualStyleBackColor = true;
            this.userInfo.Click += new System.EventHandler(this.userInfo_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(998, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "增加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userInfoGrid
            // 
            this.userInfoGrid.AllowUserToAddRows = false;
            this.userInfoGrid.AllowUserToDeleteRows = false;
            this.userInfoGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userInfoGrid.Location = new System.Drawing.Point(16, 79);
            this.userInfoGrid.Name = "userInfoGrid";
            this.userInfoGrid.ReadOnly = true;
            this.userInfoGrid.RowTemplate.Height = 23;
            this.userInfoGrid.Size = new System.Drawing.Size(1092, 475);
            this.userInfoGrid.TabIndex = 5;
            this.userInfoGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userInfoGrid_CellContentClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(851, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "搜索或刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userInfoPhone
            // 
            this.userInfoPhone.Location = new System.Drawing.Point(572, 42);
            this.userInfoPhone.Name = "userInfoPhone";
            this.userInfoPhone.Size = new System.Drawing.Size(100, 21);
            this.userInfoPhone.TabIndex = 3;
            this.userInfoPhone.TextChanged += new System.EventHandler(this.userInfoPhone_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "会员电话";
            // 
            // userInfoName
            // 
            this.userInfoName.Location = new System.Drawing.Point(186, 36);
            this.userInfoName.Name = "userInfoName";
            this.userInfoName.Size = new System.Drawing.Size(100, 21);
            this.userInfoName.TabIndex = 1;
            this.userInfoName.TextChanged += new System.EventHandler(this.userInfoName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员名字";
            // 
            // businessRecord
            // 
            this.businessRecord.Controls.Add(this.label6);
            this.businessRecord.Controls.Add(this.receiverName);
            this.businessRecord.Controls.Add(this.isInTime);
            this.businessRecord.Controls.Add(this.button3);
            this.businessRecord.Controls.Add(this.button9);
            this.businessRecord.Controls.Add(this.orderGridView);
            this.businessRecord.Controls.Add(this.endTime);
            this.businessRecord.Controls.Add(this.startTime);
            this.businessRecord.Controls.Add(this.label3);
            this.businessRecord.Controls.Add(this.label4);
            this.businessRecord.Controls.Add(this.label5);
            this.businessRecord.Controls.Add(this.businessId);
            this.businessRecord.Controls.Add(this.select);
            this.businessRecord.Location = new System.Drawing.Point(4, 22);
            this.businessRecord.Name = "businessRecord";
            this.businessRecord.Padding = new System.Windows.Forms.Padding(3);
            this.businessRecord.Size = new System.Drawing.Size(1224, 561);
            this.businessRecord.TabIndex = 1;
            this.businessRecord.Text = "交易记录";
            this.businessRecord.UseVisualStyleBackColor = true;
            this.businessRecord.Click += new System.EventHandler(this.businessRecord_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "收件人：";
            // 
            // receiverName
            // 
            this.receiverName.Location = new System.Drawing.Point(88, 26);
            this.receiverName.Name = "receiverName";
            this.receiverName.Size = new System.Drawing.Size(100, 21);
            this.receiverName.TabIndex = 26;
            this.receiverName.TextChanged += new System.EventHandler(this.receiverName_TextChanged);
            // 
            // isInTime
            // 
            this.isInTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isInTime.AutoSize = true;
            this.isInTime.Location = new System.Drawing.Point(939, 11);
            this.isInTime.Margin = new System.Windows.Forms.Padding(2);
            this.isInTime.Name = "isInTime";
            this.isInTime.Size = new System.Drawing.Size(96, 16);
            this.isInTime.TabIndex = 25;
            this.isInTime.Text = "是否筛选时间\r\n";
            this.isInTime.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(986, 520);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "已完成支付";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Location = new System.Drawing.Point(1071, 30);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 18;
            this.button9.Text = "增加";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // orderGridView
            // 
            this.orderGridView.AllowUserToAddRows = false;
            this.orderGridView.AllowUserToDeleteRows = false;
            this.orderGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(3, 116);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.RowTemplate.Height = 23;
            this.orderGridView.Size = new System.Drawing.Size(1143, 386);
            this.orderGridView.TabIndex = 17;
            this.orderGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGridView_CellContentClick);
            // 
            // endTime
            // 
            this.endTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endTime.Location = new System.Drawing.Point(744, 23);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(154, 21);
            this.endTime.TabIndex = 16;
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(459, 23);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(154, 21);
            this.startTime.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(662, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "结束时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "开始时间:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "订单号：";
            // 
            // businessId
            // 
            this.businessId.Location = new System.Drawing.Point(277, 23);
            this.businessId.Name = "businessId";
            this.businessId.Size = new System.Drawing.Size(100, 21);
            this.businessId.TabIndex = 11;
            this.businessId.TextChanged += new System.EventHandler(this.businessId_TextChanged);
            // 
            // select
            // 
            this.select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.select.Location = new System.Drawing.Point(940, 30);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(75, 23);
            this.select.TabIndex = 10;
            this.select.Text = "查询";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // goodsInfo
            // 
            this.goodsInfo.Controls.Add(this.button14);
            this.goodsInfo.Controls.Add(this.goodsInfoGridView);
            this.goodsInfo.Controls.Add(this.button15);
            this.goodsInfo.Controls.Add(this.goodId);
            this.goodsInfo.Controls.Add(this.label9);
            this.goodsInfo.Controls.Add(this.goodsName);
            this.goodsInfo.Controls.Add(this.label10);
            this.goodsInfo.Location = new System.Drawing.Point(4, 22);
            this.goodsInfo.Name = "goodsInfo";
            this.goodsInfo.Padding = new System.Windows.Forms.Padding(3);
            this.goodsInfo.Size = new System.Drawing.Size(1183, 526);
            this.goodsInfo.TabIndex = 2;
            this.goodsInfo.Text = "商品信息";
            this.goodsInfo.UseVisualStyleBackColor = true;
            this.goodsInfo.Click += new System.EventHandler(this.goodsInfo_Click);
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.Location = new System.Drawing.Point(963, 31);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 17;
            this.button14.Text = "增加";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // goodsInfoGridView
            // 
            this.goodsInfoGridView.AllowUserToAddRows = false;
            this.goodsInfoGridView.AllowUserToDeleteRows = false;
            this.goodsInfoGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goodsInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsInfoGridView.Location = new System.Drawing.Point(27, 86);
            this.goodsInfoGridView.Name = "goodsInfoGridView";
            this.goodsInfoGridView.ReadOnly = true;
            this.goodsInfoGridView.RowTemplate.Height = 23;
            this.goodsInfoGridView.Size = new System.Drawing.Size(1043, 375);
            this.goodsInfoGridView.TabIndex = 16;
            this.goodsInfoGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.goodsInfoGridView_CellContentClick);
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.Location = new System.Drawing.Point(832, 30);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 15;
            this.button15.Text = "搜索";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // goodId
            // 
            this.goodId.Location = new System.Drawing.Point(583, 33);
            this.goodId.Name = "goodId";
            this.goodId.Size = new System.Drawing.Size(100, 21);
            this.goodId.TabIndex = 14;
            this.goodId.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(468, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "商品id";
            // 
            // goodsName
            // 
            this.goodsName.Location = new System.Drawing.Point(197, 27);
            this.goodsName.Name = "goodsName";
            this.goodsName.Size = new System.Drawing.Size(100, 21);
            this.goodsName.TabIndex = 12;
            this.goodsName.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "商品名字";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 634);
            this.Controls.Add(this.mainWindow);
            this.Name = "Main";
            this.Text = "主窗体";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainWindow.ResumeLayout(false);
            this.userInfo.ResumeLayout(false);
            this.userInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoGrid)).EndInit();
            this.businessRecord.ResumeLayout(false);
            this.businessRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.goodsInfo.ResumeLayout(false);
            this.goodsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsInfoGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainWindow;
        private System.Windows.Forms.TabPage userInfo;
        private System.Windows.Forms.TabPage businessRecord;
        private System.Windows.Forms.TabPage goodsInfo;
        private System.Windows.Forms.TextBox userInfoName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userInfoPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox businessId;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView userInfoGrid;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.DataGridView goodsInfoGridView;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox goodId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox goodsName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox isInTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox receiverName;
    }
}