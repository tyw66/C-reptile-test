using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

namespace 爬取大图
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlRoot = @"http://guguxx.net/artkt/";


            // string Pattern_title = @"<title>(.*)?,美女写真,美女相册,清纯图片,少女写真,人体艺术 姑姑坏卡通动漫-姑姑坏www.guguxx.net免费提供！.*</title>";
            //string Pattern_title = @"<title>(.*)?-.*卡通动漫.*</title>";
            //getTitleFromAddress(urlRoot, Pattern_title);



            WebClient wc = new WebClient();

            string rtfolder = @".\";


            string folder = "";


            string[] address;
            string addTmp = "", imgSource = "", imgTarget = "";
            string html = "";

            string Pattern_title = @"<title>(.*)?,美女写真,美女相册,清纯图片,少女写真,人体艺术 姑姑坏卡通动漫-姑姑坏www.guguxx.net免费提供！.*</title>";
            string Pattern_img = @"<img[^>]+src=""(.+?.jpg)"".*?>";//匹配src内容          


            address = File.ReadAllLines(@".\address.txt");
            wc.Encoding = System.Text.Encoding.UTF8;

            //StreamWriter w = new StreamWriter(rtfolder + "目录.dat");//临时 
            for (int i = 0; i < address.Length; i++)
            {
                try
                {
                    html = wc.DownloadString(@"http://guguxx.net/artkt/" + address[i]);
                    //获取标题建立文件夹
                    MatchCollection matches = Regex.Matches(html, Pattern_title);
                    if (matches.Count > 0)
                    {
                        foreach (Match item in matches)
                        {
                            folder = item.Groups[1].Value;
                            Directory.CreateDirectory(rtfolder + i + " " + folder);
                            // w.WriteLine(folder);

                        }
                    }
                    Console.WriteLine(i); 
                  //  Console.WriteLine(i + " " + folder.ToString());
                    // w.Flush();
                    //分页
                    int count = 0;
                    int j = 0;
                    while (j < 30)//分页上限数30
                    {
                        j++;
                        addTmp = @"http://guguxx.net/artkt/" + address[i] + "index" + j + ".html";
                        html = wc.DownloadString(addTmp);
                        MatchCollection IMGmatches = Regex.Matches(html, Pattern_img);
                        if (IMGmatches.Count > 0)
                        {
                            foreach (Match item in IMGmatches)
                            {
                                count++;
                                imgSource = item.Groups[1].Value;//图片源地址
                                imgTarget = rtfolder + i + " " + folder + "\\Page_" + count + ".jpg";
                                wc.DownloadFile(imgSource, imgTarget);

                                //Uri Source =new Uri(item.Groups[1].Value);
                                //wc.DownloadDataCompleted += new DownloadDataCompletedEventHandler(SaveandTellme);
                                //wc.DownloadDataAsync(Source, SaveandTellme(imgTarget,j));

                            }
                            Console.WriteLine("分页{0}完成", j);
                        }
                        else
                        {
                            Console.WriteLine("分页{0}为空", j);
                            j = 30;//退出循环
                        }
                    }
                    Console.WriteLine("第{0}个网址完成", i + 1);
                }
                catch (Exception)
                {
                    //w.WriteLine("已返回");
                    Console.WriteLine("已返回");

                }
            }
            Console.WriteLine("完成，回车键退出");
            Console.ReadLine();


            // FileInfo f = new FileInfo(@"D:\1.dat");

            //StreamWriter Writer = new StreamWriter(f.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite));



            //string webpath, html;
            ////wc.Encoding = System.Text.Encoding.UTF8;

            ////目标网址的第一页
            ////html = wc.DownloadString("http://www.nvnvsao.com/artyd/");


            //for (int index = 6155326; index < 99999999; index++)//目标网址的最后变化的数字
            //{
            //    try
            //    {
            //        //Uri tmp =new Uri("http://www.bilibili.com/video/av" + index + "/");
            //        string tmp = "http://www.bilibili.com/video/av" + index + "/";
            //        // string tmp = "http://www.acfun.tv/v/ac" + index + "/";








            //        html = GetHtmlCode(tmp);

            //        //  html = wc.DownloadString(tmp);//+ ".html"输入目标网址
            //        // html = GetHtml(tmp);


            //        // string Pattern = @"<img[^>]+src=""(.+?.jpg)"".*?>";//匹配src内容

            //        //string Pattern_title = @"<title>(.*)?</title>";
            //        string Pattern = @"<title>(.*)?_bilibili_哔哩哔哩弹幕视频网.*</title>";//匹配标题内容、点击量




            //        MatchCollection matches = Regex.Matches(html, Pattern);

            //        //int i = 0;
            //        foreach (Match item in matches)
            //        {
            //            if (item.Success)
            //            {
            //                string line1 = "av" + index + "--" + item.Groups[1].Value;
            //                // string line2 = "av" + index + "--" + item.Groups[2].Value;
            //                Console.WriteLine(line1);
            //                Writer.WriteLine(line1);




            //                //下载图片
            //                //i++;
            //                //webpath = item.Groups[1].Value;//图片源地址
            //                //wc.DownloadFile(webpath, @"G:\大图\" + file+ "\\"+ cyc_ch + "_" + i + ".jpg");

            //            }

            //        }
            //        if (index % 100 == 0)
            //        {
            //            Writer.Flush();//清空缓冲区
            //        }


            //        //Console.WriteLine("读取完成：" + index.ToString());
            //    }

            //    catch (Exception)
            //    {
            //        Console.WriteLine("av" + index + "--未找到");
            //        continue;
            //    }
            //}





            //Writer.Close();


            //Console.WriteLine("完成，回车键退出");
            //Console.ReadLine();


            /// <summary>
            /// 
            /// </summary>
            /// <param name="rootUrl"></param>


        }

        /// <summary>
        /// 读取同级目录下的address.txt文件内的网址，抓取标题，写入文件title.txt
        /// </summary>
        /// <param name="rootUrl">根网址</param>
        /// <param name="pattern">正则表达式,输入可以为空""</param>
        private static void getTitleFromAddress(string rootUrl, string pattern)
        {
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            string[] address = File.ReadAllLines(@".\address.txt");
            StreamWriter writer = new StreamWriter(@".\title.txt");

            string html = "", url = "";
            string pattern_title = pattern;

            if(pattern_title.Trim()=="")
            {
                pattern_title= @"<title>(.*)?</title>";
            }

            //获取标题
            Console.WriteLine("发现{0}条数据", address.Length);



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
                            writer.WriteLine(">> " + i + " " + url.ToString());
                            Console.WriteLine(">> " + i + " " + url.ToString());
                        }
                    }
                    else
                    {
                        writer.WriteLine(">> " + i + "   无匹配");
                        Console.WriteLine(">> " + i + "   无匹配");
                    }                    
                    writer.Flush();
                }
                catch (Exception)
                {

                    Console.WriteLine(">> " + i + " ====== 异常 =====");
                    writer.WriteLine(">> " + i + " ====== 异常 =====");
                    writer.Flush();
                }
            }
            Console.WriteLine("完成，回车键退出");
            Console.ReadLine();
        }

        //private static object SaveandTellme(string imgTarget, int j)
        //{
        //    wc.DownloadFile(imgSource, imgTarget);

        //}



        // 获取网页源码，如果启用了gzip压缩后页面获取会产生乱码，采用此方法可解决gzip压缩而产生的乱码情况
        private static string GetHtmlCode(string url)
        {
            string htmlCode;
            HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
            webRequest.Timeout = 30000;
            webRequest.Method = "GET";
            webRequest.UserAgent = "Mozilla/4.0";
            webRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
            HttpWebResponse webResponse = (System.Net.HttpWebResponse)webRequest.GetResponse();
            if (webResponse.ContentEncoding.ToLower() == "gzip")//如果使用了GZip则先解压            {
                using (System.IO.Stream streamReceive = webResponse.GetResponseStream())
                {
                    using (var zipStream = new System.IO.Compression.GZipStream(streamReceive, System.IO.Compression.CompressionMode.Decompress))
                    {
                        using (StreamReader sr = new System.IO.StreamReader(zipStream, Encoding.UTF8))
                        {
                            htmlCode = sr.ReadToEnd();
                        }
                    }
                }

            else
            {
                using (System.IO.Stream streamReceive = webResponse.GetResponseStream())
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(streamReceive, Encoding.Default))
                    {
                        htmlCode = sr.ReadToEnd();
                    }
                }
            }

            return htmlCode;
        }

    }
}
