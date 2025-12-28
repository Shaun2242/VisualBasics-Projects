Option Strict On
Option Explicit On
Option Infer Off

Public Class cHighSchool
    Inherits cStudent

    Private _ExtraMural As Boolean
    Private _Prefect As Boolean

    Public Sub New(ByVal FullName As String)
        MyBase.New(FullName, 3)
    End Sub


    Public Property ExtraMural As Boolean
        Get
            Return ExtraMural
        End Get
        Set(value As Boolean)
            _ExtraMural = value
        End Set
    End Property

    Public Property Prefect As Boolean
        Get
            Return Prefect
        End Get
        Set(value As Boolean)
            _Prefect = value
        End Set
    End Property

    Public Overrides Function CalculateAverage() As Double
        Dim Average As Double
        Average = MyBase.CalculateAverage()
        EvaluateStudent(Qualifies)
        Return Average


    End Function
    Public Overrides Sub EvaluateStudent(ByRef Qualifies As Boolean)

        If Average >= 80 Then
            Qualifies = True
        Else
            If Average >= 70 And Prefect = True Or ExtraMural = True Then
                Qualifies = True
            Else
                Qualifies = False
            End If
        End If

    End Sub

    Public Overrides Function Display() As String
        Return "Type: HighSchool" & Environment.NewLine & MyBase.Display()
    End Function


End Class
