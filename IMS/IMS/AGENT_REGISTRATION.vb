Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class AGENT_REGISTRATION
    Dim VID As Integer

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\IMS\IMS\IMS\IMS.accdb"
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
        da = New OleDbDataAdapter("select* from AGENT", con)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub

   

    Private Sub A_TYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A_TYPE.SelectedIndexChanged
        If A_TYPE.Text = "AMATEUR" Then
            A_TARGET.Text = "5"
        Else
            A_TARGET.Text = "10"
        End If
    End Sub

    
    Private Sub SUBMIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUBMIT.Click
        con.Open()
        Dim str As String
        str = "insert into AGENT([A_NAME],[A_DOB],[A_MOBILE], [A_EMAIL],[A_ADDR],[A_CITY],[A_STATE],[A_TYPE],[A_TARGET]) values (?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        cmd.Parameters.Add(New OleDbParameter("A_NAME", CType(A_NAME.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("A_DOB", CType(A_DOB.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("A_MOBILE", CType(A_MOBILE.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("A_EMAIL", CType(A_EMAIL.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("A_ADDR", CType(A_ADDR.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("A_CITY", CType(A_CITY.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("A_STATE", CType(A_STATE.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("A_TYPE", CType(A_TYPE.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("A_TARGET", CType(A_TARGET.Text, Integer)))
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

    Private Sub CLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLEAR.Click
        A_NAME.Text = ""
        A_DOB.Text = ""
        A_MOBILE.Text = ""
        A_EMAIL.Text = ""
        A_ADDR.Text = ""
        A_CITY.Text = ""
        A_STATE.Text = ""
        A_TYPE.Text = "SELECT AGENT TYPE"
        A_TARGET.Text = ""
    End Sub

    Private Sub UPDATEE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPDATEE.Click
        con.Open()
        Dim str As String
        str = "Update AGENT Set AGENT.A_NAME = '" & A_NAME.Text & "', AGENT.A_DOB ='" & A_DOB.Text & "', AGENT.A_MOBILE ='" & A_MOBILE.Text & "', AGENT.A_EMAIL ='" & A_EMAIL.Text & "',AGENT.A_ADDR ='" & A_ADDR.Text & "',AGENT.A_CITY ='" & A_CITY.Text & "',AGENT.C_STATE='" & A_STATE.Text & "', AGENT.A_TYPE ='" & A_TYPE.Text & "', AGENT.A_TARGET =" & A_TARGET.Text & " WHERE A_ID = " & VID & ""
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

    
    Private Sub VIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEW.Click
        con.Open()
        Dim str As String
        str = "select * from AGENT where A_ID=" & VID & ""
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        Dim adapter As New OleDbDataAdapter(str, con)
        Dim table As New DataTable()
        adapter.Fill(table)
        A_NAME.Text = table.Rows(0)(1).ToString
        A_DOB.Text = table.Rows(0)(2).ToString
        A_MOBILE.Text = table.Rows(0)(3).ToString
        A_EMAIL.Text = table.Rows(0)(4).ToString
        A_ADDR.Text = table.Rows(0)(5).ToString
        A_CITY.Text = table.Rows(0)(6).ToString
        A_STATE.Text = table.Rows(0)(7).ToString
        A_TYPE.Text = table.Rows(0)(8).ToString
        A_TARGET.Text = table.Rows(0)(9).ToString
        con.Close()
        UPDATEE.Enabled = True
    End Sub

    Private Sub DELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETE.Click
        Dim str As String
        If (VID = 0) Then
            MsgBox("Select an Agent Detail to Delete..!", vbInformation, "Select an Agent")
        Else
            If (MsgBox("Do you Really Want to Delete?", vbOKCancel, "Confirm") = vbOK) Then
                str = "DELETE * FROM AGENT WHERE A_ID = " & VID & "  "
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

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        'If (DataGridView1.Item(0, i).Value.ToString <> System.DBNull.Equals) Then
        If (IsDBNull(DataGridView1.Item(0, i).Value)) Then

        Else
            VID = DataGridView1.Item(0, i).Value
        End If
    End Sub

    Private Sub CANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCEL.Click
        Me.Close()
    End Sub

   
    Private Sub A_NAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A_NAME.TextChanged

    End Sub

    Private Sub AGENT_POLICY_DETAILS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AGENT_POLICY_DETAILS.Click
        If VID = 0 Then
            MsgBox("Please select a Agent to view", vbInformation, "Status")
        Else
            Module1.client(VID)
            AGENT_INCEN.Show()
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
