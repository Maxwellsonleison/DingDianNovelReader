namespace 顶点云
{
    partial class RecommendedToday
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookBox4 = new 顶点云.BookBox();
            this.bookBox3 = new 顶点云.BookBox();
            this.bookBox2 = new 顶点云.BookBox();
            this.bookBox1 = new 顶点云.BookBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("李旭科书法", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(22, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "今日推荐";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.bookBox4);
            this.panel1.Controls.Add(this.bookBox3);
            this.panel1.Controls.Add(this.bookBox2);
            this.panel1.Controls.Add(this.bookBox1);
            this.panel1.Location = new System.Drawing.Point(27, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 273);
            this.panel1.TabIndex = 22;
            // 
            // bookBox4
            // 
            this.bookBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookBox4.Location = new System.Drawing.Point(579, 16);
            this.bookBox4.Name = "bookBox4";
            this.bookBox4.Size = new System.Drawing.Size(147, 236);
            this.bookBox4.TabIndex = 3;
            // 
            // bookBox3
            // 
            this.bookBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookBox3.Location = new System.Drawing.Point(391, 16);
            this.bookBox3.Name = "bookBox3";
            this.bookBox3.Size = new System.Drawing.Size(147, 236);
            this.bookBox3.TabIndex = 2;
            // 
            // bookBox2
            // 
            this.bookBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookBox2.Location = new System.Drawing.Point(203, 16);
            this.bookBox2.Name = "bookBox2";
            this.bookBox2.Size = new System.Drawing.Size(147, 236);
            this.bookBox2.TabIndex = 1;
            // 
            // bookBox1
            // 
            this.bookBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookBox1.Location = new System.Drawing.Point(15, 16);
            this.bookBox1.Name = "bookBox1";
            this.bookBox1.Size = new System.Drawing.Size(147, 236);
            this.bookBox1.TabIndex = 0;
            this.bookBox1.P_BtnClicked += new 顶点云.BookBox.BtnClickHandle(this.kcc);
            // 
            // RecommendedToday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "RecommendedToday";
            this.Size = new System.Drawing.Size(789, 486);
            this.SizeChanged += new System.EventHandler(this.RecommendedToday_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public BookBox bookBox4;
        public BookBox bookBox3;
        public BookBox bookBox2;
        public BookBox bookBox1;
    }
}
