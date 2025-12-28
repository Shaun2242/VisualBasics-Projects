<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCUA
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
        Me.btnSaveToFile = New System.Windows.Forms.Button()
        Me.btnReadFromFile = New System.Windows.Forms.Button()
        Me.btnHighestPowerCUATeam = New System.Windows.Forms.Button()
        Me.txtHighestPowerCUATeam = New System.Windows.Forms.TextBox()
        Me.grdCUA = New UJGrid.UJGrid()
        Me.btnCaptVal = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtTeamInfo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSaveToFile
        '
        Me.btnSaveToFile.Location = New System.Drawing.Point(12, 55)
        Me.btnSaveToFile.Name = "btnSaveToFile"
        Me.btnSaveToFile.Size = New System.Drawing.Size(386, 36)
        Me.btnSaveToFile.TabIndex = 0
        Me.btnSaveToFile.Text = "Save To File"
        Me.btnSaveToFile.UseVisualStyleBackColor = True
        '
        'btnReadFromFile
        '
        Me.btnReadFromFile.Location = New System.Drawing.Point(404, 55)
        Me.btnReadFromFile.Name = "btnReadFromFile"
        Me.btnReadFromFile.Size = New System.Drawing.Size(384, 36)
        Me.btnReadFromFile.TabIndex = 3
        Me.btnReadFromFile.Text = "Read From File"
        Me.btnReadFromFile.UseVisualStyleBackColor = True
        '
        'btnHighestPowerCUATeam
        '
        Me.btnHighestPowerCUATeam.Location = New System.Drawing.Point(12, 399)
        Me.btnHighestPowerCUATeam.Name = "btnHighestPowerCUATeam"
        Me.btnHighestPowerCUATeam.Size = New System.Drawing.Size(386, 44)
        Me.btnHighestPowerCUATeam.TabIndex = 4
        Me.btnHighestPowerCUATeam.Text = " Highest Power Value CUATeam"
        Me.btnHighestPowerCUATeam.UseVisualStyleBackColor = True
        '
        'txtHighestPowerCUATeam
        '
        Me.txtHighestPowerCUATeam.Location = New System.Drawing.Point(404, 402)
        Me.txtHighestPowerCUATeam.Multiline = True
        Me.txtHighestPowerCUATeam.Name = "txtHighestPowerCUATeam"
        Me.txtHighestPowerCUATeam.Size = New System.Drawing.Size(384, 41)
        Me.txtHighestPowerCUATeam.TabIndex = 5
        '
        'grdCUA
        '
        Me.grdCUA.FixedCols = 1
        Me.grdCUA.FixedRows = 1
        Me.grdCUA.Location = New System.Drawing.Point(12, 97)
        Me.grdCUA.Name = "grdCUA"
        Me.grdCUA.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdCUA.Size = New System.Drawing.Size(551, 296)
        Me.grdCUA.TabIndex = 6
        '
        'btnCaptVal
        '
        Me.btnCaptVal.Location = New System.Drawing.Point(12, 12)
        Me.btnCaptVal.Name = "btnCaptVal"
        Me.btnCaptVal.Size = New System.Drawing.Size(776, 37)
        Me.btnCaptVal.TabIndex = 7
        Me.btnCaptVal.Text = "Capture Values"
        Me.btnCaptVal.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(569, 97)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(219, 67)
        Me.btnDisplay.TabIndex = 8
        Me.btnDisplay.Text = "Display Information For Team"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtTeamInfo
        '
        Me.txtTeamInfo.Location = New System.Drawing.Point(570, 170)
        Me.txtTeamInfo.Multiline = True
        Me.txtTeamInfo.Name = "txtTeamInfo"
        Me.txtTeamInfo.Size = New System.Drawing.Size(218, 223)
        Me.txtTeamInfo.TabIndex = 9
        '
        'frmCUA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtTeamInfo)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnCaptVal)
        Me.Controls.Add(Me.grdCUA)
        Me.Controls.Add(Me.txtHighestPowerCUATeam)
        Me.Controls.Add(Me.btnHighestPowerCUATeam)
        Me.Controls.Add(Me.btnReadFromFile)
        Me.Controls.Add(Me.btnSaveToFile)
        Me.Name = "frmCUA"
        Me.Text = "CUA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSaveToFile As Button
    Friend WithEvents btnReadFromFile As Button
    Friend WithEvents btnHighestPowerCUATeam As Button
    Friend WithEvents txtHighestPowerCUATeam As TextBox
    Friend WithEvents grdCUA As UJGrid.UJGrid
    Friend WithEvents btnCaptVal As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents txtTeamInfo As TextBox
End Class
