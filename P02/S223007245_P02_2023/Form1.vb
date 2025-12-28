' **************************************************************************************************
' Surname, Initials: Lekgothoane MS
' Student Number: 223007245
' Practical: P2023-02
' **************************************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmPuppy
    'Variable declaration
    Private nDays As Integer
    Private nPuppies As Integer
    Private PuppyNum() As Puppy
    Private PricePerKilo As Double
    Private TotalFood As Double

    Private Sub SetupArray()
        ReDim PuppyNum(nPuppies)
    End Sub

    Private Sub PIG(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        grdPuppy.Row = r
        grdPuppy.Col = c
        grdPuppy.Text = t
    End Sub

    Private Sub Setup()

        'Take in inputs
        nPuppies = CInt(InputBox("Enter number of puppies"))
        nDays = CInt(InputBox("Enter number of days"))

        'Setup array 
        SetupArray()

        'Setup dimensions
        grdPuppy.Rows = 3 + nDays
        grdPuppy.Cols = nPuppies + 1

        'Label grid
        PIG(1, 0, "Name")
        PIG(2 + nDays, 0, "Total Food Fed")

        For r As Integer = 1 To nDays
            PIG(1 + r, 0, "Weight For Day " & CStr(r))
        Next r

        For c As Integer = 1 To nPuppies
            PIG(0, c, "Puppy " & CStr(c))
        Next c
    End Sub

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click

        'Setup 
        Setup()

    End Sub

    Private Sub btnCaptVal_Click(sender As Object, e As EventArgs) Handles btnCaptVal.Click

        'Take in data for each puppy
        For p As Integer = 1 To nPuppies
            PuppyNum(p) = New Puppy(nPuppies, nDays)
            PuppyNum(p).Name = InputBox("Enter name for puppy " & CStr(p))
            PIG(1, p, PuppyNum(p).Name)
            PuppyNum(p).Age = CInt(InputBox("Enter age for puppy " & p))
            PuppyNum(p).Breed = CStr(InputBox("Enter Breed for puppy " & p))
            For w As Integer = 1 To nDays
                PuppyNum(p).Weight(w) = CDbl(InputBox("Enter weight for puppy " & p & " for day " & w))
                PIG(1 + w, p, CStr(PuppyNum(p).Weight(w)))
            Next w
        Next p
    End Sub

    Private Sub btnCalcFoodFed_Click(sender As Object, e As EventArgs) Handles btnCalcFoodFed.Click
        'Calculate total food fed to each puppy

        Dim TotalFoodPerPup As Double

        For f As Integer = 1 To nPuppies
            TotalFoodPerPup = PuppyNum(f).CalcFoodPerPuppy(nPuppies, nDays)
            PIG(2 + nDays, f, CStr(TotalFoodPerPup))
        Next f
    End Sub

    Private Sub btnPricePerKil_Click(sender As Object, e As EventArgs) Handles btnPricePerKil.Click
        'Take in price per kilogram

        PricePerKilo = CDbl(InputBox("Enter price per kilogram"))

    End Sub

    Private Sub btnTotFoodFed_Click(sender As Object, e As EventArgs) Handles btnTotFoodFed.Click
        'Calculate the total food fed to all puppies

        For f As Integer = 1 To nPuppies
            TotalFood += PuppyNum(f).CalcTotalFood(nPuppies)
        Next f
        txtTotFoodFed.Text = CStr(TotalFood)
    End Sub

    Private Sub btnTotMoneySpent_Click(sender As Object, e As EventArgs) Handles btnTotMoneySpent.Click
        'Calculate the total Money spent

        Dim TotalMoney As Double

        TotalMoney = PricePerKilo * TotalFood / 1000
        txtTotMoneySpent.Text = CStr(TotalMoney)

    End Sub
End Class
