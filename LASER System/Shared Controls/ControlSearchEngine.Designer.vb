<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlSearchEngine
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboFilter = New System.Windows.Forms.ComboBox()
        Me.ButtonCloseBracket = New System.Windows.Forms.Button()
        Me.ButtonOpenBracket = New System.Windows.Forms.Button()
        Me.RadioOr = New System.Windows.Forms.RadioButton()
        Me.RadioAnd = New System.Windows.Forms.RadioButton()
        Me.FlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.TextSearch = New System.Windows.Forms.TextBox()
        Me.LabelInvalidator = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelInvalidator)
        Me.Panel1.Controls.Add(Me.ComboFilter)
        Me.Panel1.Controls.Add(Me.ButtonCloseBracket)
        Me.Panel1.Controls.Add(Me.ButtonOpenBracket)
        Me.Panel1.Controls.Add(Me.RadioOr)
        Me.Panel1.Controls.Add(Me.RadioAnd)
        Me.Panel1.Controls.Add(Me.FlowPanel)
        Me.Panel1.Controls.Add(Me.ButtonSearch)
        Me.Panel1.Controls.Add(Me.TextSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 65)
        Me.Panel1.TabIndex = 1
        '
        'ComboFilter
        '
        Me.ComboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboFilter.FormattingEnabled = True
        Me.ComboFilter.Location = New System.Drawing.Point(57, 6)
        Me.ComboFilter.Name = "ComboFilter"
        Me.ComboFilter.Size = New System.Drawing.Size(121, 22)
        Me.ComboFilter.TabIndex = 8
        '
        'ButtonCloseBracket
        '
        Me.ButtonCloseBracket.Location = New System.Drawing.Point(526, 6)
        Me.ButtonCloseBracket.Name = "ButtonCloseBracket"
        Me.ButtonCloseBracket.Size = New System.Drawing.Size(22, 22)
        Me.ButtonCloseBracket.TabIndex = 7
        Me.ButtonCloseBracket.Text = ")"
        Me.ButtonCloseBracket.UseVisualStyleBackColor = True
        '
        'ButtonOpenBracket
        '
        Me.ButtonOpenBracket.Location = New System.Drawing.Point(498, 6)
        Me.ButtonOpenBracket.Name = "ButtonOpenBracket"
        Me.ButtonOpenBracket.Size = New System.Drawing.Size(22, 22)
        Me.ButtonOpenBracket.TabIndex = 6
        Me.ButtonOpenBracket.Text = "("
        Me.ButtonOpenBracket.UseVisualStyleBackColor = True
        '
        'RadioOr
        '
        Me.RadioOr.AutoSize = True
        Me.RadioOr.Location = New System.Drawing.Point(452, 8)
        Me.RadioOr.Name = "RadioOr"
        Me.RadioOr.Size = New System.Drawing.Size(40, 18)
        Me.RadioOr.TabIndex = 5
        Me.RadioOr.Text = "OR"
        Me.RadioOr.UseVisualStyleBackColor = True
        '
        'RadioAnd
        '
        Me.RadioAnd.AutoSize = True
        Me.RadioAnd.Checked = True
        Me.RadioAnd.Location = New System.Drawing.Point(398, 8)
        Me.RadioAnd.Name = "RadioAnd"
        Me.RadioAnd.Size = New System.Drawing.Size(48, 18)
        Me.RadioAnd.TabIndex = 4
        Me.RadioAnd.TabStop = True
        Me.RadioAnd.Text = "AND"
        Me.RadioAnd.UseVisualStyleBackColor = True
        '
        'FlowPanel
        '
        Me.FlowPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowPanel.AutoScroll = True
        Me.FlowPanel.Location = New System.Drawing.Point(3, 31)
        Me.FlowPanel.Name = "FlowPanel"
        Me.FlowPanel.Size = New System.Drawing.Size(699, 31)
        Me.FlowPanel.TabIndex = 3
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Image = Global.LASER_System.My.Resources.Resources.search__2_
        Me.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSearch.Location = New System.Drawing.Point(314, 6)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(76, 22)
        Me.ButtonSearch.TabIndex = 2
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'TextSearch
        '
        Me.TextSearch.Location = New System.Drawing.Point(184, 6)
        Me.TextSearch.Name = "TextSearch"
        Me.TextSearch.Size = New System.Drawing.Size(124, 22)
        Me.TextSearch.TabIndex = 1
        '
        'LabelInvalidator
        '
        Me.LabelInvalidator.AutoSize = True
        Me.LabelInvalidator.BackColor = System.Drawing.Color.DarkRed
        Me.LabelInvalidator.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelInvalidator.Location = New System.Drawing.Point(554, 10)
        Me.LabelInvalidator.Name = "LabelInvalidator"
        Me.LabelInvalidator.Size = New System.Drawing.Size(118, 14)
        Me.LabelInvalidator.TabIndex = 9
        Me.LabelInvalidator.Text = "Invalid Search Query"
        Me.LabelInvalidator.Visible = False
        '
        'ControlSearchEngine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Name = "ControlSearchEngine"
        Me.Size = New System.Drawing.Size(705, 65)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowPanel As FlowLayoutPanel
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents TextSearch As TextBox
    Friend WithEvents RadioOr As RadioButton
    Friend WithEvents RadioAnd As RadioButton
    Friend WithEvents ButtonCloseBracket As Button
    Friend WithEvents ButtonOpenBracket As Button
    Friend WithEvents ComboFilter As ComboBox
    Friend WithEvents LabelInvalidator As Label
End Class
