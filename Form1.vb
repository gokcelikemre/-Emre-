Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox6.ReadOnly = True
        TextBox7.ReadOnly = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vize, fnl As Integer
        Dim gnot As Double
        vize = TextBox4.Text
        fnl = TextBox5.Text

        If (TextBox4.Text > 100) Then
            MsgBox("Vize notu 0-100 arasında olmalı")
        End If
        If (TextBox5.Text > 100) Then
            MsgBox("Final notu 0-100 arasında olmalı")
        End If
        gnot = vize * 0.4 + fnl * 0.6
        TextBox6.Text = gnot
        'If 100 < gnot < 90 Then
        '    TextBox7.Text = "AA"
        'ElseIf 90 < gnot < 80 Then
        '    TextBox7.Text = "BA"
        'ElseIf 80 < gnot < 70 Then
        '    TextBox7.Text = "BB"
        'ElseIf 70 < gnot < 60 Then
        '    TextBox7.Text = "CB"
        'ElseIf 60 < gnot < 50 Then
        '    TextBox7.Text = "CC"
        'ElseIf 50 < gnot < 40 Then
        '    TextBox7.Text = "CD"
        'ElseIf 40 < gnot < 30 Then
        '    TextBox7.Text = "DD"
        'ElseIf 30 < gnot < 20 Then
        '    TextBox7.Text = "FD"
        'ElseIf Gnot < 20 Then
        '    TextBox7.Text = "FF"
        'End If

        If gnot > 90 And gnot < 100 Then
            TextBox7.Text = "AA"
        End If
        If gnot > 80 And gnot < 90 Then
            TextBox7.Text = "BA"
        End If
        If gnot > 70 And gnot < 80 Then
            TextBox7.Text = "BB"
        End If
        If gnot > 60 And gnot < 70 Then
            TextBox7.Text = "CB"
        End If
        If gnot > 50 And gnot < 60 Then
            TextBox7.Text = "CC"
        End If
        If gnot > 40 And gnot < 50 Then
            TextBox7.Text = "CD"
        End If
        If gnot > 30 And gnot < 40 Then
            TextBox7.Text = "DD"
        End If
        If gnot > 20 And gnot < 30 Then
            TextBox7.Text = "FD"
        End If
        If gnot < 20 Then
            TextBox7.Text = "FF"
        End If
        If gnot >= 50 Then
            TextBox6.BackColor = Color.Green
        Else
            TextBox6.BackColor = Color.Red
        End If




    End Sub

    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles TextBox1.Validated
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Öğrenci no boş geçilemez")
        Else
            ErrorProvider1.SetError(TextBox1, Nothing)
        End If

    End Sub

    Private Sub TextBox2_Validated(sender As Object, e As EventArgs) Handles TextBox2.Validated
        If TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "Ad  alanı boş geçilemez")
        Else
            ErrorProvider1.SetError(TextBox2, Nothing)
        End If
    End Sub

    Private Sub TextBox3_Validated(sender As Object, e As EventArgs) Handles TextBox3.Validated
        If TextBox3.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "Soyadı  boş geçilemez")
        Else
            ErrorProvider1.SetError(TextBox3, Nothing)
        End If
    End Sub

    Private Sub TextBox4_Validated(sender As Object, e As EventArgs) Handles TextBox4.Validated
        If TextBox4.Text = "" Then
            ErrorProvider1.SetError(TextBox4, "Arasınav alanı  boş geçilemez")
        Else
            ErrorProvider1.SetError(TextBox4, Nothing)
        End If
    End Sub

    Private Sub Form1_Validated(sender As Object, e As EventArgs) Handles MyBase.Validated

    End Sub

    Private Sub TextBox5_Validated(sender As Object, e As EventArgs) Handles TextBox5.Validated
        If TextBox5.Text = "" Then
            ErrorProvider1.SetError(TextBox5, "Final boş geçilemez")
        Else
            ErrorProvider1.SetError(TextBox5, Nothing)
        End If
    End Sub
End Class
