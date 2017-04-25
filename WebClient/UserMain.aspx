<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserMain.aspx.cs" Inherits="WebClient.UserMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Font-Underline="True" style="z-index: 1; left: 242px; top: 124px; position: absolute; height: 29px" Text="RizerBox"></asp:Label>
        <asp:GridView ID="gvDelete" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 239px; top: 192px; position: absolute; height: 175px; width: 534px; right: 557px">
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
        <p>
        <asp:Label ID="lblUploadAFile" runat="server" Font-Underline="True" style="z-index: 1; left: 994px; top: 146px; position: absolute" Text="Upload a File" Font-Bold="True"></asp:Label>
        <asp:FileUpload ID="FileUpload" runat="server" style="z-index: 1; left: 937px; top: 190px; position: absolute" />
        <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" style="z-index: 1; left: 1069px; top: 233px; position: absolute; width: 87px" Text="Upload" />
        </p>
    </form>
</body>
</html>
