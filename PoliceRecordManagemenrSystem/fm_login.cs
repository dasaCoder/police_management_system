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
    public partial class fm_login : Form
    {
        public fm_login()
        {
            InitializeComponent();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            fm_home fmhome = new fm_home();
            fmhome.Show();
            this.Close();
            
        }

        private void Lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void Fm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
