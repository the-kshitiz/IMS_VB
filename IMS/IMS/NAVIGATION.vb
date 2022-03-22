Public Class NAVIGATION
    Dim i As Integer
    Private Sub POLICY1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POLICY1.Click
        ProgressBar1.Visible = True
        i = 1
        Timer1.Start()

    End Sub

    Private Sub AGENT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AGENT.Click
        ProgressBar1.Visible = True
        i = 2
        Timer1.Start()
    End Sub

    Private Sub CLIENT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLIENT.Click
        ProgressBar1.Visible = True
        i = 3
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = 0
        ProgressBar1.Value = ProgressBar1.Value + 100
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            If i = 1 Then
                POLICY_REGISTRATION.Show()
                Me.Close()

            ElseIf i = 2 Then
                AGENT_REGISTRATION.Show()
                Me.Close()
            Else
                CLIENT_REGISTRATION.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class