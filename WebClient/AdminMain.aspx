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
        <asp:Button ID="btnTechSupport" runat="server" style="z-index: 1; left: 73px; top: 67px; position: absolute" Text="Tech Support" class="btn btn-default" OnClick="btnTechSupport_Click"/>
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
        <asp:Button ID="btnReturnToLogin0" runat="server" OnClick="btnReturnToLogin_Click" style="z-index: 1; left: 72px; top: 20px; position: absolute" Text="Return to Login" class="btn btn-default"/>
        </p>
        <p>
        <asp:Label ID="lblDeleteAccount" runat="server" Font-Underline="True" style="z-index: 1; left: 586px; top: 213px; position: absolute; width: 290px; font-size: 150%; background-color: coral; height: 30px;" Font-Bold="True" class="label label-primary" Font-Size="Medium">Delete an Account</asp:Label>
        <asp:Label ID="lblUpdateAccount" runat="server" Font-Underline="True" style="z-index: 1; left: 588px; top: 353px; position: absolute; width: 290px; font-size: 150%; background-color: coral; height: 30px;" Font-Bold="True" class="label label-primary" Font-Size="Medium">Update Account</asp:Label>
        <asp:Label ID="lblDeactivateAccount1" runat="server" Font-Underline="True" style="z-index: 1; left: 587px; top: 611px; position: absolute; width: 290px; font-size: 150%; background-color: coral; height: 30px;" Font-Bold="True" class="label label-primary" Font-Size="Medium">Deactivate Account</asp:Label>
        <asp:Label ID="lblViewUsersFiles" runat="server" Font-Underline="True" style="z-index: 1; left: 585px; top: 757px; position: absolute; width: 290px; font-size: 150%; background-color: coral; height: 30px;" Font-Bold="True" class="label label-primary" Font-Size="Medium">View User&#39;s Files</asp:Label>
            <asp:Button ID="btnDeleteSelectedAccounts" runat="server" style="z-index: 1; left: 647px; top: 284px; position: absolute; width: 191px" Text="Delete Selected Account(s)" OnClick="btnDeleteSelectedAccounts_Click" class="btn btn-default"/>
        </p>
        <asp:Label ID="lblSetNewValuesForSelectedAccount" runat="server" Font-Underline="True" style="z-index: 1; left: 638px; top: 413px; position: absolute" Text="Set New Values for Selected Account"></asp:Label>
        <p>
        <asp:TextBox ID="txtStorageCapacity" runat="server" style="z-index: 1; left: 734px; top: 455px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword2" runat="server" style="z-index: 1; left: 737px; top: 506px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStorageCapacity" runat="server" style="z-index: 1; left: 609px; top: 455px; position: absolute" Text="Storage Capacity:"></asp:Label>
        <asp:Label ID="lblPassword2" runat="server" style="z-index: 1; left: 656px; top: 507px; position: absolute" Text="Password:"></asp:Label>
            <asp:Button ID="btnDeactivateAccounts" runat="server"  style="z-index: 1; left: 636px; top: 689px; position: absolute; width: 223px" Text="Deactivate Selected Account(s)" class="btn btn-default" OnClick="btnDeactivateAccounts_Click"/>
            <asp:Button ID="btnUpdateAccount0" runat="server"  style="z-index: 1; left: 673px; top: 553px; position: absolute; width: 158px" Text="Update Account" OnClick="btnUpdateAccount_Click" class="btn btn-default"/>
            <asp:Button ID="btnViewSelectedUsersFiles" runat="server"  style="z-index: 1; left: 643px; top: 825px; position: absolute; width: 223px" Text="View Selected User's Files" class="btn btn-default" OnClick="btnViewSelectedUsersFiles_Click"/>
        <asp:GridView class="table table-bordered table-hover" ID="gvDelete" runat="server" AutoGenerateColumns="False" Style="z-index: 1; left: 944px; top: 613px; position: absolute; height: 175px; width: 642px; right: 4px">
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
    </form>
</body>
</html>

