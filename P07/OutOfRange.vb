Public Class OutOfRange
    Inherits Exception

    Public Sub New()
        MyBase.New("Please choose within the given range")
    End Sub

End Class
