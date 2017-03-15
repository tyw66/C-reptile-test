namespace Crawler_tools
{
    partial class Frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_picSorce = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_ex = new System.Windows.Forms.TextBox();
            this.rbtn_png = new System.Windows.Forms.RadioButton();
            this.rBtn_gif = new System.Windows.Forms.RadioButton();
            this.rbtn_jpg = new System.Windows.Forms.RadioButton();
            this.btn_getDirect = new System.Windows.Forms.Button();
            this.num_fixed = new System.Windows.Forms.NumericUpDown();
            this.chk_IsFixed = new System.Windows.Forms.CheckBox();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.txt_start = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_preView = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txt_url_sg = new System.Windows.Forms.TextBox();
            this.txt_root = new System.Windows.Forms.TextBox();
            this.btn_title = new System.Windows.Forms.Button();
            this.txt_adr_path = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txt_reg = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_fixed)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "图片地址";
            // 
            // txt_picSorce
            // 
            this.txt_picSorce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_picSorce.Location = new System.Drawing.Point(9, 34);
            this.txt_picSorce.Multiline = true;
            this.txt_picSorce.Name = "txt_picSorce";
            this.txt_picSorce.Size = new System.Drawing.Size(795, 48);
            this.txt_picSorce.TabIndex = 1;
            this.txt_picSorce.Text = "http://tkpic.tukucc.com/300/%E5%B0%84%E9%9B%95%E8%8B%B1%E9%9B%84%E4%BC%A0(%E6%9D%" +
    "8E%E5%BF%97%E6%B8%85%E5%8F%B0%E7%89%88)/%E5%8D%B71/";
            this.txt_picSorce.TextChanged += new System.EventHandler(this.txt_picSorce_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 533);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_ex);
            this.tabPage1.Controls.Add(this.rbtn_png);
            this.tabPage1.Controls.Add(this.rBtn_gif);
            this.tabPage1.Controls.Add(this.rbtn_jpg);
            this.tabPage1.Controls.Add(this.btn_getDirect);
            this.tabPage1.Controls.Add(this.num_fixed);
            this.tabPage1.Controls.Add(this.chk_IsFixed);
            this.tabPage1.Controls.Add(this.txt_end);
            this.tabPage1.Controls.Add(this.txt_start);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_add);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_preView);
            this.tabPage1.Controls.Add(this.txt_picSorce);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(812, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "直接下载";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_ex
            // 
            this.txt_ex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ex.Location = new System.Drawing.Point(6, 358);
            this.txt_ex.Multiline = true;
            this.txt_ex.Name = "txt_ex";
            this.txt_ex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ex.Size = new System.Drawing.Size(798, 141);
            this.txt_ex.TabIndex = 8;
            // 
            // rbtn_png
            // 
            this.rbtn_png.AutoSize = true;
            this.rbtn_png.Location = new System.Drawing.Point(241, 162);
            this.rbtn_png.Name = "rbtn_png";
            this.rbtn_png.Size = new System.Drawing.Size(47, 16);
            this.rbtn_png.TabIndex = 7;
            this.rbtn_png.Text = ".png";
            this.rbtn_png.UseVisualStyleBackColor = true;
            this.rbtn_png.CheckedChanged += new System.EventHandler(this.rbtn_png_CheckedChanged);
            // 
            // rBtn_gif
            // 
            this.rBtn_gif.AutoSize = true;
            this.rBtn_gif.Location = new System.Drawing.Point(180, 162);
            this.rBtn_gif.Name = "rBtn_gif";
            this.rBtn_gif.Size = new System.Drawing.Size(47, 16);
            this.rBtn_gif.TabIndex = 7;
            this.rBtn_gif.Text = ".gif";
            this.rBtn_gif.UseVisualStyleBackColor = true;
            this.rBtn_gif.CheckedChanged += new System.EventHandler(this.rBtn_gif_CheckedChanged);
            // 
            // rbtn_jpg
            // 
            this.rbtn_jpg.AutoSize = true;
            this.rbtn_jpg.Checked = true;
            this.rbtn_jpg.Location = new System.Drawing.Point(106, 162);
            this.rbtn_jpg.Name = "rbtn_jpg";
            this.rbtn_jpg.Size = new System.Drawing.Size(47, 16);
            this.rbtn_jpg.TabIndex = 7;
            this.rbtn_jpg.TabStop = true;
            this.rbtn_jpg.Text = ".jpg";
            this.rbtn_jpg.UseVisualStyleBackColor = true;
            this.rbtn_jpg.CheckedChanged += new System.EventHandler(this.rbtn_jpg_CheckedChanged);
            // 
            // btn_getDirect
            // 
            this.btn_getDirect.Location = new System.Drawing.Point(154, 196);
            this.btn_getDirect.Name = "btn_getDirect";
            this.btn_getDirect.Size = new System.Drawing.Size(75, 23);
            this.btn_getDirect.TabIndex = 6;
            this.btn_getDirect.Text = "抓取";
            this.btn_getDirect.UseVisualStyleBackColor = true;
            this.btn_getDirect.Click += new System.EventHandler(this.btn_getDirect_Click);
            // 
            // num_fixed
            // 
            this.num_fixed.Enabled = false;
            this.num_fixed.Location = new System.Drawing.Point(309, 119);
            this.num_fixed.Name = "num_fixed";
            this.num_fixed.Size = new System.Drawing.Size(64, 21);
            this.num_fixed.TabIndex = 5;
            this.num_fixed.ValueChanged += new System.EventHandler(this.num_fixed_ValueChanged);
            // 
            // chk_IsFixed
            // 
            this.chk_IsFixed.AutoSize = true;
            this.chk_IsFixed.Location = new System.Drawing.Point(231, 124);
            this.chk_IsFixed.Name = "chk_IsFixed";
            this.chk_IsFixed.Size = new System.Drawing.Size(72, 16);
            this.chk_IsFixed.TabIndex = 4;
            this.chk_IsFixed.Text = "固定位数";
            this.chk_IsFixed.UseVisualStyleBackColor = true;
            this.chk_IsFixed.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(316, 88);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(57, 21);
            this.txt_end.TabIndex = 3;
            this.txt_end.Text = "10";
            // 
            // txt_start
            // 
            this.txt_start.Location = new System.Drawing.Point(106, 91);
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(57, 21);
            this.txt_start.TabIndex = 3;
            this.txt_start.Text = "1";
            this.txt_start.TextChanged += new System.EventHandler(this.txt_start_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "地址终止量";
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(106, 121);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(57, 21);
            this.txt_add.TabIndex = 3;
            this.txt_add.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "地址起始量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "起始地址预览：";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "异常报告：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "图片类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "地址自增量";
            // 
            // txt_preView
            // 
            this.txt_preView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_preView.Location = new System.Drawing.Point(8, 268);
            this.txt_preView.Multiline = true;
            this.txt_preView.Name = "txt_preView";
            this.txt_preView.Size = new System.Drawing.Size(796, 68);
            this.txt_preView.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txt_reg);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.txt_url_sg);
            this.tabPage2.Controls.Add(this.txt_root);
            this.tabPage2.Controls.Add(this.btn_title);
            this.tabPage2.Controls.Add(this.txt_adr_path);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(812, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "获取标题";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(95, 202);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "多个网址";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(95, 122);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "单网址";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txt_url_sg
            // 
            this.txt_url_sg.Location = new System.Drawing.Point(176, 121);
            this.txt_url_sg.Name = "txt_url_sg";
            this.txt_url_sg.Size = new System.Drawing.Size(280, 21);
            this.txt_url_sg.TabIndex = 3;
            // 
            // txt_root
            // 
            this.txt_root.Location = new System.Drawing.Point(176, 22);
            this.txt_root.Name = "txt_root";
            this.txt_root.Size = new System.Drawing.Size(280, 21);
            this.txt_root.TabIndex = 3;
            // 
            // btn_title
            // 
            this.btn_title.Location = new System.Drawing.Point(199, 357);
            this.btn_title.Name = "btn_title";
            this.btn_title.Size = new System.Drawing.Size(75, 23);
            this.btn_title.TabIndex = 2;
            this.btn_title.Text = "获得标题";
            this.btn_title.UseVisualStyleBackColor = true;
            this.btn_title.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_adr_path
            // 
            this.txt_adr_path.AllowDrop = true;
            this.txt_adr_path.Location = new System.Drawing.Point(176, 202);
            this.txt_adr_path.Name = "txt_adr_path";
            this.txt_adr_path.Size = new System.Drawing.Size(280, 21);
            this.txt_adr_path.TabIndex = 1;
            this.txt_adr_path.Text = "（文本文件拖拽到此获得路径）";
            this.txt_adr_path.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.txt_adr_path.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "网址公用前缀";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(281, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "文本文件内的网址，获得标题，写入到title.txt中 \r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "下方输入网址获得标题，写入到title.txt中 \r\n";
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.Description = "选择数据存放目录";
            // 
            // txt_reg
            // 
            this.txt_reg.Location = new System.Drawing.Point(171, 299);
            this.txt_reg.Name = "txt_reg";
            this.txt_reg.Size = new System.Drawing.Size(280, 21);
            this.txt_reg.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "正则表达式";
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 533);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_main";
            this.Text = "爬虫";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_fixed)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_picSorce;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown num_fixed;
        private System.Windows.Forms.CheckBox chk_IsFixed;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_getDirect;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txt_end;
        private System.Windows.Forms.TextBox txt_start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtn_png;
        private System.Windows.Forms.RadioButton rBtn_gif;
        private System.Windows.Forms.RadioButton rbtn_jpg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_preView;
        private System.Windows.Forms.TextBox txt_adr_path;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_root;
        private System.Windows.Forms.Button btn_title;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txt_url_sg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_reg;
        private System.Windows.Forms.Label label11;
    }
}