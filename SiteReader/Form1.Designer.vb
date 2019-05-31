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
        Me.components = New System.ComponentModel.Container()
        Me.txtShowContent = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.txtHorizon = New System.Windows.Forms.TextBox()
        Me.txtShow = New System.Windows.Forms.Button()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.txtTag = New System.Windows.Forms.TextBox()
        Me.txtTagType = New System.Windows.Forms.TextBox()
        Me.txtTagTypeValue = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSave = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtKeyword = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtShowContent
        '
        Me.txtShowContent.Location = New System.Drawing.Point(537, 11)
        Me.txtShowContent.Name = "txtShowContent"
        Me.txtShowContent.Size = New System.Drawing.Size(79, 20)
        Me.txtShowContent.TabIndex = 0
        Me.txtShowContent.Text = "ShowContent"
        Me.txtShowContent.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 41)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1240, 478)
        Me.WebBrowser1.TabIndex = 1
        '
        'txtHorizon
        '
        Me.txtHorizon.Location = New System.Drawing.Point(12, 15)
        Me.txtHorizon.Name = "txtHorizon"
        Me.txtHorizon.Size = New System.Drawing.Size(428, 20)
        Me.txtHorizon.TabIndex = 2
        '
        'txtShow
        '
        Me.txtShow.Location = New System.Drawing.Point(447, 11)
        Me.txtShow.Name = "txtShow"
        Me.txtShow.Size = New System.Drawing.Size(75, 23)
        Me.txtShow.TabIndex = 3
        Me.txtShow.Text = "Show"
        Me.txtShow.UseVisualStyleBackColor = True
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(6, 36)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ReadOnly = True
        Me.txtContent.Size = New System.Drawing.Size(610, 104)
        Me.txtContent.TabIndex = 4
        '
        'txtTag
        '
        Me.txtTag.Location = New System.Drawing.Point(80, 12)
        Me.txtTag.Name = "txtTag"
        Me.txtTag.Size = New System.Drawing.Size(100, 20)
        Me.txtTag.TabIndex = 5
        '
        'txtTagType
        '
        Me.txtTagType.Location = New System.Drawing.Point(257, 12)
        Me.txtTagType.Name = "txtTagType"
        Me.txtTagType.Size = New System.Drawing.Size(100, 20)
        Me.txtTagType.TabIndex = 6
        '
        'txtTagTypeValue
        '
        Me.txtTagTypeValue.Location = New System.Drawing.Point(431, 12)
        Me.txtTagTypeValue.Name = "txtTagTypeValue"
        Me.txtTagTypeValue.Size = New System.Drawing.Size(100, 20)
        Me.txtTagTypeValue.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtContent)
        Me.GroupBox1.Controls.Add(Me.txtTagTypeValue)
        Me.GroupBox1.Controls.Add(Me.txtShowContent)
        Me.GroupBox1.Controls.Add(Me.txtTagType)
        Me.GroupBox1.Controls.Add(Me.txtTag)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 525)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 149)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'txtSave
        '
        Me.txtSave.Location = New System.Drawing.Point(635, 525)
        Me.txtSave.Name = "txtSave"
        Me.txtSave.Size = New System.Drawing.Size(59, 140)
        Me.txtSave.TabIndex = 9
        Me.txtSave.Text = "Save"
        Me.txtSave.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(700, 549)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(552, 126)
        Me.DataGridView1.TabIndex = 10
        '
        'txtKeyword
        '
        Me.txtKeyword.Location = New System.Drawing.Point(700, 525)
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Size = New System.Drawing.Size(552, 20)
        Me.txtKeyword.TabIndex = 11
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.PaleGreen
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 669)
        Me.Controls.Add(Me.txtKeyword)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtShow)
        Me.Controls.Add(Me.txtHorizon)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtShowContent As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents txtHorizon As System.Windows.Forms.TextBox
    Friend WithEvents txtShow As System.Windows.Forms.Button
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents txtTag As System.Windows.Forms.TextBox
    Friend WithEvents txtTagType As System.Windows.Forms.TextBox
    Friend WithEvents txtTagTypeValue As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSave As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtKeyword As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
