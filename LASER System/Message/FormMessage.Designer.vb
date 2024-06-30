<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMessage))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.bgworker = New System.ComponentModel.BackgroundWorker()
        Me.ControlMessageUnit1 = New LASER_System.ControlMessageUnit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(644, 24)
        Me.MenuStrip.TabIndex = 29
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'bgworker
        '
        Me.bgworker.WorkerReportsProgress = True
        Me.bgworker.WorkerSupportsCancellation = True
        '
        'ControlMessageUnit1
        '
        Me.ControlMessageUnit1.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.ControlMessageUnit1.Location = New System.Drawing.Point(12, 27)
        Me.ControlMessageUnit1.Name = "ControlMessageUnit1"
        Me.ControlMessageUnit1.Size = New System.Drawing.Size(623, 326)
        Me.ControlMessageUnit1.TabIndex = 30
        '
        'FormMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 358)
        Me.Controls.Add(Me.ControlMessageUnit1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LASER System - Message Center "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents bgworker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ControlMessageUnit1 As ControlMessageUnit
End Class
