<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowContent
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
        Me.txtContent = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(12, 12)
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(517, 463)
        Me.txtContent.TabIndex = 0
        Me.txtContent.Text = ""
        '
        'ShowContent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 487)
        Me.Controls.Add(Me.txtContent)
        Me.Name = "ShowContent"
        Me.Text = "ShowContent"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtContent As System.Windows.Forms.RichTextBox
End Class
