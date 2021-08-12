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
        public string  sql { get; set; }
        //public string connection = "Data Source=127.0.0.1,1433;Initial Catalog=Crown;User ID=sa;Password=!Wjd635933";
        public SqlConnection con = new SqlConnection("Data Source=127.0.0.1,1433;Initial Catalog=Crown;User ID=sa;Password=!Wjd635933");
        public string Login(string email , string password)
        {
            sql = "select * from [User] where Email = '" + email + "' and Password = '" + password + "'";
            //SqlConnection con = new SqlConnection();
            try
            {
                //con = new SqlConnection(connection);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                if (!string.IsNullOrEmpty(rdr["Eamil"].ToString()))
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
                result = "NO";
            }
            finally
            {
                con.Close();
            }

            return result;
        }

        public void Signup(string email,string name,string gender,string password)
        {
            sql = "insert into [User](Email,Password,Name,Gender) values('"+email+"','"+password+"','"+name+"','"+gender+"')";
        }
    }
}