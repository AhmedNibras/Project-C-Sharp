<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterFormWeb.aspx.cs" Inherits="RegisterFormWeb.RegisterFormWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>

            <asp:Label ID="regitrationLabel" runat="server" Font-Bold="True" Font-Size="Larger" Text="Welcome to Registration Form"></asp:Label>

        </p>
        <p>

            <asp:Label ID="degreeLabel" runat="server" Text="Select Degree: "></asp:Label>
            <asp:DropDownList ID="dropDegree" runat="server" style="margin-left: 98px">
                <asp:ListItem>Bachelor of Arts</asp:ListItem>
                <asp:ListItem>Bachelor of Commerce</asp:ListItem>
                <asp:ListItem>BSc Biomedicine</asp:ListItem>
                <asp:ListItem>BSc Computer Science</asp:ListItem>
                <asp:ListItem>BSc IT</asp:ListItem>
                <asp:ListItem>Higher Certificate in IT</asp:ListItem>
            </asp:DropDownList>

        </p>
        <p>
            <asp:Label ID="nameLabel" runat="server" Text="Enter Name: "></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="margin-left: 111px; font-weight: 700;" Width="192px" ></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="surnameLabel" runat="server" Text="Enter Surname: "></asp:Label>
            <asp:TextBox ID="txtSurname" runat="server" style="margin-left: 93px" Width="191px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="ageLabel" runat="server" Text="Enter Age: "></asp:Label>
            <asp:TextBox ID="txtAge" runat="server" style="margin-left: 126px" Width="187px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="cellNumberLabel" runat="server" Text="Enter Cell Number: "></asp:Label>
            <asp:TextBox ID="txtCellNumber" runat="server" style="margin-left: 69px" Width="186px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtCellNumber" ErrorMessage="Please Enter the number 10 digit number" Font-Bold="True" ForeColor="#FF3300" ValidationExpression="[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]"></asp:RegularExpressionValidator>
        </p>
        <p>

            <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" style="margin-left: 276px" Text="Register" />

        </p>
        <p>

            <asp:Label ID="lbl_message" runat="server"></asp:Label>

        </p>
    </form>
</body>
</html>
