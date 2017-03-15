using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 线程同步
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLock t = new TestLock();
            for (int ii = 0; ii < 3; ii++)
            {
                Thread th = new Thread(t.TestRun);

                th.Start();
                Console.WriteLine(">>{0}个进程开始", ii+1);
            }


            Console.Read();

        }

        class TestLock
        {
            private Object obj = new object();
            private int i = 0;
            public void TestRun()
            {
                lock (obj)
                {
                    Console.WriteLine("i的初始值为：" + i.ToString());
                   Thread.Sleep(1);
                    i++;
                    Console.WriteLine("i在自增后的值为：" + i.ToString());
                }
            }

        }
    }
}
