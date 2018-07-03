<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Ovning30.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Literal ID="LiteralInfo" runat="server"></asp:Literal>
            <br />
            <asp:ListBox ID="ListBoxContacts" runat="server" Height="400px" Width="250px" AutoPostBack="True" OnSelectedIndexChanged="ListBoxContacts_SelectedIndexChanged"></asp:ListBox>
            <h2>Är man stor ska man va snäll.</h2>
            <table>
                <tr>
                    <td>Firstname</td>
                    <td>Lastname</td>
                    <td>SSN</td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="TextBoxFirstname" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBoxLastname" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBoxSSN" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
