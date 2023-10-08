<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HDWebFrm._Default" %>

<%@ Register Assembly="DevExpress.Web.v21.2, Version=21.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <br />
      <dx:ASPxGridView ID="Grd"  runat="server" AutoGenerateColumns="False"
                                    Theme="Metropolis" Width="100%"
                                    KeyFieldName="Id" Font-Size="X-Small" EnableTheming="True" AutoPostBack="True">

 

<Settings ShowFilterRow="True" ShowGroupPanel="True" ShowHeaderFilterButton="True" />
 <SettingsCustomizationDialog Enabled="true" />

 

                                    <Settings ShowGroupPanel="True" ShowFooter="True" ShowFilterRow="True" />
<SettingsDataSecurity AllowInsert="False" />
<SettingsPopup>
<FilterControl AutoUpdatePosition="False"></FilterControl>
</SettingsPopup>
                                    <SettingsSearchPanel Visible="True" />
<SettingsExport EnableClientSideExportAPI="true" ExcelExportMode="WYSIWYG" />

 

 <Columns>
<dx:GridViewCommandColumn ShowClearFilterButton="True" ShowDeleteButton="True" ShowEditButton="True" VisibleIndex="0">
</dx:GridViewCommandColumn>
<dx:GridViewDataTextColumn FieldName="Id" VisibleIndex="1" Caption="ID" ReadOnly="true" Visible="false"></dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Discreption" VisibleIndex="2" Caption="Discreption"></dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="FrmDepartment" VisibleIndex="3" Caption="From Department"></dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="CreatedDate" VisibleIndex="4" Caption="Created Date" ReadOnly="true"></dx:GridViewDataTextColumn>
<dx:GridViewDataTextColumn FieldName="Per" VisibleIndex="5" Caption="Periorty" ReadOnly="true"></dx:GridViewDataTextColumn>
     <dx:GridViewDataTextColumn Caption="State" VisibleIndex="6">
     </dx:GridViewDataTextColumn>
</Columns>
<Toolbars>
<dx:GridViewToolbar>
<SettingsAdaptivity Enabled="true" EnableCollapseRootItemsToIcons="true" />
<Items>
<dx:GridViewToolbarItem Command="ExportToPdf" />
<dx:GridViewToolbarItem Command="ExportToXls" />
<%--  <dx:GridViewToolbarItem Command="ExportToXlsx" />--%>
<dx:GridViewToolbarItem Command="ExportToDocx" />
<%--   <dx:GridViewToolbarItem Command="ExportToRtf" />--%>
<dx:GridViewToolbarItem Command="ExportToCsv" />
</Items>
</dx:GridViewToolbar>
<dx:GridViewToolbar Position="Top" ItemAlign="Right">
<Items>
<dx:GridViewToolbarItem Command="ShowCustomizationDialog" />
</Items>
</dx:GridViewToolbar>
</Toolbars>
<TotalSummary>
<dx:ASPxSummaryItem FieldName="CompanyName" SummaryType="Count" />
<dx:ASPxSummaryItem FieldName="ProductAmount" SummaryType="Sum" />
</TotalSummary>
<GroupSummary>
<dx:ASPxSummaryItem FieldName="ProductAmount" SummaryType="Sum" />
<dx:ASPxSummaryItem FieldName="CompanyName" SummaryType="Count" />
</GroupSummary>
</dx:ASPxGridView>



    
</asp:Content>
