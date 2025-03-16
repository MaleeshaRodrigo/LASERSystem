<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlRepairDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelAssignedTo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.LabelReceived = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LabelReturned = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LabelRepaired = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelPending = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelHandedOverTo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GridTechnicianOverall = New System.Windows.Forms.DataGridView()
        Me.TimerRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.Technician = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignedTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HandedOverTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pending = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Repaired = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Returned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridTechnicianOverall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelAssignedTo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(112, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(103, 114)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LabelAssignedTo
        '
        Me.LabelAssignedTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelAssignedTo.Font = New System.Drawing.Font("Calibri", 25.0!, System.Drawing.FontStyle.Bold)
        Me.LabelAssignedTo.Location = New System.Drawing.Point(3, 63)
        Me.LabelAssignedTo.Name = "LabelAssignedTo"
        Me.LabelAssignedTo.Size = New System.Drawing.Size(97, 48)
        Me.LabelAssignedTo.TabIndex = 1
        Me.LabelAssignedTo.Text = "___"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Assigned To Technician"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox5, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(660, 120)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.LabelReceived)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(103, 114)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        '
        'LabelReceived
        '
        Me.LabelReceived.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelReceived.Font = New System.Drawing.Font("Calibri", 25.0!, System.Drawing.FontStyle.Bold)
        Me.LabelReceived.Location = New System.Drawing.Point(3, 63)
        Me.LabelReceived.Name = "LabelReceived"
        Me.LabelReceived.Size = New System.Drawing.Size(97, 48)
        Me.LabelReceived.TabIndex = 1
        Me.LabelReceived.Text = "___"
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label12.Location = New System.Drawing.Point(3, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 45)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Received"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LabelReturned)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(548, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(109, 114)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        '
        'LabelReturned
        '
        Me.LabelReturned.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelReturned.Font = New System.Drawing.Font("Calibri", 25.0!, System.Drawing.FontStyle.Bold)
        Me.LabelReturned.Location = New System.Drawing.Point(3, 63)
        Me.LabelReturned.Name = "LabelReturned"
        Me.LabelReturned.Size = New System.Drawing.Size(103, 48)
        Me.LabelReturned.TabIndex = 1
        Me.LabelReturned.Text = "___"
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label10.Location = New System.Drawing.Point(3, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 45)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Returned Undelivered"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LabelRepaired)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(439, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(103, 114)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'LabelRepaired
        '
        Me.LabelRepaired.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelRepaired.Font = New System.Drawing.Font("Calibri", 25.0!, System.Drawing.FontStyle.Bold)
        Me.LabelRepaired.Location = New System.Drawing.Point(3, 63)
        Me.LabelRepaired.Name = "LabelRepaired"
        Me.LabelRepaired.Size = New System.Drawing.Size(97, 48)
        Me.LabelRepaired.TabIndex = 1
        Me.LabelRepaired.Text = "___"
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label8.Location = New System.Drawing.Point(3, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 45)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = RepairStatus.Repaired
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelPending)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(330, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(103, 114)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'LabelPending
        '
        Me.LabelPending.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelPending.Font = New System.Drawing.Font("Calibri", 25.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPending.Location = New System.Drawing.Point(3, 63)
        Me.LabelPending.Name = "LabelPending"
        Me.LabelPending.Size = New System.Drawing.Size(97, 48)
        Me.LabelPending.TabIndex = 1
        Me.LabelPending.Text = "___"
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label6.Location = New System.Drawing.Point(3, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 45)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Pending"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelHandedOverTo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(221, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(103, 114)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'LabelHandedOverTo
        '
        Me.LabelHandedOverTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelHandedOverTo.Font = New System.Drawing.Font("Calibri", 25.0!, System.Drawing.FontStyle.Bold)
        Me.LabelHandedOverTo.Location = New System.Drawing.Point(3, 63)
        Me.LabelHandedOverTo.Name = "LabelHandedOverTo"
        Me.LabelHandedOverTo.Size = New System.Drawing.Size(97, 48)
        Me.LabelHandedOverTo.TabIndex = 1
        Me.LabelHandedOverTo.Text = "___"
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label4.Location = New System.Drawing.Point(3, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 45)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Handed Over To Technician"
        '
        'GridTechnicianOverall
        '
        Me.GridTechnicianOverall.AllowUserToAddRows = False
        Me.GridTechnicianOverall.AllowUserToDeleteRows = False
        Me.GridTechnicianOverall.AllowUserToOrderColumns = True
        Me.GridTechnicianOverall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridTechnicianOverall.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Technician, Me.AssignedTo, Me.HandedOverTo, Me.Pending, Me.Repaired, Me.Returned})
        Me.GridTechnicianOverall.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridTechnicianOverall.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridTechnicianOverall.Location = New System.Drawing.Point(0, 120)
        Me.GridTechnicianOverall.Name = "GridTechnicianOverall"
        Me.GridTechnicianOverall.ReadOnly = True
        Me.GridTechnicianOverall.RowHeadersVisible = False
        Me.GridTechnicianOverall.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GridTechnicianOverall.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridTechnicianOverall.Size = New System.Drawing.Size(660, 196)
        Me.GridTechnicianOverall.TabIndex = 2
        '
        'TimerRefresh
        '
        Me.TimerRefresh.Enabled = True
        Me.TimerRefresh.Interval = 60000
        '
        'Technician
        '
        Me.Technician.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Technician.DataPropertyName = "Technician"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Technician.DefaultCellStyle = DataGridViewCellStyle1
        Me.Technician.HeaderText = "Technician"
        Me.Technician.Name = "Technician"
        Me.Technician.ReadOnly = True
        '
        'AssignedTo
        '
        Me.AssignedTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AssignedTo.DataPropertyName = "AssignedTo"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.AssignedTo.DefaultCellStyle = DataGridViewCellStyle2
        Me.AssignedTo.HeaderText = "Assigned To"
        Me.AssignedTo.Name = "AssignedTo"
        Me.AssignedTo.ReadOnly = True
        Me.AssignedTo.Width = 97
        '
        'HandedOverTo
        '
        Me.HandedOverTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.HandedOverTo.DataPropertyName = "HandedOverTo"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.HandedOverTo.DefaultCellStyle = DataGridViewCellStyle3
        Me.HandedOverTo.HeaderText = "Handed Over To"
        Me.HandedOverTo.Name = "HandedOverTo"
        Me.HandedOverTo.ReadOnly = True
        Me.HandedOverTo.Width = 97
        '
        'Pending
        '
        Me.Pending.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Pending.DataPropertyName = "Pending"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Pending.DefaultCellStyle = DataGridViewCellStyle4
        Me.Pending.HeaderText = "Pending"
        Me.Pending.Name = "Pending"
        Me.Pending.ReadOnly = True
        Me.Pending.Width = 76
        '
        'Repaired
        '
        Me.Repaired.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Repaired.DataPropertyName = "Repaired"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Repaired.DefaultCellStyle = DataGridViewCellStyle5
        Me.Repaired.HeaderText = RepairStatus.Repaired
        Me.Repaired.Name = "Repaired"
        Me.Repaired.ReadOnly = True
        Me.Repaired.Width = 139
        '
        'Returned
        '
        Me.Returned.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Returned.DataPropertyName = "Returned"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Returned.DefaultCellStyle = DataGridViewCellStyle6
        Me.Returned.HeaderText = "Returned Undelivered"
        Me.Returned.Name = "Returned"
        Me.Returned.ReadOnly = True
        Me.Returned.Width = 139
        '
        'ControlRepairDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridTechnicianOverall)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.MinimumSize = New System.Drawing.Size(660, 0)
        Me.Name = "ControlRepairDashboard"
        Me.Size = New System.Drawing.Size(660, 316)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridTechnicianOverall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelAssignedTo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents LabelReturned As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LabelRepaired As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LabelPending As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelHandedOverTo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents LabelReceived As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GridTechnicianOverall As DataGridView
    Friend WithEvents TimerRefresh As Timer
    Friend WithEvents Technician As DataGridViewTextBoxColumn
    Friend WithEvents AssignedTo As DataGridViewTextBoxColumn
    Friend WithEvents HandedOverTo As DataGridViewTextBoxColumn
    Friend WithEvents Pending As DataGridViewTextBoxColumn
    Friend WithEvents Repaired As DataGridViewTextBoxColumn
    Friend WithEvents Returned As DataGridViewTextBoxColumn
End Class
