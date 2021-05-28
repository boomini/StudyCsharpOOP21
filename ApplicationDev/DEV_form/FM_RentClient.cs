using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEV_form
{
    public partial class FM_RentClient : Form
    {
        private SqlConnection Connect = null;
        private string strConn = "Data Source=222.235.141.8; Initial Catalog=AppDev;User ID=kfqs1;Password=1234";

        public FM_RentClient()
        {
            InitializeComponent();
        }
private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Connect = new SqlConnection(Common.Db);
                Connect.Open();

                if (Connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                    return;
                }
                //고객ID, 고객이름, 고객등급, 가입일자START, END
                //조회를 위한 파라매터 설정
                int iClientId = int.Parse(txtClientID.Text); //고객ID
                String sClientName = txtClientName.Text; //고객이름
                String sStartDate = dtpStart.Text; //가입일자Start
                String sEndDate = dtpEnd.Text; //끝나는일자
                String sClientClass = ""; //고객등급

                if (rdoBlacklist.Checked == true) sClientClass = "BLACK";
                else if (rdoGeneral.Checked == true) sClientClass = "NORMAL";
                else if (rdoVip.Checked == true) sClientClass = "VIP";
                else sClientClass = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
