Option Strict On
Option Explicit On
Option Infer Off

'1.1) Definition of Exercise Class 
Public Class Exercise
    Private _ExerName As String
    Private _CalBurnt As Double
    Private _Reps() As Integer
    Private _TotCalBurnt As Double

    Public Sub New(NumberWeeks As Integer)
        ReDim _Reps(NumberWeeks)
    End Sub

    Public Property ExerName As String
        Get
            Return _ExerName
        End Get
        Set(value As String)
            _ExerName = value
        End Set
    End Property

    Public Property CalBurnt As Double
        Get
            Return _CalBurnt
        End Get
        Set(value As Double)
            _CalBurnt = value
        End Set
    End Property

    Public Property Reps(Ind As Integer) As Integer
        Get
            Return _Reps(Ind)
        End Get
        Set(value As Integer)
            _Reps(Ind) = value
        End Set
    End Property

    Public Property TotCalBurnt As Double
        Get
            Return _TotCalBurnt
        End Get
        Set(value As Double)
            _TotCalBurnt = value
        End Set
    End Property

    Public Sub CalcTotCals(ByVal Reps As Integer, ByVal Cals As Double, ByRef Tot As Double)
        Tot = Reps * Cals
    End Sub

End Class
