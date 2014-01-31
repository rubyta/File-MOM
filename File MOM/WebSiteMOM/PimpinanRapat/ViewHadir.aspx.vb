
Partial Class PimpinanRapat_ViewHadir
    Inherits System.Web.UI.Page

    Protected Sub ViewButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ViewButton.Click
        Dim ObjClassMOM As New ClassMOM

        Try
            ObjClassMOM.id = noTextBox.Text
            FileGridView.DataSource = ObjClassMOM.ViewFile()
            FileGridView.DataBind()

        Catch ex As Exception
            'if there is invalid input or no input
            MsgBox("Please input existed id first to proceed display option")
        End Try
    End Sub

    Protected Sub PekButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PekButton.Click
        Dim ObjClassMOM As New ClassMOM

        Try
            ObjClassMOM.id = nomorTextBox.Text
            PekGridView.DataSource = ObjClassMOM.ViewPek()
            PekGridView.DataBind()
        Catch ex As Exception
            'if there is invalid input or no input
            MsgBox("Please input existed id first to proceed display option")
        End Try

    End Sub

    Protected Sub NonpekButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NonpekButton.Click
        Dim ObjClassMOM As New ClassMOM

        Try
            ObjClassMOM.id = numberTextBox.Text
            NonPekGridView.DataSource = ObjClassMOM.ViewNonPek()
            NonPekGridView.DataBind()
        Catch ex As Exception
            'if there is invalid input or no input
            MsgBox("Please input existed id first to proceed display option")
        End Try
    End Sub

    Protected Sub FileGridView_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles FileGridView.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            'switch for first row 
            If e.Row.RowIndex = 1 Then
                Dim Gprev As GridViewRow = FileGridView.Rows(e.Row.RowIndex - 1)
                If Gprev.Cells(0).Text.Equals(e.Row.Cells(0).Text) Then
                    e.Row.Cells(0).Text = ""
                End If
            End If
            'now continue with the rest of the rows

            If e.Row.RowIndex > 1 Then
                'set reference to the row index and the current value
                Dim intC As Integer = e.Row.RowIndex
                Dim lookfor As String = e.Row.Cells(0).Text

                'now loop back through checking previous entries for matches 
                Do
                    Dim Gprev As GridViewRow = FileGridView.Rows(intC - 1)

                    If Gprev.Cells(0).Text.Equals(e.Row.Cells(0).Text) Then
                        e.Row.Cells(0).Text = ""
                    End If

                    intC = intC - 1

                Loop While intC > 0

            End If
        End If

    End Sub

    Protected Sub PekGridView_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles PekGridView.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            'switch for first row 
            If e.Row.RowIndex = 1 Then
                Dim Gprev As GridViewRow = PekGridView.Rows(e.Row.RowIndex - 1)
                If Gprev.Cells(0).Text.Equals(e.Row.Cells(0).Text) Then
                    e.Row.Cells(0).Text = ""
                End If
            End If
            'now continue with the rest of the rows

            If e.Row.RowIndex > 1 Then
                'set reference to the row index and the current value
                Dim intC As Integer = e.Row.RowIndex
                Dim lookfor As String = e.Row.Cells(0).Text

                'now loop back through checking previous entries for matches 
                Do
                    Dim Gprev As GridViewRow = PekGridView.Rows(intC - 1)

                    If Gprev.Cells(0).Text.Equals(e.Row.Cells(0).Text) Then
                        e.Row.Cells(0).Text = ""
                    End If

                    intC = intC - 1

                Loop While intC > 0

            End If
        End If

    End Sub

    Protected Sub NonPekGridView_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles NonPekGridView.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            'switch for first row 
            If e.Row.RowIndex = 1 Then
                Dim Gprev As GridViewRow = NonPekGridView.Rows(e.Row.RowIndex - 1)
                If Gprev.Cells(0).Text.Equals(e.Row.Cells(0).Text) Then
                    e.Row.Cells(0).Text = ""
                End If
            End If
            'now continue with the rest of the rows

            If e.Row.RowIndex > 1 Then
                'set reference to the row index and the current value
                Dim intC As Integer = e.Row.RowIndex
                Dim lookfor As String = e.Row.Cells(0).Text

                'now loop back through checking previous entries for matches 
                Do
                    Dim Gprev As GridViewRow = NonPekGridView.Rows(intC - 1)

                    If Gprev.Cells(0).Text.Equals(e.Row.Cells(0).Text) Then
                        e.Row.Cells(0).Text = ""
                    End If

                    intC = intC - 1

                Loop While intC > 0

            End If
        End If

    End Sub
End Class
