<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlCashierDashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlCashierDashboard))
        Me.LabelLastLogin = New System.Windows.Forms.Label()
        Me.LabelLogCount = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelUserName = New System.Windows.Forms.Label()
        Me.PictureUserImage = New System.Windows.Forms.PictureBox()
        Me.GridCashierSales = New System.Windows.Forms.DataGridView()
        Me.LabelProfit = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.PickerTo = New System.Windows.Forms.DateTimePicker()
        Me.UDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LowestPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalLowestPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Profit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCashierSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelLastLogin
        '
        Me.LabelLastLogin.AutoSize = True
        Me.LabelLastLogin.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.LabelLastLogin.Location = New System.Drawing.Point(193, 74)
        Me.LabelLastLogin.Name = "LabelLastLogin"
        Me.LabelLastLogin.Size = New System.Drawing.Size(68, 17)
        Me.LabelLastLogin.TabIndex = 9
        Me.LabelLastLogin.Text = "Last Login:"
        '
        'LabelLogCount
        '
        Me.LabelLogCount.AutoSize = True
        Me.LabelLogCount.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.LabelLogCount.Location = New System.Drawing.Point(192, 104)
        Me.LabelLogCount.Name = "LabelLogCount"
        Me.LabelLogCount.Size = New System.Drawing.Size(82, 17)
        Me.LabelLogCount.TabIndex = 8
        Me.LabelLogCount.Text = "Log In Count:"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.LabelEmail.Location = New System.Drawing.Point(192, 38)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(61, 24)
        Me.LabelEmail.TabIndex = 7
        Me.LabelEmail.Text = "Email:"
        '
        'LabelUserName
        '
        Me.LabelUserName.AutoSize = True
        Me.LabelUserName.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.LabelUserName.Location = New System.Drawing.Point(192, 3)
        Me.LabelUserName.Name = "LabelUserName"
        Me.LabelUserName.Size = New System.Drawing.Size(64, 24)
        Me.LabelUserName.TabIndex = 6
        Me.LabelUserName.Text = "Name:"
        '
        'PictureUserImage
        '
        Me.PictureUserImage.BackColor = System.Drawing.Color.Transparent
        Me.PictureUserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureUserImage.Image = Global.LASER_System.My.Resources.Resources.Customer
        Me.PictureUserImage.InitialImage = CType(resources.GetObject("PictureUserImage.InitialImage"), System.Drawing.Image)
        Me.PictureUserImage.Location = New System.Drawing.Point(3, 3)
        Me.PictureUserImage.Name = "PictureUserImage"
        Me.PictureUserImage.Size = New System.Drawing.Size(183, 176)
        Me.PictureUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureUserImage.TabIndex = 5
        Me.PictureUserImage.TabStop = False
        '
        'GridCashierSales
        '
        Me.GridCashierSales.AllowUserToAddRows = False
        Me.GridCashierSales.AllowUserToDeleteRows = False
        Me.GridCashierSales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCashierSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridCashierSales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UDate, Me.SNo, Me.SCategory, Me.SName, Me.Type, Me.LowestPrice, Me.Rate, Me.Qty, Me.TotalLowestPrice, Me.Total, Me.Profit})
        Me.GridCashierSales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridCashierSales.Location = New System.Drawing.Point(3, 186)
        Me.GridCashierSales.Name = "GridCashierSales"
        Me.GridCashierSales.Size = New System.Drawing.Size(707, 257)
        Me.GridCashierSales.TabIndex = 10
        '
        'LabelProfit
        '
        Me.LabelProfit.AutoSize = True
        Me.LabelProfit.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.LabelProfit.Location = New System.Drawing.Point(191, 131)
        Me.LabelProfit.Name = "LabelProfit"
        Me.LabelProfit.Size = New System.Drawing.Size(61, 24)
        Me.LabelProfit.TabIndex = 11
        Me.LabelProfit.Text = "Profit:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 14)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "From:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(463, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 14)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "To:"
        '
        'PickerFrom
        '
        Me.PickerFrom.Location = New System.Drawing.Point(237, 158)
        Me.PickerFrom.Name = "PickerFrom"
        Me.PickerFrom.Size = New System.Drawing.Size(220, 22)
        Me.PickerFrom.TabIndex = 14
        '
        'PickerTo
        '
        Me.PickerTo.Location = New System.Drawing.Point(491, 157)
        Me.PickerTo.Name = "PickerTo"
        Me.PickerTo.Size = New System.Drawing.Size(220, 22)
        Me.PickerTo.TabIndex = 15
        '
        'UDate
        '
        Me.UDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UDate.DataPropertyName = "Date"
        Me.UDate.HeaderText = "Date"
        Me.UDate.Name = "UDate"
        Me.UDate.Width = 58
        '
        'SNo
        '
        Me.SNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SNo.DataPropertyName = "SNo"
        Me.SNo.HeaderText = "Stock Code"
        Me.SNo.Name = "SNo"
        Me.SNo.Width = 83
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
        'Type
        '
        Me.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Type.DataPropertyName = "Type"
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.Width = 56
        '
        'LowestPrice
        '
        Me.LowestPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.LowestPrice.DataPropertyName = "LowestPrice"
        Me.LowestPrice.HeaderText = "Lowest Price"
        Me.LowestPrice.Name = "LowestPrice"
        Me.LowestPrice.Width = 91
        '
        'Rate
        '
        Me.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Rate.DataPropertyName = "Rate"
        Me.Rate.HeaderText = "Sold Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.Width = 78
        '
        'Qty
        '
        Me.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Qty.DataPropertyName = "Qty"
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 49
        '
        'TotalLowestPrice
        '
        Me.TotalLowestPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TotalLowestPrice.DataPropertyName = "TotalLowestPrice"
        Me.TotalLowestPrice.HeaderText = "Total Lowest Price"
        Me.TotalLowestPrice.Name = "TotalLowestPrice"
        Me.TotalLowestPrice.Width = 118
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Total.DataPropertyName = "Total"
        Me.Total.HeaderText = "Total Sold Price"
        Me.Total.Name = "Total"
        Me.Total.Width = 106
        '
        'Profit
        '
        Me.Profit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Profit.DataPropertyName = "Profit"
        Me.Profit.HeaderText = "Profit"
        Me.Profit.Name = "Profit"
        Me.Profit.Width = 59
        '
        'ControlCashierDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PickerTo)
        Me.Controls.Add(Me.PickerFrom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelProfit)
        Me.Controls.Add(Me.GridCashierSales)
        Me.Controls.Add(Me.LabelLastLogin)
        Me.Controls.Add(Me.LabelLogCount)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelUserName)
        Me.Controls.Add(Me.PictureUserImage)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlCashierDashboard"
        Me.Size = New System.Drawing.Size(715, 446)
        CType(Me.PictureUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCashierSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelLastLogin As Label
    Friend WithEvents LabelLogCount As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelUserName As Label
    Friend WithEvents PictureUserImage As PictureBox
    Friend WithEvents GridCashierSales As DataGridView
    Friend WithEvents LabelProfit As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PickerFrom As DateTimePicker
    Friend WithEvents PickerTo As DateTimePicker
    Friend WithEvents UDate As DataGridViewTextBoxColumn
    Friend WithEvents SNo As DataGridViewTextBoxColumn
    Friend WithEvents SCategory As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents LowestPrice As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents TotalLowestPrice As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Profit As DataGridViewTextBoxColumn
End Class
