Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient

Partial Class Notulis_TindakLanjut
    Inherits System.Web.UI.Page

    Private Sub BindGrid()
        Dim items As New List(Of TindakLanjut)(3)
        For i As Integer = 0 To 4
            Dim c As New TindakLanjut()
            items.Add(c)
        Next
        GridViewTindak.DataSource = items
        GridViewTindak.DataBind()
    End Sub

    Private cnn As New SqlConnection("Data Source=RUBY-PC\MSSQL2008;Initial Catalog=DB_mom;User ID=sa;Password=lolipop20")
    Private cmd As New SqlCommand()

    Private Sub BeginAdd()
        cnn.Open()
        Dim tran As SqlTransaction = cnn.BeginTransaction()
        cmd.Connection = cnn
        cmd.Transaction = tran
        cmd.CommandText = "INSERT INTO tindaklanjut(id,PIC,tindak_lanjut) VALUES(@ID,@PIC,@TINDAKLANJUT)"
        Dim p1 As New SqlParameter("@ID", SqlDbType.VarChar)
        Dim p2 As New SqlParameter("@PIC", SqlDbType.VarChar)
        Dim p3 As New SqlParameter("@TINDAKLANJUT", SqlDbType.VarChar)
        cmd.Parameters.Add(p1)
        cmd.Parameters.Add(p2)
        cmd.Parameters.Add(p3)
    End Sub

    Private Sub CompleteAdd()
        Try
            cmd.Transaction.Commit()
            lblStatus.Text = "Customers added successfully!"
        Catch ex As Exception
            lblStatus.Text = "Error completing the operation!"
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub AddTindakLanjut(ByVal id As String, ByVal PIC As String, ByVal tindak_lanjut As String)
        Try
            cmd.Parameters(0).Value = id
            cmd.Parameters(1).Value = PIC
            cmd.Parameters(2).Value = tindak_lanjut
            cmd.ExecuteNonQuery()
        Catch
            cmd.Transaction.Rollback()
        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsPostBack Then
            BindGrid()
        End If
    End Sub
    Protected Sub btnInsert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInsert.Click
        BeginAdd()
        For Each row As GridViewRow In GridViewTindak.Rows
            If row.RowType = DataControlRowType.DataRow Then
                Dim id As String = DirectCast(row.FindControl("TextBox1"), TextBox).Text
                Dim PIC As String = DirectCast(row.FindControl("TextBox2"), TextBox).Text
                Dim tindak_lanjut As String = DirectCast(row.FindControl("TextBox3"), TextBox).Text
                If id <> "" Then
                    AddTindakLanjut(id, PIC, tindak_lanjut)
                End If
            End If
        Next
        CompleteAdd()
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
        BindGrid()
    End Sub

    Protected Sub ViewButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ViewButton.Click
        Dim ObjClassMOM As New ClassMOM

        Try
            ObjClassMOM.id = idTextBox.Text
            GridViewPIC.DataSource = ObjClassMOM.View()
            GridViewPIC.DataBind()
        Catch ex As Exception
            'if there is invalid input or no input
            MsgBox("Please input existed id first to proceed display option")
        End Try
    End Sub

    Protected Sub GridViewPIC_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridViewPIC.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            'switch for first row 
            If e.Row.RowIndex = 1 Then
                Dim Gprev As GridViewRow = GridViewPIC.Rows(e.Row.RowIndex - 1)
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
                    Dim Gprev As GridViewRow = GridViewPIC.Rows(intC - 1)

                    If Gprev.Cells(0).Text.Equals(e.Row.Cells(0).Text) Then
                        e.Row.Cells(0).Text = ""
                    End If

                    intC = intC - 1

                Loop While intC > 0

            End If
        End If

    End Sub
End Class
