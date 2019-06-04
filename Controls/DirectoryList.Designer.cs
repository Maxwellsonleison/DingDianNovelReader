namespace 顶点云
{
    partial class DirectoryList
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
            this.DL_title = new System.Windows.Forms.Label();
            this.LastLevel = new System.Windows.Forms.LinkLabel();
            this.Backed = new System.Windows.Forms.LinkLabel();
            this.ListContent = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.ListContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // DL_title
            // 
            this.DL_title.AutoSize = true;
            this.DL_title.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DL_title.Location = new System.Drawing.Point(327, 25);
            this.DL_title.Name = "DL_title";
            this.DL_title.Size = new System.Drawing.Size(54, 21);
            this.DL_title.TabIndex = 0;
            this.DL_title.Text = "目录";
            // 
            // LastLevel
            // 
            this.LastLevel.AutoSize = true;
            this.LastLevel.Location = new System.Drawing.Point(543, 29);
            this.LastLevel.Name = "LastLevel";
            this.LastLevel.Size = new System.Drawing.Size(41, 12);
            this.LastLevel.TabIndex = 1;
            this.LastLevel.TabStop = true;
            this.LastLevel.Text = "上一级";
            // 
            // Backed
            // 
            this.Backed.AutoSize = true;
            this.Backed.Location = new System.Drawing.Point(136, 29);
            this.Backed.Name = "Backed";
            this.Backed.Size = new System.Drawing.Size(29, 12);
            this.Backed.TabIndex = 2;
            this.Backed.TabStop = true;
            this.Backed.Text = "返回";
            // 
            // ListContent
            // 
            this.ListContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListContent.AutoScroll = true;
            this.ListContent.Controls.Add(this.linkLabel3);
            this.ListContent.Controls.Add(this.linkLabel4);
            this.ListContent.Controls.Add(this.linkLabel5);
            this.ListContent.Controls.Add(this.linkLabel6);
            this.ListContent.Location = new System.Drawing.Point(3, 74);
            this.ListContent.Name = "ListContent";
            this.ListContent.Padding = new System.Windows.Forms.Padding(30);
            this.ListContent.Size = new System.Drawing.Size(714, 373);
            this.ListContent.TabIndex = 3;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(33, 30);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(29, 12);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "返回";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(68, 30);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(29, 12);
            this.linkLabel4.TabIndex = 4;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "返回";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(103, 30);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(29, 12);
            this.linkLabel5.TabIndex = 5;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "返回";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(138, 30);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(29, 12);
            this.linkLabel6.TabIndex = 6;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "返回";
            // 
            // DirectoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListContent);
            this.Controls.Add(this.Backed);
            this.Controls.Add(this.LastLevel);
            this.Controls.Add(this.DL_title);
            this.Name = "DirectoryList";
            this.Size = new System.Drawing.Size(720, 450);
            this.ListContent.ResumeLayout(false);
            this.ListContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DL_title;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        public System.Windows.Forms.LinkLabel Backed;
        public System.Windows.Forms.LinkLabel LastLevel;
        public System.Windows.Forms.FlowLayoutPanel ListContent;
    }
}
