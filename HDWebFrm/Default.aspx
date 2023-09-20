<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HDWebFrm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-6">
           <br />
            <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Select Department"></asp:Label>
            <asp:DropDownList ID="Combo_FromDeptSe" runat="server" Height="30px" Width="304px" AutoPostBack="True" OnSelectedIndexChanged="Combo_FromDeptSe_SelectedIndexChanged"></asp:DropDownList>
        </div>
        </div>
    </div>
  <hr />
    <asp:GridView ID="Grd" runat="server">
    </asp:GridView>
</asp:Content>
