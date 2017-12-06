Public Class Form1

    'Global Variable Decleration
    Public FileLocation As String = "C:\"


    Private primeStart As Integer = Nothing
    Private primeGoFor As Integer = Nothing


    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click
        'Puts a line in the debug console
        Debug.WriteLine("----------------------------------------")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblEndVal_Click(sender As Object, e As EventArgs) Handles lblEndVal.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Tells the program to exit
        Application.Exit()
        End
    End Sub

    Private Sub updwnGoOnFor_ValueChanged(sender As Object, e As EventArgs) Handles updwnGoOnFor.ValueChanged

    End Sub

    Private Sub Primes()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSaveAs.Click

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then

            rtbOutputBox.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)

        End If

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
