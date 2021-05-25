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
    public partial class FM_Item : Form
    {
        private SqlConnection Connect = null; // 데이터 베이스 접속 정보
        String strCon = "Data Source=61.105.9.203;Initial Catalog=AppDEV; User ID=kfqs1; Password=1234";


        public FM_Item()
        {
            InitializeComponent();
        }


        private void FM_ITEM_Load(object sender, EventArgs e)
        {
            try
            {
                //콤보박스 품목 상세 데이터 조회 및 추가
                Connect = new SqlConnection(strCon); // 접속 정보 커넥션에 등록 및 객체선언

                Connect.Open();

                if (Connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                    return;
                }

                //SQL 조회문을 실행하기 위한 어댑터
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT ITEMDESC FROM TB_TESTITEM_KBM GROUP BY ITEMDESC", Connect);

                //데이터를 담을 그릇
                DataTable DtTemp = new DataTable();

                //어댑터 실행 후 그릇에 데이터 담기
                adapter.Fill(DtTemp);
                cboItemDesc.DataSource = DtTemp;
                cboItemDesc.DisplayMember = "ITEMDESC"; //눈으로 보여줄항목
                cboItemDesc.ValueMember = "ITEMDESC"; //실제 데이터를 처리할 코드 항목
                cboItemDesc.Text = "";

                //원하는 날짜 픽스
                dtpStart.Text = string.Format("{0:yyyy-}{1:MM-dd}", DateTime.Today.AddYears(-1), DateTime.Now );
                //지금 현재 년, 월, 1일로 날짜 고정
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connect.Close();
            }
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
                //조회를 위한 파라매터 설정
                String sItemCode = txtItemCode.Text; //품목코드
                String sItemName = txtItemName.Text; //품목 명
                String sStartDate = dtpStart.Text; //출시 시작일자
                String sEndDate = dtpEnd.Text;     //출시 종료 일자
                String sItemdesc = cboItemDesc.Text;//품목 상세

                String sEndFlag = "N";
                if (rdoEnd.Checked == true) sEndFlag = "Y"; //단종여부
                if (chkNameOnly.Checked == true) sItemCode = ""; //이름으로만 검색

                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT ITEMCODE, "  +
                                                            "       ITEMNAME, "  +
                                                            "       ITEMDESC, "  +
                                                            "       ITEMDESC2,"  +
                                                            "       CASE WHEN ENDFLAG = 'Y' THEN '단종'  "  +
                                                            "            WHEN ENDFLAG = 'N' THEN '생산'  "  +
                                                            "            END AS ENDFLAG,                 "  +  
                                                            "       PRODDATE, "  +
                                                            "       MAKEDATE, "  +
                                                            "       MAKER,    "  +
                                                            "       EDITDATE, "  +
                                                            "       EDITOR    "  +
                                                            "FROM TB_TESTITEM_KBM WITH(NOLOCK) " +
                                                            "WHERE ITEMCODE LIKE '%" + sItemCode + "%'" +
                                                            "  AND ITEMNAME LIKE '%" + sItemName + "%'" +
                                                            "  AND ITEMDESC LIKE '%" + sItemdesc + "%'" +
                                                            "  AND ENDFLAG = '" + sEndFlag + "'" +
                                                            "  AND PRODDATE BETWEEN '" + sStartDate + "' AND '" + sEndDate + "'"
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
                dgvGrid.Columns["ITEMCODE"].HeaderText = "품목 코드";
                dgvGrid.Columns["ITEMNAME"].HeaderText = "품목 명";
                dgvGrid.Columns["ITEMDESC"].HeaderText = "품목 상세";
                dgvGrid.Columns["ITEMDESC2"].HeaderText = "품목 상세2";
                dgvGrid.Columns["ENDFLAG"].HeaderText = "단종 여부";
                dgvGrid.Columns["PRODDATE"].HeaderText = "출시 일자";
                dgvGrid.Columns["MAKEDATE"].HeaderText = "등록 일시";
                dgvGrid.Columns["MAKER"].HeaderText = "등록자";
                dgvGrid.Columns["EDITDATE"].HeaderText = "수정 일시";
                dgvGrid.Columns["EDITOR"].HeaderText = "수정자";

                //그리드 뷰의 폭 지정
                dgvGrid.Columns[0].Width = 150;
                dgvGrid.Columns[1].Width = 200;
                dgvGrid.Columns[2].Width = 200;
                dgvGrid.Columns[3].Width = 200;
                dgvGrid.Columns[4].Width = 150;

                //컬럼의 수정 여부를 지정한다
                dgvGrid.Columns["ITEMCODE"].ReadOnly = true;
                dgvGrid.Columns["MAKER"].ReadOnly = true;
                dgvGrid.Columns["MAKEDATE"].ReadOnly = true;
                dgvGrid.Columns["EDITOR"].ReadOnly = true;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //데이터 그리드 뷰에 신규 행 추가
            DataRow dr = ((DataTable)dgvGrid.DataSource).NewRow();
            ((DataTable)dgvGrid.DataSource).Rows.Add(dr);
            dgvGrid.Columns["ITEMCODE"].ReadOnly = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //선택된 행을 삭제한다
            if (this.dgvGrid.Rows.Count == 0) return;
            
            if (MessageBox.Show("선택된 데이터를 삭제하시겠습니까?", "데이터삭제", MessageBoxButtons.YesNo)
                == DialogResult.No) return;

            SqlCommand cmd = new SqlCommand();
            SqlTransaction tran;

            Connect = new SqlConnection(strCon);
            Connect.Open();

            // 트랜잭션 관리를 위한 권한 위임
            tran = Connect.BeginTransaction("TranStart");
            cmd.Transaction = tran;
            cmd.Connection = Connect;

            try
            {
                string Itemcode = dgvGrid.CurrentRow.Cells["ITEMCODE"].Value.ToString();
                cmd.CommandText = "DELETE TB_TESTITEM_KBM WHERE ITEMCODE = '" + Itemcode + "'";

                cmd.ExecuteNonQuery();

                //성공 시 DB Commit
                tran.Commit();
                MessageBox.Show("정상적으로 삭제되었습니다><");
                btnSearch_Click(null, null); //데이터 재조회
            }
            catch
            {
                tran.Rollback();
                MessageBox.Show("데이터 삭제에 실패하였씁니다.");

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
            if (MessageBox.Show("선택된 데이터를 등록하시겠습니까?", "데이터등록", 
                                MessageBoxButtons.YesNo) == DialogResult.No) return;
            String sItemCode = dgvGrid.CurrentRow.Cells["ITEMCODE"].Value.ToString();
            String sItemName = dgvGrid.CurrentRow.Cells["ITEMNAME"].Value.ToString();
            String sItemDesc = dgvGrid.CurrentRow.Cells["ITEMDESC"].Value.ToString();
            String sItemDesc2 = dgvGrid.CurrentRow.Cells["ITEMDESC2"].Value.ToString();
            String sItemEndFlag = dgvGrid.CurrentRow.Cells["ENDFLAG"].Value.ToString();
            String sProdDate = dgvGrid.CurrentRow.Cells["PRODDATE"].Value.ToString();

            if (sItemEndFlag == "단종" || sItemEndFlag == "Y") sItemEndFlag = "Y";
            else sItemEndFlag = "N";

            SqlCommand cmd = new SqlCommand();
            SqlTransaction Tran;

            Connect = new SqlConnection(strCon);
            Connect.Open();

            //데이터 조회 후 해당 데이터가 있는지 확인 후 UPDATE, INSERT 구문 분기
            /*String sSql = "SELECT ITEMCODE FROM TB_TESTITEM_KBM WHERE ITEMCODE = '" + sItemCode + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sSql, Connect);
            DataTable dtTemp = new DataTable();
            adapter.Fill(dtTemp);
            */

            //Transaction 설정
            Tran = Connect.BeginTransaction("TestTran");
            cmd.Transaction = Tran;
            cmd.Connection = Connect;

            cmd.CommandText = "UPDATE TB_TestItem_KBM                                   " +
                                      "    SET ITEMNAME = '" + sItemName + "',             " +
                                      "        ITEMDESC = '" + sItemDesc + "',             " +
                                      "        ITEMDESC2 = '" + sItemDesc2 + "',            " +
                                      "        ENDFLAG = '" + sItemEndFlag + "',              " +
                                      "        PRODDATE = '" + sProdDate + "',             " +
                                      //"        EDITOR = '',  " +
                                      "        EDITOR = '"    + Common.LogInId + "',  " +
                                      "        EDITDATE = GETDATE()     " +
                                      "  WHERE ITEMCODE = '" + sItemCode + "'" +
                                      " IF (@@ROWCOUNT =0) " +
                                      "INSERT INTO TB_TestItem_KBM(ITEMCODE,           ITEMNAME,            ITEMDESC,           ITEMDESC2,          ENDFLAG,           PRODDATE,      MAKEDATE,     MAKER) " +
                                      "VALUES('" + sItemCode + "','" + sItemName + "','" + sItemDesc + "','" + sItemDesc2 + "','" + sItemEndFlag + "','" + sProdDate + "',GETDATE(),'" + Common.LogInId+"');";
            //데이터가 있는경우 UPDATE, 없는 경우 INSERT
            /*
            if (dtTemp.Rows.Count == 0)
            {
                //데이터가 없으니 INSERT 해라
                cmd.CommandText = "INSERT INTO TB_TESTITEM_KBM (ITEMCODE, ITEMNAME, ITEMDESC,ITEMDESC2,ENDFLAG,PRODDATE,MAKEDATE,MAKER)" +
                                                    "VALUES ('"+ sItemCode +"', '" + sItemName + "', '" + sItemDesc + "', '"+ sItemDesc2 + "', '"+ sItemEndFlag + "', '"+ sProdDate + "', GETDATE(), ''); ";
                
            }
            else
            {
                //데이터가 있으니 UPDATE 해라
                cmd.CommandText = "UPDATE TB_TestItem_KBM                                   " +
                                  "    SET ITEMNAME = '" + sItemName + "',             " +
                                  "        ITEMDESC = '" + sItemDesc + "',             " +
                                  "        ITEMDESC2 = '" + sItemDesc2 + "',            " +
                                  "        ENDFLAG = '" + sItemEndFlag + "',              " +
                                  "        PRODDATE = '" + sProdDate + "',             " +
                                  "        EDITOR = '',  " +
                                  //"        EDITOR = '"    + Commoncs.LoginUserID + "',  " +
                                  "        EDITDATE = GETDATE()     " +
                                  "  WHERE ITEMCODE = '" + sItemCode + "'";
            }
            */
            cmd.ExecuteNonQuery();


            //성공시 DB COMMIT
            Tran.Commit();
            MessageBox.Show("정상적으로 등록하였습니다.");
            Connect.Close();
        }
    }
}
