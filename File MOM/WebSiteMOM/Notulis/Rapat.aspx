<%@ Page Title="" Language="VB" MasterPageFile="~/Master/Template.master" AutoEventWireup="false" CodeFile="Rapat.aspx.vb" Inherits="Notulis_Rapat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" Runat="Server">
    <div id="rapat" style=" width:100%; height:700px">
        <asp:GridView ID="GridViewRapat" runat="server" AutoGenerateColumns="False" OnPageIndexChanging="gvrapat_PageIndexChanging" 
                        OnRowCancelingEdit="gvrapat_RowCancelingEdit" OnRowDatabound="gvrapat_RowDataBound" 
                        OnRowDeleting="gvrapat_RowDeleting" OnRowEditing="gvrapat_RowEditing" 
                        OnRowUpdating="gvrapat_RowUpdating" OnSorting="gvrapat_Sorting" 
                        BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                        CellPadding="4" GridLines="Horizontal">
                        <RowStyle BackColor="White" ForeColor="#333333" />
                            <Columns>
                                <asp:CommandField ShowEditButton="True" />
                                <asp:CommandField ShowDeleteButton="True" />
                                <asp:BoundField DataField="no_rapat" HeaderText="no_rapat" ReadOnly="True" SortExpression="no_rapat" />
                            <asp:TemplateField HeaderText="tanggal_rapat" SortExpression="tanggal_rapat">
                            <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("tanggal_rapat") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("tanggal_rapat") %>'></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="perihal" SortExpression="perihal">
                            <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("perihal") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("perihal") %>'></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField>
                            <%--<asp:TemplateField HeaderText="tindak_lanjut" SortExpression="tindak_lanjut">
                            <EditItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("tindak_lanjut") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("tindak_lanjut") %>'></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField> 
                            <asp:TemplateField HeaderText="PIC" SortExpression="PIC">
                            <EditItemTemplate>
                            <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("PIC") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("PIC") %>'></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField>--%>
                            <asp:TemplateField HeaderText="pimpinan_rapat" SortExpression="pimpinan_rapat">
                            <EditItemTemplate>
                            <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("pimpinan_rapat") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("pimpinan_rapat") %>'></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="notulis" SortExpression="notulis">
                            <EditItemTemplate>
                            <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("notulis") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                            <asp:Label ID="Label6" runat="server" Text='<%# Bind("notulis") %>'></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="no_ruangan" SortExpression="no_ruangan">
                            <EditItemTemplate>
                            <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("no_ruangan") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                            <asp:Label ID="Label7" runat="server" Text='<%# Bind("no_ruangan") %>'></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="FilePath" SortExpression="FilePath">
                            <EditItemTemplate>
                            <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("FilePath") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                            <asp:Label ID="Label8" runat="server" Text='<%# Bind("FilePath") %>'></asp:Label>
                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Tindak Lanjut">
                             <ItemTemplate>
                                  <asp:LinkButton ID="addtindak" runat="server" Text="Add Tindak Lanjut" OnClick="lnktindak_Click"></asp:LinkButton>
                                  </ItemTemplate>
                            </asp:TemplateField> 
                                <asp:HyperLinkField DataNavigateUrlFields="FilePath" HeaderText="View" 
                                    Text="View File" />
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#333333" />
                        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    </asp:GridView>
                    <asp:Label ID="Label2" runat="server" Text="Untuk melihat dan menyimpan file,silahkan buka file di tab baru" CssClass="color"></asp:Label>
                    <%--<asp:LinkButton ID="LinkButtonBack" runat="server">Go Back</asp:LinkButton>--%>
    </div>
</asp:Content>

