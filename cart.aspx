<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cart.aspx.cs" Inherits="cart" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
        Style="position: static" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting" 
                        OnPageIndexChanging="GridView1_PageIndexChanging" AllowPaging="True" 
                        PageSize="5" onselectedindexchanged="GridView1_SelectedIndexChanged">
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#EFF3FB" />
        <EditRowStyle BackColor="#2461BF" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" />
        <Columns>
        
        <asp:TemplateField HeaderText="pid">
        <ItemTemplate>
        <asp:Label ID="pid" runat="server" Text='<%#Eval("pid") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="CartId">
        <ItemTemplate>
        <asp:Label ID="cartid" runat="server" Text='<%#Eval("cartid") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="ProductPicture">
        <ItemTemplate>
        <asp:Image ID="imgpath" runat="server" Width="100" Height="100" ImageUrl='<%#Eval("img") %>' />
        </ItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="catagory">
        <ItemTemplate>
        <asp:Label ID="catagory" runat="server" Text='<%#Eval("catagory") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="product Name">
        <ItemTemplate>
        <asp:Label ID="ptype" runat="server" Text='<%#Eval("ptype") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="size">
        <ItemTemplate>
        <asp:Label ID="size" runat="server" Text='<%#Eval("size") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="order date">
        <ItemTemplate>
        <asp:Label ID="date" runat="server" Text='<%#Eval("date") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Price">
        <ItemTemplate>
        <asp:Label ID="price" runat="server" Text='<%#Eval("price") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Quantity">
        <ItemTemplate>
        <asp:TextBox ID="quantity" runat="server" Width="20" Text='<%#Eval("quantity") %>' AutoPostBack="True" OnTextChanged="qty_TextChanged"></asp:TextBox>
        </ItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Total">
        <ItemTemplate>
        <asp:Label ID="total" runat="server" Width="100" Text='<%#Eval("total") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Delete">
        <ItemTemplate>
        <asp:LinkButton ID="delete" runat="server" Text="Delete" CommandName="Delete" CommandArgument='<%#Eval("cartid") %>'></asp:LinkButton>
        </ItemTemplate>
        </asp:TemplateField>
        
        </Columns>
        <EmptyDataTemplate>
            <strong>There are no items in your cart.</strong>
        </EmptyDataTemplate>
    </asp:GridView>
     </td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" OnClick="LinkButton1_Click"
                        Style="position: static" Width="135px">Order >>></asp:LinkButton></td>
                <td style="width: 100px">
                    Total cost:</td>
                <td style="width: 100px">
                    <asp:Label ID="Label1" runat="server" Style="position: static"></asp:Label></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
