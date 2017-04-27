<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserMain.aspx.cs" Inherits="WebClient.UserMain" %>

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
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Font-Underline="True" style="z-index: 1; left: 242px; top: 124px; position: absolute; height: 29px; width: 170px; font-size: 150%; background-color: #50ffd7" Text="RizerBox" class="label label-primary"></asp:Label>
        <asp:GridView class="table table-bordered table-hover" ID="gvDelete" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 239px; top: 192px; position: absolute; height: 175px; width: 637px; right: 414px">
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
        <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click" style="z-index: 1; left: 1082px; top: 298px; position: absolute; width: 174px" Text="Upload" class="btn btn-success"/>
        </p>
        <asp:Button ID="btnDeleteSelected" runat="server" style="z-index: 1; left: 1082px; top: 428px; position: absolute; width: 174px" Text="Delete Selected File(s)" class="btn btn-success" OnClick="btnDeleteSelected_Click"/>
        <asp:Button ID="btnUploadUpdatedFile" runat="server" style="z-index: 1; left: 1082px; top: 617px; position: absolute; width: 174px" Text="Upload Updated File" class="btn btn-success" OnClick="btnUploadUpdatedFile_Click"/>
        <asp:Label ID="btnUpdateAFile" runat="server" Font-Bold="True" Font-Underline="True" style="z-index: 1; left: 997px; top: 486px; position: absolute; width: 301px; font-size: 150%; background-color: coral" Text="Update a File" class="label label-primary"></asp:Label>
        <asp:Label ID="lblUpdateFirstSelected" runat="server" Font-Size="Small" ForeColor="Red" style="z-index: 1; left: 1089px; top: 546px; position: absolute" Text="Update First Selected File"></asp:Label>
        <p>
        <asp:FileUpload ID="FileUploadModify" runat="server" style="z-index: 1; left: 1057px; top: 575px; position: absolute" />
        <asp:Label ID="lblDeleteAFile" runat="server" Font-Underline="True" style="z-index: 1; left: 997px; top: 354px; position: absolute; bottom: 311px; width: 74px; width: 301px; font-size: 150%; background-color: coral; height: 35px" Text="Delete a File" Font-Bold="True" class="label label-primary"></asp:Label>
        <asp:Label ID="lblUploadAFile" runat="server" Font-Underline="True" style="z-index: 1; left: 997px; top: 187px; position: absolute; width: 301px; font-size: 150%; background-color: coral" Text="Upload a File" Font-Bold="True" class="label label-primary"></asp:Label>
        <asp:FileUpload ID="FileUpload" runat="server" style="z-index: 1; left: 1057px; top: 253px; position: absolute; right: 260px;" />
        </p>
    </form>
</body>
</html>
