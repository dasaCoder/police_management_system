using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceRecordManagemenrSystem
{
    public partial class fm_user : Form
    {
        public fm_user()
        {
            InitializeComponent();
        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_home_Click(object sender, EventArgs e)
        {
            fm_home home = new fm_home();
            home.Show();
            this.Close();

        }

        private void Btn_updateuser_Click(object sender, EventArgs e)
        {
            pnl_updateuser.Visible = true;
            pnl_newuser.Visible = false;
        }

        private void Lbl_suslname_Click(object sender, EventArgs e)
        {

        }

        private void Btn_adduser_Click(object sender, EventArgs e)
        {
            pnl_newuser.Visible = true;
            pnl_updateuser.Visible = false;
        }
    }
}
