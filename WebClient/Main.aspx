<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebClient.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 435px; top: 48px; position: absolute" Text="Welcome!"></asp:Label>
                <asp:Label ID="lblLoginValue" runat="server" ForeColor="Red"></asp:Label>
        <asp:FileUpload ID="FileUpload" runat="server" style="z-index: 1; left: 97px; top: 157px; position: absolute" />
        <asp:Label ID="lblUploadAFile" runat="server" Font-Underline="True" style="z-index: 1; left: 123px; top: 114px; position: absolute" Text="Upload a File"></asp:Label>
        <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" style="z-index: 1; left: 226px; top: 195px; position: absolute; width: 87px" Text="Upload" />
    </form>
</body>
</html>
