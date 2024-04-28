<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlRepairDeliverInfo
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
        Me.boxRepair = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtRepDate = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtRepPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.boxDeliver = New System.Windows.Forms.GroupBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtDPaidPrice = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtDDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDNo = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.boxRepair.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.boxDeliver.SuspendLayout()
        Me.SuspendLayout()
        '
        'boxRepair
        '
        Me.boxRepair.Controls.Add(Me.Label35)
        Me.boxRepair.Controls.Add(Me.txtRepDate)
        Me.boxRepair.Controls.Add(Me.Label27)
        Me.boxRepair.Controls.Add(Me.txtRepPrice)
        Me.boxRepair.Controls.Add(Me.Label3)
        Me.boxRepair.Dock = System.Windows.Forms.DockStyle.Fill
        Me.boxRepair.Location = New System.Drawing.Point(3, 3)
        Me.boxRepair.Name = "boxRepair"
        Me.boxRepair.Size = New System.Drawing.Size(272, 83)
        Me.boxRepair.TabIndex = 36
        Me.boxRepair.TabStop = False
        Me.boxRepair.Text = "Repair Info"
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label35.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label35.Location = New System.Drawing.Point(59, 21)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(24, 22)
        Me.Label35.TabIndex = 78
        Me.Label35.Text = "Rs."
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRepDate
        '
        Me.txtRepDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
        Me.txtRepDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtRepDate.Location = New System.Drawing.Point(100, 49)
        Me.txtRepDate.Name = "txtRepDate"
        Me.txtRepDate.Size = New System.Drawing.Size(162, 22)
        Me.txtRepDate.TabIndex = 29
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(5, 51)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(89, 14)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Repaired Date:"
        '
        'txtRepPrice
        '
        Me.txtRepPrice.Location = New System.Drawing.Point(84, 21)
        Me.txtRepPrice.Name = "txtRepPrice"
        Me.txtRepPrice.Size = New System.Drawing.Size(73, 22)
        Me.txtRepPrice.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Charge:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.boxDeliver, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.boxRepair, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(557, 89)
        Me.TableLayoutPanel1.TabIndex = 37
        '
        'boxDeliver
        '
        Me.boxDeliver.BackColor = System.Drawing.SystemColors.Control
        Me.boxDeliver.Controls.Add(Me.Label33)
        Me.boxDeliver.Controls.Add(Me.txtDPaidPrice)
        Me.boxDeliver.Controls.Add(Me.Label21)
        Me.boxDeliver.Controls.Add(Me.txtDDate)
        Me.boxDeliver.Controls.Add(Me.txtDNo)
        Me.boxDeliver.Controls.Add(Me.Label31)
        Me.boxDeliver.Dock = System.Windows.Forms.DockStyle.Fill
        Me.boxDeliver.Location = New System.Drawing.Point(281, 3)
        Me.boxDeliver.Name = "boxDeliver"
        Me.boxDeliver.Size = New System.Drawing.Size(273, 83)
        Me.boxDeliver.TabIndex = 61
        Me.boxDeliver.TabStop = False
        Me.boxDeliver.Text = "Delivered Info"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label33.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label33.Location = New System.Drawing.Point(79, 49)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(24, 22)
        Me.Label33.TabIndex = 78
        Me.Label33.Text = "Rs."
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDPaidPrice
        '
        Me.txtDPaidPrice.Enabled = False
        Me.txtDPaidPrice.Location = New System.Drawing.Point(104, 49)
        Me.txtDPaidPrice.Name = "txtDPaidPrice"
        Me.txtDPaidPrice.Size = New System.Drawing.Size(89, 22)
        Me.txtDPaidPrice.TabIndex = 31
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 52)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 14)
        Me.Label21.TabIndex = 74
        Me.Label21.Text = "Paid Price:"
        '
        'txtDDate
        '
        Me.txtDDate.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
        Me.txtDDate.Enabled = False
        Me.txtDDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDDate.Location = New System.Drawing.Point(104, 21)
        Me.txtDDate.Name = "txtDDate"
        Me.txtDDate.Size = New System.Drawing.Size(163, 22)
        Me.txtDDate.TabIndex = 30
        '
        'txtDNo
        '
        Me.txtDNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDNo.Enabled = False
        Me.txtDNo.Location = New System.Drawing.Point(214, 51)
        Me.txtDNo.Name = "txtDNo"
        Me.txtDNo.Size = New System.Drawing.Size(53, 22)
        Me.txtDNo.TabIndex = 7
        Me.txtDNo.Visible = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 25)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(92, 14)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "Delivered Date:"
        '
        'ControlRepairPrice_DateInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ControlRepairPrice_DateInfo"
        Me.Size = New System.Drawing.Size(557, 89)
        Me.boxRepair.ResumeLayout(False)
        Me.boxRepair.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.boxDeliver.ResumeLayout(False)
        Me.boxDeliver.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents boxRepair As GroupBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtRepDate As DateTimePicker
    Friend WithEvents Label27 As Label
    Friend WithEvents txtRepPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents boxDeliver As GroupBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtDPaidPrice As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtDDate As DateTimePicker
    Friend WithEvents txtDNo As TextBox
    Friend WithEvents Label31 As Label
End Class
