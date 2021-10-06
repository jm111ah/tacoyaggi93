using Crown.ViewModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileSystemGlobbing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Crown.Lib
{
    public class DBConnection : Viewmodel_Login
    {
        string connectionst = "Data Source=127.0.0.1;Initial Catalog=test;Integrated Security=SSPI;";

        public void Select(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionst))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    Viewmodel_ds = ds;
                }
                catch (Exception ex)
                {
                    ErrorMessage = ex.Message;
                }
            }
        }

        public void Insert(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionst))
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    ErrorMessage = ex.Message;
                }
            }
        }



    }
}
