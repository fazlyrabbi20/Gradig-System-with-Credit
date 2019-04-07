Public Class Form10

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox17.Text = (Val(TextBox9.Text) * 5) / 100 + (Val(TextBox10.Text) * 5) / 100 + (Val(TextBox11.Text) * 5) / 100 + (Val(TextBox12.Text) * 15) / 100 + (Val(TextBox13.Text) * 15) / 100 + (Val(TextBox14.Text) * 20) / 100 + (Val(TextBox15.Text) * 25) / 100 + (Val(TextBox16.Text) * 10) / 100
        If TextBox17.Text = 4 Then
            TextBox18.Text = "A+"
        ElseIf TextBox17.Text >= 3.75 And TextBox17.Text <= 3.99 Then
            TextBox18.Text = "A"
        ElseIf TextBox17.Text >= 3.5 And TextBox17.Text <= 3.74 Then
            TextBox18.Text = "A-"
        ElseIf TextBox17.Text >= 3.25 And TextBox17.Text <= 3.49 Then
            TextBox18.Text = "B+"
        ElseIf TextBox17.Text >= 3.0 And TextBox17.Text <= 3.24 Then
            TextBox18.Text = "B"
        ElseIf TextBox17.Text >= 2.75 And TextBox17.Text <= 2.99 Then
            TextBox18.Text = "B-"
        ElseIf TextBox17.Text >= 2.5 And TextBox17.Text <= 2.74 Then
            TextBox18.Text = "C+"
        ElseIf TextBox17.Text >= 2.25 And TextBox17.Text <= 2.49 Then
            TextBox18.Text = "C"
        ElseIf TextBox17.Text >= 2.0 And TextBox17.Text <= 2.24 Then
            TextBox18.Text = "D"

        Else
            TextBox18.Text = "F"

        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Form9.Show()
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class