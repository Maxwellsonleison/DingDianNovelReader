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
    public partial class MarkList : UserControl
    {
        public MarkList()
        {
            InitializeComponent();
        }

        public static List<string> lis_coll { get; set; }

        private void MarkList_Load(object sender, EventArgs e)
        {
            //if(lis_coll.Count>0&&lis_coll!=null)
            //M_List_Box.Items.Add(lis_coll);
        }
    }
}
