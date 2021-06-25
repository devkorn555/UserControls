Public Class Userbtn

    Dim r As RadioButton
    Private Sub Userbtn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        r = New RadioButton
        AddHandler r.CheckedChanged, AddressOf rcheck
    End Sub

    Private Sub rcheck(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged
        r = New RadioButton
        r = sender
        If r.Checked = True Then
            MsgBox(r.Text & "ปุ่ของ " & Me.Name)

        End If
    End Sub
End Class
