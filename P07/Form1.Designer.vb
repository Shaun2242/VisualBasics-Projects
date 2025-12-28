<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecycle
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
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.txtRecy = New System.Windows.Forms.TextBox()
        Me.lblInfRec = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(12, 12)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(695, 57)
        Me.btnSetup.TabIndex = 0
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'txtRecy
        '
        Me.txtRecy.Location = New System.Drawing.Point(252, 75)
        Me.txtRecy.Multiline = True
        Me.txtRecy.Name = "txtRecy"
        Me.txtRecy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecy.Size = New System.Drawing.Size(455, 241)
        Me.txtRecy.TabIndex = 6
        '
        'lblInfRec
        '
        Me.lblInfRec.BackColor = System.Drawing.SystemColors.Control
        Me.lblInfRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfRec.Location = New System.Drawing.Point(12, 75)
        Me.lblInfRec.Name = "lblInfRec"
        Me.lblInfRec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInfRec.Size = New System.Drawing.Size(234, 241)
        Me.lblInfRec.TabIndex = 7
        Me.lblInfRec.Text = "Information " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For Each " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recyclable"
        Me.lblInfRec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRecycle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblInfRec)
        Me.Controls.Add(Me.txtRecy)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "frmRecycle"
        Me.Text = "Recyclables"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSetup As Button
    Friend WithEvents txtRecy As TextBox
    Friend WithEvents lblInfRec As Label
End Class
