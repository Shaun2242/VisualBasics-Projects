' **************************************************************************************************
' Surname, Initials: Lekgothoane MS
' Student Number:223007245
' Practical: P2023-07
' **************************************************************************************************
Option Strict On
Option Explicit On
Option Infer Off

Public Class frmRecycle

    'Variable declaration
    Private Recyclables() As cRecyclable
    Private nWeeks As Integer
    Private Plastic As cPlastic
    Private Paper As cPaper

    Private Sub ResizeArrays()
        nWeeks = CInt(InputBox("Enter number of weeks"))
        ReDim Recyclables(nWeeks)
    End Sub

    Enum Type
        Plastic = 1
        Paper = 2
    End Enum

    Private Sub btnCaptVal_Click(sender As Object, e As EventArgs) Handles btnSetup.Click

        'Resize arrays
        ResizeArrays()

        'Take in inputs from user
        For r As Integer = 1 To nWeeks

            Dim Choise As Integer = CInt(InputBox("Which recyclable is being recycled for week" & r & " (1) Plastic or (2) For Paper"))

            'Exception handling
            Try
                If Choise <> 1 And Choise <> 2 Then
                    Throw New OutOfRange
                End If
            Catch ex As OutOfRange
                MsgBox("Please choose within the given range")
            End Try

            Select Case Choise
                Case Type.Plastic
                    Dim Weight As Double = CDbl(InputBox("Enter weight for plastic"))
                    Dim Volume As Double = CDbl(InputBox("Enter volume for plastic"))

                    cRecyclable.Validate(Weight, Volume)

                    'Exception handling
                    Try
                        If Weight = 0 Or Volume = 0 Then
                            Throw New InvalidInteger
                        End If
                    Catch ex As InvalidInteger
                        MsgBox("Enter positive values for weight and volume")
                    End Try

                    For c As Integer = 1 To nWeeks
                        Recyclables(c) = New cRecyclable(Weight, Volume)
                    Next c
                    Plastic = New cPlastic(Weight, Volume)

                    Recyclables(r) = Plastic

                    Plastic.CalculateRecyclingPrice(Plastic.Weight, Plastic.CalculateGrade())

                    'Display information for plastic
                    txtRecy.Text += "Week " & r & Environment.NewLine & Plastic.Display() & Environment.NewLine & Environment.NewLine

                Case Type.Paper
                    Dim Weight As Double = CDbl(InputBox("Enter weight in ton for paper"))
                    Dim Volume As Double = CDbl(InputBox("Enter volume for paper"))

                    cRecyclable.Validate(Weight, Volume)

                    'Exception handling
                    Try
                        If Weight = 0 Or Volume = 0 Then
                            Throw New InvalidInteger
                        End If
                    Catch ex As InvalidInteger
                        MsgBox("Enter positive values for weight and volume")
                    End Try

                    For c As Integer = 1 To nWeeks
                        Recyclables(c) = New cRecyclable(Weight, Volume)
                    Next c
                    Paper = New cPaper(Weight, Volume)
                    Paper.CalculateRecyclingPrice(Paper.Weight, Paper.CalculateGrade())

                    Recyclables(r) = Paper

                    'Display information for paper
                    txtRecy.Text += "Week " & r & Environment.NewLine & Paper.Display() & Environment.NewLine & Environment.NewLine

            End Select
        Next r

    End Sub

End Class
