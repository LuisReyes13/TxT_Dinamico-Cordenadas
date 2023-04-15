Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim myPanel As Panel
        'myPanel = New Panel()
        'myPanel.Name = "PanelTexts"
        'myPanel.BorderStyle = BorderStyle.FixedSingle
        'myPanel.Location = New Point(10, 10)
        'myPanel.Size = New Size(150, 300)
        'myPanel.AutoScroll = True
        'Me.Controls.Add(myPanel)

        Dim xPos As Integer = 10
        Dim yPos As Integer = 10
        Dim textBoxesCount As Integer = Integer.Parse(TextBox1.Text)

        For i As Integer = 1 To textBoxesCount
            Dim myLabel As New Label()
            myLabel.Location = New Point(xPos, yPos)
            myLabel.Name = $"Lable_{i}"
            myLabel.Text = $"Label {i}"
            myLabel.AutoSize = True
            Panel1.Controls.Add(myLabel)

            'myPanel.Controls.Add(myLabel)

            Dim myTextBox As New TextBox()
            myTextBox.Location = New Point(xPos, yPos + 20)
            myTextBox.Name = $"Txt_{i}"
            Panel1.Controls.Add(myTextBox)
            'myPanel.Controls.Add(myTextBox)

            yPos += 50
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        LblX.Text = e.X
        LblY.Text = e.Y
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cd As TextBox
        'cd = Me.Controls("PanelTexts").Controls("Txt_1")
        cd = Me.Controls("Panel1").Controls("Txt_2")
        MsgBox(cd.Text)
        Form2.ShowDialog()
    End Sub
End Class
