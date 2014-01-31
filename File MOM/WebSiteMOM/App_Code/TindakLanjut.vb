Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Public Class TindakLanjut   

    Private strID As String
    Private strPIC As String
    Private strtindaklanjut As String

    Public Property ID() As String
        Get
            Return strID
        End Get
        Set(ByVal value As String)
            strID = value
        End Set
    End Property

    Public Property PIC() As String
        Get
            Return strPIC
        End Get
        Set(ByVal value As String)
            strPIC = value
        End Set
    End Property

    Public Property tindak_lanjut() As String
        Get
            Return strtindaklanjut
        End Get
        Set(ByVal value As String)
            strtindaklanjut = value
        End Set
    End Property

End Class
