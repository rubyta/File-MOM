<%@ Page Title="" Language="VB" MasterPageFile="~/Master/Template.master" AutoEventWireup="false" CodeFile="GridViewPekerja.aspx.vb" Inherits="Notulis_GridViewPekerja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" Runat="Server">
    <div id="pekerja" style=" width:100%; height:700px">
    <asp:GridView ID="GridViewPek" runat="server" AutoGenerateColumns="False" 
        OnPageIndexChanging="gvpek_PageIndexChanging" 
        OnRowCancelingEdit="gvpek_RowCancelingEdit" OnRowDatabound="gvpek_RowDataBound" 
        OnRowDeleting="gvpek_RowDeleting" OnRowEditing="gvpek_RowEditing" 
        OnRowUpdating="gvpek_RowUpdating" OnSorting="gvpek_Sorting" BackColor="White" 
        BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
        GridLines="Horizontal">
        <RowStyle BackColor="White" ForeColor="#333333" />
        <Columns>
        <asp:CommandField ShowEditButton="true"/>
         <asp:CommandField ShowDeleteButton="true"/>
        <asp:BoundField DataField="nopek" HeaderText="nopek" ReadOnly="True" 

            SortExpression="nopek" />
        
        <asp:TemplateField HeaderText="no rapat" SortExpression="id">

            <EditItemTemplate>

                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("id") %>'></asp:TextBox>

            </EditItemTemplate>

            <ItemTemplate>

                <asp:Label ID="Label1" runat="server" Text='<%# Bind("id") %>'></asp:Label>

            </ItemTemplate>

        </asp:TemplateField>
        <asp:TemplateField HeaderText="nama_pekerja" SortExpression="nama_pekerja">

            <EditItemTemplate>

                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("nama_pekerja") %>'></asp:TextBox>

            </EditItemTemplate>

            <ItemTemplate>

                <asp:Label ID="Label2" runat="server" Text='<%# Bind("nama_pekerja") %>'></asp:Label>

            </ItemTemplate>

        </asp:TemplateField>

        <asp:TemplateField HeaderText="jabatan" SortExpression="jabatan">

            <EditItemTemplate>

                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("jabatan") %>'></asp:TextBox>

            </EditItemTemplate>

            <ItemTemplate>

                <asp:Label ID="Label3" runat="server" Text='<%# Bind("jabatan") %>'></asp:Label>

            </ItemTemplate>

        </asp:TemplateField>

        <asp:TemplateField HeaderText="email_address" SortExpression="email_address">

            <EditItemTemplate>

                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("email_address") %>'></asp:TextBox>

            </EditItemTemplate>

            <ItemTemplate>

                <asp:Label ID="Label4" runat="server" Text='<%# Bind("email_address") %>'></asp:Label>

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
    <asp:Panel ID="pnlAdd" runat="server" Visible="False"> 
        <asp:Label ID="Label1" runat="server" Text="Nopek "></asp:Label>
        <asp:TextBox ID="tbnopek" runat="server"></asp:TextBox> 
        <br />
        <asp:Label ID="Label5" runat="server" Text="no rapat"></asp:Label>
        <asp:TextBox ID="tbid" runat="server"></asp:TextBox> 
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nama "></asp:Label>
        <asp:TextBox ID="tbnamapek" runat="server"></asp:TextBox> 
        <br />
        <asp:Label ID="Label4" runat="server" Text="Jabatan"></asp:Label>
        <asp:TextBox ID="tbjabatan" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email Address"></asp:Label>
        <asp:TextBox ID="tbemail_address" runat="server"></asp:TextBox>
        <br /> 
        <asp:LinkButton ID="lbtnSubmit" runat="server" onclick="lbtnSubmit_Click">Submit</asp:LinkButton> 
        &nbsp   
        <asp:LinkButton ID="lbtnCancel" runat="server" onclick="lbtnCancel_Click">Cancel</asp:LinkButton> 
        &nbsp
        </asp:Panel> 
    </div>
</asp:Content>

