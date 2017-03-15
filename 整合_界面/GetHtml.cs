using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Crawler_tools
{
    //----------------------------------
    //输入网址，返回该网站的HTML代码
    //----------------------------------
    public static class GetHtml
    {
        //一般方法，通过DownloadString获得源码
        public static string getHtml(string address)
        {
            string htmlCode = "";
            WebClient wc = new WebClient();
            htmlCode = wc.DownloadString(address);
            return htmlCode;
        }

        //如果启用了gzip压缩后页面获取会产生乱码，采用此方法可解决gzip压缩而产生的乱码情况
        public static string getHtml_Gzip(string address)
        {
            string htmlCode = "";
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(address);
            webRequest.Timeout = 30000;
            webRequest.Method = "GET";
            webRequest.UserAgent = "Mozilla/4.0";
            webRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            if (webResponse.ContentEncoding.ToLower() == "gzip")//如果使用了GZip则先解压
                using (Stream streamReceive = webResponse.GetResponseStream())
                {
                    using (var zipStream = new System.IO.Compression.GZipStream(streamReceive, System.IO.Compression.CompressionMode.Decompress))
                    {
                        using (StreamReader sr = new StreamReader(zipStream, Encoding.UTF8))//编码方式
                        {
                            htmlCode = sr.ReadToEnd();
                        }
                    }
                }

            else
            {
                using (Stream streamReceive = webResponse.GetResponseStream())
                {
                    using (StreamReader sr = new StreamReader(streamReceive, Encoding.Default))//编码方式
                    {
                        htmlCode = sr.ReadToEnd();
                    }
                }
            }
            return htmlCode;
        }

        //备用
        public static string GetHtml_1(string Url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Url);
            req.Method = "GET";
            string str;
            HttpWebResponse Stream = req.GetResponse() as HttpWebResponse;
            if (Stream.CharacterSet.ToLower() == "gbk")
            {
                using (StreamReader reader = new StreamReader(Stream.GetResponseStream(), System.Text.Encoding.GetEncoding("gb2312")))
                {
                    str = reader.ReadToEnd();
                    return str;
                }
            }
            else
            {
                using (StreamReader reader = new StreamReader(Stream.GetResponseStream(), System.Text.Encoding.GetEncoding("utf-8")))
                {
                    str = reader.ReadToEnd();
                    return str;
                }
            }
        }


    }
}
