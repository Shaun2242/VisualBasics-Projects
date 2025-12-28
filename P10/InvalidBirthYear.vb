
Option Strict On
Option Explicit On
Option Infer Off
Public Class InvalidBirthYearException
    Inherits Exception

    Private Sub New()
        MyBase.New("Invalid Birth Year")
    End Sub
End Class
