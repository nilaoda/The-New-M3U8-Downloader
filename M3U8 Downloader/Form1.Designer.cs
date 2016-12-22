using System;

namespace M3U8_Downloader
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Download = new System.Windows.Forms.Button();
            this.button_Quit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button_ChangePath = new System.Windows.Forms.Button();
            this.button_OpenPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_DownloadPath = new System.Windows.Forms.TextBox();
            this.textBox_Info = new System.Windows.Forms.TextBox();
            this.Command = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel_Stop = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.houzhui = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.button_Min = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label_Progress = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label_About = new System.Windows.Forms.Label();
            this.Label_Monitor = new System.Windows.Forms.Label();
            this.Label_WriteLog = new System.Windows.Forms.Label();
            this.label_Update = new System.Windows.Forms.Label();
            this.label_OpenTool = new System.Windows.Forms.Label();
            this.textBox_forRegex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ProgressBar = new M3U8_Downloader.MyProgressBar();
            this.SuspendLayout();
            // 
            // button_Download
            // 
            this.button_Download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.button_Download.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button_Download.FlatAppearance.BorderSize = 0;
            this.button_Download.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(162)))), ((int)(((byte)(210)))));
            this.button_Download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Download.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Download.ForeColor = System.Drawing.Color.White;
            this.button_Download.Location = new System.Drawing.Point(20, 335);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(119, 56);
            this.button_Download.TabIndex = 11;
            this.button_Download.Text = "下载";
            this.button_Download.UseVisualStyleBackColor = false;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // button_Quit
            // 
            this.button_Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.button_Quit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button_Quit.FlatAppearance.BorderSize = 0;
            this.button_Quit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(162)))), ((int)(((byte)(210)))));
            this.button_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Quit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Quit.ForeColor = System.Drawing.Color.White;
            this.button_Quit.Location = new System.Drawing.Point(175, 335);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(119, 56);
            this.button_Quit.TabIndex = 12;
            this.button_Quit.Text = "退出";
            this.button_Quit.UseVisualStyleBackColor = false;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "拖拽或键入地址";
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.AllowDrop = true;
            this.textBox_Adress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBox_Adress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Adress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Adress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBox_Adress.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.textBox_Adress.Location = new System.Drawing.Point(21, 77);
            this.textBox_Adress.Multiline = true;
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(273, 76);
            this.textBox_Adress.TabIndex = 1;
            this.textBox_Adress.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_Adress_DragDrop);
            this.textBox_Adress.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_Adress_DragEnter);
            this.textBox_Adress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Adress_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(22, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "文件名及格式";
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBox_Name.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.textBox_Name.Location = new System.Drawing.Point(21, 179);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(273, 23);
            this.textBox_Name.TabIndex = 7;
            this.textBox_Name.Text = "Video";
            // 
            // button_ChangePath
            // 
            this.button_ChangePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.button_ChangePath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button_ChangePath.FlatAppearance.BorderSize = 0;
            this.button_ChangePath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(162)))), ((int)(((byte)(210)))));
            this.button_ChangePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChangePath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ChangePath.ForeColor = System.Drawing.Color.White;
            this.button_ChangePath.Location = new System.Drawing.Point(21, 298);
            this.button_ChangePath.Name = "button_ChangePath";
            this.button_ChangePath.Size = new System.Drawing.Size(119, 25);
            this.button_ChangePath.TabIndex = 9;
            this.button_ChangePath.Text = "更改下载路径";
            this.button_ChangePath.UseVisualStyleBackColor = false;
            this.button_ChangePath.Click += new System.EventHandler(this.button_ChangePath_Click);
            // 
            // button_OpenPath
            // 
            this.button_OpenPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.button_OpenPath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button_OpenPath.FlatAppearance.BorderSize = 0;
            this.button_OpenPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(162)))), ((int)(((byte)(210)))));
            this.button_OpenPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OpenPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_OpenPath.ForeColor = System.Drawing.Color.White;
            this.button_OpenPath.Location = new System.Drawing.Point(175, 298);
            this.button_OpenPath.Name = "button_OpenPath";
            this.button_OpenPath.Size = new System.Drawing.Size(119, 25);
            this.button_OpenPath.TabIndex = 10;
            this.button_OpenPath.Text = "打开下载路径";
            this.button_OpenPath.UseVisualStyleBackColor = false;
            this.button_OpenPath.Click += new System.EventHandler(this.button_OpenPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(22, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "当前下载路径";
            // 
            // textBox_DownloadPath
            // 
            this.textBox_DownloadPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBox_DownloadPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_DownloadPath.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.textBox_DownloadPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBox_DownloadPath.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.textBox_DownloadPath.Location = new System.Drawing.Point(21, 226);
            this.textBox_DownloadPath.Multiline = true;
            this.textBox_DownloadPath.Name = "textBox_DownloadPath";
            this.textBox_DownloadPath.ReadOnly = true;
            this.textBox_DownloadPath.Size = new System.Drawing.Size(273, 55);
            this.textBox_DownloadPath.TabIndex = 8;
            // 
            // textBox_Info
            // 
            this.textBox_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBox_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Info.Font = new System.Drawing.Font("Consolas", 9F);
            this.textBox_Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.textBox_Info.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.textBox_Info.Location = new System.Drawing.Point(311, 77);
            this.textBox_Info.Multiline = true;
            this.textBox_Info.Name = "textBox_Info";
            this.textBox_Info.Size = new System.Drawing.Size(709, 289);
            this.textBox_Info.TabIndex = 13;
            this.textBox_Info.Text = "请在左侧进行操作...";
            this.textBox_Info.TextChanged += new System.EventHandler(this.textBox_Info_TextChanged);
            // 
            // Command
            // 
            this.Command.Location = new System.Drawing.Point(433, 131);
            this.Command.Multiline = true;
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(47, 25);
            this.Command.TabIndex = 11;
            this.Command.TabStop = false;
            this.Command.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(309, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "信息显示：";
            // 
            // linkLabel_Stop
            // 
            this.linkLabel_Stop.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.linkLabel_Stop.AutoSize = true;
            this.linkLabel_Stop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel_Stop.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabel_Stop.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.linkLabel_Stop.Location = new System.Drawing.Point(371, 57);
            this.linkLabel_Stop.Name = "linkLabel_Stop";
            this.linkLabel_Stop.Size = new System.Drawing.Size(56, 17);
            this.linkLabel_Stop.TabIndex = 14;
            this.linkLabel_Stop.TabStop = true;
            this.linkLabel_Stop.Text = "点此终止";
            this.linkLabel_Stop.Visible = false;
            this.linkLabel_Stop.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Stop_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(606, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "[总时长：]";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(732, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "[已下载：，]";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(426, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "[视频信息，]";
            this.label7.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton1.Location = new System.Drawing.Point(161, 159);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 16);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Text = "MP4";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton2.Location = new System.Drawing.Point(208, 159);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 16);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "MKV";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton3.Location = new System.Drawing.Point(255, 159);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(35, 16);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "TS";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioButton4.Location = new System.Drawing.Point(114, 159);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(41, 16);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "FLV";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // houzhui
            // 
            this.houzhui.AutoSize = true;
            this.houzhui.Location = new System.Drawing.Point(452, 342);
            this.houzhui.Name = "houzhui";
            this.houzhui.Size = new System.Drawing.Size(17, 12);
            this.houzhui.TabIndex = 19;
            this.houzhui.Text = ".*";
            this.houzhui.Visible = false;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label_Title.Location = new System.Drawing.Point(14, 7);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(311, 22);
            this.label_Title.TabIndex = 23;
            this.label_Title.Text = "M3U8 Downloader - 1.0  by：nilaoda";
            this.label_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label8_MouseDown);
            // 
            // button_Min
            // 
            this.button_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Min.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button_Min.FlatAppearance.BorderSize = 0;
            this.button_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Min.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Min.ForeColor = System.Drawing.Color.White;
            this.button_Min.Location = new System.Drawing.Point(843, 1);
            this.button_Min.Margin = new System.Windows.Forms.Padding(0);
            this.button_Min.Name = "button_Min";
            this.button_Min.Size = new System.Drawing.Size(93, 26);
            this.button_Min.TabIndex = 102;
            this.button_Min.Text = "MIN";
            this.button_Min.UseVisualStyleBackColor = false;
            this.button_Min.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Exit.ForeColor = System.Drawing.Color.White;
            this.button_Exit.Location = new System.Drawing.Point(938, 1);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(93, 26);
            this.button_Exit.TabIndex = 103;
            this.button_Exit.Text = "EXIT";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label_Progress
            // 
            this.label_Progress.AutoSize = true;
            this.label_Progress.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label_Progress.Location = new System.Drawing.Point(345, 7);
            this.label_Progress.Name = "label_Progress";
            this.label_Progress.Size = new System.Drawing.Size(74, 22);
            this.label_Progress.TabIndex = 104;
            this.label_Progress.Text = "已完成：";
            this.label_Progress.Visible = false;
            this.label_Progress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Progress_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox1.Location = new System.Drawing.Point(311, 372);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(710, 19);
            this.textBox1.TabIndex = 105;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label14.Location = new System.Drawing.Point(709, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 108;
            this.label14.Text = "FFmpeg";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label_About
            // 
            this.label_About.AutoSize = true;
            this.label_About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_About.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_About.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label_About.Location = new System.Drawing.Point(799, 7);
            this.label_About.Name = "label_About";
            this.label_About.Size = new System.Drawing.Size(32, 17);
            this.label_About.TabIndex = 109;
            this.label_About.Text = "关于";
            this.label_About.Click += new System.EventHandler(this.label_About_Click);
            // 
            // Label_Monitor
            // 
            this.Label_Monitor.AutoSize = true;
            this.Label_Monitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Monitor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Monitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Label_Monitor.Location = new System.Drawing.Point(523, 7);
            this.Label_Monitor.Name = "Label_Monitor";
            this.Label_Monitor.Size = new System.Drawing.Size(56, 17);
            this.Label_Monitor.TabIndex = 110;
            this.Label_Monitor.Text = "嗅探工具";
            this.Label_Monitor.Click += new System.EventHandler(this.Label_Monitor_Click);
            // 
            // Label_WriteLog
            // 
            this.Label_WriteLog.AutoSize = true;
            this.Label_WriteLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_WriteLog.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_WriteLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Label_WriteLog.Location = new System.Drawing.Point(653, 7);
            this.Label_WriteLog.Name = "Label_WriteLog";
            this.Label_WriteLog.Size = new System.Drawing.Size(56, 17);
            this.Label_WriteLog.TabIndex = 111;
            this.Label_WriteLog.Text = "生成日志";
            this.Label_WriteLog.Click += new System.EventHandler(this.Label_WriteLog_Click);
            // 
            // label_Update
            // 
            this.label_Update.AutoSize = true;
            this.label_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Update.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label_Update.Location = new System.Drawing.Point(765, 7);
            this.label_Update.Name = "label_Update";
            this.label_Update.Size = new System.Drawing.Size(32, 17);
            this.label_Update.TabIndex = 112;
            this.label_Update.Text = "更新";
            this.label_Update.Click += new System.EventHandler(this.label_Update_Click);
            // 
            // label_OpenTool
            // 
            this.label_OpenTool.AutoSize = true;
            this.label_OpenTool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_OpenTool.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_OpenTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label_OpenTool.Location = new System.Drawing.Point(581, 7);
            this.label_OpenTool.Name = "label_OpenTool";
            this.label_OpenTool.Size = new System.Drawing.Size(68, 17);
            this.label_OpenTool.TabIndex = 113;
            this.label_OpenTool.Text = "合并或批量";
            this.label_OpenTool.Click += new System.EventHandler(this.label_OpenTool_Click);
            // 
            // textBox_forRegex
            // 
            this.textBox_forRegex.Location = new System.Drawing.Point(526, 33);
            this.textBox_forRegex.Name = "textBox_forRegex";
            this.textBox_forRegex.Size = new System.Drawing.Size(441, 21);
            this.textBox_forRegex.TabIndex = 114;
            this.textBox_forRegex.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label8.Location = new System.Drawing.Point(935, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 115;
            this.label8.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ProgressBar.Location = new System.Drawing.Point(312, 373);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(708, 17);
            this.ProgressBar.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1032, 409);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_forRegex);
            this.Controls.Add(this.label_OpenTool);
            this.Controls.Add(this.label_Update);
            this.Controls.Add(this.Label_WriteLog);
            this.Controls.Add(this.Label_Monitor);
            this.Controls.Add(this.label_About);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label_Progress);
            this.Controls.Add(this.button_Min);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.houzhui);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel_Stop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Info);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_DownloadPath);
            this.Controls.Add(this.button_OpenPath);
            this.Controls.Add(this.button_ChangePath);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Quit);
            this.Controls.Add(this.button_Download);
            this.Controls.Add(this.Command);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M3U8 Downloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Download;
        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_ChangePath;
        private System.Windows.Forms.Button button_OpenPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DownloadPath;
        private System.Windows.Forms.TextBox textBox_Info;
        private System.Windows.Forms.TextBox Command;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel_Stop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label houzhui;
        //private System.Windows.Forms.ProgressBar ProgressBar;
        private MyProgressBar ProgressBar;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button button_Min;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label_Progress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_About;
        private System.Windows.Forms.Label Label_Monitor;
        private System.Windows.Forms.Label Label_WriteLog;
        private System.Windows.Forms.Label label_Update;
        private System.Windows.Forms.Label label_OpenTool;
        private System.Windows.Forms.TextBox textBox_forRegex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

