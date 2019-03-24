using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class registration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("data Source=SAMSUNG-PC;initial catalog=website;integrated security=true");
    SqlCommand cmd;
    SqlDataReader dtr;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox8_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox9_TextChanged(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select uname from login where uname='"+TextBox9.Text+"'",con);
        dtr = cmd.ExecuteReader();
        if (dtr.Read())
        {
            TextBox9.Text = "";


        }
        else
        {
            TextBox10.Focus();
        }
        dtr.Close();
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into login values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "')", con);
        cmd.ExecuteNonQuery();
        Response.Redirect("home.aspx");
        con.Close();
    }
}