Public Class Calculator
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click

    End Sub

    Private Sub Button40_MouseHover(sender As Object, e As EventArgs) Handles Button40.MouseHover
        Dim but As New ToolTip()
        but.SetToolTip(Button40, "History (Ctrl + H)")
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.MouseHover
        Dim navigation As New ToolTip()
        navigation.SetToolTip(Button39, "Open Navigation")
    End Sub
End Class
