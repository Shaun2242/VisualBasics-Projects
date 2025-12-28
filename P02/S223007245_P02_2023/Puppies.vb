Public Class Puppy

    Private _Name As String
    Private _Breed As String
    Private _Gender As String
    Private _Age As Integer
    Private _Weight() As Double
    Private _FoodPerPup() As Double
    Private _TotMoney As Double


    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property FoodPerPup() As Double()
        Get
            For f As Integer = 1 To _FoodPerPup.Length
                Return _FoodPerPup
            Next f
        End Get
        Set(value() As Double)
            For f As Integer = 1 To _FoodPerPup.Length
                _FoodPerPup(f) = value(f)
            Next f
        End Set
    End Property

    Public WriteOnly Property Breed As String
        Set(value As String)
            _Breed = value
        End Set
    End Property

    Public WriteOnly Property Gender As Integer
        Set(value As Integer)
            _Gender = value
        End Set
    End Property

    Public WriteOnly Property Age As Integer
        Set(value As Integer)
            _Age = value
        End Set
    End Property

    Public Sub New(PSize As Integer, Wsize As Integer)
        ReDim _Weight(Wsize)
        ReDim _FoodPerPup(PSize)
    End Sub


    Public Property Weight() As Double()
        Get
            For w As Integer = 1 To _Weight.Length
                Return _Weight
            Next w
        End Get
        Set(value() As Double)
            For w As Integer = 1 To _Weight.Length
                _Weight(w) = value(w)
            Next w
        End Set
    End Property

    Public Function CalcFoodPerPuppy(ByVal sizep As Integer, ByVal sized As Integer) As Double
        Dim TotalWeight As Double = 0
        For p As Integer = 1 To sizep
            For w As Integer = 1 To sized
                TotalWeight += _Weight(w)
                If TotalWeight < 500 Then
                    _FoodPerPup(p) = 10
                Else
                    If TotalWeight > 500 And TotalWeight < 1000 Then
                        _FoodPerPup(p) = 2 * 10
                    Else
                        _FoodPerPup(p) = 3 * 10
                    End If
                End If
            Next w
            Return _FoodPerPup(p)
        Next p
    End Function

    Public Function CalcTotalFood(ByVal sizep As Integer) As Double
        Dim TotalFood As Double

        For p As Integer = 1 To sizep
            TotalFood = TotalFood + _FoodPerPup(p)
        Next p

        Return TotalFood
    End Function

End Class
