using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace EasyDownloader
{
    public static class Utility
    {
        /// <summary>
        /// 检测是否有网络连接
        /// </summary>
        /// <returns></returns>
        public static bool CheckInternet()
        {
            Console.WriteLine("正在检查网络..");
            return true;
        }

        /// <summary>
        /// 获取输入网址的标题
        /// </summary>
        /// <param name="Url">目标网址</param>
        /// <returns>网站标题</returns>
        public static string getTitleFromUrl(string Url)
        {
            //下载
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            string html = GetHtmlCode(Url);

            //抓取标题
            string title = String.Empty;
            string pattern = @"<title>(.*)?</title>";
            MatchCollection matches = Regex.Matches(html, pattern);
            if (matches.Count>0)
            {
                foreach (Match item in matches)
                    //title = item.ToString();
                    title = item.Groups[1].Value;
            }
            else
            {
                title = "没有找到页面标题";
            }
            
            return title;
        }

        /// <summary>
        /// 获取网页源码，如果启用了gzip压缩后页面获取会产生乱码，采用此方法可解决gzip压缩而产生的乱码情况
        /// </summary>
        /// <param name="url">目标网址</param>
        /// <returns>html代码</returns>
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
