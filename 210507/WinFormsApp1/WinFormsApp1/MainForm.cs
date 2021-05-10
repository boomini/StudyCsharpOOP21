using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {

        static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            

            var result = TxtUserID.Text + "\n" + TxtPassword.Text;
            MessageBox.Show($"당신의 아이디와 패스워드는 {result}");
            try
            {
                var val = TxtPassword.Text.Substring(3, 2); //문자열 자르는 메서드
                MessageBox.Show($"{val}");
                logger.Info("제대로 완료!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("예외발생!관리자에게 문의요망");
                logger.Error("예외발생!관리자에게 문의요망");
                logger.Error($"{ex}");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //초기화.....
            logger.Info("MainForm 로드");
        }
    }
}
