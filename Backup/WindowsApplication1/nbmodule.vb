Module nbmodule
    Public printt As New PrintDialog
    Public boo As New SaveFileDialog
    Public foo As New OpenFileDialog
    Public asktosave As Boolean = False
    Public txt As String
    Public okcancel As Boolean = True
    Public saving As Boolean = True


    Public Sub savedoc()

        boo.DefaultExt = ""
        foo.Filter = "Text Document (.txt) | *.txt|HTML Files (.html) | *.html | All Files | *.*"
        boo.Title = "Save" & boo.FileName
        Dim ress As DialogResult = boo.ShowDialog
        If ress = DialogResult.OK Then
            okcancel = True
        ElseIf ress = DialogResult.Cancel Then
            okcancel = False
        End If
        'Dim tt As Nullable(Of Boolean) = boo.ShowDialog
        'If (tt.GetValueOrDefault AndAlso tt.HasValue) Then
        'Dim filename As String = boo.FileName
        'End If
    End Sub
    
    Public Sub opendoc()
        'foo.FileName = "new"
        foo.DefaultExt = ""
        foo.Filter = "Text Document (.txt) | *.txt|HTML Files (.html) | *.html | All Files | *.*"
        foo.Title = "Open NBD file"

        'Dim ss As Nullable(Of Boolean) = foo.ShowDialog
        'If (ss.HasValue AndAlso ss.GetValueOrDefault) Then
        'Dim filename As String = foo.FileName
        'End If
    End Sub
    Public Sub closeme()
        txt = Form1.nbtxt.Text
        If asktosave = True Then


            Dim resolt As New DialogResult()
            resolt = MsgBox("Do you want to save changes to " & foo.FileName, MsgBoxStyle.YesNoCancel, "Save" & foo.FileName)
            If resolt = DialogResult.Yes Then
                If saving = True Then
                    savedoc()
                Else
                    My.Computer.FileSystem.WriteAllText(foo.FileName, txt, False)
                End If
            ElseIf resolt = DialogResult.No Then
                Application.Exit()
            ElseIf resolt = DialogResult.Cancel Then



            End If
        End If



    End Sub

End Module
