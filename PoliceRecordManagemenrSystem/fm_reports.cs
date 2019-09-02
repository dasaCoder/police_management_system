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
    public partial class fm_reports : Form
    {
        SqlConnection conn = null;
        public fm_reports()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("select entry.entry_type,entry_date,des.entry_description, is_court_case " +
                                              "from entryrecords entry,entrydescription des " +
                                              "where entry.identry = des.identry " +
                                              "and entry.entry_date between @sd and @ed");
            query.Parameters.AddWithValue("@sd", dt_startdate.Value);
            query.Parameters.AddWithValue("@ed", dt_enddate.Value);
            Console.WriteLine(dt_enddate.Value);
            Console.WriteLine(dt_startdate.Value);
            query.CommandType = CommandType.Text;
            query.Connection = this.conn;

            try
            {
                this.conn.Open();

                SqlDataReader rdr = query.ExecuteReader();

                    datagridReport.Rows.Add(10);

                    int x = 0;
                    while (rdr.Read())
                    {
                       String isCourtCase = "No";
                        if(Int32.Parse(rdr["is_court_case"].ToString()) == 2)
                        {
                            isCourtCase = "Yes";
                        }

                        Console.WriteLine(isCourtCase);

                        datagridReport.Rows[x].Cells[0].Value = rdr["entry_type"].ToString();
                        datagridReport.Rows[x].Cells[1].Value = rdr["entry_date"].ToString();
                        datagridReport.Rows[x].Cells[2].Value = rdr["entry_description"].ToString();
                        datagridReport.Rows[x].Cells[3].Value = isCourtCase;
                        x++;
                        datagridReport.Refresh();
                    }


                datagridReport.Refresh();


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

        private void load_report(object sender, EventArgs e)
        {

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

        private void DatagridReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            fm_home home = new fm_home();
            home.Show();
            this.Close();
        }
    }
}
