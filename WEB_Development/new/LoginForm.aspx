<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="Practice.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>

                    <td style=" width:300px;">

                        <asp:Label ID="Label1" runat="server" Text="Employee ID"></asp:Label>

                    </td>
                     <td style=" width:300px;">

                         <asp:DropDownList ID="ddlEmployeeId" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEmployeeId_SelectedIndexChanged">
                         </asp:DropDownList>

                    </td>
                     <td style=" width:300px;">

                         <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

                    </td>
                </tr>
                <tr>

                    <td style=" width:300px;">

                        <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>

                    </td>
                     <td style=" width:300px;">

                         <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>

                    </td>
                     <td style=" width:300px;">

                         <asp:Button ID="Button2" runat="server" Text="DELETE" />

                    </td>
                </tr>
                <tr>

                    <td style=" width:300px;">

                        <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>

                    </td>
                     <td style=" width:300px;">

                         <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
                    </td>
                     <td style=" width:300px;">

                         <asp:Button ID="Button3" runat="server" Text="Button" />

                    </td>
                </tr>
                <tr>

                    <td style=" width:300px;">

                        <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>

                    </td>
                     <td style=" width:300px;">

                         <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                    </td>
                     <td style=" width:300px;">

                         <asp:Button ID="Button4" runat="server" Text="Button" />

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
