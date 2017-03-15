using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 爬虫控制台
{
    class Program
    {

        static void Main(string[] args)
        {
            int flag = 0;
            bool Isconn = false;

            Console.WriteLine(">>欢迎使用爬啊爬网络资源下载小工具");
            Isconn = myclass.CheckInternet();

            if (Isconn)
            {
                Console.WriteLine("网络连接正常，可以工作了");
            }
            else
            {
                Console.WriteLine("亲注意！网络无连接哦");
            }


            Console.WriteLine("数字键选择功能：");
            Console.WriteLine("【1】批量获取网站标题；【2】网页图片下载（从图片源地址）；【3】网页内图片下载；");
            Console.WriteLine("【0】退出");

            flag = Console.Read();
            switch (flag)
            {
                case 48:
                    return;
                case 49:      //【1】
                    myfunc1();
                    break;
                case 50:      //【2】
                    myfunc2();
                    break;
                case 51:      //【3】
                    myfunc3();
                    break;

                default:
                    Console.WriteLine("未识别");
                    break;
            }
            Console.ReadKey();
        }

        private static void myfunc1()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("批量获取网站标题");
            Console.WriteLine("=======================================");
            Console.WriteLine(">>程序将读取address.txt内的网址，返回title.txt，请确保同目录下的address.txt文件存在。");
            Console.WriteLine("是否输出到控制台？0-是，1-否");

            string tmp = Console.ReadLine();
            bool Isprint = tmp == "0" ? true : false;
            string root = "";
            string pattern = "";

            myclass.getTitleFromAddress(root, pattern, Isprint);
            Console.WriteLine(">>批量获取网站标题 - 完成");

        }




        private static void myfunc2()
        {
            Console.WriteLine("已选择2：网页图片下载（从图片源地址）");
        }


        private static void myfunc3()
        {
            Console.WriteLine("已选择3：网页内图片下载");
        }

    }




}
