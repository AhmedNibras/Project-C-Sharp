<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HealthDepartment.aspx.cs" Inherits="Covid_19.HealthDepartment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="welcomeLabel" runat="server" Font-Bold="True" Font-Size="Larger" Text="Welcome To Covid-19 Health Department"></asp:Label>

        </div>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <br />
        <asp:Label ID="detailLabel" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" Text="Enter your Detail"></asp:Label>
        <br />
        <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
        <br />
        <asp:Label ID="nameLabel" runat="server" Font-Bold="True" Text="Full Name:"></asp:Label>
        <asp:TextBox ID="textName" runat="server" Width="259px"></asp:TextBox>
        <br />
        <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder>
        <br />
        <asp:Label ID="idName" runat="server" Font-Bold="True" Text="ID No: "></asp:Label>
        <asp:TextBox ID="textID" runat="server" Width="259px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="textID" runat="server" ErrorMessage="Enter 13 Digit id Number" ValidationExpression="[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]"></asp:RegularExpressionValidator>
        <br />
        <asp:PlaceHolder ID="PlaceHolder4" runat="server"></asp:PlaceHolder>
        <br />
        <asp:Label ID="ageName" runat="server" Font-Bold="True" Text="Age: "></asp:Label>
        <asp:TextBox ID="textAge" runat="server" Height="16px" Width="259px"></asp:TextBox>


        <br />
        <asp:PlaceHolder ID="PlaceHolder5" runat="server"></asp:PlaceHolder>
        <br />
        <asp:Label ID="vaccineLabel" runat="server" Font-Bold="True" Font-Underline="True" Text="Vaccine Required"></asp:Label>
        <br />
        

        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Pfizer(Comirnaty)</asp:ListItem>
            <asp:ListItem>Moderna(Spikevax)</asp:ListItem>
            <asp:ListItem>Novawax(Nuvaxovid)</asp:ListItem>
        </asp:RadioButtonList>
        

        <p>

            <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" />

        </p>
        


        <br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
        
    </form>
        
        
</body>
</html>
