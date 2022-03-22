Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class POLICY_REGISTRATION
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
        da = New OleDbDataAdapter("select * from POLICY", con)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub

    Private Sub SUBMIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUBMIT.Click
        con.Open()
        Dim str As String
        str = "insert into POLICY([P_NAME],[P_TYPE],[P_AMOUNT], [P_DESC],[P_NY]) values (?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        cmd.Parameters.Add(New OleDbParameter("P_NAME", CType(P_NAME.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P_TYPE", CType(P_TYPE.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P_AMOUNT", CType(P_AMOUNT.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("P_DESC", CType(P_DESC.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P_NY", CType(P_NY.Text, Integer)))
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
        P_NAME.Text = ""
        P_AMOUNT.Text = ""
        P_DESC.Text = ""
        P_TYPE.Text = "SELECT POLICY TYPE"
        P_NY.Text = ""
    End Sub

    Private Sub UPDATEE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPDATEE.Click
        con.Open()
        Dim str As String
        str = "Update POLICY Set POLICY.P_NAME = '" & P_NAME.Text & "', POLICY.P_TYPE ='" & P_TYPE.Text & "', POLICY.P_AMOUNT =" & P_AMOUNT.Text & ", POLICY.P_DESC ='" & P_DESC.Text & "',POLICY.P_NY =" & P_NY.Text & " WHERE P_ID = " & VID & ""
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            datagridshow()
            MsgBox("1 Record Updated Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub VIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles View.Click
        con.Open()
        Dim str As String
        str = "select * from POLICY where P_ID=" & VID & ""
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        Dim adapter As New OleDbDataAdapter(str, con)
        Dim table As New DataTable()
        adapter.Fill(table)
        P_NAME.Text = table.Rows(0)(1).ToString
        P_AMOUNT.Text = table.Rows(0)(3).ToString
        P_DESC.Text = table.Rows(0)(4).ToString
        P_NY.Text = table.Rows(0)(5).ToString
        P_TYPE.Text = table.Rows(0)(2).ToString
        con.Close()
        UPDATEE.Enabled = True
    End Sub

    Private Sub DELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETE.Click
        Dim str As String
        If (VID = 0) Then
            MsgBox("Select an Policy Detail to Delete..!", vbInformation, "Select an Policy")
        Else
            If (MsgBox("Do you Really Want to Delete?", vbOKCancel, "Confirm") = vbOK) Then
                str = "DELETE * FROM POLICY WHERE P_ID = " & VID & "  "
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
End Class
