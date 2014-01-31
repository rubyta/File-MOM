Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Partial Class Admin_Admin
    Inherits System.Web.UI.Page

    Protected Sub CreateButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CreateButton.Click
        Dim ObjClassmom As New ClassMOM

        If EmailPekTextBox.Text <> "" Then
            ObjClassmom.User = EmailPekTextBox.Text
            If PwordemailTextBox.Text <> "" Then
                ObjClassmom.Password = PwordemailTextBox.Text
                ObjClassmom.showuser()

                If ObjClassmom.User <> "" Then
                    ObjClassmom.User = EmailPekTextBox.Text
                    ObjClassmom.Password = PwordemailTextBox.Text
                    ObjClassmom.updateuser()
                Else
                    ObjClassmom.User = EmailPekTextBox.Text
                    ObjClassmom.Password = PwordemailTextBox.Text
                    ObjClassmom.insertuser()
                End If
            End If
        Else
            'show message to user if user doesn't input data
            MsgBox("Please input a text!")
        End If

        'Clear text box
        With EmailPekTextBox
            .Text() = String.Empty
            .Focus()
        End With

        PwordemailTextBox.Text = String.Empty

        BindGridUser()

    End Sub

    Private Sub BindGridUser()
        Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("select* from user1", con)
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)
            con.Close()
            GridView1.DataSource = ds
            GridView1.DataBind()
            con.Close()
        End Using
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    'Protected Sub LogoutButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LogoutButton.Click
    '    Response.Redirect("~/Logout.aspx")
    'End Sub

    'Protected Sub DropDownListView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownListView.SelectedIndexChanged
    '    MultiView1.ActiveViewIndex = Convert.ToInt32(DropDownListView.SelectedValue)
    '    BindGrid2()
    '    BindGrid3()
    '    BindGrid4()
    'End Sub

    'Private Sub BindGrid2()
    '    Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
    '        con.Open()
    '        Dim cmd As New SqlCommand("select* from rapat", con)
    '        cmd.ExecuteNonQuery()
    '        Dim da As New SqlDataAdapter(cmd)
    '        Dim ds As New DataSet()
    '        da.Fill(ds)
    '        con.Close()
    '        GridView2.DataSource = ds
    '        GridView2.DataBind()
    '        con.Close()
    '    End Using
    'End Sub

    'Private Sub BindGrid3()
    '    Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
    '        con.Open()
    '        Dim cmd As New SqlCommand("select* from pekerja", con)
    '        cmd.ExecuteNonQuery()
    '        Dim da As New SqlDataAdapter(cmd)
    '        Dim ds As New DataSet()
    '        da.Fill(ds)
    '        con.Close()
    '        GridView3.DataSource = ds
    '        GridView3.DataBind()
    '        con.Close()
    '    End Using
    'End Sub

    'Private Sub BindGrid4()
    '    Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
    '        con.Open()
    '        Dim cmd As New SqlCommand("select* from non_pekerja", con)
    '        cmd.ExecuteNonQuery()
    '        Dim da As New SqlDataAdapter(cmd)
    '        Dim ds As New DataSet()
    '        da.Fill(ds)
    '        con.Close()
    '        GridView4.DataSource = ds
    '        GridView4.DataBind()
    '        con.Close()
    '    End Using
    'End Sub

End Class
