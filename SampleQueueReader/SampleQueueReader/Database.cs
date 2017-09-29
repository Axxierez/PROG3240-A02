using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleQueueReader
{
    public static class Database
    {
        public static SqlConnection openConnection()
        {
            String connectionString = frmMain.getConnectionString();
            SqlConnection conn = null;
            if (connectionString == "")
            {
                MessageBox.Show("No Connection String");
            }
            else
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                conn.ChangeDatabase("yoyoData");
            }
            return conn;
        }

        public static void insertYoyoData(string[] data, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            cmd.CommandText = "INSERT INTO yoyo VALUES('" +
                data[0] + "','" +
                data[1] + "','" +
                data[2] + "','" +
                data[3] + "','" +
                data[4] + "','" +
                data[5] + "','" +
                data[6] + "'); ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            reader.Close();

        }

        public static void closeConnection(SqlConnection conn)
        {
            conn.Close();
        }

    }
}
