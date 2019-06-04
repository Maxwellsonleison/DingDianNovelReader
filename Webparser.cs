using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 顶点云
{
    public class Webparser:NovelsCollectionInfo
    {
        public Webparser(string url)
        {
            _defaultUri = url;
        }
        static string _defaultUri;
        static string _cachelocal= @"G:\Visualproject\顶点云\Cache";

        /*
         懒得写正则了，cnm正则是真的难写，后面两个暂时写的能用就用吧
             */
        //提取href正则
        static readonly Regex reg_href = new Regex("<a([\\s]+|[\\s]+[^<>]+[\\s]+)href=(\"(?<href>[^<>\"']*)\"|'(?<href>[^<>\"']*)')[^<>]*");
        //提取img正则
        static readonly Regex reg_rec = new Regex(@"(?i)<img[^>]*?\ssrc\s*=\s*(['""]?)(?<src>[^'""\s>]+)\1[^>]*>");
         public enum Types
        {
            科幻小说,
            网游小说,
            穿越小说,
            都市小说,
            修真小说,
            玄幻小说,
            仙侠小说,
            耽美小说,
            言情小说,
            推理小说,
            恐怖灵异,
            历史小说,
            名著,
            散文,
            其他
        }


        /// <summary>
        /// 异步线程集合
        /// </summary>
        /// <returns></returns>
        public  void GetCollection()
        {
            Htmltest(_defaultUri);
            int i = 0;
            foreach (string item in _nameInfo)
            {               
                SetImage(item,Path.Combine(_cachelocal,"picture",i+".cache"));
                
                i++;
            }
            Set_ListCache("https://www.booktxt.net/5_5552/", Path.Combine(_cachelocal, "lists", i + ".cache"));
        }

        private void Set_ListCache(string url, string cache)
        {
            if (!Directory.Exists(Path.Combine(_cachelocal, "lists")))
            {
                Directory.CreateDirectory(Path.Combine(_cachelocal, "lists"));
            }
            File.AppendAllLines(cache, ListFromLink(url));

        }

        /// <summary>
        /// 提取图片
        /// </summary>
        public static void SetImage(string url,string cache)
        {
            if (!Directory.Exists(Path.Combine(_cachelocal, "picture")))
            {
                Directory.CreateDirectory(Path.Combine(_cachelocal, "picture"));
            }
            Uri Adress = new Uri(url);
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(Adress);
            Request.KeepAlive = true;
            Request.ProtocolVersion = HttpVersion.Version11;
            Request.Method = "GET";
            Request.Accept = "*/* ";
            Request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/536.5 (KHTML, like Gecko) Chrome/19.0.1084.56 Safari/536.5";
            Request.Referer = Adress.AbsolutePath;
            HttpWebResponse htmlResponse = (HttpWebResponse)Request.GetResponse();


            using (Stream st = htmlResponse.GetResponseStream())
            {                
                Image bt = Bitmap.FromStream(st,true);
                //图片保存在缓存文件中
                bt.Save(cache);
            }
     
        }
        public static string _s="";
        public static string _st = "";

        /// <summary>
        /// 提取图片链接
        /// </summary>
        /// <param name="http"></param>
        public  static void Htmltest(object http)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument htmldoc = web.Load(http as string);
            _nameInfo = new List<string>();
            _coverInfo = new List<string>();

            //HtmlNode _collect = htmldoc.DocumentNode.SelectSingleNode("//div[@class='l']");
            HtmlNode hot_node = htmldoc.DocumentNode.SelectSingleNode("//div[@id='hotcontent']/div[@class='l']");
            HtmlNodeCollection _collection = hot_node.SelectNodes("//div[@class='item']");
            foreach(HtmlNode _htmlnode in _collection)
            {
                //HtmlNode _Mv = _htmlnode.SelectSingleNode("//div[@class='item']");
                HtmlNode _Nv = _htmlnode.SelectSingleNode("//img[@src]");

                HtmlNode _Cv = _htmlnode.SelectSingleNode("//div[@class='image']/a[@href]");

                _nameInfo.Add(_Nv.Attributes[0].Value);
                _coverInfo.Add(_Cv.Attributes[0].Value);
            }
        }

        /// <summary>
        /// 提取目录
        /// </summary>
        /// <param name="http"></param>
        /// <returns></returns>
        public static List<string> ListFromLink(object http)
        {
            HtmlWeb list_web = new HtmlWeb();
            list_web.OverrideEncoding = Encoding.GetEncoding("gb2312");

            HtmlDocument list_doc = list_web.Load(http as string);
            
            List<string> l_ss = new List<string>();
            l_ss.Add(list_doc.Encoding.ToString());
            HtmlNode list_node = list_doc.DocumentNode.SelectSingleNode("//div[@id='list']");
            HtmlNodeCollection list_collec = list_node.SelectNodes("//dd/a[@href]");
            foreach(HtmlNode item in list_collec)
            {
                l_ss.Add(item.InnerText+"|"+item.Attributes["href"].Value);
            }
            return l_ss;
        }

        /// <summary>
        /// 提取网页中的章节内容
        /// </summary>
        /// <param name="http"></param>
        /// <returns></returns>
        public static string ContentFromLink(object http)
        {

            HtmlWeb content_web = new HtmlWeb();
            content_web.OverrideEncoding = Encoding.GetEncoding("gb2312");
            StringBuilder s_bu = new StringBuilder();

            HtmlDocument content_doc = content_web.Load(http as string);

            HtmlNode content_nodes = content_doc.DocumentNode.SelectSingleNode("//div[@id='content']");
            s_bu.Append(content_nodes.InnerText.Replace("&nbsp;&nbsp;", "\n"));
            return s_bu.ToString();
        }
    }
}
