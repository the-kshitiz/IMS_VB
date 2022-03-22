Imports System.Data.OleDb

Module Module1
    Public con As New OleDbConnection
    Public ds As New OleDbDataAdapter
    Public cmd As New OleDbCommand
    Public sv As Integer
    Public no As Integer
    Public c_name As String
    Public Sub connect()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kshitiz\Desktop\IMS\IMS.mdb"
        con.Open()
    End Sub
    Public Sub ScalarQuery(ByVal query As String)
        cmd = New OleDbCommand(query, con)
        sv = cmd.ExecuteScalar()
    End Sub
    Public Sub inupdel(ByVal query As String)
        cmd = New OleDbCommand(query, con)
        If cmd.ExecuteNonQuery() Then
            MsgBox("Operation Completed")
        Else
            MsgBox("Operation Failed")
        End If
    End Sub
    Public Sub client(ByVal i As Integer)
        no = i
    End Sub
    Public Sub connectclose()
        con.Close()
    End Sub
    Public Sub purchase(ByVal P_ID As Integer, ByVal C As String)
        sv = P_ID
        MsgBox(sv)
        c_name = C
    End Sub
End Module
