Imports System
Imports System.Data.SqlClient
Imports System.Data
Imports System.Net
Imports System.IO

Partial Class Notulis_Rapat
    Inherits System.Web.UI.Page

    Private con As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)

    'Bind Gridview Data
    Private Sub BindGridRapat()
        con.Open()
        Dim cmd As New SqlCommand("select no_rapat,tanggal_rapat, perihal, pimpinan_rapat, notulis, no_ruangan, FilePath from rapat", con)
        cmd.ExecuteNonQuery()
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        da.Fill(ds)
        GridViewRapat.DataSource = ds
        GridViewRapat.DataBind()
        con.Close()
    End Sub
    ' GridView.RowDataBound Event 
    Protected Sub gvrapat_RowDataBound(ByVal sender As Object, ByVal e As GridViewRowEventArgs)

        If e.Row.RowType = DataControlRowType.DataRow Then
            'Make sure the current GridViewRow is either  
            'in the normal state or an alternate row. 
            If e.Row.RowState = DataControlRowState.Normal OrElse e.Row.RowState = DataControlRowState.Alternate Then
                'Add client-side confirmation when deleting. 
                'DirectCast(e.Row.Cells(1).Controls(0), LinkButton).Attributes("onclick") = "if(!confirm('Are you certain you want to delete it?')) return false;"
            End If
        End If
    End Sub

    ' GridView.PageIndexChanging Event 
    Protected Sub gvrapat_PageIndexChanging(ByVal sender As Object, ByVal e As GridViewPageEventArgs)
        GridViewRapat.PageIndex = e.NewPageIndex
        BindGridRapat()
    End Sub

    ' GridView.RowEditing Event 
    Protected Sub gvrapat_RowEditing(ByVal sender As Object, ByVal e As GridViewEditEventArgs)

        GridViewRapat.EditIndex = e.NewEditIndex

        BindGridRapat()

    End Sub

    ' GridView.RowCancelingEdit Event 
    Protected Sub gvrapat_RowCancelingEdit(ByVal sender As Object, ByVal e As GridViewCancelEditEventArgs)

        GridViewRapat.EditIndex = -1

        BindGridRapat()
    End Sub

    ' GridView.RowUpdating Event 
    Protected Sub gvrapat_RowUpdating(ByVal sender As Object, ByVal e As GridViewUpdateEventArgs)
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
            'Create a command object. 
            Dim cmd As New SqlCommand()
            cmd.Connection = conn
            cmd.CommandText = "SPUPDATERAPAT"
            cmd.CommandType = CommandType.StoredProcedure

            Dim strno As String = GridViewRapat.Rows(e.RowIndex).Cells(2).Text
            Dim strtanggal As String = DirectCast(GridViewRapat.Rows(e.RowIndex).FindControl("TextBox1"), TextBox).Text
            Dim strperihal As String = DirectCast(GridViewRapat.Rows(e.RowIndex).FindControl("TextBox2"), TextBox).Text
            Dim strpimpinan As String = DirectCast(GridViewRapat.Rows(e.RowIndex).FindControl("TextBox4"), TextBox).Text
            Dim strnotulis As String = DirectCast(GridViewRapat.Rows(e.RowIndex).FindControl("TextBox5"), TextBox).Text
            Dim strruang As String = DirectCast(GridViewRapat.Rows(e.RowIndex).FindControl("TextBox7"), TextBox).Text

            cmd.Parameters.Add("@TANGGAL", SqlDbType.DateTime, 100).Value = strtanggal
            cmd.Parameters.Add("@PERIHAL", SqlDbType.VarChar, 100).Value = strperihal
            cmd.Parameters.Add("@PIMPINAN", SqlDbType.VarChar, 100).Value = strpimpinan
            cmd.Parameters.Add("@NOTULIS", SqlDbType.VarChar, 100).Value = strnotulis
            cmd.Parameters.Add("@NORUANGAN", SqlDbType.VarChar, 100).Value = strruang
            conn.Open()

            cmd.ExecuteNonQuery()
        End Using

        GridViewRapat.EditIndex = -1

        BindGridRapat()

    End Sub

    ' GridView.RowDeleting Event 
    Protected Sub gvrapat_RowDeleting(ByVal sender As Object, ByVal e As GridViewDeleteEventArgs)
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
            ' Create a command object. 
            Dim cmd As New SqlCommand()


            ' Assign the connection to the command. 
            cmd.Connection = conn

            ' Set the command text  
            cmd.CommandText = "SPDELETERAPAT"

            ' Set the command type 
            cmd.CommandType = CommandType.StoredProcedure


            ' Get the PersonID of the selected row. 
            Dim strno As String = GridViewRapat.Rows(e.RowIndex).Cells(2).Text

            ' Append the parameter. 
            cmd.Parameters.Add("@NORAPAT", SqlDbType.Int).Value = strno

            ' Open the connection. 
            conn.Open()

            ' Execute the command. 
            cmd.ExecuteNonQuery()
        End Using

        ' Rebind the GridView control to show data after deleting. 
        BindGridRapat()
    End Sub

    Protected Sub gvrapat_Sorting(ByVal sender As Object, ByVal e As GridViewSortEventArgs)

        Dim strSortExpression As String() = ViewState("SortExpression").ToString().Split(" "c)

        ' If the sorting column is the same as the previous one, then change the sort order.

        If strSortExpression(0) = e.SortExpression Then

            If strSortExpression(1) = "ASC" Then

                ViewState("SortExpression") = Convert.ToString(e.SortExpression) & " " & "DESC"
            Else

                ViewState("SortExpression") = Convert.ToString(e.SortExpression) & " " & "ASC"
            End If
        Else

            ' If sorting column is another column,  

            ' then specify the sort order to "Ascending".

            ViewState("SortExpression") = Convert.ToString(e.SortExpression) & " " & "ASC"

        End If

        ' Rebind the GridView control to show sorted data.

        BindGridRapat()

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            GridViewRapat.AllowPaging = True
            GridViewRapat.PageSize = 15
            GridViewRapat.AllowSorting = True
            ViewState("SortExpression") = "nopek ASC"
            BindGridRapat()
        End If
    End Sub

    'Protected Sub LinkButtonBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButtonBack.Click
    '    Response.Redirect("~/Notulis/NForm1.aspx")
    'End Sub

    Protected Sub lnktindak_Click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect("~/Notulis/TindakLanjut.aspx")
    End Sub
End Class
