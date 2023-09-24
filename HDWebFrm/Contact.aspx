<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="HDWebFrm.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <br />
    <div class="row">
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
            <asp:TextBox ID="Txt_UserName" runat="server"></asp:TextBox>
        </div>
         <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="From Department"></asp:Label>
             <asp:DropDownList ID="Combo_FromDept" runat="server" Height="35px" Width="293px"></asp:DropDownList>
        </div>
         <div class="form-group">
             <asp:Label ID="Label3" runat="server" Text="To Department"></asp:Label>
             <asp:DropDownList ID="Combo_ToDept" runat="server" Height="35px" Width="305px"></asp:DropDownList>
        </div>
        <div class="form-group">
             <asp:Label ID="Label4" runat="server" Text="TicktPeriorty"></asp:Label>
              <asp:DropDownList ID="Combo_St" runat="server" Height="35px"></asp:DropDownList>
        </div>
        <div class="form-group">
             <asp:Label ID="Label5" runat="server" Text="TicketDescription"></asp:Label>
            <asp:TextBox ID="Txt_Des" runat="server" Height="78px" Width="280px"></asp:TextBox>
        </div>
        <div class="form-group">
             <asp:Label ID="Label6" runat="server" Text="Tiket Code"></asp:Label>
            <asp:TextBox ID="TxtGuid" runat="server" Width="315px"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="LbAttach" runat="server" Text="Add Files"></asp:Label>
            <asp:FileUpload ID="fileUpload1" runat="server" AllowMultiple="True" />
        </div>
        <div class="form-group">
            <asp:Button ID="Btn_Clear" runat="server" Text="Clear" OnClick="Btn_Clear_Click" />
             <asp:Button ID="Btn_Save" runat="server" Text="Save" OnClick="Btn_Save_Click" />
        </div>
    </div>
</asp:Content>
