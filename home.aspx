<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        welcome home---<br />
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">shoes</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">wallet</asp:LinkButton>
    
        <br />
        <br />
        <asp:LinkButton ID="LinkButton6" runat="server" PostBackUrl="~/adminpanel.aspx">Admin Panel</asp:LinkButton>
    
        <br />
        <asp:LinkButton ID="LinkButton5" runat="server" PostBackUrl="~/Addproduct.aspx">AddProduct</asp:LinkButton>
        <br />
        <br />
        <br />
        <br />
        <asp:LinkButton ID="LinkButton3" runat="server" 
            PostBackUrl="~/registration.aspx">signup</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton4" runat="server" onclick="LinkButton4_Click">login</asp:LinkButton>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Visible="False">
            username<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            password<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="signin" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
