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

namespace PoliceRecordManagemenrSystem
{
    public partial class fm_suspects : Form
    {
        SqlConnection conn = null;
        String entry_id;
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

        private void Fm_suspects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policeDataDataSet.entryrecords' table. You can move, or remove it, as needed.
            this.entryrecordsTableAdapter.Fill(this.policeDataDataSet.entryrecords);

            try
            {

                String connetionString = @"Data Source=DESKTOP-JNSHHOR\MSSQLSERVER01;Initial Catalog=PoliceData;Integrated Security=True";

                this.conn = new SqlConnection(connetionString);

                //this.conn.Open();
                //MessageBox.Show("ok");
                Console.Write("Connection MAde");
                //this.conn.Close();
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show("sql err");
                Console.WriteLine(sqlException.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show("err");
                Console.WriteLine(exception.Message);
            }
            finally
            {
                this.conn.Close();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.entry_id = this.txtSentryid.Text;
            this.pnlEntryforsuspect.Visible = false;
            this.pnl_newsuspect.Visible = true; 
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label27_Click(object sender, EventArgs e)
        {

        }

        private void Txtaddr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("insert into suspect (nic,fname,lname,bday,gender,permenent_address,occupation,mobile_number,nationality,identry) " +
                                                "values(@n,@f,@l,@b,@g,@p,@o,@m,@nati,@i)");

            query.Parameters.AddWithValue("@n", txtnic.Text);
            query.Parameters.AddWithValue("@f", txtfname.Text);
            query.Parameters.AddWithValue("@l", txtlname.Text);
            query.Parameters.AddWithValue("@b", dtdob.Value);
            query.Parameters.AddWithValue("@g", cgender.SelectedItem.ToString());
            query.Parameters.AddWithValue("@p", txtaddr.Text);
            query.Parameters.AddWithValue("@o", txtoccupa.Text);
            query.Parameters.AddWithValue("@m", txtcontact.Text);
            query.Parameters.AddWithValue("@nati", cnationality.SelectedItem.ToString());
            query.Parameters.AddWithValue("@i", this.entry_id);

            query.CommandType = CommandType.Text;
            query.Connection = this.conn;

            try
            {

                this.conn.Open();
                query.ExecuteNonQuery();

                MessageBox.Show("Entered Successfully!");



            }
            catch (SqlException sqlException)
            {
                MessageBox.Show("sql err");
                Console.WriteLine(sqlException.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show("err");
                Console.WriteLine(exception.Message);
            }
            finally
            {
                this.conn.Close();
            }

        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            var home = new fm_home();
            home.Show();
            this.Hide();
        }
    }
}
