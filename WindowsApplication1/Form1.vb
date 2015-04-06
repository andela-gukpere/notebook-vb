Public Class Form1
    Private WithEvents printdoc As New Printing.PrintDocument


    Private Sub document_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printdoc.PrintPage
        Dim printFont As New System.Drawing.Font("Calibri", 14, System.Drawing.FontStyle.Regular)
        e.Graphics.DrawString(nbtxt.Text, printFont, System.Drawing.Brushes.Black, 10, 10)
    End Sub

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub
    
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        closeme()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        boo.FileName = "newfile.txt"
        foo.FileName = "newfile.txt"
        txt = nbtxt.Text
        Label2.Text = " DATE : " & My.Computer.Clock.LocalTime.Day.ToString() & " - " & My.Computer.Clock.LocalTime.Month.ToString() & " - " & My.Computer.Clock.LocalTime.Year.ToString() & "  TIME: " & My.Computer.Clock.LocalTime.Hour.ToString() & " : " & My.Computer.Clock.LocalTime.Minute.ToString()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click


        opendoc()

        If Not foo.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            nbtxt.Text = My.Computer.FileSystem.ReadAllText(foo.FileName)
        End If
        Me.Text = "NoteBook  | " + foo.FileName.ToString()

    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        printt.AllowSomePages = True
        printt.ShowHelp = True
        printt.Document = printdoc
        Dim ress As DialogResult = printt.ShowDialog()
        If ress = Windows.Forms.DialogResult.OK Then
            printdoc.Print()
        End If
    End Sub

    Private Sub nbtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nbtxt.TextChanged
        asktosave = True

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If asktosave = True Then
            closeme()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click

        If saving = True Then
            savedoc()
            If okcancel = True Then
                My.Computer.FileSystem.WriteAllText(boo.FileName, nbtxt.Text, False)
            End If
        ElseIf saving = False Then
            My.Computer.FileSystem.WriteAllText(boo.FileName, nbtxt.Text, False)
        End If
    End Sub

    Private Sub SaveasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveasToolStripMenuItem.Click
        saving = False
        savedoc()
        
        If Not nbtxt.Text = "" Then
            If okcancel = True Then
                My.Computer.FileSystem.WriteAllText(boo.FileName, nbtxt.Text, False)
            End If
            'My.Computer.FileSystem.WriteAllText(boo.FileName, nbtxt.Text, True)
        End If
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub


    Private Sub ASPNETViaCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ASPNETViaCToolStripMenuItem.Click
        nbtxt.Text = My.Computer.FileSystem.ReadAllText(".\templates\html.nbd")
        nbtxt.BackColor = Color.DimGray
        boo.FileName = "webpage.html"
        foo.FileName = boo.FileName
        Me.Text = "NoteBook  " & " | HTML Web Page"
    End Sub

    Private Sub ASPNETCTemplateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ASPNETCTemplateToolStripMenuItem.Click
        nbtxt.Text = My.Computer.FileSystem.ReadAllText(".\templates\asp.net")
        nbtxt.BackColor = Color.DimGray
        boo.FileName = "Default.aspx"
        foo.FileName = boo.FileName
        Me.Text = "NoteBook " & " | ASP.NET C# Web Page"
    End Sub

    Private Sub JavaScriptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JavaScriptToolStripMenuItem.Click
        nbtxt.Text = My.Computer.FileSystem.ReadAllText(".\templates\javashtml.nbd")
        nbtxt.BackColor = Color.FloralWhite
        boo.FileName = "webpage.html"
        foo.FileName = boo.FileName
        Me.Text = "NoteBook " & " | HTML Javascript Web Page"
    End Sub

    Private Sub EcmscriptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EcmscriptToolStripMenuItem.Click
        nbtxt.Text = My.Computer.FileSystem.ReadAllText(".\templates\ecmascript.nbd")
        nbtxt.BackColor = Color.FloralWhite
        boo.FileName = "webpage.html"
        foo.FileName = boo.FileName
        Me.Text = "NoteBook " & " | ECMASCRIPT Web Page"
    End Sub

    Private Sub VBSccriptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VBSccriptToolStripMenuItem.Click
        nbtxt.Text = My.Computer.FileSystem.ReadAllText(".\templates\vbscript.nbd")
        nbtxt.BackColor = Color.FloralWhite
        Me.Text = "NoteBook " & " | VBSCRIPT Web Page"
        boo.FileName = "webpage.html"
        foo.FileName = boo.FileName
    End Sub

    Private Sub JscriptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JscriptToolStripMenuItem.Click
        nbtxt.Text = My.Computer.FileSystem.ReadAllText(".\templates\jscript.nbd")
        nbtxt.BackColor = Color.FloralWhite
        boo.FileName = "webpage.html"
        foo.FileName = boo.FileName
        Me.Text = "NoteBook " & " | JSCRIPT Web Page"
    End Sub

    Private Sub ASPNETVBTemplateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ASPNETVBTemplateToolStripMenuItem.Click
        nbtxt.Text = My.Computer.FileSystem.ReadAllText(".\templates\aspvb.net")
        nbtxt.BackColor = Color.DimGray
        Me.Text = "NoteBook " & " | ASP.NET VB Web Page"
        boo.FileName = "Default.aspx"
        foo.FileName = boo.FileName
    End Sub

    Private Sub CSS20StylesheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSS20StylesheetToolStripMenuItem.Click
        nbtxt.Text = "body{}"
        nbtxt.BackColor = Color.LightSteelBlue
        Me.Text = "CSS Stylesheet.css"
        boo.DefaultExt = ".css"
        boo.FileName = "style.css"
        boo.Filter = "StyleSheet (.css) | *.css"
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        If asktosave = True Then
            closeme()
        End If
        boo.DefaultExt = ""
        boo.Filter = "Text Document (.txt) | *.txt|HTML editor (.html) | *.html | All Files | *.*"
        nbtxt.Text = ""
        boo.FileName = "New"
        foo.FileName = "New"
        Me.Text = "NoteBook |  " & foo.FileName.ToString()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = " DATE : " & My.Computer.Clock.LocalTime.Day.ToString() & " | " & My.Computer.Clock.LocalTime.Month.ToString() & " | " & My.Computer.Clock.LocalTime.Year.ToString() & " || TIME: " & My.Computer.Clock.LocalTime.Hour.ToString() & " : " & My.Computer.Clock.LocalTime.Minute.ToString() & " : " & My.Computer.Clock.LocalTime.Second.ToString()

    End Sub
End Class