<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminMain.aspx.cs" Inherits="WebClient.AdminMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css?parameter=1" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

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
        <asp:Label ID="lblWelcomeAdmin" runat="server" Font-Size="X-Large" Font-Underline="True" style="z-index: 1; left: 499px; top: 44px; position: absolute" Text="Welcome Admin!"></asp:Label>
        <asp:Button ID="btnTechSupport" runat="server" style="z-index: 1; left: 892px; top: 42px; position: absolute" Text="Tech Support" class="btn btn-default" OnClick="btnTechSupport_Click"/>
        <p>
            <asp:Button ID="btnRegisterNewAdmin" runat="server" OnClick="btnRegisterNewAdmin_Click" style="z-index: 1; left: 501px; top: 102px; position: absolute; width: 158px" Text="Register New Admin" class="btn btn-default" Visible="False"/>
        </p>
        <asp:GridView class="table table-bordered table-hover" ID="gvAdminDelete" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 100px; top: 227px; position: absolute; height: 145px; width: 407px">
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkSelect2" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Email" HeaderText="Email" ReadOnly="True" SortExpression="Email" />
                <asp:BoundField DataField="Passwd" HeaderText="Password" ReadOnly="True" SortExpression="Passwd" />
                <asp:BoundField DataField="Capacity" HeaderText="Storage Capacity" ReadOnly="True" SortExpression="Capacity" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="lblCloudUserAccounts" runat="server" Font-Bold="True" Font-Underline="True" style="z-index: 1; left: 100px; top: 192px; position: absolute" Text="Cloud User Accounts"></asp:Label>
        <p>
        <asp:Button ID="btnReturnToLogin0" runat="server" OnClick="btnReturnToLogin_Click" style="z-index: 1; left: 710px; top: 41px; position: absolute" Text="Return to Login" class="btn btn-default"/>
        </p>
        <asp:Button ID="btnSuperAdminDashboard" runat="server" style="z-index: 1; left: 709px; top: 103px; position: absolute" Text="Super Admin Dashboard" class="btn btn-default" Visible="False"/>
        <asp:Label ID="lblSetNewValuesForSelectedAccount" runat="server" Font-Underline="True" style="z-index: 1; left: 638px; top: 413px; position: absolute" Text="Set New Values for Selected Account"></asp:Label>
        <asp:Button ID="btnLogOut" runat="server" style="z-index: 1; left: 1057px; top: 41px; position: absolute" Text="Log Out" class="btn btn-default" OnClick="btnLogOut_Click"/>
        <p>
        <asp:TextBox ID="txtStorageCapacity" runat="server" style="z-index: 1; left: 721px; top: 442px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword2" runat="server" style="z-index: 1; left: 720px; top: 473px; position: absolute; right: 455px;"></asp:TextBox>
        <asp:Label ID="lblStorageCapacity" runat="server" style="z-index: 1; left: 601px; top: 441px; position: absolute" Text="Storage Capacity:"></asp:Label>
        <asp:Label ID="lblPassword2" runat="server" style="z-index: 1; left: 649px; top: 474px; position: absolute" Text="Password:"></asp:Label>
            <asp:Button ID="btnDeactivateAccounts" runat="server"  style="z-index: 1; left: 635px; top: 626px; position: absolute; width: 223px" Text="Deactivate Selected Account(s)" class="btn btn-default" OnClick="btnDeactivateAccounts_Click"/>
            <asp:Button ID="btnDeleteSelectedAccounts" runat="server"  style="z-index: 1; left: 645px; top: 325px; position: absolute; width: 215px; right: 461px;" Text="Delete Selected Account(s)" OnClick="btnDeleteSelectedAccounts_Click" class="btn btn-default"/>
            <asp:Button ID="btnViewSelectedUsersFiles" runat="server"  style="z-index: 1; left: 641px; top: 751px; position: absolute; width: 223px" Text="View Selected User's Files" class="btn btn-default" OnClick="btnViewSelectedUsersFiles_Click"/>
        <asp:GridView class="table table-bordered table-hover" ID="gvDelete" runat="server" AutoGenerateColumns="False" Style="z-index: 1; left: 937px; top: 547px; position: absolute; height: 175px; width: 642px; right: -276px">
            <Columns>
                <asp:BoundField HeaderText="FileID" DataField="FileID" />
                <asp:BoundField HeaderText="File Name" DataField="Name" />
                <asp:BoundField HeaderText="File Type" DataField="FileType" />
                <asp:BoundField HeaderText="Date Uploaded" DataField="DateUploaded" />
                <asp:BoundField HeaderText="Date Modified" DataField="DateModified" />
                <asp:BoundField HeaderText="File Size (in Bytes)" DataField="FileSize" />
                <asp:BoundField DataField="FileDataID" HeaderText="File Data ID" SortExpression="FileDataID" />
            </Columns>
        </asp:GridView>
        </p>
        <asp:Label ID="lblViewAccountFiles" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" style="z-index: 1; left: 662px; top: 710px; position: absolute" Text="View Account Files"></asp:Label>
        <p>
            <asp:Label ID="lblDeleteAnAccount" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" style="z-index: 1; left: 671px; top: 289px; position: absolute" Text="Delete An Account"></asp:Label>
            <asp:Label ID="lblDeactivateanAccount" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" style="z-index: 1; left: 646px; top: 584px; position: absolute" Text="Deactivate an Account"></asp:Label>
            <asp:Label ID="lblUpdateAnAccount0" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" style="z-index: 1; left: 661px; top: 376px; position: absolute" Text="Update An Account"></asp:Label>
            <asp:Button ID="btnUpdateAccount1" runat="server"  style="z-index: 1; left: 663px; top: 508px; position: absolute; width: 158px; right: 482px;" Text="Update Account" OnClick="btnUpdateAccount_Click" class="btn btn-default"/>
            </p>
    </form>
</body>
</html>

