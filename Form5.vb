Public Class Form5

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
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
        If TextBox5.Text >= 120 And TextBox5.Text <= 150 Then
            TextBox12.Text = "A+"
            TextBox19.Text = "4.00"
        ElseIf TextBox5.Text >= 113 And TextBox5.Text <= 119 Then
            TextBox12.Text = "A"
            TextBox19.Text = "3.75"
        ElseIf TextBox5.Text >= 105 And TextBox5.Text <= 112 Then
            TextBox12.Text = "A-"
            TextBox19.Text = "3.50"
        ElseIf TextBox5.Text >= 98 And TextBox5.Text <= 104 Then
            TextBox12.Text = "B+"
            TextBox19.Text = "3.25"
        ElseIf TextBox5.Text >= 90 And TextBox5.Text <= 97 Then
            TextBox12.Text = "B"
            TextBox19.Text = "3.00"
        ElseIf TextBox5.Text >= 83 And TextBox5.Text <= 89 Then
            TextBox12.Text = "B-"
            TextBox19.Text = "2.75"
        ElseIf TextBox5.Text >= 75 And TextBox5.Text <= 82 Then
            TextBox12.Text = "C+"
            TextBox19.Text = "2.50"
        ElseIf TextBox5.Text >= 68 And TextBox5.Text <= 74 Then
            TextBox12.Text = "C"
            TextBox19.Text = "2.25"
        ElseIf TextBox5.Text >= 60 And TextBox5.Text <= 67 Then
            TextBox12.Text = "D"
            TextBox19.Text = "2.00"
        Else
            TextBox12.Text = "F"
            TextBox19.Text = "0.00"
        End If
        If TextBox6.Text >= 80 And TextBox6.Text <= 100 Then
            TextBox13.Text = "A+"
            TextBox20.Text = "4.00"
        ElseIf TextBox6.Text >= 75 And TextBox6.Text <= 79 Then
            TextBox13.Text = "A"
            TextBox20.Text = "3.75"
        ElseIf TextBox6.Text >= 70 And TextBox6.Text <= 74 Then
            TextBox13.Text = "A-"
            TextBox20.Text = "3.50"
        ElseIf TextBox6.Text >= 65 And TextBox6.Text <= 69 Then
            TextBox13.Text = "B+"
            TextBox20.Text = "3.25"
        ElseIf TextBox6.Text >= 60 And TextBox6.Text <= 64 Then
            TextBox13.Text = "B"
            TextBox20.Text = "3.00"
        ElseIf TextBox6.Text >= 55 And TextBox6.Text <= 69 Then
            TextBox13.Text = "B-"
            TextBox20.Text = "2.75"
        ElseIf TextBox6.Text >= 50 And TextBox6.Text <= 54 Then
            TextBox13.Text = "C+"
            TextBox20.Text = "2.50"
        ElseIf TextBox6.Text >= 45 And TextBox6.Text <= 49 Then
            TextBox13.Text = "C"
            TextBox20.Text = "2.25"
        ElseIf TextBox6.Text >= 40 And TextBox6.Text <= 44 Then
            TextBox13.Text = "D"
            TextBox20.Text = "2.00"
        Else
            TextBox13.Text = "F"
            TextBox20.Text = "0.00"
        End If
        If TextBox7.Text >= 80 And TextBox7.Text <= 100 Then
            TextBox14.Text = "A+"
            TextBox21.Text = "4.00"
        ElseIf TextBox7.Text >= 75 And TextBox7.Text <= 79 Then
            TextBox14.Text = "A"
            TextBox21.Text = "3.75"
        ElseIf TextBox7.Text >= 70 And TextBox7.Text <= 74 Then
            TextBox14.Text = "A-"
            TextBox21.Text = "3.50"
        ElseIf TextBox7.Text >= 65 And TextBox7.Text <= 69 Then
            TextBox14.Text = "B+"
            TextBox21.Text = "3.25"
        ElseIf TextBox7.Text >= 60 And TextBox7.Text <= 64 Then
            TextBox14.Text = "B"
            TextBox21.Text = "3.00"
        ElseIf TextBox7.Text >= 55 And TextBox7.Text <= 69 Then
            TextBox14.Text = "B-"
            TextBox21.Text = "2.75"
        ElseIf TextBox7.Text >= 50 And TextBox7.Text <= 54 Then
            TextBox14.Text = "C+"
            TextBox21.Text = "2.50"
        ElseIf TextBox7.Text >= 45 And TextBox7.Text <= 49 Then
            TextBox14.Text = "C"
            TextBox21.Text = "2.25"
        ElseIf TextBox7.Text >= 40 And TextBox7.Text <= 44 Then
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
        Form10.TextBox12.Text = Val(TextBox22.Text)
        Form10.TextBox4.Text = TextBox23.Text
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Form6.Show()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click

    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Form4.Show()
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles TextBox21.TextChanged

    End Sub

    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs) Handles TextBox20.TextChanged

    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.TextChanged

    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged

    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged

    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged

    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub

    Private Sub TextBox23_TextChanged(sender As Object, e As EventArgs) Handles TextBox23.TextChanged

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub TextBox22_TextChanged(sender As Object, e As EventArgs) Handles TextBox22.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click

    End Sub
End Class