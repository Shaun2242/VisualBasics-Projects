' **************************************************************************************************
' Surname, Initials:Lekgothoane MS
' Student Number: 223007245
' Practical: P2023-01
' **************************************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmValues

    'Variable declaration
    Private Value As Integer
    Private DigitSum1 As Integer
    Private DigitSum2 As Integer

    Private Sub btnCaptVal_Click(sender As Object, e As EventArgs) Handles btnCaptVal.Click

        'Take in inputs from user and convert negative values to positive values
        Value = CInt(txtValues.Text)

        If Value < 0 Then
            Value = Value * -1
        End If

    End Sub

    Private Function IterativeDigitsCalc(ByVal v As Integer) As Integer
        'Iterative calculation
        Dim Remainder As Integer = 0
        Dim Sum As Integer = 0

        While v <> 0

            Remainder = v Mod 10
            Sum = Sum + Remainder
            If Remainder >= 5 Then
                v = CInt((v / 10) - 0.5)
            Else
                v = CInt((v / 10))
            End If

        End While

        Return Sum

    End Function

    Private Sub btnItteration_Click(sender As Object, e As EventArgs) Handles btnItteration.Click

        'Display sum of digits
        DigitSum1 = IterativeDigitsCalc(Value)
        txtIteration.Text = CStr(DigitSum1)

    End Sub

    Private Function RecursiveDigitCalc(ByVal v As Integer) As Integer

        'Recursive calculation
        Dim Remainder As Integer = 0
        Dim Sum As Integer = 0

        If v = 0 Then
            Return Sum
        Else
            Remainder = v Mod 10
            Sum = Sum + Remainder

            If Remainder >= 5 Then
                v = CInt((v / 10) - 0.5)
            Else
                v = CInt((v / 10))
            End If
            Return Sum + RecursiveDigitCalc(v)
        End If

    End Function

    Private Sub btnRecursion_Click(sender As Object, e As EventArgs) Handles btnRecursion.Click

        'Display sum of digits
        DigitSum2 = RecursiveDigitCalc(Value)
        txtRecursion.Text = CStr(DigitSum2)
    End Sub
End Class
