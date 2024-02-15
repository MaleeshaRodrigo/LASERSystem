<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlTechnicianInfo
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
        Me.grdRepRemarks2 = New System.Windows.Forms.DataGridView()
        Me.Rem2No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepRemarks2Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepRemarks2Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rem2User = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxTechnician = New System.Windows.Forms.GroupBox()
        Me.cmbTName = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.grdRepRemarks2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxTechnician.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdRepRemarks2
        '
        Me.grdRepRemarks2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdRepRemarks2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdRepRemarks2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRepRemarks2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Rem2No, Me.RepRemarks2Date, Me.RepRemarks2Remarks, Me.Rem2User})
        Me.grdRepRemarks2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRepRemarks2.Location = New System.Drawing.Point(3, 18)
        Me.grdRepRemarks2.Name = "grdRepRemarks2"
        Me.grdRepRemarks2.Size = New System.Drawing.Size(503, 115)
        Me.grdRepRemarks2.TabIndex = 66
        '
        'Rem2No
        '
        Me.Rem2No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.Rem2No.HeaderText = "No"
        Me.Rem2No.Name = "Rem2No"
        Me.Rem2No.ReadOnly = True
        Me.Rem2No.Visible = False
        '
        'RepRemarks2Date
        '
        Me.RepRemarks2Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RepRemarks2Date.HeaderText = "Date"
        Me.RepRemarks2Date.Name = "RepRemarks2Date"
        Me.RepRemarks2Date.Width = 58
        '
        'RepRemarks2Remarks
        '
        Me.RepRemarks2Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RepRemarks2Remarks.HeaderText = "Remarks"
        Me.RepRemarks2Remarks.Name = "RepRemarks2Remarks"
        '
        'Rem2User
        '
        Me.Rem2User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Rem2User.HeaderText = "User"
        Me.Rem2User.Name = "Rem2User"
        Me.Rem2User.ReadOnly = True
        Me.Rem2User.Width = 57
        '
        'boxTechnician
        '
        Me.boxTechnician.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boxTechnician.Controls.Add(Me.cmbTName)
        Me.boxTechnician.Controls.Add(Me.Label19)
        Me.boxTechnician.Cursor = System.Windows.Forms.Cursors.Default
        Me.boxTechnician.Location = New System.Drawing.Point(3, 3)
        Me.boxTechnician.Name = "boxTechnician"
        Me.boxTechnician.Size = New System.Drawing.Size(509, 50)
        Me.boxTechnician.TabIndex = 67
        Me.boxTechnician.TabStop = False
        Me.boxTechnician.Text = "Technician Info"
        '
        'cmbTName
        '
        Me.cmbTName.FormattingEnabled = True
        Me.cmbTName.Location = New System.Drawing.Point(60, 19)
        Me.cmbTName.Name = "cmbTName"
        Me.cmbTName.Size = New System.Drawing.Size(218, 22)
        Me.cmbTName.TabIndex = 24
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 14)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Name : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.grdRepRemarks2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 136)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Remarks(by Technician):"
        '
        'ControlTechnicianInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.boxTechnician)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlTechnicianInfo"
        Me.Size = New System.Drawing.Size(515, 198)
        CType(Me.grdRepRemarks2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxTechnician.ResumeLayout(False)
        Me.boxTechnician.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdRepRemarks2 As DataGridView
    Friend WithEvents Rem2No As DataGridViewTextBoxColumn
    Friend WithEvents RepRemarks2Date As DataGridViewTextBoxColumn
    Friend WithEvents RepRemarks2Remarks As DataGridViewTextBoxColumn
    Friend WithEvents Rem2User As DataGridViewTextBoxColumn
    Friend WithEvents boxTechnician As GroupBox
    Friend WithEvents cmbTName As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
