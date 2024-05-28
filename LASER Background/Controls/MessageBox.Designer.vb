<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageBox
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnMessageDelete = New System.Windows.Forms.PictureBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.PanelAction = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn1 = New MaterialSkin.Controls.MaterialButton()
        Me.Btn2 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCard = New MaterialSkin.Controls.MaterialCard()
        CType(Me.btnMessageDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAction.SuspendLayout()
        Me.MaterialCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblTitle.Location = New System.Drawing.Point(62, 15)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(35, 17)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Title"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblMessage.Location = New System.Drawing.Point(62, 46)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(5, 5, 5, 11)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(65, 17)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.Text = "Message"
        '
        'btnMessageDelete
        '
        Me.btnMessageDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMessageDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMessageDelete.Image = Global.LASER_Background.My.Resources.Resources.close
        Me.btnMessageDelete.Location = New System.Drawing.Point(264, 18)
        Me.btnMessageDelete.Name = "btnMessageDelete"
        Me.btnMessageDelete.Size = New System.Drawing.Size(24, 25)
        Me.btnMessageDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnMessageDelete.TabIndex = 0
        Me.btnMessageDelete.TabStop = False
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox.Image = Global.LASER_Background.My.Resources.Resources.attention
        Me.PictureBox.Location = New System.Drawing.Point(14, 15)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(40, 122)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox.TabIndex = 3
        Me.PictureBox.TabStop = False
        '
        'PanelAction
        '
        Me.PanelAction.BackColor = System.Drawing.Color.Transparent
        Me.PanelAction.Controls.Add(Me.Btn1)
        Me.PanelAction.Controls.Add(Me.Btn2)
        Me.PanelAction.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelAction.Location = New System.Drawing.Point(54, 83)
        Me.PanelAction.Name = "PanelAction"
        Me.PanelAction.Size = New System.Drawing.Size(235, 54)
        Me.PanelAction.TabIndex = 4
        Me.PanelAction.Visible = False
        '
        'Btn1
        '
        Me.Btn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.Btn1.Depth = 0
        Me.Btn1.HighEmphasis = True
        Me.Btn1.Icon = Nothing
        Me.Btn1.Location = New System.Drawing.Point(4, 6)
        Me.Btn1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn1.Name = "Btn1"
        Me.Btn1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.Btn1.Size = New System.Drawing.Size(64, 36)
        Me.Btn1.TabIndex = 4
        Me.Btn1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.Btn1.UseAccentColor = False
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.Btn2.Depth = 0
        Me.Btn2.HighEmphasis = True
        Me.Btn2.Icon = Nothing
        Me.Btn2.Location = New System.Drawing.Point(76, 6)
        Me.Btn2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn2.Name = "Btn2"
        Me.Btn2.NoAccentTextColor = System.Drawing.Color.Empty
        Me.Btn2.Size = New System.Drawing.Size(64, 36)
        Me.Btn2.TabIndex = 5
        Me.Btn2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.Btn2.UseAccentColor = False
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'MaterialCard
        '
        Me.MaterialCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard.Controls.Add(Me.lblMessage)
        Me.MaterialCard.Controls.Add(Me.btnMessageDelete)
        Me.MaterialCard.Controls.Add(Me.PanelAction)
        Me.MaterialCard.Controls.Add(Me.lblTitle)
        Me.MaterialCard.Controls.Add(Me.PictureBox)
        Me.MaterialCard.Depth = 0
        Me.MaterialCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialCard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard.Location = New System.Drawing.Point(0, 0)
        Me.MaterialCard.Margin = New System.Windows.Forms.Padding(14, 15, 14, 15)
        Me.MaterialCard.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard.Name = "MaterialCard"
        Me.MaterialCard.Padding = New System.Windows.Forms.Padding(14, 15, 14, 15)
        Me.MaterialCard.Size = New System.Drawing.Size(303, 152)
        Me.MaterialCard.TabIndex = 5
        '
        'MessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.MaterialCard)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MessageBox"
        Me.Size = New System.Drawing.Size(303, 152)
        CType(Me.btnMessageDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAction.ResumeLayout(False)
        Me.PanelAction.PerformLayout()
        Me.MaterialCard.ResumeLayout(False)
        Me.MaterialCard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnMessageDelete As PictureBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents PanelAction As FlowLayoutPanel
    Friend WithEvents Btn2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Btn1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialCard As MaterialSkin.Controls.MaterialCard
End Class
