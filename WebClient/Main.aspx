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
        <asp:Label ID="lblWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 636px; top: 43px; position: absolute" Text="Welcome!" Font-Underline="True"></asp:Label>
                <asp:Label ID="lblLoginValue" runat="server" ForeColor="Red"></asp:Label>
        <asp:FileUpload ID="FileUpload" runat="server" style="z-index: 1; left: 130px; top: 369px; position: absolute" />
        <asp:Label ID="lblUploadAFile" runat="server" Font-Underline="True" style="z-index: 1; left: 184px; top: 325px; position: absolute" Text="Upload a File" Font-Bold="True"></asp:Label>
        <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" style="z-index: 1; left: 261px; top: 417px; position: absolute; width: 87px" Text="Upload" />
        <asp:Label ID="lblEnterAVerificationTokenTo" runat="server" Font-Underline="True" style="z-index: 1; left: 548px; top: 105px; position: absolute" Text="Enter a Verification Token to Complete an Action"></asp:Label>
        <asp:Label ID="lblVerification" runat="server" style="z-index: 1; left: 549px; top: 171px; position: absolute" Text="Verification Token:"></asp:Label>
        <asp:TextBox ID="txtVerificationToken" runat="server" style="z-index: 1; left: 678px; top: 171px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDeleteAFile" runat="server" Font-Underline="True" style="z-index: 1; left: 667px; top: 326px; position: absolute" Text="Delete a File" Font-Bold="True"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 627px; top: 380px; position: absolute; height: 133px; width: 187px; right: 516px">
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Label ID="lblNowUploadDeleteUpdate" runat="server" Font-Underline="True" style="z-index: 1; left: 579px; top: 243px; position: absolute" Text="Now Upload, Delete, or Update a file"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 759px; top: 542px; position: absolute" Text="Delete" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 997px; top: 327px; position: absolute" Text="Modify"></asp:Label>
    </form>
</body>
</html>
