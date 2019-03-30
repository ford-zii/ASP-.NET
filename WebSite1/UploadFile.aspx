<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UploadFile.aspx.cs" Inherits="UploadFile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:FileUpload ID="FileUpload1" runat="server" Height="40px" />
    <asp:Button ID="btnUpload" runat="server" Height="36px" OnClick="btnUpload_Click" Text="Upload" />
&nbsp;
    <asp:Label ID="lableSuc" runat="server" ForeColor="Lime" Visible="False"></asp:Label>
    <br />
    <asp:DataList ID="DataList1" runat="server" DataKeyField="ID" DataSourceID="SqlDataSource1" Width="184px">
        <ItemTemplate>
            <br />
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
            <br />
            <asp:Image ID="Image1" runat="server" Height="300px" ImageUrl='<%# Eval("PicturePath") %>' />
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UPPart2ConnectionString %>" SelectCommand="SELECT * FROM [TreeView]"></asp:SqlDataSource>
&nbsp;
</asp:Content>

