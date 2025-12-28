Option Strict On
Option Explicit On
Option Infer Off

<Serializable> Public Class cCUATeam

    Private _TeamID As Integer
    Private _PowerValue As Integer
    Private _Villains() As cVillain
    Private _TeamMembers As Integer

    Public Sub New(ByVal TeamMembers As Integer)
        _TeamMembers = TeamMembers
        ReDim _Villains(_TeamMembers)
        For v As Integer = 1 To _TeamMembers
            _Villains(v) = New cVillain()
        Next
    End Sub

    Public Property TeamID As Integer
        Get
            Return _TeamID
        End Get
        Set(value As Integer)
            _TeamID = value
        End Set
    End Property


    Public Property PowerValue As Integer
        Get
            Return _PowerValue
        End Get
        Set(value As Integer)
            _PowerValue = value
        End Set
    End Property


    Public Property Villains(ByVal Ind As Integer) As cVillain
        Get
            Return _Villains(Ind)
        End Get
        Set(value As cVillain)
            _Villains(Ind) = value
        End Set
    End Property


    Public Property TeamMembers As Integer
        Get
            Return _TeamMembers
        End Get
        Set(value As Integer)
            _TeamMembers = value
        End Set
    End Property

    'DeterminePowerValue Function
    Public Function DeterminePowerValue(ByVal Category As String) As Integer
        Dim TotVillains As Integer = 0

        If Category = "A" Then
            TotVillains += 1
        End If
        _PowerValue = TotVillains
        Return _PowerValue

    End Function

    'Display function
    Public Function Display(ByVal v As Integer) As String

        Return "TeamID: " & _TeamID & vbCrLf & "PowerValue: " & DeterminePowerValue(Villains(v).Category) & vbCrLf & "TeamMembers: " & _TeamMembers

    End Function


End Class
