<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CreateRoll.aspx.cs" Inherits="HDWebFrm.CreateRoll" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <br />
        <asp:Table runat="server" Width="494px" cellpadding="3" border="0">
        <asp:TableRow>
            <asp:TableCell>Add RollName</asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="Txt_Roll" runat="server" Width="250"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
           
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" ID="btn_cr"  Text="Create roll" OnClick="btn_cr_Click"/>
            </asp:TableCell>
        </asp:TableRow> 
        <asp:TableFooterRow>
            <asp:TableCell>
                <asp:Label runat="server" ID="LblResult"></asp:Label>
            </asp:TableCell>
        </asp:TableFooterRow>
      </asp:Table>
    
</asp:Content>