﻿Public Class Form4

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim mes As String = Date.Now.Month.ToString()

        Select Case mes
            Case 12 Or 1 Or 2
                Me.BackgroundImage = My.Resources.inverno
            Case 3 Or 4 Or 5
                Me.BackgroundImage = My.Resources.primavera
            Case 6 Or 7 Or 8
                Me.BackgroundImage = My.Resources.verao
            Case 9 Or 10 Or 11
                Me.BackgroundImage = My.Resources.outono
        End Select
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub TextBox1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Clear()


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form5.Show()

    End Sub
End Class