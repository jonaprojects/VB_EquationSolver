Imports System.IO
Imports Syncfusion.DocIO.DLS
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop

Public Class Form1
    Private userLevel As Integer = 0
    Private decimalAccuracy As Integer = 3
    Private minValue As Integer = -50
    Private maxValue As Integer = 50
    Private maxLength As Integer = 10
    Private minLength As Integer = 5
    Private worksheetCounter As Integer = 1
    Private Sub HideAll()
        aBox.Hide()
        bBox.Hide()
        cBox.Hide()
        aLabel.Hide()
        bLabel.Hide()
        cLabel.Hide()
        TextBox1.Hide()
        calculateButton.Hide()
        Button1.Hide()
        solutionsLabel.Hide()
        calculateButton.Hide()
        RandomEquation.Hide()
        EquationLabel.Hide()
        UserAnswer.Hide()
        FeedBackLabel.Hide()
        CheckButton.Hide()
        LevelLabel.Hide()
        ProgressBar1.Hide()
        NumScrollMax.Hide()
        NumScrollMin.Hide()
        biggestCoefLabel.Hide()
        smallestCoefLabel.Hide()
        Result.Hide()
        ScrollNumDigits.Hide()
        digitsLabel.Hide()
        minLengthLabel.Hide()
        maxLengthLabel.Hide()
        ScrollMaxLength.Hide()
        ScrollMinLength.Hide()
    End Sub
    Private Sub ShowSettings()
        biggestCoefLabel.Show()
        smallestCoefLabel.Show()
        NumScrollMax.Show()
        NumScrollMin.Show()
        ScrollNumDigits.Show()
        digitsLabel.Show()
        maxLengthLabel.Show()
        minLengthLabel.Show()
        ScrollMaxLength.Show()
        ScrollMinLength.Show()
        Me.Label1.Text = "הגדרות"
        Me.ScrollNumDigits.Value = decimalAccuracy
        NumScrollMax.Value = maxValue
        NumScrollMin.Value = minValue
        ScrollMaxLength.Value = maxLength
        ScrollMinLength.Value = minLength

    End Sub
    Private Sub ShowSolver()
        Me.TextBox1.Show()
        Me.Button1.Show()
        Me.Label1.Text = "מחשבון משוואות בסיסי"
        Me.Result.Show()
    End Sub
    Private Sub ShowTraining()
        RandomEquation.Show()
        EquationLabel.Show()
        UserAnswer.Show()
        FeedBackLabel.Show()
        CheckButton.Show()
        LevelLabel.Show()
        ProgressBar1.Show()
        Me.Label1.Text = "?" + "עד כמה אתם טובים"
    End Sub
    Private Sub CreateWord(Optional numOfEquations As Integer = 10)
        '
        Dim accumulator As String = "דף עבודה במשוואות עם נעלם אחד" & vbCrLf & vbCrLf
        Dim equations As String() = GetNEquations(numOfEquations)
        For Each equation As String In equations
            accumulator += $"{equation}" & vbCrLf & vbCrLf
        Next

        Using document As WordDocument = New WordDocument
            document.EnsureMinimal()
            document.LastParagraph.AppendText(accumulator)
            document.Save($"worksheet{worksheetCounter}.docx")
            worksheetCounter += 1
        End Using
    End Sub
    Private Sub writeDebug(Optional path As String = "none", Optional ByVal x As String = "Hello,World!")
        If path = "none" Then
            path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            path = "C:\"
        End If
        Dim FILE_NAME As String = path & $"\worksheet{worksheetCounter}.txt"
        worksheetCounter += 1
        If System.IO.File.Exists(FILE_NAME) = False Then
            System.IO.File.Create(FILE_NAME).Dispose()
        End If
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME, True)
        objWriter.WriteLine(x)
        objWriter.Close()
    End Sub
    Private Function GetNEquations(n As Integer)
        Dim equation As String
        Dim Answer As String
        Dim Equations(n) As String
        For i = 0 To n
            equation = RemoveSpaces(GenerateRandomEquation(minLength, maxLength, minValue, maxValue, "x"))
            Answer = RemoveSpaces(ComputeEquation(equation))
            If Answer.Contains("=") Then
                Answer = Answer.Substring(Answer.IndexOf("=") + 1)
            Else
                Answer = "BUG"
            End If
            While Answer = "BUG" OrElse (Answer.Contains(".") AndAlso RemoveSpaces(Answer.Substring(Answer.IndexOf(".") + 1)).Length >= decimalAccuracy)
                equation = RemoveSpaces(GenerateRandomEquation(minLength, maxLength, minValue, maxValue, "x"))
                Answer = RemoveSpaces(ComputeEquation(equation))
                If Answer.Contains("=") Then
                    Answer = Answer.Substring(Answer.IndexOf("=") + 1)
                Else
                    Answer = "BUG"
                End If
            End While
            Equations.SetValue(equation, i)
        Next
        Return Equations
    End Function
    Sub CreateWorkSheet(Optional path As String = "none", Optional numOfEquations As Integer = 15)
        Dim accumulator As String = "דף עבודה במשוואות עם נעלם אחד" & vbCrLf & vbCrLf
        Dim equations As String() = GetNEquations(numOfEquations)
        For Each equation As String In equations
            accumulator += $"{equation}" & vbCrLf & vbCrLf
        Next

        writeDebug(path, accumulator)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideAll()
        ShowSolver()
    End Sub
    Private Function RemoveSpaces(equation As String)
        Return equation.Replace(" ", "")
    End Function
    Private Function ExtractVariables(expression As String)
        Dim variables As Dictionary(Of String, Double) = New Dictionary(Of String, Double)
        For Each letter As String In expression
            If Char.IsLetter(letter) AndAlso Not variables.ContainsKey(letter) Then
                variables.Add(letter, 0)
            End If
        Next
        variables.Add("number", 0)
        Return variables
    End Function
    Private Function HandleAlgebricExp(expression As String, variables As Dictionary(Of String, Double))
        expression = expression.Replace("-", "+-")
        If expression.ElementAt(0) = "+" Then
            expression = expression.Substring(1)
        End If
        Dim subExpressions As String() = expression.Split("+")
        Dim currentVar As Char
        Dim temp As Double
        For Each subExpression As String In subExpressions
            subExpression = subExpression.Trim()
            currentVar = subExpression.ElementAt(subExpression.Length - 1)
            If Char.IsLetter(currentVar) Then
                If variables.ContainsKey(currentVar) Then
                    If subExpression.Length = 1 Then
                        subExpression = $"1{currentVar}"
                    ElseIf subExpression.Length = 2 AndAlso subExpression.ElementAt(0) = "-" Then
                        subExpression = $"-1{currentVar}"
                    End If
                    temp = Double.Parse(subExpression.Substring(0, subExpression.Length - 1))
                    variables.Item(currentVar) += temp
                End If
            ElseIf Double.TryParse(subExpression, temp) Then
                variables.Item("number") += temp
            End If
        Next
        Return variables
    End Function
    Private Function SubtractDictionaries(dict1 As Dictionary(Of String, Double), dict2 As Dictionary(Of String, Double))
        'Label2.Text = dict1.Item("number")
        Dim resultDict = New Dictionary(Of String, Double)
        ' create and add 
        For Each pair As KeyValuePair(Of String, Double) In dict1
            resultDict.Add(pair.Key, pair.Value)
        Next
        ' subtract 
        For Each pair As KeyValuePair(Of String, Double) In dict2
            resultDict.Item(pair.Key) -= pair.Value
            'Label2.Text += $"{resultDict.Item(pair.Key)}{pair.Key},"
        Next
        Return resultDict
    End Function
    Private Function FormatAlgebric(dict As Dictionary(Of String, Double))
        Dim result As String = ""
        For Each pair As KeyValuePair(Of String, Double) In dict
            result += $"+{pair.Value}{pair.Key}"
        Next
        Return result
    End Function
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
    Private Function GenerateRandomEquation(minLength As Integer, maxLength As Integer, minValue As Integer, maxValue As Integer, variable As Char)
        Dim firstLength As Integer = GetRandom(minLength, maxLength)
        Dim secondLength As Integer = GetRandom(minLength, maxLength)
        Dim withX, coefficient As Integer
        Dim accumulator As String = ""
        For i As Integer = 0 To firstLength
            withX = GetRandom(0, 2)
            coefficient = GetRandom(minValue, maxValue)
            If coefficient > -1 AndAlso i > 0 Then
                accumulator += "+"
            End If
            If withX = 0 Then
                accumulator += coefficient.ToString()
            ElseIf withX = 1 Then
                If Not coefficient = 1 OrElse coefficient = -1 Then
                    accumulator += coefficient.ToString()
                End If
                accumulator += variable
            End If

        Next
        accumulator += "="
        For i As Integer = 0 To secondLength
            withX = GetRandom(0, 2)
            coefficient = GetRandom(minValue, maxValue)
            If coefficient > -1 AndAlso i > 0 Then
                accumulator += "+"
            End If
            If withX = 0 Then
                accumulator += coefficient.ToString()
            ElseIf withX = 1 Then
                If Not coefficient = 1 Then
                    accumulator += coefficient.ToString()
                End If
                accumulator += variable
            End If

        Next
        Return accumulator

    End Function
    Private Function ComputeEquation(equation As String)
        Try
            equation = RemoveSpaces(equation)
            Dim sides As String() = equation.Split("=")
            Dim variables As Dictionary(Of String, Double) = ExtractVariables(expression:=equation)
            Dim variables1 As Dictionary(Of String, Double) = ExtractVariables(expression:=equation)
            Dim firstDict As Dictionary(Of String, Double) = HandleAlgebricExp(sides.ElementAt(0), variables)
            Dim secondDict As Dictionary(Of String, Double) = HandleAlgebricExp(sides.ElementAt(1), variables1)
            Dim resultDict As Dictionary(Of String, Double) = SubtractDictionaries(firstDict, secondDict)
            Dim variableKey As String = If(variables.Count > 1, variables.ElementAt(0).Key, If(variables1.Count > 1, variables1.ElementAt(0).Key, "404"))
            If variableKey = "404" Then
                Throw New Exception("404")
            End If
            If resultDict.Item(variableKey) = 0 Then
                If resultDict.Item("number") = 0 Then
                    Return "Infinite Solutions!"
                Else
                    Return "No Solution!"
                End If
            End If
            Dim finalResult As Double = -resultDict.Item("number") / resultDict.Item(variableKey)
            Return $"{variableKey} = {finalResult}"
        Catch ex As Exception
            If ex.Message = "404" Then
                Return "404-Variable Not Found"
            Else
                Return "Invalid Equation"
            End If
        End Try

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userInput As String = TextBox1.Text
        Result.Text = ComputeEquation(userInput)
    End Sub

    Private Sub Result_Click(sender As Object, e As EventArgs) Handles Result.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub MoveToSolver()
        HideAll()
        ShowSolver()
    End Sub
    Private Sub Solver_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Solver.LinkClicked
        MoveToSolver()
    End Sub
    Private Sub MoveToQuardic()
        HideAll()
        Me.aBox.Show()
        Me.bBox.Show()
        Me.cBox.Show()
        Me.cLabel.Show()
        Me.bLabel.Show()
        Me.aLabel.Show()
        solutionsLabel.Show()
        Me.calculateButton.Show()
        Me.Label1.Text = "מחשבון משוואה ריבועית"
    End Sub
    Private Sub Quardic_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Quardic.LinkClicked
        HideAll()
        MoveToQuardic()
        'Me.ClientSize = New System.Drawing.Size(284, 264)
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim a, b, c, solution1, solution2 As Double
        Double.TryParse(aBox.Text, a)
        Double.TryParse(bBox.Text, b)
        Double.TryParse(cBox.Text, c)
        Dim discriminate = b * b - 4 * a * c
        If discriminate >= 0 Then
            solution1 = (-b + Math.Sqrt(discriminate)) / (2 * a)
            solution2 = (-b - Math.Sqrt(discriminate)) / (2 * a)
            solutionsLabel.Text = $"x1 = {solution1}, x2 = {solution2}"
        ElseIf discriminate < 0 Then
            solutionsLabel.Text = $"No real solutions"

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TrainLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TrainLabel.LinkClicked
        HideAll()
        ShowTraining()
    End Sub

    Private Sub RandomEquation_Click(sender As Object, e As EventArgs) Handles RandomEquation.Click
        Dim newLocation As Point
        Dim equation As String = RemoveSpaces(GenerateRandomEquation(minLength, maxLength, minValue, maxValue, "x"))
        EquationLabel.Text = equation
        CheckButton.Text = "בדוק את עצמך"
        CheckButton.Enabled = True
        Dim Answer As String = RemoveSpaces(ComputeEquation(equation))
        If Answer.Contains("=") Then
            Answer = Answer.Substring(Answer.IndexOf("=") + 1)
        Else
            Answer = "BUG"
        End If
        Dim Iterations As Integer = 1
        While Answer = "BUG" OrElse (Answer.Contains(".") AndAlso RemoveSpaces(Answer.Substring(Answer.IndexOf(".") + 1)).Length >= decimalAccuracy)
            equation = RemoveSpaces(GenerateRandomEquation(minLength, maxLength, minValue, maxValue, "x"))
            EquationLabel.Text = equation
            Label1.Text = $"{Iterations} Equations Swapped"
            Answer = RemoveSpaces(ComputeEquation(equation))
            If Answer.Contains("=") Then
                Answer = Answer.Substring(Answer.IndexOf("=") + 1)
            Else
                Answer = "BUG"
            End If
            Iterations += 1
        End While
    End Sub

    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click

        Dim currentEquation As String = RemoveSpaces(EquationLabel.Text.ToLower())
        Dim userAnswer As String = RemoveSpaces(Me.UserAnswer.Text.ToLower())
        Dim solution As String = RemoveSpaces(ComputeEquation(currentEquation))
        If solution = userAnswer Then
            CheckButton.Text = "נכון"
            If ProgressBar1.Value <= 90 Then
                ProgressBar1.Value += 10
                userLevel += 1
                LevelLabel.Text = $"Level : {userLevel}"
                CheckButton.Enabled = False
            Else
                ProgressBar1.Value = 0
                userLevel += 1
                LevelLabel.Text = $"Level : {userLevel}"
            End If
            Return
        End If
        Dim Answer, ans As Double
        Label1.Text = solution.Substring(solution.IndexOf("=") + 1)
        Dim Success As Boolean = Double.TryParse(solution.Substring(solution.IndexOf("=") + 1), Answer) And Double.TryParse(userAnswer.Substring(solution.IndexOf("=") + 1), ans)
        Answer = Math.Round(Answer, 3)
        If Not Success Then
            CheckButton.Text = "באג"
            Return
        End If
        If Answer = ans OrElse Math.Abs(Answer - ans) < 0.1 Then
            CheckButton.Text = "נכון"
            If ProgressBar1.Value <= 90 Then
                ProgressBar1.Value += 10
                userLevel += 1
                LevelLabel.Text = $"Level : {userLevel}"
                CheckButton.Enabled = False
            Else
                ProgressBar1.Value = 0
                userLevel += 1
                LevelLabel.Text = $"Level : {userLevel}"
            End If
        Else
            CheckButton.Text = "שגוי"
        End If
    End Sub


    Private Sub Settings_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Settings.LinkClicked
        HideAll()
        ShowSettings()

    End Sub

    Private Sub NumScrollMax_ValueChanged(sender As Object, e As EventArgs) Handles NumScrollMax.ValueChanged
        maxValue = NumScrollMax.Value
    End Sub

    Private Sub NumScrollMin_ValueChanged(sender As Object, e As EventArgs) Handles NumScrollMin.ValueChanged
        minValue = NumScrollMin.Value
    End Sub

    Private Sub ScrollNumDigits_ValueChanged(sender As Object, e As EventArgs) Handles ScrollNumDigits.ValueChanged
        decimalAccuracy = ScrollNumDigits.Value
    End Sub

    Private Sub ScrollMaxLength_ValueChanged(sender As Object, e As EventArgs) Handles ScrollMaxLength.ValueChanged
        maxLength = ScrollMaxLength.Value
    End Sub

    Private Sub ScrollMinLength_ValueChanged(sender As Object, e As EventArgs) Handles ScrollMinLength.ValueChanged
        minLength = ScrollMinLength.Value
    End Sub

    Private Sub worksheetButton_Click(sender As Object, e As EventArgs) Handles worksheetButton.Click
        CreateWord()
    End Sub
End Class
