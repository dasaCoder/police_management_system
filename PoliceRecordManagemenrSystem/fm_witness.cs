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
    public partial class fm_witness : Form
    {
        public fm_witness()
        {
            InitializeComponent();
        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_updatewitness_Click(object sender, EventArgs e)
        {
            pnl_updatewitness.Visible = true;
            pnl_newwitness.Visible = false;
            pnl_viewwitness.Visible = false;
        }

        private void Rb_susmale_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void Btn_addwitness_Click(object sender, EventArgs e)
        {
            pnl_newwitness.Visible = true;
            pnl_updatewitness.Visible = false;
            pnl_viewwitness.Visible = false;
        }

        private void Btn_viewwitness_Click(object sender, EventArgs e)
        {
            pnl_viewwitness.Visible = true;
            pnl_newwitness.Visible = false;
            pnl_updatewitness.Visible = false;
        }

        private void Btn_home_Click(object sender, EventArgs e)
        {
            fm_home home = new fm_home();
            home.Show();
            this.Close();

        }
    }
}
