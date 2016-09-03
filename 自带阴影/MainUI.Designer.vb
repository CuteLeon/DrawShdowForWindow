<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainUI
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainUI))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SizePro = New System.Windows.Forms.ProgressBar()
        Me.DistancePro = New System.Windows.Forms.ProgressBar()
        Me.AnglePro = New System.Windows.Forms.ProgressBar()
        Me.OpacityPro = New System.Windows.Forms.ProgressBar()
        Me.RPro = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GPro = New System.Windows.Forms.ProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BPro = New System.Windows.Forms.ProgressBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "大小：ShadowSize"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "距离：ShadowDistance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "角度：ShadowAngle"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(12, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "不透明度：ShadowOpacity"
        '
        'SizePro
        '
        Me.SizePro.BackColor = System.Drawing.SystemColors.Control
        Me.SizePro.Location = New System.Drawing.Point(15, 24)
        Me.SizePro.Name = "SizePro"
        Me.SizePro.Size = New System.Drawing.Size(333, 16)
        Me.SizePro.Step = 5
        Me.SizePro.TabIndex = 11
        '
        'DistancePro
        '
        Me.DistancePro.Location = New System.Drawing.Point(15, 62)
        Me.DistancePro.Maximum = 150
        Me.DistancePro.Name = "DistancePro"
        Me.DistancePro.Size = New System.Drawing.Size(333, 16)
        Me.DistancePro.Step = 5
        Me.DistancePro.TabIndex = 12
        '
        'AnglePro
        '
        Me.AnglePro.Location = New System.Drawing.Point(15, 100)
        Me.AnglePro.Maximum = 360
        Me.AnglePro.Name = "AnglePro"
        Me.AnglePro.Size = New System.Drawing.Size(333, 16)
        Me.AnglePro.Step = 5
        Me.AnglePro.TabIndex = 13
        '
        'OpacityPro
        '
        Me.OpacityPro.Location = New System.Drawing.Point(15, 138)
        Me.OpacityPro.Name = "OpacityPro"
        Me.OpacityPro.Size = New System.Drawing.Size(333, 16)
        Me.OpacityPro.Step = 5
        Me.OpacityPro.TabIndex = 14
        '
        'RPro
        '
        Me.RPro.Location = New System.Drawing.Point(15, 176)
        Me.RPro.Maximum = 255
        Me.RPro.Name = "RPro"
        Me.RPro.Size = New System.Drawing.Size(333, 16)
        Me.RPro.Step = 5
        Me.RPro.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(12, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "颜色.红：255"
        '
        'GPro
        '
        Me.GPro.Location = New System.Drawing.Point(15, 214)
        Me.GPro.Maximum = 255
        Me.GPro.Name = "GPro"
        Me.GPro.Size = New System.Drawing.Size(333, 16)
        Me.GPro.Step = 5
        Me.GPro.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(12, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "颜色.绿：255"
        '
        'BPro
        '
        Me.BPro.Location = New System.Drawing.Point(15, 252)
        Me.BPro.Maximum = 255
        Me.BPro.Name = "BPro"
        Me.BPro.Size = New System.Drawing.Size(333, 16)
        Me.BPro.Step = 5
        Me.BPro.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(12, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "颜色.蓝：255"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(15, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(333, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Exit Me"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainUI
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(360, 300)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BPro)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GPro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RPro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.OpacityPro)
        Me.Controls.Add(Me.AnglePro)
        Me.Controls.Add(Me.DistancePro)
        Me.Controls.Add(Me.SizePro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "MainUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MianUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SizePro As System.Windows.Forms.ProgressBar
    Friend WithEvents DistancePro As System.Windows.Forms.ProgressBar
    Friend WithEvents AnglePro As System.Windows.Forms.ProgressBar
    Friend WithEvents OpacityPro As System.Windows.Forms.ProgressBar
    Friend WithEvents RPro As System.Windows.Forms.ProgressBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GPro As System.Windows.Forms.ProgressBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BPro As System.Windows.Forms.ProgressBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
