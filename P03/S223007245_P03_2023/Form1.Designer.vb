<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDestination
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
        Me.btnCaptVal = New System.Windows.Forms.Button()
        Me.btnCalcTotPhotos = New System.Windows.Forms.Button()
        Me.btnCalcRatio = New System.Windows.Forms.Button()
        Me.btCalcIndex = New System.Windows.Forms.Button()
        Me.btnTourismRating = New System.Windows.Forms.Button()
        Me.btnIncreaseOrSame = New System.Windows.Forms.Button()
        Me.txtIncreaseOrSame = New System.Windows.Forms.TextBox()
        Me.grdDest = New UJGrid.UJGrid()
        Me.SuspendLayout()
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(12, 12)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(125, 40)
        Me.btnSetup.TabIndex = 0
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'btnCaptVal
        '
        Me.btnCaptVal.Location = New System.Drawing.Point(12, 58)
        Me.btnCaptVal.Name = "btnCaptVal"
        Me.btnCaptVal.Size = New System.Drawing.Size(125, 40)
        Me.btnCaptVal.TabIndex = 3
        Me.btnCaptVal.Text = "Capture Values"
        Me.btnCaptVal.UseVisualStyleBackColor = True
        '
        'btnCalcTotPhotos
        '
        Me.btnCalcTotPhotos.Location = New System.Drawing.Point(12, 104)
        Me.btnCalcTotPhotos.Name = "btnCalcTotPhotos"
        Me.btnCalcTotPhotos.Size = New System.Drawing.Size(125, 40)
        Me.btnCalcTotPhotos.TabIndex = 4
        Me.btnCalcTotPhotos.Text = "Calculate Total Photos"
        Me.btnCalcTotPhotos.UseVisualStyleBackColor = True
        '
        'btnCalcRatio
        '
        Me.btnCalcRatio.Location = New System.Drawing.Point(12, 150)
        Me.btnCalcRatio.Name = "btnCalcRatio"
        Me.btnCalcRatio.Size = New System.Drawing.Size(125, 40)
        Me.btnCalcRatio.TabIndex = 5
        Me.btnCalcRatio.Text = "Calculate Ratio"
        Me.btnCalcRatio.UseVisualStyleBackColor = True
        '
        'btCalcIndex
        '
        Me.btCalcIndex.Location = New System.Drawing.Point(12, 196)
        Me.btCalcIndex.Name = "btCalcIndex"
        Me.btCalcIndex.Size = New System.Drawing.Size(125, 40)
        Me.btCalcIndex.TabIndex = 6
        Me.btCalcIndex.Text = "Calculate Index"
        Me.btCalcIndex.UseVisualStyleBackColor = True
        '
        'btnTourismRating
        '
        Me.btnTourismRating.Location = New System.Drawing.Point(12, 242)
        Me.btnTourismRating.Name = "btnTourismRating"
        Me.btnTourismRating.Size = New System.Drawing.Size(125, 40)
        Me.btnTourismRating.TabIndex = 7
        Me.btnTourismRating.Text = "Tourism Rating"
        Me.btnTourismRating.UseVisualStyleBackColor = True
        '
        'btnIncreaseOrSame
        '
        Me.btnIncreaseOrSame.Location = New System.Drawing.Point(12, 288)
        Me.btnIncreaseOrSame.Name = "btnIncreaseOrSame"
        Me.btnIncreaseOrSame.Size = New System.Drawing.Size(125, 40)
        Me.btnIncreaseOrSame.TabIndex = 8
        Me.btnIncreaseOrSame.Text = "Increase Or Same"
        Me.btnIncreaseOrSame.UseVisualStyleBackColor = True
        '
        'txtIncreaseOrSame
        '
        Me.txtIncreaseOrSame.Location = New System.Drawing.Point(143, 290)
        Me.txtIncreaseOrSame.Multiline = True
        Me.txtIncreaseOrSame.Name = "txtIncreaseOrSame"
        Me.txtIncreaseOrSame.Size = New System.Drawing.Size(633, 38)
        Me.txtIncreaseOrSame.TabIndex = 9
        '
        'grdDest
        '
        Me.grdDest.FixedCols = 1
        Me.grdDest.FixedRows = 1
        Me.grdDest.Location = New System.Drawing.Point(143, 12)
        Me.grdDest.Name = "grdDest"
        Me.grdDest.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdDest.Size = New System.Drawing.Size(633, 270)
        Me.grdDest.TabIndex = 10
        '
        'frmDestination
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grdDest)
        Me.Controls.Add(Me.txtIncreaseOrSame)
        Me.Controls.Add(Me.btnIncreaseOrSame)
        Me.Controls.Add(Me.btnTourismRating)
        Me.Controls.Add(Me.btCalcIndex)
        Me.Controls.Add(Me.btnCalcRatio)
        Me.Controls.Add(Me.btnCalcTotPhotos)
        Me.Controls.Add(Me.btnCaptVal)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "frmDestination"
        Me.Text = "Destination tracker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSetup As Button
    Friend WithEvents btnCaptVal As Button
    Friend WithEvents btnCalcTotPhotos As Button
    Friend WithEvents btnCalcRatio As Button
    Friend WithEvents btCalcIndex As Button
    Friend WithEvents btnTourismRating As Button
    Friend WithEvents btnIncreaseOrSame As Button
    Friend WithEvents txtIncreaseOrSame As TextBox
    Friend WithEvents grdDest As UJGrid.UJGrid
End Class
