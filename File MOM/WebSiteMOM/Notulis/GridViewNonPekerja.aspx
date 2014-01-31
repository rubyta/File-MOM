<%@ Page Title="" Language="VB" MasterPageFile="~/Master/Template.master" AutoEventWireup="false" CodeFile="GridViewNonPekerja.aspx.vb" Inherits="Notulis_GridViewNonPekerja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" Runat="Server" >
    <div id="nonpekerja" style=" width:100%; height:700px">
    <asp:GridView ID="GridViewNonPek" runat="server" AutoGenerateColumns="False" OnPageIndexChanging="gv1_PageIndexChanging" 
        OnRowCancelingEdit="gv1_RowCancelingEdit" OnRowDatabound="gv1_RowDataBound" 
        OnRowDeleting="gv1_RowDeleting" OnRowEditing="gv1_RowEditing" 
        OnRowUpdating="gv1_RowUpdating" OnSorting="gv1_Sorting" BackColor="White" 
        BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
        GridLines="Horizontal">
        <RowStyle BackColor="White" ForeColor="#333333" />
    <Columns>
        <asp:CommandField ShowEditButton="true"/> 
        <asp:CommandField ShowDeleteButton="True" />
        <asp:BoundField DataField="id_non_pekerja" HeaderText="no_rapat" ReadOnly="True" 
            SortExpression="id_non_pekerja" />
            
        <asp:TemplateField HeaderText="nama" SortExpression="nama">

            <EditItemTemplate>

                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("nama") %>'></asp:TextBox>

            </EditItemTemplate>

            <ItemTemplate>

                <asp:Label ID="Label1" runat="server" Text='<%# Bind("nama") %>'></asp:Label>

            </ItemTemplate>

        </asp:TemplateField>

        <asp:TemplateField HeaderText="instansi" SortExpression="instansi">

            <EditItemTemplate>

                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("instansi") %>'></asp:TextBox>

            </EditItemTemplate>

            <ItemTemplate>

                <asp:Label ID="Label2" runat="server" Text='<%# Bind("instansi") %>'></asp:Label>

            </ItemTemplate>

        </asp:TemplateField>
        <asp:TemplateField HeaderText="email_address" SortExpression="email_address">

            <EditItemTemplate>

                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("email_address") %>'></asp:TextBox>

            </EditItemTemplate>

            <ItemTemplate>

                <asp:Label ID="Label3" runat="server" Text='<%# Bind("email_address") %>'></asp:Label>

            </ItemTemplate>

        </asp:TemplateField>
    </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    <asp:LinkButton ID="lbtnAdd" runat="server" onclick="lbtnAdd_Click" Text="Add"></asp:LinkButton> 
    <br />
    <br />
    <asp:Panel ID="pnlAdd" runat="server" Visible="False"> 
        <asp:Label ID="Label4" runat="server" Text="no rapat"></asp:Label>
        <asp:TextBox ID="tbid" runat="server"></asp:TextBox> 
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nama "></asp:Label>
        <asp:TextBox ID="tbname" runat="server"></asp:TextBox> 
        <br />
        <asp:Label ID="Label2" runat="server" Text="Instansi "></asp:Label>
        <asp:TextBox ID="tbinstansi" runat="server"></asp:TextBox> 
        <br />
        <asp:Label ID="Label3" runat="server" Text="email_address"></asp:Label>
        <asp:TextBox ID="tbemail_address" runat="server"></asp:TextBox>
        <br /> 
        <asp:LinkButton ID="lbtnSubmit" runat="server" onclick="lbtnSubmit_Click">Submit</asp:LinkButton> 
        &nbsp   
        <asp:LinkButton ID="lbtnCancel" runat="server" onclick="lbtnCancel_Click">Cancel</asp:LinkButton>   
    </asp:Panel> 
    </div>
</asp:Content>

