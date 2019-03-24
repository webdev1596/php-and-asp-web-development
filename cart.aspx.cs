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

public partial class cart : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("data Source=SAMSUNG-PC;initial catalog=website;integrated security=true");
    SqlDataAdapter da;
   DataSet ds;
   // SqlCommand cmd;
   // SqlDataReader dtr;
    decimal total = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

        if (Page.IsPostBack != true)
        {
            GetUserSelectedproducts((string )Session["uid"]);
            GetTotal();
        }




    }
    private void GetUserSelectedproducts(string  uid)
    {
        da = new SqlDataAdapter("select tatc.pid,tatc.catagory,tatc.size,tatc.date,tatc.cartid,tatc.ptype,tatc.img,tatc.price,tatc.quantity,tatc.total from addcart tatc inner join login tl on tl.uname=tatc.uname where tatc.uname='" + uid + "' ", con);
        ds = new DataSet();
        da.Fill(ds, "tbl_tatc");
        
        GridView1.DataSource = ds.Tables["tbl_tatc"].DefaultView;
        GridView1.DataBind();
    }
    protected void qty_TextChanged(object sender, EventArgs e)
    {
        foreach (GridViewRow gr in GridView1.Rows)
        {
            TextBox qty = (TextBox)gr.Cells[4].FindControl("quantity");
            int quantity = Convert.ToInt32(qty.Text);

            Label cartid = (Label)gr.Cells[0].FindControl("cartid");

            Label cost = (Label)gr.Cells[3].FindControl("price");
            decimal totcost1 = Convert.ToDecimal(cost.Text);

            totcost1 = totcost1 * quantity;
            gr.Cells[5].Text = totcost1.ToString();

            total = total + totcost1;

            if (cartid.Text != "")
            {
                da = new SqlDataAdapter("update addcart set quantity=" + quantity + ",total=" + totcost1 + " where cartid=" + Convert.ToInt32(cartid.Text) + " and uname='" + (string)Session["uid"].ToString() + "' ", con);
                int n = da.SelectCommand.ExecuteNonQuery();
                if (n == 1)
                {
                    GetUserSelectedproducts((string)Session["uid"]);
                }
            }


            //gr.Cells[5].Text=
        }

        Label1.Text = total.ToString();
    }

    private void GetTotal()
    {
        foreach (GridViewRow gr in GridView1.Rows)
        {
            Label tcost = (Label)gr.Cells[5].FindControl("total");
            decimal totalcost = Convert.ToDecimal(tcost.Text);
            total = total + totalcost;
        }
        Label1.Text = total.ToString();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label cartid = new Label();
        cartid = (Label)GridView1.Rows[e.RowIndex].Cells[0].FindControl("cartid");

        if (cartid.Text != "")
        {
            da = new SqlDataAdapter("delete from addcart where cartid=" + Convert.ToInt32(cartid.Text) + " and uname=" + (string)Session["uid"] + " ", con);
            int n = da.SelectCommand.ExecuteNonQuery();
            if (n == 1)
            {
                GetUserSelectedproducts((string )Session["uid"]);
                GetTotal();
            }
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (Convert.ToDecimal(Label1.Text) > 0)
        {

            foreach (GridViewRow gr in GridView1.Rows)
            {
                Label pid = (Label)gr.Cells[0].FindControl("pid");
                Label cartid = (Label)gr.Cells[1].FindControl("cartid");
               // Label imgage = (Label)gr.Cells[2].FindControl("img");
                //string img = Convert.ToString(imgage.Text);
                Label catagory1= (Label)gr.Cells[3].FindControl("catagory");
                string catagory = Convert.ToString(catagory1.Text);
                Label  ptype1 = (Label)gr.Cells[4].FindControl("ptype");
                string ptype = Convert.ToString(ptype1.Text);
                Label size = (Label)gr.Cells[5].FindControl("size");
                Label date1= (Label)gr.Cells[6].FindControl("date");
                string date = Convert.ToString(date1.Text);
                Label price = (Label)gr.Cells[7].FindControl("price");
                TextBox qty = (TextBox)gr.Cells[8].FindControl("quantity");
                int quantity = Convert.ToInt32(qty.Text);
                Label total = (Label)gr.Cells[9].FindControl("total");
               
              SqlCommand cmd = new SqlCommand("insert into sold values("+Convert.ToInt32 (cartid.Text)+","+Convert.ToInt32 (pid.Text)+",'"+(string)Session["uid"]+"','"+catagory+"','"+ptype+"','null',"+Convert.ToInt32(price.Text) +","+quantity +","+Convert.ToInt32(size.Text)+",'"+date+"',"+Convert.ToInt32(total.Text) +",getdate())", con);
              cmd.ExecuteNonQuery();

              SqlCommand cmd1 = new SqlCommand("delete from addcart where [uname]='"+(string)Session["uid"]+"'",con);
              cmd1.ExecuteNonQuery();
              Response.Redirect("order.aspx");
            }
            
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GetUserSelectedproducts((string)Session["uid"]);
    }



    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}