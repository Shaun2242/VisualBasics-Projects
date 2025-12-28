<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntertainment
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
        Me.btnCaptValCin = New System.Windows.Forms.Button()
        Me.btnCinema = New System.Windows.Forms.Button()
        Me.btnComedy = New System.Windows.Forms.Button()
        Me.txtCinema = New System.Windows.Forms.TextBox()
        Me.txtComedy = New System.Windows.Forms.TextBox()
        Me.btnCaptValCom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCaptValCin
        '
        Me.btnCaptValCin.Location = New System.Drawing.Point(12, 12)
        Me.btnCaptValCin.Name = "btnCaptValCin"
        Me.btnCaptValCin.Size = New System.Drawing.Size(310, 31)
        Me.btnCaptValCin.TabIndex = 0
        Me.btnCaptValCin.Text = "Capture Values For Cinema"
        Me.btnCaptValCin.UseVisualStyleBackColor = True
        '
        'btnCinema
        '
        Me.btnCinema.Location = New System.Drawing.Point(12, 49)
        Me.btnCinema.Name = "btnCinema"
        Me.btnCinema.Size = New System.Drawing.Size(310, 116)
        Me.btnCinema.TabIndex = 1
        Me.btnCinema.Text = "Cinema Information"
        Me.btnCinema.UseVisualStyleBackColor = True
        '
        'btnComedy
        '
        Me.btnComedy.Location = New System.Drawing.Point(12, 210)
        Me.btnComedy.Name = "btnComedy"
        Me.btnComedy.Size = New System.Drawing.Size(310, 119)
        Me.btnComedy.TabIndex = 2
        Me.btnComedy.Text = "Comedy Show Information"
        Me.btnComedy.UseVisualStyleBackColor = True
        '
        'txtCinema
        '
        Me.txtCinema.Location = New System.Drawing.Point(328, 12)
        Me.txtCinema.Multiline = True
        Me.txtCinema.Name = "txtCinema"
        Me.txtCinema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCinema.Size = New System.Drawing.Size(416, 153)
        Me.txtCinema.TabIndex = 4
        '
        'txtComedy
        '
        Me.txtComedy.Location = New System.Drawing.Point(328, 173)
        Me.txtComedy.Multiline = True
        Me.txtComedy.Name = "txtComedy"
        Me.txtComedy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComedy.Size = New System.Drawing.Size(416, 156)
        Me.txtComedy.TabIndex = 5
        '
        'btnCaptValCom
        '
        Me.btnCaptValCom.Location = New System.Drawing.Point(12, 173)
        Me.btnCaptValCom.Name = "btnCaptValCom"
        Me.btnCaptValCom.Size = New System.Drawing.Size(310, 31)
        Me.btnCaptValCom.TabIndex = 6
        Me.btnCaptValCom.Text = "Capture Values For Comedy"
        Me.btnCaptValCom.UseVisualStyleBackColor = True
        '
        'frmEntertainment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCaptValCom)
        Me.Controls.Add(Me.txtComedy)
        Me.Controls.Add(Me.txtCinema)
        Me.Controls.Add(Me.btnComedy)
        Me.Controls.Add(Me.btnCinema)
        Me.Controls.Add(Me.btnCaptValCin)
        Me.Name = "frmEntertainment"
        Me.Text = "Entertainment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCaptValCin As Button
    Friend WithEvents btnCinema As Button
    Friend WithEvents btnComedy As Button
    Friend WithEvents txtCinema As TextBox
    Friend WithEvents txtComedy As TextBox
    Friend WithEvents btnCaptValCom As Button
End Class
