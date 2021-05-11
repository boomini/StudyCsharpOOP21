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

namespace WinformThreadApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {     
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10000;

            //스레드로 분리 윈폼의 화면스레드, 처리스레드 분리
            Thread th = new Thread(() =>
            {
            for (int i = 0; i <= 10000; i++)
            {
                progressBar1.BeginInvoke(
                    new Action(() =>
                    {
                        progressBar1.Value = i;

                    }));
                    
                    
                    Thread.Sleep(5); //50ms걸리는 처리할 일이 있음.
                }
            });

            th.IsBackground = true;//백그라운드 실행할지 여부
            th.Start();
            
        }
    }
    
}
