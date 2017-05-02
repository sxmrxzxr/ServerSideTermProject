<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPortal.aspx.cs" Inherits="WebClient.AdminPortal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:GridView ID="grvAdminLog" runat="server" AutoGenerateColumns="false">
        <Columns>                
            <asp:BoundField DataField="ActivityType" HeaderText="Action" ReadOnly="True" SortExpression="ActivityType" />
            <asp:BoundField DataField="AccountID" HeaderText="Recipient" ReadOnly="True" SortExpression="AccountID" />
            <asp:BoundField DataField="AdminID" HeaderText="By" ReadOnly="True" SortExpression="AdminID" />
        </Columns>
    </asp:GridView>
        <a href="AdminMain.aspx">Back to Admin Main Page</a>
    </form>
</body>
</html>
