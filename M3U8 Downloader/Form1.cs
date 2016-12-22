using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml;
using System.Text;
using Microsoft.WindowsAPICodePack.Taskbar;
using System.Threading;

namespace M3U8_Downloader
{
    public partial class Form1 : Form
    {
        //任务栏进度条的实现。
        private TaskbarManager windowsTaskbar = TaskbarManager.Instance;
        
        //拖动窗口
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        [DllImport("kernel32.dll")]
        static extern bool GenerateConsoleCtrlEvent(int dwCtrlEvent, int dwProcessGroupId);
        [DllImport("kernel32.dll")]
        static extern bool SetConsoleCtrlHandler(IntPtr handlerRoutine, bool add);
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();
        [DllImport("user32.dll")]
        public static extern bool FlashWindow(IntPtr hWnd,bool bInvert );


        int ffmpegid = -1;
        Double big = 0;
        Double small = 0;

        //不影响点击任务栏图标最大最小化
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MINIMIZEBOX = 0x00020000;  // Winuser.h中定义
                CreateParams cp = base.CreateParams;
                cp.Style = cp.Style | WS_MINIMIZEBOX;   // 允许最小化操作
                return cp;
            }
        }

        public Form1()
        {
            InitializeComponent();
            Init();
            Control.CheckForIllegalCrossThreadCalls = false;  //禁止编译器对跨线程访问做检查
        }

        private void textBox_Adress_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.All;
        }

        private void textBox_Adress_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        private void textBox_Adress_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                //获取拖拽的文件地址
                var filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
                var hz = filenames[0].LastIndexOf('.') + 1;
                var houzhui = filenames[0].Substring(hz);//文件后缀名
                if (houzhui == "m3u8"||houzhui == "mkv"||houzhui == "avi"||houzhui == "mp4"||houzhui == "ts"||houzhui == "flv"||houzhui == "f4v"||
                    houzhui == "wmv"||houzhui == "wm"||houzhui == "mpeg"||houzhui == "mpg"||houzhui == "m4v"||houzhui == "3gp"||houzhui == "rm"||
                    houzhui == "rmvb" || houzhui == "mov" || houzhui == "qt" || houzhui == "m2ts" || houzhui == "m3u" || houzhui == "mts" || houzhui == "txt") //只允许拖入部分文件
                {
                    e.Effect = DragDropEffects.All;
                    string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                    textBox_Adress.Text = path; //将获取到的完整路径赋值到textBox1
                }
                
            }        
            
        }

        private void button_Quit_Click(object sender, EventArgs e)
        {
            SaveSettings();
            try
            {
                if (Process.GetProcessById(ffmpegid) != null)
                {
                    if (MessageBox.Show("已启动下载进程，确认退出吗？\n（这有可能是强制的）", "请确认您的操作", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Stop();
                        MessageBox.Show("已经发送命令！\n若进程仍然存在则强制结束！", "请确认");
                        try
                        {
                            if (Process.GetProcessById(ffmpegid) != null)  //如果进程还存在就强制结束它
                            {
                                Process.GetProcessById(ffmpegid).Kill();
                                Dispose();
                                Application.Exit();
                            }
                        }
                        catch
                        {
                            Dispose();
                            Application.Exit();
                        }

                    }
                    else
                    {
                    }
                }
            }
            catch
            {
                Dispose();
                Application.Exit();
            }

        }

        private void button_ChangePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox_DownloadPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button_OpenPath_Click(object sender, EventArgs e)
        {
            Process.Start(textBox_DownloadPath.Text);
        }

        private void linkLabel_Stop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Stop();
        }

        //格式化大小输出
        public static String FormatFileSize(Double fileSize)
        {
            if (fileSize < 0)
            {
                throw new ArgumentOutOfRangeException("fileSize");
            }
            else if (fileSize >= 1024 * 1024 * 1024)
            {
                return string.Format("{0:########0.00} GB", ((Double)fileSize) / (1024 * 1024 * 1024));
            }
            else if (fileSize >= 1024 * 1024)
            {
                return string.Format("{0:####0.00} MB", ((Double)fileSize) / (1024 * 1024));
            }
            else if (fileSize >= 1024)
            {
                return string.Format("{0:####0.00} KB", ((Double)fileSize) / 1024);
            }
            else
            {
                return string.Format("{0} bytes", fileSize);
            }
        }

        private void textBox_Info_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Info.GetLineFromCharIndex(textBox_Info.TextLength) + 1 > 14)
                textBox_Info.ScrollBars = ScrollBars.Vertical;
            if (textBox_Info.GetLineFromCharIndex(textBox_Info.TextLength) + 1 <= 14)
                textBox_Info.ScrollBars = ScrollBars.None;

            Regex duration = new Regex(@"Duration: (\d\d[.:]){3}\d\d", RegexOptions.Compiled | RegexOptions.Singleline);//取总视频时长
            label5.Text = "[总时长：" + duration.Match(textBox_Info.Text).Value.Replace("Duration: ", "") + "]";
            Regex regex = new Regex(@"(\d\d[.:]){3}\d\d", RegexOptions.Compiled | RegexOptions.Singleline);//取视频时长以及Time属性
            var time = regex.Matches(textBox_forRegex.Text);
            Regex size = new Regex(@"[1-9][0-9]{0,}kB time", RegexOptions.Compiled | RegexOptions.Singleline);//取已下载大小
            var sizekb = size.Matches(textBox_forRegex.Text);
            if (time.Count > 0 && sizekb.Count > 0)
            { label6.Text = "[已下载：" + time.OfType<Match>().Last() + "，" + FormatFileSize(Convert.ToDouble(sizekb.OfType<Match>().Last().ToString().Replace("kB time", "")) * 1024) + "]"; }
            Regex fps = new Regex(@", (\S+)\sfps", RegexOptions.Compiled | RegexOptions.Singleline);//取视频帧数
            Regex resolution = new Regex(@", \d{2,}x\d{2,}", RegexOptions.Compiled | RegexOptions.Singleline);//取视频分辨率
            label7.Text = "[视频信息：" + resolution.Match(textBox_Info.Text).Value.Replace(", ","") + "，" + fps.Match(textBox_Info.Text).Value.Replace(", ", "") + "]";
            if (time.Count > 0 && sizekb.Count > 0)  //防止程序太快 无法截取
            {
                try
                {
                    Double All = Convert.ToDouble(Convert.ToDouble(label5.Text.Substring(5, 2)) * 60 * 60 + Convert.ToDouble(label5.Text.Substring(8, 2)) * 60
                + Convert.ToDouble(label5.Text.Substring(11, 2)) + Convert.ToDouble(label5.Text.Substring(14, 2)) / 100);
                    Double Downloaded = Convert.ToDouble(Convert.ToDouble(label6.Text.Substring(5, 2)) * 60 * 60 + Convert.ToDouble(label6.Text.Substring(8, 2)) * 60
                    + Convert.ToDouble(label6.Text.Substring(11, 2)) + Convert.ToDouble(label6.Text.Substring(14, 2)) / 100);

                    if (All == 0) All = 1;  //防止被除数为零导致程序崩溃
                    Double Progress = (Downloaded / All) * 100;

                    if (Progress > 100)  //防止进度条超过百分之百
                        Progress = 100;
                    if (Progress < 0)  //防止进度条小于零……
                        Progress = 0;

                    ProgressBar.Value = Convert.ToInt32(Progress);
                    windowsTaskbar.SetProgressValue(Convert.ToInt32(Progress), 100, this.Handle);
                    label_Progress.Visible = true;
                    label_Progress.Text = "已完成：" + String.Format("{0:F}", Progress) + "%";
                    this.Text = "已完成：" + String.Format("{0:F}", Progress) + "%" + " [" + FormatFileSize((big - small) * 1024) + "/s]";
                }
                catch(Exception)
                {
                    try
                    {
                        label5.Text = "[总时长：NULL]";
                        Double Downloaded = Convert.ToDouble(Convert.ToDouble(label6.Text.Substring(5, 2)) * 60 * 60 + Convert.ToDouble(label6.Text.Substring(8, 2)) * 60
                    + Convert.ToDouble(label6.Text.Substring(11, 2)) + Convert.ToDouble(label6.Text.Substring(14, 2)) / 100);
                        Double Progress = 100;

                        if (Progress > 100)  //防止进度条超过百分之百
                            Progress = 100;
                        if (Progress < 0)  //防止进度条小于零……
                            Progress = 0;

                        ProgressBar.Value = Convert.ToInt32(Progress);
                        windowsTaskbar.SetProgressValue(Convert.ToInt32(Progress), 100, this.Handle);
                        label_Progress.Visible = true;
                        label_Progress.Text = "已完成：" + String.Format("{0:F}", Progress) + "%";
                        this.Text = "已完成：" + String.Format("{0:F}", Progress) + "%" + " [" + FormatFileSize((big - small) * 1024) + "/s]";
                    }
                    catch (Exception) { }
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////初始化进度条
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.Normal, this.Handle);
            windowsTaskbar.SetProgressValue(0, 100, this.Handle);

            if (!File.Exists(@"Tools\ffmpeg.exe"))  //判断程序目录有无ffmpeg.exe
            {
                MessageBox.Show("没有找到Tools\\ffmpeg.exe", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
                Application.Exit();
            }
            if (File.Exists(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\M3u8_Downloader_Settings.xml"))  //判断程序目录有无配置文件，并读取文件
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\M3u8_Downloader_Settings.xml");    //加载Xml文件  
                XmlNodeList topM = doc.SelectNodes("Settings");
                foreach (XmlElement element in topM)
                {
                    textBox_DownloadPath.Text = element.GetElementsByTagName("DownPath")[0].InnerText;
                    if (element.GetElementsByTagName("ExtendName")[0].InnerText == "MP4") { radioButton1.Checked = true; }
                    if (element.GetElementsByTagName("ExtendName")[0].InnerText == "MKV") { radioButton2.Checked = true; }
                    if (element.GetElementsByTagName("ExtendName")[0].InnerText == "TS") { radioButton3.Checked = true; }
                    if (element.GetElementsByTagName("ExtendName")[0].InnerText == "FLV") { radioButton4.Checked = true; }
                }
            }
            else  //若无配置文件，获取当前程序运行路径，即为默认下载路径
            {
                string lujing = System.Environment.CurrentDirectory;
                textBox_DownloadPath.Text = lujing;
            }
        }

        private void textBox_Adress_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null)
                return;
            if (e.KeyChar == (char)1)       // Ctrl-A 相当于输入了AscII=1的控制字符
            {
                textBox.SelectAll();
                e.Handled = true;      // 不再发出“噔”的声音
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            SaveSettings();
            try
            {
                if (Process.GetProcessById(ffmpegid) != null)
                {
                    if (MessageBox.Show("已启动下载进程，确认退出吗？\n（这有可能是强制的）", "请确认您的操作", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Stop();
                        MessageBox.Show("已经发送命令！\n若进程仍然存在则强制结束！", "请确认"); 
                        try
                        {
                            if (Process.GetProcessById(ffmpegid) != null)  //如果进程还存在就强制结束它
                            {
                                Process.GetProcessById(ffmpegid).Kill();
                                Dispose();
                                Application.Exit();
                            }
                        }
                        catch
                        {
                            Dispose();
                            Application.Exit();
                        }
                                
                    }
                    else
                    {
                    }
                }
            }
            catch {
                Dispose();
                Application.Exit();
            }
        }

        

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFrom();
        }

        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFrom();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Process.Start("https://ffmpeg.zeranoe.com/builds/win32/static/");
        }

        private void label_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nilaoda 编译于 2016/10/22\nCopyright ©  2016", "关于", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Label_Monitor_Click(object sender, EventArgs e)
        {
            Exist_Run(@"Tools\HttpFileMonitor.exe");
        }

        private void Label_WriteLog_Click(object sender, EventArgs e)
        {
            String LogName = "日志-" + System.DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss") + ".txt";
            StreamWriter log = new StreamWriter(LogName);
            log.WriteLine("━━━━━━━━━━━━━━\r\n"
                + "■M3U8 Downloader 用户日志\r\n\r\n"
                + "■" + System.DateTime.Now.ToString("F") + "\r\n\r\n"
                + "■输入：" + textBox_Adress.Text + "\r\n\r\n"
                + "■输出：" + textBox_DownloadPath.Text + "\\" + textBox_Name.Text + houzhui.Text + "\r\n\r\n"
                + "■FFmpeg命令：ffmpeg " + Command.Text + "\r\n"
                + "━━━━━━━━━━━━━━"
                + "\r\n\r\n"
                + textBox_Info.Text);
            log.Close();
            MessageBox.Show("日志已生成到程序目录！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label_Update_Click(object sender, EventArgs e)
        {
            Process.Start("http://pan.baidu.com/s/1dF4uDuL");
        }

        private void label_OpenTool_Click(object sender, EventArgs e)
        {
            Exist_Run(@"Tools\Batch Download.exe");
        }

        private void label_Progress_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFrom();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Regex size = new Regex(@"[1-9][0-9]{0,}kB time", RegexOptions.Compiled | RegexOptions.Singleline);//取已下载大小
                var sizekb = size.Matches(textBox_forRegex.Text);
                big = Convert.ToDouble(sizekb.OfType<Match>().Last().ToString().Replace("kB time", ""));
                label8.Text = "[" + FormatFileSize((big - small) * 1024) + "/s]";
            }
            catch (Exception) { }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            small = big;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            try
            {
                if (Process.GetProcessById(ffmpegid) != null)
                {
                    if (MessageBox.Show("已启动下载进程，确认退出吗？\n（这有可能是强制的）", "请确认您的操作", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Stop();
                        MessageBox.Show("已经发送命令！\n若进程仍然存在则强制结束！", "请确认");
                        try
                        {
                            if (Process.GetProcessById(ffmpegid) != null)  //如果进程还存在就强制结束它
                            {
                                Process.GetProcessById(ffmpegid).Kill();
                                Dispose();
                                Application.Exit();
                            }
                        }
                        catch
                        {
                            Dispose();
                            Application.Exit();
                        }

                    }
                    else
                    {
                        e.Cancel=true;
                    }
                }
            }
            catch
            {
                Dispose();
                Application.Exit();
            }
        }
    }
    }


namespace M3U8_Downloader
{
    class MyProgressBar : ProgressBar //新建一个MyProgressBar类，它继承了ProgressBar的所有属性与方法
    {
        public MyProgressBar()
        {
            base.SetStyle(ControlStyles.UserPaint, true);//使控件可由用户自由重绘
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush brush = null;
            Rectangle bounds = new Rectangle(0, 0, base.Width, base.Height);
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), 1, 1, bounds.Width - 2, bounds.Height - 2);//此处完成背景重绘，并且按照属性中的BackColor设置背景色
            bounds.Height -= 4;
            bounds.Width = ((int)(bounds.Width * (((double)base.Value) / ((double)base.Maximum)))) - 4;//是的进度条跟着ProgressBar.Value值变化
            brush = new SolidBrush(this.ForeColor);
            e.Graphics.FillRectangle(brush, 2, 2, bounds.Width, bounds.Height);//此处完成前景重绘，依旧按照Progressbar的属性设置前景色
        }
    }

    // 1.定义委托  
    public delegate void DelReadStdOutput(string result);
    public delegate void DelReadErrOutput(string result);

    public partial class Form1 : Form
    {
        // 2.定义委托事件  
        public event DelReadStdOutput ReadStdOutput;
        public event DelReadErrOutput ReadErrOutput;


        private void button_Download_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(textBox_DownloadPath.Text))//若文件夹不存在则新建文件夹   
            {
                Directory.CreateDirectory(textBox_DownloadPath.Text); //新建文件夹   
            }  

            else
            {
                textBox_Info.Text = "";
                textBox_forRegex.Text = "";
                Download();
                linkLabel_Stop.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                timer1.Enabled = true;
                timer2.Enabled = true;
            }
            
        }

        private void Exist_Run(string FileName)
        {
            if (File.Exists(FileName))  //判断有无某文件
            {
                Process.Start(FileName);
            }
            else
            {
                MessageBox.Show("没有找到" + FileName, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //移动窗口
        private void MoveFrom()
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void SaveSettings()
        {
            string ExtendName = "";
            if (radioButton1.Checked == true) { ExtendName = "MP4"; }
            if (radioButton2.Checked == true) { ExtendName = "MKV"; }
            if (radioButton3.Checked == true) { ExtendName = "TS"; }
            if (radioButton4.Checked == true) { ExtendName = "FLV"; }

           
            XmlTextWriter xml = new XmlTextWriter(@System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\M3u8_Downloader_Settings.xml", Encoding.UTF8);
            xml.Formatting = Formatting.Indented;
            xml.WriteStartDocument();
            xml.WriteStartElement("Settings");
            
            xml.WriteStartElement("DownPath"); xml.WriteCData(textBox_DownloadPath.Text); xml.WriteEndElement();
            xml.WriteStartElement("ExtendName"); xml.WriteCData(ExtendName); xml.WriteEndElement();

            xml.WriteEndElement();
            xml.WriteEndDocument();
            xml.Flush();
            xml.Close();
            
        }

        private void Download()
        {
            if (radioButton1.Checked == true)
            {
                houzhui.Text = ".mp4";
                Command.Text = "-threads 0 -i " + "\"" + textBox_Adress.Text + "\"" + " -c copy -y -bsf:a aac_adtstoasc -movflags +faststart " + "\"" + textBox_DownloadPath.Text + "\\" + textBox_Name.Text + ".mp4" + "\"";
                // 启动进程执行相应命令,此例中以执行ffmpeg.exe为例  
                RealAction(@"Tools\ffmpeg.exe", Command.Text);
            }
            if (radioButton2.Checked == true)
            {
                houzhui.Text = ".mkv";
                Command.Text = "-threads 0 -i " + "\"" + textBox_Adress.Text + "\"" + " -c copy -y -bsf:a aac_adtstoasc " + "\"" + textBox_DownloadPath.Text + "\\" + textBox_Name.Text + ".mkv" + "\"";
                RealAction(@"Tools\ffmpeg.exe", Command.Text);
            }
            if (radioButton3.Checked == true)
            {
                houzhui.Text = ".ts";
                Command.Text = "-threads 0 -i " + "\"" + textBox_Adress.Text + "\"" + " -c copy -y -f mpegts " + "\"" + textBox_DownloadPath.Text + "\\" + textBox_Name.Text + ".ts" + "\"";
                RealAction(@"Tools\ffmpeg.exe", Command.Text);
            }
            if (radioButton4.Checked == true)
            {
                houzhui.Text = ".flv";
                Command.Text = "-threads 0 -i " + "\"" + textBox_Adress.Text + "\"" + " -c copy -y -f f4v -bsf:a aac_adtstoasc " + "\"" + textBox_DownloadPath.Text + "\\" + textBox_Name.Text + ".flv" + "\"";
                RealAction(@"Tools\ffmpeg.exe", Command.Text);
            }
        }

        private void RealAction(string StartFileName, string StartFileArg)
        {
            Process CmdProcess = new Process();
            CmdProcess.StartInfo.FileName = StartFileName;      // 命令  
            CmdProcess.StartInfo.Arguments = StartFileArg;      // 参数  

            CmdProcess.StartInfo.CreateNoWindow = true;         // 不创建新窗口  
            CmdProcess.StartInfo.UseShellExecute = false;
            CmdProcess.StartInfo.RedirectStandardInput = true;  // 重定向输入  
            CmdProcess.StartInfo.RedirectStandardOutput = true; // 重定向标准输出  
            CmdProcess.StartInfo.RedirectStandardError = true;  // 重定向错误输出  
            //CmdProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;  

            CmdProcess.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
            CmdProcess.ErrorDataReceived += new DataReceivedEventHandler(p_ErrorDataReceived);

            CmdProcess.EnableRaisingEvents = true;                      // 启用Exited事件  
            CmdProcess.Exited += new EventHandler(CmdProcess_Exited);   // 注册进程结束事件  

            CmdProcess.Start();
            ffmpegid = CmdProcess.Id;//获取ffmpeg.exe的进程ID
            CmdProcess.BeginOutputReadLine();
            CmdProcess.BeginErrorReadLine();

            // 如果打开注释，则以同步方式执行命令，此例子中用Exited事件异步执行。  
            // CmdProcess.WaitForExit();       

        }

        public void Stop()
        {
            AttachConsole(ffmpegid);
            SetConsoleCtrlHandler(IntPtr.Zero, true);
            GenerateConsoleCtrlEvent(0, 0);
            FreeConsole();
        }

        //以下为实现异步输出CMD信息

        private void Init()
        {
            //3.将相应函数注册到委托事件中  
            ReadStdOutput += new DelReadStdOutput(ReadStdOutputAction);
            ReadErrOutput += new DelReadErrOutput(ReadErrOutputAction);
        }

        private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                // 4. 异步调用，需要invoke  
                this.Invoke(ReadStdOutput, new object[] { e.Data });
            }
        }

        private void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                this.Invoke(ReadErrOutput, new object[] { e.Data });
            }
        }

        private void ReadStdOutputAction(string result)
        {
            textBox_forRegex.Text = result;
            this.textBox_Info.AppendText(result + "\r\n");
        }

        private void ReadErrOutputAction(string result)
        {
            textBox_forRegex.Text = result;
            this.textBox_Info.AppendText(result + "\r\n");
        }

        private void CmdProcess_Exited(object sender, EventArgs e)
        {
            FlashWindow(this.Handle, true);

            //设置任务栏进度条状态
            windowsTaskbar.SetProgressState(TaskbarProgressBarState.NoProgress, this.Handle);
            this.Text = "M3U8 Downloader";
            this.label_Progress.Text = "已完成：" + "100.00%";
            ProgressBar.Value = 100;
            timer1.Enabled = false;
            timer2.Enabled = false;
            label8.Text = "";
            MessageBox.Show("命令执行结束！", "M3U8 Downloader", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);  // 执行结束后触发
        }  
    }
}