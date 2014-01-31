Imports System.Data.SqlClient
Imports System.Data

Partial Class Notulis_GridViewPekerja
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            GridViewPek.AllowPaging = True
            GridViewPek.PageSize = 15
            GridViewPek.AllowSorting = True
            ViewState("SortExpression") = "nopek ASC"
            BindGridviewData3()
        End If

    End Sub

    Private Sub BindGridviewData3()
        Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
            Dim ds As New DataSet()
            Dim cmd As New SqlCommand("select * from pekerja", con)
            Dim da As New SqlDataAdapter(cmd)
            con.Open()
            da.Fill(ds, "pekerja")
            Dim dvpek As DataView = ds.Tables("pekerja").DefaultView
            dvpek.Sort = ViewState("SortExpression").ToString()
            con.Close()
            GridViewPek.DataSource = dvpek
            GridViewPek.DataBind()
        End Using
    End Sub

    ' GridView.RowDataBound Event 
    Protected Sub gvpek_RowDataBound(ByVal sender As Object, ByVal e As GridViewRowEventArgs)

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
    Protected Sub gvpek_PageIndexChanging(ByVal sender As Object, ByVal e As GridViewPageEventArgs)
        GridViewPek.PageIndex = e.NewPageIndex
        BindGridviewData3()
    End Sub

    ' GridView.RowEditing Event 
    Protected Sub gvpek_RowEditing(ByVal sender As Object, ByVal e As GridViewEditEventArgs)

        GridViewPek.EditIndex = e.NewEditIndex

        BindGridviewData3()

        lbtnAdd.Visible = False
    End Sub

    ' GridView.RowCancelingEdit Event 
    Protected Sub gvpek_RowCancelingEdit(ByVal sender As Object, ByVal e As GridViewCancelEditEventArgs)

        GridViewPek.EditIndex = -1

        BindGridviewData3()

        lbtnAdd.Visible = True
    End Sub

    ' GridView.RowUpdating Event 
    Protected Sub gvpek_RowUpdating(ByVal sender As Object, ByVal e As GridViewUpdateEventArgs)
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
            'Create a command object. 
            Dim cmd As New SqlCommand()
            cmd.Connection = conn
            cmd.CommandText = "SPUPDATEPEK"
            cmd.CommandType = CommandType.StoredProcedure

            Dim strnopek As String = GridViewPek.Rows(e.RowIndex).Cells(1).Text()
            Dim strid As String = DirectCast(GridViewPek.Rows(e.RowIndex).FindControl("TextBox1"), TextBox).Text
            Dim strnamapek As String = DirectCast(GridViewPek.Rows(e.RowIndex).FindControl("TextBox2"), TextBox).Text
            Dim strjabatan As String = DirectCast(GridViewPek.Rows(e.RowIndex).FindControl("TextBox3"), TextBox).Text
            Dim stremail As String = DirectCast(GridViewPek.Rows(e.RowIndex).FindControl("TextBox4"), TextBox).Text

            cmd.Parameters.Add("@NOPEK", SqlDbType.VarChar).Value = strnopek
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = strid
            cmd.Parameters.Add("@NAMAPEK", SqlDbType.VarChar, 100).Value = strnamapek
            cmd.Parameters.Add("@JABATAN", SqlDbType.VarChar, 100).Value = strjabatan
            cmd.Parameters.Add("@EMAILADD", SqlDbType.VarChar, 100).Value = stremail

            conn.Open()

            cmd.ExecuteNonQuery()
        End Using

        GridViewPek.EditIndex = -1

        BindGridviewData3()

        lbtnAdd.Visible = True
    End Sub

    ' GridView.RowDeleting Event 
    Protected Sub gvpek_RowDeleting(ByVal sender As Object, ByVal e As GridViewDeleteEventArgs)
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
            ' Create a command object. 
            Dim cmd As New SqlCommand()


            ' Assign the connection to the command. 
            cmd.Connection = conn


            ' Set the command text 
            ' SQL statement or the name of the stored procedure  
            cmd.CommandText = "DELETE FROM pekerja WHERE nopek= @NOPEK"


            ' Set the command type 
            ' CommandType.Text for ordinary SQL statements;  
            ' CommandType.StoredProcedure for stored procedures. 
            cmd.CommandType = CommandType.Text


            ' Get the PersonID of the selected row. 
            Dim strnopek As String = GridViewPek.Rows(e.RowIndex).Cells(2).Text


            ' Append the parameter. 
            cmd.Parameters.Add("@NOPEK", SqlDbType.NVarChar).Value = strnopek


            ' Open the connection. 
            conn.Open()


            ' Execute the command. 
            cmd.ExecuteNonQuery()
        End Using


        ' Rebind the GridView control to show data after deleting. 
        BindGridviewData3()
    End Sub

    Protected Sub gvpek_Sorting(ByVal sender As Object, ByVal e As GridViewSortEventArgs)

        Dim strSortExpression As String() = ViewState("SortExpression").ToString().Split(" "c)



        ' If the sorting column is the same as the previous one, 

        ' then change the sort order.

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

        BindGridviewData3()

    End Sub

    Protected Sub lbtnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbtnAdd.Click
        'Hide the Add button and showing Add panel. 
        lbtnAdd.Visible = False
        pnlAdd.Visible = True
    End Sub

    Protected Sub lbtnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs)
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString) 
            Dim cmd As New SqlCommand()
            cmd.Connection = conn
            cmd.CommandText = "SPINSERTPEK"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@NOPEK", SqlDbType.NVarChar, 50).Value = tbnopek.Text
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tbid.Text
            cmd.Parameters.Add("@NAMAPEK", SqlDbType.VarChar, 100).Value = tbnamapek.Text
            cmd.Parameters.Add("@JABATAN", SqlDbType.VarChar, 100).Value = tbjabatan.Text
            cmd.Parameters.Add("@EMAILADD", SqlDbType.VarChar, 100).Value = tbemail_address.Text
            conn.Open()
            cmd.ExecuteNonQuery()
        End Using

        BindGridviewData3()

        ' Empty the TextBox controls
        tbnopek.Text = String.Empty
        tbnamapek.Text = String.Empty
        tbjabatan.Text = String.Empty
        tbemail_address.Text = String.Empty

        ' Show the Add button and hiding the Add panel
        lbtnAdd.Visible = True
        pnlAdd.Visible = False
    End Sub


    Protected Sub lbtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Empty the TextBox controls. 
        tbnopek.Text = String.Empty
        tbid.Text = String.Empty
        tbnamapek.Text = String.Empty
        tbjabatan.Text = String.Empty
        tbemail_address.Text = String.Empty

        ' Show the Add button and hiding the Add panel. 
        lbtnAdd.Visible = True
        pnlAdd.Visible = False
    End Sub
End Class
