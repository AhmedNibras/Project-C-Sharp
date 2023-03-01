<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Shoprite_Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="welcomeLabel" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Welcome to Shoprite Web"></asp:Label>
        </div>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <br />
        <asp:Label ID="prodNameLabel" runat="server" Font-Bold="True" Text="Product Name:"></asp:Label>
&nbsp;<asp:TextBox ID="TextName" runat="server" style="margin-left: 41px"></asp:TextBox>
        <br />
        <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
        <br />
        <asp:Label ID="prodTypeLabel" runat="server" Font-Bold="True" Text="Product Type:"></asp:Label>
        <br />
        <asp:RadioButtonList ID="RadioPriceType" runat="server" OnSelectedIndexChanged="RadioPriceType_SelectedIndexChanged">
            <asp:ListItem>Food</asp:ListItem>
            <asp:ListItem>Cosmetics</asp:ListItem>
            <asp:ListItem>Electronics</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder>
        <br />
        <asp:Label ID="prodQuantLabel" runat="server" Font-Bold="True" Text="Product Quantity:"></asp:Label>
<asp:TextBox ID="TextQuantity" runat="server" style="margin-left: 21px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextQuantity" ErrorMessage="Add Input" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
        <br />
        <asp:PlaceHolder ID="PlaceHolder4" runat="server"></asp:PlaceHolder>
        <br />
        <asp:Label ID="prodPriceLabel" runat="server" Font-Bold="True" Text="Product Price:"></asp:Label>
<asp:TextBox ID="TextPrice" runat="server" style="margin-left: 47px"></asp:TextBox>
<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextPrice" ErrorMessage="Add Input" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
        <br />
        <asp:PlaceHolder ID="PlaceHolder5" runat="server"></asp:PlaceHolder>
        <br />
        <asp:Button ID="btnCapture" runat="server" OnClick="Button1_Click" Text="Capture" />
        <br />
        <asp:PlaceHolder ID="PlaceHolder6" runat="server"></asp:PlaceHolder>
        <br />
        <asp:Label ID="lbl_result" runat="server"></asp:Label>
    </form>
</body>
</html>
