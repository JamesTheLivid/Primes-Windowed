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
        Me.tabOutput = New System.Windows.Forms.TabPage()
        Me.tabAbout = New System.Windows.Forms.TabPage()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblStartValue = New System.Windows.Forms.Label()
        Me.updownStartValue = New System.Windows.Forms.NumericUpDown()
        Me.lblGoOnFor = New System.Windows.Forms.Label()
        Me.updownGoOnFor = New System.Windows.Forms.NumericUpDown()
        Me.lblJamesRobinson = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Button()
        Me.lblDebug = New System.Windows.Forms.Button()
        Me.lblSaveUp = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TabControl1.SuspendLayout()
        Me.tabSettings.SuspendLayout()
        Me.tabAbout.SuspendLayout()
        CType(Me.updownStartValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownGoOnFor, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'tabOutput
        '
        Me.tabOutput.BackColor = System.Drawing.SystemColors.Control
        Me.tabOutput.Location = New System.Drawing.Point(4, 22)
        Me.tabOutput.Name = "tabOutput"
        Me.tabOutput.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOutput.Size = New System.Drawing.Size(686, 412)
        Me.tabOutput.TabIndex = 1
        Me.tabOutput.Text = "Output"
        '
        'tabAbout
        '
        Me.tabAbout.BackColor = System.Drawing.SystemColors.Control
        Me.tabAbout.Controls.Add(Me.RichTextBox1)
        Me.tabAbout.Location = New System.Drawing.Point(4, 22)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Size = New System.Drawing.Size(686, 412)
        Me.tabAbout.TabIndex = 2
        Me.tabAbout.Text = "About"
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
        'lblStartValue
        '
        Me.lblStartValue.AutoSize = True
        Me.lblStartValue.Location = New System.Drawing.Point(8, 39)
        Me.lblStartValue.Name = "lblStartValue"
        Me.lblStartValue.Size = New System.Drawing.Size(59, 13)
        Me.lblStartValue.TabIndex = 1
        Me.lblStartValue.Text = "Start Value"
        '
        'updownStartValue
        '
        Me.updownStartValue.Location = New System.Drawing.Point(11, 56)
        Me.updownStartValue.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.updownStartValue.Name = "updownStartValue"
        Me.updownStartValue.Size = New System.Drawing.Size(120, 20)
        Me.updownStartValue.TabIndex = 2
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
        'updownGoOnFor
        '
        Me.updownGoOnFor.Location = New System.Drawing.Point(141, 55)
        Me.updownGoOnFor.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.updownGoOnFor.Name = "updownGoOnFor"
        Me.updownGoOnFor.Size = New System.Drawing.Size(120, 20)
        Me.updownGoOnFor.TabIndex = 4
        Me.updownGoOnFor.Value = New Decimal(New Integer() {100, 0, 0, 0})
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
        'lblExit
        '
        Me.lblExit.Location = New System.Drawing.Point(13, 378)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(75, 23)
        Me.lblExit.TabIndex = 6
        Me.lblExit.Text = "Exit"
        Me.lblExit.UseVisualStyleBackColor = True
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
        'lblSaveUp
        '
        Me.lblSaveUp.Location = New System.Drawing.Point(601, 378)
        Me.lblSaveUp.Name = "lblSaveUp"
        Me.lblSaveUp.Size = New System.Drawing.Size(75, 23)
        Me.lblSaveUp.TabIndex = 8
        Me.lblSaveUp.Text = "Save As ..."
        Me.lblSaveUp.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(10, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(667, 389)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "Primes Windowed - Alpha 0.0.1" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "A program that finds prime numbers by moding every" &
    " 2 numbers by half of its self. For more information go to " & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.tabAbout.ResumeLayout(False)
        CType(Me.updownStartValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownGoOnFor, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
