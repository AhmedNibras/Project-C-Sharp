<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FlightWeb.aspx.cs" Inherits="Flight_Web.FlightWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #FFFF00;">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID='welcomeLabel' runat='server' Font-Bold="True" Font-size="XX-Large" Text='Welcome to Areyeng Flight'></asp:Label>
        </div>
        <asp:PlaceHolder ID="PlaceHolder1" runat='server'></asp:PlaceHolder>
        <br />
        <asp:Label ID = 'Label2' runat='server' Text='Fill the following detail'></asp:Label>
        <br />
        <asp:Placeholder ID="PlaceHolder2" runat='server'></asp:Placeholder>
        <br />
        <asp:Label ID="departureLabel" runat="server" Text="Departure Airport:"></asp:Label>
        <asp:DropDownList ID="DropDownDepart" runat="server">
            <asp:ListItem>Dallas Fort Worth International Airport</asp:ListItem>
            <asp:ListItem>Guangzhou Baiyun International Airport</asp:ListItem>
            <asp:ListItem>Indira Gandhi International Airport</asp:ListItem>
            <asp:ListItem>Braam Fischer International</asp:ListItem>
            <asp:ListItem>Dubai International Airport</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:PlaceHolder ID="PlaceHolder3" runat='server'></asp:PlaceHolder>
        <br />
        <asp:Label ID="arrivalLabel" runat="server" Text="Arrival Airport:"></asp:Label>
        <asp:DropDownList ID="DropDownArrival" runat="server">
            <asp:ListItem>Dallas Fort Worth International Airport</asp:ListItem>
            <asp:ListItem>Guangzhou Baiyun International Airport</asp:ListItem>
            <asp:ListItem>Indira Gandhi International Airport</asp:ListItem>
            <asp:ListItem>Braam Fischer International</asp:ListItem>
            <asp:ListItem>Dubai International Airport</asp:ListItem>
        </asp:DropDownList>
        <br/>
        <asp:PlaceHolder ID="PlaceHolder4" runat='server'></asp:PlaceHolder>
        <p>
            <asp:Label ID="dataLabel" runat="server" Text="Departure Date:"></asp:Label>
            <asp:TextBox ID="TextDate" runat="server" Width="270px"></asp:TextBox>
        </p>
        <asp:PlaceHolder ID="PlaceHolder5" runat='server'></asp:PlaceHolder>
        <br />
        <asp:Label ID="nameLabel" runat="server" Text="Passanger Full Name:"></asp:Label>
        <asp:TextBox ID="TextName" runat="server" style="margin-bottom: 0px" Width="245px"></asp:TextBox>
        <br />
        <asp:PlaceHolder ID="PlaceHolder6" runat='server'></asp:PlaceHolder>
        <br />
        <asp:Label ID="idLabel" runat="server" Text="Passenger ID Number:"></asp:Label>
        <asp:TextBox ID="TextID" runat="server" Width="235px"></asp:TextBox>
        <br />
        <asp:PlaceHolder ID="PlaceHolder7" runat='server'></asp:PlaceHolder>
        <br />
        <asp:Label ID="cellLabel" runat="server" Text="Passanger Cell Number:"></asp:Label>
        <asp:TextBox ID="TextCell" runat="server" Width="235px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextCell" ValidationExpression="[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]" ErrorMessage="Please enter a valid phone number in the format 1234567890" Display="Dynamic"></asp:RegularExpressionValidator>
        <br /> 
        <asp:PlaceHolder ID="PlaceHolder8" runat='server'></asp:PlaceHolder>
        <br />
        <asp:Button ID="btnLabel" runat="server" Text="Book" OnClick="Book_Click" />
        <br />
        <asp:PlaceHolder ID="PlaceHolder9" runat='server'></asp:PlaceHolder>
        <br />
        <asp:Label ID="lbl_result" runat="server"></asp:Label>
    </form>
</body>
</html>
