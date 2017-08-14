<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleRpt
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnShow = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtReceiptWise = New System.Windows.Forms.TextBox
        Me.optReceiptWise = New System.Windows.Forms.RadioButton
        Me.cboItemWise = New System.Windows.Forms.ComboBox
        Me.optItemWise = New System.Windows.Forms.RadioButton
        Me.cboCustomer = New System.Windows.Forms.ComboBox
        Me.optCusWiseSale = New System.Windows.Forms.RadioButton
        Me.optTotalSale = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkDateRange = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpTo = New System.Windows.Forms.DateTimePicker
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker
        Me.txtVoutcherwise = New System.Windows.Forms.TextBox
        Me.optVoutcherWise = New System.Windows.Forms.RadioButton
        Me.optTotalExpense = New System.Windows.Forms.RadioButton
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnShow)
        Me.Panel1.Location = New System.Drawing.Point(113, 276)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 61)
        Me.Panel1.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(107, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 42)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnShow.Location = New System.Drawing.Point(17, 7)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 42)
        Me.btnShow.TabIndex = 0
        Me.btnShow.Text = "&Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtVoutcherwise)
        Me.GroupBox2.Controls.Add(Me.optVoutcherWise)
        Me.GroupBox2.Controls.Add(Me.optTotalExpense)
        Me.GroupBox2.Controls.Add(Me.txtReceiptWise)
        Me.GroupBox2.Controls.Add(Me.optReceiptWise)
        Me.GroupBox2.Controls.Add(Me.cboItemWise)
        Me.GroupBox2.Controls.Add(Me.optItemWise)
        Me.GroupBox2.Controls.Add(Me.cboCustomer)
        Me.GroupBox2.Controls.Add(Me.optCusWiseSale)
        Me.GroupBox2.Controls.Add(Me.optTotalSale)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(441, 175)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'txtReceiptWise
        '
        Me.txtReceiptWise.Location = New System.Drawing.Point(313, 23)
        Me.txtReceiptWise.Name = "txtReceiptWise"
        Me.txtReceiptWise.Size = New System.Drawing.Size(120, 20)
        Me.txtReceiptWise.TabIndex = 18
        '
        'optReceiptWise
        '
        Me.optReceiptWise.AutoSize = True
        Me.optReceiptWise.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optReceiptWise.Location = New System.Drawing.Point(206, 23)
        Me.optReceiptWise.Name = "optReceiptWise"
        Me.optReceiptWise.Size = New System.Drawing.Size(101, 17)
        Me.optReceiptWise.TabIndex = 17
        Me.optReceiptWise.TabStop = True
        Me.optReceiptWise.Text = "Receipt Wise"
        Me.optReceiptWise.UseVisualStyleBackColor = True
        '
        'cboItemWise
        '
        Me.cboItemWise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItemWise.FormattingEnabled = True
        Me.cboItemWise.Location = New System.Drawing.Point(159, 93)
        Me.cboItemWise.Name = "cboItemWise"
        Me.cboItemWise.Size = New System.Drawing.Size(274, 21)
        Me.cboItemWise.TabIndex = 14
        Me.cboItemWise.Visible = False
        '
        'optItemWise
        '
        Me.optItemWise.AutoSize = True
        Me.optItemWise.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optItemWise.Location = New System.Drawing.Point(15, 96)
        Me.optItemWise.Name = "optItemWise"
        Me.optItemWise.Size = New System.Drawing.Size(110, 17)
        Me.optItemWise.TabIndex = 13
        Me.optItemWise.TabStop = True
        Me.optItemWise.Text = "Item Wise Sale"
        Me.optItemWise.UseVisualStyleBackColor = True
        '
        'cboCustomer
        '
        Me.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(159, 136)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(274, 21)
        Me.cboCustomer.TabIndex = 12
        Me.cboCustomer.Visible = False
        '
        'optCusWiseSale
        '
        Me.optCusWiseSale.AutoSize = True
        Me.optCusWiseSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCusWiseSale.Location = New System.Drawing.Point(15, 139)
        Me.optCusWiseSale.Name = "optCusWiseSale"
        Me.optCusWiseSale.Size = New System.Drawing.Size(138, 17)
        Me.optCusWiseSale.TabIndex = 11
        Me.optCusWiseSale.TabStop = True
        Me.optCusWiseSale.Text = "Customer Wise Sale"
        Me.optCusWiseSale.UseVisualStyleBackColor = True
        '
        'optTotalSale
        '
        Me.optTotalSale.AutoSize = True
        Me.optTotalSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTotalSale.Location = New System.Drawing.Point(16, 23)
        Me.optTotalSale.Name = "optTotalSale"
        Me.optTotalSale.Size = New System.Drawing.Size(83, 17)
        Me.optTotalSale.TabIndex = 0
        Me.optTotalSale.TabStop = True
        Me.optTotalSale.Text = "Total Sale"
        Me.optTotalSale.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkDateRange)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpTo)
        Me.GroupBox1.Controls.Add(Me.dtpFrom)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(441, 47)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'chkDateRange
        '
        Me.chkDateRange.AutoSize = True
        Me.chkDateRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkDateRange.Location = New System.Drawing.Point(16, 18)
        Me.chkDateRange.Name = "chkDateRange"
        Me.chkDateRange.Size = New System.Drawing.Size(98, 17)
        Me.chkDateRange.TabIndex = 11
        Me.chkDateRange.Text = "Date Range:"
        Me.chkDateRange.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "From"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(287, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "To"
        Me.Label1.Visible = False
        '
        'dtpTo
        '
        Me.dtpTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(318, 17)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(115, 20)
        Me.dtpTo.TabIndex = 7
        Me.dtpTo.Visible = False
        '
        'dtpFrom
        '
        Me.dtpFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(160, 17)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(121, 20)
        Me.dtpFrom.TabIndex = 5
        Me.dtpFrom.Visible = False
        '
        'txtVoutcherwise
        '
        Me.txtVoutcherwise.Location = New System.Drawing.Point(313, 58)
        Me.txtVoutcherwise.Name = "txtVoutcherwise"
        Me.txtVoutcherwise.Size = New System.Drawing.Size(120, 20)
        Me.txtVoutcherwise.TabIndex = 21
        '
        'optVoutcherWise
        '
        Me.optVoutcherWise.AutoSize = True
        Me.optVoutcherWise.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optVoutcherWise.Location = New System.Drawing.Point(206, 58)
        Me.optVoutcherWise.Name = "optVoutcherWise"
        Me.optVoutcherWise.Size = New System.Drawing.Size(108, 17)
        Me.optVoutcherWise.TabIndex = 20
        Me.optVoutcherWise.TabStop = True
        Me.optVoutcherWise.Text = "Voutcher Wise"
        Me.optVoutcherWise.UseVisualStyleBackColor = True
        '
        'optTotalExpense
        '
        Me.optTotalExpense.AutoSize = True
        Me.optTotalExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTotalExpense.Location = New System.Drawing.Point(16, 58)
        Me.optTotalExpense.Name = "optTotalExpense"
        Me.optTotalExpense.Size = New System.Drawing.Size(106, 17)
        Me.optTotalExpense.TabIndex = 19
        Me.optTotalExpense.TabStop = True
        Me.optTotalExpense.Text = "Total Expense"
        Me.optTotalExpense.UseVisualStyleBackColor = True
        '
        'frmSaleRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(455, 352)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSaleRpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports of Sale"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtReceiptWise As System.Windows.Forms.TextBox
    Friend WithEvents optReceiptWise As System.Windows.Forms.RadioButton
    Friend WithEvents cboItemWise As System.Windows.Forms.ComboBox
    Friend WithEvents optItemWise As System.Windows.Forms.RadioButton
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents optCusWiseSale As System.Windows.Forms.RadioButton
    Friend WithEvents optTotalSale As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDateRange As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtVoutcherwise As System.Windows.Forms.TextBox
    Friend WithEvents optVoutcherWise As System.Windows.Forms.RadioButton
    Friend WithEvents optTotalExpense As System.Windows.Forms.RadioButton
End Class
