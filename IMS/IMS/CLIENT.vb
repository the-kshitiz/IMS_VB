Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class CLIENT
    Dim VID, i As Integer
    Dim aNAME As String

    Private Sub CLIENT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kshitiz\Desktop\IMS\IMS.accdb"
        con.Open()
        i = Module1.no
        Dim str As String
        str = "Select * from CLIENT where C_ID=" & i & ""
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        Dim adapter As New OleDbDataAdapter(str, con)
        Dim table As New DataTable()
        adapter.Fill(table)
        CNAME.Text = table.Rows(0)(1).ToString
        aNAME = CNAME.Text
        C_NAME.Text = table.Rows(0)(1).ToString
        C_DOB.Text = table.Rows(0)(2).ToString
        C_MOBILE.Text = table.Rows(0)(3).ToString
        C_EMAIL.Text = table.Rows(0)(4).ToString
        C_ADDR.Text = table.Rows(0)(5).ToString
        C_CITY.Text = table.Rows(0)(6).ToString
        C_STATE.Text = table.Rows(0)(7).ToString
        con.Close()
    End Sub
    Private Sub datagridshow(ByVal query As String)

        con.Open()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(query, con)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub


    
    Private Sub OPERATION_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPERATION.SelectedIndexChanged
        Dim query As String
        DataGridView1.ClearSelection()
        If OPERATION.Text = "ACTIVE POLICIES" Then
            query = "select * from CLIENT_POLICY where C_NAME='" & Module1.no & "'"
        ElseIf OPERATION.Text = "NEW HEALTH INSURANCE" Then
            query = "select * from POLICY where P_TYPE= 'HEALTH INSURANCE' "
            BUY.Enabled = True
        ElseIf OPERATION.Text = "NEW VEHICLE INSURANCE" Then
            query = "select * from POLICY where P_TYPE='VEHICLE INSURANCE' "
            BUY.Enabled = True
        ElseIf OPERATION.Text = "NEW LIFE INSURANCE" Then
            query = "select * from POLICY where P_TYPE= 'LIFE INSURANCE' "
            BUY.Enabled = True
        End If
        datagridshow(query)
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        'If (DataGridView1.Item(0, i).Value.ToString <> System.DBNull.Equals) Then
        If (IsDBNull(DataGridView1.Item(0, i).Value)) Then

        Else
            VID = DataGridView1.Item(0, i).Value
        End If
    End Sub

    Private Sub BUY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUY.Click
        Module1.purchase(VID, aNAME)
        PURCHASE.Show()

    End Sub
End Class