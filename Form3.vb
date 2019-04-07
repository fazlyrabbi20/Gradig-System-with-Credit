Public Class Form3

    Private Sub Button21_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs)
        Form4.Show()
    End Sub

    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox24_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button21_Click_1(sender As Object, e As EventArgs) Handles Button21.Click
        If TextBox1.Text >= 80 And TextBox1.Text <= 100 Then
            TextBox9.Text = "A+"
            TextBox17.Text = "4.00"
        ElseIf TextBox1.Text >= 75 And TextBox1.Text <= 79 Then
            TextBox9.Text = "A"
            TextBox17.Text = "3.75"
        ElseIf TextBox1.Text >= 70 And TextBox1.Text <= 74 Then
            TextBox9.Text = "A-"
            TextBox17.Text = "3.50"
        ElseIf TextBox1.Text >= 65 And TextBox1.Text <= 69 Then
            TextBox9.Text = "B+"
            TextBox17.Text = "3.25"
        ElseIf TextBox1.Text >= 60 And TextBox1.Text <= 64 Then
            TextBox9.Text = "B"
            TextBox17.Text = "3.00"
        ElseIf TextBox1.Text >= 55 And TextBox1.Text <= 69 Then
            TextBox9.Text = "B-"
            TextBox17.Text = "2.75"
        ElseIf TextBox1.Text >= 50 And TextBox1.Text <= 54 Then
            TextBox9.Text = "C+"
            TextBox17.Text = "2.50"
        ElseIf TextBox1.Text >= 45 And TextBox1.Text <= 49 Then
            TextBox9.Text = "C"
            TextBox17.Text = "2.25"
        ElseIf TextBox1.Text >= 40 And TextBox1.Text <= 44 Then
            TextBox9.Text = "D"
            TextBox17.Text = "2.00"
        Else
            TextBox9.Text = "F"
            TextBox17.Text = "0.00"
        End If
        If TextBox2.Text >= 80 And TextBox2.Text <= 100 Then
            TextBox10.Text = "A+"
            TextBox18.Text = "4.00"
        ElseIf TextBox2.Text >= 75 And TextBox2.Text <= 79 Then
            TextBox10.Text = "A"
            TextBox18.Text = "3.75"
        ElseIf TextBox2.Text >= 70 And TextBox2.Text <= 74 Then
            TextBox10.Text = "A-"
            TextBox18.Text = "3.50"
        ElseIf TextBox2.Text >= 65 And TextBox2.Text <= 69 Then
            TextBox10.Text = "B+"
            TextBox18.Text = "3.25"
        ElseIf TextBox2.Text >= 60 And TextBox2.Text <= 64 Then
            TextBox10.Text = "B"
            TextBox18.Text = "3.00"
        ElseIf TextBox2.Text >= 55 And TextBox2.Text <= 69 Then
            TextBox10.Text = "B-"
            TextBox18.Text = "2.75"
        ElseIf TextBox2.Text >= 50 And TextBox2.Text <= 54 Then
            TextBox10.Text = "C+"
            TextBox18.Text = "2.50"
        ElseIf TextBox2.Text >= 45 And TextBox2.Text <= 49 Then
            TextBox10.Text = "C"
            TextBox18.Text = "2.25"
        ElseIf TextBox2.Text >= 40 And TextBox2.Text <= 44 Then
            TextBox10.Text = "D"
            TextBox18.Text = "2.00"
        Else
            TextBox10.Text = "F"
            TextBox18.Text = "0.00"
        End If
        If TextBox3.Text >= 160 And TextBox3.Text <= 200 Then
            TextBox11.Text = "A+"
            TextBox19.Text = "4.00"
        ElseIf TextBox3.Text >= 150 And TextBox3.Text <= 159 Then
            TextBox11.Text = "A"
            TextBox19.Text = "3.75"
        ElseIf TextBox3.Text >= 140 And TextBox3.Text <= 149 Then
            TextBox11.Text = "A-"
            TextBox19.Text = "3.50"
        ElseIf TextBox3.Text >= 130 And TextBox3.Text <= 139 Then
            TextBox11.Text = "B+"
            TextBox19.Text = "3.25"
        ElseIf TextBox3.Text >= 120 And TextBox3.Text <= 129 Then
            TextBox11.Text = "B"
            TextBox19.Text = "3.00"
        ElseIf TextBox3.Text >= 110 And TextBox3.Text <= 119 Then
            TextBox11.Text = "B-"
            TextBox19.Text = "2.75"
        ElseIf TextBox3.Text >= 100 And TextBox3.Text <= 109 Then
            TextBox11.Text = "C+"
            TextBox19.Text = "2.50"
        ElseIf TextBox3.Text >= 90 And TextBox3.Text <= 99 Then
            TextBox11.Text = "C"
            TextBox19.Text = "2.25"
        ElseIf TextBox3.Text >= 80 And TextBox3.Text <= 89 Then
            TextBox11.Text = "D"
            TextBox19.Text = "2.00"
        Else
            TextBox11.Text = "F"
            TextBox19.Text = "0.00"
        End If
        If TextBox4.Text >= 160 And TextBox4.Text <= 200 Then
            TextBox12.Text = "A+"
            TextBox20.Text = "4.00"
        ElseIf TextBox4.Text >= 150 And TextBox4.Text <= 159 Then
            TextBox12.Text = "A"
            TextBox20.Text = "3.75"
        ElseIf TextBox4.Text >= 140 And TextBox4.Text <= 149 Then
            TextBox12.Text = "A-"
            TextBox20.Text = "3.50"
        ElseIf TextBox4.Text >= 130 And TextBox4.Text <= 139 Then
            TextBox12.Text = "B+"
            TextBox20.Text = "3.25"
        ElseIf TextBox4.Text >= 120 And TextBox4.Text <= 129 Then
            TextBox12.Text = "B"
            TextBox20.Text = "3.00"
        ElseIf TextBox4.Text >= 110 And TextBox4.Text <= 119 Then
            TextBox12.Text = "B-"
            TextBox20.Text = "2.75"
        ElseIf TextBox4.Text >= 100 And TextBox4.Text <= 109 Then
            TextBox12.Text = "C+"
            TextBox20.Text = "2.50"
        ElseIf TextBox4.Text >= 90 And TextBox4.Text <= 99 Then
            TextBox12.Text = "C"
            TextBox20.Text = "2.25"
        ElseIf TextBox4.Text >= 80 And TextBox4.Text <= 89 Then
            TextBox12.Text = "D"
            TextBox20.Text = "2.00"
        Else
            TextBox12.Text = "F"
            TextBox20.Text = "0.00"
        End If
        If TextBox5.Text >= 80 And TextBox5.Text <= 100 Then
            TextBox13.Text = "A+"
            TextBox21.Text = "4.00"
        ElseIf TextBox5.Text >= 75 And TextBox5.Text <= 79 Then
            TextBox13.Text = "A"
            TextBox21.Text = "3.75"
        ElseIf TextBox5.Text >= 70 And TextBox5.Text <= 74 Then
            TextBox13.Text = "A-"
            TextBox21.Text = "3.50"
        ElseIf TextBox5.Text >= 65 And TextBox5.Text <= 69 Then
            TextBox13.Text = "B+"
            TextBox21.Text = "3.25"
        ElseIf TextBox5.Text >= 60 And TextBox5.Text <= 64 Then
            TextBox13.Text = "B"
            TextBox21.Text = "3.00"
        ElseIf TextBox5.Text >= 55 And TextBox5.Text <= 69 Then
            TextBox13.Text = "B-"
            TextBox21.Text = "2.75"
        ElseIf TextBox5.Text >= 50 And TextBox5.Text <= 54 Then
            TextBox13.Text = "C+"
            TextBox21.Text = "2.50"
        ElseIf TextBox5.Text >= 45 And TextBox5.Text <= 49 Then
            TextBox13.Text = "C"
            TextBox21.Text = "2.25"
        ElseIf TextBox5.Text >= 40 And TextBox5.Text <= 44 Then
            TextBox13.Text = "D"
            TextBox21.Text = "2.00"
        Else
            TextBox13.Text = "F"
            TextBox21.Text = "0.00"
        End If
        If TextBox6.Text >= 120 And TextBox6.Text <= 150 Then
            TextBox14.Text = "A+"
            TextBox22.Text = "4.00"
        ElseIf TextBox6.Text >= 113 And TextBox6.Text <= 119 Then
            TextBox14.Text = "A"
            TextBox22.Text = "3.75"
        ElseIf TextBox6.Text >= 105 And TextBox6.Text <= 112 Then
            TextBox14.Text = "A-"
            TextBox22.Text = "3.50"
        ElseIf TextBox6.Text >= 98 And TextBox6.Text <= 104 Then
            TextBox14.Text = "B+"
            TextBox22.Text = "3.25"
        ElseIf TextBox6.Text >= 90 And TextBox6.Text <= 97 Then
            TextBox14.Text = "B"
            TextBox22.Text = "3.00"
        ElseIf TextBox6.Text >= 83 And TextBox6.Text <= 89 Then
            TextBox14.Text = "B-"
            TextBox22.Text = "2.75"
        ElseIf TextBox6.Text >= 75 And TextBox6.Text <= 82 Then
            TextBox14.Text = "C+"
            TextBox22.Text = "2.50"
        ElseIf TextBox6.Text >= 68 And TextBox6.Text <= 74 Then
            TextBox14.Text = "C"
            TextBox22.Text = "2.25"
        ElseIf TextBox6.Text >= 60 And TextBox6.Text <= 67 Then
            TextBox14.Text = "D"
            TextBox22.Text = "2.00"
        Else
            TextBox14.Text = "F"
            TextBox22.Text = "0.00"
        End If
        If TextBox7.Text >= 120 And TextBox7.Text <= 150 Then
            TextBox15.Text = "A+"
            TextBox23.Text = "4.00"
        ElseIf TextBox7.Text >= 113 And TextBox7.Text <= 119 Then
            TextBox15.Text = "A"
            TextBox23.Text = "3.75"
        ElseIf TextBox7.Text >= 105 And TextBox7.Text <= 112 Then
            TextBox15.Text = "A-"
            TextBox23.Text = "3.50"
        ElseIf TextBox7.Text >= 98 And TextBox7.Text <= 104 Then
            TextBox15.Text = "B+"
            TextBox23.Text = "3.25"
        ElseIf TextBox7.Text >= 90 And TextBox7.Text <= 97 Then
            TextBox15.Text = "B"
            TextBox23.Text = "3.00"
        ElseIf TextBox7.Text >= 83 And TextBox7.Text <= 89 Then
            TextBox15.Text = "B-"
            TextBox23.Text = "2.75"
        ElseIf TextBox7.Text >= 75 And TextBox7.Text <= 82 Then
            TextBox15.Text = "C+"
            TextBox23.Text = "2.50"
        ElseIf TextBox7.Text >= 68 And TextBox7.Text <= 74 Then
            TextBox15.Text = "C"
            TextBox23.Text = "2.25"
        ElseIf TextBox7.Text >= 60 And TextBox7.Text <= 67 Then
            TextBox15.Text = "D"
            TextBox23.Text = "2.00"
        Else
            TextBox15.Text = "F"
            TextBox23.Text = "0.00"
        End If
        If TextBox8.Text >= 120 And TextBox8.Text <= 150 Then
            TextBox16.Text = "A+"
            TextBox24.Text = "4.00"
        ElseIf TextBox8.Text >= 113 And TextBox8.Text <= 119 Then
            TextBox16.Text = "A"
            TextBox24.Text = "3.75"
        ElseIf TextBox8.Text >= 105 And TextBox8.Text <= 112 Then
            TextBox16.Text = "A-"
            TextBox24.Text = "3.50"
        ElseIf TextBox8.Text >= 98 And TextBox8.Text <= 104 Then
            TextBox16.Text = "B+"
            TextBox24.Text = "3.25"
        ElseIf TextBox8.Text >= 90 And TextBox8.Text <= 97 Then
            TextBox16.Text = "B"
            TextBox24.Text = "3.00"
        ElseIf TextBox8.Text >= 83 And TextBox8.Text <= 89 Then
            TextBox16.Text = "B-"
            TextBox24.Text = "2.75"
        ElseIf TextBox8.Text >= 75 And TextBox8.Text <= 82 Then
            TextBox16.Text = "C+"
            TextBox24.Text = "2.50"
        ElseIf TextBox8.Text >= 68 And TextBox8.Text <= 74 Then
            TextBox16.Text = "C"
            TextBox24.Text = "2.25"
        ElseIf TextBox8.Text >= 60 And TextBox8.Text <= 67 Then
            TextBox16.Text = "D"
            TextBox24.Text = "2.00"
        Else
            TextBox16.Text = "F"
            TextBox24.Text = "0.00"
        End If
        TextBox25.Text = (Val(TextBox17.Text) + Val(TextBox18.Text) + Val(TextBox19.Text) + Val(TextBox20.Text) + Val(TextBox21.Text) + Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text)) / 8
        If TextBox25.Text = 4 Then
            TextBox26.Text = "A+"
        ElseIf TextBox25.Text >= 3.75 And TextBox25.Text <= 3.99 Then
            TextBox26.Text = "A"
        ElseIf TextBox25.Text >= 3.5 And TextBox25.Text <= 3.74 Then
            TextBox26.Text = "A-"
        ElseIf TextBox25.Text >= 3.25 And TextBox25.Text <= 3.49 Then
            TextBox26.Text = "B+"
        ElseIf TextBox25.Text >= 3.0 And TextBox25.Text <= 3.24 Then
            TextBox26.Text = "B"
        ElseIf TextBox25.Text >= 2.75 And TextBox25.Text <= 2.99 Then
            TextBox26.Text = "B-"
        ElseIf TextBox25.Text >= 2.5 And TextBox25.Text <= 2.74 Then
            TextBox26.Text = "C+"
        ElseIf TextBox25.Text >= 2.25 And TextBox25.Text <= 2.49 Then
            TextBox26.Text = "C"
        ElseIf TextBox25.Text >= 2.0 And TextBox25.Text <= 2.24 Then
            TextBox26.Text = "D"

        Else
            TextBox26.Text = "F"

        End If
        Form10.TextBox10.Text = Val(TextBox25.Text)
        Form10.TextBox2.Text = TextBox26.Text
    End Sub

    Private Sub Button22_Click_1(sender As Object, e As EventArgs) Handles Button22.Click
        Form4.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Form2.Show()
    End Sub
End Class