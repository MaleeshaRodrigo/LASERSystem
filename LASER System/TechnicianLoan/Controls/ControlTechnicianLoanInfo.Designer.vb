<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlTechnicianLoanInfo
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.boxItem = New System.Windows.Forms.GroupBox()
        Me.ControlTechnicianSelection = New LASER_System.ControlTechnicianSelection()
        Me.TextAmount = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.TextDate = New System.Windows.Forms.DateTimePicker()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.TextNo = New System.Windows.Forms.TextBox()
        Me.lblRs1 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextItemPrice = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ControlStockSelection = New LASER_System.ControlStockSelection()
        Me.TextQty = New System.Windows.Forms.NumericUpDown()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextReason = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.boxItem.SuspendLayout()
        CType(Me.TextAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TextItemPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'boxItem
        '
        Me.boxItem.Controls.Add(Me.ControlTechnicianSelection)
        Me.boxItem.Controls.Add(Me.TextAmount)
        Me.boxItem.Controls.Add(Me.Label1)
        Me.boxItem.Controls.Add(Me.ButtonDelete)
        Me.boxItem.Controls.Add(Me.TextDate)
        Me.boxItem.Controls.Add(Me.ButtonSave)
        Me.boxItem.Controls.Add(Me.Label10)
        Me.boxItem.Controls.Add(Me.ButtonClose)
        Me.boxItem.Controls.Add(Me.TextNo)
        Me.boxItem.Controls.Add(Me.lblRs1)
        Me.boxItem.Controls.Add(Me.Label58)
        Me.boxItem.Controls.Add(Me.GroupBox2)
        Me.boxItem.Controls.Add(Me.Label3)
        Me.boxItem.Controls.Add(Me.Label4)
        Me.boxItem.Controls.Add(Me.TextReason)
        Me.boxItem.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.boxItem.Location = New System.Drawing.Point(106, 70)
        Me.boxItem.Name = "boxItem"
        Me.boxItem.Size = New System.Drawing.Size(368, 435)
        Me.boxItem.TabIndex = 64
        Me.boxItem.TabStop = False
        Me.boxItem.Text = "Technician Loan Info"
        '
        'ControlTechnicianSelection
        '
        Me.ControlTechnicianSelection.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.ControlTechnicianSelection.Location = New System.Drawing.Point(6, 49)
        Me.ControlTechnicianSelection.MaximumSize = New System.Drawing.Size(250, 29)
        Me.ControlTechnicianSelection.MinimumSize = New System.Drawing.Size(200, 25)
        Me.ControlTechnicianSelection.Name = "ControlTechnicianSelection"
        Me.ControlTechnicianSelection.Size = New System.Drawing.Size(231, 25)
        Me.ControlTechnicianSelection.TabIndex = 131
        '
        'TextAmount
        '
        Me.TextAmount.DecimalPlaces = 2
        Me.TextAmount.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TextAmount.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.TextAmount.Location = New System.Drawing.Point(98, 357)
        Me.TextAmount.Maximum = New Decimal(New Integer() {-1981284353, -1966660860, 0, 0})
        Me.TextAmount.Minimum = New Decimal(New Integer() {-1981284353, -1966660860, 0, -2147483648})
        Me.TextAmount.Name = "TextAmount"
        Me.TextAmount.Size = New System.Drawing.Size(119, 24)
        Me.TextAmount.TabIndex = 122
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(132, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 17)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "TL-"
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDelete.Enabled = False
        Me.ButtonDelete.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ButtonDelete.Image = Global.LASER_System.My.Resources.Resources.Delete
        Me.ButtonDelete.Location = New System.Drawing.Point(204, 390)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(76, 39)
        Me.ButtonDelete.TabIndex = 128
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'TextDate
        '
        Me.TextDate.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TextDate.Location = New System.Drawing.Point(52, 80)
        Me.TextDate.Name = "TextDate"
        Me.TextDate.Size = New System.Drawing.Size(271, 24)
        Me.TextDate.TabIndex = 92
        '
        'ButtonSave
        '
        Me.ButtonSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSave.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ButtonSave.Image = Global.LASER_System.My.Resources.Resources.Save
        Me.ButtonSave.Location = New System.Drawing.Point(124, 391)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(76, 37)
        Me.ButtonSave.TabIndex = 126
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(6, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 17)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Date:"
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ButtonClose.Image = Global.LASER_System.My.Resources.Resources.close
        Me.ButtonClose.Location = New System.Drawing.Point(286, 389)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(76, 40)
        Me.ButtonClose.TabIndex = 125
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'TextNo
        '
        Me.TextNo.Enabled = False
        Me.TextNo.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TextNo.Location = New System.Drawing.Point(163, 21)
        Me.TextNo.Name = "TextNo"
        Me.TextNo.Size = New System.Drawing.Size(63, 24)
        Me.TextNo.TabIndex = 90
        '
        'lblRs1
        '
        Me.lblRs1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblRs1.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.lblRs1.Location = New System.Drawing.Point(72, 357)
        Me.lblRs1.Name = "lblRs1"
        Me.lblRs1.Size = New System.Drawing.Size(24, 24)
        Me.lblRs1.TabIndex = 124
        Me.lblRs1.Text = "Rs."
        Me.lblRs1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label58.Location = New System.Drawing.Point(6, 23)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(120, 17)
        Me.Label58.TabIndex = 89
        Me.Label58.Text = "Technician Loan No:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextItemPrice)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ControlStockSelection)
        Me.GroupBox2.Controls.Add(Me.TextQty)
        Me.GroupBox2.Controls.Add(Me.Label55)
        Me.GroupBox2.Controls.Add(Me.Label54)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 140)
        Me.GroupBox2.TabIndex = 119
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item Info"
        '
        'TextItemPrice
        '
        Me.TextItemPrice.DecimalPlaces = 2
        Me.TextItemPrice.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TextItemPrice.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.TextItemPrice.Location = New System.Drawing.Point(97, 106)
        Me.TextItemPrice.Maximum = New Decimal(New Integer() {-1981284353, -1966660860, 0, 0})
        Me.TextItemPrice.Name = "TextItemPrice"
        Me.TextItemPrice.Size = New System.Drawing.Size(133, 24)
        Me.TextItemPrice.TabIndex = 119
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(72, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 24)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "Rs."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ControlStockSelection
        '
        Me.ControlStockSelection.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.ControlStockSelection.Location = New System.Drawing.Point(4, 16)
        Me.ControlStockSelection.MaximumSize = New System.Drawing.Size(350, 90)
        Me.ControlStockSelection.MinimumSize = New System.Drawing.Size(200, 90)
        Me.ControlStockSelection.Name = "ControlStockSelection"
        Me.ControlStockSelection.SCategory = ""
        Me.ControlStockSelection.SCode = 0
        Me.ControlStockSelection.Size = New System.Drawing.Size(340, 90)
        Me.ControlStockSelection.SName = ""
        Me.ControlStockSelection.TabIndex = 121
        '
        'TextQty
        '
        Me.TextQty.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TextQty.Location = New System.Drawing.Point(271, 106)
        Me.TextQty.Maximum = New Decimal(New Integer() {-1304428545, 434162106, 542, 0})
        Me.TextQty.Name = "TextQty"
        Me.TextQty.Size = New System.Drawing.Size(73, 24)
        Me.TextQty.TabIndex = 120
        Me.TextQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label55.Location = New System.Drawing.Point(236, 110)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(32, 17)
        Me.Label55.TabIndex = 106
        Me.Label55.Text = "Qty:"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label54.Location = New System.Drawing.Point(8, 110)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(39, 17)
        Me.Label54.TabIndex = 104
        Me.Label54.Text = "Rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(9, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Amount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Reason:"
        '
        'TextReason
        '
        Me.TextReason.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TextReason.Location = New System.Drawing.Point(6, 273)
        Me.TextReason.Multiline = True
        Me.TextReason.Name = "TextReason"
        Me.TextReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextReason.Size = New System.Drawing.Size(354, 78)
        Me.TextReason.TabIndex = 121
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.boxItem, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(580, 575)
        Me.TableLayoutPanel1.TabIndex = 129
        '
        'ControlTechnicianLoanInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlTechnicianLoanInfo"
        Me.Size = New System.Drawing.Size(580, 575)
        Me.boxItem.ResumeLayout(False)
        Me.boxItem.PerformLayout()
        CType(Me.TextAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TextItemPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents boxItem As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents TextNo As TextBox
    Friend WithEvents Label58 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents TextReason As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblRs1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextQty As NumericUpDown
    Friend WithEvents TextItemPrice As NumericUpDown
    Friend WithEvents ControlStockSelection As ControlStockSelection
    Friend WithEvents TextAmount As NumericUpDown
    Friend WithEvents ControlTechnicianSelection As ControlTechnicianSelection
End Class
