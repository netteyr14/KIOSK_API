using System.Data.Odbc;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjCSTAKiosk
{
    class ClasCon
    {
        public OdbcConnection conn;
        private string conStr = "server=localhost;uid=root;password=Ambin123456123456;database=dbIPT;Driver={MYSQL ODBC 3.51 Driver};";

        public ClasCon()
        {
            conn = new OdbcConnection(conStr);
        }

        public void connection()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
        }

        public DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                connection();
                using (OdbcDataAdapter da = new OdbcDataAdapter(sql, conn))
                {
                    da.Fill(dt);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Error");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
