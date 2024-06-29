<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlMessageUnit
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextMsgNo = New System.Windows.Forms.TextBox()
        Me.TextTelNo = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboReRepNo = New System.Windows.Forms.ComboBox()
        Me.ComboRepNo = New System.Windows.Forms.ComboBox()
        Me.RadioReRepNo = New System.Windows.Forms.RadioButton()
        Me.RadioRepNo = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSend = New System.Windows.Forms.Button()
        Me.TextMessage = New System.Windows.Forms.RichTextBox()
        Me.GridSuggestion = New System.Windows.Forms.DataGridView()
        Me.Message = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridSuggestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(526, 327)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridSuggestion)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(266, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 321)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Suggestions"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextMsgNo)
        Me.GroupBox3.Controls.Add(Me.TextTelNo)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.ComboReRepNo)
        Me.GroupBox3.Controls.Add(Me.ComboRepNo)
        Me.GroupBox3.Controls.Add(Me.RadioReRepNo)
        Me.GroupBox3.Controls.Add(Me.RadioRepNo)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ButtonSend)
        Me.GroupBox3.Controls.Add(Me.TextMessage)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(257, 321)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Message Unit"
        '
        'TextMsgNo
        '
        Me.TextMsgNo.Location = New System.Drawing.Point(6, 293)
        Me.TextMsgNo.Name = "TextMsgNo"
        Me.TextMsgNo.Size = New System.Drawing.Size(65, 22)
        Me.TextMsgNo.TabIndex = 9
        '
        'TextTelNo
        '
        Me.TextTelNo.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TextTelNo.Location = New System.Drawing.Point(126, 77)
        Me.TextTelNo.Mask = "999 0 000 000"
        Me.TextTelNo.Name = "TextTelNo"
        Me.TextTelNo.Size = New System.Drawing.Size(104, 24)
        Me.TextTelNo.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 14)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Telephone Number:"
        '
        'ComboReRepNo
        '
        Me.ComboReRepNo.FormattingEnabled = True
        Me.ComboReRepNo.Location = New System.Drawing.Point(126, 49)
        Me.ComboReRepNo.Name = "ComboReRepNo"
        Me.ComboReRepNo.Size = New System.Drawing.Size(130, 22)
        Me.ComboReRepNo.TabIndex = 6
        '
        'ComboRepNo
        '
        Me.ComboRepNo.FormattingEnabled = True
        Me.ComboRepNo.Location = New System.Drawing.Point(126, 21)
        Me.ComboRepNo.Name = "ComboRepNo"
        Me.ComboRepNo.Size = New System.Drawing.Size(130, 22)
        Me.ComboRepNo.TabIndex = 5
        '
        'RadioReRepNo
        '
        Me.RadioReRepNo.AutoSize = True
        Me.RadioReRepNo.Location = New System.Drawing.Point(6, 50)
        Me.RadioReRepNo.Name = "RadioReRepNo"
        Me.RadioReRepNo.Size = New System.Drawing.Size(93, 18)
        Me.RadioReRepNo.TabIndex = 4
        Me.RadioReRepNo.TabStop = True
        Me.RadioReRepNo.Text = "Rerepair No:"
        Me.RadioReRepNo.UseVisualStyleBackColor = True
        '
        'RadioRepNo
        '
        Me.RadioRepNo.AutoSize = True
        Me.RadioRepNo.Location = New System.Drawing.Point(6, 22)
        Me.RadioRepNo.Name = "RadioRepNo"
        Me.RadioRepNo.Size = New System.Drawing.Size(82, 18)
        Me.RadioRepNo.TabIndex = 3
        Me.RadioRepNo.TabStop = True
        Me.RadioRepNo.Text = "Repair No:"
        Me.RadioRepNo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Message:"
        '
        'ButtonSend
        '
        Me.ButtonSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSend.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonSend.Location = New System.Drawing.Point(161, 286)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(92, 29)
        Me.ButtonSend.TabIndex = 1
        Me.ButtonSend.Text = "Send"
        Me.ButtonSend.UseVisualStyleBackColor = False
        '
        'TextMessage
        '
        Me.TextMessage.AcceptsTab = True
        Me.TextMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextMessage.AutoWordSelection = True
        Me.TextMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextMessage.EnableAutoDragDrop = True
        Me.TextMessage.Location = New System.Drawing.Point(6, 128)
        Me.TextMessage.Name = "TextMessage"
        Me.TextMessage.Size = New System.Drawing.Size(247, 152)
        Me.TextMessage.TabIndex = 0
        Me.TextMessage.Text = ""
        '
        'GridSuggestion
        '
        Me.GridSuggestion.AllowUserToResizeColumns = False
        Me.GridSuggestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSuggestion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Message})
        Me.GridSuggestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSuggestion.Location = New System.Drawing.Point(3, 18)
        Me.GridSuggestion.Name = "GridSuggestion"
        Me.GridSuggestion.Size = New System.Drawing.Size(251, 300)
        Me.GridSuggestion.TabIndex = 10
        '
        'Message
        '
        Me.Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Message.DefaultCellStyle = DataGridViewCellStyle2
        Me.Message.HeaderText = "Message"
        Me.Message.Name = "Message"
        '
        'ControlMessageUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlMessageUnit"
        Me.Size = New System.Drawing.Size(526, 327)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GridSuggestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ButtonSend As Button
    Friend WithEvents TextMessage As RichTextBox
    Friend WithEvents RadioReRepNo As RadioButton
    Friend WithEvents RadioRepNo As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboReRepNo As ComboBox
    Friend WithEvents ComboRepNo As ComboBox
    Friend WithEvents TextTelNo As MaskedTextBox
    Friend WithEvents TextMsgNo As TextBox
    Friend WithEvents GridSuggestion As DataGridView
    Friend WithEvents Message As DataGridViewTextBoxColumn
End Class
