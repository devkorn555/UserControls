Public Class Form1

    Dim user1 As Userbtn

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For i = 1 To 10
            user1 = New Userbtn
            user1.lb.Text = "Label " & i
            user1.btn.Text = "ปุ่มที่ " & i
            user1.Name = "ปุ่มที่ " & i
            AddHandler user1.Click, AddressOf btnclick
            FlowLayoutPanel1.Controls.Add(user1)
        Next

    End Sub

    Private Sub btnclick(sender As Object, e As EventArgs)
        user1 = New Userbtn
        user1 = sender
    End Sub
End Class
