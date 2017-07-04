using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EasyDownloader
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            TitleTask task = new TitleTask();
            task.PreUrl = "http://www.bilibili.com/av";
            task.Start = 10000;
            task.End = 10010;
            task.Step = 1;

            Thread thread1 = new Thread(new ThreadStart(task.run));
            thread1.IsBackground = true;
            thread1.Start();
            thread1.Join();
            thread1.Abort();

            foreach (var item in task.titles)
            {
                listBox.Items.Add(item);
            }            

  
        }
    }
}
