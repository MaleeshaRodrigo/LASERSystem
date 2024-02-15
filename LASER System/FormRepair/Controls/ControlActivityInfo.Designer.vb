<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlActivityInfo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpActivity = New System.Windows.Forms.GroupBox()
        Me.grdActivity = New System.Windows.Forms.DataGridView()
        Me.ANo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivityDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivityActivity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpActivity.SuspendLayout()
        CType(Me.grdActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpActivity
        '
        Me.grpActivity.Controls.Add(Me.grdActivity)
        Me.grpActivity.Cursor = System.Windows.Forms.Cursors.Default
        Me.grpActivity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpActivity.Location = New System.Drawing.Point(0, 0)
        Me.grpActivity.Name = "grpActivity"
        Me.grpActivity.Size = New System.Drawing.Size(559, 164)
        Me.grpActivity.TabIndex = 83
        Me.grpActivity.TabStop = False
        Me.grpActivity.Text = "Activity Info"
        '
        'grdActivity
        '
        Me.grdActivity.AllowUserToAddRows = False
        Me.grdActivity.AllowUserToDeleteRows = False
        Me.grdActivity.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdActivity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdActivity.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ANo, Me.ActivityDate, Me.ActivityActivity, Me.AUserName})
        Me.grdActivity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdActivity.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdActivity.Location = New System.Drawing.Point(3, 18)
        Me.grdActivity.Name = "grdActivity"
        Me.grdActivity.ReadOnly = True
        Me.grdActivity.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grdActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdActivity.Size = New System.Drawing.Size(553, 143)
        Me.grdActivity.TabIndex = 34
        '
        'ANo
        '
        Me.ANo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.ANo.HeaderText = "No"
        Me.ANo.Name = "ANo"
        Me.ANo.ReadOnly = True
        Me.ANo.Visible = False
        '
        'ActivityDate
        '
        Me.ActivityDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ActivityDate.HeaderText = "Date"
        Me.ActivityDate.Name = "ActivityDate"
        Me.ActivityDate.ReadOnly = True
        Me.ActivityDate.Width = 58
        '
        'ActivityActivity
        '
        Me.ActivityActivity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ActivityActivity.DefaultCellStyle = DataGridViewCellStyle1
        Me.ActivityActivity.HeaderText = "Activity"
        Me.ActivityActivity.Name = "ActivityActivity"
        Me.ActivityActivity.ReadOnly = True
        '
        'AUserName
        '
        Me.AUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AUserName.HeaderText = "User"
        Me.AUserName.Name = "AUserName"
        Me.AUserName.ReadOnly = True
        Me.AUserName.Width = 57
        '
        'ControlActivityInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpActivity)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlActivityInfo"
        Me.Size = New System.Drawing.Size(559, 164)
        Me.grpActivity.ResumeLayout(False)
        CType(Me.grdActivity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpActivity As GroupBox
    Friend WithEvents grdActivity As DataGridView
    Friend WithEvents ANo As DataGridViewTextBoxColumn
    Friend WithEvents ActivityDate As DataGridViewTextBoxColumn
    Friend WithEvents ActivityActivity As DataGridViewTextBoxColumn
    Friend WithEvents AUserName As DataGridViewTextBoxColumn
End Class
