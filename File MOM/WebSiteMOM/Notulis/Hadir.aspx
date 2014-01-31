<%@ Page Title="" Language="VB" MasterPageFile="~/Master/Template.master" AutoEventWireup="false" CodeFile="Hadir.aspx.vb" Inherits="Notulis_Hadir" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" Runat="Server">
    <div id="hadir" style=" width:100%; height:700px">
        <asp:Label ID="Label2" runat="server" Text="Tanggal" Width="100px"></asp:Label>
        <asp:TextBox ID="DateTextBox" runat="server"></asp:TextBox>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" OnDayRender="Calendar1_dayrender"
        ShowTitle="true" DayNameFormat="FirstTwoLetters" SelectionMode="Day" FirstDayOfWeek="Monday"></asp:Calendar>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Daftar Hadir" Width="100px"></asp:Label>
        <asp:FileUpload ID="FileUploadHadir" runat="server" />   
        <br />         
        <asp:Button ID="SaveButton" runat="server" Text="Save" />
        <br />
        <br />
        <asp:GridView ID="GridViewHadir" runat="server" BackColor="White" 
            BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
            GridLines="Horizontal">
            <RowStyle BackColor="White" ForeColor="#333333" />
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <Columns>
            <asp:BoundField DataField="id" HeaderText="id" />
            <asp:BoundField DataField="filename" HeaderText="filename" />
            <%--<asp:TemplateField HeaderText="Download">
            <ItemTemplate>
                <asp:LinkButton ID="lnkDownload" runat="server" Text="Download" OnClick="lnkDownload_Click"></asp:LinkButton>
            </ItemTemplate>
           </asp:TemplateField>--%>
           <asp:TemplateField HeaderText="Add pekerja">
            <ItemTemplate>
                <asp:LinkButton ID="lnkAdd" runat="server" Text="Add pekerja" OnClick="lnkAdd_Click"></asp:LinkButton>
            </ItemTemplate>
           </asp:TemplateField>
           <asp:TemplateField HeaderText="Add peserta">
            <ItemTemplate>
                <asp:LinkButton ID="lnkTambah" runat="server" Text="Add peserta" OnClick="lnkTambah_Click"></asp:LinkButton>
            </ItemTemplate>
           </asp:TemplateField>
                <asp:HyperLinkField DataNavigateUrlFields="filepath" HeaderText="View" 
                    Text="View File" />
           </Columns> 
        </asp:GridView>
        <asp:Label ID="Label3" runat="server" Text="Untuk melihat dan menyimpan file,silahkan buka file di tab baru" CssClass="color"></asp:Label>
        <br />
    </div>

</asp:Content>

