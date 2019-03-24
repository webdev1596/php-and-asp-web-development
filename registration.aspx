<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="registration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        name--<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        email--<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        address--<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        city--<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        state--<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        pin--<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        countery--<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        mobile--<asp:TextBox ID="TextBox8" runat="server" 
            ontextchanged="TextBox8_TextChanged"></asp:TextBox>
        <br />
        username--<asp:TextBox ID="TextBox9" runat="server" AutoPostBack="True" 
            ontextchanged="TextBox9_TextChanged"></asp:TextBox>
        <br />
        password--<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="signup" />
    
    </div>
    </form>
</body>
</html>
