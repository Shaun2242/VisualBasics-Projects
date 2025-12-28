Option Strict On
Option Explicit On
Option Infer Off

Public Class Activity

    Private _ActivityName As String
    Private _nVisitors As Integer
    Private _nPhotos() As Integer
    Private _TotPhotos As Integer
    Private _PhotoVisitRatio As Double

    Public Sub New(NumberOfSites As Integer)
        ReDim _nPhotos(NumberOfSites)
    End Sub

    Public Property ActivityName As String
        Get
            Return _ActivityName
        End Get
        Set(value As String)
            _ActivityName = value
        End Set
    End Property

    Public Property nVisitors As Integer
        Get
            Return _nVisitors
        End Get
        Set(value As Integer)
            _nVisitors = value
        End Set
    End Property

    Public Property nPhotos(Index As Integer) As Integer

        Get
            Return _nPhotos(Index)
        End Get
        Set(value As Integer)
            _nPhotos(Index) = value
        End Set

    End Property

    Public Property TotPhotos As Integer
        Get
            Return _TotPhotos
        End Get
        Set(value As Integer)
            _TotPhotos = value
        End Set
    End Property

    Public Property PhotoVisitRatio As Double
        Get
            Return _PhotoVisitRatio
        End Get
        Set(value As Double)
            _PhotoVisitRatio = value
        End Set
    End Property

End Class
