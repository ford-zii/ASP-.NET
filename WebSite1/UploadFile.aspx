<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UploadFile.aspx.cs" Inherits="UploadFile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:FileUpload ID="FileUpload1" runat="server" Height="40px" />
    <asp:Button ID="btnUpload" runat="server" Height="36px" OnClick="btnUpload_Click" Text="Upload" />
&nbsp;
    <asp:Label ID="lableSuc" runat="server" ForeColor="Lime" Visible="False"></asp:Label>
&nbsp;
</asp:Content>

