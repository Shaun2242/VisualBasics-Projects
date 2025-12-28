<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGym
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
        Me.grdGym = New UJGrid.UJGrid()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.btnCaptVal = New System.Windows.Forms.Button()
        Me.btnCalcTotCalBurnt = New System.Windows.Forms.Button()
        Me.btnIndIneExer = New System.Windows.Forms.Button()
        Me.btnWeightLossAlert = New System.Windows.Forms.Button()
        Me.btnCalcHighCalExer = New System.Windows.Forms.Button()
        Me.txtHighCalExer = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'grdGym
        '
        Me.grdGym.FixedCols = 1
        Me.grdGym.FixedRows = 1
        Me.grdGym.Location = New System.Drawing.Point(123, 12)
        Me.grdGym.Name = "grdGym"
        Me.grdGym.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdGym.Size = New System.Drawing.Size(594, 274)
        Me.grdGym.TabIndex = 0
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(12, 12)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(105, 50)
        Me.btnSetup.TabIndex = 1
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'btnCaptVal
        '
        Me.btnCaptVal.Location = New System.Drawing.Point(12, 68)
        Me.btnCaptVal.Name = "btnCaptVal"
        Me.btnCaptVal.Size = New System.Drawing.Size(105, 50)
        Me.btnCaptVal.TabIndex = 2
        Me.btnCaptVal.Text = "Capture Values"
        Me.btnCaptVal.UseVisualStyleBackColor = True
        '
        'btnCalcTotCalBurnt
        '
        Me.btnCalcTotCalBurnt.Location = New System.Drawing.Point(12, 124)
        Me.btnCalcTotCalBurnt.Name = "btnCalcTotCalBurnt"
        Me.btnCalcTotCalBurnt.Size = New System.Drawing.Size(105, 50)
        Me.btnCalcTotCalBurnt.TabIndex = 3
        Me.btnCalcTotCalBurnt.Text = "Total Calories Burnt "
        Me.btnCalcTotCalBurnt.UseVisualStyleBackColor = True
        '
        'btnIndIneExer
        '
        Me.btnIndIneExer.Location = New System.Drawing.Point(12, 180)
        Me.btnIndIneExer.Name = "btnIndIneExer"
        Me.btnIndIneExer.Size = New System.Drawing.Size(105, 50)
        Me.btnIndIneExer.TabIndex = 4
        Me.btnIndIneExer.Text = "Most Inneffective Exercise"
        Me.btnIndIneExer.UseVisualStyleBackColor = True
        '
        'btnWeightLossAlert
        '
        Me.btnWeightLossAlert.Location = New System.Drawing.Point(12, 236)
        Me.btnWeightLossAlert.Name = "btnWeightLossAlert"
        Me.btnWeightLossAlert.Size = New System.Drawing.Size(105, 50)
        Me.btnWeightLossAlert.TabIndex = 5
        Me.btnWeightLossAlert.Text = "Weight Loss Alert"
        Me.btnWeightLossAlert.UseVisualStyleBackColor = True
        '
        'btnCalcHighCalExer
        '
        Me.btnCalcHighCalExer.Location = New System.Drawing.Point(12, 292)
        Me.btnCalcHighCalExer.Name = "btnCalcHighCalExer"
        Me.btnCalcHighCalExer.Size = New System.Drawing.Size(105, 50)
        Me.btnCalcHighCalExer.TabIndex = 6
        Me.btnCalcHighCalExer.Text = "High Calories Exercise"
        Me.btnCalcHighCalExer.UseVisualStyleBackColor = True
        '
        'txtHighCalExer
        '
        Me.txtHighCalExer.Location = New System.Drawing.Point(123, 292)
        Me.txtHighCalExer.Multiline = True
        Me.txtHighCalExer.Name = "txtHighCalExer"
        Me.txtHighCalExer.Size = New System.Drawing.Size(594, 50)
        Me.txtHighCalExer.TabIndex = 7
        '
        'frmGym
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtHighCalExer)
        Me.Controls.Add(Me.btnCalcHighCalExer)
        Me.Controls.Add(Me.btnWeightLossAlert)
        Me.Controls.Add(Me.btnIndIneExer)
        Me.Controls.Add(Me.btnCalcTotCalBurnt)
        Me.Controls.Add(Me.btnCaptVal)
        Me.Controls.Add(Me.btnSetup)
        Me.Controls.Add(Me.grdGym)
        Me.Name = "frmGym"
        Me.Text = "Gym Member Tracker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdGym As UJGrid.UJGrid
    Friend WithEvents btnSetup As Button
    Friend WithEvents btnCaptVal As Button
    Friend WithEvents btnCalcTotCalBurnt As Button
    Friend WithEvents btnIndIneExer As Button
    Friend WithEvents btnWeightLossAlert As Button
    Friend WithEvents btnCalcHighCalExer As Button
    Friend WithEvents txtHighCalExer As TextBox
End Class
