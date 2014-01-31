<%@ Page Title="" Language="VB" MasterPageFile="~/Master/Template.master" AutoEventWireup="false" CodeFile="TindakLanjut.aspx.vb" Inherits="Notulis_TindakLanjut" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" Runat="Server">
    <div id="divtindak" runat="server" style=" width:100%">
    <asp:GridView ID="GridViewTindak" runat="server" BackColor="White" 
            BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
            GridLines="Horizontal">
        <RowStyle BackColor="White" ForeColor="#333333" />
        <Columns>
            <asp:TemplateField HeaderText="no rapat">
                <ItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("id") %>' Width="65px"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PIC">
                <ItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("PIC") %>'></asp:TextBox>
                </ItemTemplate>
             </asp:TemplateField>
             <asp:TemplateField HeaderText="tindak_lanjut">
                <ItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Text='<%# Bind("tindak_lanjut") %>'></asp:TextBox>
                    </ItemTemplate>
             </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
    &nbsp
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Clear Grid" />
    <br />
    <asp:Label id="lblStatus" runat="server" EnableViewState="False" Font-Bold="True" ForeColor="Red"></asp:Label> 
    <br />
    </div>
    <div id="viewtindak" runat="server" runat="server" style=" width:100%">
    <asp:Label ID="idLabel" runat="server" Text="no rapat" Width="50px"></asp:Label>
    <asp:TextBox ID="idTextBox" runat="server" Width="50px"></asp:TextBox>
    &nbsp
    <asp:Button ID="ViewButton" runat="server" OnClick="ViewButton_Click" Text="View" /> 
    <br />
    <asp:GridView ID="GridViewPIC" runat="server" BackColor="White" 
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

