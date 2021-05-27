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
    public partial class FM_CUST : Form
    {
        private SqlConnection Connect = null; // 데이터 베이스 접속 정보
        String strCon = "Data Source=61.105.9.203;Initial Catalog=AppDEV; User ID=kfqs1; Password=1234";
        public FM_CUST()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Connect = new SqlConnection(strCon);
                Connect.Open();

                if (Connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                    return;
                }

                //조회를 위한 파라메터 설정
                String custCode = txtCustCode.Text; //거래처 코드
                String custName = txtCustName.Text; //거래처 이름
                String startDate = dtpStart.Text; //거래 시작일자
                String endDate = dtpEnd.Text; //거래 종료일자
                String bizType = ""; //종목
                String custType = ""; //거래처 타입
                if (rdbCar.Checked == true) bizType = "자동차부품";
                else if (rdbJeol.Checked == true) bizType = "절삭가공";
                else if (rdbPump.Checked == true) bizType = "펌프압축기";
                else if (rdbSang.Checked == true) bizType = "상용차 부품";

                if (chCOnly.Checked == true) custType = "C";

                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT CUSTCODE, " +
                                                            "       CASE WHEN CUSTTYPE = 'C' THEN '고객사' " +
                                                            "            WHEN CUSTTYPE = 'V' THEN '협력사' " +
                                                            "            END AS CUSTTYPE,                  " +          
                                                            "       CUSTNAME, " +
                                                            "       BIZCLASS, " +
                                                            "       BIZTYPE,  " +
                                                            "       CASE WHEN USEFLAG = 'Y' THEN '사용'   " +
                                                            "            WHEN USEFLAG = 'N' THEN '미사용' " +
                                                            "            END AS USEFLAG,                  " +
                                                            "       FIRSTDATE," +
                                                            "       MAKEDATE, " +
                                                            "       MAKER,    " +
                                                            "       EDITDATE, " +
                                                            "       EDITOR    " +
                                                            "FROM TB_CUST_KBM WITH(NOLOCK) " +
                                                            "WHERE CUSTCODE LIKE '%" + custCode + "%'" +
                                                            "  AND CUSTNAME LIKE '%" + custName + "%'" +
                                                            "  AND BIZTYPE LIKE '%" + bizType + "'" +
                                                            "  AND FIRSTDATE BETWEEN '" + startDate + " ' AND '" + endDate + "'" +
                                                            "  AND CUSTTYPE LIKE '%" + custType + "'"
                                                            , Connect);

                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);
                if (dtTemp.Rows.Count == 0)
                {
                    dgvGrid.DataSource = null;
                    return;
                }
                dgvGrid.DataSource = dtTemp; //데이터 그리드 뷰에 데이터 테이블 등록;

                //그리드뷰의 헤더 명칭 선언
                dgvGrid.Columns["CUSTCODE"].HeaderText = "거래처코드";
                dgvGrid.Columns["CUSTTYPE"].HeaderText = "거래처 타입";
                dgvGrid.Columns["CUSTNAME"].HeaderText = "거래처 명";
                dgvGrid.Columns["BIZCLASS"].HeaderText = "업태";
                dgvGrid.Columns["BIZTYPE"].HeaderText = "종목";
                dgvGrid.Columns["USEFLAG"].HeaderText = "사용여부";
                dgvGrid.Columns["FIRSTDATE"].HeaderText = "거래일자";
                dgvGrid.Columns["MAKEDATE"].HeaderText = "등록일시";
                dgvGrid.Columns["MAKER"].HeaderText = "등록자";
                dgvGrid.Columns["EDITDATE"].HeaderText = "수정일시";
                dgvGrid.Columns["EDITOR"].HeaderText = "수정자";

                dgvGrid.Columns["CUSTCODE"].ReadOnly = true;
                dgvGrid.Columns["CUSTTYPE"].ReadOnly = true;
                dgvGrid.Columns["MAKER"].ReadOnly    = true;
                dgvGrid.Columns["MAKEDATE"].ReadOnly = true;
                dgvGrid.Columns["EDITOR"].ReadOnly   = true;
                dgvGrid.Columns["EDITDATE"].ReadOnly = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void fm_cust_load(object sender, EventArgs e)
        {
            dtpStart.Text = string.Format("{0:yyyy-}{1:MM-dd}", DateTime.Today.AddYears(-1), DateTime.Now);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvGrid.Rows.Count == 0) return;
            //데이터 그리드 뷰에 신규 행 추가
            DataRow dr = ((DataTable)dgvGrid.DataSource).NewRow();
            ((DataTable)dgvGrid.DataSource).Rows.Add(dr);
            dgvGrid.Columns["CUSTCODE"].ReadOnly = false;
            dgvGrid.Columns["CUSTTYPE"].ReadOnly = false;

            //마지막에 추가 된 행 선택
            int MaxRow = dgvGrid.Rows.Count - 1;
            dgvGrid.Rows[MaxRow].Selected = true;
            dgvGrid.CurrentCell = dgvGrid.Rows[MaxRow].Cells[0];

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //선택된 행을 삭제한다.
            if (this.dgvGrid.Rows.Count == 0) return;

            if (MessageBox.Show("선택된 데이터를 삭제하시겠습니까?", "데이터삭제", MessageBoxButtons.YesNo)
                ==DialogResult.No) return;

            SqlCommand cmd = new SqlCommand();
            SqlTransaction tran;

            Connect = new SqlConnection(strCon);
            Connect.Open();

            //트랜잭션 관리를 위한 권한 위임
            tran = Connect.BeginTransaction("TranStart");
            cmd.Transaction = tran;
            cmd.Connection = Connect;

            try
            {
                String Custcode = dgvGrid.CurrentRow.Cells["CUSTCODE"].Value.ToString();
                String Custtype = dgvGrid.CurrentRow.Cells["CUSTTYPE"].Value.ToString();

                if (Custtype == "고객사") Custtype = "C";
                else Custtype = "V";

                cmd.CommandText = "DELETE TB_CUST_KBM WHERE CUSTTYPE = '" + Custtype + "'" +
                                  "                     AND CUSTCODE = '" + Custcode + "'";

                cmd.ExecuteNonQuery();

                //성공시 DB Commit
                tran.Commit();
                MessageBox.Show("정상적으로 삭제되었씁니다");
                btnSearch_Click(null, null);
            }
            catch
            {
                tran.Rollback();
                MessageBox.Show("데이터 삭제에 실패하였습니다.");
            }
            finally
            {
                Connect.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //선택된 행 데이터 저장
            if (dgvGrid.Rows.Count == 0) return;
            if (dgvGrid.CurrentRow.Cells[0].Value.ToString() == "" || dgvGrid.CurrentRow.Cells[1].Value.ToString() == "" || dgvGrid.CurrentRow.Cells[6].Value.ToString() == "")
            {
                MessageBox.Show("거래처코드 및 거래처 타입, 거래 일자는 반드시 입력해주세요");
                return;
            }
            else
            {
                if (MessageBox.Show("선택된 데이터를 등록하시겠습니까?", "데이터등록 ",
                                MessageBoxButtons.YesNo) == DialogResult.No) return;
                String custCode = dgvGrid.CurrentRow.Cells["CUSTCODE"].Value.ToString();
                String custType = dgvGrid.CurrentRow.Cells["CUSTTYPE"].Value.ToString();
                String custName = dgvGrid.CurrentRow.Cells["CUSTNAME"].Value.ToString();
                String bizClass = dgvGrid.CurrentRow.Cells["BIZCLASS"].Value.ToString();
                String bizType  = dgvGrid.CurrentRow.Cells["BIZTYPE"].Value.ToString();
                String useFlag  = dgvGrid.CurrentRow.Cells["USEFLAG"].Value.ToString();
                String firstDate = dgvGrid.CurrentRow.Cells["FIRSTDATE"].Value.ToString();

                if (custType == "고객사" || custType == "C") custType = "C";
                else custType = "V";

                if (useFlag == "사용" || useFlag == "Y") useFlag = "Y";
                else useFlag = "N";

                SqlCommand cmd = new SqlCommand();
                SqlTransaction Tran;

                Connect = new SqlConnection(strCon);
                Connect.Open();

                //Transaction 설정
                Tran = Connect.BeginTransaction("TestTran");
                cmd.Transaction = Tran;
                cmd.Connection = Connect;

                cmd.CommandText = "UPDATE TB_CUST_KBM                          " +
                                     "   SET CUSTNAME = '" + custName + "',    " +
                                     "       BIZCLASS = '" + bizClass + "',    " +
                                     "       BIZTYPE = '" + bizType + "',      " +
                                     "       USEFLAG = '" + useFlag + "',      " +
                                     "       FIRSTDATE = '" + firstDate + "',  " +
                                     "       EDITDATE = GETDATE() ,            " +
                                     "       EDITOR = '" + Common.LogInId + "' " +
                                     " WHERE CUSTCODE = '" + custCode + "'" +
                                     "   AND CUSTTYPE = '" + custType + "'" +
                                     "IF (@@ROWCOUNT = 0)" +
                                     "INSERT INTO TB_CUST_KBM (CUSTCODE, CUSTTYPE, CUSTNAME, BIZCLASS, BIZTYPE, USEFLAG, FIRSTDATE, MAKEDATE, MAKER)" +
                                     "  VALUES('" + custCode + "','" + custType + "','" + custName + "','" + bizClass + "','" + bizType + "','" + useFlag + "','" + firstDate + "', GETDATE() ,'" + Common.LogInId + "');";


                cmd.ExecuteNonQuery();

                //성공 시 DB COMMIT
                Tran.Commit();
                MessageBox.Show("정상적으로 등록하였씁니다.");
                Connect.Close();

            }    
            


        }

    }
}
