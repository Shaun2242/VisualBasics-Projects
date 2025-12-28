Option Explicit On
Option Strict On
Option Infer Off

Public Class Cinema
    Inherits Entertainment
    Private _MovieName As String
    Private _MovieRating As Double

    Public Property MovieName As String
        Get
            Return _MovieName
        End Get
        Set(value As String)
            _MovieName = value
        End Set
    End Property

    Public Property MovieRating As Double
        Get
            Return _MovieRating
        End Get
        Set(value As Double)
            _MovieRating = value
        End Set
    End Property

    Public Overrides Function TotalIncome() As Double
        Return MyBase.TotalIncome() + (_MovieRating / 100)
    End Function

    Public Overrides Function Display(ByVal Price As Double, ByVal NumPeople As Integer, ByVal VariableA As String, ByVal VariableB As String, ByVal VariableC As String) As String

        Return "Cinema Price: " & Price & Environment.NewLine & "Number Of People: " & NumPeople & Environment.NewLine & "Movie Name: " & VariableA & Environment.NewLine & "Movie Rating: " & VariableB & Environment.NewLine & "Total Income: " & VariableC & Environment.NewLine

    End Function

End Class
