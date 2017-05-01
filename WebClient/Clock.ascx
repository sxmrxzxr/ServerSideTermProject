<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Clock.ascx.cs" Inherits="WebClient.Clock" %>
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <asp:Timer ID="Timer1" runat="server" Interval="1000"></asp:Timer>

        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

    </ContentTemplate>
</asp:UpdatePanel>
