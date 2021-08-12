using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Webform2.Lib;

namespace Webform2
{
    public partial class Login : System.Web.UI.Page
    {
        protected string result = string.Empty;
        protected string sql = string.Empty;
        protected string connection = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Request.Params["email"];
            string password = Request.Params["password"];

            User user = new User();
            result = user.Login(email,password);

            //connection = "Data Source=127.0.0.1,1433;Initial Catalog=Crown;User ID=sa;Password=!Wjd635933";
            //sql = "select * from [User] where Email = '" + email + "' and Password = '" + password + "'";
            //SqlConnection con = new SqlConnection();

            //try
            //{
            //    con = new SqlConnection(connection);
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand(sql,con);
            //    SqlDataReader rdr = cmd.ExecuteReader();
            //    rdr.Read();
            //    if (!string.IsNullOrEmpty(rdr["Eamil"].ToString()))
            //    {
            //        result = "OK";
            //    }
            //    else
            //    {
            //        result = "NO";
            //    }
                
            //}
            //catch(Exception ex)
            //{
            //    result = "NO";
            //}
            //finally
            //{
            //    con.Close();
            //}
        }
    }
}