<Serializable> Public Class cUniversity
    Inherits cStudent

    Public Sub New(ByVal FullName As String)
        MyBase.New(FullName, 2)
    End Sub


    Public Overrides Function CalculateAverage() As Double
        Dim Average As Double
        Average = MyBase.CalculateAverage()
        EvaluateStudent(Qualifies)
        Return Average

    End Function


    Public Overrides Sub EvaluateStudent(ByRef Qualifies As Boolean)

        If Average >= 65 Then
            Qualifies = True
        Else
            Qualifies = False
        End If

    End Sub

    Public Overrides Function Display() As String
        Return "Type: University" & Environment.NewLine & MyBase.Display()
    End Function

End Class
