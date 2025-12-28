Public Class InvalidInteger
    Inherits Exception

    Public Sub New()
        MyBase.New("Enter positive values for weight and volume")
    End Sub
End Class
