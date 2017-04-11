<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebClient.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>

    </style>
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
            <asp:CheckBox ID="chkRememberMe" runat="server" Font-Size="Medium" style="z-index: 1; left: 310px; top: 289px; position: absolute" Text="Remember Me?" TextAlign="Left" />
            <asp:Button ID="btnReturnToLogin" runat="server" OnClick="btnReturnToLogin_Click" style="z-index: 1; left: 435px; top: 130px; position: absolute; width: 130px" Text="Return to Login" Visible="False" />
            <asp:Button ID="btnReturnToLogin2" runat="server" OnClick="btnReturnToLogin2_Click" style="z-index: 1; left: 220px; top: 46px; position: absolute; margin-top: 3px" Text="Return to Login" />
        </p>
        <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" style="z-index: 1; left: 310px; top: 335px; position: absolute" Text="Register" />
        <asp:Label ID="lblRegistrationSuccessful" runat="server" style="z-index: 1; left: 432px; top: 97px; position: absolute" Text="Registration Successful!" Visible="False"></asp:Label>
        <p>
            <asp:Label ID="lblRequiredField" runat="server" ForeColor="Red" style="z-index: 1; left: 548px; top: 109px; position: absolute" Text="Required Field" Visible="False"></asp:Label>
            <asp:Label ID="lblRequiredField2" runat="server" ForeColor="Red" style="z-index: 1; left: 548px; top: 146px; position: absolute; bottom: 380px" Text="Required Field" Visible="False"></asp:Label>
            <asp:Label ID="lblRequiredField3" runat="server" ForeColor="Red" style="z-index: 1; left: 548px; top: 182px; position: absolute" Text="Required Field" Visible="False"></asp:Label>
            <asp:Label ID="lblRequiredField4" runat="server" ForeColor="Red" style="z-index: 1; left: 548px; top: 215px; position: absolute" Text="Required Field" Visible="False"></asp:Label>
        </p>
        <!-- <asp:CheckBox ID="chkRegisterAsAnAdmin" runat="server" style="z-index: 1; left: 310px; top: 256px; position: absolute" Text="Register As an Admin?" TextAlign="Left" /> -->
    </form>
</body>
</html>
