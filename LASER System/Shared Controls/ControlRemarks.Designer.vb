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
        Me.GridRemarks = New System.Windows.Forms.DataGridView()
        Me.RemNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupRepRem1.SuspendLayout()
        CType(Me.GridRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupRepRem1
        '
        Me.GroupRepRem1.Controls.Add(Me.GridRemarks)
        Me.GroupRepRem1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupRepRem1.Location = New System.Drawing.Point(0, 0)
        Me.GroupRepRem1.Name = "GroupRepRem1"
        Me.GroupRepRem1.Size = New System.Drawing.Size(428, 158)
        Me.GroupRepRem1.TabIndex = 81
        Me.GroupRepRem1.TabStop = False
        Me.GroupRepRem1.Text = "Remarks (by Customer):"
        '
        'GridRemarks
        '
        Me.GridRemarks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GridRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridRemarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridRemarks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RemNo, Me.RemDate, Me.Remarks, Me.RemUser})
        Me.GridRemarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridRemarks.Location = New System.Drawing.Point(3, 18)
        Me.GridRemarks.Name = "GridRemarks"
        Me.GridRemarks.RowHeadersWidth = 51
        Me.GridRemarks.Size = New System.Drawing.Size(422, 137)
        Me.GridRemarks.TabIndex = 23
        '
        'RemNo
        '
        Me.RemNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.RemNo.DataPropertyName = "RemNo"
        Me.RemNo.HeaderText = "No"
        Me.RemNo.MinimumWidth = 6
        Me.RemNo.Name = "RemNo"
        Me.RemNo.ReadOnly = True
        Me.RemNo.Visible = False
        Me.RemNo.Width = 6
        '
        'RemDate
        '
        Me.RemDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RemDate.DataPropertyName = "RemDate"
        Me.RemDate.HeaderText = "Date"
        Me.RemDate.MinimumWidth = 6
        Me.RemDate.Name = "RemDate"
        Me.RemDate.Width = 58
        '
        'Remarks
        '
        Me.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Remarks.DataPropertyName = "Remarks"
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.MinimumWidth = 6
        Me.Remarks.Name = "Remarks"
        '
        'RemUser
        '
        Me.RemUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RemUser.DataPropertyName = "UserName"
        Me.RemUser.HeaderText = "User"
        Me.RemUser.MinimumWidth = 6
        Me.RemUser.Name = "RemUser"
        Me.RemUser.ReadOnly = True
        Me.RemUser.Width = 57
        '
        'ControlRemarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupRepRem1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlRemarks"
        Me.Size = New System.Drawing.Size(428, 158)
        Me.GroupRepRem1.ResumeLayout(False)
        CType(Me.GridRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupRepRem1 As GroupBox
    Friend WithEvents GridRemarks As DataGridView
    Friend WithEvents RemNo As DataGridViewTextBoxColumn
    Friend WithEvents RemDate As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
    Friend WithEvents RemUser As DataGridViewTextBoxColumn
End Class
