Option Strict On
Option Explicit On
Option Infer Off


Public Class OutOfRangeException
    Inherits Exception
    Public Sub New()
        MyBase.New("Value Entered Is Out Of Range")
    End Sub
End Class
