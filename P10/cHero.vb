Option Strict On
Option Explicit On
Option Infer Off


<Serializable> Public Class cHero

    Private _Name As String
    Private _BirthYear As Integer
    Private _WinLossDraw(3) As Integer

    Public Sub New(ByVal BirthYear As Integer)
        _BirthYear = Validate(BirthYear)
    End Sub

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property WinLossDaw(ByVal Ind As Integer) As Integer
        Get
            Return Validate(_WinLossDraw(Ind))
        End Get
        Set(value As Integer)
            _WinLossDraw(Ind) = Validate(value)
        End Set
    End Property

    Public ReadOnly Property BirthYaer() As Integer
        Get
            Return _BirthYear
        End Get
    End Property

    Public Shared Function Validate(ByVal Value As Integer) As Integer
        If Value < 0 Then
            Value = 0
            Return Value
        Else
            Return Value
        End If
    End Function

    Public Function CalculateAge() As Integer
        Return 2023 - _BirthYear
    End Function

    Public Function CalculateTotalFights() As Integer
        Dim TotalFights As Integer
        For f As Integer = 1 To 3
            TotalFights += _WinLossDraw(f)
        Next
        Return TotalFights
    End Function

    Public Function CalculateVictoryRatio() As Double
        Dim Ratio As Double
        Ratio = _WinLossDraw(1) / CalculateTotalFights()
        Return Ratio
    End Function

    Public Overridable Sub Fight(ByVal OpponentLevel As Integer)

    End Sub

    Public Overridable Function ToAString() As String
        Return _Name & "-" & CalculateAge() & "-" & "[" & _WinLossDraw(1) & ": " & _WinLossDraw(2) & ": " & _WinLossDraw(3) & "]" & "-" & Format(((_WinLossDraw(1) / CalculateTotalFights()) * 100), "0.##") & "%"
    End Function

End Class
