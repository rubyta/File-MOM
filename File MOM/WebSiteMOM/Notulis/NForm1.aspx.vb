Imports System
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data

Partial Class Notulis_NForm1
    Inherits System.Web.UI.Page

    Protected Sub SaveButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Dim ObjClassMOM As New ClassMOM

        Try
            'check all data input

            If TglTextBox.Text <> "" Then
                'ObjClassMOM.Tanggal = DateTime.Parse(TglTextBox.Text)
                If PerihalTextBox.Text <> "" Then
                    'ObjClassMOM.Perihal = PerihalTextBox.Text
                    If PimpinanRapatTextBox.Text <> "" Then
                        'ObjClassMOM.Pimpinan = PimpinanRapatTextBox.Text
                        If NotulisTextBox.Text <> "" Then
                            'ObjClassMOM.Notulis = NotulisTextBox.Text
                            If NoRuanganDropDownList.SelectedValue <> "" Then
                                If FileUpload1.HasFile Then
                                    'ObjClassMOM.Ruangan = ddl
                                    'ObjClassMOM.showrapat()
                                    'ObjClassMOM.Tanggal = DateTime.Parse(TglTextBox.Text)
                                    'ObjClassMOM.Perihal = PerihalTextBox.Text
                                    'ObjClassMOM.Pimpinan = PimpinanRapatTextBox.Text
                                    'ObjClassMOM.TindakLanjut = TindakLanjutTextBox.Text
                                    'ObjClassMOM.Ruangan = ddl
                                    'ObjClassMOM.insertrapat()
                                    Insertrapat()
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                'show message to user if user doesn't input data
                MsgBox("Please input a text!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

        'clear all text boxes
        With TglTextBox
            .Text = String.Empty
            .Focus()
        End With
        PerihalTextBox.Text = String.Empty
        PimpinanRapatTextBox.Text = String.Empty
        NotulisTextBox.Text = String.Empty
    End Sub

    Protected Sub Insertrapat()
        Dim tanggal As DateTime = DateTime.Parse(TglTextBox.Text)
        Dim perihal As String = PerihalTextBox.Text
        Dim pimpinan As String = PimpinanRapatTextBox.Text
        Dim notulis As String = NotulisTextBox.Text
        Dim noruang As String = NoRuanganDropDownList.SelectedValue
        Dim filename As String = Path.GetFileName(FileUpload1.PostedFile.FileName)
        Dim str As Stream = FileUpload1.PostedFile.InputStream
        Dim br As New BinaryReader(str)
        Dim size As [Byte]() = br.ReadBytes(CInt(str.Length))
        FileUpload1.SaveAs(Server.MapPath("~/File/") & filename)
        Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
            con.Open()
            Using cmd As New SqlCommand()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SPINSERTRAPAT"
                cmd.Parameters.AddWithValue("@TANGGAL", tanggal)
                cmd.Parameters.AddWithValue("@PERIHAL", perihal)
                cmd.Parameters.AddWithValue("@PIMPINAN", pimpinan)
                cmd.Parameters.AddWithValue("@NOTULIS", notulis)
                cmd.Parameters.AddWithValue("@NORUANGAN", noruang)
                cmd.Parameters.AddWithValue("@FILENAME", filename)
                cmd.Parameters.AddWithValue("@FILETYPE", "apllication/pdf")
                cmd.Parameters.AddWithValue("@FILEDATA", size)
                cmd.Parameters.AddWithValue("@FILEPATH", "~/File/" + filename)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
    End Sub

    Protected Sub CancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        'Clear all input
        TglTextBox.Text = String.Empty
        PerihalTextBox.Text = String.Empty
        PimpinanRapatTextBox.Text = String.Empty
        NotulisTextBox.Text = String.Empty
        'PICTextBox.Text = String.Empty
        'TindakLanjutTextBox.Text = String.Empty

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Binddropdown()
        End If

    End Sub

    ''Bind Gridview Data
    'Private Sub BindGridRapat()
    '    con.Open()
    '    Dim cmd As New SqlCommand("select* from rapat", con)
    '    cmd.ExecuteNonQuery()
    '    Dim da As New SqlDataAdapter(cmd)
    '    Dim ds As New DataSet()
    '    da.Fill(ds)
    '    GridViewRapat.DataSource = ds
    '    GridViewRapat.DataBind()
    '    con.Close()
    'End Sub
    '' GridView.RowDataBound Event 
    'Protected Sub gvrapat_RowDataBound(ByVal sender As Object, ByVal e As GridViewRowEventArgs)

    '    If e.Row.RowType = DataControlRowType.DataRow Then
    '        'Make sure the current GridViewRow is either  
    '        'in the normal state or an alternate row. 
    '        If e.Row.RowState = DataControlRowState.Normal OrElse e.Row.RowState = DataControlRowState.Alternate Then
    '            'Add client-side confirmation when deleting. 
    '            'DirectCast(e.Row.Cells(1).Controls(0), LinkButton).Attributes("onclick") = "if(!confirm('Are you certain you want to delete it?')) return false;"
    '        End If
    '    End If
    'End Sub

    '' GridView.PageIndexChanging Event 
    'Protected Sub gvrapat_PageIndexChanging(ByVal sender As Object, ByVal e As GridViewPageEventArgs)
    '    GridViewRapat.PageIndex = e.NewPageIndex
    '    BindGridRapat()
    'End Sub

    '' GridView.RowEditing Event 
    'Protected Sub gvrapat_RowEditing(ByVal sender As Object, ByVal e As GridViewEditEventArgs)

    '    GridViewRapat.EditIndex = e.NewEditIndex

    '    BindGridRapat()

    'End Sub

    '' GridView.RowCancelingEdit Event 
    'Protected Sub gvrapat_RowCancelingEdit(ByVal sender As Object, ByVal e As GridViewCancelEditEventArgs)

    '    GridViewRapat.EditIndex = -1

    '    BindGridRapat()
    'End Sub

    '' GridView.RowUpdating Event 
    'Protected Sub gvrapat_RowUpdating(ByVal sender As Object, ByVal e As GridViewUpdateEventArgs)
    '    Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
    '        'Create a command object. 
    '        Dim cmd As New SqlCommand()
    '        cmd.Connection = conn
    '        cmd.CommandText = "SPUPDATERAPAT"
    '        cmd.CommandType = CommandType.StoredProcedure

    '        Dim strtanggal As String = DirectCast(GridViewRapat.Rows(e.RowIndex).FindControl("TextBox1"), TextBox).Text
    '        Dim strperihal As String = DirectCast(GridViewRapat.Rows(e.RowIndex).FindControl("TextBox2"), TextBox).Text
    '        Dim strtindak As String = DirectCast(GridViewRapat.Rows(e.RowIndex).FindControl("TextBox3"), TextBox).Text
    '        Dim strpimpinan As String = DirectCast(GridViewRapat.Rows(e.RowIndex).FindControl("TextBox4"), TextBox).Text
    '        Dim strnotulis As String = DirectCast(GridViewRapat.Rows(e.RowIndex).FindControl("TextBox5"), TextBox).Text
    '        Dim strpic As String = DirectCast(GridViewRapat.Rows(e.RowIndex).FindControl("TextBox6"), TextBox).Text
    '        Dim strruang As String = DirectCast(GridViewRapat.Rows(e.RowIndex).FindControl("TextBox7"), TextBox).Text

    '        cmd.Parameters.Add("@TANGGAL", SqlDbType.VarChar, 100).Value = strtanggal
    '        cmd.Parameters.Add("@PERIHAL", SqlDbType.VarChar, 100).Value = strperihal
    '        cmd.Parameters.Add("@TINDAK_LANJUT", SqlDbType.VarChar, 50).Value = strtindak
    '        cmd.Parameters.Add("@PIC", SqlDbType.VarChar, 100).Value = strpic
    '        cmd.Parameters.Add("@PIMPINAN", SqlDbType.VarChar, 100).Value = strpimpinan
    '        cmd.Parameters.Add("@NOTULIS", SqlDbType.VarChar, 100).Value = strnotulis
    '        cmd.Parameters.Add("@NORUANGAN", SqlDbType.VarChar, 100).Value = strruang
    '        conn.Open()

    '        cmd.ExecuteNonQuery()
    '    End Using

    '    GridViewRapat.EditIndex = -1

    '    BindGridRapat()

    'End Sub

    '' GridView.RowDeleting Event 
    'Protected Sub gvrapat_RowDeleting(ByVal sender As Object, ByVal e As GridViewDeleteEventArgs)
    '    Using conn As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
    '        ' Create a command object. 
    '        Dim cmd As New SqlCommand()


    '        ' Assign the connection to the command. 
    '        cmd.Connection = conn

    '        ' Set the command text  
    '        cmd.CommandText = "SPDELETERAPAT"

    '        ' Set the command type 
    '        cmd.CommandType = CommandType.StoredProcedure


    '        ' Get the PersonID of the selected row. 
    '        Dim strnorapat As String = GridViewRapat.Rows(e.RowIndex).Cells(2).Text

    '        ' Append the parameter. 
    '        cmd.Parameters.Add("@NORAPAT", SqlDbType.Int).Value = strnorapat

    '        ' Open the connection. 
    '        conn.Open()

    '        ' Execute the command. 
    '        cmd.ExecuteNonQuery()
    '    End Using

    '    ' Rebind the GridView control to show data after deleting. 
    '    BindGridRapat()
    'End Sub

    'Protected Sub gvrapat_Sorting(ByVal sender As Object, ByVal e As GridViewSortEventArgs)

    '    Dim strSortExpression As String() = ViewState("SortExpression").ToString().Split(" "c)

    '    ' If the sorting column is the same as the previous one, then change the sort order.

    '    If strSortExpression(0) = e.SortExpression Then

    '        If strSortExpression(1) = "ASC" Then

    '            ViewState("SortExpression") = Convert.ToString(e.SortExpression) & " " & "DESC"
    '        Else

    '            ViewState("SortExpression") = Convert.ToString(e.SortExpression) & " " & "ASC"
    '        End If
    '    Else

    '        ' If sorting column is another column,  

    '        ' then specify the sort order to "Ascending".

    '        ViewState("SortExpression") = Convert.ToString(e.SortExpression) & " " & "ASC"

    '    End If

    '    ' Rebind the GridView control to show sorted data.

    '    BindGridRapat()

    'End Sub

    Protected Sub Binddropdown()
        'conenction path for database
        Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("Select no_ruangan FROM ruangan", con)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)
            NoRuanganDropDownList.DataSource = ds
            NoRuanganDropDownList.DataTextField = "no_ruangan"
            NoRuanganDropDownList.DataValueField = "no_ruangan"
            NoRuanganDropDownList.DataBind()
            NoRuanganDropDownList.Items.Insert(0, New ListItem("--Select--", "0"))
            con.Close()
        End Using
    End Sub

    

    'Protected Sub ViewButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ViewButton.Click
    '    If DropDownList1.SelectedValue = "rapat" Then
    '        Response.Redirect("~/Notulis/Rapat.aspx")
    '    ElseIf DropDownList1.SelectedValue = "pekerja" Then
    '        Response.Redirect("~/Notulis/GridViewPekerja.aspx")
    '    ElseIf DropDownList1.SelectedValue = "non_pekerja" Then
    '        Response.Redirect("~/Notulis/GridViewNonPekerja.aspx")
    '    End If
    'End Sub

    Protected Sub Calendar1_DayRender(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DayRenderEventArgs) Handles Calendar1.DayRender
        If e.Day.Date = DateTime.Now.ToString("d") Then
            e.Cell.BackColor = System.Drawing.Color.LightGray
        End If
    End Sub

    Protected Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        Dim strjscript As String = "<script language=""javascript"">"
        strjscript &= "window.opener." & _
              HttpContext.Current.Request.QueryString("formname") & ".value = '" & _
              Calendar1.SelectedDate & "';window.close();"
        strjscript = strjscript & "</script" & ">"

        Literal1.Text = strjscript
        TglTextBox.Text = Calendar1.SelectedDate.ToString()
    End Sub

    'Protected Sub HadirLinkButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HadirLinkButton.Click
    '    Response.Redirect("~/Notulis/Hadir.aspx")
    'End Sub

End Class
