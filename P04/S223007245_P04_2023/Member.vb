Option Strict On
Option Explicit On
Option Infer Off

'1.2) Definition of GymMember Class 
Public Class Member
    Private _MemName As String
    Private _Weight As Double
    Private _Age As Integer
    Private _Exercises() As Exercise
    Private _IneExercise As Integer
    Private _WeightLossAlert As String

    Public Sub New(NumberExercises As Integer)
        ReDim _Exercises(NumberExercises)
    End Sub

    Public Property MemName As String
        Get
            Return _MemName
        End Get
        Set(value As String)
            _MemName = value
        End Set
    End Property

    Public Property Weight As Double
        Get
            Return _Weight
        End Get
        Set(value As Double)
            _Weight = value
        End Set
    End Property

    Public Property Age As Integer
        Get
            Return _Age
        End Get
        Set(value As Integer)
            _Age = value
        End Set
    End Property

    Public Property Exercises(Ind As Integer) As Exercise
        Get
            Return _Exercises(Ind)
        End Get
        Set(value As Exercise)
            _Exercises(Ind) = value
        End Set
    End Property

    Public Property IneExercise As Integer
        Get
            Return _IneExercise
        End Get
        Set(value As Integer)
            _IneExercise = value
        End Set
    End Property

    Public Property WeightLossAlert As String
        Get
            Return _WeightLossAlert
        End Get
        Set(value As String)
            _WeightLossAlert = value
        End Set
    End Property

    '7.1) Definition of CalcWeightLossRatio Function
    Public Function CalcWeightLossRatio(ByVal TotalCaloriesBurnt As Double, ByVal Weight As Double) As Double
        Return TotalCaloriesBurnt / 7700 / Weight
    End Function

End Class
