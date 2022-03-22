Public Class ALOGIN
    Private Sub ALOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Module1.connect()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Static count As Integer
        Module1.ScalarQuery("select count(*) from ADMIN where USERNAME='" & USERNAME.Text & "' and PASSWORD='" & PASSWORD.Text & "'")
        If count > 2 Then
            MsgBox("NO. of attempts exceeded")
            End
        ElseIf Module1.sv = 1 Then
            MsgBox("login successful")
            NAVIGATION.Show()
            Me.Hide()

        Else
            MsgBox("login Unsuccessful")
            count = count + 1
        End If
        Module1.connectclose()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class

