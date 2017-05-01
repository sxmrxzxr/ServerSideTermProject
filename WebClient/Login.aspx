<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebClient.Login" %>

<%@ Register Src="~/Clock.ascx" TagPrefix="uc1" TagName="Clock" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

<!-- Optional theme -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

<!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <uc1:Clock runat="server" id="Clock" />
        <asp:Label ID="lblLogin" runat="server" Font-Size="X-Large" Font-Underline="True" style="z-index: 1; left: 507px; top: 64px; position: absolute" Text="Login"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 451px; top: 111px; position: absolute; width: 175px" placeholder="Email:" class="form-control"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 451px; top: 154px; position: absolute; width: 175px" placeholder="Password:" TextMode="Password" class="form-control"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkRememberMe" runat="server" Font-Size="Small" style="z-index: 1; left: 457px; top: 201px; position: absolute" Text="Remember Me?" TextAlign="Left" />
        </p>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 455px; top: 229px; position: absolute; width: 151px; background: coral; color: black" Text="Login" OnClick="btnLogin_Click" class="btn btn-default"/>
        <asp:Button ID="btnRegister" runat="server" style="z-index: 1; left: 455px; top: 270px; position: absolute; width: 151px; background: #0080af; color: black;" Text="Register" OnClick="btnRegister_Click" class="btn btn-default"/>
        <asp:Label ID="lblRequiredField" runat="server" ForeColor="Red" style="z-index: 1; left: 661px; top: 118px; position: absolute" Text="Required Field" Visible="False"></asp:Label>
        <asp:Label ID="lblRequiredField2" runat="server" ForeColor="Red" style="z-index: 1; left: 657px; top: 161px; position: absolute" Text="Required Field" Visible="False"></asp:Label>
        <asp:Label ID="lblLoginFailed" runat="server" ForeColor="Red" style="z-index: 1; left: 643px; top: 236px; position: absolute" Text="Login Failed" Visible="False"></asp:Label>
    </form>
</body>
</html>
