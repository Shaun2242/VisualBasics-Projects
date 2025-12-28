<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPuppy
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
        Me.grdPuppy = New UJGrid.UJGrid()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.btnCaptVal = New System.Windows.Forms.Button()
        Me.btnCalcFoodFed = New System.Windows.Forms.Button()
        Me.btnPricePerKil = New System.Windows.Forms.Button()
        Me.btnTotFoodFed = New System.Windows.Forms.Button()
        Me.btnTotMoneySpent = New System.Windows.Forms.Button()
        Me.txtTotFoodFed = New System.Windows.Forms.TextBox()
        Me.txtTotMoneySpent = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'grdPuppy
        '
        Me.grdPuppy.FixedCols = 1
        Me.grdPuppy.FixedRows = 1
        Me.grdPuppy.Location = New System.Drawing.Point(132, 32)
        Me.grdPuppy.Name = "grdPuppy"
        Me.grdPuppy.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdPuppy.Size = New System.Drawing.Size(400, 218)
        Me.grdPuppy.TabIndex = 0
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(12, 32)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(114, 50)
        Me.btnSetup.TabIndex = 1
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'btnCaptVal
        '
        Me.btnCaptVal.Location = New System.Drawing.Point(12, 88)
        Me.btnCaptVal.Name = "btnCaptVal"
        Me.btnCaptVal.Size = New System.Drawing.Size(114, 50)
        Me.btnCaptVal.TabIndex = 2
        Me.btnCaptVal.Text = "Capture Values"
        Me.btnCaptVal.UseVisualStyleBackColor = True
        '
        'btnCalcFoodFed
        '
        Me.btnCalcFoodFed.Location = New System.Drawing.Point(12, 144)
        Me.btnCalcFoodFed.Name = "btnCalcFoodFed"
        Me.btnCalcFoodFed.Size = New System.Drawing.Size(114, 50)
        Me.btnCalcFoodFed.TabIndex = 3
        Me.btnCalcFoodFed.Text = "Calculate Food To Be Fed "
        Me.btnCalcFoodFed.UseVisualStyleBackColor = True
        '
        'btnPricePerKil
        '
        Me.btnPricePerKil.Location = New System.Drawing.Point(12, 200)
        Me.btnPricePerKil.Name = "btnPricePerKil"
        Me.btnPricePerKil.Size = New System.Drawing.Size(114, 50)
        Me.btnPricePerKil.TabIndex = 4
        Me.btnPricePerKil.Text = "Enter Price Per Kilogram"
        Me.btnPricePerKil.UseVisualStyleBackColor = True
        '
        'btnTotFoodFed
        '
        Me.btnTotFoodFed.Location = New System.Drawing.Point(12, 256)
        Me.btnTotFoodFed.Name = "btnTotFoodFed"
        Me.btnTotFoodFed.Size = New System.Drawing.Size(114, 50)
        Me.btnTotFoodFed.TabIndex = 5
        Me.btnTotFoodFed.Text = "Calculate Total Food Fed"
        Me.btnTotFoodFed.UseVisualStyleBackColor = True
        '
        'btnTotMoneySpent
        '
        Me.btnTotMoneySpent.Location = New System.Drawing.Point(12, 312)
        Me.btnTotMoneySpent.Name = "btnTotMoneySpent"
        Me.btnTotMoneySpent.Size = New System.Drawing.Size(114, 50)
        Me.btnTotMoneySpent.TabIndex = 6
        Me.btnTotMoneySpent.Text = "Calculate Total Money Spent"
        Me.btnTotMoneySpent.UseVisualStyleBackColor = True
        '
        'txtTotFoodFed
        '
        Me.txtTotFoodFed.Location = New System.Drawing.Point(132, 256)
        Me.txtTotFoodFed.Multiline = True
        Me.txtTotFoodFed.Name = "txtTotFoodFed"
        Me.txtTotFoodFed.Size = New System.Drawing.Size(400, 50)
        Me.txtTotFoodFed.TabIndex = 7
        '
        'txtTotMoneySpent
        '
        Me.txtTotMoneySpent.Location = New System.Drawing.Point(132, 312)
        Me.txtTotMoneySpent.Multiline = True
        Me.txtTotMoneySpent.Name = "txtTotMoneySpent"
        Me.txtTotMoneySpent.Size = New System.Drawing.Size(400, 50)
        Me.txtTotMoneySpent.TabIndex = 8
        '
        'frmPuppy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtTotMoneySpent)
        Me.Controls.Add(Me.txtTotFoodFed)
        Me.Controls.Add(Me.btnTotMoneySpent)
        Me.Controls.Add(Me.btnTotFoodFed)
        Me.Controls.Add(Me.btnPricePerKil)
        Me.Controls.Add(Me.btnCalcFoodFed)
        Me.Controls.Add(Me.btnCaptVal)
        Me.Controls.Add(Me.btnSetup)
        Me.Controls.Add(Me.grdPuppy)
        Me.Name = "frmPuppy"
        Me.Text = "Puppies Tracker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdPuppy As UJGrid.UJGrid
    Friend WithEvents btnSetup As Button
    Friend WithEvents btnCaptVal As Button
    Friend WithEvents btnCalcFoodFed As Button
    Friend WithEvents btnPricePerKil As Button
    Friend WithEvents btnTotFoodFed As Button
    Friend WithEvents btnTotMoneySpent As Button
    Friend WithEvents txtTotFoodFed As TextBox
    Friend WithEvents txtTotMoneySpent As TextBox
End Class
