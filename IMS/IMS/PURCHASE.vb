Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class PURCHASE
    Dim NOY As Integer
    Private Sub PURCHASE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IMSDataSet.AGENT' table. You can move, or remove it, as needed.
        Me.AGENTTableAdapter.Fill(Me.IMSDataSet.AGENT)

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kshitiz\Desktop\IMS\IMS.accdb"
        con.Open()
        Dim str As String
        str = "Select * from POLICY where P_ID=" & Module1.sv & ""
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        Dim adapter As New OleDbDataAdapter(str, con)
        Dim table As New DataTable()
        adapter.Fill(table)
        C_NAME.Text = Module1.c_name
        P_ID.Text = Module1.sv
        P_NAME.Text = table.Rows(0)(1).ToString
        P_AMOUNT.Text = table.Rows(0)(3).ToString
        NOY = table.Rows(0)(5).ToString
        con.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CP_DOC.ValueChanged
        CP_DOE.Value = CP_DOC.Value.AddYears(NOY)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CP_EMI.Text = P_AMOUNT.Text / NOY
    End Sub

    Private Sub BUY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUY.Click
        con.Open()
        Dim str As String
        str = "insert into CLIENT_POLICY([C_ID],[C_NAME],[A_ID], [A_NAME],[P_ID],[P_NAME],[CP_DOC],[CP_NOP],[CP_EMI],[CP_DOE]) values (?,?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        cmd.Parameters.Add(New OleDbParameter("C_ID", CType(Module1.no, Integer)))
        cmd.Parameters.Add(New OleDbParameter("C_NAME", CType(C_NAME.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("A_NAME", CType(A_NAME.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P_ID", CType(P_ID.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("P_NAME", CType(P_NAME.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("CP_DOC", CType(CP_DOC.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("CP_NOP", CType(CP_NOP.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("CP_EMI", CType(CP_EMI.Text, Integer)))
        cmd.Parameters.Add(New OleDbParameter("CP_DOE", CType(CP_DOE.Text, String)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MsgBox("POLICY BOUGHT SUCCESFULLY")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCEL.Click
        Me.Close()
    End Sub

    Private Sub A_NAME_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles A_NAME.Click
        Combo2_Change()
    End Sub
    Private Sub Combo2_Change()
        con.Open()
        Dim R As String
        R = "select COUNT(A_NAME) from AGENT"
        Module1.ScalarQuery(R)
        Dim cmd As OleDbCommand = New OleDbCommand(R, con)
        Dim adapter As New OleDbDataAdapter(R, con)
        Dim table As New DataTable()
        adapter.Fill(table)
        Dim j As Integer
        j = 0
        While (j < Module1.sv)
            A_NAME.Items.Add(table.Rows(j)(0).ToString)
        End While
        con.Close()
    End Sub
End Class