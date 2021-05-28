using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEV_form
{
    public partial class Fm_User : BaseMDIChildForm
    {
        public Fm_User()
        {
            InitializeComponent();
        }

        public override void Inquire()
        {
            base.Inquire();

            //DB HELPER 선언
            DBHelper helper = new DBHelper(false);
            try
            {
                String sUserId = txtUserID.Text;
                String sUserName = txtUserName.Text;
                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("SP_USER_KBM_S1", CommandType.StoredProcedure
                                           , helper.CreateParameter("USERID", sUserId)
                                           , helper.CreateParameter("USERNAME", sUserName));
                if(dtTemp.Rows.Count == 0)
                {
                    dataGridView1.DataSource = null;
                    MessageBox.Show("조회할 데이터가 없습니다.");
                }
                //string sUserId = dataGridView1.CurrentRow.Cells["USERID"].Value.ToString();
                else
                {
                    //그리드 뷰에 데이터 삽입.
                    dataGridView1.DataSource = dtTemp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally 
            {
                helper.Close();
            }
        }
        public override void DoNew()
        {
            base.DoNew();
            DataRow dr = ((DataTable)dataGridView1.DataSource).NewRow();
            ((DataTable)dataGridView1.DataSource).Rows.Add(dr);
        }
        public override void Delete()
        {
            base.Delete();
            /*if (dataGridView1.Rows.Count == 0) return;
            int iSelectIndex = dataGridView1.CurrentCell.RowIndex;
            DataTable dtTemp = (DataTable)dataGridView1.DataSource;
            dtTemp.Rows[iSelectIndex].Delete();*/
            if (dataGridView1.Rows.Count == 0) return;

            String sUserId = dataGridView1.CurrentRow.Cells["USERID"].Value.ToString();
            DataTable dTtemp = (DataTable)dataGridView1.DataSource;
            for(int i=0; i<dTtemp.Rows.Count; i++)
            {
                if (dTtemp.Rows[i].RowState == DataRowState.Deleted) continue;
                if (dTtemp.Rows[i][0].ToString() == sUserId)
                {
                    dTtemp.Rows[i].Delete();
                    break;
                }
            }

        }

        public override void Save()
        {
            base.Save();
            String UserId = String.Empty;
            String sUserName = String.Empty;
            String sPassword = String.Empty;

            //추가된 row들만 dtTemp로 들어가게된다.
            DataTable dtTemp = ((DataTable)dataGridView1.DataSource).GetChanges();
            if (dtTemp == null) return;

            if (MessageBox.Show("데이터를 등록하시겠씁니까?", "데이터 저장",
               MessageBoxButtons.YesNo) == DialogResult.No) return;
            DBHelper helper = new DBHelper(true);
            try
            {
                //트랜잭션 설정
                //데이터 테이블의 상태 체크
                foreach (DataRow drRow in dtTemp.Rows)
                {
                    switch (drRow.RowState)
                    {
                        case DataRowState.Deleted:
                            drRow.RejectChanges();
                            UserId = drRow["USERID"].ToString();
                            helper.ExecuteNoneQuery("SP_USER_KBM_D1"
                                                    , CommandType.StoredProcedure
                                                    , helper.CreateParameter("USERID", UserId));
                            break;
                        case DataRowState.Added:
                            #region 추가
                            UserId = drRow["USERID"].ToString();
                            sUserName = drRow["USERNAME"].ToString();
                            sPassword = drRow["PW"].ToString();
                            helper.ExecuteNoneQuery("SP_USER_KBM_I1", CommandType.StoredProcedure
                                                    , helper.CreateParameter("USERID", UserId)
                                                    , helper.CreateParameter("USERNAME", sUserName)
                                                    , helper.CreateParameter("PASSWORD", sPassword)
                                                    , helper.CreateParameter("MAKER", Common.LogInId));
                            #endregion
                            break;
                        case DataRowState.Modified:
                            #region 수정
                            UserId = drRow["USERID"].ToString();
                            sUserName = drRow["USERNAME"].ToString();
                            sPassword = drRow["PW"].ToString();
                            helper.ExecuteNoneQuery("SP_USER_KBM_U1", CommandType.StoredProcedure
                                                    , helper.CreateParameter("USERID", UserId)
                                                    , helper.CreateParameter("USERNAME", sUserName)
                                                    , helper.CreateParameter("PASSWORD", sPassword)
                                                    , helper.CreateParameter("EDITOR", Common.LogInId));
                            #endregion
                            break;

                    }
                }

                //성공시 DB COMMIT
                helper.Commit();
                //메세지
                MessageBox.Show("정상적으로 등록하였습니다");

                //재조회
                Inquire();
            }
            catch(Exception ex)
            {
                //트랜잭션 롤백
                helper.Rollback();
                //메세지
                MessageBox.Show("데이터 등록에 실패 하였ㅆ브니다.");
            }
            finally
            {
                //DB Close
                helper.Close();
            }
        }
    }
}
