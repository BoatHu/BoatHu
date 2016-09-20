namespace order.view
{
    partial class UserInfo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.会员名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.会员性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.会员电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.编辑 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.删除 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.会员名称,
            this.会员性别,
            this.会员电话,
            this.编辑,
            this.删除});
            this.dataGridView1.Location = new System.Drawing.Point(2, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1106, 537);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 会员名称
            // 
            this.会员名称.DataPropertyName = "\"编辑\"";
            this.会员名称.HeaderText = "会员名称";
            this.会员名称.Name = "会员名称";
            // 
            // 会员性别
            // 
            this.会员性别.HeaderText = "会员性别";
            this.会员性别.Name = "会员性别";
            // 
            // 会员电话
            // 
            this.会员电话.HeaderText = "会员电话";
            this.会员电话.Name = "会员电话";
            // 
            // 编辑
            // 
            this.编辑.HeaderText = "编辑";
            this.编辑.Name = "编辑";
            this.编辑.Text = "编辑";
            this.编辑.ToolTipText = "编辑";
            // 
            // 删除
            // 
            this.删除.HeaderText = "删除";
            this.删除.Name = "删除";
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 605);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserInfo";
            this.Text = "UserInfo";
            this.Load += new System.EventHandler(this.UserInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 会员名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 会员性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 会员电话;
        private System.Windows.Forms.DataGridViewButtonColumn 编辑;
        private System.Windows.Forms.DataGridViewButtonColumn 删除;
    }
}