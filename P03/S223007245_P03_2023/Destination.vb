Option Strict On
Option Explicit On
Option Infer Off

Public Class Destination

    Private _DestiantionName As String
    Private _Activities() As Activity
    Private _HighestPhotoVisIndex As Integer
    Private _TourismRating As String

    Public Sub New(NumberOfActivities As Integer)
        ReDim _Activities(NumberOfActivities)
    End Sub

    Public Property Activities(Index As Integer) As Activity
        Get
            Return _Activities(Index)
        End Get
        Set(value As Activity)
            _Activities(Index) = value
        End Set
    End Property

    Public Property DestinationName As String
        Get
            Return _DestiantionName
        End Get
        Set(value As String)
            _DestiantionName = value
        End Set
    End Property

    Public Property HighestPhotoVisIndex As Integer
        Get
            Return _HighestPhotoVisIndex
        End Get
        Set(value As Integer)
            _HighestPhotoVisIndex = value
        End Set
    End Property

    Public Property TourismRating As String
        Get
            Return _TourismRating
        End Get
        Set(value As String)
            _TourismRating = value
        End Set
    End Property

    '4. Definition of subroutine called CalcRatio
    Public Sub CalcRatio(ByVal x As Integer, ByVal y As Integer, ByRef r As Double)
        r = x / y
    End Sub
End Class
