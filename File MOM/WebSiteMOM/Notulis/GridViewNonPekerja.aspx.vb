Imports System.Data.SqlClient
Imports System.Data


Partial Class Notulis_GridViewNonPekerja
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            GridViewNonPek.AllowPaging = True
            GridViewNonPek.PageSize = 15
            GridViewNonPek.AllowSorting = True
            ViewState("SortExpression") = "id_non_pekerja ASC"
            BindGridviewData2()
        End If

    End Sub

    Private Sub BindGridviewData2()
        Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
            Dim ds As New DataSet()
            Dim cmd As New SqlCommand("select * from non_pekerja ", con)
            Dim da As New SqlDataAdapter(cmd)
            con.Open()
            da.Fill(ds, "non_pekerja")
            Dim dvnonpek As DataView = ds.Tables("non_pekerja").DefaultView
            dvnonpek.Sort = ViewState("SortExpression").ToString()
            con.Close()
            GridViewNonPek.DataSource = dvnonpek
            GridViewNonPek.DataBind()
        End Using   
    End Sub

    ' GridView.RowDataBound Event 
    Protected Sub gv1_RowDataBound(ByVal sender As Object, ByVal e As GridViewRowEventArgs)
        '     Make sure the current GridViewRow is a data row. 
        If e.Row.RowType = DataControlRowType.DataRow Then
            'Make sure the current GridViewRow is either  
            'in the normal state or an alternate row. 
            If e.Row.RowState = DataControlRowState.Normal OrElse e.Row.RowState = DataControlRowState.Alternate Then
                'Add client-side confirmation when deleting. 
                'DirectCast(e.Row.Cells(1).Controls(0), LinkButton).Attributes("onclick") = "if(!confirm('Are you certain you want to delete this person ?')) return false;"
            End If
        End If
    End Sub

    ' GridView.PageIndexChanging Event 
    Protected Sub gv1_PageIndexChanging(ByVal sender As Object, ByVal e As GridViewPageEventArgs)
        GridViewNonPek.PageIndex = e.NewPageIndex
        BindGridviewData2()
    End Sub

    Protected Sub gv1_RowEditing(ByVal sender As Object, ByVal e As GridViewEditEventArgs)

        GridViewNonPek.EditIndex = e.NewEditIndex

        BindGridviewData2()

        lbtnAdd.Visible = False
    End Sub

    ' GridView.RowCancelingEdit Event 
    Protected Sub gv1_RowCancelingEdit(ByVal sender As Object, ByVal e As GridViewCancelEditEventArgs)
        '     Exit edit mode. 
        GridViewNonPek.EditIndex = -1


        '     Rebind the GridView control to show data in view mode. 
        BindGridviewData2()


        '     Show the Add button. 
        lbtnAdd.Visible = True
    End Sub

    ' GridView.RowUpdating Event 
    Protected Sub gv1_RowUpdating(ByVal sender As Object, ByVal e As GridViewUpdateEventArgs)
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
            'Create a command object. 
            Dim cmd As New SqlCommand()


            ' Assign the connection to the command. 
            cmd.Connection = conn


            'Set the command text 
            'SQL statement or the name of the stored procedure  
            cmd.CommandText = "SPUPDATENONPEK"


            'Set the command type 
            'CommandType.Text for ordinary SQL statements;  
            'CommandType.StoredProcedure for stored procedures. 
            cmd.CommandType = CommandType.StoredProcedure


            'Get the PersonID of the selected row. 
            Dim strID As String = GridViewNonPek.Rows(e.RowIndex).Cells(2).Text
            Dim strNama As String = DirectCast(GridViewNonPek.Rows(e.RowIndex).FindControl("TextBox1"), TextBox).Text
            Dim strJabatan As String = DirectCast(GridViewNonPek.Rows(e.RowIndex).FindControl("TextBox2"), TextBox).Text
            Dim strInstansi As String = DirectCast(GridViewNonPek.Rows(e.RowIndex).FindControl("TextBox3"), TextBox).Text


            'Append the parameters
            cmd.Parameters.Add("@IDNONPEK", SqlDbType.Int).Value = strID
            cmd.Parameters.Add("@NAMA", SqlDbType.VarChar, 50).Value = strNama
            cmd.Parameters.Add("@INSTANSI", SqlDbType.VarChar, 50).Value = strJabatan
            cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar, 50).Value = strInstansi


            '         Open the connection. 
            conn.Open()


            '         Execute the command. 
            cmd.ExecuteNonQuery()
        End Using


        '     Exit edit mode. 
        GridViewNonPek.EditIndex = -1


        '     Rebind the GridView control to show data after updating. 
        BindGridviewData2()


        '     Show the Add button. 
        lbtnAdd.Visible = True
    End Sub

    ' GridView.RowDeleting Event 
    Protected Sub gv1_RowDeleting(ByVal sender As Object, ByVal e As GridViewDeleteEventArgs)
        Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
            ' Create a command object. 
            Dim cmd As New SqlCommand()

            ' Assign the connection to the command. 
            cmd.Connection = con


            ' Set the command text 
            ' SQL statement or the name of the stored procedure  
            cmd.CommandText = "DELETE FROM non_pekerja WHERE id_non_pekerja= @IDNONPEK"


            ' Set the command type 
            ' CommandType.Text for ordinary SQL statements;  
            ' CommandType.StoredProcedure for stored procedures. 
            cmd.CommandType = CommandType.Text


            ' Get the PersonID of the selected row. 
            Dim strID As String = GridViewNonPek.Rows(e.RowIndex).Cells(2).Text


            ' Append the parameter. 
            cmd.Parameters.Add("@IDNONPEK", SqlDbType.NVarChar).Value = strID


            ' Open the connection. 
            con.Open()


            ' Execute the command. 
            cmd.ExecuteNonQuery()
        End Using


        ' Rebind the GridView control to show data after deleting. 
        BindGridviewData2()
    End Sub

    Protected Sub gv1_Sorting(ByVal sender As Object, ByVal e As GridViewSortEventArgs)

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
    End Sub

    Protected Sub lbtnAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Hide the Add button and showing Add panel. 
        lbtnAdd.Visible = False
        pnlAdd.Visible = True
    End Sub

    Protected Sub lbtnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs)
        Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
            ' Create a command object. 
            Dim cmd As New SqlCommand()


            ' Assign the connection to the command. 
            cmd.Connection = conn


            ' Set the command text 
            ' SQL statement or the name of the stored procedure  
            cmd.CommandText = "SPINSERTNONPEK"


            ' Set the command type 
            ' CommandType.Text for ordinary SQL statements;  
            ' CommandType.StoredProcedure for stored procedures. 
            cmd.CommandType = CommandType.StoredProcedure


            ' Append the parameters. 
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tbid.Text
            cmd.Parameters.Add("@NAMA", SqlDbType.NVarChar, 50).Value = tbname.Text
            cmd.Parameters.Add("@INSTANSI", SqlDbType.NVarChar, 50).Value = tbinstansi.Text
            cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar, 50).Value = tbemail_address.Text

            ' Open the connection. 
            conn.Open()


            ' Execute the command. 
            cmd.ExecuteNonQuery()
        End Using


        ' Rebind the GridView control to show inserted data. 
        BindGridviewData2()


        ' Empty the TextBox controls. 
        tbid.Text = String.Empty
        tbname.Text = String.Empty
        tbinstansi.Text = String.Empty
        tbemail_address.Text = String.Empty


        ' Show the Add button and hiding the Add panel. 
        lbtnAdd.Visible = True
        pnlAdd.Visible = False
    End Sub


    Protected Sub lbtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Empty the TextBox controls. 
        tbid.Text = String.Empty
        tbname.Text = String.Empty
        tbinstansi.Text = String.Empty
        tbemail_address.Text = String.Empty


        ' Show the Add button and hiding the Add panel. 
        lbtnAdd.Visible = True
        pnlAdd.Visible = False
    End Sub

    Protected Sub GridViewNonPek_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridViewNonPek.SelectedIndexChanged

    End Sub

End Class
