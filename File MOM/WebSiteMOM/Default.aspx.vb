
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub LoginButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LoginButton.Click
        Dim ObjClassMOM As New ClassMOM

        'login for admin
        If NotulisCheckBox.Checked = True Then
            If UserTextBox.Text <> "" And PasswordTextBox.Text <> "" Then
                ObjClassMOM.User = UserTextBox.Text
                ObjClassMOM.Password = PasswordTextBox.Text
                ObjClassMOM.showuser()
                Response.Redirect("~/Notulis/NForm1.aspx")
                'Session("email") = UserTextBox.Text
                'Session("password") = PasswordTextBox.Text
            Else
                MsgBox("Please input a valid email and password")
            End If
        ElseIf PimpinanCheckBox.Checked = True Then
            If UserTextBox.Text <> "" And PasswordTextBox.Text <> "" Then
                ObjClassMOM.User = UserTextBox.Text
                ObjClassMOM.Password = PasswordTextBox.Text
                Response.Redirect("~/PimpinanRapat/PForm.aspx")
            End If
        ElseIf UserTextBox.Text = "admin" And PasswordTextBox.Text = "admin" Then
            Response.Redirect("~/Admin/admin.aspx")
        Else
            MsgBox("Login is invalid")
        End If

        With UserTextBox
            .Text = String.Empty
            .Focus()
        End With
        PasswordTextBox.Text = String.Empty

    End Sub

    Protected Sub UserTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserTextBox.TextChanged

    End Sub
End Class
