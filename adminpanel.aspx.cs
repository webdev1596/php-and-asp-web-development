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
using System.Web.Caching;
using System.Data.SqlClient;

public partial class adminpanel : System.Web.UI.Page
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
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        SqlDataReader dtr;
        SqlCommand cm = new SqlCommand("select pid from productdetail order by pid desc", con);
        dtr = cm.ExecuteReader();
        int i;
        if (dtr.Read())
        {
            i = (int)dtr["pid"];
            i++;
        }
        else
        {
            i = 1;
        }
        dtr.Close();
        if (FileUpload1.PostedFile.ContentLength > 0 && FileUpload1.HasFile == true)
        {
            string filename = Guid.NewGuid().ToString().Substring(0, 10) + "" + FileUpload1.PostedFile.FileName.Remove(0, FileUpload1.PostedFile.FileName.LastIndexOf("."));
            FileUpload1.SaveAs(Server.MapPath("~/img/" + filename.ToString()));
            string imgpath = "~/img/" + filename.ToString();
            da = new SqlDataAdapter("insert into productdetail values("+i+",'"+DropDownList1.Text+"','"+DropDownList2.Text+"','" + imgpath.ToString() + "',"+TextBox1.Text+","+TextBox2.Text+","+TextBox3.Text +")", con);
            int n = da.SelectCommand.ExecuteNonQuery();
            if (n == 1)
            {
                TextBox3.Text = "";
                TextBox2.Text = "";
                TextBox1.Text = "";
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                Response.Redirect("home.aspx");
            }
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();

        SqlCommand cmd = new SqlCommand("select ptype from type where [catagory]='" + DropDownList1.Text + "'", con);
        SqlDataReader dtr = cmd.ExecuteReader();
       while (dtr.Read())
        {
            DropDownList2.Items.Add((string)dtr["ptype"]);
        }
    }
}