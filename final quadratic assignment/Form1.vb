Public Class Form

    Private Sub btncompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncompute.Click
        Dim a As Single
        Dim b As Single
        Dim c As Single
        Dim x1 As Single
        Dim x2 As Single
        a = Val(TxtA.Text)
        b = Val(TxtB.Text)
        c = Val(TxtC.Text)
        x1 = (-b + Math.Sqrt(Math.Abs(b ^ 2 - 4 * a * c))) / (2 * a)
        x2 = (-b - Math.Sqrt(Math.Abs(b ^ 2 - 4 * a * c))) / (2 * a)
        txtresult.Text = "The value of X is" & x1 & "or" & x2
    End Sub
End Class
