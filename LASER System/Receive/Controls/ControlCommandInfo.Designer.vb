<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlCommandInfo
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
        Me.grpComInfo = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSaveOnly = New System.Windows.Forms.Button()
        Me.cmdReceiptSticker = New System.Windows.Forms.Button()
        Me.cmdSticker = New System.Windows.Forms.Button()
        Me.cmdReceipt = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.grpComInfo.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpComInfo
        '
        Me.grpComInfo.Controls.Add(Me.cmdCancel)
        Me.grpComInfo.Controls.Add(Me.cmdSaveOnly)
        Me.grpComInfo.Controls.Add(Me.cmdReceiptSticker)
        Me.grpComInfo.Controls.Add(Me.cmdSticker)
        Me.grpComInfo.Controls.Add(Me.cmdReceipt)
        Me.grpComInfo.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Italic)
        Me.grpComInfo.Location = New System.Drawing.Point(58, 43)
        Me.grpComInfo.Name = "grpComInfo"
        Me.grpComInfo.Size = New System.Drawing.Size(515, 101)
        Me.grpComInfo.TabIndex = 108
        Me.grpComInfo.TabStop = False
        Me.grpComInfo.Text = "Command Info"
        '
        'cmdCancel
        '
        Me.cmdCancel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmdCancel.Image = Global.LASER_System.My.Resources.Resources.close
        Me.cmdCancel.Location = New System.Drawing.Point(482, 6)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(34, 30)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSaveOnly
        '
        Me.cmdSaveOnly.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmdSaveOnly.Location = New System.Drawing.Point(408, 23)
        Me.cmdSaveOnly.Name = "cmdSaveOnly"
        Me.cmdSaveOnly.Size = New System.Drawing.Size(68, 65)
        Me.cmdSaveOnly.TabIndex = 3
        Me.cmdSaveOnly.Text = "Save Only"
        Me.cmdSaveOnly.UseVisualStyleBackColor = True
        '
        'cmdReceiptSticker
        '
        Me.cmdReceiptSticker.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmdReceiptSticker.Location = New System.Drawing.Point(6, 23)
        Me.cmdReceiptSticker.Name = "cmdReceiptSticker"
        Me.cmdReceiptSticker.Size = New System.Drawing.Size(142, 65)
        Me.cmdReceiptSticker.TabIndex = 0
        Me.cmdReceiptSticker.Text = "බිල්පතක් සහ  Repair Sticker එකක් අවශ්‍යයි."
        Me.cmdReceiptSticker.UseVisualStyleBackColor = True
        '
        'cmdSticker
        '
        Me.cmdSticker.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmdSticker.Location = New System.Drawing.Point(281, 23)
        Me.cmdSticker.Name = "cmdSticker"
        Me.cmdSticker.Size = New System.Drawing.Size(121, 65)
        Me.cmdSticker.TabIndex = 2
        Me.cmdSticker.Text = "Repair Sticker එකක් පමණක් අවශ්‍යයි."
        Me.cmdSticker.UseVisualStyleBackColor = True
        '
        'cmdReceipt
        '
        Me.cmdReceipt.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cmdReceipt.Location = New System.Drawing.Point(154, 23)
        Me.cmdReceipt.Name = "cmdReceipt"
        Me.cmdReceipt.Size = New System.Drawing.Size(121, 65)
        Me.cmdReceipt.TabIndex = 1
        Me.cmdReceipt.Text = "බිල්පතක් පමණක් අවශ්‍යයි."
        Me.cmdReceipt.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.grpComInfo, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(631, 187)
        Me.TableLayoutPanel1.TabIndex = 109
        '
        'ControlCommandInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlCommandInfo"
        Me.Size = New System.Drawing.Size(631, 187)
        Me.grpComInfo.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpComInfo As GroupBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdSaveOnly As Button
    Friend WithEvents cmdReceiptSticker As Button
    Friend WithEvents cmdSticker As Button
    Friend WithEvents cmdReceipt As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
