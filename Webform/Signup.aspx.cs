using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webform2
{
    public partial class Signup : System.Web.UI.Page
    {
        protected string email = string.Empty;
        protected string name = string.Empty;
        protected string gender = string.Empty;
        protected string password = string.Empty;
        protected string passcheck = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            email = Request.Params["email"];
            name = Request.Params["name"];
            gender = Request.Params["gender"];
            password = Request.Params["password"];
            passcheck = Request.Params["passcheck"];
        }
    }
}