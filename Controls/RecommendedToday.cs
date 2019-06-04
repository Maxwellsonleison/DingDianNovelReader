using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 顶点云
{
    public partial class RecommendedToday : UserControl
    {
        public RecommendedToday()
        {
            InitializeComponent();
        }

        private void kcc(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show("btn1_clicked");
            this.Click += kcc;
        }

        private int Original_L=43;//初始化button位置



        private void RecommendedToday_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
