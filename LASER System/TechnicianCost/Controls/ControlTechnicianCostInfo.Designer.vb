﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlTechnicianCostInfo
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlTechnicianCostInfo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PickerDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextRemarks = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ControlStockSelection = New LASER_System.ControlStockSelection()
        Me.ControlRepairReRepairSelection = New LASER_System.ControlRepairReRepairSelection()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextRate = New System.Windows.Forms.NumericUpDown()
        Me.TextQty = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextTotal = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextStockNo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TextRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextStockNo)
        Me.GroupBox1.Controls.Add(Me.TextTotal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextQty)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextRate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.ButtonDelete)
        Me.GroupBox1.Controls.Add(Me.ButtonClose)
        Me.GroupBox1.Controls.Add(Me.TextRemarks)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.PickerDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(163, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 414)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Technician Cost Info"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ControlStockSelection)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 77)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(304, 88)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stock Info"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ControlRepairReRepairSelection)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 171)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(304, 84)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Repair Info"
        '
        'PickerDate
        '
        Me.PickerDate.Location = New System.Drawing.Point(95, 21)
        Me.PickerDate.Name = "PickerDate"
        Me.PickerDate.Size = New System.Drawing.Size(218, 22)
        Me.PickerDate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 14)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Remarks:"
        '
        'TextRemarks
        '
        Me.TextRemarks.Location = New System.Drawing.Point(6, 303)
        Me.TextRemarks.Multiline = True
        Me.TextRemarks.Name = "TextRemarks"
        Me.TextRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextRemarks.Size = New System.Drawing.Size(306, 65)
        Me.TextRemarks.TabIndex = 8
        '
        'ButtonSave
        '
        Me.ButtonSave.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.Location = New System.Drawing.Point(68, 373)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(86, 34)
        Me.ButtonSave.TabIndex = 32
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ButtonDelete.Image = CType(resources.GetObject("ButtonDelete.Image"), System.Drawing.Image)
        Me.ButtonDelete.Location = New System.Drawing.Point(158, 373)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(84, 34)
        Me.ButtonDelete.TabIndex = 33
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.Location = New System.Drawing.Point(246, 373)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(73, 34)
        Me.ButtonClose.TabIndex = 34
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 420.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(650, 543)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'ControlStockSelection
        '
        Me.ControlStockSelection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlStockSelection.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.ControlStockSelection.Location = New System.Drawing.Point(6, 21)
        Me.ControlStockSelection.MaximumSize = New System.Drawing.Size(0, 60)
        Me.ControlStockSelection.MinimumSize = New System.Drawing.Size(200, 60)
        Me.ControlStockSelection.Name = "ControlStockSelection"
        Me.ControlStockSelection.Size = New System.Drawing.Size(292, 60)
        Me.ControlStockSelection.TabIndex = 0
        '
        'ControlRepairReRepairSelection
        '
        Me.ControlRepairReRepairSelection.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.ControlRepairReRepairSelection.Location = New System.Drawing.Point(6, 21)
        Me.ControlRepairReRepairSelection.MaximumSize = New System.Drawing.Size(0, 57)
        Me.ControlRepairReRepairSelection.MinimumSize = New System.Drawing.Size(197, 57)
        Me.ControlRepairReRepairSelection.Name = "ControlRepairReRepairSelection"
        Me.ControlRepairReRepairSelection.Size = New System.Drawing.Size(197, 57)
        Me.ControlRepairReRepairSelection.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 14)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Rate:"
        '
        'TextRate
        '
        Me.TextRate.Location = New System.Drawing.Point(49, 261)
        Me.TextRate.Name = "TextRate"
        Me.TextRate.Size = New System.Drawing.Size(72, 22)
        Me.TextRate.TabIndex = 36
        '
        'TextQty
        '
        Me.TextQty.Location = New System.Drawing.Point(158, 261)
        Me.TextQty.Name = "TextQty"
        Me.TextQty.Size = New System.Drawing.Size(37, 22)
        Me.TextQty.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(125, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 14)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Qty:"
        '
        'TextTotal
        '
        Me.TextTotal.Location = New System.Drawing.Point(244, 261)
        Me.TextTotal.Name = "TextTotal"
        Me.TextTotal.Size = New System.Drawing.Size(68, 22)
        Me.TextTotal.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(201, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 14)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Total:"
        '
        'TextStockNo
        '
        Me.TextStockNo.Enabled = False
        Me.TextStockNo.Location = New System.Drawing.Point(6, 385)
        Me.TextStockNo.Name = "TextStockNo"
        Me.TextStockNo.Size = New System.Drawing.Size(57, 22)
        Me.TextStockNo.TabIndex = 41
        '
        'ControlTechnicianCostInfo
        '
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlTechnicianCostInfo"
        Me.Size = New System.Drawing.Size(650, 543)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.TextRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PickerDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents ControlRepairReRepairSelection As ControlRepairReRepairSelection
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ControlStockSelection As ControlStockSelection
    Friend WithEvents TextRemarks As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextTotal As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents TextQty As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents TextRate As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents TextStockNo As TextBox
End Class