Public Class Form1
    Dim primeList As String

    Sub PrimeCheck()

        Dim minNumber As Integer
        Dim maxNumber As Integer
        Dim currentNumber As Integer
        Dim isPrime As Boolean

        minNumber = txtMin.Text
        maxNumber = txtMax.Text
        primeList = String.Empty
        isPrime = True

        For currentNumber = minNumber To maxNumber

            If isPrime Then
                For i = 2 To currentNumber - 1
                    If currentNumber Mod i Then
                    Else
                        isPrime = False
                    End If
                Next
            End If

            If isPrime Then
                primeList = currentNumber.ToString & ", " & primeList
                txtOutput.Text = primeList
                Application.DoEvents()
            End If
            isPrime = True
        Next


    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        PrimeCheck()
    End Sub
End Class
