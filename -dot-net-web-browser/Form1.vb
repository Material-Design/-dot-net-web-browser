Imports System.Windows.Forms
Imports Microsoft.Win32
Public Event KeyDown As KeyEventHandler

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("https://www.google.com")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text.Contains("http://") Or TextBox1.Text.Contains("https://") Or TextBox1.Text.Contains("www.") Or TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".co.uk") Or TextBox1.Text.Contains(".org") Then
            WebBrowser1.Navigate(TextBox1.Text)
            Button7.Enabled = True
        ElseIf TextBox1.Text = "" Or TextBox1.Text = "Enter your URL or search term here" Then
            MsgBox("Please enter a valid query")
        Else
            WebBrowser1.Navigate("https://www.google.com/search?hl=en&q=" & TextBox1.Text)
            Button7.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.Refresh()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.GoHome()
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        TextBox2.Text = WebBrowser1.Url.ToString
        TextBox1.Text = WebBrowser1.Url.ToString
        If TextBox2.Text.Contains("https://") Then
            ToolStripStatusLabel1.Text = "Secure connection"
            Button7.Enabled = False
        ElseIf TextBox2.Text.Contains("http://") Then
            ToolStripStatusLabel1.Text = "Unsecure connection"
            Button7.Enabled = False
        Else
            ToolStripStatusLabel1.Text = "#"
            Button7.Enabled = False
        End If
    End Sub
    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        Try
            If e.MaximumProgress <> 0 And e.MaximumProgress >= e.CurrentProgress Then
                ToolStripProgressBar1.Value = Convert.ToInt32(100 * e.CurrentProgress / e.MaximumProgress)
            Else
                With ToolStripProgressBar1
                    .Value = 100
                    .Visible = True
                End With
            End If
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Error Loading page"
        End Try

    End Sub
    Private Sub textBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button5_Click(sender, e)
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.Text = WebBrowser1.DocumentTitle & " - IE shell web browser: GitHub: Material-Design"
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim value = InputBox("Set a new homepage:" & vbNewLine & "Note, your input must include 'http(s)'")
        Dim regKey As RegistryKey
        regKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Internet Explorer\Main", True)
        regKey.SetValue("Start Page", value)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WebBrowser1.Stop()
    End Sub
End Class