<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        LblX = New Label()
        LblY = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Panel1 = New Panel()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(491, 51)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(369, 52)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(525, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(17, 15)
        Label1.TabIndex = 2
        Label1.Text = "X:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(525, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(17, 15)
        Label2.TabIndex = 3
        Label2.Text = "Y:"
        ' 
        ' LblX
        ' 
        LblX.AutoSize = True
        LblX.Location = New Point(549, 121)
        LblX.Name = "LblX"
        LblX.Size = New Size(37, 15)
        LblX.TabIndex = 0
        LblX.Text = "12345"
        ' 
        ' LblY
        ' 
        LblY.AutoSize = True
        LblY.Location = New Point(549, 146)
        LblY.Name = "LblY"
        LblY.Size = New Size(37, 15)
        LblY.TabIndex = 5
        LblY.Text = "12345"
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Location = New Point(221, 175)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 100)
        Panel1.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(489, 203)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 7
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(696, 450)
        Controls.Add(Button2)
        Controls.Add(Panel1)
        Controls.Add(LblY)
        Controls.Add(LblX)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblX As Label
    Friend WithEvents LblY As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
End Class
