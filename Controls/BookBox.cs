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
    public partial class BookBox : UserControl
    {

        public delegate void BtnClickHandle(object sender, EventArgs e);

        public event BtnClickHandle P_BtnClicked;

        private void btn_Click(object sender, EventArgs e)
        {
            if (P_BtnClicked != null)
                P_BtnClicked(sender, new EventArgs());//把按钮自身作为参数传递
        }
        enum property
        {
            作者,
            名称,
            添加时间,
            未知,
        }
        /// <summary>
        /// 设置作者字段，默认为空
        /// </summary>
        public static string _autName = "";
        /// <summary>
        /// 设置作品名称，默认为空
        /// </summary>
        public static string _novNmae = "";
        /// <summary>
        /// 设置添加时间，使用标准时间格式【年/月/日】
        /// </summary>
        public static string _addTime = "";

        public static Image _image;
        public BookBox()
        {
            InitializeComponent();
        }

        //private void Btn_click(object sender,EventArgs e)
        //{
        //    MessageBox.Show(property.作者.ToString());
        //}
        private void BookBox_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(_autName))
            {
                
                N_lab.Text = property.作者.ToString() + _autName;
            }
            else
            {
                this.N_lab.Text = property.作者.ToString() + property.未知.ToString();
            }
            if (!string.IsNullOrEmpty(_novNmae))
            {
                A_lab.Text = property.名称.ToString()+ _autName;
            }
            else
            {
                A_lab.Text = property.名称.ToString() + property.未知.ToString();
            }
            if (!string.IsNullOrEmpty(_addTime))
            {
                T_lab.Text = property.添加时间.ToString()+_autName;
            }
            else
            {
                T_lab.Text = property.添加时间.ToString() + property.未知.ToString();
            }

            if (_image!=null)
            {
                P_btn.BackgroundImage = _image;
            }
            else
            {
                //P_btn.BackgroundImage = null;
            }
        }
    }
}
