using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace MMS_msAccess
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        private const uint WM_SYSKEYDOWN = 0x104;
        //private const string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\wiseeyeon\Data\WiseEyeOn39.mdb;";
        //readonly OleDbConnection con = 
        public Form1()
        {
            InitializeComponent();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                //using (OleDbCommand cmd = new OleDbCommand("select * from checkinout", con))
                using (OleDbCommand cmd = new OleDbCommand("INSERT INTO dbo_Checkinout SELECT src.* FROM checkinout  AS src LEFT JOIN dbo_Checkinout AS tgt ON src.timestr = tgt.timestr WHERE tgt.timestr IS NULL", con))
                {
                    con.Open();

                    OleDbDataReader reader = cmd.ExecuteReader();

                    //meal.Load(reader);
                }
                //}
            }

            void Form1_Load(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'dataSet1.CheckInOut' table. You can move, or remove it, as needed.
                //this.checkInOutTableAdapter.Fill(this.dataSet1.CheckInOut);
                //DataTable dt checkinout = new DataTable();

                //string connstring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

                //using (ole)
                //Checkinout.DataSource = GetCheckInout();

                ////SqlDataAdapter da = new SqlDataAdapter("select COUNT(distinct userenrollnumber)as Lunch from CheckInOut where TimeStr between '2022-11-17 11:04:24.000' and '2022-11-17 13:04:24.000'", "server = 10.10.0.230; database = mms_qv; UID = sa; password = 1234");
                //SqlDataAdapter da = new SqlDataAdapter("MmsCountingDaily '2022-11-22','2022-11-22'", "server = 10.10.0.230; database = mms_qv; UID = sa; password = 1234");
                //DataSet ds = new DataSet();
                //da.Fill(ds, "checkinout");
                //Checkinout.DataSource = ds.Tables["checkinout"].DefaultView;


                //Checkinout.DataSource = Getcheckinout();
            }

            void Search_Click(object sender, EventArgs e)
            {
                DateTime From = dateTimePicker1.Value;
                DateTime To = dateTimePicker2.Value.AddDays(1);


                //string test = "MmsCountingDaily '" + From.ToString("yyyy-MM-dd") +"'"+ "," + "'" + To.ToString("yyyy-MM-dd") + "'";

                //SqlDataAdapter da = new SqlDataAdapter("select COUNT(distinct userenrollnumber)as Lunch from CheckInOut where TimeStr between '2022-11-17 11:04:24.000' and '2022-11-17 13:04:24.000'", "server = 10.10.0.230; database = mms_qv; UID = sa; password = 1234");
                //SqlDataAdapter da = new SqlDataAdapter("MmsCountingDaily '" + From.ToString("yyyy-MM-dd") + "'" , "server = 10.10.0.230; database = mms_qv; UID = sa; password = 1234");
                SqlDataAdapter da = new SqlDataAdapter("MmsCountingDaily '" + From.ToString("yyyy-MM-dd") + "'" + "," + "'" + To.ToString("yyyy-MM-dd") + "'", "server = 10.10.0.230; database = mms_qv; UID = sa; password = 1234");
                //SqlDataAdapter da = new SqlDataAdapter("MmsCountingDaily '2022-11-22','2022-11-22'", "server = 10.10.0.230; database = mms_qv; UID = sa; password = 1234");

                DataSet ds = new DataSet();
                da.Fill(ds, "checkinout");
                Checkinout.DataSource = ds.Tables["checkinout"].DefaultView;

            }

            void Excel_Click(object sender, EventArgs e)
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Exported from gridview";
                // storing header part in Excel  
                for (int i = 1; i < Checkinout.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = Checkinout.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < Checkinout.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < Checkinout.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = Checkinout.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application  
                workbook.SaveAs("D:\\MMS\\mms_" + DateTime.Now.ToString("ddMMyyyy_hhmm") + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
            }

            void Today_Click(object sender, EventArgs e)
            {
                SendMessage(dateTimePicker1.Handle, WM_SYSKEYDOWN, (int)Keys.Down, 0);
            }

            void retry_Click(object sender, EventArgs e)
            {
                //string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

                //using (OleDbConnection con = new OleDbConnection(connString))
                //{
                //    //using (OleDbCommand cmd = new OleDbCommand("select * from checkinout", con))
                //    using (OleDbCommand cmd = new OleDbCommand("INSERT INTO dbo_Checkinout SELECT src.* FROM checkinout  AS src LEFT JOIN dbo_Checkinout AS tgt ON src.timestr = tgt.timestr WHERE tgt.timestr IS NULL", con))
                //    {
                //        con.Open();

                //        OleDbDataReader reader = cmd.ExecuteReader();

                //        //meal.Load(reader);
                //    }
                //}
            }

            //private object GetCheckInout()
            //{
            //    //throw new NotImplementedException();

            //    //DataTable meal = new DataTable();

            //    //string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            //    //using(oledbconnection con = new oledbconnection(connString))
            //    //{
            //    //    using(oledbcommand cmd = new )
            //    //}

            //    //return meal;
            //}

            //private DataTable Getcheckinout()
            //{
            //    //DataTable meal = new DataTable();

            //    // msAccess
            //    string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            //    using (OleDbConnection con = new OleDbConnection(connString))
            //    {
            //        //using (OleDbCommand cmd = new OleDbCommand("select * from checkinout", con))
            //        using (OleDbCommand cmd = new OleDbCommand("INSERT INTO dbo_Checkinout SELECT src.* FROM checkinout  AS src LEFT JOIN dbo_Checkinout AS tgt ON src.timestr = tgt.timestr WHERE tgt.timestr IS NULL", con))
            //        {
            //            con.Open();

            //            OleDbDataReader reader = cmd.ExecuteReader();

            //            //meal.Load(reader);
            //        }
            //    }



            //    //return meal;

            //}
        }

        private void Search_Click(object sender, EventArgs e)
        {
            //DateTime From = dateTimePicker1.Value.AddDays(-1); 
            DateTime From = dateTimePicker1.Value;
            DateTime To = dateTimePicker2.Value.AddDays(1);

            if ((To-From).Days > 31)
            {
                MessageBox.Show("Can not search over 1 month");
            }
            //string test = "MmsCountingDaily '" + From.ToString("yyyy-MM-dd") +"'"+ "," + "'" + To.ToString("yyyy-MM-dd") + "'";
            else
            {
                //SqlDataAdapter da = new SqlDataAdapter("select COUNT(distinct userenrollnumber)as Lunch from CheckInOut where TimeStr between '2022-11-17 11:04:24.000' and '2022-11-17 13:04:24.000'", "server = 10.10.0.230; database = mms_qv; UID = sa; password = 1234");
                //SqlDataAdapter da = new SqlDataAdapter("MmsCountingDaily '" + From.ToString("yyyy-MM-dd") + "'" , "server = 10.10.0.230; database = mms_qv; UID = sa; password = 1234");

                SqlDataAdapter da = new SqlDataAdapter("MmsCountingDaily_Ver4 '" + From.ToString("yyyy-MM-dd") + "'" + "," + "'" + To.ToString("yyyy-MM-dd") + "'", "server = 10.10.0.230; database = mms_qv; UID = sa; password = 1234");
                //SqlDataAdapter da = new SqlDataAdapter("MmsCountingDaily '" + From.ToString("yyyy-MM-dd") + "'" + "," + "'" + To.ToString("yyyy-MM-dd") + "'", "server = 10.10.0.230; database = mms_qv; UID = sa; password = 1234");
                //SqlDataAdapter da = new SqlDataAdapter("MmsCountingDaily '2022-11-22','2022-11-22'", "server = 10.10.0.230; database = mms_qv; UID = sa; password = 1234");

                DataSet ds = new DataSet();
                da.Fill(ds, "checkinout");

                
                Checkinout.DataSource = ds.Tables["checkinout"].DefaultView;
                //Checkinout.Rows[0].Visible = false;

            }
        }

        private void Excel_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < Checkinout.Columns.Count + 1; i++)
            {
                worksheet.Cells[2, i] = Checkinout.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < Checkinout.Rows.Count - 1; i++)
            {
                for (int j = 0; j < Checkinout.Columns.Count; j++)
                {
                    worksheet.Cells[i + 3, j + 1] = Checkinout.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("D:\\MMS\\mms_" + DateTime.Now.ToString("ddMMyyyy_hhmm") + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

        private void retry_Click(object sender, EventArgs e)
        {

        }
    } 
}
