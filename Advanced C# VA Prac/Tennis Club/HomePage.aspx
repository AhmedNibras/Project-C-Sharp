<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Tennis_Club.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="welcomeLabel" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Welcome to the site"></asp:Label>
            <br />
            <asp:Label ID="dropLabel" runat="server" Font-Bold="True" Font-Italic="True" Text="Select from the dropdown list the coach detail "></asp:Label>
        </div>
        <p>
            <asp:Label ID="coachDetailLabel" runat="server" Font-Bold="True" Font-Size="Medium" Text="Coach Details:"></asp:Label>
        </p>
        
            <asp:Label ID="coachLabel" runat="server" Font-Bold="True" Text="Select Coach:"></asp:Label>
            <asp:DropDownList ID="drpList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpList_SelectedIndexChanged" style="margin-left: 74px" Width="198px">
            </asp:DropDownList>
            <br />
            <br />

    
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    Coach Name:<%# DataBinder.Eval(Container.DataItem, "Coach_Name") %><br /><br />Gender:<%# DataBinder.Eval(Container.DataItem, "Gender") %><br /><br />Province:<%# DataBinder.Eval(Container.DataItem, "Province") %><br /><br />Contact Number:<%# DataBinder.Eval(Container.DataItem, "Contact_Number") %><br /><br />

                </ItemTemplate>
            </asp:Repeater>
                <asp:Label ID="lbl_message2" runat="server"></asp:Label>
            
        </p>
    </form>
</body>
</html>
