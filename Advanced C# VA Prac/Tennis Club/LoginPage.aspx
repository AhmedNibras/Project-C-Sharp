<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Tennis_Club.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="welcomeLabel" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Welcome to Grand Slammer Tennis Club "></asp:Label>
            <br />
            <asp:Label ID="detailLabel" runat="server" Text="Please Enter Username and Password"></asp:Label>

        </div>
        <p>

            <asp:Label ID="usernameLabel" runat="server" Text="Username:"></asp:Label>
&nbsp;<asp:TextBox ID="textUsername" runat="server" style="margin-left: 110px"></asp:TextBox>

        </p>
        <p>

            <asp:Label ID="passwordLabel" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="textPassword" runat="server" style="margin-left: 115px"></asp:TextBox>

        </p>
        <p>

            <asp:Button ID="Login" runat="server" Height="36px" style="margin-left: 227px" Text="Login" Width="108px" OnClick="Login_Click" />

        </p>
        <p>

            <asp:Label ID="lbl_message" runat="server"></asp:Label>

        </p>
    </form>
</body>
</html>
