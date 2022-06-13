<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WritetoErrlog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WritetoErrlog))
        Me.createFile_btn = New System.Windows.Forms.Button()
        Me.StatusLable = New System.Windows.Forms.Label()
        Me.MessageBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'createFile_btn
        '
        Me.createFile_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.createFile_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.createFile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.createFile_btn.Location = New System.Drawing.Point(307, 280)
        Me.createFile_btn.Name = "createFile_btn"
        Me.createFile_btn.Size = New System.Drawing.Size(177, 65)
        Me.createFile_btn.TabIndex = 0
        Me.createFile_btn.Text = "Add Message"
        Me.createFile_btn.UseVisualStyleBackColor = False
        '
        'StatusLable
        '
        Me.StatusLable.AutoSize = True
        Me.StatusLable.Location = New System.Drawing.Point(155, 380)
        Me.StatusLable.Name = "StatusLable"
        Me.StatusLable.Size = New System.Drawing.Size(64, 20)
        Me.StatusLable.TabIndex = 1
        Me.StatusLable.Text = "Status: "
        '
        'MessageBox
        '
        Me.MessageBox.Location = New System.Drawing.Point(159, 126)
        Me.MessageBox.Multiline = True
        Me.MessageBox.Name = "MessageBox"
        Me.MessageBox.Size = New System.Drawing.Size(471, 148)
        Me.MessageBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(155, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Write Message"
        '
        'WritetoErrlog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MessageBox)
        Me.Controls.Add(Me.StatusLable)
        Me.Controls.Add(Me.createFile_btn)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WritetoErrlog"
        Me.Text = "WritetoErrlog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents createFile_btn As Button
    Friend WithEvents StatusLable As Label
    Friend WithEvents MessageBox As TextBox
    Friend WithEvents Label1 As Label
End Class
