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
    public partial class fm_courtcase : Form
    {
        SqlConnection conn = null;
        public fm_courtcase()
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

        private void Btn_viewwitness_Click(object sender, EventArgs e)
        {
            pnl_viewcourtcase.Visible = true;
            pnl_newcourtcase.Visible = false;
            pnl_entrygrid_court.Visible = false;
        }

        private void Btn_updatewitness_Click(object sender, EventArgs e)
        {
            pnl_entrygrid_court.Visible = true;
            pnl_newcourtcase.Visible = false;
            pnl_viewcourtcase.Visible = false;
        }

        private void Btn_addcourtcase_Click(object sender, EventArgs e)
        {
            pnl_newcourtcase.Visible = false;
            pnl_entrygrid_court.Visible = false;
            pnl_viewcourtcase.Visible = false;
            pnl_entrygrid_court.Visible = true;
        }

        private void Fm_courtcase_Load(object sender, EventArgs e)
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
                this.conn.Close();
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

        private void Btn_addcc_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("insert into courtcase (last_courtdate,next_courtdate,identry) values(@ld,@nd,@id);" +
                                               "update entryrecords set is_court_case = 2 where identry = @id; ");

            query.Parameters.AddWithValue("@ld", dt_last.Value);
            query.Parameters.AddWithValue("@nd", dt_next.Value);
            query.Parameters.AddWithValue("@id", tb_entryidupdate.Text);

            query.CommandType = CommandType.Text;
            query.Connection = this.conn;

            try
            {

                this.conn.Open();
                //entryId = (Int32)query.ExecuteScalar();
                query.ExecuteNonQuery();
                //MessageBox.Show(entryId.ToString());
                this.conn.Close();
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


        }
    }

/*        private void Tb_entryidupdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }*/
    }

