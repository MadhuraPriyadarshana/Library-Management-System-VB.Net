Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pg1.Increment(1)
        If pg1.Value = 100 Then
            Me.Hide()
            Dim log = New loging
            log.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub pg1_Click(sender As Object, e As EventArgs) Handles pg1.Click

    End Sub
End Class
