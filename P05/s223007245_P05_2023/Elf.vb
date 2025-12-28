Option Strict On
Option Explicit On
Option Infer Off
'Define Elf class
Public Class Elf

    Inherits Race
    Private _Accuracy As Double
    Private _Agility As Double

    Public Sub New(Name As String)
        MyBase.New(Name)
    End Sub

    Public Property Accuracy As Double
        Get
            Return _Accuracy
        End Get
        Set(value As Double)
            _Accuracy = value
        End Set
    End Property

    Public Property Agility As Double
        Get
            Return _Agility
        End Get
        Set(value As Double)
            _Agility = value
        End Set
    End Property

    Public Overrides Function Fight() As Double

        Return _Agility * _Accuracy

    End Function

    Public Overrides Function Defend() As Double

        Return Level * _Agility

    End Function

    Public Overrides Function Display() As String

        Return MyBase.Display() & Environment.NewLine & "Agility: " & _Agility & Environment.NewLine & "Accuracy: " & _Accuracy & Environment.NewLine & "Fight: " & Fight() & Environment.NewLine & "Defend: " & Defend() & Environment.NewLine

    End Function

End Class
