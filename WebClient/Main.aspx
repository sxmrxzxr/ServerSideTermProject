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
        <asp:Label ID="lblWelcome" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 537px; top: 38px; position: absolute" Text="Welcome to the Test Page!" Font-Underline="True"></asp:Label>
                <asp:Label ID="lblLoginValue" runat="server" ForeColor="Red"></asp:Label>
        <asp:FileUpload ID="FileUpload" runat="server" style="z-index: 1; left: 143px; top: 241px; position: absolute" />
        <asp:Label ID="lblUploadAFile" runat="server" Font-Underline="True" style="z-index: 1; left: 204px; top: 193px; position: absolute" Text="Upload a File" Font-Bold="True"></asp:Label>
        <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" style="z-index: 1; left: 271px; top: 288px; position: absolute; width: 87px" Text="Upload" />
        <asp:Label ID="lblDeleteAFile" runat="server" Font-Underline="True" style="z-index: 1; left: 475px; top: 198px; position: absolute" Text="Delete a File" Font-Bold="True"></asp:Label>
        <asp:GridView ID="gvDelete" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 385px; top: 275px; position: absolute; height: 133px; width: 534px; right: 373px">
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="FileID" DataField="FileID" />
                <asp:BoundField HeaderText="File Name" DataField="Name" />
                <asp:BoundField HeaderText="File Type" DataField="FileType" />
                <asp:BoundField HeaderText="Date Uploaded" DataField="DateUploaded" />
                <asp:BoundField HeaderText="Date Modified" DataField="DateModified" />
                <asp:BoundField HeaderText="File Size (in Bytes)" DataField="FileSize" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 587px; top: 198px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="lblUpdate" runat="server" style="z-index: 1; left: 1109px; top: 199px; position: absolute" Text="Update a File" Font-Bold="True" Font-Underline="True"></asp:Label>
        <p>
            <asp:Label ID="lblUploadASimple" runat="server" style="z-index: 1; left: 948px; top: 233px; position: absolute" Text="Upload a simple text file to modify one of the text files already stored"></asp:Label>
            <asp:Button ID="btnUpdate" runat="server" style="z-index: 1; left: 1169px; top: 317px; position: absolute; width: 85px" Text="Update" OnClick="btnUpdate_Click" />
        </p>
        <asp:FileUpload ID="FileUploadModify" runat="server" style="z-index: 1; left: 1036px; top: 275px; position: absolute" />
        <asp:Label ID="lblDeleteDescription" runat="server" Font-Size="Small" ForeColor="Red" style="z-index: 1; left: 394px; top: 239px; position: absolute; width: 501px" Text="File Information for current User. Select one to delete. Don't delete FileID 33. That is for testing the Update a File Method."></asp:Label>
    </form>
</body>
</html>
