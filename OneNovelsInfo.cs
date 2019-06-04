using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 顶点云
{
    /// <summary>
    /// 小说信息公有类
    /// </summary>
    public class OneNovelsInfo
    {
        /// <summary>
        /// 初始化对象
        /// </summary>
        /// <param name="name"></param>
        /// <param name="a_name"></param>
        /// <param name="number"></param>
        /// <param name="type"></param>
        /// <param name="intro"></param>
        public OneNovelsInfo(string name,string au_name,int number,Webparser.Types _type,string intro)
        {
            _Name = name;
            _Author = au_name;
            _Numbers = number.ToString();
            _Type = _type.ToString();
            _Introduction = intro;
        }

        /// <summary>
        /// 书名
        /// </summary>
        public string _Name { get; internal set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string _Author { get; internal set; }

        /// <summary>
        /// 字数
        /// </summary>
        public string _Numbers { get; internal set; }

        /// <summary>
        /// 分类
        /// </summary>
        public string _Type { get; internal set; }

        /// <summary>
        /// 介绍
        /// </summary>
        public string _Introduction { get; internal set; }

    }
}
