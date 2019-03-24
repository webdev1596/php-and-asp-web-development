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



public partial class billadd : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("data Source=SAMSUNG-PC;initial catalog=website;integrated security=true");
    SqlDataAdapter da;
    DataSet ds;
    
    protected void Page_Load(object sender, EventArgs e)
    {
         if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

        if (!Page.IsPostBack)
        {
            GetBillingDetails((string)(Session["uid"]));           
        }
    }

    private void GetBillingDetails(string  uid)
    {
        da = new SqlDataAdapter("select name,email,address,city,state,pin,country,mob from login where [uname]='" + uid + "'", con);
        ds = new DataSet();
        da.Fill(ds,"login");
        if (ds.Tables.Count > 0 && ds.Tables["login"].Rows.Count > 0)
        {
            TextBox1.Text = ds.Tables["login"].Rows[0][0].ToString();
            TextBox2.Text = ds.Tables["login"].Rows[0][1].ToString();
            TextBox3.Text = ds.Tables["login"].Rows[0][2].ToString();
            TextBox4.Text = ds.Tables["login"].Rows[0][3].ToString();
            TextBox5.Text = ds.Tables["login"].Rows[0][4].ToString();
            TextBox6.Text = ds.Tables["login"].Rows[0][5].ToString();
            TextBox7.Text = ds.Tables["login"].Rows[0][6].ToString();
            TextBox9.Text = ds.Tables["login"].Rows[0][7].ToString();
        } 
    }

    
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid == true)
        {
            if (TextBox10.Text != "")
            {
                Session["name"] = TextBox10.Text;
                Session["email"] = TextBox11.Text;
                Session["add"] = TextBox12.Text;
                Session["city"] = TextBox13.Text;
                Session["state"] = TextBox14.Text;
                Session["pin"] = TextBox15.Text;
                Session["country"] = TextBox16.Text;
                Session["mob"] = TextBox18.Text;
                if (Session.Count > 0) /// && Request.QueryString.Count>0)
                {
                    // int artid = Convert.ToInt32(Request.QueryString["pitemid"].ToString());
                    Response.Redirect("Order.aspx");  ////?pitemid=" + artid.ToString());
                }
            }
        }
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
        
        da = new SqlDataAdapter("select name,email,address,city,state,pin,country,mob from login where uname='" +(string )Session ["uid"] + "'", con);
        ds = new DataSet();
        da.Fill(ds, "login");
        if (ds.Tables.Count > 0 && ds.Tables["login"].Rows.Count > 0)
        {
            TextBox10.Text = ds.Tables["login"].Rows[0][0].ToString();
            TextBox11.Text = ds.Tables["login"].Rows[0][1].ToString();
            TextBox12.Text = ds.Tables["login"].Rows[0][2].ToString();
            TextBox13.Text = ds.Tables["login"].Rows[0][3].ToString();
            TextBox14.Text = ds.Tables["login"].Rows[0][4].ToString();
            TextBox15.Text = ds.Tables["login"].Rows[0][5].ToString();
            TextBox16.Text = ds.Tables["login"].Rows[0][6].ToString();
            TextBox18.Text = ds.Tables["login"].Rows[0][7].ToString();
        } 
        }
        else
        {
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
            TextBox14.Text = "";
            TextBox15.Text = "";
            TextBox16.Text = "";
            TextBox18.Text = "";
        }
    }
    }
