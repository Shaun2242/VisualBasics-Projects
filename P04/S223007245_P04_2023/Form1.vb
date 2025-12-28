Option Strict On
Option Explicit On
Option Infer Off
Public Class frmGym
    'Variable declaration

    Private nMembers As Integer
    Private nExercises As Integer
    Private nWeeks As Integer
    Private Members() As Member

    Private Sub PIG(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        grdGym.Row = r
        grdGym.Col = c
        grdGym.Text = t
    End Sub

    Private Sub SetupArray()
        ReDim Members(nMembers)
    End Sub

    Private Sub Setup()
        '2.1) Take in inputs from user for number of gym members, exercise and weeks 
        nMembers = CInt(InputBox("Enter number of exercises"))
        nExercises = CInt(InputBox("Enter number of exercises"))
        nWeeks = CInt(InputBox("Enter number of weeks"))

        '2.2) Set up of dynamic arrays
        SetupArray()

        '2.3) Set up of the UJGrdi arrays  
        grdGym.Rows = 1 + nMembers
        grdGym.Cols = 3 + nExercises

        '2.4) Label the grid 
        For r As Integer = 1 To nMembers
            PIG(r, 0, "Member " & CStr(r))
        Next r

        For c As Integer = 1 To nExercises
            PIG(0, c, "Exercise " & CStr(c))
        Next c

        PIG(0, nExercises + 1, "Most Inneffective Exercise")
        PIG(0, nExercises + 2, "Weight Loss Alert")

    End Sub
    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        'Set up
        Setup()
    End Sub

    Private Sub btnCaptVal_Click(sender As Object, e As EventArgs) Handles btnCaptVal.Click
        '3.1) Input of data for each Gym member (including data for each exercise)

        For m As Integer = 1 To nMembers
            Members(m) = New Member(nMembers)
            Members(m).MemName = InputBox("Enter name for gym member " & CStr(m))
            Members(m).Weight = CDbl(InputBox("Enter weight for gym member " & m))
            Members(m).Age = CInt(InputBox("Enter age for gym memeber " & m))
            For x As Integer = 1 To nExercises
                Members(m).Exercises(x) = New Exercise(nExercises)
                Members(m).Exercises(x).ExerName = InputBox("Enter exercise name " & CStr(x) & " for gym member " & CStr(m))
                Members(m).Exercises(x).CalBurnt = CDbl(InputBox("Enter number of calories burnt for exercise " & x & " gym member " & m))
                For w As Integer = 1 To nWeeks
                    Members(m).Exercises(x).Reps(w) = CInt(InputBox("Enter number of reps for week " & w & " exercise " & x & " gym member " & m))
                Next w
            Next x
        Next m

    End Sub

    Private Sub btnCalcHighCalExer_Click(sender As Object, e As EventArgs) Handles btnCalcHighCalExer.Click
        '4.1) Count of High-Burning Calorie Exercises that exceed 2.5 calories per pep

        Dim Counter As Integer = 0

        For m As Integer = 1 To nMembers
            For x As Integer = 1 To nExercises
                If Members(m).Exercises(x).CalBurnt > 2.5 Then
                    Counter = Counter + 1
                End If
            Next x
        Next m

        '4.2) Display of High-Burning Calorie Exercises that exceed 2.5 calories per pep
        txtHighCalExer.Text = CStr(Counter)

    End Sub
    Private Sub btnCalcTotCalBurnt_Click(sender As Object, e As EventArgs) Handles btnCalcTotCalBurnt.Click
        '5.1) Calculation of the total number of calories burnt per Exercise by each Gym member

        Dim Total As Integer

        For m As Integer = 1 To nMembers
            For x As Integer = 1 To nExercises
                Total = 0
                For w As Integer = 1 To nWeeks
                    Total += Members(m).Exercises(x).Reps(w)
                Next w
                Members(m).Exercises(x).CalcTotCals(Total, Members(m).Exercises(x).CalBurnt, Members(m).Exercises(x).TotCalBurnt)

                '5.2) Display of the total number of calories burnt per Exercise by each Gym member
                PIG(m, x, Format(Members(m).Exercises(x).TotCalBurnt, "00"))
            Next x
        Next m

    End Sub


    Private Sub btnIndIneExer_Click(sender As Object, e As EventArgs) Handles btnIndIneExer.Click
        '6.1) Calculation of the index of the Most Inneffective Exercises performed

        Dim Min As Double
        Dim MinIndex As Integer = 1

        For m As Integer = 1 To nMembers
            Min = Members(m).Exercises(1).CalBurnt
            For x As Integer = 2 To nExercises
                If Min > Members(m).Exercises(x).CalBurnt Then
                    Min = Members(m).Exercises(x).CalBurnt
                    MinIndex = x
                End If
            Next x

            '6.2) Display the Name of the Most Inneffective Exercises performed by each Gym Member
            PIG(m, nExercises + 1, Members(m).Exercises(MinIndex).ExerName)
        Next m

    End Sub

    Private Sub btnWeightLossAlert_Click(sender As Object, e As EventArgs) Handles btnWeightLossAlert.Click
        '8.1) Calculation of the Weight Loss Alert 

        Dim Ratio As Double

        For m As Integer = 1 To nMembers
            For x As Integer = 1 To nExercises
                Ratio = Members(m).CalcWeightLossRatio(Members(m).Exercises(x).TotCalBurnt, Members(m).Weight)
            Next x
            Select Case Ratio
                Case <= 0.1
                    If Members(m).Age < 50 Then
                        Members(m).WeightLossAlert = "Try Harder"
                    Else
                        Members(m).WeightLossAlert = "Stay Steady"
                    End If
                Case > 0.2
                    If Members(m).Age < 50 Then
                        Members(m).WeightLossAlert = "Slow Down"
                    Else
                        Members(m).WeightLossAlert = "Seek Medical Attention"
                    End If
                Case Else
                    If Members(m).Age < 50 Then
                        Members(m).WeightLossAlert = "Stay Steady"
                    Else
                        Members(m).WeightLossAlert = "Slow Down"
                    End If
            End Select

            '8.2) Display of the Weiht Loss Alert
            PIG(m, nExercises + 2, Members(m).WeightLossAlert)
        Next m

    End Sub

End Class
