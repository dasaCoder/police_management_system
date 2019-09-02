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
    public partial class fm_entryrecords : Form
    {
        SqlConnection conn = null;
        Int32 victimId;
        Int32 entryId;
        public fm_entryrecords()
        {
            InitializeComponent();
        }

       

        private void Btn_addentry_Click(object sender, EventArgs e)
        {
            pnl_newentry.Visible = false;
            pnlEntryGrid.Visible = false;
            pnlSingleEntry.Visible = false;
            pnlAddVictimforEntry.Visible = true;

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rtb_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pnl_newentry_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_home_Click(object sender, EventArgs e)
        {
            fm_home fm_Home = new fm_home();
            fm_Home.Show();
            this.Close();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_viewentry_Click(object sender, EventArgs e)
        {
            pnlEntryGrid.Visible = true;
        }

        private void Btn_searchentry_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_uodateentry_Click(object sender, EventArgs e)
        {
         /*   pnl_updaterecord.Visible = true;
            btn_cancelupdate.Enabled = true;*/
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {

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

                MessageBox.Show(victimId.ToString());
                
                //MessageBox.Show("Entered Successfully!");
                pnlAddVictimforEntry.Visible = false;
                pnl_newentry.Visible = true;


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

        private void load_entry(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'policeDataDataSet.entryrecords' table. You can move, or remove it, as needed.
            this.entryrecordsTableAdapter.Fill(this.policeDataDataSet.entryrecords);
            //MessageBox.Show("started ");
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

        private void Btn_addentryrecord_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("insert into entryrecords (entry_type,entry_date,division,iduser,idvictim,is_court_case) OUTPUT INSERTED.identry " +
                "values (@eType,@eDate,@division,@iduser,@v,1)");
            query.Parameters.AddWithValue("@eType", this.centryType.SelectedItem);
            query.Parameters.AddWithValue("@eDate", this.dtdate.Value);
            query.Parameters.AddWithValue("@division", this.cBranch.SelectedItem);
            query.Parameters.AddWithValue("@iduser", 1);
            query.Parameters.AddWithValue("@v", this.victimId);

            query.CommandType = CommandType.Text;
            query.Connection = this.conn;

            try
            {

                this.conn.Open();
                entryId = (Int32)query.ExecuteScalar();

                //MessageBox.Show(entryId.ToString());
                
                MessageBox.Show("Entered Successfully!");
                //pnlAddVictimforEntry.Visible = false;
                //pnl_newentry.Visible = true;


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

        private void Btn_entrydescription_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("insert into entrydescription (incident_location,vehicle_number,deaths,injuries,money_value,entry_description,identry) " +
                "values (@location,@vnum,@d,@i,@m,@edes,@id)");

            query.Parameters.AddWithValue("@location", this.txtLc.Text);
            query.Parameters.AddWithValue("@vnum", this.txtvehicle.Text);
            query.Parameters.AddWithValue("@d", this.tb_deaths.Text);
            query.Parameters.AddWithValue("@i", this.tb_injuries.Text);
            query.Parameters.AddWithValue("@m", this.tb_moneyvalue.Text);
            query.Parameters.AddWithValue("@edes", this.tb_description.Text);
            query.Parameters.AddWithValue("@id", this.entryId);

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


        private void viewSingleEntry(int entryId)
        {
            this.entryId = entryId;
            SqlCommand query = new SqlCommand("SELECT * from entryrecords,entrydescription where entryrecords.identry = entrydescription.identry and entryrecords.identry = @id");
            query.Parameters.AddWithValue("@id", this.entryId);

            query.CommandType = CommandType.Text;
            query.Connection = this.conn;

            try
            {
                this.conn.Open();

                SqlDataReader rdr = query.ExecuteReader();

                if (rdr.Read())
                {
                    this.txtentrytype.Text = rdr["entry_type"].ToString();
                }

                pnlSingleEntry.Visible = true;


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
            this.entryId = Int32.Parse(this.txtselectedEntry.Text);

            SqlCommand query = new SqlCommand("SELECT * from entryrecords, entrydescription,victim " +
                                                "where entryrecords.identry = entrydescription.identry " +
                                                "and entryrecords.idvictim = victim.idvictim " +
                                                "and entryrecords.identry = @id");

            query.Parameters.AddWithValue("@id", this.entryId);

            query.CommandType = CommandType.Text;
            query.Connection = this.conn;

            try
            {
                this.conn.Open();

                SqlDataReader rdr = query.ExecuteReader();

                if (rdr.Read())
                {
                    this.lblEntry.Text = rdr["identry"].ToString();
                    this.txtentrytype.Text = rdr["entry_type"].ToString();
                    this.txtentrydate.Text = rdr["entry_date"].ToString();
                    this.txtentrydivision.Text = rdr["division"].ToString();
                    this.txtRvehicle.Text = rdr["vehicle_number"].ToString();
                    this.txtRmoney.Text = rdr["money_value"].ToString();
                    this.txtRdeaths.Text = rdr["deaths"].ToString();
                    this.txtRinjuries.Text = rdr["injuries"].ToString();
                    this.txtRv_name.Text = rdr["fname"].ToString();
                    this.txtRv_nic.Text = rdr["nic"].ToString();
                    this.txtRtele.Text = rdr["mobile_number"].ToString();
                    this.txtRv_addr.Text = rdr["permenent_address"].ToString();
                    this.txtRdetails.Text = rdr["identrydescription"].ToString();
                    this.txtRdescription.Text = rdr["entry_description"].ToString();

                    Console.WriteLine(rdr["vehicle_number"].ToString());
                    Console.WriteLine(rdr["money_value"].ToString());

                }

                pnlEntryGrid.Visible = false;
                pnlSingleEntry.Visible = true;


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

        private void TxtselectedEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
