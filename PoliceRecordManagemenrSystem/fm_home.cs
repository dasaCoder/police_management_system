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
    public partial class fm_home : Form
    {
        public fm_home()
        {
            InitializeComponent();
        }

        private void Btn_reports_Click(object sender, EventArgs e)
        {
            fm_reports rpr = new fm_reports();
            rpr.Show();
            this.Close();
        }

        // Load form Entry Records
        private void Btn_entryrecords_Click(object sender, EventArgs e)
        {
            fm_entryrecords entryrecords = new fm_entryrecords();
            entryrecords.Show();
            this.Close();
        }

        private void Btn_suspects_Click(object sender, EventArgs e)
        {
            fm_suspects suspects = new fm_suspects();
            suspects.Show();
            this.Close();
        }

        private void Btn_victims_Click(object sender, EventArgs e)
        {
            fm_victims victims = new fm_victims();
            victims.Show();
            this.Close();
        }

        private void Btn_witness_Click(object sender, EventArgs e)
        {
            fm_witness witness = new fm_witness();
            witness.Show();
            this.Close();
        }

        private void Btn_courtcase_Click(object sender, EventArgs e)
        {
            fm_courtcase courtcase = new fm_courtcase();
            courtcase.Show();
            this.Close();
        }

        private void Btn_userrecords_Click(object sender, EventArgs e)
        {
            fm_user user = new fm_user();
            user.Show();
            this.Close();
        }
    }
}
