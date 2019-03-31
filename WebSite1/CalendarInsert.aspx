<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CalendarInsert.aspx.cs" Inherits="CalendarInsert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DropDownList ID="DropDownListDay" runat="server" Height="35px">
</asp:DropDownList>
<asp:DropDownList ID="DropDownListMonth" runat="server">
</asp:DropDownList>
<asp:DropDownList ID="DropDownListYear" runat="server">
</asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
<asp:TextBox ID="TitleInput" runat="server" Height="57px" TextMode="MultiLine" Width="229px"></asp:TextBox>
<br />
<asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" Width="117px" />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lableSuc" runat="server" ForeColor="Lime" Visible="False"></asp:Label>
    &nbsp;
</asp:Content>

