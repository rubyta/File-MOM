<%@ Page Title="" Language="VB" MasterPageFile="~/Master/Template4.master" AutoEventWireup="false" CodeFile="Admin.aspx.vb" Inherits="Admin_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" Runat="Server">
<table style="width:100%;">
            <tr>
                <td style=" text-align: left; vertical-align:top; width:100%; height:700px">
                    <!-- create user -->
                    <asp:Label ID="Label18" runat="server" Text="Email" Width="61px"></asp:Label>
                    <asp:TextBox ID="EmailPekTextBox" runat="server" Width="178px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label19" runat="server" Text="Password" Width="61px"></asp:Label>
                    <asp:TextBox ID="PwordemailTextBox" runat="server" Width="176px"></asp:TextBox>
                    <br />
                    <asp:Button ID="CreateButton" runat="server" Text="Create" />
                    <br />
                    <br />
                    <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                        BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                        GridLines="Horizontal">
                        <RowStyle BackColor="White" ForeColor="#333333" />
                    <Columns>
                            <asp:CommandField ShowEditButton="True" />
                            <asp:CommandField ShowDeleteButton="True" />
                    </Columns> 
                        <FooterStyle BackColor="White" ForeColor="#333333" />
                        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    </asp:GridView> 
                    <%--<asp:Button ID="LogoutButton" runat="server" Text="Logout" />--%>
               </td>
               
               <%--<td>
                   <asp:DropDownList ID="DropDownListView" runat="server" OnSelectedIndexChanged="DropDownListView_SelectedIndexChanged" AutoPostBack="True">
                   <asp:ListItem Value="0">Select</asp:ListItem>
                   <asp:ListItem Value="1">Rapat</asp:ListItem>
                   <asp:ListItem Value="2">Pekerja</asp:ListItem>
                   <asp:ListItem Value="3">NonPekerja</asp:ListItem>
                   </asp:DropDownList>
                   <br />
                   <br />
                   <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                       <asp:View ID="Select" runat="server">
                       </asp:View>
                       <asp:View ID="Rapat" runat="server">
                           <asp:Label ID="Label1" runat="server" Text="Tabel Rapat"></asp:Label>
                           <asp:GridView ID="GridView2" runat="server" BackColor="White" 
                               BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                               GridLines="Horizontal">
                               <RowStyle BackColor="White" ForeColor="#333333" />
                           <Columns>
                            <asp:CommandField ShowEditButton="True" />
                            <asp:CommandField ShowDeleteButton="True" />
                           </Columns> 
                               <FooterStyle BackColor="White" ForeColor="#333333" />
                               <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                               <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                               <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                           </asp:GridView>
                       </asp:View>
                       <asp:View ID="Pekerja" runat="server">
                           <asp:Label ID="Label2" runat="server" Text="Tabel Pekerja"></asp:Label>
                           <asp:GridView ID="GridView3" runat="server" BackColor="White" 
                               BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                               GridLines="Horizontal">
                               <RowStyle BackColor="White" ForeColor="#333333" />
                               <Columns>
                                <asp:CommandField ShowEditButton="True" />
                                <asp:CommandField ShowDeleteButton="True" />
                               </Columns> 
                               <FooterStyle BackColor="White" ForeColor="#333333" />
                               <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                               <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                               <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                           </asp:GridView>
                       </asp:View>
                       <asp:View ID="NonPekerja" runat="server">
                           <asp:Label ID="Label3" runat="server" Text="Table Non Pekerja"></asp:Label>
                           <asp:GridView ID="GridView4" runat="server" BackColor="White" 
                               BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                               GridLines="Horizontal">
                               <RowStyle BackColor="White" ForeColor="#333333" />
                               <Columns>
                                <asp:CommandField ShowEditButton="True" />
                                <asp:CommandField ShowDeleteButton="True" />
                               </Columns> 
                               <FooterStyle BackColor="White" ForeColor="#333333" />
                               <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                               <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                               <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                           </asp:GridView>
                       </asp:View>
                   </asp:MultiView>
               </td>--%>
            </tr>
        </table>
</asp:Content>

