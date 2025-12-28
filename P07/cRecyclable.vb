'A) Defined cRecyclable class
Public Class cRecyclable
    Private _Weight As Double
    Private _Grade As Integer
    Private _Volume As Double

    Public Sub New(ByVal Weight As Double, ByVal Volume As Double)
        Validate(Weight, Volume)
        _Weight = Weight
        _Volume = Volume
    End Sub

    Public ReadOnly Property Weight As Double
        Get
            Return _Weight
        End Get
    End Property

    Public ReadOnly Property Volume As Double
        Get
            Return _Volume
        End Get
    End Property

    Public Property Grade As Integer
        Get
            Return _Grade
        End Get
        Set(value As Integer)
            _Grade = value
        End Set
    End Property

    'Utility method
    Public Shared Function Validate(ByRef Weight As Double, ByRef Volume As Double) As Double

        If Weight < 0 Then
            Weight = 0
        End If

        If Volume < 0 Then
            Volume = 0
        End If

        Return Volume And Weight
    End Function

    'Define CalculateGrade function
    Public Overridable Function CalculateGrade() As Integer
        Dim Ratio As Double

        Ratio = _Volume / _Weight

        If Ratio < 1 Then
            _Grade = 1
        Else
            If Ratio >= 1 And Ratio < 4 Then
                _Grade = 2
            Else
                If Ratio >= 4 And Ratio < 7 Then
                    _Grade = 3
                Else
                    If Ratio >= 7 And Ratio < 9 Then
                        _Grade = 4
                    Else
                        _Grade = 5
                    End If
                End If
            End If
        End If

        Return _Grade
    End Function

    'Define CalculateRecyclingPrice function
    Public Overridable Function CalculateRecyclingPrice(ByVal Weight As Double, ByVal Grade As Integer) As Double
        Dim Price As Double

        Select Case _Grade
            Case 1
                Price = 0.25 * _Weight
            Case 2
                Price = 0.75 * _Weight
            Case 3
                Price = 1 * _Weight
            Case 4
                Price = 1.25 * _Weight
            Case 5
                Price = 2 * _Weight
        End Select

        Return Price

    End Function

    'Define display function
    Public Overridable Function Display() As String

        Return "Weight: " & _Weight & Environment.NewLine & "Volume: " & _Volume & Environment.NewLine & "Grade: " & _Grade & Environment.NewLine & "Price: " & CalculateRecyclingPrice(_Weight, _Grade)

    End Function
End Class
