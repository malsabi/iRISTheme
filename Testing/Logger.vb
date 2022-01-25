Imports System.IO
Public Class Logger
#Region "Fields"
    Private _Path As String
    Private _LogLock As Object
#End Region

#Region "Properties"
    Public Property Path As String
        Get
            Return _Path
        End Get
        Set(value As String)
            _Path = value
        End Set
    End Property

    Public Property LogLock As Object
        Get
            Return _LogLock
        End Get
        Set(value As Object)
            _LogLock = value
        End Set
    End Property
#End Region

#Region "Constructors"
    Public Sub New()
        Path = "./Log.txt"
        LogLock = New Object()
        CreateFile()
    End Sub
#End Region

#Region "Public Methods"
    Public Sub Log(Title As String, Message As String)
        SyncLock LogLock
            Append(Title, Message, Date.Now)
        End SyncLock
    End Sub
#End Region

#Region "Private Methods"
    Private Function IsFileExists() As Boolean
        Try
            Return New FileInfo(Path).Exists
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function CreateFile() As Boolean
        Try
            If Not IsFileExists() Then
                File.Create(Path)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub Append(Title As String, Message As String, TimeStamp As Date)
        If Not IsFileExists() Then
            Throw New Exception("File doesnot exists")
        Else
            Using FS As FileStream = New FileStream(Path, FileMode.Append, FileAccess.Write)
                Using SR As New StreamWriter(FS)
                    SR.WriteLine(String.Format("[TITLE: {0}] [MESSAGE: {1}] [TIMESTAMP: {2}]", Title, Message, TimeStamp.ToString()))
                End Using
            End Using
        End If
    End Sub
#End Region
End Class