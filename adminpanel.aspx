<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminpanel.aspx.cs" Inherits="adminpanel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        iteam add----<br />
        <br />
        <br />
        catagory
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>--select--</asp:ListItem>
            <asp:ListItem>male</asp:ListItem>
            <asp:ListItem>female</asp:ListItem>
        </asp:DropDownList>
        <br />
        product type<asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>select</asp:ListItem>
        </asp:DropDownList>
        <br />
        image upload<asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        price<asp:TextBox ID="TextBox1" runat="server" Width="129px"></asp:TextBox>
        <br />
        quantity<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        size<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="save" />
    
    </div>
    </form>
</body>
</html>
