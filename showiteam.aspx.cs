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


public partial class showiteam : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("data Source=SAMSUNG-PC;initial catalog=website;integrated security=true");
    SqlDataAdapter da;
    DataSet ds;
    SqlCommand cmd;
    SqlDataReader dtr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        if (!Page.IsPostBack)
        {
            Getproductdetails();
        }
    }

    private void Getproductdetails()
    {
        da = new SqlDataAdapter("select pid,img,catagory,ptype,price,quantity,size from productdetail where [ptype]='" + (string)Session["pt"] + "' or [catagory]='"+DropDownList1.Text+"'", con);
        ds = new DataSet();
        da.Fill(ds, "tbl_pidetails");
        DataList1.DataSource = ds.Tables["tbl_pidetails"].DefaultView;
        DataList1.DataBind();
    }


    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
         

        if (e.CommandName=="Cart")
        {
            da = new SqlDataAdapter("select count(*) from addcart tatc inner join login tl on tatc.uname=tl.uname where tatc.pid=" + Convert.ToInt32(e.CommandArgument.ToString()) + " and tl.uname='" + (string)Session["uid"] + "' and tatc.uname='" + (string )Session["uid"] + "'", con);
            int n = Convert.ToInt32(da.SelectCommand.ExecuteScalar());
            if (n == 1)
            {
                da = new SqlDataAdapter("select tpd.pid,tpd.ptype,tpd.price,tpd.img,tl.uname,tatc.cartid from productdetail tpd inner join addcart tatc on tpd.pid=tatc.pid inner join login tl on tl.uname=tatc.uname where tatc.pid=" + Convert.ToInt32(e.CommandArgument.ToString()) + " and tl.uname='" + ((string )Session["uid"]) + "' ", con);
                ds = new DataSet();
                da.Fill(ds, "tbl_tpd");
                if (ds.Tables.Count > 0 && ds.Tables["tbl_tpd"].Rows.Count > 0)
                {
                    da = new SqlDataAdapter("update addcart set uname='" + (string )Session["uid"]+ "',pid=" + Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + ",ptype='" + ds.Tables[0].Rows[0][1].ToString() + "',img='" + ds.Tables[0].Rows[0][3].ToString() + "',price=" + Convert.ToDecimal(ds.Tables[0].Rows[0][2].ToString()) + ",date=getdate() where pid=" + Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + " and cartid=" + Convert.ToInt32(ds.Tables[0].Rows[0][5].ToString()) + " and uname='" + (string )Session["uid"] + "' ", con);
                    da.SelectCommand.ExecuteNonQuery();
                }
            }

            else
            {

                da = new SqlDataAdapter("select pid,catagory,ptype,img,price,size from productdetail where pid=" + Convert.ToInt32(e.CommandArgument.ToString()) + " ", con);
            ds = new DataSet();
             da.Fill(ds, "tbl_tpd");

             if (ds.Tables.Count > 0 && ds.Tables["tbl_tpd"].Rows.Count > 0)
             {
                 da = new SqlDataAdapter("insert into addcart (pid,uname,catagory,ptype,img,price,quantity,size,date,total) values(" + Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + ",'" + (string)Session["uid"] + "','" + ds.Tables[0].Rows[0][1].ToString() + "','" + ds.Tables[0].Rows[0][2].ToString() + "','" + ds.Tables[0].Rows[0][3].ToString() + "'," + Convert.ToInt32(ds.Tables[0].Rows[0][4].ToString()) + ",1," + Convert.ToDecimal(ds.Tables[0].Rows[0][5].ToString()) + ",getdate()," + Convert.ToInt32 (ds.Tables[0].Rows[0][4].ToString()) + ")", con);
                 da.SelectCommand.ExecuteNonQuery();
             }
            
        }
    }
}
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        da = new SqlDataAdapter("select pid,img,catagory,ptype,price,quantity,size from productdetail where [catagory]='" + DropDownList1.Text + "'", con);
        ds = new DataSet();
        da.Fill(ds, "tbl_pidetails");
        DataList1.DataSource = ds.Tables["tbl_pidetails"].DefaultView;
        DataList1.DataBind();

        DropDownList2.Items.Clear();
        DropDownList2.Items.Add("select product type");
        SqlCommand cmd = new SqlCommand("select ptype from type where [catagory]='" + DropDownList1.Text + "'", con);
        SqlDataReader dtr = cmd.ExecuteReader();
        while (dtr.Read())
        {
           
            DropDownList2.Items.Add((string)dtr["ptype"]);
        }

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("select pid,img,catagory,ptype,price,quantity,size from productdetail where [ptype]='" + DropDownList2.Text + "' and [catagory]='" + DropDownList1.Text + "'", con);
        ds = new DataSet();
        da.Fill(ds, "tbl_pidetails");
        DataList1.DataSource = ds.Tables["tbl_pidetails"].DefaultView;
        DataList1.DataBind();

       
        
    }
}
   
