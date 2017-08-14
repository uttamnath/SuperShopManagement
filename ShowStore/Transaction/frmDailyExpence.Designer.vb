<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyExpence
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
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.cmdEntryOk = New System.Windows.Forms.Button
        Me.cmdEntryCancel = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dgvVoucherEntry = New System.Windows.Forms.DataGridView
        Me.colSL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colParticular = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtParticulars = New System.Windows.Forms.TextBox
        Me.txtVoucherNo = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dtpSaleDate = New System.Windows.Forms.DateTimePicker
        Me.SSFrame2 = New System.Windows.Forms.Panel
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdVDelete = New System.Windows.Forms.Button
        Me.cmdCloseForm = New System.Windows.Forms.Button
        Me.cmdSaveEntry = New System.Windows.Forms.Button
        Me.cmdCancelEntry = New System.Windows.Forms.Button
        Me.pnlSearch = New System.Windows.Forms.Panel
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtSearchTransNo = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        CType(Me.dgvVoucherEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SSFrame2.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdEntryOk
        '
        Me.cmdEntryOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEntryOk.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cmdEntryOk.Location = New System.Drawing.Point(89, 125)
        Me.cmdEntryOk.Name = "cmdEntryOk"
        Me.cmdEntryOk.Size = New System.Drawing.Size(88, 26)
        Me.cmdEntryOk.TabIndex = 140
        Me.cmdEntryOk.Text = "&Ok"
        Me.cmdEntryOk.UseVisualStyleBackColor = True
        '
        'cmdEntryCancel
        '
        Me.cmdEntryCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEntryCancel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.cmdEntryCancel.Location = New System.Drawing.Point(233, 125)
        Me.cmdEntryCancel.Name = "cmdEntryCancel"
        Me.cmdEntryCancel.Size = New System.Drawing.Size(101, 26)
        Me.cmdEntryCancel.TabIndex = 141
        Me.cmdEntryCancel.Text = "&Ignore"
        Me.cmdEntryCancel.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "Particulars"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(252, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "Voucher No."
        '
        'dgvVoucherEntry
        '
        Me.dgvVoucherEntry.AllowUserToAddRows = False
        Me.dgvVoucherEntry.AllowUserToResizeColumns = False
        Me.dgvVoucherEntry.AllowUserToResizeRows = False
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVoucherEntry.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.dgvVoucherEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVoucherEntry.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSL, Me.colParticular, Me.colQty})
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVoucherEntry.DefaultCellStyle = DataGridViewCellStyle22
        Me.dgvVoucherEntry.Location = New System.Drawing.Point(30, 190)
        Me.dgvVoucherEntry.Name = "dgvVoucherEntry"
        Me.dgvVoucherEntry.RowHeadersVisible = False
        Me.dgvVoucherEntry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVoucherEntry.Size = New System.Drawing.Size(479, 146)
        Me.dgvVoucherEntry.TabIndex = 142
        '
        'colSL
        '
        Me.colSL.HeaderText = "Serial No"
        Me.colSL.Name = "colSL"
        Me.colSL.ReadOnly = True
        Me.colSL.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colParticular
        '
        Me.colParticular.HeaderText = "Particular"
        Me.colParticular.Name = "colParticular"
        Me.colParticular.ReadOnly = True
        Me.colParticular.Width = 260
        '
        'colQty
        '
        Me.colQty.HeaderText = "Amount"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        Me.colQty.Width = 115
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(89, 48)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(128, 20)
        Me.txtAmount.TabIndex = 139
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Amount"
        '
        'txtParticulars
        '
        Me.txtParticulars.Location = New System.Drawing.Point(89, 81)
        Me.txtParticulars.Multiline = True
        Me.txtParticulars.Name = "txtParticulars"
        Me.txtParticulars.Size = New System.Drawing.Size(361, 25)
        Me.txtParticulars.TabIndex = 137
        '
        'txtVoucherNo
        '
        Me.txtVoucherNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucherNo.Location = New System.Drawing.Point(89, 13)
        Me.txtVoucherNo.Name = "txtVoucherNo"
        Me.txtVoucherNo.ReadOnly = True
        Me.txtVoucherNo.Size = New System.Drawing.Size(129, 20)
        Me.txtVoucherNo.TabIndex = 136
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtpSaleDate)
        Me.Panel1.Controls.Add(Me.txtVoucherNo)
        Me.Panel1.Controls.Add(Me.cmdEntryCancel)
        Me.Panel1.Controls.Add(Me.cmdEntryOk)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtParticulars)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(30, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(476, 162)
        Me.Panel1.TabIndex = 143
        '
        'dtpSaleDate
        '
        Me.dtpSaleDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSaleDate.Location = New System.Drawing.Point(320, 13)
        Me.dtpSaleDate.Name = "dtpSaleDate"
        Me.dtpSaleDate.Size = New System.Drawing.Size(130, 20)
        Me.dtpSaleDate.TabIndex = 159
        '
        'SSFrame2
        '
        Me.SSFrame2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.SSFrame2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SSFrame2.Controls.Add(Me.cmdEdit)
        Me.SSFrame2.Controls.Add(Me.cmdVDelete)
        Me.SSFrame2.Controls.Add(Me.cmdCloseForm)
        Me.SSFrame2.Controls.Add(Me.cmdSaveEntry)
        Me.SSFrame2.Controls.Add(Me.cmdCancelEntry)
        Me.SSFrame2.Location = New System.Drawing.Point(30, 348)
        Me.SSFrame2.Name = "SSFrame2"
        Me.SSFrame2.Size = New System.Drawing.Size(479, 52)
        Me.SSFrame2.TabIndex = 144
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Location = New System.Drawing.Point(113, 11)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(60, 29)
        Me.cmdEdit.TabIndex = 8
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdVDelete
        '
        Me.cmdVDelete.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVDelete.Location = New System.Drawing.Point(205, 11)
        Me.cmdVDelete.Name = "cmdVDelete"
        Me.cmdVDelete.Size = New System.Drawing.Size(63, 29)
        Me.cmdVDelete.TabIndex = 7
        Me.cmdVDelete.Text = "&Delete"
        Me.cmdVDelete.UseVisualStyleBackColor = True
        '
        'cmdCloseForm
        '
        Me.cmdCloseForm.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseForm.Location = New System.Drawing.Point(392, 11)
        Me.cmdCloseForm.Name = "cmdCloseForm"
        Me.cmdCloseForm.Size = New System.Drawing.Size(63, 29)
        Me.cmdCloseForm.TabIndex = 4
        Me.cmdCloseForm.Text = "E&xit"
        Me.cmdCloseForm.UseVisualStyleBackColor = True
        '
        'cmdSaveEntry
        '
        Me.cmdSaveEntry.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveEntry.Location = New System.Drawing.Point(20, 11)
        Me.cmdSaveEntry.Name = "cmdSaveEntry"
        Me.cmdSaveEntry.Size = New System.Drawing.Size(60, 29)
        Me.cmdSaveEntry.TabIndex = 0
        Me.cmdSaveEntry.Text = "&Save"
        Me.cmdSaveEntry.UseVisualStyleBackColor = True
        '
        'cmdCancelEntry
        '
        Me.cmdCancelEntry.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelEntry.Location = New System.Drawing.Point(300, 11)
        Me.cmdCancelEntry.Name = "cmdCancelEntry"
        Me.cmdCancelEntry.Size = New System.Drawing.Size(63, 29)
        Me.cmdCancelEntry.TabIndex = 27
        Me.cmdCancelEntry.Text = "&Cancel"
        Me.cmdCancelEntry.UseVisualStyleBackColor = True
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSearch.Controls.Add(Me.btnCancel)
        Me.pnlSearch.Controls.Add(Me.txtSearchTransNo)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Location = New System.Drawing.Point(189, 212)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(153, 87)
        Me.pnlSearch.TabIndex = 145
        Me.pnlSearch.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(79, 47)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(58, 23)
        Me.btnCancel.TabIndex = 104
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtSearchTransNo
        '
        Me.txtSearchTransNo.Location = New System.Drawing.Point(16, 12)
        Me.txtSearchTransNo.Name = "txtSearchTransNo"
        Me.txtSearchTransNo.Size = New System.Drawing.Size(121, 20)
        Me.txtSearchTransNo.TabIndex = 102
        Me.txtSearchTransNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(16, 47)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(58, 23)
        Me.btnSearch.TabIndex = 103
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmDailyExpence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 414)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.SSFrame2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvVoucherEntry)
        Me.MaximizeBox = False
        Me.Name = "frmDailyExpence"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Voutcher"
        CType(Me.dgvVoucherEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SSFrame2.ResumeLayout(False)
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdEntryOk As System.Windows.Forms.Button
    Friend WithEvents cmdEntryCancel As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvVoucherEntry As System.Windows.Forms.DataGridView
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtParticulars As System.Windows.Forms.TextBox
    Friend WithEvents txtVoucherNo As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents colSL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colParticular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpSaleDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents SSFrame2 As System.Windows.Forms.Panel
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdVDelete As System.Windows.Forms.Button
    Friend WithEvents cmdCloseForm As System.Windows.Forms.Button
    Friend WithEvents cmdSaveEntry As System.Windows.Forms.Button
    Friend WithEvents cmdCancelEntry As System.Windows.Forms.Button
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtSearchTransNo As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
End Class
