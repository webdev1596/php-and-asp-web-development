<%@ Page Language="C#" AutoEventWireup="true" CodeFile="showiteam.aspx.cs" Inherits="showiteam" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>select catagory</asp:ListItem>
            <asp:ListItem>male</asp:ListItem>
            <asp:ListItem>female</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem>select product type</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
    <asp:DataList ID="DataList1" runat="server" BackColor="Gray" BorderColor="#666666"

            BorderStyle="None" BorderWidth="2px" CellPadding="3" CellSpacing="2"

            Font-Names="Verdana" Font-Size="Small" GridLines="Both" 
        RepeatColumns="3" RepeatDirection="Horizontal"

            Width="600px" onselectedindexchanged="DataList1_SelectedIndexChanged" OnItemCommand="DataList1_ItemCommand">

            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />

            <HeaderStyle BackColor="#333333" Font-Bold="True" Font-Size="Large" ForeColor="White"

                HorizontalAlign="Center" VerticalAlign="Middle" />

            <HeaderTemplate>

                you are search</HeaderTemplate>

            <ItemStyle BackColor="White" ForeColor="Black" BorderWidth="2px" />

            <ItemTemplate>

                <asp:Image ID="imgEmp" runat="server" Width="200px" Height="200px" ImageUrl='<%# Eval("img") %>' style="padding-left:40px"/><br />

                <b>Catagory</b>
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("catagory") %>'></asp:Label>
                <br>
                <b>product type:</b>
                
                <asp:Label ID="lblCName" runat="server" Text='<%# Eval("ptype") %>'></asp:Label>

                <br />

                <b>price:</b>

                <asp:Label ID="lblName" runat="server" Text='<%# Eval("price") %>'></asp:Label>

                <br />

               <b> quantity:</b>

                <asp:Label ID="lblCity" runat="server" Text=' <%# Eval("quantity") %>'></asp:Label>

                <br />

                <b>size:</b>

                <asp:Label ID="lblCountry" runat="server" Text='<%# Eval("size") %>'></asp:Label>


                <br />
                <b>
            <asp:LinkButton ID="LinkButton1" runat="server" Style="position: static" Text="addtocart" CommandArgument='<%#Eval("pid") %>' CommandName="Cart"></asp:LinkButton></td>
            </b>
            </ItemTemplate>

        </asp:DataList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/cart.aspx">cart</asp:LinkButton>
    </div>
    </form>
</body>
</html>
