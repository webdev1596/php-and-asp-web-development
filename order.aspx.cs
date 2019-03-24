using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class order : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("data Source=SAMSUNG-PC;initial catalog=website;integrated security=true");
    SqlCommand cmd1, cmd2;
    SqlDataReader dtr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((string)Session["uid"]=="" || (string)Session["pt"]=="")
        {
            Response.Redirect("home.aspx");
        }

       
          
           }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["pt"] = "";
        Session["uid"] = "";
        Response.Redirect("home.aspx");
    }
}
