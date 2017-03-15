using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 线程练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myclass cl = new myclass();
            for (int i = 0; i < 3; i++)
            {
                Thread th = new Thread(new ThreadStart(cl.function));
                th.Start();

            }

        }

        class myclass
        {
            object obj = new object();
            public void function()
            {
                lock (obj)
                {
                    for (int i = 0; i < 99; i++)
                    {
                        //label1.Text = i.ToString();
                        Thread.Sleep(1000);


                    }
                }

            }
        }

    }
}
