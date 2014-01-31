<%@ Page Title="" Language="VB" MasterPageFile="~/Master/Template.master" AutoEventWireup="false" CodeFile="Email.aspx.vb" Inherits="Mail_Email" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" Runat="Server">
<div id="email">
            <table style=" border:1px solid">
                <tr>
                    <td style="width: 647px">
                        <asp:Label ID="Label1" runat="server" Text="From" Width="50px"></asp:Label>
                        <asp:TextBox ID="txtFrom" runat="server" Width="529px"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="To" Width="50px"></asp:Label>
                        <asp:TextBox ID="txtTo" runat="server" Width="527px"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label3" runat="server" Text="Subject:" Width="50px"></asp:Label>
                        <asp:TextBox ID="txtSubject" runat="server" Width="526px"></asp:TextBox>
                        <br />
                        <asp:Label ID="Label4" runat="server" Text="Attach a file" Width="107px"></asp:Label>
                        <asp:FileUpload ID="fileUpload1" runat="server" Width="216px" />
                     </td>
                </tr>
                <tr>
                    <td valign="top" style="width: 647px">
                        <asp:Label ID="Label5" runat="server" Text="Body:"></asp:Label>
                        <br />
                        <asp:TextBox ID="txtBody" runat="server" TextMode="MultiLine" Columns="30" 
                            Rows="10" Height="180px" Width="587px" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 647px">
                        <asp:Button ID="btnSubmit" Text="Send" runat="server" onclick="btnSubmit_Click" />
                    </td>
                </tr>
            </table>
       </div>
</asp:Content>

