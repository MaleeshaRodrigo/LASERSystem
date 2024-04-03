<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlAdvancePayInfo
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
        Me.grpAdvancePay = New System.Windows.Forms.GroupBox()
        Me.grdAdvance = New System.Windows.Forms.DataGridView()
        Me.AdvancePayAVNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdvancePayDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdvancePayPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdvancePayRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpAdvancePay.SuspendLayout()
        CType(Me.grdAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpAdvancePay
        '
        Me.grpAdvancePay.Controls.Add(Me.grdAdvance)
        Me.grpAdvancePay.Cursor = System.Windows.Forms.Cursors.Default
        Me.grpAdvancePay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpAdvancePay.Location = New System.Drawing.Point(0, 0)
        Me.grpAdvancePay.Name = "grpAdvancePay"
        Me.grpAdvancePay.Size = New System.Drawing.Size(509, 104)
        Me.grpAdvancePay.TabIndex = 84
        Me.grpAdvancePay.TabStop = False
        Me.grpAdvancePay.Text = "Advance Pay Info"
        '
        'grdAdvance
        '
        Me.grdAdvance.AllowUserToAddRows = False
        Me.grdAdvance.AllowUserToDeleteRows = False
        Me.grdAdvance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdAdvance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdAdvance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdAdvance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdvancePayAVNo, Me.AdvancePayDate, Me.AdvancePayPrice, Me.AdvancePayRemarks})
        Me.grdAdvance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAdvance.Location = New System.Drawing.Point(3, 18)
        Me.grdAdvance.Name = "grdAdvance"
        Me.grdAdvance.ReadOnly = True
        Me.grdAdvance.Size = New System.Drawing.Size(503, 83)
        Me.grdAdvance.TabIndex = 32
        '
        'AdvancePayAVNo
        '
        Me.AdvancePayAVNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.AdvancePayAVNo.HeaderText = "Advance Pay No"
        Me.AdvancePayAVNo.Name = "AdvancePayAVNo"
        Me.AdvancePayAVNo.ReadOnly = True
        Me.AdvancePayAVNo.Width = 5
        '
        'AdvancePayDate
        '
        Me.AdvancePayDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AdvancePayDate.HeaderText = "Date"
        Me.AdvancePayDate.Name = "AdvancePayDate"
        Me.AdvancePayDate.ReadOnly = True
        Me.AdvancePayDate.Width = 58
        '
        'AdvancePayPrice
        '
        Me.AdvancePayPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AdvancePayPrice.HeaderText = "Price"
        Me.AdvancePayPrice.Name = "AdvancePayPrice"
        Me.AdvancePayPrice.ReadOnly = True
        Me.AdvancePayPrice.Width = 58
        '
        'AdvancePayRemarks
        '
        Me.AdvancePayRemarks.HeaderText = "Remarks"
        Me.AdvancePayRemarks.Name = "AdvancePayRemarks"
        Me.AdvancePayRemarks.ReadOnly = True
        '
        'ControlAdvancePayInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpAdvancePay)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlAdvancePayInfo"
        Me.Size = New System.Drawing.Size(509, 104)
        Me.grpAdvancePay.ResumeLayout(False)
        CType(Me.grdAdvance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpAdvancePay As GroupBox
    Friend WithEvents grdAdvance As DataGridView
    Friend WithEvents AdvancePayAVNo As DataGridViewTextBoxColumn
    Friend WithEvents AdvancePayDate As DataGridViewTextBoxColumn
    Friend WithEvents AdvancePayPrice As DataGridViewTextBoxColumn
    Friend WithEvents AdvancePayRemarks As DataGridViewTextBoxColumn
End Class
