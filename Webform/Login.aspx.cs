using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webform2
{
    public partial class Login : System.Web.UI.Page
    {
        protected string result = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Request.Params["email"];
            string password = Request.Params["password"];

            if (email == "test" && password == "123")
            {
                result = "OK";
            }
            else
            {
                result = "NO";
            }
        }
    }
    
}