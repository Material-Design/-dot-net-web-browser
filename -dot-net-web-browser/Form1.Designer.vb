<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 74)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1125, 466)
        Me.WebBrowser1.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 542)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1125, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = true
        Me.ListBox1.Location = New System.Drawing.Point(345, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(295, 56)
        Me.ListBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(901, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Forward ->"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(809, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 30)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "<- Back"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(728, 38)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 30)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Refresh"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(646, 38)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(76, 30)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Home"
        Me.Button4.UseVisualStyleBackColor = true
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(987, 15)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(57, 46)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Go"
        Me.Button5.UseVisualStyleBackColor = true
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 15)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(98, 46)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Set homepage"
        Me.Button6.UseVisualStyleBackColor = true
        '
        'Button7
        '
        Me.Button7.Enabled = false
        Me.Button7.Location = New System.Drawing.Point(1056, 15)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(57, 46)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "Stop"
        Me.Button7.UseVisualStyleBackColor = true
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(128, 15)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(98, 46)
        Me.Button8.TabIndex = 10
        Me.Button8.Text = "Print page"
        Me.Button8.UseVisualStyleBackColor = true
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(241, 15)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(98, 46)
        Me.Button11.TabIndex = 13
        Me.Button11.Text = "Page info"
        Me.Button11.UseVisualStyleBackColor = true
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(646, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(335, 20)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Text = "Enter your URL or search term here"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1056, 544)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(39, 20)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.Visible = false
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(1050, 542)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 16
        Me.Button9.Text = "Clear history"
        Me.Button9.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 564)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "IE shell web browser: GitHub: Material-Design"
        Me.StatusStrip1.ResumeLayout(false)
        Me.StatusStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button9 As Button
End Class
