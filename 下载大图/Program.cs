using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 下载大图
{
    class Program
    {
        static void Main(string[] args)//直接去图片源地址下载图片
        {
            string file = "[TechniMIND] Misato CV (Neon Genesis Evangelion)";// t
            Directory.CreateDirectory(@"G:\大图\"+ file);

            //图片源地址：
            //html内img的src:

            
            WebClient wc = new WebClient();
            for (int cyc_ch = 1; cyc_ch < 2; cyc_ch++)
            {
                for (int cyc_page = 1; cyc_page < 999; cyc_page++)
                {
                    try
                    {
                        string webpath;
                        webpath = "http://roufan.wmmnb.com/uploads/allimg/150806/1-150P60T209508.jpg" +  String.Format("{0:D1}", cyc_page) + ").jpg";
                        wc.DownloadFile(webpath, @"G:\大图\"+file+"\\"+ cyc_ch + "_" + cyc_page + ".jpg");

                        Console.WriteLine("读完一个页面" + cyc_page);
                    }
                    catch (Exception)
                    {
                        break;
                    }


                }
                Console.WriteLine("读完一个章" + cyc_ch.ToString());
            }
            Console.WriteLine("完成，回车键退出");
            Console.ReadLine();

            //  

        }
    }
}
