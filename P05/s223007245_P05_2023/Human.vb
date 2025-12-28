Option Strict On
Option Explicit On
Option Infer Off
'Define human class
Public Class Human

    Inherits Race
    Private _Speed As Double
    Private _Intelligence As Double

    Public Sub New(Name As String)
        MyBase.New(Name)
    End Sub

    Public Property Speed As Double
        Get
            Return _Speed
        End Get
        Set(value As Double)
            _Speed = value
        End Set
    End Property

    Public Property Intelligence As Double
        Get
            Return _Intelligence
        End Get
        Set(value As Double)
            _Intelligence = value
        End Set
    End Property

    Public Overrides Function Fight() As Double

        Return _Speed * Level

    End Function

    Public Overrides Function Defend() As Double

        Return _Intelligence * Level

    End Function

    Public Overrides Function Display() As String

        Return MyBase.Display() & Environment.NewLine & "Speed: " & _Speed & Environment.NewLine & "Intelligence: " & _Intelligence & Environment.NewLine & "Fight: " & Fight() & Environment.NewLine & "Defend: " & Defend() & Environment.NewLine

    End Function

End Class
