<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlRemarks
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
        Me.GroupRepRem1 = New System.Windows.Forms.GroupBox()
        Me.grdRepRemarks1 = New System.Windows.Forms.DataGridView()
        Me.Rem1No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rem1Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rem1Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rem1UNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.imgRepair = New System.Windows.Forms.PictureBox()
        Me.GroupRepRem1.SuspendLayout()
        CType(Me.grdRepRemarks1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgRepair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupRepRem1
        '
        Me.GroupRepRem1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupRepRem1.Controls.Add(Me.grdRepRemarks1)
        Me.GroupRepRem1.Location = New System.Drawing.Point(6, 31)
        Me.GroupRepRem1.Name = "GroupRepRem1"
        Me.GroupRepRem1.Size = New System.Drawing.Size(455, 147)
        Me.GroupRepRem1.TabIndex = 80
        Me.GroupRepRem1.TabStop = False
        Me.GroupRepRem1.Text = "Remarks (by Customer):"
        '
        'grdRepRemarks1
        '
        Me.grdRepRemarks1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdRepRemarks1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdRepRemarks1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRepRemarks1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Rem1No, Me.Rem1Date, Me.Rem1Remarks, Me.Rem1UNo})
        Me.grdRepRemarks1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRepRemarks1.Location = New System.Drawing.Point(3, 18)
        Me.grdRepRemarks1.Name = "grdRepRemarks1"
        Me.grdRepRemarks1.Size = New System.Drawing.Size(449, 126)
        Me.grdRepRemarks1.TabIndex = 23
        '
        'Rem1No
        '
        Me.Rem1No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.Rem1No.HeaderText = "No"
        Me.Rem1No.Name = "Rem1No"
        Me.Rem1No.ReadOnly = True
        Me.Rem1No.Visible = False
        '
        'Rem1Date
        '
        Me.Rem1Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Rem1Date.HeaderText = "Date"
        Me.Rem1Date.Name = "Rem1Date"
        Me.Rem1Date.Width = 58
        '
        'Rem1Remarks
        '
        Me.Rem1Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Rem1Remarks.HeaderText = "Remarks"
        Me.Rem1Remarks.Name = "Rem1Remarks"
        '
        'Rem1UNo
        '
        Me.Rem1UNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Rem1UNo.HeaderText = "User"
        Me.Rem1UNo.Name = "Rem1UNo"
        Me.Rem1UNo.ReadOnly = True
        Me.Rem1UNo.Width = 57
        '
        'cmbLocation
        '
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Location = New System.Drawing.Point(64, 3)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(251, 22)
        Me.cmbLocation.TabIndex = 81
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(3, 6)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(55, 14)
        Me.lblLocation.TabIndex = 83
        Me.lblLocation.Text = "Location:"
        '
        'imgRepair
        '
        Me.imgRepair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgRepair.BackColor = System.Drawing.Color.Black
        Me.imgRepair.Enabled = False
        Me.imgRepair.Location = New System.Drawing.Point(467, 3)
        Me.imgRepair.Name = "imgRepair"
        Me.imgRepair.Size = New System.Drawing.Size(175, 175)
        Me.imgRepair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.imgRepair.TabIndex = 82
        Me.imgRepair.TabStop = False
        '
        'ControlRemarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupRepRem1)
        Me.Controls.Add(Me.cmbLocation)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.imgRepair)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlRemarks"
        Me.Size = New System.Drawing.Size(645, 184)
        Me.GroupRepRem1.ResumeLayout(False)
        CType(Me.grdRepRemarks1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgRepair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupRepRem1 As GroupBox
    Friend WithEvents grdRepRemarks1 As DataGridView
    Friend WithEvents Rem1No As DataGridViewTextBoxColumn
    Friend WithEvents Rem1Date As DataGridViewTextBoxColumn
    Friend WithEvents Rem1Remarks As DataGridViewTextBoxColumn
    Friend WithEvents Rem1UNo As DataGridViewTextBoxColumn
    Friend WithEvents cmbLocation As ComboBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents imgRepair As PictureBox
End Class
