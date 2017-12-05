<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblJames = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblStartVal = New System.Windows.Forms.Label()
        Me.lblEndVal = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDebug = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmBoxFormattingMeth = New System.Windows.Forms.ComboBox()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.updwnStartValue = New System.Windows.Forms.NumericUpDown()
        Me.updwnGoOnFor = New System.Windows.Forms.NumericUpDown()
        Me.ckboxClear = New System.Windows.Forms.CheckBox()
        Me.btnSaveAs = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.tabOutput = New System.Windows.Forms.TabPage()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.rtbOutputBox = New System.Windows.Forms.RichTextBox()
        Me.tabAbout = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.updwnStartValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updwnGoOnFor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        Me.tabOutput.SuspendLayout()
        Me.tabAbout.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(92, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Primes Windowed"
        '
        'lblJames
        '
        Me.lblJames.AutoSize = True
        Me.lblJames.Location = New System.Drawing.Point(579, 3)
        Me.lblJames.Name = "lblJames"
        Me.lblJames.Size = New System.Drawing.Size(100, 13)
        Me.lblJames.TabIndex = 1
        Me.lblJames.Text = "By James Robinson"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(9, 363)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(107, 13)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Version 0.0.1 ALPHA"
        '
        'lblStartVal
        '
        Me.lblStartVal.AutoSize = True
        Me.lblStartVal.Location = New System.Drawing.Point(15, 28)
        Me.lblStartVal.Name = "lblStartVal"
        Me.lblStartVal.Size = New System.Drawing.Size(59, 13)
        Me.lblStartVal.TabIndex = 4
        Me.lblStartVal.Text = "Start Value"
        '
        'lblEndVal
        '
        Me.lblEndVal.AutoSize = True
        Me.lblEndVal.Location = New System.Drawing.Point(139, 28)
        Me.lblEndVal.Name = "lblEndVal"
        Me.lblEndVal.Size = New System.Drawing.Size(56, 13)
        Me.lblEndVal.TabIndex = 7
        Me.lblEndVal.Text = "Go On For"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 380)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDebug
        '
        Me.btnDebug.Location = New System.Drawing.Point(93, 380)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(75, 23)
        Me.btnDebug.TabIndex = 9
        Me.btnDebug.Text = "Debug"
        Me.btnDebug.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Formatting Methords"
        '
        'cmBoxFormattingMeth
        '
        Me.cmBoxFormattingMeth.FormattingEnabled = True
        Me.cmBoxFormattingMeth.Location = New System.Drawing.Point(18, 98)
        Me.cmBoxFormattingMeth.Name = "cmBoxFormattingMeth"
        Me.cmBoxFormattingMeth.Size = New System.Drawing.Size(221, 21)
        Me.cmBoxFormattingMeth.TabIndex = 11
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(6, 332)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(668, 23)
        Me.ProgressBar.TabIndex = 12
        '
        'updwnStartValue
        '
        Me.updwnStartValue.Location = New System.Drawing.Point(18, 44)
        Me.updwnStartValue.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.updwnStartValue.Name = "updwnStartValue"
        Me.updwnStartValue.Size = New System.Drawing.Size(115, 20)
        Me.updwnStartValue.TabIndex = 14
        '
        'updwnGoOnFor
        '
        Me.updwnGoOnFor.Location = New System.Drawing.Point(142, 43)
        Me.updwnGoOnFor.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.updwnGoOnFor.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.updwnGoOnFor.Name = "updwnGoOnFor"
        Me.updwnGoOnFor.Size = New System.Drawing.Size(115, 20)
        Me.updwnGoOnFor.TabIndex = 15
        Me.updwnGoOnFor.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'ckboxClear
        '
        Me.ckboxClear.AutoSize = True
        Me.ckboxClear.Location = New System.Drawing.Point(18, 137)
        Me.ckboxClear.Name = "ckboxClear"
        Me.ckboxClear.Size = New System.Drawing.Size(141, 17)
        Me.ckboxClear.TabIndex = 16
        Me.ckboxClear.Text = "Clear Text At Next Run?"
        Me.ckboxClear.UseVisualStyleBackColor = True
        '
        'btnSaveAs
        '
        Me.btnSaveAs.Location = New System.Drawing.Point(604, 378)
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveAs.TabIndex = 17
        Me.btnSaveAs.Text = "Save As ..."
        Me.btnSaveAs.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabSettings)
        Me.TabControl1.Controls.Add(Me.tabOutput)
        Me.TabControl1.Controls.Add(Me.tabAbout)
        Me.TabControl1.Location = New System.Drawing.Point(-2, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(697, 437)
        Me.TabControl1.TabIndex = 18
        '
        'tabSettings
        '
        Me.tabSettings.BackColor = System.Drawing.SystemColors.Control
        Me.tabSettings.Controls.Add(Me.lblTitle)
        Me.tabSettings.Controls.Add(Me.btnSaveAs)
        Me.tabSettings.Controls.Add(Me.lblJames)
        Me.tabSettings.Controls.Add(Me.ckboxClear)
        Me.tabSettings.Controls.Add(Me.lblVersion)
        Me.tabSettings.Controls.Add(Me.updwnGoOnFor)
        Me.tabSettings.Controls.Add(Me.updwnStartValue)
        Me.tabSettings.Controls.Add(Me.lblStartVal)
        Me.tabSettings.Controls.Add(Me.ProgressBar)
        Me.tabSettings.Controls.Add(Me.lblEndVal)
        Me.tabSettings.Controls.Add(Me.cmBoxFormattingMeth)
        Me.tabSettings.Controls.Add(Me.btnExit)
        Me.tabSettings.Controls.Add(Me.Label1)
        Me.tabSettings.Controls.Add(Me.btnDebug)
        Me.tabSettings.Location = New System.Drawing.Point(4, 22)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSettings.Size = New System.Drawing.Size(689, 411)
        Me.tabSettings.TabIndex = 0
        Me.tabSettings.Text = "Settings"
        '
        'tabOutput
        '
        Me.tabOutput.BackColor = System.Drawing.SystemColors.Control
        Me.tabOutput.Controls.Add(Me.rtbOutputBox)
        Me.tabOutput.Location = New System.Drawing.Point(4, 22)
        Me.tabOutput.Name = "tabOutput"
        Me.tabOutput.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOutput.Size = New System.Drawing.Size(689, 411)
        Me.tabOutput.TabIndex = 1
        Me.tabOutput.Text = "Output"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'rtbOutputBox
        '
        Me.rtbOutputBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbOutputBox.Location = New System.Drawing.Point(10, 6)
        Me.rtbOutputBox.Name = "rtbOutputBox"
        Me.rtbOutputBox.Size = New System.Drawing.Size(668, 395)
        Me.rtbOutputBox.TabIndex = 4
        Me.rtbOutputBox.Text = "Start Max         : 100,000,000,000" & Global.Microsoft.VisualBasic.ChrW(10) & "Go on For Max :     1,000,000,000"
        '
        'tabAbout
        '
        Me.tabAbout.BackColor = System.Drawing.SystemColors.Control
        Me.tabAbout.Controls.Add(Me.RichTextBox1)
        Me.tabAbout.Location = New System.Drawing.Point(4, 22)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAbout.Size = New System.Drawing.Size(689, 411)
        Me.tabAbout.TabIndex = 2
        Me.tabAbout.Text = "About"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(14, 14)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(664, 387)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = "Primes Windowed - Alpha 0.0.1" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "A program that finds prime numbers by moding every" &
    " 2 numbers by half of its self. For more information go to "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(692, 435)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Primes Windowed -- Alpha 0.0.1"
        CType(Me.updwnStartValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updwnGoOnFor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabSettings.ResumeLayout(False)
        Me.tabSettings.PerformLayout()
        Me.tabOutput.ResumeLayout(False)
        Me.tabAbout.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblJames As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblStartVal As Label
    Friend WithEvents lblEndVal As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDebug As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmBoxFormattingMeth As ComboBox
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents updwnStartValue As NumericUpDown
    Friend WithEvents updwnGoOnFor As NumericUpDown
    Friend WithEvents ckboxClear As CheckBox
    Friend WithEvents btnSaveAs As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabSettings As TabPage
    Friend WithEvents tabOutput As TabPage
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents rtbOutputBox As RichTextBox
    Friend WithEvents tabAbout As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
