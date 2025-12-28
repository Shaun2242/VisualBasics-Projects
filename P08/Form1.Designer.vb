<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBursary
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
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.btnUniStudent = New System.Windows.Forms.Button()
        Me.txtStudents = New System.Windows.Forms.TextBox()
        Me.txtUniStudent = New System.Windows.Forms.TextBox()
        Me.btnWriteFile = New System.Windows.Forms.Button()
        Me.btnReadFile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(12, 12)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(776, 50)
        Me.btnSetup.TabIndex = 0
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'btnStudents
        '
        Me.btnStudents.Location = New System.Drawing.Point(12, 114)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(181, 188)
        Me.btnStudents.TabIndex = 1
        Me.btnStudents.Text = "Display Information For Students"
        Me.btnStudents.UseVisualStyleBackColor = True
        '
        'btnUniStudent
        '
        Me.btnUniStudent.Location = New System.Drawing.Point(12, 308)
        Me.btnUniStudent.Name = "btnUniStudent"
        Me.btnUniStudent.Size = New System.Drawing.Size(181, 20)
        Me.btnUniStudent.TabIndex = 3
        Me.btnUniStudent.Text = "Display Top University Student"
        Me.btnUniStudent.UseVisualStyleBackColor = True
        '
        'txtStudents
        '
        Me.txtStudents.Location = New System.Drawing.Point(199, 114)
        Me.txtStudents.Multiline = True
        Me.txtStudents.Name = "txtStudents"
        Me.txtStudents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStudents.Size = New System.Drawing.Size(589, 188)
        Me.txtStudents.TabIndex = 4
        '
        'txtUniStudent
        '
        Me.txtUniStudent.Location = New System.Drawing.Point(199, 309)
        Me.txtUniStudent.Name = "txtUniStudent"
        Me.txtUniStudent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtUniStudent.Size = New System.Drawing.Size(589, 20)
        Me.txtUniStudent.TabIndex = 6
        '
        'btnWriteFile
        '
        Me.btnWriteFile.Location = New System.Drawing.Point(12, 68)
        Me.btnWriteFile.Name = "btnWriteFile"
        Me.btnWriteFile.Size = New System.Drawing.Size(390, 40)
        Me.btnWriteFile.TabIndex = 7
        Me.btnWriteFile.Text = "Write Infromation To File"
        Me.btnWriteFile.UseVisualStyleBackColor = True
        '
        'btnReadFile
        '
        Me.btnReadFile.Location = New System.Drawing.Point(408, 68)
        Me.btnReadFile.Name = "btnReadFile"
        Me.btnReadFile.Size = New System.Drawing.Size(380, 40)
        Me.btnReadFile.TabIndex = 8
        Me.btnReadFile.Text = "Read Information From File"
        Me.btnReadFile.UseVisualStyleBackColor = True
        '
        'frmBursary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 368)
        Me.Controls.Add(Me.btnReadFile)
        Me.Controls.Add(Me.btnWriteFile)
        Me.Controls.Add(Me.txtUniStudent)
        Me.Controls.Add(Me.txtStudents)
        Me.Controls.Add(Me.btnUniStudent)
        Me.Controls.Add(Me.btnStudents)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "frmBursary"
        Me.Text = "Bursary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSetup As Button
    Friend WithEvents btnStudents As Button
    Friend WithEvents btnUniStudent As Button
    Friend WithEvents txtStudents As TextBox
    Friend WithEvents txtUniStudent As TextBox
    Friend WithEvents btnWriteFile As Button
    Friend WithEvents btnReadFile As Button
End Class
