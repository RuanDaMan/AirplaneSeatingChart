<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeatAssignForm
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
        Me.Unoccupied = New System.Windows.Forms.RadioButton()
        Me.Regular = New System.Windows.Forms.RadioButton()
        Me.LowCalorie = New System.Windows.Forms.RadioButton()
        Me.Vegetarian = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout
        '
        'Unoccupied
        '
        Me.Unoccupied.AutoCheck = false
        Me.Unoccupied.AutoSize = true
        Me.Unoccupied.Location = New System.Drawing.Point(12, 12)
        Me.Unoccupied.Name = "Unoccupied"
        Me.Unoccupied.Size = New System.Drawing.Size(89, 19)
        Me.Unoccupied.TabIndex = 0
        Me.Unoccupied.TabStop = true
        Me.Unoccupied.Tag = "."
        Me.Unoccupied.Text = "Unoccupied"
        Me.Unoccupied.UseVisualStyleBackColor = true
        '
        'Regular
        '
        Me.Regular.AutoCheck = false
        Me.Regular.AutoSize = true
        Me.Regular.Location = New System.Drawing.Point(219, 12)
        Me.Regular.Name = "Regular"
        Me.Regular.Size = New System.Drawing.Size(65, 19)
        Me.Regular.TabIndex = 1
        Me.Regular.TabStop = true
        Me.Regular.Tag = "R"
        Me.Regular.Text = "Regular"
        Me.Regular.UseVisualStyleBackColor = true
        '
        'LowCalorie
        '
        Me.LowCalorie.AutoCheck = false
        Me.LowCalorie.AutoSize = true
        Me.LowCalorie.Location = New System.Drawing.Point(12, 64)
        Me.LowCalorie.Name = "LowCalorie"
        Me.LowCalorie.Size = New System.Drawing.Size(87, 19)
        Me.LowCalorie.TabIndex = 2
        Me.LowCalorie.TabStop = true
        Me.LowCalorie.Tag = "L"
        Me.LowCalorie.Text = "Low Calorie"
        Me.LowCalorie.UseVisualStyleBackColor = true
        '
        'Vegetarian
        '
        Me.Vegetarian.AutoCheck = false
        Me.Vegetarian.AutoSize = true
        Me.Vegetarian.Location = New System.Drawing.Point(219, 64)
        Me.Vegetarian.Name = "Vegetarian"
        Me.Vegetarian.Size = New System.Drawing.Size(80, 19)
        Me.Vegetarian.TabIndex = 3
        Me.Vegetarian.TabStop = true
        Me.Vegetarian.Tag = "V"
        Me.Vegetarian.Text = "Vegetarian"
        Me.Vegetarian.UseVisualStyleBackColor = true
        '
        'SeatAssignForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 95)
        Me.Controls.Add(Me.Vegetarian)
        Me.Controls.Add(Me.LowCalorie)
        Me.Controls.Add(Me.Regular)
        Me.Controls.Add(Me.Unoccupied)
        Me.Name = "SeatAssignForm"
        Me.Text = "Assign"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Unoccupied As RadioButton
    Friend WithEvents Regular As RadioButton
    Friend WithEvents LowCalorie As RadioButton
    Friend WithEvents Vegetarian As RadioButton
End Class
