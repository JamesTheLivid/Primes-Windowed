<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMainWindow))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.barProgres1 = New System.Windows.Forms.ProgressBar()
        Me.ckboxClearText = New System.Windows.Forms.CheckBox()
        Me.comboFormatingMeth = New System.Windows.Forms.ComboBox()
        Me.lblFormattingMeth = New System.Windows.Forms.Label()
        Me.lblSaveUp = New System.Windows.Forms.Button()
        Me.lblDebug = New System.Windows.Forms.Button()
        Me.lblExit = New System.Windows.Forms.Button()
        Me.lblJamesRobinson = New System.Windows.Forms.Label()
        Me.updownGoOnFor = New System.Windows.Forms.NumericUpDown()
        Me.lblGoOnFor = New System.Windows.Forms.Label()
        Me.updownStartValue = New System.Windows.Forms.NumericUpDown()
        Me.lblStartValue = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.tabOutput = New System.Windows.Forms.TabPage()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.barProgres2 = New System.Windows.Forms.ProgressBar()
        Me.lblOutPut = New System.Windows.Forms.Label()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.tabAbout = New System.Windows.Forms.TabPage()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.lblFileCode = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        CType(Me.updownGoOnFor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownStartValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOutput.SuspendLayout()
        Me.tabAbout.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabSettings)
        Me.TabControl1.Controls.Add(Me.tabOutput)
        Me.TabControl1.Controls.Add(Me.tabAbout)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(694, 438)
        Me.TabControl1.TabIndex = 0
        '
        'tabSettings
        '
        Me.tabSettings.BackColor = System.Drawing.SystemColors.Control
        Me.tabSettings.Controls.Add(Me.btnStart)
        Me.tabSettings.Controls.Add(Me.barProgres1)
        Me.tabSettings.Controls.Add(Me.ckboxClearText)
        Me.tabSettings.Controls.Add(Me.comboFormatingMeth)
        Me.tabSettings.Controls.Add(Me.lblFormattingMeth)
        Me.tabSettings.Controls.Add(Me.lblSaveUp)
        Me.tabSettings.Controls.Add(Me.lblDebug)
        Me.tabSettings.Controls.Add(Me.lblExit)
        Me.tabSettings.Controls.Add(Me.lblJamesRobinson)
        Me.tabSettings.Controls.Add(Me.updownGoOnFor)
        Me.tabSettings.Controls.Add(Me.lblGoOnFor)
        Me.tabSettings.Controls.Add(Me.updownStartValue)
        Me.tabSettings.Controls.Add(Me.lblStartValue)
        Me.tabSettings.Controls.Add(Me.lblName)
        Me.tabSettings.Location = New System.Drawing.Point(4, 22)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSettings.Size = New System.Drawing.Size(686, 412)
        Me.tabSettings.TabIndex = 0
        Me.tabSettings.Text = "Settings"
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(13, 281)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(662, 62)
        Me.btnStart.TabIndex = 13
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'barProgres1
        '
        Me.barProgres1.Location = New System.Drawing.Point(13, 349)
        Me.barProgres1.Name = "barProgres1"
        Me.barProgres1.Size = New System.Drawing.Size(662, 23)
        Me.barProgres1.TabIndex = 12
        '
        'ckboxClearText
        '
        Me.ckboxClearText.AutoSize = True
        Me.ckboxClearText.Location = New System.Drawing.Point(11, 135)
        Me.ckboxClearText.Name = "ckboxClearText"
        Me.ckboxClearText.Size = New System.Drawing.Size(81, 17)
        Me.ckboxClearText.TabIndex = 11
        Me.ckboxClearText.Text = "CheckBox1"
        Me.ckboxClearText.UseVisualStyleBackColor = True
        '
        'comboFormatingMeth
        '
        Me.comboFormatingMeth.FormattingEnabled = True
        Me.comboFormatingMeth.Location = New System.Drawing.Point(11, 102)
        Me.comboFormatingMeth.Name = "comboFormatingMeth"
        Me.comboFormatingMeth.Size = New System.Drawing.Size(250, 21)
        Me.comboFormatingMeth.TabIndex = 10
        '
        'lblFormattingMeth
        '
        Me.lblFormattingMeth.AutoSize = True
        Me.lblFormattingMeth.Location = New System.Drawing.Point(8, 85)
        Me.lblFormattingMeth.Name = "lblFormattingMeth"
        Me.lblFormattingMeth.Size = New System.Drawing.Size(100, 13)
        Me.lblFormattingMeth.TabIndex = 9
        Me.lblFormattingMeth.Text = "Formating Methords"
        '
        'lblSaveUp
        '
        Me.lblSaveUp.Location = New System.Drawing.Point(601, 378)
        Me.lblSaveUp.Name = "lblSaveUp"
        Me.lblSaveUp.Size = New System.Drawing.Size(75, 23)
        Me.lblSaveUp.TabIndex = 8
        Me.lblSaveUp.Text = "Save As ..."
        Me.lblSaveUp.UseVisualStyleBackColor = True
        '
        'lblDebug
        '
        Me.lblDebug.Location = New System.Drawing.Point(94, 378)
        Me.lblDebug.Name = "lblDebug"
        Me.lblDebug.Size = New System.Drawing.Size(75, 23)
        Me.lblDebug.TabIndex = 7
        Me.lblDebug.Text = "Debug"
        Me.lblDebug.UseVisualStyleBackColor = True
        '
        'lblExit
        '
        Me.lblExit.Location = New System.Drawing.Point(13, 378)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(75, 23)
        Me.lblExit.TabIndex = 6
        Me.lblExit.Text = "Exit"
        Me.lblExit.UseVisualStyleBackColor = True
        '
        'lblJamesRobinson
        '
        Me.lblJamesRobinson.AutoSize = True
        Me.lblJamesRobinson.Location = New System.Drawing.Point(575, 12)
        Me.lblJamesRobinson.Name = "lblJamesRobinson"
        Me.lblJamesRobinson.Size = New System.Drawing.Size(100, 13)
        Me.lblJamesRobinson.TabIndex = 5
        Me.lblJamesRobinson.Text = "By James Robinson"
        '
        'updownGoOnFor
        '
        Me.updownGoOnFor.Location = New System.Drawing.Point(141, 55)
        Me.updownGoOnFor.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.updownGoOnFor.Name = "updownGoOnFor"
        Me.updownGoOnFor.Size = New System.Drawing.Size(120, 20)
        Me.updownGoOnFor.TabIndex = 4
        Me.updownGoOnFor.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'lblGoOnFor
        '
        Me.lblGoOnFor.AutoSize = True
        Me.lblGoOnFor.Location = New System.Drawing.Point(138, 39)
        Me.lblGoOnFor.Name = "lblGoOnFor"
        Me.lblGoOnFor.Size = New System.Drawing.Size(56, 13)
        Me.lblGoOnFor.TabIndex = 3
        Me.lblGoOnFor.Text = "Go On For"
        '
        'updownStartValue
        '
        Me.updownStartValue.Location = New System.Drawing.Point(11, 56)
        Me.updownStartValue.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.updownStartValue.Name = "updownStartValue"
        Me.updownStartValue.Size = New System.Drawing.Size(120, 20)
        Me.updownStartValue.TabIndex = 2
        '
        'lblStartValue
        '
        Me.lblStartValue.AutoSize = True
        Me.lblStartValue.Location = New System.Drawing.Point(8, 39)
        Me.lblStartValue.Name = "lblStartValue"
        Me.lblStartValue.Size = New System.Drawing.Size(59, 13)
        Me.lblStartValue.TabIndex = 1
        Me.lblStartValue.Text = "Start Value"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblName.Location = New System.Drawing.Point(8, 12)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(92, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Primes Windowed"
        '
        'tabOutput
        '
        Me.tabOutput.BackColor = System.Drawing.SystemColors.Control
        Me.tabOutput.Controls.Add(Me.lblFileCode)
        Me.tabOutput.Controls.Add(Me.HScrollBar1)
        Me.tabOutput.Controls.Add(Me.barProgres2)
        Me.tabOutput.Controls.Add(Me.lblOutPut)
        Me.tabOutput.Controls.Add(Me.rtbOutput)
        Me.tabOutput.Location = New System.Drawing.Point(4, 22)
        Me.tabOutput.Name = "tabOutput"
        Me.tabOutput.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOutput.Size = New System.Drawing.Size(686, 412)
        Me.tabOutput.TabIndex = 1
        Me.tabOutput.Text = "Output"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(350, 38)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(327, 336)
        Me.HScrollBar1.TabIndex = 3
        '
        'barProgres2
        '
        Me.barProgres2.Location = New System.Drawing.Point(350, 377)
        Me.barProgres2.Name = "barProgres2"
        Me.barProgres2.Size = New System.Drawing.Size(327, 23)
        Me.barProgres2.TabIndex = 2
        '
        'lblOutPut
        '
        Me.lblOutPut.AutoSize = True
        Me.lblOutPut.Location = New System.Drawing.Point(8, 12)
        Me.lblOutPut.Name = "lblOutPut"
        Me.lblOutPut.Size = New System.Drawing.Size(75, 13)
        Me.lblOutPut.TabIndex = 1
        Me.lblOutPut.Text = "Data From File"
        '
        'rtbOutput
        '
        Me.rtbOutput.Location = New System.Drawing.Point(10, 38)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.Size = New System.Drawing.Size(333, 363)
        Me.rtbOutput.TabIndex = 0
        Me.rtbOutput.Text = ""
        '
        'tabAbout
        '
        Me.tabAbout.BackColor = System.Drawing.SystemColors.Control
        Me.tabAbout.Controls.Add(Me.RichTextBox2)
        Me.tabAbout.Controls.Add(Me.RichTextBox1)
        Me.tabAbout.Location = New System.Drawing.Point(4, 22)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Size = New System.Drawing.Size(686, 412)
        Me.tabAbout.TabIndex = 2
        Me.tabAbout.Text = "About"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Location = New System.Drawing.Point(10, 346)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(667, 55)
        Me.RichTextBox2.TabIndex = 1
        Me.RichTextBox2.Text = "(c) Copyright James Robinson 2017" & Global.Microsoft.VisualBasic.ChrW(10) & "All rights reserved" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "If you would like to use t" &
    "his program please contact James Robinson on GitHub (link above)"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(10, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(667, 138)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "Primes Windowed - Alpha 0.0.1" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "A program that finds prime numbers by moding every" &
    " 2 numbers by half of its self. For more information go to https://github.com/Ja" &
    "mesTheLivid/Primes-Windowed" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'lblFileCode
        '
        Me.lblFileCode.AutoSize = True
        Me.lblFileCode.Location = New System.Drawing.Point(90, 11)
        Me.lblFileCode.Name = "lblFileCode"
        Me.lblFileCode.Size = New System.Drawing.Size(57, 13)
        Me.lblFileCode.TabIndex = 4
        Me.lblFileCode.Text = "File Code: "
        '
        'formMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 435)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formMainWindow"
        Me.Text = "Primes Windowed -- Alpha 0.0.1"
        Me.TabControl1.ResumeLayout(False)
        Me.tabSettings.ResumeLayout(False)
        Me.tabSettings.PerformLayout()
        CType(Me.updownGoOnFor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownStartValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOutput.ResumeLayout(False)
        Me.tabOutput.PerformLayout()
        Me.tabAbout.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabSettings As TabPage
    Friend WithEvents tabOutput As TabPage
    Friend WithEvents updownGoOnFor As NumericUpDown
    Friend WithEvents lblGoOnFor As Label
    Friend WithEvents updownStartValue As NumericUpDown
    Friend WithEvents lblStartValue As Label
    Friend WithEvents lblName As Label
    Friend WithEvents tabAbout As TabPage
    Friend WithEvents lblSaveUp As Button
    Friend WithEvents lblDebug As Button
    Friend WithEvents lblExit As Button
    Friend WithEvents lblJamesRobinson As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents comboFormatingMeth As ComboBox
    Friend WithEvents lblFormattingMeth As Label
    Friend WithEvents barProgres1 As ProgressBar
    Friend WithEvents ckboxClearText As CheckBox
    Friend WithEvents btnStart As Button
    Friend WithEvents barProgres2 As ProgressBar
    Friend WithEvents lblOutPut As Label
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents lblFileCode As Label
End Class
