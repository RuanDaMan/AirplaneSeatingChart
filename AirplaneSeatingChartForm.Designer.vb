<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AirplaneSeatingChartForm
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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SeatsFilledLbl = New System.Windows.Forms.Label()
        Me.WindowsAvalLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RegMealLbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LowCalMealLbl = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.VegMealLbl = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RefreshStats = New System.Windows.Forms.Button()
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
        Me.CurrSeatA.ReadOnly = true
        Me.CurrSeatA.Size = New System.Drawing.Size(39, 23)
        Me.CurrSeatA.TabIndex = 1
        Me.CurrSeatA.Tag = "A"
        '
        'CurrSeatB
        '
        Me.CurrSeatB.Location = New System.Drawing.Point(57, 415)
        Me.CurrSeatB.Name = "CurrSeatB"
        Me.CurrSeatB.ReadOnly = true
        Me.CurrSeatB.Size = New System.Drawing.Size(39, 23)
        Me.CurrSeatB.TabIndex = 2
        Me.CurrSeatB.Tag = "B"
        '
        'CurrSeatC
        '
        Me.CurrSeatC.Location = New System.Drawing.Point(102, 415)
        Me.CurrSeatC.Name = "CurrSeatC"
        Me.CurrSeatC.ReadOnly = true
        Me.CurrSeatC.Size = New System.Drawing.Size(39, 23)
        Me.CurrSeatC.TabIndex = 3
        Me.CurrSeatC.Tag = "C"
        '
        'CurrSeatD
        '
        Me.CurrSeatD.Location = New System.Drawing.Point(147, 415)
        Me.CurrSeatD.Name = "CurrSeatD"
        Me.CurrSeatD.ReadOnly = true
        Me.CurrSeatD.Size = New System.Drawing.Size(39, 23)
        Me.CurrSeatD.TabIndex = 4
        Me.CurrSeatD.Tag = "D"
        '
        'CurrSeatE
        '
        Me.CurrSeatE.Location = New System.Drawing.Point(192, 415)
        Me.CurrSeatE.Name = "CurrSeatE"
        Me.CurrSeatE.ReadOnly = true
        Me.CurrSeatE.Size = New System.Drawing.Size(39, 23)
        Me.CurrSeatE.TabIndex = 5
        Me.CurrSeatE.Tag = "E"
        '
        'CurrSeatF
        '
        Me.CurrSeatF.Location = New System.Drawing.Point(237, 415)
        Me.CurrSeatF.Name = "CurrSeatF"
        Me.CurrSeatF.ReadOnly = true
        Me.CurrSeatF.Size = New System.Drawing.Size(39, 23)
        Me.CurrSeatF.TabIndex = 6
        Me.CurrSeatF.Tag = "F"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(54, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Seats Filled:"
        '
        'SeatsFilledLbl
        '
        Me.SeatsFilledLbl.AutoSize = true
        Me.SeatsFilledLbl.Location = New System.Drawing.Point(128, 112)
        Me.SeatsFilledLbl.Name = "SeatsFilledLbl"
        Me.SeatsFilledLbl.Size = New System.Drawing.Size(13, 15)
        Me.SeatsFilledLbl.TabIndex = 8
        Me.SeatsFilledLbl.Text = "0"
        '
        'WindowsAvalLbl
        '
        Me.WindowsAvalLbl.AutoSize = true
        Me.WindowsAvalLbl.Location = New System.Drawing.Point(128, 127)
        Me.WindowsAvalLbl.Name = "WindowsAvalLbl"
        Me.WindowsAvalLbl.Size = New System.Drawing.Size(13, 15)
        Me.WindowsAvalLbl.TabIndex = 10
        Me.WindowsAvalLbl.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(12, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Windows Available:"
        '
        'RegMealLbl
        '
        Me.RegMealLbl.AutoSize = true
        Me.RegMealLbl.Location = New System.Drawing.Point(128, 142)
        Me.RegMealLbl.Name = "RegMealLbl"
        Me.RegMealLbl.Size = New System.Drawing.Size(13, 15)
        Me.RegMealLbl.TabIndex = 12
        Me.RegMealLbl.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(38, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Regular Meals:"
        '
        'LowCalMealLbl
        '
        Me.LowCalMealLbl.AutoSize = true
        Me.LowCalMealLbl.Location = New System.Drawing.Point(128, 157)
        Me.LowCalMealLbl.Name = "LowCalMealLbl"
        Me.LowCalMealLbl.Size = New System.Drawing.Size(13, 15)
        Me.LowCalMealLbl.TabIndex = 14
        Me.LowCalMealLbl.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(16, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Low Calorie Meals:"
        '
        'VegMealLbl
        '
        Me.VegMealLbl.AutoSize = true
        Me.VegMealLbl.Location = New System.Drawing.Point(128, 172)
        Me.VegMealLbl.Name = "VegMealLbl"
        Me.VegMealLbl.Size = New System.Drawing.Size(13, 15)
        Me.VegMealLbl.TabIndex = 16
        Me.VegMealLbl.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(23, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Vegetarian Meals:"
        '
        'RefreshStats
        '
        Me.RefreshStats.Location = New System.Drawing.Point(47, 190)
        Me.RefreshStats.Name = "RefreshStats"
        Me.RefreshStats.Size = New System.Drawing.Size(75, 23)
        Me.RefreshStats.TabIndex = 17
        Me.RefreshStats.Text = "Refresh Statistics"
        Me.RefreshStats.UseVisualStyleBackColor = true
        '
        'AirplaneSeatingChartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RefreshStats)
        Me.Controls.Add(Me.VegMealLbl)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LowCalMealLbl)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RegMealLbl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.WindowsAvalLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SeatsFilledLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CurrSeatF)
        Me.Controls.Add(Me.CurrSeatE)
        Me.Controls.Add(Me.CurrSeatD)
        Me.Controls.Add(Me.CurrSeatC)
        Me.Controls.Add(Me.CurrSeatB)
        Me.Controls.Add(Me.CurrSeatA)
        Me.Controls.Add(Me.FlightSeatsListView)
        Me.Name = "AirplaneSeatingChartForm"
        Me.Text = "Airplane Seating Chart"
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
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents SeatsFilledLbl As Label
    Friend WithEvents WindowsAvalLbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RegMealLbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LowCalMealLbl As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents VegMealLbl As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents RefreshStats As Button
End Class
