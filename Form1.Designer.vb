<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.FlightSeatsListView = New System.Windows.Forms.ListView()
        Me.CurrSeatA = New System.Windows.Forms.TextBox()
        Me.CurrSeatB = New System.Windows.Forms.TextBox()
        Me.CurrSeatC = New System.Windows.Forms.TextBox()
        Me.CurrSeatD = New System.Windows.Forms.TextBox()
        Me.CurrSeatE = New System.Windows.Forms.TextBox()
        Me.CurrSeatF = New System.Windows.Forms.TextBox()
        Me.UpdateRowBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'FlightSeatsListView
        '
        Me.FlightSeatsListView.FullRowSelect = true
        Me.FlightSeatsListView.GridLines = true
        Me.FlightSeatsListView.HideSelection = false
        Me.FlightSeatsListView.Location = New System.Drawing.Point(373, 12)
        Me.FlightSeatsListView.Name = "FlightSeatsListView"
        Me.FlightSeatsListView.Size = New System.Drawing.Size(384, 336)
        Me.FlightSeatsListView.TabIndex = 0
        Me.FlightSeatsListView.UseCompatibleStateImageBehavior = false
        Me.FlightSeatsListView.View = System.Windows.Forms.View.Details
        '
        'CurrSeatA
        '
        Me.CurrSeatA.Location = New System.Drawing.Point(12, 415)
        Me.CurrSeatA.Name = "CurrSeatA"
        Me.CurrSeatA.Size = New System.Drawing.Size(39, 23)
        Me.CurrSeatA.TabIndex = 1
        '
        'CurrSeatB
        '
        Me.CurrSeatB.Location = New System.Drawing.Point(57, 415)
        Me.CurrSeatB.Name = "CurrSeatB"
        Me.CurrSeatB.Size = New System.Drawing.Size(39, 23)
        Me.CurrSeatB.TabIndex = 2
        '
        'CurrSeatC
        '
        Me.CurrSeatC.Location = New System.Drawing.Point(102, 415)
        Me.CurrSeatC.Name = "CurrSeatC"
        Me.CurrSeatC.Size = New System.Drawing.Size(39, 23)
        Me.CurrSeatC.TabIndex = 3
        '
        'CurrSeatD
        '
        Me.CurrSeatD.Location = New System.Drawing.Point(147, 415)
        Me.CurrSeatD.Name = "CurrSeatD"
        Me.CurrSeatD.Size = New System.Drawing.Size(39, 23)
        Me.CurrSeatD.TabIndex = 4
        '
        'CurrSeatE
        '
        Me.CurrSeatE.Location = New System.Drawing.Point(192, 415)
        Me.CurrSeatE.Name = "CurrSeatE"
        Me.CurrSeatE.Size = New System.Drawing.Size(39, 23)
        Me.CurrSeatE.TabIndex = 5
        '
        'CurrSeatF
        '
        Me.CurrSeatF.Location = New System.Drawing.Point(237, 415)
        Me.CurrSeatF.Name = "CurrSeatF"
        Me.CurrSeatF.Size = New System.Drawing.Size(39, 23)
        Me.CurrSeatF.TabIndex = 6
        '
        'UpdateRowBtn
        '
        Me.UpdateRowBtn.Location = New System.Drawing.Point(324, 415)
        Me.UpdateRowBtn.Name = "UpdateRowBtn"
        Me.UpdateRowBtn.Size = New System.Drawing.Size(75, 23)
        Me.UpdateRowBtn.TabIndex = 7
        Me.UpdateRowBtn.Text = "Update"
        Me.UpdateRowBtn.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UpdateRowBtn)
        Me.Controls.Add(Me.CurrSeatF)
        Me.Controls.Add(Me.CurrSeatE)
        Me.Controls.Add(Me.CurrSeatD)
        Me.Controls.Add(Me.CurrSeatC)
        Me.Controls.Add(Me.CurrSeatB)
        Me.Controls.Add(Me.CurrSeatA)
        Me.Controls.Add(Me.FlightSeatsListView)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents FlightSeatsListView As ListView
    Friend WithEvents CurrSeatA As TextBox
    Friend WithEvents CurrSeatB As TextBox
    Friend WithEvents CurrSeatC As TextBox
    Friend WithEvents CurrSeatD As TextBox
    Friend WithEvents CurrSeatE As TextBox
    Friend WithEvents CurrSeatF As TextBox
    Friend WithEvents UpdateRowBtn As Button
End Class
