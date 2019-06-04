namespace 顶点云
{
    partial class BookBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookBox));
            this.P_btn = new System.Windows.Forms.Button();
            this.N_lab = new System.Windows.Forms.Label();
            this.A_lab = new System.Windows.Forms.Label();
            this.T_lab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // P_btn
            // 
            this.P_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.P_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("P_btn.BackgroundImage")));
            this.P_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.P_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P_btn.Location = new System.Drawing.Point(26, 15);
            this.P_btn.Name = "P_btn";
            this.P_btn.Size = new System.Drawing.Size(96, 125);
            this.P_btn.TabIndex = 1;
            this.P_btn.UseVisualStyleBackColor = true;
            // 
            // N_lab
            // 
            this.N_lab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.N_lab.AutoSize = true;
            this.N_lab.Location = new System.Drawing.Point(50, 159);
            this.N_lab.Name = "N_lab";
            this.N_lab.Size = new System.Drawing.Size(29, 12);
            this.N_lab.TabIndex = 2;
            this.N_lab.Text = "名称";
            // 
            // A_lab
            // 
            this.A_lab.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.A_lab.AutoSize = true;
            this.A_lab.Location = new System.Drawing.Point(50, 185);
            this.A_lab.Name = "A_lab";
            this.A_lab.Size = new System.Drawing.Size(29, 12);
            this.A_lab.TabIndex = 3;
            this.A_lab.Text = "作者";
            // 
            // T_lab
            // 
            this.T_lab.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.T_lab.AutoSize = true;
            this.T_lab.Location = new System.Drawing.Point(7, 212);
            this.T_lab.Name = "T_lab";
            this.T_lab.Size = new System.Drawing.Size(137, 12);
            this.T_lab.TabIndex = 4;
            this.T_lab.Text = "添加时间：2019年5月6日";
            // 
            // BookBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.T_lab);
            this.Controls.Add(this.A_lab);
            this.Controls.Add(this.N_lab);
            this.Controls.Add(this.P_btn);
            this.Name = "BookBox";
            this.Size = new System.Drawing.Size(147, 236);
            this.Load += new System.EventHandler(this.BookBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label A_lab;
        private System.Windows.Forms.Label T_lab;
        private System.Windows.Forms.Label N_lab;
        public System.Windows.Forms.Button P_btn;
    }
}
