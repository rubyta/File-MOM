<%@ Page Title="" Language="VB" MasterPageFile="~/Master/Help.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content0" Runat="Server">
    <div id="default">
        <table style="width:100%; height: 700px;">
            <tr style="background-image:url(mom1.png); background-position:inherit; background-repeat:no-repeat;">
                <td style="border: thin solid #008000; text-align:center; vertical-align:middle;">
                    <asp:CheckBox ID="NotulisCheckBox" runat="server" Text="Notulis"/>
                    <asp:CheckBox ID="PimpinanCheckBox" runat="server" Text="Pimpinan"/>
                    <asp:Label ID="Label1" runat="server" Text="* Tolong pilih salah satu" Font-Size="Small" Font-Names="Arial" ForeColor="Red"></asp:Label>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Email" Width="78px"></asp:Label>
                    <asp:TextBox ID="UserTextBox" runat="server" Width="145px" CssClass="textfield"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Password" Width="78px"></asp:Label>
                    <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" Width="145px" CssClass="textfield"></asp:TextBox>
                    <br />
                    <asp:Button ID="LoginButton" runat="server" Text="Login" CssClass="button2"/>
                    <br />  
                </td>
            </tr>
        </table>
     </div>     
</asp:Content>

