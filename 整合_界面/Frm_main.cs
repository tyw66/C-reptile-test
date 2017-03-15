using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crawler_tools
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }
        string PicType =".jpg";

        private void btn_getDirect_Click(object sender, EventArgs e)
        {
            txt_ex.Text = "";
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                txt_ex.Text=Get_Direct.DownloadImg(txt_picSorce.Text, FolderBrowser.SelectedPath, int.Parse(txt_start.Text), int.Parse(txt_end.Text), int.Parse(txt_add.Text), Convert.ToInt32(num_fixed.Value), PicType);
                MessageBox.Show("完毕！");
             }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            num_fixed.Enabled = chk_IsFixed.Checked;
            if (!chk_IsFixed.Checked)
            {
                num_fixed.Value = 0;
            }
            preFlash();
        }

        private void rBtn_gif_CheckedChanged(object sender, EventArgs e)
        {
            if(rBtn_gif.Checked)
            {
                PicType =".gif";
            }
            preFlash();
        }



        private void rbtn_jpg_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_jpg.Checked)
            {
                PicType = ".jpg";
            }
            preFlash();
        }

        private void rbtn_png_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_png.Checked)
            {
                PicType = ".png";
            }
            preFlash();
        }
        private void num_fixed_ValueChanged(object sender, EventArgs e)
        {
            preFlash();
        }

        private void txt_start_TextChanged(object sender, EventArgs e)
        {
            preFlash();
        }
        private void txt_picSorce_TextChanged(object sender, EventArgs e)
        {
            preFlash();
        }

        //起始地址预览
        private void preFlash()
        {
            string formatFix = String.Format("0:D{0}", num_fixed.Value);
            formatFix = "{" + formatFix + "}";
            string tmp = String.Format(formatFix, int.Parse(txt_start.Text));
            txt_preView.Text = txt_picSorce.Text+ tmp + PicType;
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string fileName = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            txt_adr_path.Text = fileName;

        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getTitleFromAddress(txt_root.Text, txt_reg.Text,txt_adr_path.Text);
        }

        private static void getTitleFromAddress(string rootUrl, string pattern, string address_path)
        {
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            string[] address = File.ReadAllLines(address_path);
            StreamWriter writer = new StreamWriter(@".\title.txt");

            string html = "", url = "";
            string pattern_title = pattern;

            if (pattern_title.Trim() == "")
            {
                pattern_title = @"<title>(.*)?</title>";
            }

            //获取标题
            Console.WriteLine("发现{0}条数据", address.Length);



            for (int i = 0; i < address.Length; i++)
            {
                try
                {
                    html = wc.DownloadString(rootUrl + address[i]);
                    MatchCollection matches = Regex.Matches(html, pattern_title);
                    if (matches.Count > 0)
                    {
                        foreach (Match item in matches)
                        {
                            url = item.Groups[1].Value;
                            writer.WriteLine(">> " + i + " " + url.ToString());
                            Console.WriteLine(">> " + i + " " + url.ToString());
                        }
                    }
                    else
                    {
                        writer.WriteLine(">> " + i + "   无匹配");
                        Console.WriteLine(">> " + i + "   无匹配");
                    }
                    writer.Flush();
                }
                catch (Exception)
                {

                    Console.WriteLine(">> " + i + " ====== 异常 =====");
                    writer.WriteLine(">> " + i + " ====== 异常 =====");
                    writer.Flush();
                }
            }
            writer.Dispose();
            Console.WriteLine("完成，回车键退出");
            Console.ReadLine();
        }
    }
}
