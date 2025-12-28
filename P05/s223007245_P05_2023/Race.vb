Option Strict On
Option Explicit On
Option Infer Off
'Define Race base class
Public MustInherit Class Race

    Private _Name As String
    Private _Level As Integer
    Private _Attack As Double

    Public Sub New(Name As String)
        _Name = Name
    End Sub

    Public ReadOnly Property Name As String
        Get
            Return _Name
        End Get
    End Property

    Public Property Level As Integer
        Get
            Return _Level
        End Get
        Set(value As Integer)
            _Level = value
        End Set
    End Property

    Public Property Attack As Double
        Get
            Return _Attack
        End Get
        Set(value As Double)
            _Attack = value
        End Set
    End Property

    Public MustOverride Function Fight() As Double

    Public MustOverride Function Defend() As Double

    Public Overridable Function Display() As String

        Return "Name: " & _Name & Environment.NewLine & "Level: " & _Level & Environment.NewLine & "Attack: " & _Attack

    End Function

End Class
