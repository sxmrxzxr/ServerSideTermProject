<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRestore.aspx.cs" Inherits="WebClient.UserRestore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblHeader" Text="User's Trash" runat="server"></asp:Label> <br />
        <asp:GridView ID="grvUserTrash" runat="server" AutoGenerateColumns="false">
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
                <asp:BoundField DataField="FileDataID" HeaderText="File Data ID" SortExpression="FileDataID" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="btnRestore" runat="server" Text="Restore Selected" OnClick="btnRestore_Click"/>
        <a href="UserMain.aspx">Return to previous</a>
    </form>
</body>
</html>
