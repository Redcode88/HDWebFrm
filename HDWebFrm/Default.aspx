<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HDWebFrm._Default" %>

<%@ Register Assembly="DevExpress.Web.v21.2, Version=21.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <br />
    <dx:aspxgridview runat="server" ID="Grd" Width="944px">
        

        <SettingsPager AlwaysShowPager="True">
        </SettingsPager>
        <Settings ShowGroupPanel="True" ShowFooter="True" />
        <SettingsBehavior AllowSelectByRowClick="True" />
<SettingsPopup>
<FilterControl AutoUpdatePosition="False"></FilterControl>
</SettingsPopup>
 <SettingsSearchPanel Visible="True" />
 
        <EditFormLayoutProperties>
            <Items>
                <dx:GridViewColumnLayoutItem Caption="Replay" ColSpan="1">
                </dx:GridViewColumnLayoutItem>
            </Items>
        </EditFormLayoutProperties>
       
        

        

       
        

    </dx:aspxgridview>


</asp:Content>
