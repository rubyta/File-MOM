Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Web.UI.WebControls

Partial Class PimpinanRapat_PForm
    Inherits System.Web.UI.Page

    Private con As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            BindGridviewData()
        End If
    End Sub
    ' Bind Gridview Data
    Private Sub BindGridviewData()
        con.Open()
        Dim cmd As New SqlCommand("select * from rapat", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        da.Fill(ds)
        con.Close()
        GridView2.DataSource = ds
        GridView2.DataBind()
    End Sub

    Protected Sub lnkDownload_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim lnkbtn As LinkButton = TryCast(sender, LinkButton)
        Dim gvrow As GridViewRow = TryCast(lnkbtn.NamingContainer, GridViewRow)
        Dim fileid As Integer = GridView2.DataKeys(gvrow.RowIndex).Value.ToString()
        Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
            Using cmd As New SqlCommand()
                cmd.CommandText = "select FileName, FileType, FileData from rapat where no_rapat=@NORAPAT"
                cmd.Parameters.AddWithValue("@NORAPAT", fileid)
                cmd.Connection = con
                con.Open()
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    Response.ContentType = dr("FileType").ToString()
                    Response.AddHeader("Content-Disposition", "attachment;filename=""" & Convert.ToString(dr("FileName")) & """")
                    Response.BinaryWrite(DirectCast(dr("FileData"), Byte()))
                    Response.[End]()
                End If
            End Using
        End Using
    End Sub

    Protected Sub ViewButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ViewButton.Click
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
End Class
