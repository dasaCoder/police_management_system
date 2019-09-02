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
    public partial class fm_victims : Form
    {
        SqlConnection conn = null;
        Int32 victimId;

        public fm_victims()
        {
            InitializeComponent();
        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_viewvictim_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_addvictim_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_home_Click(object sender, EventArgs e)
        {
            fm_home home = new fm_home();
            home.Show();
            this.Close();
        }

        private void Pnl_victimview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Fm_victims_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policeDataDataSet.victim' table. You can move, or remove it, as needed.
            this.victimTableAdapter.Fill(this.policeDataDataSet.victim);
            this.pnl_addnewvict.Visible = true;

            string connetionString;

            try
            {

                connetionString = @"Data Source=DESKTOP-JNSHHOR\MSSQLSERVER01;Initial Catalog=PoliceData;Integrated Security=True";

                conn = new SqlConnection(connetionString);

                conn.Open();
                //MessageBox.Show("ok");
                Console.Write("Connection MAde");
                conn.Close();
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

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            victimBindingSource.MoveNext();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            victimBindingSource.MovePrevious();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            victimBindingSource.MoveNext();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //victimBindingSource.AddNew();

            SqlCommand query = new SqlCommand("insert into victim (nic, fname, lname, email, bday, gender, permenent_address, occupation, mobile_number, religon, nationality) " +
                "OUTPUT INSERTED.idvictim values(@nic, @fname, @lname, @email, @bday,@gender,@permanent_address,@occupation,@mobile_number,@religion,@national); ");

            query.Parameters.AddWithValue("@nic", this.txtnic.Text);
            query.Parameters.AddWithValue("@fname", this.txtfname.Text);
            query.Parameters.AddWithValue("@lname", this.txtlname.Text);
            query.Parameters.AddWithValue("@email", this.txtemail.Text);
            query.Parameters.AddWithValue("@bday", this.dtdob.Value);
            query.Parameters.AddWithValue("@gender", this.cgender.SelectedItem);
            query.Parameters.AddWithValue("@permanent_address", this.txtaddr.Text);
            query.Parameters.AddWithValue("@occupation", this.txtoccupa.Text);
            query.Parameters.AddWithValue("@mobile_number", this.txtcontact.Text);
            query.Parameters.AddWithValue("@religion", this.creligion.SelectedItem);
            query.Parameters.AddWithValue("@national", this.cnationality.SelectedItem);

            query.CommandType = CommandType.Text;
            query.Connection = this.conn;

            try
            {

                this.conn.Open();
                victimId = (Int32)query.ExecuteScalar();
        
                MessageBox.Show("Entered Successfully!");

                this.txtSelectedVic.Text = victimId.ToString();

                victimTableAdapter.Fill(policeDataDataSet1.victim);
                this.Refresh();
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


        private void Button2_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            SqlCommand query = new SqlCommand("update victim set fname = @fname, nic = @nic, lname = @lname, permenent_address = @addr, " +
                                                 "mobile_number = @mobile, email = @email where idvictim = @id");
            query.Parameters.AddWithValue("@nic", this.txtnic.Text);
            query.Parameters.AddWithValue("@fname", this.txtfname.Text);
            query.Parameters.AddWithValue("@lname", this.txtlname.Text);
            query.Parameters.AddWithValue("@addr", this.txtaddr.Text);
            query.Parameters.AddWithValue("@mobile", this.txtcontact.Text);
            query.Parameters.AddWithValue("@email", this.txtemail.Text);
            query.Parameters.AddWithValue("@id", id);

            query.CommandType = CommandType.Text;
            query.Connection = this.conn;
            try
            {

                this.conn.Open();
                query.ExecuteNonQuery();

                MessageBox.Show("Updated Successfully");
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

        private void addvictivepnl_load(object sender, EventArgs e)
        {
            //MessageBox.Show("opened");
/*            string connetionString;

            try
            {

                connetionString = @"Data Source=DESKTOP-JNSHHOR\MSSQLSERVER01;Initial Catalog=PoliceData;Integrated Security=True";

                conn = new SqlConnection(connetionString);

                conn.Open();
                //MessageBox.Show("ok");
                Console.Write("Connection MAde");
                conn.Close();
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show("sql err");
                Console.WriteLine(sqlException.Message);
            }
            catch(Exception exception)
            {
                MessageBox.Show("err");
                Console.WriteLine(exception.Message);
            }*/
        }

        private void Label34_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnl_addnewvict_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            fm_home home = new fm_home();
            home.Show();
            this.Close();
        }

        private void TxtSelectedVic_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }
    }
}
