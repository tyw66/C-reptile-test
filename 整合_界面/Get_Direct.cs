using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Crawler_tools
{
    public static class Get_Direct
    {
        public static string DownloadImg(string address, string folder, int start, int end, int add, int fix, string picType)
        {

            StringBuilder result =new StringBuilder();
            WebClient wc = new WebClient();
            string formatFix = String.Format("0:D{0}", fix);
            formatFix = "{" + formatFix + "}";
            for (int cyc_html = start; cyc_html <= end; cyc_html += add)
            {
                try
                {
                    string picPath;
                    picPath = address + String.Format(formatFix, cyc_html) + picType;
                    wc.DownloadFile(picPath, folder + "\\" + cyc_html + picType);
                }
                catch (Exception ex)
                {
                    result.Append(ex.Message+"\r\n");
                    continue;
                }
            }

            if (result.ToString() == "")
            {
                result.Append("(无异常)");
            }
            return result.ToString();

        }

    }
}
