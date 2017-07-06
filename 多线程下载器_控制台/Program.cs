using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 多线程下载器_控制台
{
    class Program
    {
        static void Main(string[] args)
        {
            TitleTask task1 = new TitleTask("http://www.bilibili.com/av", 10000, 10010);
            TitleTask task2 = new TitleTask("http://www.bilibili.com/av", 10010, 10020);
            TitleTask task3 = new TitleTask("http://www.bilibili.com/av", 10020, 10030);

            Thread thread1 = new Thread(new ThreadStart(task1.run));
            Thread thread2 = new Thread(new ThreadStart(task2.run));
            Thread thread3 = new Thread(new ThreadStart(task3.run));

            thread1.Start();
            thread2.Start();
            thread3.Start();

            //for (int i = 0; i < 9; i++)
            //{
            //    Thread thread = new Thread(new ThreadStart(
            //        new TitleTask("http://www.bilibili.com/av", 10000, 10010).run));
            //    //thread1.IsBackground = true;
            //    thread.Start(i);
            //    //thread.Join();
            //    //thread1.Abort();
            //}



            Console.ReadLine();

        }
    }
}
