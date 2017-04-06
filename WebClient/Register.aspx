<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebClient.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblRegisterForANewAccount" runat="server" Font-Size="X-Large" Font-Underline="True" style="z-index: 1; left: 380px; top: 46px; position: absolute" Text="Register For A New Account"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 306px; top: 106px; position: absolute" Text="First Name:"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 307px; top: 144px; position: absolute" Text="Last Name:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 314px; top: 215px; position: absolute" Text="Password:" width="63"></asp:Label>
        <p>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 341px; top: 180px; position: absolute" Text="Email:"></asp:Label>
        </p>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 388px; top: 108px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 388px; top: 144px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 388px; top: 180px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 388px; top: 213px; position: absolute"></asp:TextBox>
            <asp:CheckBox ID="chkRememberMe" runat="server" Font-Size="Medium" style="z-index: 1; left: 315px; top: 256px; position: absolute" Text="Remember Me?" TextAlign="Left" />
        </p>
        <asp:Button ID="btnRegister" runat="server" style="z-index: 1; left: 319px; top: 297px; position: absolute" Text="Register" />
    </form>
</body>
</html>
