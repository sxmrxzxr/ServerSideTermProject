<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminRegister.aspx.cs" Inherits="WebClient.AdminRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    
        <asp:Label ID="lblAdminPanel" runat="server" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 573px; top: 47px; position: absolute" Text="Admin Panel"></asp:Label>
        <asp:GridView ID="gvUsers" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 533px; top: 173px; position: absolute; height: 133px; width: 187px">
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="FirstName" HeaderText="First Name" ReadOnly="True" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" ReadOnly="True" SortExpression="LastName" />
                <asp:BoundField DataField="Email" HeaderText="Email" ReadOnly="True" SortExpression="Email" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" style="z-index: 1; left: 809px; top: 309px; position: absolute" Text="Register" />
        <asp:Label ID="lblSelectUser" runat="server" style="z-index: 1; left: 527px; top: 124px; position: absolute" Text="Select User to Register as an Administrator"></asp:Label>
    
    </form>
</body>
</html>
