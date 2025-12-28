<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChaosInc
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnHuman = New System.Windows.Forms.Button()
        Me.btnOrc = New System.Windows.Forms.Button()
        Me.btnElf = New System.Windows.Forms.Button()
        Me.txtHuman = New System.Windows.Forms.TextBox()
        Me.txtOrc = New System.Windows.Forms.TextBox()
        Me.txtElf = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 22)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(775, 45)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnHuman
        '
        Me.btnHuman.Location = New System.Drawing.Point(12, 73)
        Me.btnHuman.Name = "btnHuman"
        Me.btnHuman.Size = New System.Drawing.Size(185, 115)
        Me.btnHuman.TabIndex = 1
        Me.btnHuman.Text = "Display Information For Human "
        Me.btnHuman.UseVisualStyleBackColor = True
        '
        'btnOrc
        '
        Me.btnOrc.Location = New System.Drawing.Point(13, 194)
        Me.btnOrc.Name = "btnOrc"
        Me.btnOrc.Size = New System.Drawing.Size(185, 115)
        Me.btnOrc.TabIndex = 2
        Me.btnOrc.Text = "Display Information For Orc"
        Me.btnOrc.UseVisualStyleBackColor = True
        '
        'btnElf
        '
        Me.btnElf.Location = New System.Drawing.Point(12, 315)
        Me.btnElf.Name = "btnElf"
        Me.btnElf.Size = New System.Drawing.Size(185, 115)
        Me.btnElf.TabIndex = 3
        Me.btnElf.Text = "Display Infromation For Elf"
        Me.btnElf.UseVisualStyleBackColor = True
        '
        'txtHuman
        '
        Me.txtHuman.Location = New System.Drawing.Point(203, 73)
        Me.txtHuman.Multiline = True
        Me.txtHuman.Name = "txtHuman"
        Me.txtHuman.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHuman.Size = New System.Drawing.Size(584, 115)
        Me.txtHuman.TabIndex = 4
        '
        'txtOrc
        '
        Me.txtOrc.Location = New System.Drawing.Point(202, 194)
        Me.txtOrc.Multiline = True
        Me.txtOrc.Name = "txtOrc"
        Me.txtOrc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOrc.Size = New System.Drawing.Size(585, 115)
        Me.txtOrc.TabIndex = 5
        '
        'txtElf
        '
        Me.txtElf.Location = New System.Drawing.Point(203, 315)
        Me.txtElf.Multiline = True
        Me.txtElf.Name = "txtElf"
        Me.txtElf.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtElf.Size = New System.Drawing.Size(584, 115)
        Me.txtElf.TabIndex = 6
        '
        'frmChaosInc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtElf)
        Me.Controls.Add(Me.txtOrc)
        Me.Controls.Add(Me.txtHuman)
        Me.Controls.Add(Me.btnElf)
        Me.Controls.Add(Me.btnOrc)
        Me.Controls.Add(Me.btnHuman)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "frmChaosInc"
        Me.Text = "Chaos Inc."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnHuman As Button
    Friend WithEvents btnOrc As Button
    Friend WithEvents btnElf As Button
    Friend WithEvents txtHuman As TextBox
    Friend WithEvents txtOrc As TextBox
    Friend WithEvents txtElf As TextBox
End Class
