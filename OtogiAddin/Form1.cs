using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Threading;


namespace OtogiAddin
{
    public partial class Form1 : Form
    {
        //Genymotion視窗名稱 "Genymotion for personal use - Sony Xperia Z - 4.3 - API 18 - 1080x1920 (800x1280, 160dpi) - 192.168.172.101"

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam); //用來模擬滑鼠動作
        public static uint WM_LBUTTONDOWN = 0x201; //0x201
        public static uint WM_LBUTTONUP = 0x202;   //0x202

        [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Auto)]  
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);  //以視窗名稱獲得窗口句柄

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForgegroundWindow(); //獲得當前視窗窗口句柄

        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        private const int WS_SHOWNORMAL = 1;

        [DllImport("USER32.DLL")]//引用User32.dll
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect); //獲得窗口四角座標
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left; //最左坐标
            public int Top; //最上坐标
            public int Right; //最右坐标
            public int Bottom; //最下坐标
        }

        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(Point Point);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        public Form1()
        {
            InitializeComponent();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            textBox1.Text = "Genymotion for personal use - Sony Xperia Z - 4.3 - API 18 - 1080x1920 (800x1280, 160dpi) - 192.168.136.101";
            OtogiWindow = FindWindow(null,textBox1.Text);
            if(OtogiWindow.ToInt32() != 0)
            {
                findOtogi();
            }
            else
            {
                MessageBox.Show("找不到Otogi視窗");
            }
            
        }

        public void findOtogi()
        {
            OtogiWindow = FindWindow(null, textBox1.Text);
            ShowWindowAsync(OtogiWindow, WS_SHOWNORMAL);
            SetForegroundWindow(OtogiWindow);
            GetWindowRect(OtogiWindow, ref OtogiWindowRect);
            OtogiWindowPoint.X = OtogiWindowRect.Left;  //或得Otogi最左上角座標
            OtogiWindowPoint.Y = OtogiWindowRect.Top;
            //label2.Text = "(" + OtogiWindowPoint.X.ToString() + "," + OtogiWindowPoint.Y.ToString() + ")";
        }

        public void play2_3_123()
        {
            
            Point mousePoint = new Point(0, 0);
            mousePoint = setMousePoint(260, 624);
            SetCursorPos(mousePoint.X, mousePoint.Y);
            setProcess("進入2.3.1");
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            for (int i=0;i<300;i+=10)
            {
                SetCursorPos(mousePoint.X, mousePoint.Y - i);
                if(!mySleep(10) || stopFight)
                {
                    return;
                }
            }
            if (!mySleep(10) || stopFight)
            {
                return;
            }
            mouse_event(MOUSEEVENTF_LEFTUP, 0,0, 0, 0);
            if(!mySleep(1000) || stopFight)
            {
                return;
            }

            Fight(260, 562, Int32.Parse(battleTimeTextBox.Text));
            if (!mySleep(3000) || stopFight)
            {
                return;
            }

            setProcess("進入2.3.2");
            mousePoint = setMousePoint(260, 624);
            SetCursorPos(mousePoint.X, mousePoint.Y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            if (!mySleep(100) || stopFight)
            {
                return;
            }
            if (!mySleep(500) || stopFight)
            {
                return;
            }
            for (int i = 0; i < 300; i += 10)
            {
                SetCursorPos(mousePoint.X, mousePoint.Y - i);
                if (!mySleep(10) || stopFight)
                {
                    return;
                }
            }
            if (!mySleep(10) || stopFight)
            {
                return;
            }
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            if (!mySleep(1000 ) || stopFight)
            {
                return;
            }

            Fight(283, 371, Int32.Parse(battleTimeTextBox.Text));
            if (!mySleep(3000) || stopFight)
            {
                return;
            }

            setProcess("進入2.3.3");
            Fight(286, 624, Int32.Parse(battleTimeTextBox.Text));
            if (!mySleep(3000) || stopFight)
            {
                return;
            }
        }

        public void Fight(int level_X =286, int level_Y = 624, int battleTime = 60)
        {
            if (!mySleep(1000) || stopFight)
            {
                return;
            }
            findOtogi();

            Point mousePoint = new Point(0, 0);
            //點擊進入關卡
            setProcess("進入關卡");
            mousePoint = setMousePoint(level_X, level_Y);
            SetCursorPos(mousePoint.X, mousePoint.Y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0,0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            if (!mySleep(2000) || stopFight)
            {
                return;
            }

            //確定隊伍
            setProcess("確定隊伍");
            mousePoint = setMousePoint(445, 658);
            SetCursorPos(mousePoint.X, mousePoint.Y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            if (!mySleep(2000) || stopFight)
            {
                return;
            }

            //選擇助戰 
            setProcess("選擇助戰");
            mousePoint = setMousePoint(302, 587);//(公會幫助1)
            SetCursorPos(mousePoint.X, mousePoint.Y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            if (!mySleep(2000) || stopFight)
            {
                return;
            }
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            if (!mySleep(2000) || stopFight)
            {
                return;
            }

            //點選快進
            setProcess("點選快進");
            mousePoint = setMousePoint(462, 59);
            SetCursorPos(mousePoint.X, mousePoint.Y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

            setProcess("等待戰鬥結束...");
            for(int i=0;i<battleTime*1000;i+=10)
            {
                Thread.Sleep(10);
                Application.DoEvents();
                if(programClosed || stopFight)
                {
                    return;
                }
            }
            //等待戰鬥結束

            //點選快進
            setProcess("點選快進");
            mousePoint = setMousePoint(462, 59);
            SetCursorPos(mousePoint.X, mousePoint.Y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            if (!mySleep(2000) || stopFight)
            {
                return;
            }
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            setProcess("完成關卡");
            return;
        }

        private void setProcess(string state)
        {
            processLabel.Text = state;
            return;
        }

        private bool mySleep(int ms)
        {

            if (ms > 10)
            {
                int times = ms / 10;
                ms %= 10;
                for (int i = 0; i < times; i++)
                {
                    Thread.Sleep(10);
                    Application.DoEvents();

                    if (programClosed)
                    {
                        return false;
                    }
                }
                Thread.Sleep(ms);
            }
            else
            {
                Thread.Sleep(ms);
                Application.DoEvents();
                if (programClosed)
                {
                    return false;
                }
            }
            return true;
        }

        public Point setMousePoint(int x,int y)
        {
            findOtogi();
            x += OtogiWindowPoint.X;
            y += OtogiWindowPoint.Y;
            Point ret = new Point(x, y);
            return ret;
        }

        private void getWindownName()
        {
            // 關鍵： 先隱藏本表單以利偵側本 Winform 下的程式
            this.Hide();
            // 透過 WindowFromPoint 方法來取得當下座標程式的 IntPtr (句柄)
            Point ptCursor = new Point();
            IntPtr hWnd = WindowFromPoint(ptCursor);
            // 取得視窗名稱長度
            int length = GetWindowTextLength(hWnd) + 1;
            StringBuilder sb = new StringBuilder(length);
            // 取得視窗名稱
            GetWindowText(hWnd, sb, length);
            textBox1.Text = ""; //清空舊資訊
            textBox1.Text = sb.ToString();
            // 最後再把原本的 Winform Show 出來~
            this.Show();

            return;
        }

        private void getMousePoint()
        {
            stopTrackMouse = false;
            Point mousePoint = new Point();     

            while (true)
            {
                mousePoint.X = Cursor.Position.X;
                mousePoint.Y = Cursor.Position.Y;
                label2.Text = "(" + (mousePoint.X-OtogiWindowPoint.X).ToString() + "," + (mousePoint.Y - OtogiWindowPoint.Y).ToString() + ")";
                //label2.Text = "(" + (mousePoint.X).ToString() + "," + (mousePoint.Y).ToString() + ")";
                if (!mySleep(10) || stopTrackMouse)
                {
                    return;
                }
            }
            

        }

        private static IntPtr OtogiWindow = new IntPtr();
        private static RECT OtogiWindowRect = new RECT();
        private static Point OtogiWindowPoint = new Point();
        private bool stopTrackMouse { set; get; }
        private static bool programClosed { set; get; }
        private static bool stopFight { set; get; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopTrackMouse = true;
            programClosed = false;
            stopFight = true;
            //stopTrackButton.Hide();
            stopFightButton.Hide();
        }

        private void Form1_Closing(object sender, EventArgs e)
        {
            programClosed = true;
            Console.WriteLine("bye bye");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getMousePoint();
            //stopTrackButton.Show();
        }

        private void startFightButton_Click(object sender, EventArgs e)
        {
            mySleep(1000);
            findOtogi();
            int times = Int32.Parse(timesTextBox.Text);
            if (OtogiWindow.ToInt32() == 0)
            {
                setProcess("沒有找到Otogi");
                return;
            }
            if(times<=0)
            {
                setProcess("戰鬥次數為0");
                return;
            }
            stopFightButton.Show();
            times--;
            timesTextBox.Text = times.ToString();
            stopFight = false;
            play2_3_123();
            setProcess("開始2.3.1 2.3.2 2.3.3副本");
            if(times>0 && !stopFight)
            {
                startFightButton_Click(sender,e);
                
            }
            setProcess("結束");
            stopFightButton.Hide();
            startFightButton.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void stopTrackButton_Click(object sender, EventArgs e)
        {
            timesTextBox.Text = "0";
            stopTrackMouse = true;
            //stopTrackButton.Hide();
        }

        private void timesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stopFightButton_Click(object sender, EventArgs e)
        {
            stopFight = true;
            stopFightButton.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void battleTimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
