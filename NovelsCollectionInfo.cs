using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 顶点云
{
    public class NovelsCollectionInfo
    {
        public static IList<string> _title { get; internal set; }

        public static IList<string> _nameInfo { get; internal set; }

        public static IList<string> _coverInfo { get; internal set; }

        public static IList<string> _authorInfo { get; internal set; }

        public static IList<string> _message { get; internal set; }
    }
}
