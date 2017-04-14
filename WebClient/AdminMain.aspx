<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminMain.aspx.cs" Inherits="WebClient.AdminMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblWelcomeAdmin" runat="server" Font-Size="X-Large" Font-Underline="True" style="z-index: 1; left: 499px; top: 44px; position: absolute" Text="Welcome Admin!"></asp:Label>
        <asp:Button ID="btnReturnToLogin" runat="server" OnClick="btnReturnToLogin_Click" style="z-index: 1; left: 299px; top: 49px; position: absolute" Text="Return to Login" />
        <p>
            <asp:Button ID="btnRegisterNewAdmin" runat="server" OnClick="btnRegisterNewAdmin_Click" style="z-index: 1; left: 501px; top: 102px; position: absolute; width: 160px" Text="Register New Admin" />
        </p>
    </form>
</body>
</html>
