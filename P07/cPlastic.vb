Public Class cPlastic
    Inherits cRecyclable

    Public Sub New(ByVal Weight As Double, ByVal Volume As Double)
        MyBase.New(Weight, Volume)
    End Sub

    Public Overrides Function CalculateGrade() As Integer
        Grade = 1
        Return Grade
    End Function

    Public Overrides Function CalculateRecyclingPrice(ByVal Weight As Double, ByVal Grade As Integer) As Double
        Dim Price As Double

        Select Case Grade
            Case 1
                Price = 0.25 * Weight
            Case 2
                Price = 0.75 * Weight
            Case 3
                Price = 1 * Weight
            Case 4
                Price = 1.25 * Weight
            Case 5
                Price = 2 * Weight
        End Select

        Return Price

    End Function

    Public Overrides Function Display() As String

        Return "Recyclable: " & "Plastic" & Environment.NewLine & "Weight: " & Weight & Environment.NewLine & "Volume: " & Volume & Environment.NewLine & "Grade: " & Grade & Environment.NewLine & "Price: " & CalculateRecyclingPrice(Weight, Grade)

    End Function
End Class
