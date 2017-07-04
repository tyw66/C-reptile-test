using System;
using System.Threading;

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
                Console.WriteLine(">>第{0}个进程开始", ii + 1);
                th.Start();
            }

            //TestJoin.test_join();
            Console.Read();
        }


        class TestLock
        {
            private Object obj = new object();
            private int testNumber = 0;
            public void TestRun()
            {
                //上锁，保证锁里面的代码/变量资源在1个时刻只有1个进程访问
                lock (obj)
                {
                    Console.WriteLine("i的初始值为：" + testNumber.ToString());
                    Thread.Sleep(2000);
                    testNumber++;
                    Console.WriteLine("i在自增后的值为：" + testNumber.ToString());
                }
            }
        }


        class TestJoin
        {
            //一个例子说明join()的作用
            public static void test_join()
            {
                //线程A
                Thread ThreadA = new Thread(delegate ()
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("A : ");
                        if (i == 9)
                        {
                            break;
                        }
                        Thread.Sleep(1000);
                    }
                });
                //线程B
                Thread ThreadB = new Thread(delegate ()
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("B : ");
                        if (i == 4)
                        {
                            break;
                        }
                        Thread.Sleep(1000);
                    }
                    //在这里插入线程A
                    //线程B中join了线程A只有A执行结束，才可以继续执行线程B中剩下的代码
                    ThreadA.Join();
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("C : ");
                        if (i == 4)
                        {
                            break;
                        }
                        Thread.Sleep(1000);
                    }
                });
                ThreadA.Start();
                ThreadB.Start();
                Console.ReadLine();
            }
        }
        


    }
}
