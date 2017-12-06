Public Class formMainWindow

    'Global Variable Decleration
    Public FileLocation As String = "C:\"
    Private primeStart As Integer = Nothing
    Private primeGoFor As Integer = Nothing


    Private Sub tabAbout_Click(sender As Object, e As EventArgs) Handles tabAbout.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click



    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click

        'Tells the program to exit
        Application.Exit()

    End Sub

    Private Sub lblDebug_Click(sender As Object, e As EventArgs) Handles lblDebug.Click

        'Puts a line in the debug console
        Debug.WriteLine("----------------------------------------")

    End Sub

    Private Sub lblSaveUp_Click(sender As Object, e As EventArgs) Handles lblSaveUp.Click

        'Gets a file directory from a dialog
        If OpenFileDialog.ShowDialog = DialogResult.OK Then

            'Opens the dialog
            rtbOutput.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog.FileName)

        End If

    End Sub

    Private Sub OpenFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk

    End Sub

    Private Sub PrimesPrimeFinder(progName As String)

        Dim file As System.IO.StreamWriter

        Dim fileTimeVar As String = DateTime.Now.ToString("hhmmss")
        ' Console.Write("Save Directory: ")

        Dim fileDirectory As String = Console.ReadLine()
        'Console.WriteLine("Your File Code is: " & fileTimeVar)
        file = My.Computer.FileSystem.OpenTextFileWriter(fileDirectory & "\PrimeFile" & DateTime.Now.ToString("hhmmss") & ".txt", True)


        'Console.Write("Go On For: ")
        Dim primeMax As Integer = Console.ReadLine()

        ' Console.Write("Start Value: ")
        Dim primeStartValue As Integer = Console.ReadLine()

        If primeStartValue Mod 2 = 0 Then primeStartValue += 1

        Dim k As Integer = 2
        Dim primeCounter As Integer = 0


        While primeStartValue <= primeMax
            primeCounter = 0
            k = 2
            While k <= primeStartValue / 2
                If (primeStartValue Mod k) = 0 Then
                    primeCounter = primeCounter + 1

                    k = primeStartValue
                End If

                k = k + 1

            End While

            If primeCounter <= 0 Then

                file.Write(primeStartValue)
                file.WriteLine("")

            End If

            If primeStartValue Mod 10000 = 1 Then
                Console.WriteLine(String.Format("{0:#,#}", primeStartValue))
            End If

            primeStartValue = primeStartValue + 2

        End While
        Console.WriteLine("DONE: ")

        file.WriteLine("")
        file.WriteLine("------------------------------------------------------")
        file.WriteLine("")

        file.Close()

    End Sub

End Class
