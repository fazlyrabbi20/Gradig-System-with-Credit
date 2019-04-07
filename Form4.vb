Public Class Form4

    Private Sub Button21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button21_Click_1(sender As Object, e As EventArgs) Handles Button21.Click
        If TextBox1.Text >= 120 And TextBox1.Text <= 150 Then
            TextBox8.Text = "A+"
            TextBox15.Text = "4.00"
        ElseIf TextBox1.Text >= 113 And TextBox1.Text <= 119 Then
            TextBox8.Text = "A"
            TextBox15.Text = "3.75"
        ElseIf TextBox1.Text >= 105 And TextBox1.Text <= 112 Then
            TextBox8.Text = "A-"
            TextBox15.Text = "3.50"
        ElseIf TextBox1.Text >= 98 And TextBox1.Text <= 104 Then
            TextBox8.Text = "B+"
            TextBox15.Text = "3.25"
        ElseIf TextBox1.Text >= 90 And TextBox1.Text <= 97 Then
            TextBox8.Text = "B"
            TextBox15.Text = "3.00"
        ElseIf TextBox1.Text >= 83 And TextBox1.Text <= 89 Then
            TextBox8.Text = "B-"
            TextBox15.Text = "2.75"
        ElseIf TextBox1.Text >= 75 And TextBox1.Text <= 82 Then
            TextBox8.Text = "C+"
            TextBox15.Text = "2.50"
        ElseIf TextBox1.Text >= 68 And TextBox1.Text <= 74 Then
            TextBox8.Text = "C"
            TextBox15.Text = "2.25"
        ElseIf TextBox1.Text >= 60 And TextBox1.Text <= 67 Then
            TextBox8.Text = "D"
            TextBox15.Text = "2.00"
        Else
            TextBox8.Text = "F"
            TextBox15.Text = "0.00"
        End If
        If TextBox2.Text >= 80 And TextBox2.Text <= 100 Then
            TextBox9.Text = "A+"
            TextBox16.Text = "4.00"
        ElseIf TextBox2.Text >= 75 And TextBox2.Text <= 79 Then
            TextBox9.Text = "A"
            TextBox16.Text = "3.75"
        ElseIf TextBox2.Text >= 70 And TextBox2.Text <= 74 Then
            TextBox9.Text = "A-"
            TextBox16.Text = "3.50"
        ElseIf TextBox2.Text >= 65 And TextBox2.Text <= 69 Then
            TextBox9.Text = "B+"
            TextBox16.Text = "3.25"
        ElseIf TextBox2.Text >= 60 And TextBox2.Text <= 64 Then
            TextBox9.Text = "B"
            TextBox16.Text = "3.00"
        ElseIf TextBox2.Text >= 55 And TextBox2.Text <= 69 Then
            TextBox9.Text = "B-"
            TextBox16.Text = "2.75"
        ElseIf TextBox2.Text >= 50 And TextBox2.Text <= 54 Then
            TextBox9.Text = "C+"
            TextBox16.Text = "2.50"
        ElseIf TextBox2.Text >= 45 And TextBox2.Text <= 49 Then
            TextBox9.Text = "C"
            TextBox16.Text = "2.25"
        ElseIf TextBox2.Text >= 40 And TextBox2.Text <= 44 Then
            TextBox9.Text = "D"
            TextBox16.Text = "2.00"
        Else
            TextBox9.Text = "F"
            TextBox16.Text = "0.00"
        End If
        If TextBox3.Text >= 120 And TextBox3.Text <= 150 Then
            TextBox10.Text = "A+"
            TextBox17.Text = "4.00"
        ElseIf TextBox3.Text >= 113 And TextBox3.Text <= 119 Then
            TextBox10.Text = "A"
            TextBox17.Text = "3.75"
        ElseIf TextBox3.Text >= 105 And TextBox3.Text <= 112 Then
            TextBox10.Text = "A-"
            TextBox17.Text = "3.50"
        ElseIf TextBox3.Text >= 98 And TextBox3.Text <= 104 Then
            TextBox10.Text = "B+"
            TextBox17.Text = "3.25"
        ElseIf TextBox3.Text >= 90 And TextBox3.Text <= 97 Then
            TextBox10.Text = "B"
            TextBox17.Text = "3.00"
        ElseIf TextBox3.Text >= 83 And TextBox3.Text <= 89 Then
            TextBox10.Text = "B-"
            TextBox17.Text = "2.75"
        ElseIf TextBox3.Text >= 75 And TextBox3.Text <= 82 Then
            TextBox10.Text = "C+"
            TextBox17.Text = "2.50"
        ElseIf TextBox3.Text >= 68 And TextBox3.Text <= 74 Then
            TextBox10.Text = "C"
            TextBox17.Text = "2.25"
        ElseIf TextBox3.Text >= 60 And TextBox3.Text <= 67 Then
            TextBox10.Text = "D"
            TextBox17.Text = "2.00"
        Else
            TextBox10.Text = "F"
            TextBox17.Text = "0.00"
        End If
        If TextBox4.Text >= 120 And TextBox4.Text <= 150 Then
            TextBox11.Text = "A+"
            TextBox18.Text = "4.00"
        ElseIf TextBox4.Text >= 113 And TextBox4.Text <= 119 Then
            TextBox11.Text = "A"
            TextBox18.Text = "3.75"
        ElseIf TextBox4.Text >= 105 And TextBox4.Text <= 112 Then
            TextBox11.Text = "A-"
            TextBox18.Text = "3.50"
        ElseIf TextBox4.Text >= 98 And TextBox4.Text <= 104 Then
            TextBox11.Text = "B+"
            TextBox18.Text = "3.25"
        ElseIf TextBox4.Text >= 90 And TextBox4.Text <= 97 Then
            TextBox11.Text = "B"
            TextBox18.Text = "3.00"
        ElseIf TextBox4.Text >= 83 And TextBox4.Text <= 89 Then
            TextBox11.Text = "B-"
            TextBox18.Text = "2.75"
        ElseIf TextBox4.Text >= 75 And TextBox4.Text <= 82 Then
            TextBox11.Text = "C+"
            TextBox18.Text = "2.50"
        ElseIf TextBox4.Text >= 68 And TextBox4.Text <= 74 Then
            TextBox11.Text = "C"
            TextBox18.Text = "2.25"
        ElseIf TextBox4.Text >= 60 And TextBox4.Text <= 67 Then
            TextBox11.Text = "D"
            TextBox18.Text = "2.00"
        Else
            TextBox11.Text = "F"
            TextBox18.Text = "0.00"
        End If
        If TextBox5.Text >= 160 And TextBox5.Text <= 200 Then
            TextBox12.Text = "A+"
            TextBox19.Text = "4.00"
        ElseIf TextBox5.Text >= 150 And TextBox5.Text <= 159 Then
            TextBox12.Text = "A"
            TextBox19.Text = "3.75"
        ElseIf TextBox5.Text >= 140 And TextBox5.Text <= 149 Then
            TextBox12.Text = "A-"
            TextBox19.Text = "3.50"
        ElseIf TextBox5.Text >= 130 And TextBox5.Text <= 139 Then
            TextBox12.Text = "B+"
            TextBox19.Text = "3.25"
        ElseIf TextBox5.Text >= 120 And TextBox5.Text <= 129 Then
            TextBox12.Text = "B"
            TextBox19.Text = "3.00"
        ElseIf TextBox5.Text >= 110 And TextBox5.Text <= 119 Then
            TextBox12.Text = "B-"
            TextBox19.Text = "2.75"
        ElseIf TextBox5.Text >= 100 And TextBox5.Text <= 109 Then
            TextBox12.Text = "C+"
            TextBox19.Text = "2.50"
        ElseIf TextBox5.Text >= 90 And TextBox5.Text <= 99 Then
            TextBox12.Text = "C"
            TextBox19.Text = "2.25"
        ElseIf TextBox5.Text >= 80 And TextBox5.Text <= 89 Then
            TextBox12.Text = "D"
            TextBox19.Text = "2.00"
        Else
            TextBox12.Text = "F"
            TextBox19.Text = "0.00"
        End If
        If TextBox6.Text >= 120 And TextBox6.Text <= 150 Then
            TextBox13.Text = "A+"
            TextBox20.Text = "4.00"
        ElseIf TextBox6.Text >= 113 And TextBox6.Text <= 119 Then
            TextBox13.Text = "A"
            TextBox20.Text = "3.75"
        ElseIf TextBox6.Text >= 105 And TextBox6.Text <= 112 Then
            TextBox13.Text = "A-"
            TextBox20.Text = "3.50"
        ElseIf TextBox6.Text >= 98 And TextBox6.Text <= 104 Then
            TextBox13.Text = "B+"
            TextBox20.Text = "3.25"
        ElseIf TextBox6.Text >= 90 And TextBox6.Text <= 97 Then
            TextBox13.Text = "B"
            TextBox20.Text = "3.00"
        ElseIf TextBox6.Text >= 83 And TextBox6.Text <= 89 Then
            TextBox13.Text = "B-"
            TextBox20.Text = "2.75"
        ElseIf TextBox6.Text >= 75 And TextBox6.Text <= 82 Then
            TextBox13.Text = "C+"
            TextBox20.Text = "2.50"
        ElseIf TextBox6.Text >= 68 And TextBox6.Text <= 74 Then
            TextBox13.Text = "C"
            TextBox20.Text = "2.25"
        ElseIf TextBox6.Text >= 60 And TextBox6.Text <= 67 Then
            TextBox13.Text = "D"
            TextBox20.Text = "2.00"
        Else
            TextBox13.Text = "F"
            TextBox20.Text = "0.00"
        End If
        If TextBox7.Text >= 120 And TextBox7.Text <= 150 Then
            TextBox14.Text = "A+"
            TextBox21.Text = "4.00"
        ElseIf TextBox7.Text >= 113 And TextBox7.Text <= 119 Then
            TextBox14.Text = "A"
            TextBox21.Text = "3.75"
        ElseIf TextBox7.Text >= 105 And TextBox7.Text <= 112 Then
            TextBox14.Text = "A-"
            TextBox21.Text = "3.50"
        ElseIf TextBox7.Text >= 98 And TextBox7.Text <= 104 Then
            TextBox14.Text = "B+"
            TextBox21.Text = "3.25"
        ElseIf TextBox7.Text >= 90 And TextBox7.Text <= 97 Then
            TextBox14.Text = "B"
            TextBox21.Text = "3.00"
        ElseIf TextBox7.Text >= 83 And TextBox7.Text <= 89 Then
            TextBox14.Text = "B-"
            TextBox21.Text = "2.75"
        ElseIf TextBox7.Text >= 75 And TextBox7.Text <= 82 Then
            TextBox14.Text = "C+"
            TextBox21.Text = "2.50"
        ElseIf TextBox7.Text >= 68 And TextBox7.Text <= 74 Then
            TextBox14.Text = "C"
            TextBox21.Text = "2.25"
        ElseIf TextBox7.Text >= 60 And TextBox7.Text <= 67 Then
            TextBox14.Text = "D"
            TextBox21.Text = "2.00"
        Else
            TextBox14.Text = "F"
            TextBox21.Text = "0.00"
        End If
        TextBox22.Text = (Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text) + Val(TextBox18.Text) + Val(TextBox19.Text) + Val(TextBox20.Text) + Val(TextBox21.Text)) / 7
        If TextBox22.Text = 4 Then
            TextBox23.Text = "A+"
        ElseIf TextBox22.Text >= 3.75 And TextBox22.Text <= 3.99 Then
            TextBox23.Text = "A"
        ElseIf TextBox22.Text >= 3.5 And TextBox22.Text <= 3.74 Then
            TextBox23.Text = "A-"
        ElseIf TextBox22.Text >= 3.25 And TextBox22.Text <= 3.49 Then
            TextBox23.Text = "B+"
        ElseIf TextBox22.Text >= 3.0 And TextBox22.Text <= 3.24 Then
            TextBox23.Text = "B"
        ElseIf TextBox22.Text >= 2.75 And TextBox22.Text <= 2.99 Then
            TextBox23.Text = "B-"
        ElseIf TextBox22.Text >= 2.5 And TextBox22.Text <= 2.74 Then
            TextBox23.Text = "C+"
        ElseIf TextBox22.Text >= 2.25 And TextBox22.Text <= 2.49 Then
            TextBox23.Text = "C"
        ElseIf TextBox22.Text >= 2.0 And TextBox22.Text <= 2.24 Then
            TextBox23.Text = "D"

        Else
            TextBox23.Text = "F"

        End If
        Form10.TextBox11.Text = Val(TextBox22.Text)
        Form10.TextBox3.Text = TextBox23.Text
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Form5.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Form3.Show()
    End Sub
End Class