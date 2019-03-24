<%@ Page Language="C#" AutoEventWireup="true" CodeFile="billadd.aspx.cs" Inherits="billadd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table style="width: 487px; position: static; height: 100px">
            <tr>
                <td colspan="2">
                    &nbsp;<asp:Label ID="Label2" runat="server" Style="position: static" Text="Billing Address >>>"
                        Width="146px"></asp:Label></td>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Style="position: static" Text="Shipping Address >>>"
                        Width="156px"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" Style="position: static"
                        Text="Same address" OnCheckedChanged="CheckBox1_CheckedChanged" Width="151px" /></td>
            </tr>
            <tr>
                <td style="width: 100px; height: 21px">
                    <asp:Label ID="Label3" runat="server" Style="position: static" Text="Name :"></asp:Label></td>
                <td style="width: 100px; height: 21px">
                    <asp:TextBox ID="TextBox1" runat="server" Style="position: static"></asp:TextBox></td>
                <td style="width: 100px; height: 21px">
                    <asp:Label ID="Label12" runat="server" Style="position: static" Text="Name :"></asp:Label></td>
                <td style="width: 100px; height: 21px">
                    <asp:TextBox ID="TextBox10" runat="server" Style="position: static"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:Label ID="Label4" runat="server" Style="position: static" Text="Email:"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox2" runat="server" Style="position: static"></asp:TextBox></td>
                <td style="width: 100px">
                    <asp:Label ID="Label13" runat="server" Style="position: static" Text="Email :"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox11" runat="server" Style="position: static"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:Label ID="Label5" runat="server" Style="position: static" Text="Address :"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox3" runat="server" Style="position: static"></asp:TextBox></td>
                <td style="width: 100px">
                    <asp:Label ID="Label14" runat="server" Style="position: static" 
                        Text="Address :"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox12" runat="server" Style="position: static"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:Label ID="Label6" runat="server" Style="position: static" Text="City :" 
                        Width="64px"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox4" runat="server" Style="position: static"></asp:TextBox></td>
                <td style="width: 100px">
                    <asp:Label ID="Label15" runat="server" Style="position: static" Text="City :" 
                        Width="64px"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox13" runat="server" Style="position: static"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:Label ID="Label7" runat="server" Style="position: static" Text="State :"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox5" runat="server" Style="position: static"></asp:TextBox></td>
                <td style="width: 100px">
                    <asp:Label ID="Label16" runat="server" Style="position: static" Text="State:"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox14" runat="server" Style="position: static"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:Label ID="Label8" runat="server" Style="position: static" 
                        Text="Pin Code :"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox6" runat="server" Style="position: static"></asp:TextBox></td>
                <td style="width: 100px">
                    <asp:Label ID="Label17" runat="server" Style="position: static" 
                        Text="Pin Code :"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox15" runat="server" Style="position: static"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px; height: 26px">
                    <asp:Label ID="Label9" runat="server" Style="position: static" Text="Country :"></asp:Label></td>
                <td style="width: 100px; height: 26px">
                    <asp:TextBox ID="TextBox7" runat="server" Style="position: static"></asp:TextBox></td>
                <td style="width: 100px; height: 26px">
                    <asp:Label ID="Label18" runat="server" Style="position: static" Text="Country :"></asp:Label></td>
                <td style="width: 100px; height: 26px">
                    <asp:TextBox ID="TextBox16" runat="server" Style="position: static"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:Label ID="Label11" runat="server" Style="position: static" Text="Mobile no :"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox9" runat="server" Style="position: static"></asp:TextBox></td>
                <td style="width: 100px">
                    <asp:Label ID="Label20" runat="server" Style="position: static" Text="Mobile no :"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox18" runat="server" Style="position: static"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td align="center" colspan="2">
                    <asp:Button ID="Button1" runat="server" Style="position: static" Text="Proceed & Continue>>" OnClick="Button1_Click" /></td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
