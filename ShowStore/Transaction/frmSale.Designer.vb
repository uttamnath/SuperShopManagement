<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleEntry
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtbasepricecode = New System.Windows.Forms.TextBox
        Me.cboProductID = New System.Windows.Forms.ComboBox
        Me.txtSaleCode = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtTk = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtProductName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCustomerName = New System.Windows.Forms.TextBox
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtStock = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtReceptNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnInvoicePrint = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.txtReceiveAmt = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtDueAmount = New System.Windows.Forms.TextBox
        Me.pnlSearch = New System.Windows.Forms.Panel
        Me.Label19 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtSearchTransNo = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtChangeAmt = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.pnlPrint = New System.Windows.Forms.Panel
        Me.Label20 = New System.Windows.Forms.Label
        Me.btnPrintCancel = New System.Windows.Forms.Button
        Me.txtprint = New System.Windows.Forms.TextBox
        Me.btnPrintOK = New System.Windows.Forms.Button
        Me.dgvSaleEntry = New System.Windows.Forms.DataGridView
        Me.colSL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colProductName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTk = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colProfit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnExit = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtNetAmt = New System.Windows.Forms.TextBox
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtGrossAmt = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.dtpSaleDate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.pnlPrint.SuspendLayout()
        CType(Me.dgvSaleEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(40, 135)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(87, 44)
        Me.btnRefresh.TabIndex = 16
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(184, 74)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 44)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpSaleDate)
        Me.GroupBox1.Controls.Add(Me.txtbasepricecode)
        Me.GroupBox1.Controls.Add(Me.cboProductID)
        Me.GroupBox1.Controls.Add(Me.txtSaleCode)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtTk)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtProductName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.txtRate)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtStock)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtReceptNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 162)
        Me.GroupBox1.TabIndex = 135
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sale Info"
        '
        'txtbasepricecode
        '
        Me.txtbasepricecode.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtbasepricecode.Location = New System.Drawing.Point(259, 88)
        Me.txtbasepricecode.Name = "txtbasepricecode"
        Me.txtbasepricecode.ReadOnly = True
        Me.txtbasepricecode.Size = New System.Drawing.Size(40, 21)
        Me.txtbasepricecode.TabIndex = 157
        '
        'cboProductID
        '
        Me.cboProductID.FormattingEnabled = True
        Me.cboProductID.Location = New System.Drawing.Point(97, 55)
        Me.cboProductID.Name = "cboProductID"
        Me.cboProductID.Size = New System.Drawing.Size(125, 23)
        Me.cboProductID.TabIndex = 2
        '
        'txtSaleCode
        '
        Me.txtSaleCode.Location = New System.Drawing.Point(472, 89)
        Me.txtSaleCode.Name = "txtSaleCode"
        Me.txtSaleCode.ReadOnly = True
        Me.txtSaleCode.Size = New System.Drawing.Size(38, 21)
        Me.txtSaleCode.TabIndex = 156
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(437, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 15)
        Me.Label11.TabIndex = 155
        Me.Label11.Text = "Code"
        '
        'txtTk
        '
        Me.txtTk.Location = New System.Drawing.Point(394, 89)
        Me.txtTk.Name = "txtTk"
        Me.txtTk.Size = New System.Drawing.Size(42, 21)
        Me.txtTk.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(370, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 15)
        Me.Label9.TabIndex = 153
        Me.Label9.Text = "Tk"
        '
        'txtProductName
        '
        Me.txtProductName.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtProductName.Location = New System.Drawing.Point(321, 59)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(190, 21)
        Me.txtProductName.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(228, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 15)
        Me.Label6.TabIndex = 151
        Me.Label6.Text = "Product Name"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCustomerName.Location = New System.Drawing.Point(116, 120)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(152, 21)
        Me.txtCustomerName.TabIndex = 8
        '
        'txtRate
        '
        Me.txtRate.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtRate.Location = New System.Drawing.Point(219, 88)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.ReadOnly = True
        Me.txtRate.Size = New System.Drawing.Size(34, 21)
        Me.txtRate.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(150, 89)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 15)
        Me.Label15.TabIndex = 141
        Me.Label15.Text = "Base Price"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(331, 88)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(36, 21)
        Me.txtQty.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(302, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 15)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "Qty"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "Product ID"
        '
        'txtStock
        '
        Me.txtStock.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtStock.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(97, 88)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(53, 22)
        Me.txtStock.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "Stock"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(337, 120)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(174, 22)
        Me.txtAddress.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 15)
        Me.Label8.TabIndex = 131
        Me.Label8.Text = "Customer Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(362, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 15)
        Me.Label7.TabIndex = 129
        Me.Label7.Text = "Date"
        '
        'txtReceptNo
        '
        Me.txtReceptNo.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtReceptNo.Location = New System.Drawing.Point(97, 28)
        Me.txtReceptNo.Name = "txtReceptNo"
        Me.txtReceptNo.ReadOnly = True
        Me.txtReceptNo.Size = New System.Drawing.Size(103, 21)
        Me.txtReceptNo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Receipt No"
        '
        'btnInvoicePrint
        '
        Me.btnInvoicePrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvoicePrint.Location = New System.Drawing.Point(40, 74)
        Me.btnInvoicePrint.Name = "btnInvoicePrint"
        Me.btnInvoicePrint.Size = New System.Drawing.Size(87, 44)
        Me.btnInvoicePrint.TabIndex = 14
        Me.btnInvoicePrint.Text = "Invoice" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "&Print"
        Me.btnInvoicePrint.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(184, 13)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(87, 44)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(40, 13)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 44)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRemove.Location = New System.Drawing.Point(549, 96)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(113, 69)
        Me.btnRemove.TabIndex = 140
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(549, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(113, 64)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtReceiveAmt
        '
        Me.txtReceiveAmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtReceiveAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiveAmt.Location = New System.Drawing.Point(161, 119)
        Me.txtReceiveAmt.Name = "txtReceiveAmt"
        Me.txtReceiveAmt.Size = New System.Drawing.Size(110, 26)
        Me.txtReceiveAmt.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(43, 123)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(99, 15)
        Me.Label18.TabIndex = 158
        Me.Label18.Text = "Receive Amount"
        '
        'txtDueAmount
        '
        Me.txtDueAmount.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtDueAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueAmount.Location = New System.Drawing.Point(161, 187)
        Me.txtDueAmount.Name = "txtDueAmount"
        Me.txtDueAmount.Size = New System.Drawing.Size(110, 22)
        Me.txtDueAmount.TabIndex = 153
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSearch.Controls.Add(Me.Label19)
        Me.pnlSearch.Controls.Add(Me.btnCancel)
        Me.pnlSearch.Controls.Add(Me.txtSearchTransNo)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Location = New System.Drawing.Point(223, 230)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(156, 100)
        Me.pnlSearch.TabIndex = 141
        Me.pnlSearch.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(1, 6)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(151, 13)
        Me.Label19.TabIndex = 105
        Me.Label19.Text = "Receipt No. Wise Search"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(79, 58)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(58, 23)
        Me.btnCancel.TabIndex = 104
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtSearchTransNo
        '
        Me.txtSearchTransNo.Location = New System.Drawing.Point(16, 29)
        Me.txtSearchTransNo.Name = "txtSearchTransNo"
        Me.txtSearchTransNo.Size = New System.Drawing.Size(121, 20)
        Me.txtSearchTransNo.TabIndex = 102
        Me.txtSearchTransNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(16, 58)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(58, 23)
        Me.btnSearch.TabIndex = 103
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(43, 190)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 15)
        Me.Label14.TabIndex = 152
        Me.Label14.Text = "Due Amount"
        '
        'txtChangeAmt
        '
        Me.txtChangeAmt.BackColor = System.Drawing.Color.White
        Me.txtChangeAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangeAmt.Location = New System.Drawing.Point(161, 155)
        Me.txtChangeAmt.Name = "txtChangeAmt"
        Me.txtChangeAmt.Size = New System.Drawing.Size(110, 22)
        Me.txtChangeAmt.TabIndex = 151
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(43, 159)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 15)
        Me.Label16.TabIndex = 150
        Me.Label16.Text = "Change Amt"
        '
        'pnlPrint
        '
        Me.pnlPrint.BackColor = System.Drawing.Color.SkyBlue
        Me.pnlPrint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPrint.Controls.Add(Me.Label20)
        Me.pnlPrint.Controls.Add(Me.btnPrintCancel)
        Me.pnlPrint.Controls.Add(Me.txtprint)
        Me.pnlPrint.Controls.Add(Me.btnPrintOK)
        Me.pnlPrint.Location = New System.Drawing.Point(345, 230)
        Me.pnlPrint.Name = "pnlPrint"
        Me.pnlPrint.Size = New System.Drawing.Size(156, 100)
        Me.pnlPrint.TabIndex = 142
        Me.pnlPrint.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 7)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(137, 13)
        Me.Label20.TabIndex = 106
        Me.Label20.Text = "Receipt No. Wise Print"
        '
        'btnPrintCancel
        '
        Me.btnPrintCancel.Location = New System.Drawing.Point(79, 58)
        Me.btnPrintCancel.Name = "btnPrintCancel"
        Me.btnPrintCancel.Size = New System.Drawing.Size(58, 23)
        Me.btnPrintCancel.TabIndex = 104
        Me.btnPrintCancel.Text = "Cancel"
        Me.btnPrintCancel.UseVisualStyleBackColor = True
        '
        'txtprint
        '
        Me.txtprint.Location = New System.Drawing.Point(16, 28)
        Me.txtprint.Name = "txtprint"
        Me.txtprint.Size = New System.Drawing.Size(121, 20)
        Me.txtprint.TabIndex = 102
        Me.txtprint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPrintOK
        '
        Me.btnPrintOK.Location = New System.Drawing.Point(16, 58)
        Me.btnPrintOK.Name = "btnPrintOK"
        Me.btnPrintOK.Size = New System.Drawing.Size(58, 23)
        Me.btnPrintOK.TabIndex = 103
        Me.btnPrintOK.Text = "OK"
        Me.btnPrintOK.UseVisualStyleBackColor = True
        '
        'dgvSaleEntry
        '
        Me.dgvSaleEntry.AllowUserToAddRows = False
        Me.dgvSaleEntry.AllowUserToResizeColumns = False
        Me.dgvSaleEntry.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSaleEntry.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSaleEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSaleEntry.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSL, Me.colProductName, Me.colRate, Me.colQty, Me.colTk, Me.colCode, Me.colAmount, Me.colItemCode, Me.colProfit})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSaleEntry.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSaleEntry.Location = New System.Drawing.Point(18, 177)
        Me.dgvSaleEntry.Name = "dgvSaleEntry"
        Me.dgvSaleEntry.RowHeadersVisible = False
        Me.dgvSaleEntry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSaleEntry.Size = New System.Drawing.Size(643, 273)
        Me.dgvSaleEntry.TabIndex = 138
        '
        'colSL
        '
        Me.colSL.HeaderText = "SL"
        Me.colSL.Name = "colSL"
        Me.colSL.ReadOnly = True
        Me.colSL.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colSL.Width = 40
        '
        'colProductName
        '
        Me.colProductName.HeaderText = "Product Name"
        Me.colProductName.Name = "colProductName"
        Me.colProductName.ReadOnly = True
        Me.colProductName.Width = 160
        '
        'colRate
        '
        Me.colRate.HeaderText = "Base Price"
        Me.colRate.Name = "colRate"
        Me.colRate.ReadOnly = True
        Me.colRate.Width = 75
        '
        'colQty
        '
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        Me.colQty.Width = 35
        '
        'colTk
        '
        Me.colTk.HeaderText = "Tk"
        Me.colTk.Name = "colTk"
        Me.colTk.Width = 55
        '
        'colCode
        '
        Me.colCode.HeaderText = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Width = 60
        '
        'colAmount
        '
        Me.colAmount.HeaderText = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.ReadOnly = True
        Me.colAmount.Width = 80
        '
        'colItemCode
        '
        Me.colItemCode.HeaderText = "Product ID"
        Me.colItemCode.Name = "colItemCode"
        Me.colItemCode.ReadOnly = True
        Me.colItemCode.Width = 80
        '
        'colProfit
        '
        Me.colProfit.HeaderText = "Profit"
        Me.colProfit.Name = "colProfit"
        Me.colProfit.Width = 55
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(184, 135)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 44)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(44, 92)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 15)
        Me.Label17.TabIndex = 148
        Me.Label17.Text = "Net Amount"
        '
        'txtNetAmt
        '
        Me.txtNetAmt.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtNetAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetAmt.Location = New System.Drawing.Point(161, 84)
        Me.txtNetAmt.Name = "txtNetAmt"
        Me.txtNetAmt.Size = New System.Drawing.Size(110, 29)
        Me.txtNetAmt.TabIndex = 149
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(161, 51)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(110, 22)
        Me.txtDiscount.TabIndex = 145
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(44, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 15)
        Me.Label13.TabIndex = 144
        Me.Label13.Text = "Discount"
        '
        'txtGrossAmt
        '
        Me.txtGrossAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrossAmt.Location = New System.Drawing.Point(161, 19)
        Me.txtGrossAmt.Name = "txtGrossAmt"
        Me.txtGrossAmt.ReadOnly = True
        Me.txtGrossAmt.Size = New System.Drawing.Size(110, 22)
        Me.txtGrossAmt.TabIndex = 143
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(43, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 15)
        Me.Label10.TabIndex = 142
        Me.Label10.Text = "Gross Amt"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(679, 15)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtReceiveAmt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label18)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDueAmount)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtChangeAmt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label16)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtNetAmt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label17)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDiscount)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtGrossAmt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnExit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnRefresh)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnDelete)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnInvoicePrint)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnEdit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Size = New System.Drawing.Size(290, 435)
        Me.SplitContainer1.SplitterDistance = 238
        Me.SplitContainer1.TabIndex = 137
        '
        'dtpSaleDate
        '
        Me.dtpSaleDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSaleDate.Location = New System.Drawing.Point(413, 29)
        Me.dtpSaleDate.Name = "dtpSaleDate"
        Me.dtpSaleDate.Size = New System.Drawing.Size(97, 21)
        Me.dtpSaleDate.TabIndex = 158
        '
        'frmSaleEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(985, 461)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.pnlPrint)
        Me.Controls.Add(Me.dgvSaleEntry)
        Me.MaximizeBox = False
        Me.Name = "frmSaleEntry"
        Me.Text = "Sale Entry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.pnlPrint.ResumeLayout(False)
        Me.pnlPrint.PerformLayout()
        CType(Me.dgvSaleEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtReceptNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnInvoicePrint As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtReceiveAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtDueAmount As System.Windows.Forms.TextBox
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtSearchTransNo As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtChangeAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents pnlPrint As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnPrintCancel As System.Windows.Forms.Button
    Friend WithEvents txtprint As System.Windows.Forms.TextBox
    Friend WithEvents btnPrintOK As System.Windows.Forms.Button
    Friend WithEvents dgvSaleEntry As System.Windows.Forms.DataGridView
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtNetAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtGrossAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTk As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSaleCode As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboProductID As System.Windows.Forms.ComboBox
    Friend WithEvents txtbasepricecode As System.Windows.Forms.TextBox
    Friend WithEvents colSL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colProductName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colProfit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpSaleDate As System.Windows.Forms.DateTimePicker
End Class
