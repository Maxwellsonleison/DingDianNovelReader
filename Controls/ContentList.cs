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
    public partial class ContentList : UserControl
    {
        public float single_line { get; set; } = 20;//单个索引的绘制宽度
        public float single_width { get; set; } = 500;//单个索引的绘制长度
        public float LineSpace { get; set; } = 50;//行距

        float draw_x=0, draw_y=0;//绘制行横纵坐标
        Rectangle draw_rec;//单个绘制矩形区域

        public string draw_singleline;//绘制的一行

        public ICollection<string> Draw_Collection;//定义一个绘制目标的集合

        private string Get_Drawsingleline()
        {
            int Lines = 0;
            foreach (string item in Draw_Collection)
            {
                draw_singleline += item + "\t";
            }
            return draw_singleline;
        }
        public ContentList()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Draw_Collection == null)
                return;

            int Lines = 0;
            var g = e.Graphics;

            Brush b_rush = new SolidBrush(Color.Blue);
            
            foreach (string item in Draw_Collection)
            {               
                if (Lines < 3)
                {
                    draw_singleline += item + "\t";
                    Lines++;                   
                }
                else
                {
                    Lines = 0;
                    SizeF sizeF = g.MeasureString(draw_singleline, Font, Width, StringFormat.GenericDefault);
                    //仅绘制可见区域
                    if (g.IsVisible(draw_x,draw_y))
                    {
                        g.DrawString(draw_singleline, Font, b_rush, draw_x, draw_y);                                               
                    }
                    draw_y += (sizeF.Height + LineSpace);
                }
            }

            b_rush.Dispose();
                        
        }
    }
}
