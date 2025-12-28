<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHero
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
        Me.txtHeroInf = New System.Windows.Forms.TextBox()
        Me.txtRecInf = New System.Windows.Forms.TextBox()
        Me.btnDisHeroInf = New System.Windows.Forms.Button()
        Me.btnReadFromFile = New System.Windows.Forms.Button()
        Me.btnWriteToFile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(12, 13)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(776, 43)
        Me.btnSetup.TabIndex = 0
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'txtHeroInf
        '
        Me.txtHeroInf.Location = New System.Drawing.Point(253, 62)
        Me.txtHeroInf.Multiline = True
        Me.txtHeroInf.Name = "txtHeroInf"
        Me.txtHeroInf.Size = New System.Drawing.Size(529, 161)
        Me.txtHeroInf.TabIndex = 1
        '
        'txtRecInf
        '
        Me.txtRecInf.Location = New System.Drawing.Point(253, 277)
        Me.txtRecInf.Multiline = True
        Me.txtRecInf.Name = "txtRecInf"
        Me.txtRecInf.Size = New System.Drawing.Size(535, 161)
        Me.txtRecInf.TabIndex = 2
        '
        'btnDisHeroInf
        '
        Me.btnDisHeroInf.Location = New System.Drawing.Point(6, 62)
        Me.btnDisHeroInf.Name = "btnDisHeroInf"
        Me.btnDisHeroInf.Size = New System.Drawing.Size(241, 161)
        Me.btnDisHeroInf.TabIndex = 3
        Me.btnDisHeroInf.Text = "Display Heros Information"
        Me.btnDisHeroInf.UseVisualStyleBackColor = True
        '
        'btnReadFromFile
        '
        Me.btnReadFromFile.Location = New System.Drawing.Point(12, 288)
        Me.btnReadFromFile.Name = "btnReadFromFile"
        Me.btnReadFromFile.Size = New System.Drawing.Size(235, 150)
        Me.btnReadFromFile.TabIndex = 5
        Me.btnReadFromFile.Text = "Read From File"
        Me.btnReadFromFile.UseVisualStyleBackColor = True
        '
        'btnWriteToFile
        '
        Me.btnWriteToFile.Location = New System.Drawing.Point(6, 229)
        Me.btnWriteToFile.Name = "btnWriteToFile"
        Me.btnWriteToFile.Size = New System.Drawing.Size(776, 43)
        Me.btnWriteToFile.TabIndex = 7
        Me.btnWriteToFile.Text = "Write To File"
        Me.btnWriteToFile.UseVisualStyleBackColor = True
        '
        'frmHero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnWriteToFile)
        Me.Controls.Add(Me.btnReadFromFile)
        Me.Controls.Add(Me.btnDisHeroInf)
        Me.Controls.Add(Me.txtRecInf)
        Me.Controls.Add(Me.txtHeroInf)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "frmHero"
        Me.Text = "Heros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSetup As Button
    Friend WithEvents txtHeroInf As TextBox
    Friend WithEvents txtRecInf As TextBox
    Friend WithEvents btnDisHeroInf As Button
    Friend WithEvents btnReadFromFile As Button
    Friend WithEvents btnWriteToFile As Button
End Class
