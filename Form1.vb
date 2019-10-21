Public Class Form1
    Dim number As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        Const CARA As Integer = 1
        Const COROA As Integer = 2

        number = (2 * Rnd())


        If rdbCARA.Checked And number = CARA Then
            Label1.Text = "CARA, Ganhou!"
        ElseIf rdbCARA.Checked And number = COROA Then
            Label1.Text = "COROA, Perdeu!"
        End If





        If rdbCOROA.Checked And number = COROA Then
            Label1.Text = "COROA, Ganhou!"
        ElseIf rdbCOROA.Checked And number = CARA Then
            Label1.Text = "CARA, Perdeu!"
        End If

        If number = CARA Then
            PictureBox1.BackgroundImage = My.Resources.cara
        ElseIf number = COROA Then
            PictureBox1.BackgroundImage = My.Resources.coroa
        End If
    End Sub
End Class