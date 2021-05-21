using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEV_form;

namespace ApplicationDev
{
    public partial class FM_MAIN : Form
    {
        public FM_MAIN()
        {
            InitializeComponent();
            //버튼에 이벤트 추가
            
            //FM_Login Login = new FM_Login();
            //Login.ShowDialog();
            //tssUserName.Text = Login.Tag.ToString();
            //if(Login.Tag.ToString() == "FAIL")
            //{
            //    //  Application.ExitThread();
            //    //Application.Exit();
            //    System.Environment.Exit(0);
            //}
            ////버튼에 이벤트추가
            this.stbExit.Click += new System.EventHandler(this.stbExit_Click);

            //메뉴클릭이벤트 추가
            this.M_SYSTEM.DropDownItemClicked +=
                new System.Windows.Forms.ToolStripItemClickedEventHandler(this.M_SYSTEM_DropDownItemClicked);
        }

        private void stbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssNowDate.Text = DateTime.Now.ToString();
        }

       
        private void M_SYSTEM_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //1. 단순히 폼을 호출하는 경우,
            //DEV_form.Form1 Form = new DEV_form.Form1();
            ////다른 프로젝트에도 Form1 class가 존재할 수 있기 때문에 여러 form1 class가 존재하면 앞에 DEV_form 프로젝트이름을 넣어주어야한다.
            //Form.MdiParent = this;
            //Form.Show();

            //2. 프로그램을 호출
            Assembly assemb = Assembly.LoadFrom(Application.StartupPath + @"\" + "DEV_form.DLL");
            Type typeForm = assemb.GetType("DEV_form." + e.ClickedItem.Name.ToString(), true);
            Form ShowForm = (Form)Activator.CreateInstance(typeForm);
            //메뉴클릭은 화면이름으로 정하고, 해당되는 파일 위치의 똑같은 파일을 호출해라.

            ShowForm.MdiParent = this;
            ShowForm.Show();
        }
    }
}
