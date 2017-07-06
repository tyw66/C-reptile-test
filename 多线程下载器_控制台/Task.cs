using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多线程下载器_控制台
{
    /// <summary>
    /// 任务：获取网站的title，
    /// </summary>
    public class TitleTask
    {
        static public Dictionary<int, string> titles = new Dictionary<int, string>();

        public static int index;
        public string _preUrl;
        public int _start;
        public int _end;

        public TitleTask(string PreUrl,int Start,int End)
        {
            _preUrl = PreUrl;
            _start = Start;
            _end = End;
        }
        //public string PreUrl { get; set; }
        //public string Url { get; set; }
        //public int Start { get; set; }
        //public int End { get; set; }

        //public int threadStart { get; set; }
        //public int threadEnd { get; set; }

    

        //public void run(object region)
        //{
        //    object obj = new object();
        //    lock (obj)
        //    {
        //        threadStart = Start + (int)region * 10;
        //        threadEnd = Start + ((int)region + 1) * 10;

        //        for (index = threadStart; index < threadEnd; index++)
        //        {
        //            Url = PreUrl + index.ToString();
        //            string title = Utility.getTitleFromUrl(Url);

        //            titles.Add(title);
        //            Console.WriteLine("第{0}个网页的标题是：{1}", index, title);
        //        }
        //    }

        //}

        public void run()
        {
            object obj = new object();
            lock (obj)
            {
                for (int index = _start; index < _end; index++)
                {
                    string Url = _preUrl + index.ToString();
                    string title = Utility.getTitleFromUrl(Url);

                    titles.Add(index,title);
                    Console.WriteLine("第{0}个网页的标题是：{1}", index, title);
                }
            }

        }

    }


}
