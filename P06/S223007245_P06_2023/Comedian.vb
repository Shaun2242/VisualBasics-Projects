Option Explicit On
Option Strict On
Option Infer Off

Public Class Comedian
    Private _Name As String
    Private _Age As Integer

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
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

    Public Function Eligibility() As String
        If _Age >= 18 Then
            Return "Can participate"
        Else
            Return "Can't participate"
        End If
    End Function

End Class
