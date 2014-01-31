Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Configuration
Imports System.IO
Imports System.Web.UI.WebControls

Public Class ClassMOM
    'Private _Nopek As String
    Private _Password As String
    'Private _Tanggal As DateTime
    'Private _Perihal As String
    'Private _Pimpinan As String
    'Private _PIC As String
    Private _Ruangan As String
    'Private _Lantai As Integer
    'Private _Lokasi As String
    'Private _Namapek As String
    'Private _Nama As String
    'Private _Jabatan As String
    Private _EmailAdd As String
    Private _EmailAdd2 As String
    'Private _Instansi As String
    'Private _Notulis As String
    'Private _TindakLanjut As String
    Private _id As Integer
    Private _no As Integer

    'Public Property Nopek() As String
    '    Get
    '        Return _Nopek
    '    End Get
    '    Set(ByVal value As String)
    '        _Nopek = value
    '    End Set
    'End Property

    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
        End Set
    End Property

    'Public Property Tanggal() As DateTime
    '    Get
    '        Return _Tanggal
    '    End Get
    '    Set(ByVal value As DateTime)
    '        _Tanggal = value
    '    End Set
    'End Property

    'Public Property Perihal() As String
    '    Get
    '        Return _Perihal
    '    End Get
    '    Set(ByVal value As String)
    '        _Perihal = value
    '    End Set
    'End Property

    'Public Property Pimpinan() As String
    '    Get
    '        Return _Pimpinan
    '    End Get
    '    Set(ByVal value As String)
    '        _Pimpinan = value
    '    End Set
    'End Property

    'Public Property PIC() As String
    '    Get
    '        Return _PIC
    '    End Get
    '    Set(ByVal value As String)
    '        _PIC = value
    '    End Set
    'End Property
    Public Property Ruangan() As String
        Get
            Return _Ruangan
        End Get
        Set(ByVal value As String)
            _Ruangan = value
        End Set
    End Property

    'Public Property Lantai() As Integer
    '    Get
    '        Return _Lantai
    '    End Get
    '    Set(ByVal value As Integer)
    '        _Lantai = value
    '    End Set
    'End Property

    'Public Property Lokasi() As String
    '    Get
    '        Return _Lokasi
    '    End Get
    '    Set(ByVal value As String)
    '        _Lokasi = value
    '    End Set
    'End Property

    'Public Property Namapek() As String
    '    Get
    '        Return _Namapek
    '    End Get
    '    Set(ByVal value As String)
    '        _Namapek = value
    '    End Set
    'End Property

    'Public Property Nama() As String
    '    Get
    '        Return _Nama
    '    End Get
    '    Set(ByVal value As String)
    '        _Nama = value
    '    End Set
    'End Property

    'Public Property Jabatan() As String
    '    Get
    '        Return _Jabatan
    '    End Get
    '    Set(ByVal value As String)
    '        _Jabatan = value
    '    End Set
    'End Property

    Public Property EmailAdd() As String
        Get
            Return _EmailAdd
        End Get
        Set(ByVal value As String)
            _EmailAdd = value
        End Set
    End Property

    Public Property EmailAdd2() As String
        Get
            Return _EmailAdd2
        End Get
        Set(ByVal value As String)
            _EmailAdd2 = value
        End Set
    End Property

    'Public Property Instansi() As String
    '    Get
    '        Return _Instansi
    '    End Get
    '    Set(ByVal value As String)
    '        _Instansi = value
    '    End Set
    'End Property

    'Public Property Notulis() As String
    '    Get
    '        Return _Notulis
    '    End Get
    '    Set(ByVal value As String)
    '        _Notulis = value
    '    End Set
    'End Property

    Public Property User() As String
        Get
            Return _EmailAdd
        End Get
        Set(ByVal value As String)
            _EmailAdd = value
        End Set
    End Property

    'Public Property TindakLanjut() As String
    '    Get
    '        Return _TindakLanjut
    '    End Get
    '    Set(ByVal value As String)
    '        _TindakLanjut = value
    '    End Set
    'End Property

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property no() As Integer
        Get
            Return _no
        End Get
        Set(ByVal value As Integer)
            _no = value
        End Set
    End Property

    Public Function GetConnection() As SqlConnection
        Dim con As New SqlConnection(WebConfigurationManager.ConnectionStrings("WebConnectionString").ConnectionString)
        Return con
    End Function

    '--------------------------------INSERT PROCEDURE ------------------------------------
    'Public Sub insertrapat()
    '    Try
    '        Dim Dt As New DataTable
    '        Dim SqlConn As New SqlConnection
    '        Dim SqlComm As New SqlCommand
    '        'Dim SqlDataR As SqlDataReader
    '        SqlConn = GetConnection()
    '        SqlConn.Open()
    '        SqlComm.Connection = SqlConn
    '        SqlComm.CommandType = CommandType.StoredProcedure
    '        SqlComm.CommandText = "SPINSERTRAPAT"
    '        SqlComm.Parameters.Add("@TANGGAL", _Tanggal)
    '        SqlComm.Parameters.Add("@PERIHAL", _Perihal)
    '        SqlComm.Parameters.Add("@PIMPINAN", _Pimpinan)
    '        SqlComm.Parameters.Add("@NOTULIS", _Notulis)
    '        SqlComm.Parameters.Add("@PIC", _PIC)
    '        SqlComm.Parameters.Add("@TINDAK_LANJUT", _TindakLanjut)
    '        SqlComm.Parameters.Add("@NORUANGAN", _Ruangan)
    '        SqlComm.CommandTimeout = 0
    '        SqlComm.ExecuteNonQuery()
    '        'SqlDataR = SqlComm.ExecuteReader()
    '        'Dt.Load(SqlDataR)
    '        'SqlDataR.Close()
    '        SqlConn.Close()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    'Public Sub insertpek()
    '    Try
    '        Dim Dt As New DataTable
    '        Dim SqlConn As New SqlConnection
    '        Dim SqlComm As New SqlCommand
    '        'Dim SqlDataR As SqlDataReader
    '        SqlConn = GetConnection()
    '        SqlConn.Open()
    '        SqlComm.Connection = SqlConn
    '        SqlComm.CommandType = CommandType.StoredProcedure
    '        SqlComm.CommandText = "SPINSERTPEK"
    '        SqlComm.Parameters.Add("@NOPEK", _Nopek)
    '        SqlComm.Parameters.Add("@NAMAPEK", _Namapek)
    '        SqlComm.Parameters.Add("@JABATAN", _Jabatan)
    '        SqlComm.Parameters.Add("@EMAILADD", _EmailAdd)
    '        SqlComm.CommandTimeout = 0
    '        SqlComm.ExecuteNonQuery()
    '        'SqlDataR = SqlComm.ExecuteReader()
    '        'Dt.Load(SqlDataR)
    '        'SqlDataR.Close()
    '        SqlConn.Close()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    'Public Sub insertnonpekerja()
    '    Try
    '        Dim Dt As New DataTable
    '        Dim SqlConn As New SqlConnection
    '        Dim SqlComm As New SqlCommand
    '        'Dim SqlDataR As SqlDataReader
    '        SqlConn = GetConnection()
    '        SqlConn.Open()
    '        SqlComm.Connection = SqlConn
    '        SqlComm.CommandType = CommandType.StoredProcedure
    '        SqlComm.CommandText = "SPINSERTNONPEK"
    '        SqlComm.Parameters.Add("@NAMA", _Nama)
    '        SqlComm.Parameters.Add("@INSTANSI ", _Instansi)
    '        SqlComm.Parameters.Add("@EMAIL", _EmailAdd2)
    '        SqlComm.CommandTimeout = 0
    '        SqlComm.ExecuteNonQuery()
    '        'SqlDataR = SqlComm.ExecuteReader()
    '        'Dt.Load(SqlDataR)
    '        'SqlDataR.Close()
    '        SqlConn.Close()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    'Public Sub insertruangan()
    '    Try
    '        Dim Dt As New DataTable
    '        Dim SqlConn As New SqlConnection
    '        Dim SqlComm As New SqlCommand
    '        'Dim SqlDataR As SqlDataReader
    '        SqlConn = GetConnection()
    '        SqlConn.Open()
    '        SqlComm.Connection = SqlConn
    '        SqlComm.CommandType = CommandType.StoredProcedure
    '        SqlComm.CommandText = "SPINSERTRUANGAN"
    '        SqlComm.Parameters.Add("@NORUANGAN", _Ruangan)
    '        SqlComm.Parameters.Add("@NOLANTAI ", _Lantai)
    '        SqlComm.Parameters.Add("@LOKASI", _Lokasi)
    '        SqlComm.CommandTimeout = 0
    '        SqlComm.ExecuteNonQuery()
    '        'SqlDataR = SqlComm.ExecuteReader()
    '        'Dt.Load(SqlDataR)
    '        'SqlDataR.Close()
    '        SqlConn.Close()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    Public Sub insertuser()
        Try
            Dim Dt As New DataTable
            Dim SqlConn As New SqlConnection
            Dim SqlComm As New SqlCommand
            'Dim SqlDataR As SqlDataReader
            SqlConn = GetConnection()
            SqlConn.Open()
            SqlComm.Connection = SqlConn
            SqlComm.CommandType = CommandType.StoredProcedure
            SqlComm.CommandText = "SPINSERTUSER"
            SqlComm.Parameters.Add("@EMAIL", _EmailAdd)
            SqlComm.Parameters.Add("@PWORD", _Password)
            SqlComm.CommandTimeout = 0
            SqlComm.ExecuteNonQuery()
            'SqlDataR = SqlComm.ExecuteReader()
            'Dt.Load(SqlDataR)
            'SqlDataR.Close()
            SqlConn.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    '--------------------------------UPDATE PROCEDURE ------------------------------------
    'Public Sub updaterapat()
    '    Try
    '        Dim Dt As New DataTable
    '        Dim SqlConn As New SqlConnection
    '        Dim SqlComm As New SqlCommand
    '        'Dim SqlDataR As SqlDataReader
    '        SqlConn = GetConnection()
    '        SqlConn.Open()
    '        SqlComm.Connection = SqlConn
    '        SqlComm.CommandType = CommandType.StoredProcedure
    '        SqlComm.CommandText = "SPUPDATERAPAT"
    '        SqlComm.Parameters.Add("@TANGGAL", _Tanggal)
    '        SqlComm.Parameters.Add("@PERIHAL", _Perihal)
    '        SqlComm.Parameters.Add("@PIMPINAN", _Pimpinan)
    '        SqlComm.Parameters.Add("@NOTULIS", _Notulis)
    '        SqlComm.Parameters.Add("@PIC", _PIC)
    '        SqlComm.Parameters.Add("TINDAK_LANJUT", _TindakLanjut)
    '        SqlComm.Parameters.Add("@NORUANGAN", _Ruangan)
    '        SqlComm.CommandTimeout = 0
    '        SqlComm.ExecuteNonQuery()
    '        'SqlDataR = SqlComm.ExecuteReader()
    '        'Dt.Load(SqlDataR)
    '        'SqlDataR.Close()
    '        SqlConn.Close()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    'Public Sub updatepek()
    '    Try
    '        Dim Dt As New DataTable
    '        Dim SqlConn As New SqlConnection
    '        Dim SqlComm As New SqlCommand
    '        'Dim SqlDataR As SqlDataReader
    '        SqlConn = GetConnection()
    '        SqlConn.Open()
    '        SqlComm.Connection = SqlConn
    '        SqlComm.CommandType = CommandType.StoredProcedure
    '        SqlComm.CommandText = "SPUPDATEPEK"
    '        SqlComm.Parameters.Add("@NOPEK", _Nopek)
    '        SqlComm.Parameters.Add("@NAMAPEK", _Namapek)
    '        SqlComm.Parameters.Add("@JABATAN", _Jabatan)
    '        SqlComm.Parameters.Add("@NOTULIS", _Notulis)
    '        SqlComm.Parameters.Add("@EMAILADD", _EmailAdd)
    '        SqlComm.CommandTimeout = 0
    '        SqlComm.ExecuteNonQuery()
    '        'SqlDataR = SqlComm.ExecuteReader()
    '        'Dt.Load(SqlDataR)
    '        'SqlDataR.Close()
    '        SqlConn.Close()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    'Public Sub updatenonpek()
    '    Try
    '        Dim Dt As New DataTable
    '        Dim SqlConn As New SqlConnection
    '        Dim SqlComm As New SqlCommand
    '        'Dim SqlDataR As SqlDataReader
    '        SqlConn = GetConnection()
    '        SqlConn.Open()
    '        SqlComm.Connection = SqlConn
    '        SqlComm.CommandType = CommandType.StoredProcedure
    '        SqlComm.CommandText = "SPUPDATENONPEK"
    '        SqlComm.Parameters.Add("@NAMA", _Nama)
    '        SqlComm.Parameters.Add("@INSTANSI ", _Instansi)
    '        SqlComm.Parameters.Add("@EMAILADD", _EmailAdd2)
    '        SqlComm.CommandTimeout = 0
    '        SqlComm.ExecuteNonQuery()
    '        'SqlDataR = SqlComm.ExecuteReader()
    '        'Dt.Load(SqlDataR)
    '        'SqlDataR.Close()
    '        SqlConn.Close()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    Public Sub updateuser()
        Try
            Dim Dt As New DataTable
            Dim SqlConn As New SqlConnection
            Dim SqlComm As New SqlCommand
            'Dim SqlDataR As SqlDataReader
            SqlConn = GetConnection()
            SqlConn.Open()
            SqlComm.Connection = SqlConn
            SqlComm.CommandType = CommandType.StoredProcedure
            SqlComm.CommandText = "SPUPDATEUSER"
            SqlComm.Parameters.Add("@EMAIL", _EmailAdd)
            SqlComm.Parameters.Add("@PWORD", _Password)
            SqlComm.CommandTimeout = 0
            SqlComm.ExecuteNonQuery()
            'SqlDataR = SqlComm.ExecuteReader()
            'Dt.Load(SqlDataR)
            'SqlDataR.Close()
            SqlConn.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    'Public Sub updateruangan()
    '    Try
    '        Dim Dt As New DataTable
    '        Dim SqlConn As New SqlConnection
    '        Dim SqlComm As New SqlCommand
    '        'Dim SqlDataR As SqlDataReader
    '        SqlConn = GetConnection()
    '        SqlConn.Open()
    '        SqlComm.Connection = SqlConn
    '        SqlComm.CommandType = CommandType.StoredProcedure
    '        SqlComm.CommandText = "SPUPDATERUANGAN"
    '        SqlComm.Parameters.Add("@NORUANGAN", _Ruangan)
    '        SqlComm.Parameters.Add("@NOLANTAI", _Lantai)
    '        SqlComm.Parameters.Add("@LOKASI", _Lokasi)
    '        SqlComm.CommandTimeout = 0
    '        SqlComm.ExecuteNonQuery()
    '        'SqlDataR = SqlComm.ExecuteReader()
    '        'Dt.Load(SqlDataR)
    '        'SqlDataR.Close()
    '        SqlConn.Close()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    '--------------------------------DELETE PROCEDURE ------------------------------------
    'Public Sub deleterapat()
    '    Dim Dt As New DataTable
    '    Dim SqlConn As New SqlConnection
    '    Dim SqlComm As New SqlCommand
    '    Dim SqlDataR As SqlDataReader
    '    Try
    '        SqlConn = GetConnection()
    '        SqlConn.Open()
    '        SqlComm.Connection = SqlConn
    '        SqlComm.CommandType = CommandType.StoredProcedure
    '        SqlComm.CommandText = "SPDELETERAPAT"
    '        SqlComm.Parameters.Add("@TANGGAl", _Tanggal)
    '        SqlComm.CommandTimeout = 0
    '        SqlComm.ExecuteNonQuery()
    '        SqlDataR = SqlComm.ExecuteReader()
    '        Dt.Load(SqlDataR)
    '        Return
    '        SqlDataR.Close()
    '        SqlConn.Close()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    Public Sub deletepek()
        Dim Dt As New DataTable
        Dim SqlConn As New SqlConnection
        Dim SqlComm As New SqlCommand
        Dim SqlDataR As SqlDataReader
        Try
            SqlConn = GetConnection()
            SqlConn.Open()
            SqlComm.Connection = SqlConn
            SqlComm.CommandType = CommandType.StoredProcedure
            SqlComm.CommandText = "SPDELETERUANGAN"
            SqlComm.Parameters.Add("@NORUANGAN", _Ruangan)
            SqlComm.CommandTimeout = 0
            SqlComm.ExecuteNonQuery()
            SqlDataR = SqlComm.ExecuteReader()
            Dt.Load(SqlDataR)
            Return
            SqlDataR.Close()
            SqlConn.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    'Public Sub deletenonpek()
    '    Dim Dt As New DataTable
    '    Dim SqlConn As New SqlConnection
    '    Dim SqlComm As New SqlCommand
    '    Dim SqlDataR As SqlDataReader
    '    Try
    '        SqlConn = GetConnection()
    '        SqlConn.Open()
    '        SqlComm.Connection = SqlConn
    '        SqlComm.CommandType = CommandType.StoredProcedure
    '        SqlComm.CommandText = "SPDELETENONPEK"
    '        SqlComm.Parameters.Add("@NAMA", _Nama)
    '        SqlComm.CommandTimeout = 0
    '        SqlComm.ExecuteNonQuery()
    '        SqlDataR = SqlComm.ExecuteReader()
    '        Dt.Load(SqlDataR)
    '        Return
    '        SqlDataR.Close()
    '        SqlConn.Close()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    'Public Sub deleteruangan()
    '    Try
    '        Dim Dt As New DataTable
    '        Dim SqlConn As New SqlConnection
    '        Dim SqlComm As New SqlCommand
    '        'Dim SqlDataR As SqlDataReader
    '        SqlConn = GetConnection()
    '        SqlConn.Open()
    '        SqlComm.Connection = SqlConn
    '        SqlComm.CommandType = CommandType.StoredProcedure
    '        SqlComm.CommandText = "SPDELETERUANGAN"
    '        SqlComm.Parameters.Add("@NOLANTAI ", _Lantai)
    '        SqlComm.Parameters.Add("@LOKASI", _Lokasi)
    '        SqlComm.CommandTimeout = 0
    '        SqlComm.ExecuteNonQuery()
    '        'SqlDataR = SqlComm.ExecuteReader()
    '        'Dt.Load(SqlDataR)
    '        'SqlDataR.Close()
    '        SqlConn.Close()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    Public Sub deleteuser()
        Dim Dt As New DataTable
        Dim SqlConn As New SqlConnection
        Dim SqlComm As New SqlCommand
        Dim SqlDataR As SqlDataReader
        Try
            SqlConn = GetConnection()
            SqlConn.Open()
            SqlComm.Connection = SqlConn
            SqlComm.CommandType = CommandType.StoredProcedure
            SqlComm.CommandText = "SPDELETEUSER"
            SqlComm.Parameters.Add("@EMAIL", _EmailAdd)
            SqlComm.CommandTimeout = 0
            SqlComm.ExecuteNonQuery()
            SqlDataR = SqlComm.ExecuteReader()
            Dt.Load(SqlDataR)
            Return
            SqlDataR.Close()
            SqlConn.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    '--------------------------------SELECT PROCEDURE ------------------------------------
    'Public Sub showrapat()
    '    Try
    '        Dim Dt As New DataTable
    '        Dim SqlConn As New SqlConnection
    '        Dim SqlComm As New SqlCommand
    '        Dim SqlDataR As SqlDataReader
    '        SqlConn = GetConnection()
    '        SqlConn.Open()
    '        SqlComm.Connection = SqlConn
    '        SqlComm.CommandType = CommandType.StoredProcedure
    '        SqlComm.CommandText = "SPSELECTRAPAT"
    '        SqlComm.Parameters.Add("@TANGGAL", _Tanggal)
    '        SqlComm.Parameters.Add("@PERIHAL", _Perihal)
    '        SqlComm.Parameters.Add("@TINDAK_LANJUT", _TindakLanjut)
    '        SqlComm.Parameters.Add("@PIMPINAN", _Pimpinan)
    '        SqlComm.Parameters.Add("@NOTULIS", _Notulis)
    '        SqlComm.Parameters.Add("@PIC", _PIC)
    '        SqlComm.Parameters.Add("@NORUANGAN", _Ruangan)
    '        SqlComm.CommandTimeout = 0
    '        'SqlComm.ExecuteNonQuery()
    '        SqlDataR = SqlComm.ExecuteReader()
    '        Dt.Load(SqlDataR)
    '        If Dt.Rows.Count > 0 Then
    '            Tanggal = Dt.Rows(0).Item("tanggal_rapat")
    '        Else
    '            Tanggal = Nothing
    '        End If


    '        SqlDataR.Close()
    '        SqlConn.Close()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    'Public Sub selected()
    '    Try
    '        Dim Dt As New DataTable
    '        Dim SqlConn As New SqlConnection
    '        Dim SqlComm As New SqlCommand
    '        Dim SqlDataR As SqlDataReader
    '        SqlConn = GetConnection()
    '        SqlConn.Open()
    '        SqlComm.Connection = SqlConn
    '        SqlComm.CommandType = CommandType.StoredProcedure
    '        SqlComm.CommandText = "SPSELECT"
    '        SqlComm.Parameters.Add("@TANGGAL", _Tanggal)
    '        SqlComm.Parameters.Add("@PERIHAL", _Perihal)
    '        SqlComm.Parameters.Add("@TINDAK_LANJUT", _TindakLanjut)
    '        SqlComm.Parameters.Add("@PIMPINAN", _Pimpinan)
    '        SqlComm.Parameters.Add("@NOTULIS", _Notulis)
    '        SqlComm.Parameters.Add("@PIC", _PIC)
    '        SqlComm.CommandTimeout = 0
    '        'SqlComm.ExecuteNonQuery()
    '        SqlDataR = SqlComm.ExecuteReader()
    '        Dt.Load(SqlDataR)
    '        If Dt.Rows.Count > 0 Then
    '            Tanggal = Dt.Rows(0).Item("tanggal")
    '            'Perihal = Dt.Rows(0).Item("perihal")
    '        Else
    '            Tanggal = Nothing
    '            'Perihal = Nothing
    '        End If


    '        SqlDataR.Close()
    '        SqlConn.Close()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    'Public Sub showpek()
    '    Try
    '        Dim Dt As New DataTable
    '        Dim SqlConn As New SqlConnection
    '        Dim SqlComm As New SqlCommand
    '        Dim SqlDataR As SqlDataReader
    '        SqlConn = GetConnection()
    '        SqlConn.Open()
    '        SqlComm.Connection = SqlConn
    '        SqlComm.CommandType = CommandType.StoredProcedure
    '        SqlComm.CommandText = "SPSELECTPEK"
    '        SqlComm.Parameters.Add("@NOPEK", _Nopek)
    '        SqlComm.CommandTimeout = 0
    '        'SqlComm.ExecuteNonQuery()
    '        SqlDataR = SqlComm.ExecuteReader()
    '        Dt.Load(SqlDataR)
    '        If Dt.Rows.Count > 0 Then
    '            Nopek = Dt.Rows(0).Item("nopek")
    '        Else
    '            Nopek = Nothing
    '        End If


    '        SqlDataR.Close()
    '        SqlConn.Close()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    'Public Sub shownonpek()
    '    Try
    '        Dim Dt As New DataTable
    '        Dim SqlConn As New SqlConnection
    '        Dim SqlComm As New SqlCommand
    '        Dim SqlDataR As SqlDataReader
    '        SqlConn = GetConnection()
    '        SqlConn.Open()
    '        SqlComm.Connection = SqlConn
    '        SqlComm.CommandType = CommandType.StoredProcedure
    '        SqlComm.CommandText = "SPSELECTNONPEK"
    '        SqlComm.Parameters.Add("@NAMA", _Nama)
    '        SqlComm.CommandTimeout = 0
    '        'SqlComm.ExecuteNonQuery()
    '        SqlDataR = SqlComm.ExecuteReader()
    '        Dt.Load(SqlDataR)
    '        If Dt.Rows.Count > 0 Then
    '            Nama = Dt.Rows(0).Item("nama")
    '        Else
    '            Nama = Nothing
    '        End If


    '        SqlDataR.Close()
    '        SqlConn.Close()

    '    Catch ex As Exception
    '        Throw New Exception(ex.Message)
    '    End Try
    'End Sub

    Public Sub showuser()

        Try
            Dim Dt As New DataTable
            Dim SqlConn As New SqlConnection
            Dim SqlComm As New SqlCommand
            Dim SqlDataR As SqlDataReader
            SqlConn = GetConnection()
            SqlConn.Open()
            SqlComm.Connection = SqlConn
            SqlComm.CommandType = CommandType.StoredProcedure
            SqlComm.CommandText = "SPSELECTUSER"
            SqlComm.Parameters.Add("@EMAIL", _EmailAdd)
            SqlComm.Parameters.Add("@PWORD", _Password)
            SqlComm.CommandTimeout = 0
            ' SqlComm.ExecuteNonQuery()
            SqlDataR = SqlComm.ExecuteReader()
            Dt.Load(SqlDataR)
            If Dt.Rows.Count > 0 Then
                EmailAdd = Dt.Rows(0).Item("email_add")
                Password = Dt.Rows(0).Item("password")
            Else
                EmailAdd = Nothing
                Password = Nothing
            End If

            SqlDataR.Close()
            SqlConn.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
    End Sub

    Public Sub showruangan()
        Try
            Dim Dt As New DataTable
            Dim SqlConn As New SqlConnection
            Dim SqlComm As New SqlCommand
            Dim SqlDataR As SqlDataReader
            SqlConn = GetConnection()
            SqlConn.Open()
            SqlComm.Connection = SqlConn
            SqlComm.CommandType = CommandType.StoredProcedure
            SqlComm.CommandText = "SPSELECTRUANGAN"
            SqlComm.Parameters.Add("@NORUANGAN", _Ruangan)
            SqlComm.CommandTimeout = 0
            'SqlComm.ExecuteNonQuery()
            SqlDataR = SqlComm.ExecuteReader()
            Dt.Load(SqlDataR)
            If Dt.Rows.Count > 0 Then
                Ruangan = Dt.Rows(0).Item("no_ruangan")
            Else
                Ruangan = Nothing
            End If


            SqlDataR.Close()
            SqlConn.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Function View() As DataTable
        Dim Dt As New DataTable
        Dim SqlConn As New SqlConnection
        Dim SqlComm As New SqlCommand
        Dim SqlDataR As SqlDataReader
        Try

            SqlConn = GetConnection()
            SqlConn.Open()
            SqlComm.Connection = SqlConn
            SqlComm.CommandType = CommandType.StoredProcedure
            SqlComm.CommandText = "SPSELECTTINDAK"
            SqlComm.Parameters.Add("@ID", _id)
            SqlComm.CommandTimeout = 0
            SqlDataR = SqlComm.ExecuteReader()
            Dt.Load(SqlDataR)
            Return Dt
        Catch ex As Exception
            Throw New Exception(ex.Message)


        Finally
            SqlDataR.Close()
            SqlConn.Close()
        End Try
    End Function

    Public Function ViewFile() As DataTable
        Dim Dt As New DataTable
        Dim SqlConn As New SqlConnection
        Dim SqlComm As New SqlCommand
        Dim SqlDataR As SqlDataReader
        Try

            SqlConn = GetConnection()
            SqlConn.Open()
            SqlComm.Connection = SqlConn
            SqlComm.CommandType = CommandType.Text
            SqlComm.CommandText = "SELECT * FROM hadir WHERE @ID = id"
            SqlComm.Parameters.Add("@ID", _id)
            SqlComm.CommandTimeout = 0
            SqlDataR = SqlComm.ExecuteReader()
            Dt.Load(SqlDataR)
            Return Dt
        Catch ex As Exception
            Throw New Exception(ex.Message)


        Finally
            SqlDataR.Close()
            SqlConn.Close()
        End Try
    End Function

    Public Function ViewPek() As DataTable
        Dim Dt As New DataTable
        Dim SqlConn As New SqlConnection
        Dim SqlComm As New SqlCommand
        Dim SqlDataR As SqlDataReader
        Try

            SqlConn = GetConnection()
            SqlConn.Open()
            SqlComm.Connection = SqlConn
            SqlComm.CommandType = CommandType.Text
            SqlComm.CommandText = "SELECT * FROM pekerja WHERE @ID=id"
            SqlComm.Parameters.Add("@ID", _id)
            SqlComm.CommandTimeout = 0
            SqlDataR = SqlComm.ExecuteReader()
            Dt.Load(SqlDataR)
            Return Dt
        Catch ex As Exception
            Throw New Exception(ex.Message)


        Finally
            SqlDataR.Close()
            SqlConn.Close()
        End Try
    End Function

    Public Function ViewNonPek() As DataTable
        Dim Dt As New DataTable
        Dim SqlConn As New SqlConnection
        Dim SqlComm As New SqlCommand
        Dim SqlDataR As SqlDataReader
        Try

            SqlConn = GetConnection()
            SqlConn.Open()
            SqlComm.Connection = SqlConn
            SqlComm.CommandType = CommandType.Text
            SqlComm.CommandText = "SELECT * FROM non_pekerja WHERE @ID = id_non_pekerja"
            SqlComm.Parameters.Add("@ID", _id)
            SqlComm.CommandTimeout = 0
            SqlDataR = SqlComm.ExecuteReader()
            Dt.Load(SqlDataR)
            Return Dt
        Catch ex As Exception
            Throw New Exception(ex.Message)


        Finally
            SqlDataR.Close()
            SqlConn.Close()
        End Try
    End Function
End Class
