using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;

namespace MyStore
{
    class dataaccess
  
    {
        string con = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        SqlConnection cn;
        SqlCommand cmd;

        void openConnection()
        {
            cn = new SqlConnection(con);
            cn.Open();
        }
        void closeConnection()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
        public SqlDataReader SelectQuery(String query)
        {
            openConnection();
            cmd = new SqlCommand(query, cn);
            return cmd.ExecuteReader();
        }
        public int NonQuery(String query)
        {
            openConnection();
            cmd = new SqlCommand(query, cn);
            int temp = cmd.ExecuteNonQuery();
            closeConnection();
            return temp;
        }
        public void FillComboBox(ComboBox cb, string query)
        {
            openConnection();
            SqlDataReader rec = SelectQuery(query);
            while (rec.Read())
            {
                cb.Items.Add(rec[0].ToString());
            }
        }
        public void filldataGrid(DataGridView dg, String query)
        {
            openConnection();
            cmd = new SqlCommand(query, cn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dg.DataSource = ds.Tables[0];


        }

    }
}

