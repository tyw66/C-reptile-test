using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDownloader
{
    public class TitleTask
    {
        public string PreUrl { get; set; }
        public string Url { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public int Step { get; set; }

        public List<string> titles=new List<string>();

        public void run()
        {
            if (Start > End || Step == 0)
                return;            
            for (int i = Start; i < End; i+=Step)
            {
                Url = PreUrl + i.ToString();
                titles.Add(Utility.getTitleFromUrl(Url));
            }            
        }



    }
}
