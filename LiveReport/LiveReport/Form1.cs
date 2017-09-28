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

namespace LiveReport
{
    public partial class Form1 : Form
    {
        String connectionString = "";
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            connectionString = txtDatabaseConnectionString.Text;
            conn = new SqlConnection(connectionString);
            conn.Open();

            double totalMoldedCount = 0;
            double totalSuccessfulMoldCount = 0;
            double totalSuccessfullPaintCount = 0;

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;



            //Total Parts Molded
            cmd.CommandText = "select count(*) from yoyo where state like 'QUEUE_INSPECTION_1';";
            totalMoldedCount = GetCount(cmd.ExecuteReader(), lblTotalMoldedCount);
            
            //Total Parts Successfully Molded
            cmd.CommandText = "select count(*) from yoyo where [State] like 'QUEUE_PAINT';";
            totalSuccessfulMoldCount= GetCount(cmd.ExecuteReader(), lblTotalSuccessMoldCount);

            //Yield at Mold
            lblYieldAtMoldCount.Text = CalculateYield(totalSuccessfulMoldCount, totalMoldedCount);

            cmd.CommandText = "select count(*) from yoyo where [State] like 'QUEUE_ASSEMBLY';";
            totalSuccessfullPaintCount = GetCount(cmd.ExecuteReader(), lblSuccessfullyPaintedCount);


        }

        private string CalculateYield(double successfulCount, double totalCount)
        {
            double yield = successfulCount / totalCount * 100;
            return yield!= 0 ? yield.ToString().Substring(0, 5) + "%" : 0.ToString()+"%";
        }

        private double GetCount(SqlDataReader reader, Label l)
        {
            if (reader.Read())
            {
                double count = double.Parse(String.Format("{0}", reader[0]));
                l.Text = count.ToString();
                reader.Close();
                return count;
            }
            return 0;
        }
    }
}
