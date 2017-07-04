using System;
using System.Threading;
using System.Windows.Forms;

namespace 线程Thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strInfo = string.Empty;
            Thread t1 = new Thread(new ThreadStart(ThreadFuncA));            
            Thread t2 = new Thread(new ThreadStart(ThreadFuncB));

            t1.Start();
            t2.Priority = ThreadPriority.Highest;
            t2.Start();
            
            //strInfo = "新建子线程唯一标识符：" + t1.ManagedThreadId;
            //strInfo += "\n名称：" + t1.Name;
            //strInfo += "\n状态：" + t1.ThreadState;
            //strInfo += "\n优先级：" + t1.Priority;
            //strInfo += "\n是否后台：" + t1.IsBackground;
            //richTextBox1.Text = strInfo;

            Thread.Sleep(500);//主线程休眠
            t1.Abort();
            t2.Abort();
            // t.Join();
            // MessageBox.Show("新建子线程结束", "新建子线程");
        }


        private void ThreadFuncA()
        {
            MessageBox.Show("新建子线程1开始执行", "新建子线程1");
        }
        private void ThreadFuncB()
        {
            MessageBox.Show("新建子线程2开始执行", "新建子线程2");
        }
    }
}
