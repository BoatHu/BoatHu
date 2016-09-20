namespace order.view
{
    partial class BusinessInfoEdit
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.goodsAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.goodsVipPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.goodsPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goodsName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(772, 620);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(952, 620);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 22;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // goodsAmount
            // 
            this.goodsAmount.Location = new System.Drawing.Point(303, 398);
            this.goodsAmount.Margin = new System.Windows.Forms.Padding(4);
            this.goodsAmount.Name = "goodsAmount";
            this.goodsAmount.Size = new System.Drawing.Size(367, 28);
            this.goodsAmount.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 402);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "商品库存";
            // 
            // goodsVipPrice
            // 
            this.goodsVipPrice.Location = new System.Drawing.Point(303, 280);
            this.goodsVipPrice.Margin = new System.Windows.Forms.Padding(4);
            this.goodsVipPrice.Name = "goodsVipPrice";
            this.goodsVipPrice.Size = new System.Drawing.Size(367, 28);
            this.goodsVipPrice.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "商品会员价格";
            // 
            // goodsPrice
            // 
            this.goodsPrice.Location = new System.Drawing.Point(303, 156);
            this.goodsPrice.Margin = new System.Windows.Forms.Padding(4);
            this.goodsPrice.Name = "goodsPrice";
            this.goodsPrice.Size = new System.Drawing.Size(367, 28);
            this.goodsPrice.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "商品普通价格";
            // 
            // goodsName
            // 
            this.goodsName.Location = new System.Drawing.Point(303, 56);
            this.goodsName.Margin = new System.Windows.Forms.Padding(4);
            this.goodsName.Name = "goodsName";
            this.goodsName.Size = new System.Drawing.Size(367, 28);
            this.goodsName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "商品名称";
            // 
            // BusinessInfoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 798);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.goodsAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.goodsVipPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goodsPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goodsName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BusinessInfoEdit";
            this.Text = "BusinessInfoEdit";
            this.Load += new System.EventHandler(this.BusinessInfoEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox goodsAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox goodsVipPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox goodsPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox goodsName;
        private System.Windows.Forms.Label label1;
    }
}