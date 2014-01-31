Imports System
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Imports System.Web.UI.WebControls

Partial Class Notulis_Hadir
    Inherits System.Web.UI.Page

    Protected Sub SaveButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        If DateTextBox.Text <> Nothing Then
            If FileUploadHadir.HasFile Then
                FileHadir()
            End If
        End If

        BindGridHadir()
    End Sub

    Protected Sub FileHadir()
        Dim tanggal As DateTime = DateTime.Parse(DateTextBox.Text)
        Dim filename As String = Path.GetFileName(FileUploadHadir.PostedFile.FileName)
        Dim str As Stream = FileUploadHadir.PostedFile.InputStream
        Dim br As New BinaryReader(str)
        Dim size As [Byte]() = br.ReadBytes(CInt(str.Length))
        FileUploadHadir.SaveAs(Server.MapPath("~/File/" & filename))
        Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
            con.Open()
            Using cmd As New SqlCommand()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "SPINSERTHADIR"
                cmd.Parameters.AddWithValue("@DATE", tanggal)
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
        DateTextBox.Text = Calendar1.SelectedDate.ToString()
    End Sub

    Private Sub BindGridHadir()
        Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
            con.Open()
            Dim cmd As New SqlCommand("SELECT * FROM hadir", con)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            da.Fill(ds)
            con.Close()
            GridViewHadir.DataSource = ds
            GridViewHadir.DataBind()
            con.Close()
        End Using
    End Sub

    'Protected Sub lnkDownload_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim lnkbtn As LinkButton = TryCast(sender, LinkButton)
    '    Dim gvrow As GridViewRow = TryCast(lnkbtn.NamingContainer, GridViewRow)
    '    Dim id As Integer = GridViewHadir.DataKeys(gvrow.RowIndex).Value.ToString()
    '    Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
    '        Using cmd As New SqlCommand()
    '            cmd.CommandText = "SELECT filename, filetype, filedata FROM hadir WHERE id=@ID"
    '            cmd.Parameters.AddWithValue("@ID", id)
    '            cmd.Connection = con
    '            con.Open()
    '            Dim dr As SqlDataReader = cmd.ExecuteReader()
    '            If dr.Read() Then
    '                Response.ContentType = dr("filetype").ToString()
    '                Response.AddHeader("Content-Disposition", "attachment;filename=""" & Convert.ToString(dr("filename")) & """")
    '                Response.BinaryWrite(DirectCast(dr("filedata"), Byte()))
    '                Response.[End]()
    '            End If
    '        End Using
    '    End Using
    'End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            BindGridHadir()
        End If
    End Sub

    Protected Sub lnkAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect("~/Notulis/GridViewPekerja.aspx")
    End Sub

    Protected Sub lnkTambah_Click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect("~/Notulis/GridViewNonPekerja.aspx")
    End Sub

End Class
