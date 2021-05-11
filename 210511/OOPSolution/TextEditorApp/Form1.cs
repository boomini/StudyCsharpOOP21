using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            String filename = @"C:\Test\Help\PFRO.txt";//파일 Encoding 확인필수
            byte[] result;

            using (FileStream stream = File.Open(filename, FileMode.Open))
            {
                result = new byte[stream.Length]; //파일크기만큼 byte[] 배열을 생성
                await stream.ReadAsync(result, 0, (int)stream.Length);
                //stream.Close(); using이 Close() 자동으로 처리
            }
            richTextBox1.Text = Encoding.UTF8.GetString(result);
        }
    }
}
