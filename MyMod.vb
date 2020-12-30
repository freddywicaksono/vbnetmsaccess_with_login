Imports System.Data.OleDb
Imports System.Security.Cryptography

Module MyMod
    Public mycommand As New System.Data.OleDb.OleDbCommand
    Public myadapter As New System.Data.OleDb.OleDbDataAdapter
    Public mydata As New DataTable
    Public DR As System.Data.OleDb.OleDbDataReader
    Public SQL As String
    Public conn As New OleDbConnection
    Public cn As New Connection

    'Tabel Fakultas
    '-------------------------------
    Public fakultas_baru As Boolean
    Public ofakultas As New Fakultas
    '--------------------------------

    'Tabel User
    '--------------------------------
    Public user_baru As Boolean
    Public oUser As New User
    '--------------------------------

    Public login_valid As Boolean

    Public Sub DBConnect()
        cn.DataSource = "C:\Users\UMC-LN-03\Downloads\Compressed\praktek_access_2\praktek_access\umc.accdb"

        cn.Connect()
    End Sub

    Public Sub DBDisconnect()
        cn.Disconnect()
    End Sub

    Public Function getMD5Hash(ByVal strToHash As String) As String

        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        Dim b As Byte
        For Each b In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function
End Module
