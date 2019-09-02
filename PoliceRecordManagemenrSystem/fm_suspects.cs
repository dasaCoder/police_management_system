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
    public partial class fm_suspects : Form
    {
        public fm_suspects()
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

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Btn_addsuspect_Click(object sender, EventArgs e)
        {
            pnl_newsuspect.Visible = true;
            pnl_updatesuspect.Visible = false;
            pnl_viewsuspect.Visible = false;

        }


        private void Btn_viewsuspect_Click(object sender, EventArgs e)
        {
            pnl_viewsuspect.Visible = true;
            pnl_newsuspect.Visible = false;
            pnl_updatesuspect.Visible = false;
        }

        private void Btn_suspect_Click(object sender, EventArgs e)
        {
            pnl_updatesuspect.Visible = true;
            pnl_newsuspect.Visible = false;
            pnl_viewsuspect.Visible = false;
        }
    }
}
