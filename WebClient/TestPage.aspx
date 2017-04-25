<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPage.aspx.cs" Inherits="WebClient.Main" %>

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
        <asp:GridView ID="gvDelete" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 385px; top: 275px; position: absolute; height: 133px; width: 534px; ">
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
        <asp:Label ID="lblUserUpdateAccount" runat="server" Font-Bold="True" Font-Underline="True" style="z-index: 1; left: 180px; top: 607px; position: absolute" Text="User Update Account"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 105px; top: 650px; position: absolute" Text="First Name:"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 104px; top: 693px; position: absolute" Text="Last Name:"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 134px; top: 731px; position: absolute" Text="Email:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 105px; top: 774px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 193px; top: 650px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 193px; top: 693px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 193px; top: 731px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 193px; top: 776px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnUpdateAccount" runat="server" OnClick="btnUpdateAccount_Click" style="z-index: 1; left: 364px; top: 769px; position: absolute; height: 28px; width: 113px" Text="Update Account" />
        <asp:Label ID="lblAdminUpdate" runat="server" Font-Bold="True" Font-Underline="True" style="z-index: 1; left: 578px; top: 583px; position: absolute" Text="Admin Update/Delete Account"></asp:Label>
        <asp:GridView ID="gvAdminDelete" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 561px; top: 668px; position: absolute; height: 145px; width: 407px">
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
        <asp:TextBox ID="txtStorageCapacity" runat="server" style="z-index: 1; left: 1133px; top: 672px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword2" runat="server" style="z-index: 1; left: 1135px; top: 714px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStorageCapacity" runat="server" style="z-index: 1; left: 1001px; top: 675px; position: absolute" Text="Storage Capacity:"></asp:Label>
        <asp:Label ID="lblPassword2" runat="server" style="z-index: 1; left: 1049px; top: 715px; position: absolute" Text="Password:"></asp:Label>
        <asp:Label ID="lblSetNewValues" runat="server" Font-Underline="True" style="z-index: 1; left: 1034px; top: 637px; position: absolute" Text="Set new values for selected account"></asp:Label>
        <asp:Button ID="btnUpdate2" runat="server" OnClick="btnUpdate2_Click" style="z-index: 1; left: 1202px; top: 752px; position: absolute" Text="Update" />
        <asp:Button ID="btnDelete2" runat="server" OnClick="btnDelete2_Click" style="z-index: 1; left: 801px; top: 581px; position: absolute" Text="Delete" />
        <asp:Label ID="lblAdminDeleteDescription" runat="server" Font-Size="Small" ForeColor="Red" style="z-index: 1; left: 567px; top: 618px; position: absolute; width: 400px; height: 36px; margin-top: 6px" Text="Select one account. Then either delete or set new values for Storage Capacity and Password and then Update."></asp:Label>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Underline="True" style="z-index: 1; left: 110px; top: 866px; position: absolute" Text="Transactions For A Single User and a Time Period"></asp:Label>
        <asp:GridView ID="gvTransactions" runat="server" AutoGenerateColumns="False" style="z-index: 1; left: 97px; top: 938px; position: absolute; height: 133px; width: 435px">
            <Columns>
                <asp:BoundField DataField="TransactionDateTime" HeaderText="Transaction Date and Time" ReadOnly="True" SortExpression="TransactionDateTime" />
                <asp:BoundField DataField="UploadDownload" HeaderText="Upload/Download" ReadOnly="True" SortExpression="UploadDownload" />
                <asp:BoundField DataField="FileID" HeaderText="File ID" ReadOnly="True" SortExpression="FileID" />
                <asp:BoundField DataField="AccountID" HeaderText="Account ID" ReadOnly="True" SortExpression="AccountID" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="lblTransactionDescription" runat="server" ForeColor="Red" style="z-index: 1; left: 100px; top: 903px; position: absolute" Text="Time span and specific account are hard coded."></asp:Label>
    </form>
</body>
</html>
