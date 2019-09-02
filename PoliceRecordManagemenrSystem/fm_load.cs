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
    public partial class fm_load : Form
    {
        public fm_load()
        {
            InitializeComponent();
        }

        //Loading Login screen
        private void Btn_login_Click(object sender, EventArgs e)
        {
            fm_login fmlogin = new fm_login();
            fmlogin.Show();
            //this.Close();
        }
    }
}
