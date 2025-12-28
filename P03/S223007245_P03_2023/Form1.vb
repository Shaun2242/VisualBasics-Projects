' **************************************************************************************************
' Surname, Initials:Lekgothoane MS
' Student Number:223007245
' Practical: P2023-03
' **************************************************************************************************

Option Strict On
Option Explicit On
Option Infer Off


Public Class frmDestination
    'Variable declaration
    Private nDestination As Integer
    Private nActivitiesPerDest As Integer
    Private nSocialMediaSite As Integer
    Private Destinations() As Destination

    Private Sub PIG(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        grdDest.Row = r
        grdDest.Col = c
        grdDest.Text = t
    End Sub

    Private Sub SetupArray()
        ReDim Destinations(nDestination)

    End Sub

    Private Sub Setup()

        'Take in inputs from user 
        nDestination = CInt(InputBox("Enter number of destinations"))
        nActivitiesPerDest = CInt(InputBox("Enter number of activities"))
        nSocialMediaSite = CInt(InputBox("Enter number social media sites"))

        'Resize arrays 
        SetupArray()

        'Set grid dimensions 
        grdDest.Rows = 3 + nActivitiesPerDest
        grdDest.Cols = 1 + nDestination

        'Label grid
        For c As Integer = 1 To nDestination
            PIG(0, c, "Destination " & CStr(c))
        Next c

        For r As Integer = 1 To nActivitiesPerDest
            PIG(r, 0, "Activity " & CStr(r))
        Next r

        PIG(nActivitiesPerDest + 1, 0, "Index")
        PIG(nActivitiesPerDest + 2, 0, "Rating")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSetup.Click

        '1. Take in number of destinations, activities and social media sites
        Setup()

    End Sub

    Private Sub btnCaptVal_Click(sender As Object, e As EventArgs) Handles btnCaptVal.Click
        '2. Take in inputs for relevant Destination and their related activities data
        For d As Integer = 1 To nDestination
            Destinations(d) = New Destination(nActivitiesPerDest)
            Destinations(d).DestinationName = InputBox("Enter name for destination " & CStr(d))
            For a As Integer = 1 To nActivitiesPerDest
                Destinations(d).Activities(a) = New Activity(nSocialMediaSite)
                Destinations(d).Activities(a).ActivityName = InputBox("Enter activity name for destination " & CStr(d) & " activity " & CStr(a))
                Destinations(d).Activities(a).nVisitors = CInt(InputBox("Enter number of visitors for destination " & d & " activity " & a))
                For s As Integer = 1 To nSocialMediaSite
                    Destinations(d).Activities(a).nPhotos(s) = CInt(InputBox("Enter number of photos at destination " & d & " activity " & a & " social media site " & s))
                Next s
            Next a
        Next d
    End Sub

    Private Sub btnCalcTotPhotos_Click(sender As Object, e As EventArgs) Handles btnCalcTotPhotos.Click
        '3. Calculate the total photographs that have been uploaded to each social media site for each activity offered at each destination

        Dim TotalPhotos As Integer

        For d As Integer = 1 To nDestination
            For a As Integer = 1 To nActivitiesPerDest
                TotalPhotos = 0
                For s As Integer = 1 To nSocialMediaSite
                    TotalPhotos += Destinations(d).Activities(a).nPhotos(s)
                Next s
                Destinations(d).Activities(a).TotPhotos = TotalPhotos
            Next a
        Next d

    End Sub

    Private Sub btnCalcRatio_Click(sender As Object, e As EventArgs) Handles btnCalcRatio.Click
        '5. Calculate, store and display the Photos-Visitors ratio for each activity offered at each destination

        For d As Integer = 1 To nDestination
            For a As Integer = 1 To nActivitiesPerDest
                Destinations(d).CalcRatio(Destinations(d).Activities(a).TotPhotos, Destinations(d).Activities(a).nVisitors, Destinations(d).Activities(a).PhotoVisitRatio)
                PIG(a, d, CStr(Destinations(d).Activities(a).PhotoVisitRatio))
            Next a
        Next d

    End Sub

    Private Sub btCalcIndex_Click(sender As Object, e As EventArgs) Handles btCalcIndex.Click
        '6. Calculate, store and display the index of the activity that has the highest Photo-Visitors Ratio for each destination 

        Dim Max As Double
        Dim MaxIndex As Integer

        For d As Integer = 1 To nDestination
            Max = Destinations(d).Activities(1).PhotoVisitRatio
            MaxIndex = 1
            For a As Integer = 2 To nActivitiesPerDest
                If Max < Destinations(d).Activities(a).PhotoVisitRatio Then
                    Max = Destinations(d).Activities(a).PhotoVisitRatio
                    MaxIndex = a
                End If
            Next a
            Destinations(d).HighestPhotoVisIndex = MaxIndex
            PIG(nActivitiesPerDest + 1, d, CStr(Destinations(d).HighestPhotoVisIndex))
        Next d

    End Sub

    Private Sub btnTourismRating_Click(sender As Object, e As EventArgs) Handles btnTourismRating.Click
        '7. Calculate, store and display the destination's tourism rating for each destination

        Dim Remainder As Integer

        For d As Integer = 1 To nDestination
            Remainder = Destinations(d).HighestPhotoVisIndex Mod 2
            Select Case Remainder
                Case 0
                    Destinations(d).TourismRating = "A"
                Case 1
                    Destinations(d).TourismRating = "B"
            End Select
            PIG(nActivitiesPerDest + 2, d, Destinations(d).TourismRating)
        Next d

    End Sub

    Private Sub btnIncreaseOrSame_Click(sender As Object, e As EventArgs) Handles btnIncreaseOrSame.Click
        '8. Assess the index of the Highest Photos-Visitors ratio of each destination's tourism rating

        Dim Condition As Boolean = True
        Dim Index As Integer = 1
        Dim Trend As String

        For d As Integer = 1 To nDestination
            While Index < nDestination And Condition = True
                If Destinations(Index + 1).HighestPhotoVisIndex > Destinations(Index).HighestPhotoVisIndex Then
                    Condition = True
                    Index += 1
                Else
                    Condition = False
                End If
            End While
            If Condition = True Then
                Trend = "Increasing"
            Else
                Trend = "Remaining the same"
            End If
        Next d

        txtIncreaseOrSame.Text = Trend

    End Sub
End Class
