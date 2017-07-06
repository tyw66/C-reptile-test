using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace 爬虫控制台
{
    public static class myclass
    {


        //检测是否有网
        public static bool CheckInternet()
        {
            Console.WriteLine("正在检查网络..");
            return true;

        }

        public static void getTitleFromAddress(string rootUrl, string pattern,bool print)
        {
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            string[] address = File.ReadAllLines(@".\Address.txt");
            StreamWriter writer = new StreamWriter(@".\Title.txt");
            StreamWriter LOGwriter = new StreamWriter(@".\Title_log.txt");

            string html = "", url = "";
            string pattern_title = pattern;

            if (pattern_title.Trim() == "")
            {
                pattern_title = @"<title>(.*)?</title>";
            }

            //获取标题
            Console.WriteLine(">发现{0}个网页", address.Length);

            

            for (int i = 0; i < address.Length; i++)
            {
                try
                {
                    html = wc.DownloadString(rootUrl + address[i]);
                    MatchCollection matches = Regex.Matches(html, pattern_title);
                    if (matches.Count > 0)
                    {
                        foreach (Match item in matches)
                        {
                            url = item.Groups[1].Value;
                            writer.WriteLine("> " + i + " " + url.ToString());
                            if(print)
                                Console.WriteLine("> " + i + " " + url.ToString());
                        }
                    }
                    else
                    {
                        writer.WriteLine(">" + i + "   无匹配");
                        if (print)
                            Console.WriteLine("> " + i + "   无匹配");
                    }
                    writer.Flush();
                }
                catch (Exception ex)
                {

                    Console.WriteLine("> " + i + ex.Message);
                    LOGwriter.WriteLine("> " + i + ex.Message);
                    LOGwriter.Flush();
                }


            }
            writer.Close();
            LOGwriter.Close();


        }
    }
}
