<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtNewPW = New System.Windows.Forms.TextBox
        Me.txtOldPW = New System.Windows.Forms.TextBox
        Me.txtConfirmPW = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboUser = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnxit = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNewPW)
        Me.GroupBox1.Controls.Add(Me.txtOldPW)
        Me.GroupBox1.Controls.Add(Me.txtConfirmPW)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboUser)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 136)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txtNewPW
        '
        Me.txtNewPW.Location = New System.Drawing.Point(133, 78)
        Me.txtNewPW.Name = "txtNewPW"
        Me.txtNewPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPW.Size = New System.Drawing.Size(157, 20)
        Me.txtNewPW.TabIndex = 7
        '
        'txtOldPW
        '
        Me.txtOldPW.Location = New System.Drawing.Point(133, 49)
        Me.txtOldPW.Name = "txtOldPW"
        Me.txtOldPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPW.Size = New System.Drawing.Size(157, 20)
        Me.txtOldPW.TabIndex = 6
        '
        'txtConfirmPW
        '
        Me.txtConfirmPW.Location = New System.Drawing.Point(133, 107)
        Me.txtConfirmPW.Name = "txtConfirmPW"
        Me.txtConfirmPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPW.Size = New System.Drawing.Size(157, 20)
        Me.txtConfirmPW.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Confirm Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "New Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Old Password"
        '
        'cboUser
        '
        Me.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUser.FormattingEnabled = True
        Me.cboUser.Location = New System.Drawing.Point(133, 19)
        Me.cboUser.Name = "cboUser"
        Me.cboUser.Size = New System.Drawing.Size(157, 21)
        Me.cboUser.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name"
        '
        'btnxit
        '
        Me.btnxit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxit.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnxit.Location = New System.Drawing.Point(166, 3)
        Me.btnxit.Name = "btnxit"
        Me.btnxit.Size = New System.Drawing.Size(91, 36)
        Me.btnxit.TabIndex = 2
        Me.btnxit.Text = "E&xit"
        Me.btnxit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnxit)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Location = New System.Drawing.Point(3, 151)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 46)
        Me.Panel1.TabIndex = 3
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnUpdate.Location = New System.Drawing.Point(51, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(94, 36)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 201)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frmChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNewPW As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPW As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmPW As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboUser As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnxit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
End Class
