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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Result = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Solver = New System.Windows.Forms.LinkLabel()
        Me.Quardic = New System.Windows.Forms.LinkLabel()
        Me.aBox = New System.Windows.Forms.TextBox()
        Me.bBox = New System.Windows.Forms.TextBox()
        Me.cBox = New System.Windows.Forms.TextBox()
        Me.aLabel = New System.Windows.Forms.Label()
        Me.bLabel = New System.Windows.Forms.Label()
        Me.cLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.solutionsLabel = New System.Windows.Forms.Label()
        Me.Process1 = New System.Diagnostics.Process()
        Me.TrainLabel = New System.Windows.Forms.LinkLabel()
        Me.RandomEquation = New System.Windows.Forms.Button()
        Me.EquationLabel = New System.Windows.Forms.Label()
        Me.UserAnswer = New System.Windows.Forms.TextBox()
        Me.FeedBackLabel = New System.Windows.Forms.Label()
        Me.CheckButton = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LevelLabel = New System.Windows.Forms.Label()
        Me.Settings = New System.Windows.Forms.LinkLabel()
        Me.NumScrollMax = New System.Windows.Forms.NumericUpDown()
        Me.NumScrollMin = New System.Windows.Forms.NumericUpDown()
        Me.biggestCoefLabel = New System.Windows.Forms.Label()
        Me.smallestCoefLabel = New System.Windows.Forms.Label()
        Me.digitsLabel = New System.Windows.Forms.Label()
        Me.ScrollNumDigits = New System.Windows.Forms.NumericUpDown()
        Me.maxLengthLabel = New System.Windows.Forms.Label()
        Me.minLengthLabel = New System.Windows.Forms.Label()
        Me.ScrollMaxLength = New System.Windows.Forms.NumericUpDown()
        Me.ScrollMinLength = New System.Windows.Forms.NumericUpDown()
        Me.worksheetButton = New System.Windows.Forms.Button()
        CType(Me.NumScrollMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumScrollMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScrollNumDigits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScrollMaxLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScrollMinLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(492, 255)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "חשב"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(416, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "מחשבון משוואות בסיסי"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(368, 204)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(366, 39)
        Me.TextBox1.TabIndex = 3
        '
        'Result
        '
        Me.Result.AutoSize = True
        Me.Result.Location = New System.Drawing.Point(521, 350)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(25, 32)
        Me.Result.TabIndex = 4
        Me.Result.Text = "?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(962, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "גרסה 1.2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(950, 594)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 32)
        Me.Label3.TabIndex = 6
        '
        'Solver
        '
        Me.Solver.AutoSize = True
        Me.Solver.Location = New System.Drawing.Point(889, 22)
        Me.Solver.Name = "Solver"
        Me.Solver.Size = New System.Drawing.Size(183, 32)
        Me.Solver.TabIndex = 7
        Me.Solver.TabStop = True
        Me.Solver.Text = "מחשבון משוואות"
        '
        'Quardic
        '
        Me.Quardic.AutoSize = True
        Me.Quardic.Location = New System.Drawing.Point(681, 22)
        Me.Quardic.Name = "Quardic"
        Me.Quardic.Size = New System.Drawing.Size(176, 32)
        Me.Quardic.TabIndex = 8
        Me.Quardic.TabStop = True
        Me.Quardic.Text = "משוואה ריבועית"
        '
        'aBox
        '
        Me.aBox.Location = New System.Drawing.Point(329, 230)
        Me.aBox.Name = "aBox"
        Me.aBox.Size = New System.Drawing.Size(56, 39)
        Me.aBox.TabIndex = 9
        '
        'bBox
        '
        Me.bBox.Location = New System.Drawing.Point(605, 231)
        Me.bBox.Name = "bBox"
        Me.bBox.Size = New System.Drawing.Size(59, 39)
        Me.bBox.TabIndex = 10
        '
        'cBox
        '
        Me.cBox.Location = New System.Drawing.Point(855, 230)
        Me.cBox.Name = "cBox"
        Me.cBox.Size = New System.Drawing.Size(59, 39)
        Me.cBox.TabIndex = 11
        '
        'aLabel
        '
        Me.aLabel.AutoSize = True
        Me.aLabel.Location = New System.Drawing.Point(222, 230)
        Me.aLabel.Name = "aLabel"
        Me.aLabel.Size = New System.Drawing.Size(59, 32)
        Me.aLabel.TabIndex = 12
        Me.aLabel.Text = "A = "
        '
        'bLabel
        '
        Me.bLabel.AutoSize = True
        Me.bLabel.Location = New System.Drawing.Point(449, 230)
        Me.bLabel.Name = "bLabel"
        Me.bLabel.Size = New System.Drawing.Size(58, 32)
        Me.bLabel.TabIndex = 13
        Me.bLabel.Text = "B = "
        '
        'cLabel
        '
        Me.cLabel.AutoSize = True
        Me.cLabel.Location = New System.Drawing.Point(729, 234)
        Me.cLabel.Name = "cLabel"
        Me.cLabel.Size = New System.Drawing.Size(59, 32)
        Me.cLabel.TabIndex = 14
        Me.cLabel.Text = "C = "
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(492, 295)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(127, 52)
        Me.calculateButton.TabIndex = 15
        Me.calculateButton.Text = "פתור"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'solutionsLabel
        '
        Me.solutionsLabel.AutoSize = True
        Me.solutionsLabel.Location = New System.Drawing.Point(472, 406)
        Me.solutionsLabel.Name = "solutionsLabel"
        Me.solutionsLabel.Size = New System.Drawing.Size(0, 32)
        Me.solutionsLabel.TabIndex = 16
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardInputEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'TrainLabel
        '
        Me.TrainLabel.AutoSize = True
        Me.TrainLabel.Location = New System.Drawing.Point(557, 22)
        Me.TrainLabel.Name = "TrainLabel"
        Me.TrainLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TrainLabel.Size = New System.Drawing.Size(74, 32)
        Me.TrainLabel.TabIndex = 17
        Me.TrainLabel.TabStop = True
        Me.TrainLabel.Text = "תרגול"
        '
        'RandomEquation
        '
        Me.RandomEquation.Location = New System.Drawing.Point(438, 184)
        Me.RandomEquation.Name = "RandomEquation"
        Me.RandomEquation.Size = New System.Drawing.Size(240, 43)
        Me.RandomEquation.TabIndex = 18
        Me.RandomEquation.Text = "משוואה חדשה"
        Me.RandomEquation.UseVisualStyleBackColor = True
        '
        'EquationLabel
        '
        Me.EquationLabel.AutoSize = True
        Me.EquationLabel.Location = New System.Drawing.Point(475, 273)
        Me.EquationLabel.Name = "EquationLabel"
        Me.EquationLabel.Size = New System.Drawing.Size(173, 32)
        Me.EquationLabel.TabIndex = 19
        Me.EquationLabel.Text = "(הוסף משוואה )"
        '
        'UserAnswer
        '
        Me.UserAnswer.Location = New System.Drawing.Point(492, 385)
        Me.UserAnswer.Name = "UserAnswer"
        Me.UserAnswer.Size = New System.Drawing.Size(127, 39)
        Me.UserAnswer.TabIndex = 20
        '
        'FeedBackLabel
        '
        Me.FeedBackLabel.AutoSize = True
        Me.FeedBackLabel.Location = New System.Drawing.Point(516, 507)
        Me.FeedBackLabel.Name = "FeedBackLabel"
        Me.FeedBackLabel.Size = New System.Drawing.Size(0, 32)
        Me.FeedBackLabel.TabIndex = 21
        '
        'CheckButton
        '
        Me.CheckButton.Location = New System.Drawing.Point(458, 456)
        Me.CheckButton.Name = "CheckButton"
        Me.CheckButton.Size = New System.Drawing.Size(190, 83)
        Me.CheckButton.TabIndex = 22
        Me.CheckButton.Text = "בדוק את עצמך"
        Me.CheckButton.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(57, 145)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(158, 23)
        Me.ProgressBar1.TabIndex = 23
        '
        'LevelLabel
        '
        Me.LevelLabel.AutoSize = True
        Me.LevelLabel.Location = New System.Drawing.Point(98, 93)
        Me.LevelLabel.Name = "LevelLabel"
        Me.LevelLabel.Size = New System.Drawing.Size(101, 32)
        Me.LevelLabel.TabIndex = 24
        Me.LevelLabel.Text = "Level : 0"
        '
        'Settings
        '
        Me.Settings.AutoSize = True
        Me.Settings.Location = New System.Drawing.Point(360, 22)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(156, 32)
        Me.Settings.TabIndex = 25
        Me.Settings.TabStop = True
        Me.Settings.Text = "הגדרות תרגול"
        '
        'NumScrollMax
        '
        Me.NumScrollMax.Location = New System.Drawing.Point(670, 227)
        Me.NumScrollMax.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumScrollMax.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NumScrollMax.Name = "NumScrollMax"
        Me.NumScrollMax.Size = New System.Drawing.Size(120, 39)
        Me.NumScrollMax.TabIndex = 26
        '
        'NumScrollMin
        '
        Me.NumScrollMin.Location = New System.Drawing.Point(668, 303)
        Me.NumScrollMin.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumScrollMin.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.NumScrollMin.Name = "NumScrollMin"
        Me.NumScrollMin.Size = New System.Drawing.Size(120, 39)
        Me.NumScrollMin.TabIndex = 27
        '
        'biggestCoefLabel
        '
        Me.biggestCoefLabel.AutoSize = True
        Me.biggestCoefLabel.Location = New System.Drawing.Point(809, 229)
        Me.biggestCoefLabel.Name = "biggestCoefLabel"
        Me.biggestCoefLabel.Size = New System.Drawing.Size(225, 32)
        Me.biggestCoefLabel.TabIndex = 28
        Me.biggestCoefLabel.Text = "המקדם הגדול ביותר "
        '
        'smallestCoefLabel
        '
        Me.smallestCoefLabel.AutoSize = True
        Me.smallestCoefLabel.Location = New System.Drawing.Point(815, 310)
        Me.smallestCoefLabel.Name = "smallestCoefLabel"
        Me.smallestCoefLabel.Size = New System.Drawing.Size(214, 32)
        Me.smallestCoefLabel.TabIndex = 29
        Me.smallestCoefLabel.Text = "המקדם הקטן ביותר"
        '
        'digitsLabel
        '
        Me.digitsLabel.AutoSize = True
        Me.digitsLabel.Location = New System.Drawing.Point(809, 392)
        Me.digitsLabel.Name = "digitsLabel"
        Me.digitsLabel.Size = New System.Drawing.Size(220, 32)
        Me.digitsLabel.TabIndex = 30
        Me.digitsLabel.Text = "ספרות אחרי הנקודה"
        '
        'ScrollNumDigits
        '
        Me.ScrollNumDigits.Location = New System.Drawing.Point(668, 386)
        Me.ScrollNumDigits.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.ScrollNumDigits.Name = "ScrollNumDigits"
        Me.ScrollNumDigits.Size = New System.Drawing.Size(120, 39)
        Me.ScrollNumDigits.TabIndex = 31
        '
        'maxLengthLabel
        '
        Me.maxLengthLabel.AutoSize = True
        Me.maxLengthLabel.Location = New System.Drawing.Point(449, 229)
        Me.maxLengthLabel.Name = "maxLengthLabel"
        Me.maxLengthLabel.Size = New System.Drawing.Size(157, 32)
        Me.maxLengthLabel.TabIndex = 32
        Me.maxLengthLabel.Text = "אורך מקסימלי"
        '
        'minLengthLabel
        '
        Me.minLengthLabel.AutoSize = True
        Me.minLengthLabel.Location = New System.Drawing.Point(458, 310)
        Me.minLengthLabel.Name = "minLengthLabel"
        Me.minLengthLabel.Size = New System.Drawing.Size(141, 32)
        Me.minLengthLabel.TabIndex = 33
        Me.minLengthLabel.Text = "אורך מינימלי"
        '
        'ScrollMaxLength
        '
        Me.ScrollMaxLength.Location = New System.Drawing.Point(287, 228)
        Me.ScrollMaxLength.Name = "ScrollMaxLength"
        Me.ScrollMaxLength.Size = New System.Drawing.Size(120, 39)
        Me.ScrollMaxLength.TabIndex = 34
        '
        'ScrollMinLength
        '
        Me.ScrollMinLength.Location = New System.Drawing.Point(287, 308)
        Me.ScrollMinLength.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.ScrollMinLength.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.ScrollMinLength.Name = "ScrollMinLength"
        Me.ScrollMinLength.Size = New System.Drawing.Size(120, 39)
        Me.ScrollMinLength.TabIndex = 35
        Me.ScrollMinLength.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'worksheetButton
        '
        Me.worksheetButton.Location = New System.Drawing.Point(98, 392)
        Me.worksheetButton.Name = "worksheetButton"
        Me.worksheetButton.Size = New System.Drawing.Size(166, 68)
        Me.worksheetButton.TabIndex = 36
        Me.worksheetButton.Text = "צור דף עבודה"
        Me.worksheetButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 561)
        Me.Controls.Add(Me.worksheetButton)
        Me.Controls.Add(Me.ScrollMinLength)
        Me.Controls.Add(Me.ScrollMaxLength)
        Me.Controls.Add(Me.minLengthLabel)
        Me.Controls.Add(Me.maxLengthLabel)
        Me.Controls.Add(Me.ScrollNumDigits)
        Me.Controls.Add(Me.digitsLabel)
        Me.Controls.Add(Me.smallestCoefLabel)
        Me.Controls.Add(Me.biggestCoefLabel)
        Me.Controls.Add(Me.NumScrollMin)
        Me.Controls.Add(Me.NumScrollMax)
        Me.Controls.Add(Me.Settings)
        Me.Controls.Add(Me.LevelLabel)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.CheckButton)
        Me.Controls.Add(Me.FeedBackLabel)
        Me.Controls.Add(Me.UserAnswer)
        Me.Controls.Add(Me.EquationLabel)
        Me.Controls.Add(Me.RandomEquation)
        Me.Controls.Add(Me.TrainLabel)
        Me.Controls.Add(Me.solutionsLabel)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.cLabel)
        Me.Controls.Add(Me.bLabel)
        Me.Controls.Add(Me.aLabel)
        Me.Controls.Add(Me.cBox)
        Me.Controls.Add(Me.bBox)
        Me.Controls.Add(Me.aBox)
        Me.Controls.Add(Me.Quardic)
        Me.Controls.Add(Me.Solver)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.Text = "הגדרות תרגול"
        CType(Me.NumScrollMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumScrollMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScrollNumDigits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScrollMaxLength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScrollMinLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Result As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Solver As LinkLabel
    Friend WithEvents Quardic As LinkLabel
    Friend WithEvents aBox As TextBox
    Friend WithEvents bBox As TextBox
    Friend WithEvents cBox As TextBox
    Friend WithEvents aLabel As Label
    Friend WithEvents bLabel As Label
    Friend WithEvents cLabel As Label
    Friend WithEvents calculateButton As Button
    Friend WithEvents solutionsLabel As Label
    Friend WithEvents Process1 As Process
    Friend WithEvents TrainLabel As LinkLabel
    Friend WithEvents RandomEquation As Button
    Friend WithEvents EquationLabel As Label
    Friend WithEvents UserAnswer As TextBox
    Friend WithEvents FeedBackLabel As Label
    Friend WithEvents CheckButton As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents LevelLabel As Label
    Friend WithEvents Settings As LinkLabel
    Friend WithEvents smallestCoefLabel As Label
    Friend WithEvents biggestCoefLabel As Label
    Friend WithEvents NumScrollMin As NumericUpDown
    Friend WithEvents NumScrollMax As NumericUpDown
    Friend WithEvents ScrollNumDigits As NumericUpDown
    Friend WithEvents digitsLabel As Label
    Friend WithEvents ScrollMinLength As NumericUpDown
    Friend WithEvents ScrollMaxLength As NumericUpDown
    Friend WithEvents minLengthLabel As Label
    Friend WithEvents maxLengthLabel As Label
    Friend WithEvents worksheetButton As Button
End Class
