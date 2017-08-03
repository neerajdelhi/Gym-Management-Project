Public Class userlogin

    Private Sub userlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("No Username/Password Found", MsgBoxStyle.Critical, "Error")
        ElseIf TextBox1.Text = "" Then
            MsgBox("No Username Found", MsgBoxStyle.Critical, "Error")
        ElseIf TextBox2.Text = "" Then
            MsgBox("No Password Found", MsgBoxStyle.Critical, "Error")
        Else
            MsgBox("You are Logged in", MsgBoxStyle.Information, "Loged")
            bmi.Show()
        End If
    End Sub
End Class