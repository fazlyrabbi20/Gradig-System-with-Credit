Public Class Form9

    Private Sub Button21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text >= 160 And TextBox1.Text <= 200 Then
            TextBox2.Text = "A+"
            TextBox3.Text = "4.00"
        ElseIf TextBox1.Text >= 150 And TextBox1.Text <= 159 Then
            TextBox2.Text = "A"
            TextBox3.Text = "3.75"
        ElseIf TextBox1.Text >= 140 And TextBox1.Text <= 149 Then
            TextBox2.Text = "A-"
            TextBox3.Text = "3.50"
        ElseIf TextBox1.Text >= 130 And TextBox1.Text <= 139 Then
            TextBox2.Text = "B+"
            TextBox3.Text = "3.25"
        ElseIf TextBox1.Text >= 120 And TextBox1.Text <= 129 Then
            TextBox2.Text = "B"
            TextBox3.Text = "3.00"
        ElseIf TextBox1.Text >= 110 And TextBox1.Text <= 119 Then
            TextBox2.Text = "B-"
            TextBox3.Text = "2.75"
        ElseIf TextBox1.Text >= 100 And TextBox1.Text <= 109 Then
            TextBox2.Text = "C+"
            TextBox3.Text = "2.50"
        ElseIf TextBox1.Text >= 90 And TextBox1.Text <= 99 Then
            TextBox2.Text = "C"
            TextBox3.Text = "2.25"
        ElseIf TextBox1.Text >= 80 And TextBox1.Text <= 89 Then
            TextBox2.Text = "D"
            TextBox3.Text = "2.00"
        Else
            TextBox2.Text = "F"
            TextBox3.Text = "0.00"
        End If
        TextBox4.Text = (Val(TextBox3.Text))
        If TextBox4.Text = 4 Then
            TextBox5.Text = "A+"
        ElseIf TextBox4.Text >= 3.75 And TextBox4.Text <= 3.99 Then
            TextBox5.Text = "A"
        ElseIf TextBox4.Text >= 3.5 And TextBox4.Text <= 3.74 Then
            TextBox5.Text = "A-"
        ElseIf TextBox4.Text >= 3.25 And TextBox4.Text <= 3.49 Then
            TextBox5.Text = "B+"
        ElseIf TextBox4.Text >= 3.0 And TextBox4.Text <= 3.24 Then
            TextBox5.Text = "B"
        ElseIf TextBox4.Text >= 2.75 And TextBox4.Text <= 2.99 Then
            TextBox5.Text = "B-"
        ElseIf TextBox4.Text >= 2.5 And TextBox4.Text <= 2.74 Then
            TextBox5.Text = "C+"
        ElseIf TextBox4.Text >= 2.25 And TextBox4.Text <= 2.49 Then
            TextBox5.Text = "C"
        ElseIf TextBox4.Text >= 2.0 And TextBox4.Text <= 2.24 Then
            TextBox5.Text = "D"

        Else
            TextBox5.Text = "F"

        End If
        Form10.TextBox16.Text = Val(TextBox4.Text)
        Form10.TextBox8.Text = TextBox5.Text
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Form10.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Form8.Show()
    End Sub
End Class