<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChartofAllAccount
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
        Me.lstHeadList = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'lstHeadList
        '
        Me.lstHeadList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHeadList.FormattingEnabled = True
        Me.lstHeadList.ItemHeight = 24
        Me.lstHeadList.Location = New System.Drawing.Point(9, 20)
        Me.lstHeadList.Name = "lstHeadList"
        Me.lstHeadList.Size = New System.Drawing.Size(303, 340)
        Me.lstHeadList.TabIndex = 0
        '
        'frmChartofAllAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(323, 393)
        Me.Controls.Add(Me.lstHeadList)
        Me.MaximizeBox = False
        Me.Name = "frmChartofAllAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chart of All Account"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstHeadList As System.Windows.Forms.ListBox
End Class
