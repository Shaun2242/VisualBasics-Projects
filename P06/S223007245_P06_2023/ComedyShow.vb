Option Explicit On
Option Strict On
Option Infer Off

Public Class ComedyShow

    Inherits Entertainment
    Private _Comedian() As Comedian
    Private _Duration As Double

    Public Sub New(ByVal nComedians As Integer)
        ReDim _Comedian(nComedians)
        For C As Integer = 1 To nComedians
            _Comedian(C) = New Comedian()
        Next C
    End Sub

    Public Property Comadian(ByVal Ind As Integer) As Comedian
        Get
            Return _Comedian(Ind)
        End Get
        Set(value As Comedian)
            _Comedian(Ind) = value
        End Set
    End Property

    Public Property Duration As Double
        Get
            Return _Duration
        End Get
        Set(value As Double)
            _Duration = value
        End Set
    End Property

    Public Overrides Function TotalIncome() As Double
        Return MyBase.TotalIncome() + (_Duration / 10)
    End Function

    Public Overrides Function Display(ByVal Price As Double, ByVal NumPeople As Integer, ByVal VariableA As String, ByVal VariableB As String, ByVal VariableC As String) As String

        Return "Comedy Show Price: " & Price & Environment.NewLine & "Number Of People: " & NumPeople & Environment.NewLine & "Show Duration: " & VariableA & Environment.NewLine & "Total Income: " & VariableC

    End Function

End Class
