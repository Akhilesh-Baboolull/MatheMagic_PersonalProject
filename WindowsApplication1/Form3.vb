Public Class Form3

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim day As Integer
        Dim month As Integer
        Dim year As Integer
        Dim year1, year2 As String
        Dim total As Integer

        day = Val(Form2.DateTimePicker1.Value.Day)
        month = Val(Form2.DateTimePicker1.Value.Month)
        year = Val(Form2.DateTimePicker1.Value.Year)

        year1 = Mid(year, 1, 2)
        year2 = Mid(year, 3, 2)

        If (day >= 1) And (day <= 9) Then
            Ans1.Text = "0" & day
        Else
            Ans1.Text = day
        End If

        If (month >= 1) And (month <= 9) Then
            Ans2.Text = "0" & month
        Else
            Ans2.Text = month
        End If

        Ans3.Text = year1
        Ans4.Text = year2

        Ans5.Text = Ans4.Text
        Ans6.Text = Ans3.Text
        Ans7.Text = Ans2.Text
        Ans8.Text = Ans1.Text
        Ans9.Text = Ans2.Text
        Ans10.Text = Ans1.Text
        Ans11.Text = Ans4.Text
        Ans12.Text = Ans3.Text
        Ans13.Text = Ans3.Text
        Ans14.Text = Ans4.Text
        Ans15.Text = Ans1.Text
        Ans16.Text = Ans2.Text

        total = day + month + year1 + Val(year2)

        S1.Text = total
        S2.Text = total
        S3.Text = total
        S4.Text = total
        S5.Text = total
        S6.Text = total
        S7.Text = total
        S8.Text = total
        S9.Text = total
        S10.Text = total
        S11.Text = total
        S12.Text = total
        S13.Text = total
        S14.Text = total
        S15.Text = total
        S16.Text = total
        S17.Text = total
        S18.Text = total
        S19.Text = total
        S20.Text = total

        Timer1.Enabled = True


    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        pb1.Value = pb1.Value + 1

        If pb1.Value = 2 Then

            Label2.Visible = True

        End If

        If pb1.Value = pb1.Maximum Then

            S1.Visible = True
            S2.Visible = True
            S3.Visible = True
            S4.Visible = True
            S5.Visible = True
            S6.Visible = True
            S7.Visible = True
            S8.Visible = True
            S9.Visible = True
            S10.Visible = True
            S11.Visible = True
            S12.Visible = True
            S13.Visible = True
            S14.Visible = True
            S15.Visible = True
            S16.Visible = True
            S17.Visible = True
            S18.Visible = True
            S19.Visible = True
            S20.Visible = True
            Label3.Visible = True
            Button1.Visible = True
            Button2.Visible = True
            Timer1.Enabled = False

        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Application.Restart()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MsgBox("Had a good time? See u soon!", vbOKOnly, "Bye...")
        End
    End Sub

    Private Sub Window1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        End
    End Sub

End Class