using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class home : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("data Source=SAMSUNG-PC;initial catalog=website;integrated security=true");
    SqlCommand cmd;
    SqlDataReader dtr;
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.Visible = false;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session ["pt"]=LinkButton1.Text;
        Response.Redirect("showiteam.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Session["pt"] = LinkButton2.Text;
        Response.Redirect("showiteam.aspx");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from login where uname='"+TextBox1.Text+"' and pass='"+TextBox2.Text+"'",con);
        dtr = cmd.ExecuteReader();
        if (dtr.Read())
        {
            Session["uid"] = TextBox1.Text;
            // Response.Redirect("");
        }
        else
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox1.Focus();
        }
        dtr.Close();
        con.Close();
    }
}