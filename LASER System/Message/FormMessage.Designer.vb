<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMessage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMessage))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tabMsg = New System.Windows.Forms.TabPage()
        Me.txtPhoneNo = New System.Windows.Forms.MaskedTextBox()
        Me.txtMsgNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbField = New System.Windows.Forms.ComboBox()
        Me.cmbRepNo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdMSend = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabMsgHistory = New System.Windows.Forms.TabPage()
        Me.grdMsgHistory = New System.Windows.Forms.DataGridView()
        Me.MsgNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MsgDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MsgAction = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.RepNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RETNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuTElNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BMsgMessage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabRepTask = New System.Windows.Forms.TabPage()
        Me.grdRepairTask = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepTaskCuName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepTaskPCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepTaskPName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepTaskStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdRepTaskOption = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.bgworker = New System.ComponentModel.BackgroundWorker()
        Me.TabControl.SuspendLayout()
        Me.tabMsg.SuspendLayout()
        Me.tabMsgHistory.SuspendLayout()
        CType(Me.grdMsgHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRepTask.SuspendLayout()
        CType(Me.grdRepairTask, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.tabMsg)
        Me.TabControl.Controls.Add(Me.tabMsgHistory)
        Me.TabControl.Controls.Add(Me.tabRepTask)
        Me.TabControl.Location = New System.Drawing.Point(12, 27)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(718, 385)
        Me.TabControl.TabIndex = 7
        '
        'tabMsg
        '
        Me.tabMsg.Controls.Add(Me.txtPhoneNo)
        Me.tabMsg.Controls.Add(Me.txtMsgNo)
        Me.tabMsg.Controls.Add(Me.Label4)
        Me.tabMsg.Controls.Add(Me.cmbField)
        Me.tabMsg.Controls.Add(Me.cmbRepNo)
        Me.tabMsg.Controls.Add(Me.Label3)
        Me.tabMsg.Controls.Add(Me.cmdMSend)
        Me.tabMsg.Controls.Add(Me.txtMessage)
        Me.tabMsg.Controls.Add(Me.Label2)
        Me.tabMsg.Controls.Add(Me.Label1)
        Me.tabMsg.Location = New System.Drawing.Point(4, 26)
        Me.tabMsg.Name = "tabMsg"
        Me.tabMsg.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMsg.Size = New System.Drawing.Size(710, 355)
        Me.tabMsg.TabIndex = 0
        Me.tabMsg.Text = "Message"
        Me.tabMsg.UseVisualStyleBackColor = True
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Location = New System.Drawing.Point(89, 58)
        Me.txtPhoneNo.Mask = "\94000000000"
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(78, 24)
        Me.txtPhoneNo.TabIndex = 20
        '
        'txtMsgNo
        '
        Me.txtMsgNo.Enabled = False
        Me.txtMsgNo.Location = New System.Drawing.Point(79, 6)
        Me.txtMsgNo.Name = "txtMsgNo"
        Me.txtMsgNo.Size = New System.Drawing.Size(54, 24)
        Me.txtMsgNo.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Message No:"
        '
        'cmbField
        '
        Me.cmbField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbField.FormattingEnabled = True
        Me.cmbField.Items.AddRange(New Object() {"Repair", "RERepair"})
        Me.cmbField.Location = New System.Drawing.Point(6, 33)
        Me.cmbField.Name = "cmbField"
        Me.cmbField.Size = New System.Drawing.Size(98, 25)
        Me.cmbField.TabIndex = 17
        '
        'cmbRepNo
        '
        Me.cmbRepNo.FormattingEnabled = True
        Me.cmbRepNo.Location = New System.Drawing.Point(139, 33)
        Me.cmbRepNo.Name = "cmbRepNo"
        Me.cmbRepNo.Size = New System.Drawing.Size(86, 25)
        Me.cmbRepNo.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "No:"
        '
        'cmdMSend
        '
        Me.cmdMSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdMSend.Location = New System.Drawing.Point(631, 322)
        Me.cmdMSend.Name = "cmdMSend"
        Me.cmdMSend.Size = New System.Drawing.Size(73, 31)
        Me.cmdMSend.TabIndex = 11
        Me.cmdMSend.Text = "Send"
        Me.cmdMSend.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMessage.Location = New System.Drawing.Point(64, 85)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessage.Size = New System.Drawing.Size(640, 231)
        Me.txtMessage.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Message:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Phone Number:"
        '
        'tabMsgHistory
        '
        Me.tabMsgHistory.Controls.Add(Me.grdMsgHistory)
        Me.tabMsgHistory.Location = New System.Drawing.Point(4, 26)
        Me.tabMsgHistory.Name = "tabMsgHistory"
        Me.tabMsgHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMsgHistory.Size = New System.Drawing.Size(710, 355)
        Me.tabMsgHistory.TabIndex = 1
        Me.tabMsgHistory.Text = "Message History"
        Me.tabMsgHistory.UseVisualStyleBackColor = True
        '
        'grdMsgHistory
        '
        Me.grdMsgHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdMsgHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdMsgHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdMsgHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMsgHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MsgNo, Me.MsgDate, Me.MsgAction, Me.RepNo, Me.RETNO, Me.CuTElNo1, Me.BMsgMessage, Me.Status})
        Me.grdMsgHistory.Location = New System.Drawing.Point(3, 6)
        Me.grdMsgHistory.Name = "grdMsgHistory"
        Me.grdMsgHistory.RowHeadersWidth = 51
        Me.grdMsgHistory.Size = New System.Drawing.Size(704, 266)
        Me.grdMsgHistory.TabIndex = 19
        '
        'MsgNo
        '
        Me.MsgNo.DataPropertyName = "MsgNo"
        Me.MsgNo.HeaderText = "Message No"
        Me.MsgNo.MinimumWidth = 6
        Me.MsgNo.Name = "MsgNo"
        Me.MsgNo.Width = 98
        '
        'MsgDate
        '
        Me.MsgDate.DataPropertyName = "MsgDate"
        Me.MsgDate.HeaderText = "Date"
        Me.MsgDate.MinimumWidth = 6
        Me.MsgDate.Name = "MsgDate"
        Me.MsgDate.Width = 65
        '
        'MsgAction
        '
        Me.MsgAction.DataPropertyName = "Action"
        Me.MsgAction.HeaderText = "Action"
        Me.MsgAction.Items.AddRange(New Object() {"SMS", "Call"})
        Me.MsgAction.MinimumWidth = 6
        Me.MsgAction.Name = "MsgAction"
        Me.MsgAction.Width = 50
        '
        'RepNo
        '
        Me.RepNo.DataPropertyName = "RepNo"
        Me.RepNo.HeaderText = "Repair No"
        Me.RepNo.MinimumWidth = 6
        Me.RepNo.Name = "RepNo"
        Me.RepNo.Width = 86
        '
        'RETNO
        '
        Me.RETNO.DataPropertyName = "RETNo"
        Me.RETNO.HeaderText = "RERepair No"
        Me.RETNO.MinimumWidth = 6
        Me.RETNO.Name = "RETNO"
        '
        'CuTElNo1
        '
        Me.CuTElNo1.DataPropertyName = "CuTelNo1"
        Me.CuTElNo1.HeaderText = "Customer Telephone No1"
        Me.CuTElNo1.MinimumWidth = 6
        Me.CuTElNo1.Name = "CuTElNo1"
        Me.CuTElNo1.Width = 142
        '
        'BMsgMessage
        '
        Me.BMsgMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BMsgMessage.DataPropertyName = "Message"
        Me.BMsgMessage.HeaderText = "Message "
        Me.BMsgMessage.MinimumWidth = 6
        Me.BMsgMessage.Name = "BMsgMessage"
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 6
        Me.Status.Name = "Status"
        Me.Status.Width = 72
        '
        'tabRepTask
        '
        Me.tabRepTask.Controls.Add(Me.grdRepairTask)
        Me.tabRepTask.Location = New System.Drawing.Point(4, 26)
        Me.tabRepTask.Name = "tabRepTask"
        Me.tabRepTask.Size = New System.Drawing.Size(710, 355)
        Me.tabRepTask.TabIndex = 2
        Me.tabRepTask.Text = "Repair Task"
        Me.tabRepTask.UseVisualStyleBackColor = True
        '
        'grdRepairTask
        '
        Me.grdRepairTask.AllowUserToDeleteRows = False
        Me.grdRepairTask.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRepairTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdRepairTask.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdRepairTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRepairTask.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.RepTaskCuName, Me.DataGridViewTextBoxColumn5, Me.RepTaskPCategory, Me.RepTaskPName, Me.RepTaskStatus, Me.DataGridViewComboBoxColumn1, Me.DataGridViewTextBoxColumn6, Me.grdRepTaskOption})
        Me.grdRepairTask.Location = New System.Drawing.Point(3, 3)
        Me.grdRepairTask.Name = "grdRepairTask"
        Me.grdRepairTask.RowHeadersWidth = 51
        Me.grdRepairTask.Size = New System.Drawing.Size(704, 306)
        Me.grdRepairTask.TabIndex = 21
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RETNo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "RERepair No"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RepNo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Repair No"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 86
        '
        'RepTaskCuName
        '
        Me.RepTaskCuName.HeaderText = "Customer Name"
        Me.RepTaskCuName.MinimumWidth = 6
        Me.RepTaskCuName.Name = "RepTaskCuName"
        Me.RepTaskCuName.ReadOnly = True
        Me.RepTaskCuName.Width = 118
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CuTelNo"
        DataGridViewCellStyle1.Format = "\94000000000"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn5.HeaderText = "Customer Telephone No"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 142
        '
        'RepTaskPCategory
        '
        Me.RepTaskPCategory.HeaderText = "Product Category"
        Me.RepTaskPCategory.MinimumWidth = 6
        Me.RepTaskPCategory.Name = "RepTaskPCategory"
        Me.RepTaskPCategory.ReadOnly = True
        Me.RepTaskPCategory.Width = 124
        '
        'RepTaskPName
        '
        Me.RepTaskPName.HeaderText = "Product Name"
        Me.RepTaskPName.MinimumWidth = 6
        Me.RepTaskPName.Name = "RepTaskPName"
        Me.RepTaskPName.Width = 109
        '
        'RepTaskStatus
        '
        Me.RepTaskStatus.HeaderText = "Status"
        Me.RepTaskStatus.MinimumWidth = 6
        Me.RepTaskStatus.Name = "RepTaskStatus"
        Me.RepTaskStatus.ReadOnly = True
        Me.RepTaskStatus.Width = 72
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.DataPropertyName = "Action"
        Me.DataGridViewComboBoxColumn1.HeaderText = "Action"
        Me.DataGridViewComboBoxColumn1.Items.AddRange(New Object() {"SMS", "Call"})
        Me.DataGridViewComboBoxColumn1.MinimumWidth = 6
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Message"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Message "
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'grdRepTaskOption
        '
        Me.grdRepTaskOption.HeaderText = "Option"
        Me.grdRepTaskOption.MinimumWidth = 6
        Me.grdRepTaskOption.Name = "grdRepTaskOption"
        Me.grdRepTaskOption.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdRepTaskOption.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.grdRepTaskOption.Text = "Send"
        Me.grdRepTaskOption.UseColumnTextForButtonValue = True
        Me.grdRepTaskOption.Width = 75
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(742, 24)
        Me.MenuStrip.TabIndex = 29
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'bgworker
        '
        Me.bgworker.WorkerReportsProgress = True
        Me.bgworker.WorkerSupportsCancellation = True
        '
        'FormMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 413)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.TabControl)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LASER System - Message Center "
        Me.TabControl.ResumeLayout(False)
        Me.tabMsg.ResumeLayout(False)
        Me.tabMsg.PerformLayout()
        Me.tabMsgHistory.ResumeLayout(False)
        CType(Me.grdMsgHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRepTask.ResumeLayout(False)
        CType(Me.grdRepairTask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabMsg As System.Windows.Forms.TabPage
    Friend WithEvents cmdMSend As System.Windows.Forms.Button
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabMsgHistory As System.Windows.Forms.TabPage
    Friend WithEvents grdMsgHistory As System.Windows.Forms.DataGridView
    Friend WithEvents cmbRepNo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbField As ComboBox
    Friend WithEvents txtMsgNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MsgNo As DataGridViewTextBoxColumn
    Friend WithEvents MsgDate As DataGridViewTextBoxColumn
    Friend WithEvents MsgAction As DataGridViewComboBoxColumn
    Friend WithEvents RepNo As DataGridViewTextBoxColumn
    Friend WithEvents RETNO As DataGridViewTextBoxColumn
    Friend WithEvents CuTElNo1 As DataGridViewTextBoxColumn
    Friend WithEvents BMsgMessage As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents tabRepTask As TabPage
    Friend WithEvents grdRepairTask As DataGridView
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents txtPhoneNo As MaskedTextBox
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents RepTaskCuName As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents RepTaskPCategory As DataGridViewTextBoxColumn
    Friend WithEvents RepTaskPName As DataGridViewTextBoxColumn
    Friend WithEvents RepTaskStatus As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents grdRepTaskOption As DataGridViewButtonColumn
    Friend WithEvents bgworker As System.ComponentModel.BackgroundWorker
End Class
