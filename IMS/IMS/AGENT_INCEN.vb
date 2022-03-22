Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class AGENT_INCEN
    Dim i As Integer
    Private Sub AGENT_INCEN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kshitiz\Desktop\IMS\IMS.accdb"
        con.Open()
        i = Module1.no
        Dim str, str1 As String
        Dim x As Integer
        str1 = "Select count(A_NAME) from CLIENT_POLICY where A_NAME='" & A_NAME.Text & "'"
        str = "Select * from AGENT where A_ID=" & i & ""
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        Dim cmd1 As OleDbCommand = New OleDbCommand(str1, con)
        x = cmd1.ExecuteScalar()
        Dim adapter As New OleDbDataAdapter(str, con)
        Dim table As New DataTable()
        adapter.Fill(table)
        A_NAME.Text = table.Rows(0)(1).ToString
        A_MOBILE.Text = table.Rows(0)(3).ToString
        A_EMAIL.Text = table.Rows(0)(4).ToString
        A_ADDR.Text = table.Rows(0)(5).ToString
        A_CITY.Text = table.Rows(0)(6).ToString
        A_STATE.Text = table.Rows(0)(7).ToString
        A_TYPE.Text = table.Rows(0)(8).ToString
        A_TARGET.Text = table.Rows(0)(9).ToString
        A_NOC.Text = x

        con.Close()
    End Sub
End Class