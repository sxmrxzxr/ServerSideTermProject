<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebClient.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblLogin" runat="server" Font-Size="X-Large" Font-Underline="True" style="z-index: 1; left: 486px; top: 64px; position: absolute" Text="Login"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 451px; top: 111px; position: absolute" placeholder="Email:"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 451px; top: 154px; position: absolute" placeholder="Password:" TextMode="Password"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkRememberMe" runat="server" Font-Size="Small" style="z-index: 1; left: 451px; top: 186px; position: absolute" Text="Remember Me?" TextAlign="Left" />
        </p>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 470px; top: 213px; position: absolute; width: 93px" Text="Login" OnClick="btnLogin_Click"/>
        <asp:Button ID="btnRegister" runat="server" style="z-index: 1; left: 470px; top: 257px; position: absolute; width: 93px;" Text="Register" OnClick="btnRegister_Click" />
        <asp:Label ID="lblRequiredField" runat="server" ForeColor="Red" style="z-index: 1; left: 612px; top: 112px; position: absolute" Text="Required Field" Visible="False"></asp:Label>
        <asp:Label ID="lblRequiredField2" runat="server" ForeColor="Red" style="z-index: 1; left: 612px; top: 154px; position: absolute" Text="Required Field" Visible="False"></asp:Label>
        <asp:Label ID="lblLoginFailed" runat="server" ForeColor="Red" style="z-index: 1; left: 586px; top: 216px; position: absolute" Text="Login Failed" Visible="False"></asp:Label>
    </form>
</body>
</html>
