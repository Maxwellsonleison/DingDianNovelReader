using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using 顶点云;


namespace 顶点云
{
    public partial class MainFom : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);
        private const int WM_SETREDRAW = 11;

        static RecommendedToday _rt;
        static DirectoryList _dl;
        static ContextReader _ct;
        static MarkList _ml;
        static WholeNovelsFom _wnf;
        static LocalNovels _ln;
        public MainFom()
        {
            InitializeComponent();
            
        }


        Point mPoint;
        //申请一个新线程执行操作
        Thread new_t;
        private void MainFom_Shown(object sender, EventArgs e)
        {
            //开启初始界面
            Button5_Click(sender,e);

            Webparser wb = new Webparser("http://www.booktxt.net");
            var t = Getwebsite.Set_url(@"G:\Visualproject\顶点云\Weblocal.txt");
            new_t = new Thread(new ParameterizedThreadStart(Webparser.Htmltest));
            new_t.IsBackground = true;
            new_t.Start("http://www.booktxt.net");
            new_t = new Thread(wb.GetCollection);
            new_t.IsBackground = true;
            new_t.Start();

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.Invalidate();
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Invalidate();
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 更新对应按键背景图
        /// </summary>
        /// <param name="http"></param>
        private void UpdatingBackImageFromWeb(Stream webstream, Button btn)
        {
            //从流加载图片
            btn.BackgroundImage = Image.FromStream(webstream);

            Invalidate();
        }

        /// <summary>
        /// 从指定缓存更新指定bt背景图
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="btn"></param>
        private void UpdatingBackImageFromCache(string cache, Button btn)
        {
            //检查缓存文件是否存在
            if (!File.Exists(cache))
                return;

            btn.BackgroundImage = Image.FromFile(cache);
            Invalidate();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            _wnf = new WholeNovelsFom();
            _wnf.Location = new Point(0, 0);
            _wnf.Width = panel3.Width;
            _wnf.Height = panel3.Height;

            _wnf.bookBox1.P_btn.Click += Btn_Click;
            _wnf.bookBox2.P_btn.Click += Btn_Click;
            _wnf.bookBox3.P_btn.Click += Btn_Click;
            _wnf.bookBox4.P_btn.Click += Btn_Click;
 

            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(_wnf);
            _wnf.Anchor = AnchorStyles.Bottom;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            _rt= new RecommendedToday();
            _rt.Location = new Point(0, 0);
            _rt.bookBox1.P_btn.Click += Btn_Click;
            _rt.bookBox2.P_btn.Click += Btn_Click;
            _rt.bookBox3.P_btn.Click += Btn_Click;
            _rt.bookBox4.P_btn.Click += Btn_Click;

            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(_rt);
            _rt.Width = panel3.Width;
            _rt.Height = panel3.Height;
            _rt.AutoSize = true;
            _rt.Anchor = AnchorStyles.Bottom;

        }

        #region 移动窗口
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);

        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion
        private void Button7_Click(object sender, EventArgs e)
        {
            _ln = new LocalNovels();
            _ln.Location = new Point(0, 0);
            Button N_btn = new Button();
            N_btn.Click += Btn_Click;

            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(_ln);
            _ln.Width = panel3.Width;
            _ln.Height = panel3.Height;
            _ln.AutoSize = true;
            _ln.Anchor = AnchorStyles.Bottom;
            _ln.Anchor = AnchorStyles.Left;
            _ln.Anchor = AnchorStyles.Top;
            _ln.Anchor = AnchorStyles.Right;
            _ln.add_btn.Click += new EventHandler(SelectFile);
        }
        private void SelectFile(object sender, EventArgs e)
        {

            Thread t = new Thread(Copy_File);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        private void Copy_File()
        {
            FileDialog f_dia = new OpenFileDialog();
            f_dia.Title = "选择文件";
            f_dia.Filter = "文本文件|*.txt";
            if (f_dia.ShowDialog() == DialogResult.OK)
            {
                File.Copy(f_dia.FileName, Path.Combine(@"G:\Visualproject\顶点云\Cache", System.DateTime.UtcNow.ToFileTimeUtc().ToString()+".txt"), true);
               //updata filelog
            }


        }

        private void Button11_Click(object sender, EventArgs e)
        {
            _ml = new MarkList();
            _ml.Location = new Point(0, 0);


            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(_ml);
            _ml.Width = panel3.Width;
            _ml.Height = panel3.Height;
            _ml.AutoSize = true;
            _ml.Anchor = AnchorStyles.Bottom;
            _ml.Anchor = AnchorStyles.Left;
            _ml.Anchor = AnchorStyles.Top;
            _ml.Anchor = AnchorStyles.Right;
        }
        //

         private async void ADD_Link()
         {
            int lines = 0;
            List<string> e_linr = File.ReadLines(@"G:\Visualproject\顶点云\Cache\lists\4.cache").ToList<string>();
            if(e_linr.Count<153)
            {
                for (int i = 0; i < e_linr.Count; i++)
                {
                    if (e_linr[i].Contains("|") && lines < 153)
                    {
                        lines = i;
                        LinkLabel _l = new LinkLabel();
                        _l.MaximumSize = new Size(1000, 20);
                        _l.AutoEllipsis = true;
                        //_l.AutoSize = true;
                        _l.Text = e_linr[lines].Substring(0, e_linr[lines].LastIndexOf("|"));
                        _dl.ListContent.Controls.Add(_l);
                    }
                }
            }
            else
            {
                int _page = e_linr.Count / 153; //总页数
                int cc = e_linr.Count - _page*153;//剩下的条目
                _dl.Controls.Add(new LinkLabel { Text = (_page - 1).ToString() }) ;
            }
                      
        }

        private void Btn_Click(object sender,EventArgs e)
        {                     
            //_dl = new DirectoryList();
            WebBrowser wb = new WebBrowser();
            wb.Size = panel3.Size;
            wb.ScriptErrorsSuppressed = true;
            wb.Navigate(@"C:\Users\Administrator\Desktop\全职法师最新章节_全职法师无弹窗全文阅读_顶点小说.html");
            panel3.Controls.Clear();
            panel3.Controls.Add(wb);
            //_dl.Backed.Click += Back_Clicked;
            //_dl.LastLevel.Click += ListLink_Clicked;
            //_dl.ListContent.Controls.Clear();

            //_dl.Width = panel3.Width;
            //_dl.Height = panel3.Height;
            //_dl.AutoSize = true;
            //_dl.Anchor = AnchorStyles.Bottom;
            

            //Add_list();


            //ADD_Link();

            

        }

        /// <summary>
        /// 按下返回时操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Clicked(object sender, EventArgs e)
        {
            _rt = new RecommendedToday();
            _rt.Location = new Point(0, 0);
            _rt.bookBox1.P_btn.Click += Btn_Click;
            _rt.bookBox2.P_btn.Click += Btn_Click;
            _rt.bookBox3.P_btn.Click += Btn_Click;
            _rt.bookBox4.P_btn.Click += Btn_Click;

            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(_rt);
            _rt.Width = panel3.Width;
            _rt.Height = panel3.Height;
            _rt.AutoSize = true;
            _rt.Anchor = AnchorStyles.Bottom;
            _rt.Anchor = AnchorStyles.Left;
            _rt.Anchor = AnchorStyles.Top;
            _rt.Anchor = AnchorStyles.Right;
        }//考虑静态变量处理控件

        

        //按下目录索引时操作
        private void ListLink_Clicked(object sender,EventArgs e)
        {
            _ct = new ContextReader();
            panel3.Controls.Clear();
            panel3.Controls.Add(_ct);
        }

    }

    
}
