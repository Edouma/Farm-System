Imports MySql.Data.MySqlClient


Module UniversalVariables

    Public Conn As MySqlConnection = New MySqlConnection
    Public ds As New DataSet
    Public cmd As MySqlCommand = New MySqlCommand
    Public dr As MySqlDataReader
    Public sql As String

    Public Sub connect()
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        cmd.Connection = Conn
        Conn.Open()
        dr = cmd.ExecuteReader

    End Sub

End Module
