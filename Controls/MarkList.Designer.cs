namespace 顶点云
{
    partial class MarkList
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
            this.M_List_Box = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // M_List_Box
            // 
            this.M_List_Box.BackColor = System.Drawing.Color.White;
            this.M_List_Box.FormattingEnabled = true;
            this.M_List_Box.Location = new System.Drawing.Point(3, 3);
            this.M_List_Box.Name = "M_List_Box";
            this.M_List_Box.Size = new System.Drawing.Size(593, 468);
            this.M_List_Box.TabIndex = 1;
            // 
            // MarkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.M_List_Box);
            this.Name = "MarkList";
            this.Size = new System.Drawing.Size(599, 476);
            this.Load += new System.EventHandler(this.MarkList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox M_List_Box;
    }
}
