Public Class adminlogin

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "neeraj" And TextBox2.Text = "sharma" Then
            MsgBox("You are Logged In!", MsgBoxStyle.Information, "Login")
        ElseIf TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("No Username/Password Found", MsgBoxStyle.Critical, "Error")
        ElseIf TextBox1.Text = "" Then
            MsgBox("No Username Found", MsgBoxStyle.Critical, "Error")
        ElseIf TextBox2.Text = "" Then
            MsgBox("No Password Found", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class