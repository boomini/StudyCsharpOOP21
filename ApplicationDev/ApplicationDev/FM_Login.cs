using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DEV_form;

namespace ApplicationDev
{
    public partial class FM_Login : Form
    {
        private SqlConnection Connect = null; //데이터 베이스 접속 정보
        private SqlTransaction Tran;    //데이터 베이스 관리 권한
        private SqlCommand cmd = new SqlCommand(); //데이터 베이스 명령 전달
        private int count = 0; //비밀번호 3회 오류 count 변수
        public FM_Login()
        {
            InitializeComponent();
            this.Tag = "FAIL";
        }

        private void txtPwChange_Click(object sender, EventArgs e)
        {
            //비밀번호 변경화면 팝업을 호출한다.
            this.Visible = false; //로그인 화면을 보이지 않게 한다.
            FM_Passwords FmPassWord = new FM_Passwords();
            //쇼를 하면 두개의 팝업창을 다 작업하 수 있고, ShowDialog는 fmpassword 팝업창만 작업하고 이전 로그인 화면은 작업할 수 없다.
            FmPassWord.ShowDialog();
            this.Visible = true;
            

        }

        private void FM_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String strCon = "Data Source=61.105.9.203;Initial Catalog=AppDEV; User ID=kfqs1; Password=1234";
                Connect = new SqlConnection(strCon);
                Connect.Open(); // 데이터 베이스에 접속한다.

                if (Connect.State != System.Data.ConnectionState.Open)
                {
                   MessageBox.Show("데이터 베이스 연결에 실패하였씁니다.");
                    return;
                }
                String sLoginId = String.Empty;
                String sPw = String.Empty;
                sLoginId = txtUserId.Text;
                sPw = txtPassword.Text;

                //SQL 조회문을 실행시키기 위한 어댑터
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT PW,USERNAME FROM TB_USER_KBM WHERE USERID = '" + sLoginId + "'", Connect);

                //데이터를 담을 그릇
                DataTable DtTemp = new DataTable();

                //어댑터 실행 후 그릇에 데이터 담기
                adapter.Fill(DtTemp);

                //데이터가 없는 경우 사용자가 없다고 메시지 및 리턴
                if (DtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("등록되지 않은 사용자입니다.");
                    return;
                }

                if (DtTemp.Rows[0]["PW"].ToString() != sPw)
                {
                    MessageBox.Show("비밀번호가 일치하지 않습니다");
                    count = count + 1;
                    if (count >= 3)
                    {
                        MessageBox.Show("3회이상 비밀번호를 틀리셨습니다. 다시 로그인을 시도해주세요");
                        this.Close();
                        Application.Exit();

                    }  
                    return;
                   
                }
                else
                {
                    Common.LogInId = txtUserId.Text;
                    Common.LogInName = DtTemp.Rows[0]["USERNAME"].ToString(); //유저명은 Common에 등록함
                    this.Tag = DtTemp.Rows[0]["USERNAME"].ToString(); //
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("로그인 작업중 오류가 발생하였습니다." + ex.ToString());
            }
            finally
            {
                Connect.Close();
            }
            
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
