Option Explicit On
Option Strict On
Option Infer Off

Public MustInherit Class Entertainment
    Private _Price As Double
    Private _nPeople As Integer

    Public Property Price As Double
        Get
            Return _Price
        End Get
        Set(value As Double)
            _Price = value
        End Set
    End Property

    Public Property nPeople As Integer
        Get
            Return _nPeople
        End Get
        Set(value As Integer)
            _nPeople = value
        End Set
    End Property

    Public Overridable Function TotalIncome() As Double
        Return _Price * _nPeople
    End Function

    Public MustOverride Function Display(ByVal Price As Double, ByVal NumPeople As Integer, ByVal VariableA As String, ByVal VariableB As String, ByVal VariableC As String) As String

End Class
