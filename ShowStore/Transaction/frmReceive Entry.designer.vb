<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceivedEntry
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.pnlCashCredit = New System.Windows.Forms.Panel
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAmt = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboSupplierName = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTransID = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpTransDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtProductName = New System.Windows.Forms.TextBox
        Me.dgvPurchase = New System.Windows.Forms.DataGridView
        Me.colSlNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colItemName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnRemove = New System.Windows.Forms.Button
        Me.txtTotalAmt = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnlSearch = New System.Windows.Forms.Panel
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtSearchTransNo = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtDueAmount = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtPaidAmount = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.lstItem = New System.Windows.Forms.ListBox
        Me.pnlCashCredit.SuspendLayout()
        CType(Me.dgvPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCashCredit
        '
        Me.pnlCashCredit.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.pnlCashCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCashCredit.Controls.Add(Me.txtCode)
        Me.pnlCashCredit.Controls.Add(Me.Label3)
        Me.pnlCashCredit.Controls.Add(Me.txtAmt)
        Me.pnlCashCredit.Controls.Add(Me.Label10)
        Me.pnlCashCredit.Controls.Add(Me.cboSupplierName)
        Me.pnlCashCredit.Controls.Add(Me.Label8)
        Me.pnlCashCredit.Controls.Add(Me.txtTransID)
        Me.pnlCashCredit.Controls.Add(Me.Label5)
        Me.pnlCashCredit.Controls.Add(Me.txtRate)
        Me.pnlCashCredit.Controls.Add(Me.Label4)
        Me.pnlCashCredit.Controls.Add(Me.dtpTransDate)
        Me.pnlCashCredit.Controls.Add(Me.Label7)
        Me.pnlCashCredit.Controls.Add(Me.txtQty)
        Me.pnlCashCredit.Controls.Add(Me.Label2)
        Me.pnlCashCredit.Controls.Add(Me.Label1)
        Me.pnlCashCredit.Controls.Add(Me.txtProductName)
        Me.pnlCashCredit.Location = New System.Drawing.Point(270, 11)
        Me.pnlCashCredit.Name = "pnlCashCredit"
        Me.pnlCashCredit.Size = New System.Drawing.Size(501, 122)
        Me.pnlCashCredit.TabIndex = 81
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(371, 65)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(61, 20)
        Me.txtCode.TabIndex = 106
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(324, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Code"
        '
        'txtAmt
        '
        Me.txtAmt.Location = New System.Drawing.Point(372, 91)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Size = New System.Drawing.Size(61, 20)
        Me.txtAmt.TabIndex = 104
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(325, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 16)
        Me.Label10.TabIndex = 105
        Me.Label10.Text = "Amount"
        '
        'cboSupplierName
        '
        Me.cboSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSupplierName.FormattingEnabled = True
        Me.cboSupplierName.Location = New System.Drawing.Point(148, 36)
        Me.cboSupplierName.Name = "cboSupplierName"
        Me.cboSupplierName.Size = New System.Drawing.Size(286, 21)
        Me.cboSupplierName.TabIndex = 103
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(63, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "Supplier Name"
        '
        'txtTransID
        '
        Me.txtTransID.Location = New System.Drawing.Point(148, 9)
        Me.txtTransID.Name = "txtTransID"
        Me.txtTransID.ReadOnly = True
        Me.txtTransID.Size = New System.Drawing.Size(97, 20)
        Me.txtTransID.TabIndex = 0
        Me.txtTransID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(63, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Trans ID"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(252, 91)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(58, 20)
        Me.txtRate.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(220, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 16)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Rate"
        '
        'dtpTransDate
        '
        Me.dtpTransDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTransDate.Location = New System.Drawing.Point(337, 9)
        Me.dtpTransDate.Name = "dtpTransDate"
        Me.dtpTransDate.Size = New System.Drawing.Size(97, 20)
        Me.dtpTransDate.TabIndex = 97
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(301, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 16)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Date"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(148, 92)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(47, 20)
        Me.txtQty.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(63, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quantity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(63, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Name"
        '
        'txtProductName
        '
        Me.txtProductName.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtProductName.Location = New System.Drawing.Point(148, 64)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(162, 20)
        Me.txtProductName.TabIndex = 3
        '
        'dgvPurchase
        '
        Me.dgvPurchase.AllowUserToAddRows = False
        Me.dgvPurchase.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPurchase.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPurchase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSlNo, Me.colItemName, Me.colQty, Me.colRate, Me.colCode, Me.colAmount, Me.colItemCode})
        Me.dgvPurchase.EnableHeadersVisualStyles = False
        Me.dgvPurchase.Location = New System.Drawing.Point(269, 158)
        Me.dgvPurchase.MultiSelect = False
        Me.dgvPurchase.Name = "dgvPurchase"
        Me.dgvPurchase.RowHeadersVisible = False
        Me.dgvPurchase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPurchase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPurchase.Size = New System.Drawing.Size(503, 182)
        Me.dgvPurchase.TabIndex = 82
        '
        'colSlNo
        '
        Me.colSlNo.HeaderText = "Sl No."
        Me.colSlNo.Name = "colSlNo"
        Me.colSlNo.Width = 45
        '
        'colItemName
        '
        Me.colItemName.HeaderText = "Item Name"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.Width = 180
        '
        'colQty
        '
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Width = 40
        '
        'colRate
        '
        Me.colRate.HeaderText = "Rate"
        Me.colRate.Name = "colRate"
        Me.colRate.Width = 75
        '
        'colCode
        '
        Me.colCode.HeaderText = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Width = 75
        '
        'colAmount
        '
        Me.colAmount.HeaderText = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.Width = 85
        '
        'colItemCode
        '
        Me.colItemCode.HeaderText = "ProductId"
        Me.colItemCode.Name = "colItemCode"
        Me.colItemCode.Visible = False
        Me.colItemCode.Width = 110
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Location = New System.Drawing.Point(271, 387)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(501, 53)
        Me.Panel1.TabIndex = 83
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(210, 6)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 37)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(395, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 37)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(304, 6)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 37)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(119, 6)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 37)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(27, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 37)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(268, 134)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(53, 24)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(320, 134)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(56, 24)
        Me.btnRemove.TabIndex = 8
        Me.btnRemove.Text = "Remo&ve"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'txtTotalAmt
        '
        Me.txtTotalAmt.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTotalAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalAmt.Location = New System.Drawing.Point(680, 341)
        Me.txtTotalAmt.Name = "txtTotalAmt"
        Me.txtTotalAmt.ReadOnly = True
        Me.txtTotalAmt.Size = New System.Drawing.Size(92, 20)
        Me.txtTotalAmt.TabIndex = 104
        Me.txtTotalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(605, 343)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Total Amount"
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSearch.Controls.Add(Me.btnCancel)
        Me.pnlSearch.Controls.Add(Me.txtSearchTransNo)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Location = New System.Drawing.Point(434, 183)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(153, 87)
        Me.pnlSearch.TabIndex = 106
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
        'txtDueAmount
        '
        Me.txtDueAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDueAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueAmount.Location = New System.Drawing.Point(522, 363)
        Me.txtDueAmount.Name = "txtDueAmount"
        Me.txtDueAmount.ReadOnly = True
        Me.txtDueAmount.Size = New System.Drawing.Size(67, 21)
        Me.txtDueAmount.TabIndex = 111
        Me.txtDueAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(442, 366)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 110
        Me.Label11.Text = "Due Amount"
        '
        'txtPaidAmount
        '
        Me.txtPaidAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaidAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaidAmount.Location = New System.Drawing.Point(680, 363)
        Me.txtPaidAmount.Name = "txtPaidAmount"
        Me.txtPaidAmount.Size = New System.Drawing.Size(92, 21)
        Me.txtPaidAmount.TabIndex = 109
        Me.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(595, 366)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 108
        Me.Label12.Text = "Paid Amount"
        '
        'lstItem
        '
        Me.lstItem.FormattingEnabled = True
        Me.lstItem.Location = New System.Drawing.Point(10, 7)
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(238, 433)
        Me.lstItem.TabIndex = 112
        '
        'frmReceivedEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(782, 450)
        Me.Controls.Add(Me.lstItem)
        Me.Controls.Add(Me.txtDueAmount)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPaidAmount)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.txtTotalAmt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvPurchase)
        Me.Controls.Add(Me.pnlCashCredit)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaximizeBox = False
        Me.Name = "frmReceivedEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receive Entry"
        Me.pnlCashCredit.ResumeLayout(False)
        Me.pnlCashCredit.PerformLayout()
        CType(Me.dgvPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlCashCredit As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents dtpTransDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvPurchase As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents txtTransID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtSearchTransNo As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDueAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPaidAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lstItem As System.Windows.Forms.ListBox
    Friend WithEvents cboSupplierName As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents colSlNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemCode As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
