Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class CLIENT_REGISTRATION
    Dim VID As Integer

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kshitiz\Desktop\IMS\IMS.accdb"
        con.Open()
        datagridshow()
        DataGridView1.ClearSelection()
        UPDATEE.Enabled = False
    End Sub

    Private Sub datagridshow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("select* from CLIENT", con)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        con.Close()
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

    Private Sub VIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEW.Click
        con.Open()
        Dim str As String
        str = "select * from CLIENT where C_ID=" & VID & ""
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        Dim adapter As New OleDbDataAdapter(str, con)
        Dim table As New DataTable()
        adapter.Fill(table)
        C_NAME.Text = table.Rows(0)(1).ToString
        C_DOB.Text = table.Rows(0)(2).ToString
        C_MOBILE.Text = table.Rows(0)(3).ToString
        C_EMAIL.Text = table.Rows(0)(4).ToString
        C_ADDR.Text = table.Rows(0)(5).ToString
        C_CITY.Text = table.Rows(0)(6).ToString
        C_STATE.Text = table.Rows(0)(7).ToString
        con.Close()
        UPDATEE.Enabled = True
    End Sub

    Private Sub CLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLEAR.Click
        C_NAME.Text = ""
        C_DOB.Text = ""
        C_MOBILE.Text = ""
        C_EMAIL.Text = ""
        C_ADDR.Text = ""
        C_CITY.Text = ""
        C_STATE.Text = ""
    End Sub

    Private Sub UPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPDATEE.Click
        con.Open()
        Dim str As String
        str = "Update CLIENT Set CLIENT.C_NAME = '" & C_NAME.Text & "', CLIENT.C_DOB ='" & C_DOB.Text & "', CLIENT.C_MOBILE ='" & C_MOBILE.Text & "', CLIENT.C_EMAIL ='" & C_EMAIL.Text & "',CLIENT.C_ADDR ='" & C_ADDR.Text & "',CLIENT.C_CITY ='" & C_CITY.Text & "',CLIENT.C_STATE='" & C_STATE.Text & "' WHERE C_ID = " & VID & ""
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            datagridshow()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETE.Click
        Dim str As String
        If (VID = 0) Then
            MsgBox("Select a PRODUCT to Delete..!", vbInformation, "Select PRODUCT")
        Else
            If (MsgBox("Do you Really Want to Delete?", vbOKCancel, "Confirm") = vbOK) Then
                str = "DELETE * FROM CLIENT WHERE C_ID = " & VID & "  "
                con.Open()
                Dim cmd As OleDbCommand = New OleDbCommand(str, con)
                cmd.ExecuteNonQuery()
                con.Dispose()
                con.Close()
                MsgBox("Record Deleted!", vbInformation, "Status")
                datagridshow()
            End If
        End If
    End Sub


    Private Sub SUBMIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUBMIT.Click
        con.Open()
        Dim str As String
        str = "insert into CLIENT([C_NAME],[C_DOB],[C_MOBILE], [C_EMAIL],[C_ADDR],[C_CITY],[C_STATE]) values (?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        cmd.Parameters.Add(New OleDbParameter("C_NAME", CType(C_NAME.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("C_DOB", CType(C_DOB.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("C_MOBILE", CType(C_MOBILE.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("C_EMAIL", CType(C_EMAIL.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("C_ADDR", CType(C_ADDR.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("C_CITY", CType(C_CITY.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("C_STATE", CType(C_STATE.Text, String)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            datagridshow()
            MsgBox("1 Record Inserted Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

  
    Private Sub CLIENT_POLICY_DETAILS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLIENT_POLICY_DETAILS.Click
        If VID = 0 Then
            MsgBox("Please select a Client to view", vbInformation, "Status")
        Else
            Module1.client(VID)
            CLIENT.Show()
        End If
    End Sub

    Private Sub CANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCEL.Click
        Me.Close()
    End Sub
End Class