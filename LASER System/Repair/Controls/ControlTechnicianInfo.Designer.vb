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
        Me.ComboHandOverTo = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.grdRepRemarks2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxTechnician.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.grdRepRemarks2.RowHeadersWidth = 51
        Me.grdRepRemarks2.Size = New System.Drawing.Size(503, 110)
        Me.grdRepRemarks2.TabIndex = 66
        '
        'Rem2No
        '
        Me.Rem2No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.Rem2No.DataPropertyName = "Rem2No"
        Me.Rem2No.HeaderText = "No"
        Me.Rem2No.MinimumWidth = 6
        Me.Rem2No.Name = "Rem2No"
        Me.Rem2No.ReadOnly = True
        Me.Rem2No.Visible = False
        '
        'RepRemarks2Date
        '
        Me.RepRemarks2Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RepRemarks2Date.DataPropertyName = "Rem2Date"
        Me.RepRemarks2Date.HeaderText = "Date"
        Me.RepRemarks2Date.MinimumWidth = 6
        Me.RepRemarks2Date.Name = "RepRemarks2Date"
        Me.RepRemarks2Date.Width = 58
        '
        'RepRemarks2Remarks
        '
        Me.RepRemarks2Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RepRemarks2Remarks.DataPropertyName = "Remarks"
        Me.RepRemarks2Remarks.HeaderText = "Remarks"
        Me.RepRemarks2Remarks.MinimumWidth = 6
        Me.RepRemarks2Remarks.Name = "RepRemarks2Remarks"
        '
        'Rem2User
        '
        Me.Rem2User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Rem2User.DataPropertyName = "UserName"
        Me.Rem2User.HeaderText = "User"
        Me.Rem2User.MinimumWidth = 6
        Me.Rem2User.Name = "Rem2User"
        Me.Rem2User.ReadOnly = True
        Me.Rem2User.Width = 57
        '
        'boxTechnician
        '
        Me.boxTechnician.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boxTechnician.Controls.Add(Me.TableLayoutPanel1)
        Me.boxTechnician.Cursor = System.Windows.Forms.Cursors.Default
        Me.boxTechnician.Location = New System.Drawing.Point(3, 3)
        Me.boxTechnician.Name = "boxTechnician"
        Me.boxTechnician.Size = New System.Drawing.Size(509, 55)
        Me.boxTechnician.TabIndex = 67
        Me.boxTechnician.TabStop = False
        Me.boxTechnician.Text = "Technician Info"
        '
        'ComboHandOverTo
        '
        Me.ComboHandOverTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboHandOverTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboHandOverTo.FormattingEnabled = True
        Me.ComboHandOverTo.Location = New System.Drawing.Point(107, 3)
        Me.ComboHandOverTo.Name = "ComboHandOverTo"
        Me.ComboHandOverTo.Size = New System.Drawing.Size(139, 22)
        Me.ComboHandOverTo.TabIndex = 24
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 5)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 14)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Handed Over To: "
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.grdRepRemarks2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 131)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Remarks(by Technician):"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(87, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(154, 22)
        Me.ComboBox1.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 14)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Assigned To: "
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(503, 34)
        Me.TableLayoutPanel1.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 28)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.ComboHandOverTo)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(254, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(246, 28)
        Me.Panel2.TabIndex = 1
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
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdRepRemarks2 As DataGridView
    Friend WithEvents boxTechnician As GroupBox
    Friend WithEvents ComboHandOverTo As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Rem2No As DataGridViewTextBoxColumn
    Friend WithEvents RepRemarks2Date As DataGridViewTextBoxColumn
    Friend WithEvents RepRemarks2Remarks As DataGridViewTextBoxColumn
    Friend WithEvents Rem2User As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
