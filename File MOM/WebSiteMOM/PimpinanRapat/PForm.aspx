<%@ Page Title="" Language="VB" MasterPageFile="~/Master/Template2.master" AutoEventWireup="false" CodeFile="PForm.aspx.vb" Inherits="PimpinanRapat_PForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" Runat="Server">
    <div style=" width:100%" id="pimpinan">
        <table>
            <tr>
                <td>
                    <asp:GridView ID="GridView2" runat="server" DataKeyNames="no_rapat" 
                        BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
                        CellPadding="4" GridLines="Horizontal">
                        <RowStyle BackColor="White" ForeColor="#333333" />
                        <Columns>
                         <asp:BoundField DataField="no_rapat" HeaderText="no_rapat" />
                         <asp:BoundField DataField="FileName" HeaderText="FileName" />
                            <%--<asp:TemplateField HeaderText="FilePath">
                             <ItemTemplate>
                                  <asp:LinkButton ID="lnkDownload" runat="server" Text="Download" OnClick="lnkDownload_Click"></asp:LinkButton>
                                  </ItemTemplate>
                            </asp:TemplateField> --%>
                            <asp:HyperLinkField DataNavigateUrlFields="FilePath" HeaderText="View File" 
                                Text="View File" />
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#333333" />
                        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    </asp:GridView>
                    <asp:Label ID="Label2" runat="server" Text="Untuk melihat dan menyimpan file,silahkan buka file di tab baru" CssClass="color"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <br />
    </div>
    <div id="viewtindak" runat="server" style="width:100%">
    <asp:Label ID="Label1" runat="server" Text="Look up untuk detail tindak lanjut" Font-Bold="true" ></asp:Label>
    <br />
    <asp:Label ID="idLabel" runat="server" Text="no rapat" Width="70px"></asp:Label>
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

