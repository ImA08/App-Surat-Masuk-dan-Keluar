Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Module koneksi
    Public conn As MySqlConnection
    Public ds As DataSet
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public cmd As MySqlCommand
    Public str, sql As String

    Public Sub dbkoneksi()
        sql = "server = localhost; user = root; database = db_surat"
        conn = New MySqlConnection(sql)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

End Module
