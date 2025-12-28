Option Strict On
Option Explicit On
Option Infer Off
'Define Orc class
Public Class Orc

    Inherits Race
    Private _Scariness As Double
    Private _Strength As Double

    Public Sub New(Name As String)
        MyBase.New(Name)
    End Sub

    Public Property Scariness As Double
        Get
            Return _Scariness
        End Get
        Set(value As Double)
            _Scariness = value
        End Set
    End Property

    Public Property Strength As Double
        Get
            Return _Strength
        End Get
        Set(value As Double)
            _Strength = value
        End Set
    End Property

    Public Overrides Function Fight() As Double

        Return Attack + _Scariness + _Strength

    End Function

    Public Overrides Function Defend() As Double

        Return _Strength * _Scariness

    End Function

    Public Overrides Function Display() As String

        Return MyBase.Display() & Environment.NewLine & "Strength: " & _Strength & Environment.NewLine & "Scariness: " & _Scariness & Environment.NewLine & "Fight: " & Fight() & Environment.NewLine & "Defend: " & Defend() & Environment.NewLine

    End Function
End Class
