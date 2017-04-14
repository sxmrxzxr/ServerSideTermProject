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
        <asp:FileUpload ID="FileUpload" runat="server" style="z-index: 1; left: 92px; top: 223px; position: absolute" />
        <asp:Label ID="lblUploadAFile" runat="server" Font-Underline="True" style="z-index: 1; left: 131px; top: 140px; position: absolute" Text="Upload a File"></asp:Label>
        <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" style="z-index: 1; left: 227px; top: 262px; position: absolute; width: 87px" Text="Upload" />
        <asp:Label ID="lblEnterVerification" runat="server" style="z-index: 1; left: 36px; top: 181px; position: absolute" Text="Enter Verification Token:"></asp:Label>
        <asp:TextBox ID="txtVerificationToken" runat="server" style="z-index: 1; left: 196px; top: 184px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDeleteAFile" runat="server" Font-Underline="True" style="z-index: 1; left: 497px; top: 131px; position: absolute" Text="Delete a File"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 485px; top: 179px; position: absolute; height: 133px; width: 187px; right: 552px">
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
