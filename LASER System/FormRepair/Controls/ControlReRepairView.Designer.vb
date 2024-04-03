<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlReRepairView
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GridReRepairView = New System.Windows.Forms.DataGridView()
        Me.RetNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridReRepairView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridReRepairView)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ReRepair View"
        '
        'GridReRepairView
        '
        Me.GridReRepairView.AllowUserToAddRows = False
        Me.GridReRepairView.AllowUserToDeleteRows = False
        Me.GridReRepairView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridReRepairView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RetNo, Me.Status})
        Me.GridReRepairView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridReRepairView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridReRepairView.Location = New System.Drawing.Point(3, 18)
        Me.GridReRepairView.Name = "GridReRepairView"
        Me.GridReRepairView.Size = New System.Drawing.Size(445, 142)
        Me.GridReRepairView.TabIndex = 0
        '
        'RetNo
        '
        Me.RetNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RetNo.DataPropertyName = "RetNo"
        Me.RetNo.HeaderText = "ReRepair No"
        Me.RetNo.Name = "RetNo"
        Me.RetNo.ReadOnly = True
        '
        'Status
        '
        Me.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 66
        '
        'ControlReRepairView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlReRepairView"
        Me.Size = New System.Drawing.Size(451, 163)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridReRepairView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GridReRepairView As DataGridView
    Friend WithEvents RetNo As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
End Class
