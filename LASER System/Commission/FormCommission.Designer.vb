<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCommission
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
        Me.GridCommission = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboUser = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.TextDateTo = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonSubmit = New System.Windows.Forms.Button()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextSaTotal = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SaDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SLowestPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.GridCommission, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextSaTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridCommission
        '
        Me.GridCommission.AllowUserToAddRows = False
        Me.GridCommission.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCommission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridCommission.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SaDate, Me.SNo, Me.SCategory, Me.SName, Me.SaType, Me.SaRate, Me.SLowestPrice, Me.Qty, Me.SaTotal, Me.Total, Me.Action})
        Me.GridCommission.Location = New System.Drawing.Point(12, 47)
        Me.GridCommission.Name = "GridCommission"
        Me.GridCommission.Size = New System.Drawing.Size(914, 388)
        Me.GridCommission.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User: "
        '
        'ComboUser
        '
        Me.ComboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboUser.FormattingEnabled = True
        Me.ComboUser.Location = New System.Drawing.Point(57, 12)
        Me.ComboUser.Name = "ComboUser"
        Me.ComboUser.Size = New System.Drawing.Size(187, 22)
        Me.ComboUser.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "From:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(515, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "To:"
        '
        'TextDateFrom
        '
        Me.TextDateFrom.Location = New System.Drawing.Point(295, 12)
        Me.TextDateFrom.Name = "TextDateFrom"
        Me.TextDateFrom.Size = New System.Drawing.Size(213, 22)
        Me.TextDateFrom.TabIndex = 5
        '
        'TextDateTo
        '
        Me.TextDateTo.Location = New System.Drawing.Point(544, 12)
        Me.TextDateTo.Name = "TextDateTo"
        Me.TextDateTo.Size = New System.Drawing.Size(213, 22)
        Me.TextDateTo.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ButtonSubmit)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextSaTotal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 441)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(914, 83)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Result of Salesman Commission"
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSubmit.Image = Global.LASER_System.My.Resources.Resources.Save
        Me.ButtonSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSubmit.Location = New System.Drawing.Point(819, 41)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.Size = New System.Drawing.Size(89, 36)
        Me.ButtonSubmit.TabIndex = 10
        Me.ButtonSubmit.Text = "Submit"
        Me.ButtonSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonSubmit.UseVisualStyleBackColor = True
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NumericUpDown4.Location = New System.Drawing.Point(623, 21)
        Me.NumericUpDown4.Maximum = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.ReadOnly = True
        Me.NumericUpDown4.Size = New System.Drawing.Size(107, 27)
        Me.NumericUpDown4.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(485, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Total Commission:"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(385, 49)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.ReadOnly = True
        Me.NumericUpDown3.Size = New System.Drawing.Size(48, 22)
        Me.NumericUpDown3.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(239, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 14)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Commission Precentage:"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(368, 21)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.ReadOnly = True
        Me.NumericUpDown2.Size = New System.Drawing.Size(107, 22)
        Me.NumericUpDown2.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(239, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 14)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Total of Less Amount:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(125, 49)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.ReadOnly = True
        Me.NumericUpDown1.Size = New System.Drawing.Size(107, 22)
        Me.NumericUpDown1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total of Cost Prices:"
        '
        'TextSaTotal
        '
        Me.TextSaTotal.Location = New System.Drawing.Point(125, 21)
        Me.TextSaTotal.Maximum = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.TextSaTotal.Name = "TextSaTotal"
        Me.TextSaTotal.ReadOnly = True
        Me.TextSaTotal.Size = New System.Drawing.Size(107, 22)
        Me.TextSaTotal.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total of Sale Prices:"
        '
        'SaDate
        '
        Me.SaDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SaDate.DataPropertyName = "SaDate"
        Me.SaDate.HeaderText = "Sold Date"
        Me.SaDate.Name = "SaDate"
        Me.SaDate.ReadOnly = True
        Me.SaDate.Width = 85
        '
        'SNo
        '
        Me.SNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.SNo.DataPropertyName = "SNo"
        Me.SNo.HeaderText = "Stock Code"
        Me.SNo.Name = "SNo"
        Me.SNo.Width = 21
        '
        'SCategory
        '
        Me.SCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SCategory.DataPropertyName = "SCategory"
        Me.SCategory.HeaderText = "Stock Category"
        Me.SCategory.Name = "SCategory"
        '
        'SName
        '
        Me.SName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SName.DataPropertyName = "SName"
        Me.SName.HeaderText = "Stock Name"
        Me.SName.Name = "SName"
        Me.SName.Width = 88
        '
        'SaType
        '
        Me.SaType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SaType.DataPropertyName = "SaType"
        Me.SaType.HeaderText = "Sold Type"
        Me.SaType.Name = "SaType"
        Me.SaType.ReadOnly = True
        Me.SaType.Width = 77
        '
        'SaRate
        '
        Me.SaRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.SaRate.DataPropertyName = "SaRate"
        Me.SaRate.HeaderText = "Sold Price"
        Me.SaRate.Name = "SaRate"
        Me.SaRate.ReadOnly = True
        Me.SaRate.Width = 21
        '
        'SLowestPrice
        '
        Me.SLowestPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.SLowestPrice.DataPropertyName = "SLowestPrice"
        Me.SLowestPrice.HeaderText = "Cost Price"
        Me.SLowestPrice.Name = "SLowestPrice"
        Me.SLowestPrice.Width = 21
        '
        'Qty
        '
        Me.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.Qty.DataPropertyName = "SaUnits"
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        Me.Qty.Width = 21
        '
        'SaTotal
        '
        Me.SaTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.SaTotal.DataPropertyName = "SaTotal"
        Me.SaTotal.HeaderText = "Total of Sold Price"
        Me.SaTotal.Name = "SaTotal"
        Me.SaTotal.ReadOnly = True
        Me.SaTotal.Width = 21
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.Total.DataPropertyName = "SaTotalLowest"
        Me.Total.HeaderText = "Total of Cost Price"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 21
        '
        'Action
        '
        Me.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Action.HeaderText = "Action"
        Me.Action.Name = "Action"
        Me.Action.Text = "Open Stock"
        Me.Action.ToolTipText = "Open the related stock"
        Me.Action.UseColumnTextForButtonValue = True
        Me.Action.Width = 46
        '
        'FormCommission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 545)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextDateTo)
        Me.Controls.Add(Me.TextDateFrom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridCommission)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "FormCommission"
        Me.Text = "LASER System - Salesman Commission"
        CType(Me.GridCommission, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextSaTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridCommission As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboUser As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextDateFrom As DateTimePicker
    Friend WithEvents TextDateTo As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextSaTotal As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonSubmit As Button
    Friend WithEvents SaDate As DataGridViewTextBoxColumn
    Friend WithEvents SNo As DataGridViewTextBoxColumn
    Friend WithEvents SCategory As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents SaType As DataGridViewTextBoxColumn
    Friend WithEvents SaRate As DataGridViewTextBoxColumn
    Friend WithEvents SLowestPrice As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents SaTotal As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Action As DataGridViewButtonColumn
End Class
