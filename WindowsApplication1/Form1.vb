Public Class Form1
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        pb1.Value = pb1.Value + 1

        If pb1.Value = pb1.Maximum Then
            Timer1.Enabled = False
            Label5.Visible = True
            Timer2.Enabled = True
        End If

        If pb1.Value = 3 Then
            Label3.Visible = True
        End If

        If pb1.Value = 4 Then
            Label4.Visible = True
        End If


    End Sub


    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick

        If pb2.Value <= 10 Then
            count.Text = 10 - Val(pb2.Value)
        End If
        pb2.Value = pb2.Value + 1

        If pb2.Value = 11 Then

            Label4.Enabled = False
            LineShape1.Visible = True
            LineShape2.Visible = True
            Label7.Visible = True

        End If

        If pb2.Value = pb2.Maximum Then

            Timer2.Enabled = False
            Me.Visible = False
            Form2.Visible = True

        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Label1.Visible = True
        Timer1.Enabled = True
        Button1.Visible = False

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

        Timer2.Enabled = False
        Me.Visible = False
        Form2.Visible = True

    End Sub

    Private Sub Window1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        End
    End Sub

End Class
