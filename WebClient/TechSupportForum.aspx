<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TechSupportForum.aspx.cs" Inherits="WebClient.TechSupportForum" %>

<%@ Register Src="Forum.ascx" TagName="QuestionAnswerEntry" TagPrefix="uc1" %>

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
        <div class="container">
            <div class="row">
                <div class="col-md-4 col-md-offset-4">
                    <uc1:QuestionAnswerEntry ID="forumControl" runat="server" Visible="True" />
                </div>
            </div>
            <br />
            <br />
            <br />
            <br />

            <div class="row">
                <div class="col-md-4 col-md-offset-4">
                    <asp:Button ID="btnSubmitQuestion" runat="server" Style="width: 160px; background: #0080af" Text="Submit Question" class="btn btn-success" OnClick="btnSubmitQuestion_Click" />
                </div>
            </div>
            <br />
            <br />
            <div class="row">
                <div class="col-md-4 col-md-offset-3">
                    <asp:GridView class="table table-bordered table-hover" ID="gvForum" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField HeaderText="Question" DataField="Question" />
                            <asp:BoundField HeaderText="Answer" DataField="Answer" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
        <div class="row">
                <div class="col-md-4 col-md-offset-4">
                    <asp:Button ID="btnReturn" runat="server" Style="width: 160px; background: #0080af" Text="Submit Question" class="btn btn-success" OnClick="btnReturn_Click" />
                </div>
            </div>
    </form>
</body>
</html>
