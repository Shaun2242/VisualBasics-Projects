Option Strict On
Option Explicit On
Option Infer Off
<Serializable> Public Class cVillain
    Private _IDNumber As Integer
    Private _Name As String
    Private _Loot(2) As Integer
    Private _Caught As Integer
    Private _Category As String


    Public Property IDNumber As Integer
        Get
            Return _IDNumber
        End Get
        Set(value As Integer)
            _IDNumber = value
        End Set

    End Property

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Loot(Ind As Integer) As Integer
        Get
            Return _Loot(Ind)
        End Get
        Set(value As Integer)
            _Loot(Ind) = value
        End Set
    End Property

    Public Property Caught As Integer
        Get
            Return _Caught
        End Get
        Set(value As Integer)
            _Caught = value
        End Set
    End Property

    Public Property Category As String
        Get
            Return _Category
        End Get
        Set(value As String)
            _Category = value
        End Set
    End Property

    'Validate value function
    Public Shared Function ValidateKey(ByVal key As Integer) As Integer

        If key < 1000 Or key > 7000 Then
            key = 0
            Return key
        Else
            Return key
        End If

    End Function

    'CalculateVillainry function
    Public Function CalculateVillainry() As Double

        Dim TotLoot As Integer

        For l As Integer = 1 To 2
            TotLoot += _Loot(l)
        Next
        Return TotLoot / _Caught

    End Function

    'Assign category function
    Public Function AssignCategory() As String

        If _Caught = 0 Then
            _Category = "A"
        Else
            If _Caught >= 1 And _Caught <= 5 Then
                _Category = "B"
            Else
                If _Caught >= 6 Then
                    _Category = "C"
                End If
            End If
        End If
        Return _Category

    End Function

    Public Function Display(ByVal Key As Integer) As String

        If Key = 1 Then
            Return CStr(_IDNumber)
        Else
            If Key = 2 Then
                Return _Name
            Else
                If Key = 3 Then
                    Return CStr(_Loot(1))
                Else
                    If Key = 4 Then
                        Return CStr(_Loot(2))
                    Else
                        If Key = 5 Then
                            Return CStr(_Caught)
                        Else
                            If Key = 6 Then
                                Return _Category
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Function

End Class
