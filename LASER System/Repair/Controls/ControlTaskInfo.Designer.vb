<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlTaskInfo
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
        Me.grpRepTask = New System.Windows.Forms.GroupBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.grdRepTask = New System.Windows.Forms.DataGridView()
        Me.TaskTNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskAction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpRepTask.SuspendLayout()
        CType(Me.grdRepTask, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpRepTask
        '
        Me.grpRepTask.Controls.Add(Me.BtnAdd)
        Me.grpRepTask.Controls.Add(Me.grdRepTask)
        Me.grpRepTask.Cursor = System.Windows.Forms.Cursors.Default
        Me.grpRepTask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpRepTask.Location = New System.Drawing.Point(0, 0)
        Me.grpRepTask.Name = "grpRepTask"
        Me.grpRepTask.Size = New System.Drawing.Size(612, 144)
        Me.grpRepTask.TabIndex = 82
        Me.grpRepTask.TabStop = False
        Me.grpRepTask.Text = "Task Info"
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.Image = Global.LASER_System.My.Resources.Resources.add
        Me.BtnAdd.Location = New System.Drawing.Point(546, 15)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(60, 26)
        Me.BtnAdd.TabIndex = 34
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'grdRepTask
        '
        Me.grdRepTask.AllowUserToAddRows = False
        Me.grdRepTask.AllowUserToDeleteRows = False
        Me.grdRepTask.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRepTask.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdRepTask.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdRepTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRepTask.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TaskTNo, Me.TaskDate, Me.TaskAction, Me.TaskRemarks, Me.TStatus})
        Me.grdRepTask.Location = New System.Drawing.Point(3, 15)
        Me.grdRepTask.Name = "grdRepTask"
        Me.grdRepTask.ReadOnly = True
        Me.grdRepTask.Size = New System.Drawing.Size(537, 126)
        Me.grdRepTask.TabIndex = 33
        '
        'TaskTNo
        '
        Me.TaskTNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.TaskTNo.DataPropertyName = "MsgNo"
        Me.TaskTNo.HeaderText = "Task No"
        Me.TaskTNo.Name = "TaskTNo"
        Me.TaskTNo.ReadOnly = True
        Me.TaskTNo.Visible = False
        '
        'TaskDate
        '
        Me.TaskDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TaskDate.DataPropertyName = "MsgDate"
        Me.TaskDate.HeaderText = "Date"
        Me.TaskDate.Name = "TaskDate"
        Me.TaskDate.ReadOnly = True
        Me.TaskDate.Width = 58
        '
        'TaskAction
        '
        Me.TaskAction.DataPropertyName = "ACTION"
        Me.TaskAction.HeaderText = "Action"
        Me.TaskAction.Name = "TaskAction"
        Me.TaskAction.ReadOnly = True
        Me.TaskAction.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'TaskRemarks
        '
        Me.TaskRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TaskRemarks.DataPropertyName = "MESSAGE"
        Me.TaskRemarks.HeaderText = "Message"
        Me.TaskRemarks.Name = "TaskRemarks"
        Me.TaskRemarks.ReadOnly = True
        '
        'TStatus
        '
        Me.TStatus.DataPropertyName = "STATUS"
        Me.TStatus.HeaderText = "Status"
        Me.TStatus.Name = "TStatus"
        Me.TStatus.ReadOnly = True
        '
        'ControlTaskInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpRepTask)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlTaskInfo"
        Me.Size = New System.Drawing.Size(612, 144)
        Me.grpRepTask.ResumeLayout(False)
        CType(Me.grdRepTask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpRepTask As GroupBox
    Friend WithEvents grdRepTask As DataGridView
    Friend WithEvents TaskTNo As DataGridViewTextBoxColumn
    Friend WithEvents TaskDate As DataGridViewTextBoxColumn
    Friend WithEvents TaskAction As DataGridViewTextBoxColumn
    Friend WithEvents TaskRemarks As DataGridViewTextBoxColumn
    Friend WithEvents TStatus As DataGridViewTextBoxColumn
    Friend WithEvents BtnAdd As Button
End Class
