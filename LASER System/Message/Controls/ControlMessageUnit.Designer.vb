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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextMessage = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(602, 489)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(424, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 483)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Suggestions"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.TextMessage)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(415, 483)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Message"
        '
        'TextMessage
        '
        Me.TextMessage.AcceptsTab = True
        Me.TextMessage.AutoWordSelection = True
        Me.TextMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextMessage.EnableAutoDragDrop = True
        Me.TextMessage.Location = New System.Drawing.Point(6, 292)
        Me.TextMessage.Name = "TextMessage"
        Me.TextMessage.Size = New System.Drawing.Size(403, 152)
        Me.TextMessage.TabIndex = 0
        Me.TextMessage.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(317, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ControlMessageUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlMessageUnit"
        Me.Size = New System.Drawing.Size(602, 489)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextMessage As RichTextBox
End Class
