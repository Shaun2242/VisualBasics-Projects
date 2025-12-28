Option Strict On
Option Explicit On
Option Infer Off

<Serializable> Public Class cStudent

    Private _FullName As String
    Private _NumMarks As Integer
    Protected _Marks() As Integer
    Private _Average As Double
    Private _Qualifies As Boolean


    Public Sub New(ByVal FullName As String, ByVal NumMarks As Integer)
        _FullName = FullName
        _NumMarks = NumMarks
        ReDim _Marks(_NumMarks)
    End Sub

    Public Property Marks(ByVal Ind As Integer) As Integer
        Get
            Return _Marks(Ind)
        End Get
        Set(value As Integer)
            _Marks(Ind) = value
        End Set
    End Property

    Public ReadOnly Property FullName As String
        Get
            Return _FullName
        End Get
    End Property

    'Define utiliy function
    Public Shared Function ValidateMarks(ByVal Marks As Integer) As Integer

        If Marks < 0 Or Marks > 100 Then
            Marks = 0
            Return Marks
        Else
            Return Marks
        End If
    End Function

    Public ReadOnly Property Average As Double
        Get
            Return _Average
        End Get

    End Property

    Public ReadOnly Property Qualifies As Boolean
        Get
            Return _Qualifies
        End Get
    End Property

    'Define calculateaverage function
    Public Overridable Function CalculateAverage() As Double
        Dim TotalMark As Integer = 0

        For m As Integer = 1 To _NumMarks
            TotalMark += Marks(m)
        Next m
        _Average = TotalMark / (100 * _NumMarks) * 100
        EvaluateStudent(_Qualifies)
        Return _Average
    End Function


    'Define evaluatestudent subrutine
    Public Overridable Sub EvaluateStudent(ByRef Qualifies As Boolean)
        _Qualifies = Qualifies
    End Sub

    'Define define display function
    Public Overridable Function Display() As String
        Return "FullName: (" & _FullName & ")" & Environment.NewLine & "Average: (" & _Average & ")" & Environment.NewLine & "Qaulifies: " & (_Qualifies)
    End Function

End Class
