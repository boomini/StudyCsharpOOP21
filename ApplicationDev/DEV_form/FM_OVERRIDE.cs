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
    public partial class FM_OVERRIDE : BaseMDIChildForm
    {
        public FM_OVERRIDE()
        {
            InitializeComponent();
        }

        public override void Save()
        {
            base.Save();
        }
        public override void Inquire()
        {
            base.Inquire();
        }
    }
}
