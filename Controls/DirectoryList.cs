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
    public partial class DirectoryList : UserControl
    {
        public DirectoryList()
        {
            InitializeComponent();
            //开启双缓冲防止绘制的时候闪烁
            DoubleBuffered = true;
            
        }
    }
}
