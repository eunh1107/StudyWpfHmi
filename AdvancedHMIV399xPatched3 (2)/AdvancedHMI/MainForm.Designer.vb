<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
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
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QuickStartLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LicenseNote = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.ModbusTCPCom1 = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.Tank1 = New AdvancedHMIControls.Tank()
        Me.WaterPump1 = New AdvancedHMIControls.WaterPump()
        Me.Pipe1 = New AdvancedHMIControls.Pipe()
        Me.Gauge1 = New AdvancedHMIControls.Gauge()
        Me.Pipe2 = New AdvancedHMIControls.Pipe()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 620)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'QuickStartLabel
        '
        Me.QuickStartLabel.AutoSize = True
        Me.QuickStartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.QuickStartLabel.ForeColor = System.Drawing.Color.White
        Me.QuickStartLabel.Location = New System.Drawing.Point(9, 16)
        Me.QuickStartLabel.Name = "QuickStartLabel"
        Me.QuickStartLabel.Size = New System.Drawing.Size(350, 136)
        Me.QuickStartLabel.TabIndex = 38
        Me.QuickStartLabel.Text = resources.GetString("QuickStartLabel.Text")
        Me.QuickStartLabel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(752, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 47)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'LicenseNote
        '
        Me.LicenseNote.AutoSize = True
        Me.LicenseNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicenseNote.ForeColor = System.Drawing.Color.White
        Me.LicenseNote.Location = New System.Drawing.Point(12, 281)
        Me.LicenseNote.Name = "LicenseNote"
        Me.LicenseNote.Size = New System.Drawing.Size(923, 40)
        Me.LicenseNote.TabIndex = 54
        Me.LicenseNote.Text = "By Using This Software You Agree to the UsageAndLicense.txt" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AdvancedHMI is licen" &
    "sed under a GPL model which means you must pass on the full source to the end us" &
    "er."
        Me.LicenseNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LicenseNote.Visible = False
        '
        'ModbusTCPCom1
        '
        Me.ModbusTCPCom1.DisableSubscriptions = False
        Me.ModbusTCPCom1.IniFileName = ""
        Me.ModbusTCPCom1.IniFileSection = Nothing
        Me.ModbusTCPCom1.IPAddress = "172.20.10.2"
        Me.ModbusTCPCom1.MaxReadGroupSize = 20
        Me.ModbusTCPCom1.PollRateOverride = 500
        Me.ModbusTCPCom1.SwapBytes = True
        Me.ModbusTCPCom1.SwapWords = False
        Me.ModbusTCPCom1.TcpipPort = CType(502US, UShort)
        Me.ModbusTCPCom1.TimeOut = 3000
        Me.ModbusTCPCom1.UnitId = CType(1, Byte)
        '
        'Tank1
        '
        Me.Tank1.ComComponent = Me.ModbusTCPCom1
        Me.Tank1.HighlightColor = System.Drawing.Color.Red
        Me.Tank1.HighlightKeyCharacter = "!"
        Me.Tank1.KeypadText = Nothing
        Me.Tank1.Location = New System.Drawing.Point(288, 281)
        Me.Tank1.MaxValue = 100
        Me.Tank1.MinValue = 0
        Me.Tank1.Name = "Tank1"
        Me.Tank1.NumericFormat = Nothing
        Me.Tank1.PLCAddressKeypad = ""
        Me.Tank1.PLCAddressText = ""
        Me.Tank1.PLCAddressValue = "400016"
        Me.Tank1.PLCAddressVisible = ""
        Me.Tank1.ScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Tank1.Size = New System.Drawing.Size(131, 150)
        Me.Tank1.TabIndex = 55
        Me.Tank1.TankContentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Tank1.Text = "Tank1"
        Me.Tank1.TextPrefix = Nothing
        Me.Tank1.TextSuffix = Nothing
        Me.Tank1.Value = 0!
        Me.Tank1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'WaterPump1
        '
        Me.WaterPump1.ComComponent = Me.ModbusTCPCom1
        Me.WaterPump1.Location = New System.Drawing.Point(63, 300)
        Me.WaterPump1.Name = "WaterPump1"
        Me.WaterPump1.PLCAddressText = ""
        Me.WaterPump1.PLCAddressValue = "000016"
        Me.WaterPump1.PLCAddressVisible = ""
        Me.WaterPump1.Size = New System.Drawing.Size(165, 91)
        Me.WaterPump1.TabIndex = 56
        Me.WaterPump1.Text = "WaterPump1"
        Me.WaterPump1.Value = False
        '
        'Pipe1
        '
        Me.Pipe1.ComComponent = Me.ModbusTCPCom1
        Me.Pipe1.Fitting = MfgControl.AdvancedHMI.Controls.Pipe.FittingType.Straight
        Me.Pipe1.HighlightColor = System.Drawing.Color.Red
        Me.Pipe1.HighlightKeyCharacter = "!"
        Me.Pipe1.KeypadText = Nothing
        Me.Pipe1.Location = New System.Drawing.Point(224, 334)
        Me.Pipe1.Name = "Pipe1"
        Me.Pipe1.NumericFormat = Nothing
        Me.Pipe1.PLCAddressKeypad = ""
        Me.Pipe1.PLCAddressRotate = ""
        Me.Pipe1.PLCAddressText = ""
        Me.Pipe1.PLCAddressVisible = ""
        Me.Pipe1.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.Pipe1.ScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Pipe1.Size = New System.Drawing.Size(75, 23)
        Me.Pipe1.TabIndex = 57
        Me.Pipe1.Text = "Pipe1"
        Me.Pipe1.TextPrefix = Nothing
        Me.Pipe1.TextSuffix = Nothing
        '
        'Gauge1
        '
        Me.Gauge1.AllowDragging = False
        Me.Gauge1.BackColor = System.Drawing.Color.Transparent
        Me.Gauge1.ComComponent = Me.ModbusTCPCom1
        Me.Gauge1.HighlightColor = System.Drawing.Color.Red
        Me.Gauge1.Location = New System.Drawing.Point(474, 316)
        Me.Gauge1.Maximum = 100
        Me.Gauge1.Minimum = 0
        Me.Gauge1.Name = "Gauge1"
        Me.Gauge1.NumericFormat = Nothing
        Me.Gauge1.PLCAddressText = ""
        Me.Gauge1.PLCAddressValue = "400015"
        Me.Gauge1.PLCAddressVisible = ""
        Me.Gauge1.Size = New System.Drawing.Size(75, 75)
        Me.Gauge1.TabIndex = 58
        Me.Gauge1.Text = "Gauge1"
        Me.Gauge1.Value = 0R
        Me.Gauge1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Pipe2
        '
        Me.Pipe2.ComComponent = Me.ModbusTCPCom1
        Me.Pipe2.Fitting = MfgControl.AdvancedHMI.Controls.Pipe.FittingType.Straight
        Me.Pipe2.HighlightColor = System.Drawing.Color.Red
        Me.Pipe2.HighlightKeyCharacter = "!"
        Me.Pipe2.KeypadText = Nothing
        Me.Pipe2.Location = New System.Drawing.Point(404, 334)
        Me.Pipe2.Name = "Pipe2"
        Me.Pipe2.NumericFormat = Nothing
        Me.Pipe2.PLCAddressKeypad = ""
        Me.Pipe2.PLCAddressRotate = ""
        Me.Pipe2.PLCAddressText = ""
        Me.Pipe2.PLCAddressVisible = ""
        Me.Pipe2.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone
        Me.Pipe2.ScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Pipe2.Size = New System.Drawing.Size(75, 23)
        Me.Pipe2.TabIndex = 59
        Me.Pipe2.TextPrefix = Nothing
        Me.Pipe2.TextSuffix = Nothing
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Pipe2)
        Me.Controls.Add(Me.Gauge1)
        Me.Controls.Add(Me.Pipe1)
        Me.Controls.Add(Me.WaterPump1)
        Me.Controls.Add(Me.Tank1)
        Me.Controls.Add(Me.LicenseNote)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.QuickStartLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AdvancedHMI v3.99x-Patched3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QuickStartLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents LicenseNote As Label
    Friend WithEvents ModbusTCPCom1 As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents Tank1 As AdvancedHMIControls.Tank
    Friend WithEvents WaterPump1 As AdvancedHMIControls.WaterPump
    Friend WithEvents Pipe1 As AdvancedHMIControls.Pipe
    Friend WithEvents Gauge1 As AdvancedHMIControls.Gauge
    Friend WithEvents Pipe2 As AdvancedHMIControls.Pipe
End Class
