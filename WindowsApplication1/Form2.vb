Public Class Form2
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        pb1.Value = pb1.Value + 10

        If pb1.Value = pb1.Maximum Then
            Timer1.Enabled = False
            pb1.Visible = False

            Label4.Visible = True
            Label5.Visible = True
            DateTimePicker1.Visible = True
            selected.Visible = True
            Button1.Visible = True

        End If


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Timer2.Enabled = True
        Label4.Visible = False
        DateTimePicker1.Visible = False
        Button1.Visible = False
        pb2.Visible = True
        Label6.Visible = True
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick

        pb2.Value = pb2.Value + 20

        If pb2.Value = pb2.Maximum Then
            Timer2.Enabled = False
            Me.Visible = False
            Form3.Visible = True

        End If


    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick

        pbh.Value = pbh.Value + 1

        If pbh.Value = 2 Then
            Label2.Visible = True
        End If

        If pbh.Value = 3 Then
            Label3.Visible = True
        End If

        If pbh.Value = pbh.Maximum Then

            Timer3.Enabled = False
            Timer1.Enabled = True
            pb1.Visible = True

        End If

    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Timer3.Enabled = True

    End Sub
    Private Sub DateTimePicker1_ValueChanged_1(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        selected.Text = DateTimePicker1.Value
    End Sub

    Private Sub Window1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        End
    End Sub

End Class