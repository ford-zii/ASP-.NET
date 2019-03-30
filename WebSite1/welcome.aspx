<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="welcome.aspx.cs" Inherits="welcome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TextBox ID="Input1" runat="server"></asp:TextBox>
    +<asp:TextBox ID="Input2" runat="server"></asp:TextBox>
    =<asp:Label ID="SUMresult" runat="server"></asp:Label>
    <asp:Button ID="SUM" runat="server" OnClick="SUM_Click" Text="บวก" />
    <br />
    <asp:TextBox ID="Input3" runat="server"></asp:TextBox>
    +<asp:TextBox ID="Input4" runat="server"></asp:TextBox>
    +<asp:TextBox ID="Input5" runat="server"></asp:TextBox>
    =<asp:Label ID="SUMresult1" runat="server"></asp:Label>
    <asp:Button ID="SUM3" runat="server" OnClick="SUM_Click2" Text="บวก" />
    <br />
</asp:Content>

