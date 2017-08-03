Public Class bmi

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim w As Double
        Dim h As Double
        Dim result As Double
        w = TextBox1.Text
        h = TextBox2.Text
        result = (w / (h * h))
        MessageBox.Show("You BMI is " + result.ToString)
        Button3.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim w As Double
        Dim h As Double
        Dim result As Double
        w = TextBox1.Text
        h = TextBox2.Text
        result = (w / (h * h))

        If result < 18.5 Then
            underweight.Show()
        ElseIf result >= 18.5 And result <= 24.9 Then
            healtyweight.Show()
        ElseIf result >= 25.0 And result <= 29.9 Then
            overweight.Show()
        ElseIf result >= 30.0 Then
            obeseweight.Show()
        Else
            dietplan.Show()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        userlogin.Close()
        Form1.Show()
    End Sub
End Class