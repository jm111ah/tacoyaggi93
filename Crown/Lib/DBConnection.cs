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
        //private string connectionst = "Server=(localdb)\\MSSQLLocalDB;Database=test;Trusted_Connection=True;MultipleActiveResultSets=true";
        string connectionst = "Data Source=(local);Initial Catalog=pubs;Integrated Security=SSPI;";



        public void Select(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionst))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    Viewmodel_ds = ds;
                }
                catch (Exception ex)
                {

                }

            }

        }

    }
}
