using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

namespace 深入
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "bilibili";// 自定义目录

            Directory.CreateDirectory(@"G:\大图\" + file);
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;

            string rootHtml, ChildHtml, webpath;
            List<string> childAddress = new List<string>();


            //目标网址
            rootHtml = wc.DownloadString("http://www.bilibili.com");

            string Pattern = @"<a[^>]+href=""(http:.+?)"".*?>";//匹配a标签内容

            MatchCollection matches = Regex.Matches(rootHtml, Pattern);
            int rootCount = 0;
            foreach (Match item in matches)
            {
                if (item.Success)
                {
                    rootCount++;
                    childAddress.Add(item.Groups[1].Value);//子地址
                    //Console.WriteLine(item.Groups[1].Value);
                }
            }
            Console.WriteLine("根网址中有{0}个站点：", rootCount.ToString());
            for (int i = 0; i < childAddress.Count; i++)
            {
                try
                {

                    ChildHtml = wc.DownloadString(childAddress[i]);//获取子网站的HTML代码
                    Pattern = @"<img[^>]+src=""(.+?.gif)"".*?>";//匹配src内容

                    MatchCollection img_matches = Regex.Matches(ChildHtml, Pattern);
                    //Directory.CreateDirectory(@"G:\大图\" + file + "\\" + i);

                    int j = 0;
                    foreach (Match item in img_matches)
                    {
                        if (item.Success)
                        {
                            j++;
                            webpath = item.Groups[1].Value;//图片源地址
                            wc.DownloadFile(webpath, @"G:\大图\" + file + "\\" + i + "_" + j + ".gif");

                        }
                    }
                    Console.WriteLine("读完一个页面：" + i.ToString() + childAddress[i]);

                }

                catch (Exception)
                {
                    continue;
                }

            }




            Console.WriteLine("完毕");

           Console.ReadLine();
        }
    }
}
