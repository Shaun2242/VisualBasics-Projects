'*********************************************************************************************
' Surname, Initials: Lekgothoane MS
' Student Number:223007245
' Practical: P06
'*********************************************************************************************
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmEntertainment

    Private Cinema As Cinema
    Private ComedyShow As ComedyShow
    Private nComedians As Integer

    Private Sub btnCaptVal_Click(sender As Object, e As EventArgs) Handles btnCaptValCin.Click

        'Take in information for cinema
        Cinema = New Cinema()
        Cinema.Price = CDbl(InputBox("Enter price for cinema entry"))
        Cinema.nPeople = CInt(InputBox("Enter number of people in the cinema"))
        Cinema.MovieName = InputBox("Enter name for movie name")
        Cinema.MovieRating = CDbl(InputBox("Enter movie rating"))

    End Sub

    Private Sub btnCaptValCom_Click(sender As Object, e As EventArgs) Handles btnCaptValCom.Click

        'Take in information for comedy

        nComedians = CInt(InputBox("Enter number of comedians"))
        ComedyShow = New ComedyShow(nComedians)
        ComedyShow.Price = CDbl(InputBox("Enter price for comedy show"))
        ComedyShow.nPeople = CInt(InputBox("Enter number of people at the show"))
        ComedyShow.Duration = CDbl(InputBox("Enter duration for comedy show in hours"))
        For c As Integer = 1 To nComedians
            ComedyShow.Comadian(c).Name = InputBox("Enter name for comedian " & c)
            ComedyShow.Comadian(c).Age = CInt(InputBox("Enter age for comedian " & c))
        Next c

    End Sub

    Private Sub btnCinema_Click(sender As Object, e As EventArgs) Handles btnCinema.Click
        Dim TotalIncome As Double

        TotalIncome = Cinema.TotalIncome()
        txtCinema.Text += Cinema.Display(Cinema.Price, Cinema.nPeople, Cinema.MovieName, CStr(Cinema.MovieRating), CStr(TotalIncome))

    End Sub

    Private Sub btnComedy_Click(sender As Object, e As EventArgs) Handles btnComedy.Click
        Dim TotalIncome As Double

        TotalIncome = ComedyShow.TotalIncome()
        txtComedy.Text += ComedyShow.Display(ComedyShow.Price, ComedyShow.nPeople, CStr(ComedyShow.Duration), "", CStr(TotalIncome)) & Environment.NewLine
        For c As Integer = 1 To nComedians
            txtComedy.Text += Environment.NewLine & "Comedian Name: " & ComedyShow.Comadian(c).Name & Environment.NewLine & "Comedian Age: " & ComedyShow.Comadian(c).Age & Environment.NewLine & "Eligibility: " & ComedyShow.Comadian(c).Eligibility() & Environment.NewLine
        Next c
    End Sub
End Class
