<%@ Page Title="" Language="VB" MasterPageFile="~/Master/Template2.master" AutoEventWireup="false" CodeFile="ViewHadir.aspx.vb" Inherits="PimpinanRapat_ViewHadir" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" Runat="Server">
    <div style=" width:100%; height:700px" id="viewhadir">
    <asp:Label ID="Label1" runat="server" Text="No rapat"></asp:Label>
    <asp:TextBox ID="noTextBox" runat="server"></asp:TextBox>
    <asp:Button ID="ViewButton" runat="server" Text="View" />
    <br />
    <asp:GridView ID="FileGridView" runat="server" BackColor="White" 
        BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
        GridLines="Horizontal">
        <RowStyle BackColor="White" ForeColor="#333333" />
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="filepath" HeaderText="View" 
                    Text="View File" />
        </Columns>
    </asp:GridView>
    <asp:Label ID="Label4" runat="server" Text="Untuk melihat dan menyimpan file,silahkan buka file di tab baru" CssClass="color"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="No rapat"></asp:Label>
    <asp:TextBox ID="nomorTextBox" runat="server"></asp:TextBox>
    <asp:Button ID="PekButton" runat="server" Text="View" />
    <asp:GridView ID="PekGridView" runat="server" BackColor="White" 
        BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
        GridLines="Horizontal">
        <RowStyle BackColor="White" ForeColor="#333333" />
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    <br />
    <asp:Label ID="Label3" runat="server" Text="No rapat"></asp:Label>
    <asp:TextBox ID="numberTextBox" runat="server"></asp:TextBox>
    <asp:Button ID="NonpekButton" runat="server" Text="View" />
    <asp:GridView ID="NonPekGridView" runat="server" BackColor="White" 
        BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
        GridLines="Horizontal">
        <RowStyle BackColor="White" ForeColor="#333333" />
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    </div>
</asp:Content>

