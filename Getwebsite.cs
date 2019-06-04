using System.IO;
using System.Text.RegularExpressions;

namespace 顶点云
{
    public class Getwebsite
    {
        public string Inner_url { get; private set; }
        private static  readonly Regex _rex = new Regex(@"(http|https)://(?<domain>[^(:|/]*)");


        public static  string Set_url(string file)
        {
            var s_url = "";
            if (!File.Exists(file))
            {
                throw new FileNotFoundException("文件不存在");

            }
            foreach (string str in File.ReadLines(file))
            {
                if (_rex.IsMatch(str))
                {
                    s_url = str;
                }
            }
            return s_url;
        }
    }
}
