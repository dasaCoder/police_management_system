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
    public partial class fm_login : Form
    {
        public fm_login()
        {
            InitializeComponent();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;

            try
            {
                

                String connetionString = @"Data Source=DESKTOP-JNSHHOR\MSSQLSERVER01;Initial Catalog=PoliceData;Integrated Security=True";

                conn = new SqlConnection(connetionString);
                conn.Open();
                SqlCommand query = new SqlCommand("select * from users where fname = @u and userpassword = @p");
                query.Parameters.AddWithValue("@u", tb_username.Text);
                query.Parameters.AddWithValue("@p", tb_password.Text);

                query.CommandType = CommandType.Text;
                query.Connection = conn;

                SqlDataReader rdr = query.ExecuteReader();

                if (rdr.Read())
                {
                    fm_home fmhome = new fm_home();
                    fmhome.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }
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
                conn.Close();
            }

        }

        private void Lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void Fm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
