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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DocumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ASPNETViaCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.JavaScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EcmscriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VBSccriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.JscriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ASPNETCTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ASPNETVBTemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CSS20StylesheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.nbtxt = New System.Windows.Forms.RichTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DocumentToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(641, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveasToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.NewToolStripMenuItem.Text = "&New "
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveasToolStripMenuItem
        '
        Me.SaveasToolStripMenuItem.Name = "SaveasToolStripMenuItem"
        Me.SaveasToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveasToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.SaveasToolStripMenuItem.Text = "Save &as"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.PrintToolStripMenuItem.Text = "P&rint"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'DocumentToolStripMenuItem
        '
        Me.DocumentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ASPNETViaCToolStripMenuItem, Me.ASPNETCTemplateToolStripMenuItem, Me.ASPNETVBTemplateToolStripMenuItem, Me.CSS20StylesheetToolStripMenuItem})
        Me.DocumentToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentToolStripMenuItem.Name = "DocumentToolStripMenuItem"
        Me.DocumentToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.DocumentToolStripMenuItem.Text = "&Document Templates"
        '
        'ASPNETViaCToolStripMenuItem
        '
        Me.ASPNETViaCToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JavaScriptToolStripMenuItem, Me.EcmscriptToolStripMenuItem, Me.VBSccriptToolStripMenuItem, Me.JscriptToolStripMenuItem})
        Me.ASPNETViaCToolStripMenuItem.Name = "ASPNETViaCToolStripMenuItem"
        Me.ASPNETViaCToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ASPNETViaCToolStripMenuItem.Text = "HTML Templates"
        '
        'JavaScriptToolStripMenuItem
        '
        Me.JavaScriptToolStripMenuItem.Name = "JavaScriptToolStripMenuItem"
        Me.JavaScriptToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.JavaScriptToolStripMenuItem.Text = "JavaScript"
        '
        'EcmscriptToolStripMenuItem
        '
        Me.EcmscriptToolStripMenuItem.Name = "EcmscriptToolStripMenuItem"
        Me.EcmscriptToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.EcmscriptToolStripMenuItem.Text = "Ecmscript"
        '
        'VBSccriptToolStripMenuItem
        '
        Me.VBSccriptToolStripMenuItem.Name = "VBSccriptToolStripMenuItem"
        Me.VBSccriptToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.VBSccriptToolStripMenuItem.Text = "VBSccript"
        '
        'JscriptToolStripMenuItem
        '
        Me.JscriptToolStripMenuItem.Name = "JscriptToolStripMenuItem"
        Me.JscriptToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.JscriptToolStripMenuItem.Text = "Jscript"
        '
        'ASPNETCTemplateToolStripMenuItem
        '
        Me.ASPNETCTemplateToolStripMenuItem.Name = "ASPNETCTemplateToolStripMenuItem"
        Me.ASPNETCTemplateToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ASPNETCTemplateToolStripMenuItem.Text = "ASP.NET C# Template"
        '
        'ASPNETVBTemplateToolStripMenuItem
        '
        Me.ASPNETVBTemplateToolStripMenuItem.Name = "ASPNETVBTemplateToolStripMenuItem"
        Me.ASPNETVBTemplateToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ASPNETVBTemplateToolStripMenuItem.Text = "ASP.NET VB Template"
        '
        'CSS20StylesheetToolStripMenuItem
        '
        Me.CSS20StylesheetToolStripMenuItem.Name = "CSS20StylesheetToolStripMenuItem"
        Me.CSS20StylesheetToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CSS20StylesheetToolStripMenuItem.Text = "CSS 2.0 Stylesheet"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'nbtxt
        '
        Me.nbtxt.AcceptsTab = True
        Me.nbtxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nbtxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nbtxt.EnableAutoDragDrop = True
        Me.nbtxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nbtxt.ForeColor = System.Drawing.Color.LightCoral
        Me.nbtxt.Location = New System.Drawing.Point(0, 27)
        Me.nbtxt.Name = "nbtxt"
        Me.nbtxt.Size = New System.Drawing.Size(641, 430)
        Me.nbtxt.TabIndex = 1
        Me.nbtxt.Text = ""
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(412, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Be Sure to Save your Document before exiting"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Calibri", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(230, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 11)
        Me.Label2.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 459)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nbtxt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NoteBook "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nbtxt As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DocumentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ASPNETViaCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ASPNETCTemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JavaScriptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EcmscriptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VBSccriptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JscriptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ASPNETVBTemplateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CSS20StylesheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
