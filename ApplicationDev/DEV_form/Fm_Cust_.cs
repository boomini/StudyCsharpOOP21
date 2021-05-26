
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
using ApplicationDev;

namespace DEV_form
{
    public partial class Fm_Cust_ : Form
    {
        #region Connection Init
        private SqlConnection Conn = null;
        private string ConnInfo = Common.Db;
        
        #endregion

        public Fm_Cust_()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                #region Connection Open
                Conn = new SqlConnection(ConnInfo);
                Conn.Open();

                if (Conn.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Failed to connect to database.");
                    return;
                }
                #endregion

                #region Variable Init
                string custCode = txtCustCode.Text;
                string custType = "";
                string custName = txtCustName.Text;
                string startDate = dtpStart.Text.ToString();
                string endDate = dtpEnd.Text.ToString();
                string bizType = "";

                if (rdoCVP.Checked == true) bizType = "상용차 부품";
                else if (rdoAVP.Checked == true) bizType = "자동차부품";
                else if (rdoCUT.Checked == true) bizType = "절삭가공";
                else if (rdoCSR.Checked == true) bizType = "펌프압축기";
                else bizType = "";

                if (chkCustOnly.Checked == true) custType = "C";
                #endregion

                #region Fill Data
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT CUSTCODE, " +
                                                                  $"CASE WHEN CUSTTYPE = 'C' THEN '고객사'" +
                                                                  $"WHEN CUSTTYPE = 'V' THEN '협력사'" +
                                                                   "END AS CUSTTYPE, " +
                                                                   "CUSTNAME, " +
                                                                   "BIZCLASS, " +
                                                                   "BIZTYPE,  " +
                                                                  $"CASE WHEN USEFLAG = 'Y' THEN '사용'" +
                                                                  $"WHEN USEFLAG = 'N' THEN '미사용'" +
                                                                   "END AS USEFLAG, " +
                                                                   "FIRSTDATE, " +
                                                                   "MAKEDATE, " +
                                                                   "MAKER, " +
                                                                   "EDITDATE, " +
                                                                   "EDITOR " +
                                                                   "FROM TB_CUST_KBM WITH(NOLOCK) " +
                                                                   $"WHERE CUSTCODE LIKE '%{custCode}%' " +
                                                                   $"AND CUSTTYPE LIKE '%{custType}%' "+
                                                                   $"AND CUSTNAME LIKE '%{custName}%' " +
                                                                   $"AND BIZTYPE LIKE '%{bizType}%' " +
                                                                   $"AND FIRSTDATE BETWEEN '{startDate}' AND '{endDate}'",
                                                                   Conn);
                DataTable DtTemp = new DataTable();
                Adapter.Fill(DtTemp);
                #endregion

                #region Show Data
                if (DtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("검색 조건에 맞는 데이터가 없습니다.");
                    dgvGrid.DataSource = null;
                    return;
                }
                dgvGrid.DataSource = DtTemp;
                #endregion

                #region Column Set
                dgvGrid.Columns["CUSTCODE"].HeaderText = "거래처 코드";
                dgvGrid.Columns["CUSTTYPE"].HeaderText = "거래처 타입";
                dgvGrid.Columns["CUSTNAME"].HeaderText = "거래처명";
                dgvGrid.Columns["BIZCLASS"].HeaderText = "업태";
                dgvGrid.Columns["BIZTYPE"].HeaderText = "종목";
                dgvGrid.Columns["USEFLAG"].HeaderText = "사용여부";
                dgvGrid.Columns["FIRSTDATE"].HeaderText = "거래일자";
                dgvGrid.Columns["MAKEDATE"].HeaderText = "등록일시";
                dgvGrid.Columns["MAKER"].HeaderText = "등록자";
                dgvGrid.Columns["EDITDATE"].HeaderText = "수정일시";
                dgvGrid.Columns["EDITOR"].HeaderText = "수정자";

                dgvGrid.Columns[0].Width = 100;
                dgvGrid.Columns[1].Width = 100;
                dgvGrid.Columns[2].Width = 200;
                dgvGrid.Columns[3].Width = 200;
                dgvGrid.Columns[4].Width = 100;

                dgvGrid.Columns["CUSTCODE"].ReadOnly = true;
                dgvGrid.Columns["CUSTTYPE"].ReadOnly = true;
                dgvGrid.Columns["MAKER"].ReadOnly = true;
                dgvGrid.Columns["MAKEDATE"].ReadOnly = true;
                dgvGrid.Columns["EDITOR"].ReadOnly = true;
                dgvGrid.Columns["EDITDATE"].ReadOnly = true;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow Dr = ((DataTable)dgvGrid.DataSource).NewRow();
            ((DataTable)dgvGrid.DataSource).Rows.Add(Dr);
            dgvGrid.Columns["CUSTCODE"].ReadOnly = false;
            dgvGrid.Columns["CUSTTYPE"].ReadOnly = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvGrid.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 저장하시겠습니까??", "Save", MessageBoxButtons.YesNo) == DialogResult.No) return;

            #region Variable Init
            string custCode = dgvGrid.CurrentRow.Cells["CUSTCODE"].Value.ToString();
            string custType = dgvGrid.CurrentRow.Cells["CUSTTYPE"].Value.ToString();
            string custName = dgvGrid.CurrentRow.Cells["CUSTNAME"].Value.ToString();
            string bizClass = dgvGrid.CurrentRow.Cells["BIZCLASS"].Value.ToString();
            string bizType = dgvGrid.CurrentRow.Cells["BIZTYPE"].Value.ToString();
            string useFlag = dgvGrid.CurrentRow.Cells["USEFLAG"].Value.ToString();
            string firstDate = dgvGrid.CurrentRow.Cells["FIRSTDATE"].Value.ToString();

            if (custCode == "" || custType == "" || firstDate == "")
            {
                MessageBox.Show("'거래처 코드', '거래처 타입', '거래일자' 는 빈칸으로 남겨둘 수 없습니다.");
                return;
            }

            if (custType == "고객사" || custType == "C") custType = "C";
            else custType = "V";

            if (useFlag == "미사용" || useFlag == "N") useFlag = "N";
            else useFlag = "Y";
            #endregion

            #region Transaction Decl
            SqlCommand Cmd = new SqlCommand();
            SqlTransaction Txn;
            #endregion

            #region Connection Open
            Conn = new SqlConnection(ConnInfo);
            Conn.Open();
            #endregion

            #region Transaction Init
            Txn = Conn.BeginTransaction("Test Transaction");
            Cmd.Transaction = Txn;
            Cmd.Connection = Conn;
            #endregion

            #region Transaction Commit
            Cmd.CommandText = "UPDATE TB_CUST_KBM                      " +
                             $"   SET CUSTNAME   = '{custName}',       " +
                             $"       CUSTTYPE   = '{custType}',       " +
                             $"       BIZCLASS   = '{bizClass}',       " +
                             $"       BIZTYPE    = '{bizType}',        " +
                             $"       USEFLAG    = '{useFlag}',        " +
                             $"       FIRSTDATE  = '{firstDate}',      " +
                             $"       EDITOR     = '{Common.LogInId}'," +
                             $"       EDITDATE   = GETDATE()           " +
                             $" WHERE CUSTCODE  = '{custCode}'         " +
                             " IF (@@ROWCOUNT =0)                     " +
                             " INSERT INTO TB_CUST_KBM (CUSTCODE,     CUSTTYPE,     CUSTNAME,     BIZCLASS,     BIZTYPE,     USEFLAG,     FIRSTDATE,   MAKEDATE,   MAKER) " +
                             $"VALUES (               '{custCode}', '{custType}', '{custName}', '{bizClass}', '{bizType}', '{useFlag}', '{firstDate}', GETDATE(), '{Common.LogInId}')";
            Cmd.ExecuteNonQuery();
            Txn.Commit();
            #endregion

            MessageBox.Show("성공적으로 저장하였습니다.");
            Conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvGrid.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 삭제하시겠습니까?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No) return;

            #region Transaction Decl
            SqlCommand Cmd = new SqlCommand();
            SqlTransaction Txn;
            #endregion

            #region Connection Open
            Conn = new SqlConnection(ConnInfo);
            Conn.Open();
            #endregion

            #region Transaction Init
            Txn = Conn.BeginTransaction("Begin Transaction");
            Cmd.Transaction = Txn;
            Cmd.Connection = Conn;
            #endregion

            try
            {
                string delCustCode = dgvGrid.CurrentRow.Cells["CUSTCODE"].Value.ToString();

                #region Transaction Commit
                Cmd.CommandText = $"DELETE TB_CUST_KBM WHERE CUSTCODE = '{delCustCode}'";
                Cmd.ExecuteNonQuery();
                Txn.Commit();
                #endregion

                MessageBox.Show("성공적으로 데이터를 삭제하였습니다.");
                btnSearch_Click(null, null);
            }
            catch (Exception ex)
            {
                Txn.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }

    }
}
