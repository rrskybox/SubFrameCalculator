<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubFrameCalculatorForm
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
        Me.components = New System.ComponentModel.Container()
        Me.GainBox = New System.Windows.Forms.NumericUpDown()
        Me.GainLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RNoiseBox = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaxNoiseBox = New System.Windows.Forms.NumericUpDown()
        Me.SLambdaLabel = New System.Windows.Forms.Label()
        Me.SLambdaBox = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SNRTgtBox = New System.Windows.Forms.NumericUpDown()
        Me.ImageButton = New System.Windows.Forms.Button()
        Me.AnalyzeButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SmExpLabel = New System.Windows.Forms.Label()
        Me.AnExpLabel = New System.Windows.Forms.Label()
        Me.CaExpLabel = New System.Windows.Forms.Label()
        Me.SmExpCntLabel = New System.Windows.Forms.Label()
        Me.AnExpCntLabel = New System.Windows.Forms.Label()
        Me.CaExpCntLabel = New System.Windows.Forms.Label()
        Me.FiltersLabel = New System.Windows.Forms.Label()
        Me.filtersBox = New System.Windows.Forms.NumericUpDown()
        Me.AvailableHoursLabel = New System.Windows.Forms.Label()
        Me.AvailableHoursBox = New System.Windows.Forms.NumericUpDown()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OverviewButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.GainBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RNoiseBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxNoiseBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SLambdaBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SNRTgtBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.filtersBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvailableHoursBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GainBox
        '
        Me.GainBox.DecimalPlaces = 2
        Me.GainBox.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.GainBox.Location = New System.Drawing.Point(230, 48)
        Me.GainBox.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.GainBox.Name = "GainBox"
        Me.GainBox.Size = New System.Drawing.Size(61, 20)
        Me.GainBox.TabIndex = 0
        '
        'GainLabel
        '
        Me.GainLabel.AutoSize = True
        Me.GainLabel.Location = New System.Drawing.Point(82, 50)
        Me.GainLabel.Name = "GainLabel"
        Me.GainLabel.Size = New System.Drawing.Size(80, 13)
        Me.GainLabel.TabIndex = 1
        Me.GainLabel.Text = "CCD ADU Gain"
        Me.ToolTip1.SetToolTip(Me.GainLabel, "SBIG STF8300M = .37" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SBIG STXL11002 = .87")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CCD Read Noise"
        Me.ToolTip1.SetToolTip(Me.Label1, "SBIG STF8300M = 9.3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SBIG STXL11002 = 11")
        '
        'RNoiseBox
        '
        Me.RNoiseBox.DecimalPlaces = 1
        Me.RNoiseBox.Location = New System.Drawing.Point(230, 74)
        Me.RNoiseBox.Name = "RNoiseBox"
        Me.RNoiseBox.Size = New System.Drawing.Size(61, 20)
        Me.RNoiseBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Maximum Read Noise % (Smith Model)"
        '
        'MaxNoiseBox
        '
        Me.MaxNoiseBox.Location = New System.Drawing.Point(237, 25)
        Me.MaxNoiseBox.Name = "MaxNoiseBox"
        Me.MaxNoiseBox.Size = New System.Drawing.Size(46, 20)
        Me.MaxNoiseBox.TabIndex = 4
        Me.MaxNoiseBox.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'SLambdaLabel
        '
        Me.SLambdaLabel.AutoSize = True
        Me.SLambdaLabel.Location = New System.Drawing.Point(8, 53)
        Me.SLambdaLabel.Name = "SLambdaLabel"
        Me.SLambdaLabel.Size = New System.Drawing.Size(207, 13)
        Me.SLambdaLabel.TabIndex = 9
        Me.SLambdaLabel.Text = "Minimum Faint Target ADU (Anstey Model)"
        '
        'SLambdaBox
        '
        Me.SLambdaBox.Location = New System.Drawing.Point(237, 51)
        Me.SLambdaBox.Name = "SLambdaBox"
        Me.SLambdaBox.Size = New System.Drawing.Size(46, 20)
        Me.SLambdaBox.TabIndex = 8
        Me.SLambdaBox.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(219, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Maximum Fraction of SNR (Cannestra Model)"
        '
        'SNRTgtBox
        '
        Me.SNRTgtBox.DecimalPlaces = 2
        Me.SNRTgtBox.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.SNRTgtBox.Location = New System.Drawing.Point(233, 78)
        Me.SNRTgtBox.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SNRTgtBox.Name = "SNRTgtBox"
        Me.SNRTgtBox.Size = New System.Drawing.Size(50, 20)
        Me.SNRTgtBox.TabIndex = 10
        Me.SNRTgtBox.Value = New Decimal(New Integer() {9, 0, 0, 65536})
        '
        'ImageButton
        '
        Me.ImageButton.Location = New System.Drawing.Point(111, 12)
        Me.ImageButton.Name = "ImageButton"
        Me.ImageButton.Size = New System.Drawing.Size(75, 23)
        Me.ImageButton.TabIndex = 12
        Me.ImageButton.Text = "Image"
        Me.ToolTip1.SetToolTip(Me.ImageButton, "Image prompts TSX to take a 60 second image using" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "using the current filter.  Aut" & _
        "odark is also turned on," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "so the whole process may take over 2 minutes -- be pat" & _
        "ient.")
        Me.ImageButton.UseVisualStyleBackColor = True
        '
        'AnalyzeButton
        '
        Me.AnalyzeButton.Location = New System.Drawing.Point(208, 12)
        Me.AnalyzeButton.Name = "AnalyzeButton"
        Me.AnalyzeButton.Size = New System.Drawing.Size(75, 23)
        Me.AnalyzeButton.TabIndex = 13
        Me.AnalyzeButton.Text = "Analyze"
        Me.AnalyzeButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(200, 400)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 14
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Smith"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Anstey"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Cannestra"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(94, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Exposure (sec)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(182, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Reps/Filter/Session"
        '
        'SmExpLabel
        '
        Me.SmExpLabel.AutoSize = True
        Me.SmExpLabel.Location = New System.Drawing.Point(109, 319)
        Me.SmExpLabel.Name = "SmExpLabel"
        Me.SmExpLabel.Size = New System.Drawing.Size(29, 13)
        Me.SmExpLabel.TabIndex = 20
        Me.SmExpLabel.Text = "TBD"
        '
        'AnExpLabel
        '
        Me.AnExpLabel.AutoSize = True
        Me.AnExpLabel.Location = New System.Drawing.Point(109, 342)
        Me.AnExpLabel.Name = "AnExpLabel"
        Me.AnExpLabel.Size = New System.Drawing.Size(29, 13)
        Me.AnExpLabel.TabIndex = 21
        Me.AnExpLabel.Text = "TBD"
        '
        'CaExpLabel
        '
        Me.CaExpLabel.AutoSize = True
        Me.CaExpLabel.Location = New System.Drawing.Point(109, 367)
        Me.CaExpLabel.Name = "CaExpLabel"
        Me.CaExpLabel.Size = New System.Drawing.Size(29, 13)
        Me.CaExpLabel.TabIndex = 22
        Me.CaExpLabel.Text = "TBD"
        '
        'SmExpCntLabel
        '
        Me.SmExpCntLabel.AutoSize = True
        Me.SmExpCntLabel.Location = New System.Drawing.Point(216, 319)
        Me.SmExpCntLabel.Name = "SmExpCntLabel"
        Me.SmExpCntLabel.Size = New System.Drawing.Size(29, 13)
        Me.SmExpCntLabel.TabIndex = 23
        Me.SmExpCntLabel.Text = "TBD"
        '
        'AnExpCntLabel
        '
        Me.AnExpCntLabel.AutoSize = True
        Me.AnExpCntLabel.Location = New System.Drawing.Point(216, 342)
        Me.AnExpCntLabel.Name = "AnExpCntLabel"
        Me.AnExpCntLabel.Size = New System.Drawing.Size(29, 13)
        Me.AnExpCntLabel.TabIndex = 24
        Me.AnExpCntLabel.Text = "TBD"
        '
        'CaExpCntLabel
        '
        Me.CaExpCntLabel.AutoSize = True
        Me.CaExpCntLabel.Location = New System.Drawing.Point(216, 367)
        Me.CaExpCntLabel.Name = "CaExpCntLabel"
        Me.CaExpCntLabel.Size = New System.Drawing.Size(29, 13)
        Me.CaExpCntLabel.TabIndex = 25
        Me.CaExpCntLabel.Text = "TBD"
        Me.CaExpCntLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'FiltersLabel
        '
        Me.FiltersLabel.AutoSize = True
        Me.FiltersLabel.Location = New System.Drawing.Point(82, 102)
        Me.FiltersLabel.Name = "FiltersLabel"
        Me.FiltersLabel.Size = New System.Drawing.Size(34, 13)
        Me.FiltersLabel.TabIndex = 27
        Me.FiltersLabel.Text = "Filters"
        '
        'filtersBox
        '
        Me.filtersBox.Location = New System.Drawing.Point(230, 100)
        Me.filtersBox.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.filtersBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.filtersBox.Name = "filtersBox"
        Me.filtersBox.Size = New System.Drawing.Size(61, 20)
        Me.filtersBox.TabIndex = 26
        Me.filtersBox.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'AvailableHoursLabel
        '
        Me.AvailableHoursLabel.AutoSize = True
        Me.AvailableHoursLabel.Location = New System.Drawing.Point(82, 128)
        Me.AvailableHoursLabel.Name = "AvailableHoursLabel"
        Me.AvailableHoursLabel.Size = New System.Drawing.Size(129, 13)
        Me.AvailableHoursLabel.TabIndex = 29
        Me.AvailableHoursLabel.Text = "Desired Hours for Session"
        '
        'AvailableHoursBox
        '
        Me.AvailableHoursBox.Location = New System.Drawing.Point(230, 128)
        Me.AvailableHoursBox.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.AvailableHoursBox.Name = "AvailableHoursBox"
        Me.AvailableHoursBox.Size = New System.Drawing.Size(61, 20)
        Me.AvailableHoursBox.TabIndex = 28
        Me.AvailableHoursBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'OverviewButton
        '
        Me.OverviewButton.Location = New System.Drawing.Point(8, 12)
        Me.OverviewButton.Name = "OverviewButton"
        Me.OverviewButton.Size = New System.Drawing.Size(75, 23)
        Me.OverviewButton.TabIndex = 30
        Me.OverviewButton.Text = "Overview"
        Me.OverviewButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.SNRTgtBox)
        Me.GroupBox1.Controls.Add(Me.SLambdaLabel)
        Me.GroupBox1.Controls.Add(Me.SLambdaBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.MaxNoiseBox)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 116)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Optimization Targets"
        '
        'SubFrameCalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 435)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OverviewButton)
        Me.Controls.Add(Me.AvailableHoursLabel)
        Me.Controls.Add(Me.AvailableHoursBox)
        Me.Controls.Add(Me.FiltersLabel)
        Me.Controls.Add(Me.filtersBox)
        Me.Controls.Add(Me.CaExpCntLabel)
        Me.Controls.Add(Me.AnExpCntLabel)
        Me.Controls.Add(Me.SmExpCntLabel)
        Me.Controls.Add(Me.CaExpLabel)
        Me.Controls.Add(Me.AnExpLabel)
        Me.Controls.Add(Me.SmExpLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.AnalyzeButton)
        Me.Controls.Add(Me.ImageButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RNoiseBox)
        Me.Controls.Add(Me.GainLabel)
        Me.Controls.Add(Me.GainBox)
        Me.Name = "SubFrameCalculatorForm"
        Me.Text = "SubFrame Calculator (V1.0)"
        CType(Me.GainBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RNoiseBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxNoiseBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SLambdaBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SNRTgtBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.filtersBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvailableHoursBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GainBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents GainLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RNoiseBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MaxNoiseBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents SLambdaLabel As System.Windows.Forms.Label
    Friend WithEvents SLambdaBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SNRTgtBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents ImageButton As System.Windows.Forms.Button
    Friend WithEvents AnalyzeButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SmExpLabel As System.Windows.Forms.Label
    Friend WithEvents AnExpLabel As System.Windows.Forms.Label
    Friend WithEvents CaExpLabel As System.Windows.Forms.Label
    Friend WithEvents SmExpCntLabel As System.Windows.Forms.Label
    Friend WithEvents AnExpCntLabel As System.Windows.Forms.Label
    Friend WithEvents CaExpCntLabel As System.Windows.Forms.Label
    Friend WithEvents FiltersLabel As System.Windows.Forms.Label
    Friend WithEvents filtersBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents AvailableHoursLabel As System.Windows.Forms.Label
    Friend WithEvents AvailableHoursBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OverviewButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
