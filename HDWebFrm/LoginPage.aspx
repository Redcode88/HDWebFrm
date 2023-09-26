<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master"  CodeBehind="LoginPage.aspx.cs" Inherits="HDWebFrm.LoginPage" %>

 <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div style="margin-top:40px;">
        <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate"></asp:Login>
        </div>
</asp:Content>
