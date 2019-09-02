using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        private void exportPdf()
        {
            try
            {
                String time = GetTimestamp(DateTime.Now);
                var pdfDoc = new Document(PageSize.A4);
                string path = $"d:\\reports\\police_report_{time}.pdf";

                PdfWriter.GetInstance(pdfDoc,new FileStream(path, FileMode.OpenOrCreate));
                pdfDoc.Open();

                iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 30);
                iTextSharp.text.Font regularFont = FontFactory.GetFont("Arial", 36);
                Paragraph title;
                Paragraph text;
                title = new Paragraph("Sri Lanka Police", titleFont);
                title.Alignment = Element.ALIGN_CENTER;

                pdfDoc.Add(title);

                var spacer = new Paragraph("")
                {
                    SpacingBefore = 10f,
                    SpacingAfter = 10f
                };

                pdfDoc.Add(spacer);
                pdfDoc.Add(spacer);


                var headerTable = new PdfPTable(new[] { .75f, 2f })
                {
                    HorizontalAlignment = Left,
                    WidthPercentage = 75,
                    DefaultCell = { MinimumHeight = 22f }
                };

                headerTable.AddCell("Type");
                headerTable.AddCell("Test");
                headerTable.AddCell("From");
                headerTable.AddCell(this.dt_startdate.Text);
                headerTable.AddCell("To");
                headerTable.AddCell(this.dt_enddate.Text);

                pdfDoc.Add(headerTable);

                pdfDoc.Add(spacer);
                pdfDoc.Add(spacer);


                var columnCount = datagridReport.ColumnCount;
                var columnWidths = new[] { 0.75f, 2f, 2f, 1f };

                var table = new PdfPTable(columnWidths)
                {
                    HorizontalAlignment = Left,
                    WidthPercentage = 100,
                    DefaultCell = { MinimumHeight = 22f }
                };

                var cell = new PdfPCell(new Phrase("Entry Records"))
                {
                    Colspan = columnCount,
                    HorizontalAlignment = 1,
                    MinimumHeight = 30f
                };

                table.AddCell(cell);
                this.datagridReport.Columns
                        .OfType<DataGridViewColumn>()
                        .ToList()
                        .ForEach(c => table.AddCell(c.Name));


                int row = datagridReport.Rows.Count;
                int cell2 = datagridReport.Rows[1].Cells.Count;
                for (int i = 0; i < row - 1; i++)
                {
                    for (int j = 0; j < cell2; j++)
                    {
                        if (datagridReport.Rows[i].Cells[j].Value == null)
                        {
                            //return directly
                            //return;
                            //or set a value for the empty data
                            //datagridReport.Rows[i].Cells[j].Value = "";
                            continue;
                        }
                        table.AddCell(datagridReport.Rows[i].Cells[j].Value.ToString());
                    }
                }

                pdfDoc.Add(table);

                pdfDoc.Close();

                MessageBox.Show("Generated Succesfully!");
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.exportPdf();
        }
    }
}
