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

public partial class Addproduct : System.Web.UI.Page
{
    SqlConnection cn;
    SqlCommand cmd;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        cn = new SqlConnection("data source=SAMSUNG-PC;Initial catalog=website;Integrated security=true");
        if (cn.State == ConnectionState.Closed)
        {
            cn.Open();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("insert into type values ('"+DropDownList1.Text+"','"+TextBox1.Text+"')",cn);
        cmd.ExecuteNonQuery();
        DropDownList1.SelectedIndex = 0;
        TextBox1.Text = "";
    }
}