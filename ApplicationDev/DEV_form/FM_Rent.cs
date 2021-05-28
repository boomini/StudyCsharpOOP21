using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEV_form
{
    public partial class FM_Rent : Form
    {
        private SqlConnection Connect = null; // 데이터 베이스 접속 정보


        public FM_Rent()
        {
            InitializeComponent();
        }
    }
}
