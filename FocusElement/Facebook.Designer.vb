<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Facebook_Form
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
        Me.components = New System.ComponentModel.Container()
        Me.Facebook_Browser = New System.Windows.Forms.WebBrowser()
        Me.btnFocus = New System.Windows.Forms.Button()
        Me.txtSpamText = New System.Windows.Forms.TextBox()
        Me.timermore = New System.Windows.Forms.Timer(Me.components)
        Me.btnstop = New System.Windows.Forms.Button()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstspamtext = New System.Windows.Forms.ListBox()
        Me.btnAddTextToList = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Facebook_Browser
        '
        Me.Facebook_Browser.Location = New System.Drawing.Point(0, 75)
        Me.Facebook_Browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Facebook_Browser.Name = "Facebook_Browser"
        Me.Facebook_Browser.Size = New System.Drawing.Size(1292, 658)
        Me.Facebook_Browser.TabIndex = 0
        '
        'btnFocus
        '
        Me.btnFocus.Location = New System.Drawing.Point(12, 12)
        Me.btnFocus.Name = "btnFocus"
        Me.btnFocus.Size = New System.Drawing.Size(111, 42)
        Me.btnFocus.TabIndex = 1
        Me.btnFocus.Text = "Focus IT"
        Me.btnFocus.UseVisualStyleBackColor = True
        '
        'txtSpamText
        '
        Me.txtSpamText.Location = New System.Drawing.Point(151, 13)
        Me.txtSpamText.Multiline = True
        Me.txtSpamText.Name = "txtSpamText"
        Me.txtSpamText.Size = New System.Drawing.Size(901, 41)
        Me.txtSpamText.TabIndex = 2
        '
        'timermore
        '
        '
        'btnstop
        '
        Me.btnstop.Location = New System.Drawing.Point(1159, 19)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(88, 29)
        Me.btnstop.TabIndex = 5
        Me.btnstop.Text = "Stop"
        Me.btnstop.UseVisualStyleBackColor = True
        '
        'btnstart
        '
        Me.btnstart.Location = New System.Drawing.Point(1065, 19)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(88, 29)
        Me.btnstart.TabIndex = 4
        Me.btnstart.Text = "Start"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1370, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Different Texts"
        '
        'lstspamtext
        '
        Me.lstspamtext.FormattingEnabled = True
        Me.lstspamtext.ItemHeight = 16
        Me.lstspamtext.Location = New System.Drawing.Point(1320, 129)
        Me.lstspamtext.Name = "lstspamtext"
        Me.lstspamtext.Size = New System.Drawing.Size(319, 596)
        Me.lstspamtext.TabIndex = 7
        '
        'btnAddTextToList
        '
        Me.btnAddTextToList.Location = New System.Drawing.Point(1309, 12)
        Me.btnAddTextToList.Name = "btnAddTextToList"
        Me.btnAddTextToList.Size = New System.Drawing.Size(330, 60)
        Me.btnAddTextToList.TabIndex = 8
        Me.btnAddTextToList.Text = "Add Text"
        Me.btnAddTextToList.UseVisualStyleBackColor = True
        '
        'Facebook_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1673, 753)
        Me.Controls.Add(Me.btnAddTextToList)
        Me.Controls.Add(Me.lstspamtext)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnstop)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.txtSpamText)
        Me.Controls.Add(Me.btnFocus)
        Me.Controls.Add(Me.Facebook_Browser)
        Me.Name = "Facebook_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Focus Text Box Facebook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Facebook_Browser As WebBrowser
    Friend WithEvents btnFocus As Button
    Friend WithEvents txtSpamText As TextBox
    Friend WithEvents timermore As Timer
    Friend WithEvents btnstop As Button
    Friend WithEvents btnstart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lstspamtext As ListBox
    Friend WithEvents btnAddTextToList As Button
End Class
