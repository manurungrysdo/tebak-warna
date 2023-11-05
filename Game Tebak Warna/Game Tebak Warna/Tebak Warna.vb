Public Class Tebak_Warna
    Sub skor()
        Dim point As Integer
        Dim scor As Integer
        If CheckBox2.Checked = True Then
            point = point + 30
        End If
        If CheckBox3.Checked = True Then
            point = point - 50
        End If
        If CheckBox4.Checked = True Then
            point = point + 30
        End If
        If CheckBox5.Checked = True Then
            point = point - 50
        End If
        If CheckBox6.Checked = True Then
            point = point + 30
        End If
        If CheckBox7.Checked = True Then
            point = point + 10
        End If
        scor = scor + point
        Label5.Text = scor
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Hide()
        If Timer1.Enabled = True Then
            Timer1.Start()
        Else
            Label4.Text = 8
            Timer1.Start()
        End If
        Label1.ForeColor = Color.DodgerBlue
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        CheckBox3.Enabled = True
        CheckBox4.Enabled = True
        CheckBox5.Enabled = True
        CheckBox6.Enabled = True
        CheckBox7.Enabled = True
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button2.Enabled = True
        Label4.Text = 0
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        CheckBox4.Enabled = False
        CheckBox5.Enabled = False
        CheckBox6.Enabled = False
        CheckBox7.Enabled = False
        Me.Hide()
        MsgBox("Do you want play again?")
        Menu_utama.Show()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1000
        Label4.Text = Label4.Text - 1
        If Label4.Text = 0 Then 
            Timer1.Stop()
            MsgBox("Time's up!")
            Call skor()
            Button2.Enabled = False
            Button4.Enabled = True
            Label2.Show()
            Label4.Text = 8
        End If
        If Label5.Text <= 19 Then
            Label2.Text = "bad😭"
        ElseIf Label5.Text >= 20 Then
            Label2.Text = "good👍"
        End If
    End Sub
End Class