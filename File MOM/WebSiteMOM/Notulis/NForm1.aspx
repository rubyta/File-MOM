<%@ Page Title="" Language="VB" MasterPageFile="~/Master/Template.master" AutoEventWireup="true" CodeFile="NForm1.aspx.vb" Inherits="Notulis_NForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" Runat="Server">
    <div id="notulis">
    <table style=" width:100%; height:700px">
            <tr>
                <td style="border: thin solid #800000; text-align:left; vertical-align:top;">
                    <!-- rapat form ---> 
                    <asp:Label ID="Label1" runat="server" Text="Tanggal&Waktu" Width="101px"></asp:Label>
                    <asp:TextBox ID="TglTextBox" runat="server" Width="201px"></asp:TextBox>
                    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" OnDayRender="Calendar1_dayrender"
                     ShowTitle="true" DayNameFormat="FirstTwoLetters" SelectionMode="Day" FirstDayOfWeek="Monday"></asp:Calendar>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Perihal" Width="100px"></asp:Label>
                    <asp:TextBox ID="PerihalTextBox" runat="server" Width="200px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Pimpinan rapat" Width="100px"></asp:Label>
                    <asp:TextBox ID="PimpinanRapatTextBox" runat="server" Width="200px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label5" runat="server" Text="Notulis" Width="100px"></asp:Label>
                    <asp:TextBox ID="NotulisTextBox" runat="server" Width="200px"></asp:TextBox>
                    <br />
                    <%--<asp:Label ID="Label6" runat="server" Text="PIC" Width="100px"></asp:Label>
                    <asp:TextBox ID="PICTextBox" runat="server" Width="200px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label10" runat="server" Text="Tindak Lanjut" Width="100px"></asp:Label>
                    <asp:TextBox ID="TindakLanjutTextBox" runat="server" Width="200px"></asp:TextBox>
                    <br /> --%>
                    <asp:Label ID="Label11" runat="server" Text="Hasil Rapat" Width="100px"></asp:Label>
                    <asp:FileUpload ID="FileUpload1" runat="server" Width="216px" />
                    <br />
                    <asp:Label ID="Label12" runat="server" Text="No ruangan" Width="97px"></asp:Label>
                    <asp:DropDownList ID="NoRuanganDropDownList" runat="server" Width="114px">
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:Button ID="SaveButton" runat="server" Text="Save" style="" Width="60px"/>
                    <%--<br />--%>&nbsp;
                   <%-- <asp:Label ID="Label9" runat="server" Text="Daftar Hadir"></asp:Label>
                    <br />
                    <asp:LinkButton ID="HadirLinkButton" runat="server">Add file hadir</asp:LinkButton>
                    <br />--%>
                    <asp:Button ID="CancelButton" runat="server" Text="Cancel" style="" Width="60px"/>
                    &nbsp
                    
                </td>
                <%--<td style="text-align:left; vertical-align:top;">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="100px" >
                <asp:ListItem Selected ="True" >select</asp:ListItem>
                <asp:ListItem>rapat</asp:ListItem>
                <asp:ListItem>pekerja</asp:ListItem>
                <asp:ListItem>non_pekerja</asp:ListItem>
                </asp:DropDownList>  
                <asp:Button ID="ViewButton" runat="server" Text="View" />--%>
                <%--<br />
                <br />--%>
                <%--<asp:GridView ID="GridViewRapat" runat="server" OnPageIndexChanging="gvrapat_PageIndexChanging" 
                        OnRowCancelingEdit="gvrapat_RowCancelingEdit" OnRowDatabound="gvrapat_RowDataBound" 
                        OnRowDeleting="gvrapat_RowDeleting" OnRowEditing="gvrapat_RowEditing" 
                        OnRowUpdating="gvrapat_RowUpdating" OnSorting="gvrapat_Sorting" 
                        BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                        CellPadding="4" GridLines="Horizontal">
                        <RowStyle BackColor="White" ForeColor="#333333" />
                            <Columns>
                                <asp:CommandField ShowEditButton="True" />
                                <asp:CommandField ShowDeleteButton="True" />
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
                            <asp:TemplateField HeaderText="tindak_lanjut" SortExpression="tindak_lanjut">
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
                            </asp:TemplateField>
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
                                <asp:HyperLinkField HeaderText="View" Text="View File" />
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#333333" />
                        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    </asp:GridView>--%>
             <%--</td>    --%>
            </tr>
        </table>
        </div> 
</asp:Content>

