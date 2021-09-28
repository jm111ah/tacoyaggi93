using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Webform2.Lib
{
    public class User
    {
        public string result { get; set; }
        public string sql { get; set; }
        public string error { get; set; }

        
        public string Login(string email, string password)
        {
            sql = "select * from [User] where Email = @email and Password = @password";
            using (SqlConnection con = new SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=Crown;User ID=sa;Password=!Wjd635933"))
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                try
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    rdr.Read();
                    if (!string.IsNullOrEmpty(rdr["Email"].ToString()))
                    {
                        result = "OK";
                    }
                    else
                    {
                        result = "NO";
                    }

                }
                catch (Exception ex)
                {
                    error = ex.ToString();
                    result = "NO";
                }
                // using을 사용하므로 굳이 종료를 해줄 필요 없다. 
                //finally
                //{
                //    con.Close();
                //}
            }


            return result;
        }

        public void Signup(string email, string name, string gender, string password)
        {
       
        }
    }
}