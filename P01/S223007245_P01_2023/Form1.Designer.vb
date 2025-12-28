<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValues
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.btnCaptVal = New System.Windows.Forms.Button()
        Me.txtValues = New System.Windows.Forms.TextBox()
        Me.btnItteration = New System.Windows.Forms.Button()
        Me.btnRecursion = New System.Windows.Forms.Button()
        Me.txtIteration = New System.Windows.Forms.TextBox()
        Me.txtRecursion = New System.Windows.Forms.TextBox()
        Me.lblVal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCaptVal
        '
        Me.btnCaptVal.Location = New System.Drawing.Point(27, 41)
        Me.btnCaptVal.Name = "btnCaptVal"
        Me.btnCaptVal.Size = New System.Drawing.Size(280, 49)
        Me.btnCaptVal.TabIndex = 0
        Me.btnCaptVal.Text = "Capture Values"
        Me.btnCaptVal.UseVisualStyleBackColor = True
        '
        'txtValues
        '
        Me.txtValues.Location = New System.Drawing.Point(100, 12)
        Me.txtValues.Multiline = True
        Me.txtValues.Name = "txtValues"
        Me.txtValues.Size = New System.Drawing.Size(207, 23)
        Me.txtValues.TabIndex = 1
        '
        'btnItteration
        '
        Me.btnItteration.Location = New System.Drawing.Point(27, 96)
        Me.btnItteration.Name = "btnItteration"
        Me.btnItteration.Size = New System.Drawing.Size(125, 49)
        Me.btnItteration.TabIndex = 2
        Me.btnItteration.Text = "Iterative Calculation"
        Me.btnItteration.UseVisualStyleBackColor = True
        '
        'btnRecursion
        '
        Me.btnRecursion.Location = New System.Drawing.Point(27, 151)
        Me.btnRecursion.Name = "btnRecursion"
        Me.btnRecursion.Size = New System.Drawing.Size(125, 49)
        Me.btnRecursion.TabIndex = 3
        Me.btnRecursion.Text = "Recursive Calculation"
        Me.btnRecursion.UseVisualStyleBackColor = True
        '
        'txtIteration
        '
        Me.txtIteration.Location = New System.Drawing.Point(158, 96)
        Me.txtIteration.Multiline = True
        Me.txtIteration.Name = "txtIteration"
        Me.txtIteration.Size = New System.Drawing.Size(149, 49)
        Me.txtIteration.TabIndex = 4
        '
        'txtRecursion
        '
        Me.txtRecursion.Location = New System.Drawing.Point(158, 151)
        Me.txtRecursion.Multiline = True
        Me.txtRecursion.Name = "txtRecursion"
        Me.txtRecursion.Size = New System.Drawing.Size(149, 49)
        Me.txtRecursion.TabIndex = 5
        '
        'lblVal
        '
        Me.lblVal.AutoSize = True
        Me.lblVal.Location = New System.Drawing.Point(24, 15)
        Me.lblVal.Name = "lblVal"
        Me.lblVal.Size = New System.Drawing.Size(70, 13)
        Me.lblVal.TabIndex = 6
        Me.lblVal.Text = "Integer Value"
        '
        'frmValues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 450)
        Me.Controls.Add(Me.lblVal)
        Me.Controls.Add(Me.txtRecursion)
        Me.Controls.Add(Me.txtIteration)
        Me.Controls.Add(Me.btnRecursion)
        Me.Controls.Add(Me.btnItteration)
        Me.Controls.Add(Me.txtValues)
        Me.Controls.Add(Me.btnCaptVal)
        Me.Name = "frmValues"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCaptVal As Button
    Friend WithEvents txtValues As TextBox
    Friend WithEvents btnItteration As Button
    Friend WithEvents btnRecursion As Button
    Friend WithEvents txtIteration As TextBox
    Friend WithEvents txtRecursion As TextBox
    Friend WithEvents lblVal As Label
End Class
