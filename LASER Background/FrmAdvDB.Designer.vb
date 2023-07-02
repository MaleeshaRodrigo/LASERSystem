<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdvDB
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GridOnline = New System.Windows.Forms.DataGridView()
        Me.CmbOTable = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GridLocal = New System.Windows.Forms.DataGridView()
        Me.CmbTable = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridOnlineDB = New System.Windows.Forms.DataGridView()
        Me.TxtCommand = New System.Windows.Forms.TextBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnTurnUpdate = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GridOnline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GridLocal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridOnlineDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(958, 315)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GridOnline)
        Me.Panel2.Controls.Add(Me.CmbOTable)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(482, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(473, 309)
        Me.Panel2.TabIndex = 1
        '
        'GridOnline
        '
        Me.GridOnline.AllowUserToAddRows = False
        Me.GridOnline.AllowUserToDeleteRows = False
        Me.GridOnline.AllowUserToOrderColumns = True
        Me.GridOnline.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridOnline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridOnline.Location = New System.Drawing.Point(3, 57)
        Me.GridOnline.Name = "GridOnline"
        Me.GridOnline.ReadOnly = True
        Me.GridOnline.Size = New System.Drawing.Size(467, 252)
        Me.GridOnline.TabIndex = 7
        '
        'CmbOTable
        '
        Me.CmbOTable.FormattingEnabled = True
        Me.CmbOTable.Location = New System.Drawing.Point(97, 27)
        Me.CmbOTable.Name = "CmbOTable"
        Me.CmbOTable.Size = New System.Drawing.Size(188, 21)
        Me.CmbOTable.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Table Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Online Database"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GridLocal)
        Me.Panel1.Controls.Add(Me.CmbTable)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(473, 309)
        Me.Panel1.TabIndex = 0
        '
        'GridLocal
        '
        Me.GridLocal.AllowUserToAddRows = False
        Me.GridLocal.AllowUserToDeleteRows = False
        Me.GridLocal.AllowUserToOrderColumns = True
        Me.GridLocal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridLocal.Location = New System.Drawing.Point(8, 57)
        Me.GridLocal.Name = "GridLocal"
        Me.GridLocal.ReadOnly = True
        Me.GridLocal.Size = New System.Drawing.Size(465, 250)
        Me.GridLocal.TabIndex = 6
        '
        'CmbTable
        '
        Me.CmbTable.FormattingEnabled = True
        Me.CmbTable.Location = New System.Drawing.Point(99, 30)
        Me.CmbTable.Name = "CmbTable"
        Me.CmbTable.Size = New System.Drawing.Size(169, 21)
        Me.CmbTable.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Table Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Local Database"
        '
        'GridOnlineDB
        '
        Me.GridOnlineDB.AllowUserToAddRows = False
        Me.GridOnlineDB.AllowUserToDeleteRows = False
        Me.GridOnlineDB.AllowUserToOrderColumns = True
        Me.GridOnlineDB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridOnlineDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridOnlineDB.Location = New System.Drawing.Point(12, 330)
        Me.GridOnlineDB.MultiSelect = False
        Me.GridOnlineDB.Name = "GridOnlineDB"
        Me.GridOnlineDB.ReadOnly = True
        Me.GridOnlineDB.Size = New System.Drawing.Size(958, 89)
        Me.GridOnlineDB.TabIndex = 1
        '
        'TxtCommand
        '
        Me.TxtCommand.Location = New System.Drawing.Point(67, 10)
        Me.TxtCommand.Multiline = True
        Me.TxtCommand.Name = "TxtCommand"
        Me.TxtCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtCommand.Size = New System.Drawing.Size(816, 63)
        Me.TxtCommand.TabIndex = 2
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(889, 10)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(81, 24)
        Me.BtnUpdate.TabIndex = 3
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Command"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnTurnUpdate)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.TxtCommand)
        Me.Panel3.Controls.Add(Me.BtnUpdate)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 425)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(984, 85)
        Me.Panel3.TabIndex = 6
        '
        'BtnTurnUpdate
        '
        Me.BtnTurnUpdate.Location = New System.Drawing.Point(889, 33)
        Me.BtnTurnUpdate.Name = "BtnTurnUpdate"
        Me.BtnTurnUpdate.Size = New System.Drawing.Size(83, 40)
        Me.BtnTurnUpdate.TabIndex = 6
        Me.BtnTurnUpdate.Text = "Turn to UPDATE SQL"
        Me.BtnTurnUpdate.UseVisualStyleBackColor = True
        '
        'FrmAdvDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 510)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GridOnlineDB)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmAdvDB"
        Me.Text = "Advanced Database - LASER Background Worker"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GridOnline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridLocal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridOnlineDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbOTable As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbTable As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GridOnline As DataGridView
    Friend WithEvents GridLocal As DataGridView
    Friend WithEvents GridOnlineDB As DataGridView
    Friend WithEvents TxtCommand As TextBox
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnTurnUpdate As Button
End Class
