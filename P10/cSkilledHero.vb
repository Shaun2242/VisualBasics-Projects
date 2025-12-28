Option Strict On
Option Explicit On
Option Infer Off

<Serializable> Public Class cSkilledHero
    Inherits cHero

    Private _Skills As Integer

    Public Sub New(ByVal BirthYear As Integer)
        MyBase.New(BirthYear)
    End Sub

    Public Property Skills As Integer
        Get
            Return _Skills
        End Get
        Set(value As Integer)
            _Skills = value
        End Set
    End Property

    Public Overrides Sub Fight(ByVal OpponentLevel As Integer)
        If _Skills > OpponentLevel Then
            WinLossDaw(1) += 1
        Else
            If _Skills >= (OpponentLevel / 2) Then
                WinLossDaw(3) += 1
            Else
                WinLossDaw(2) += 1
            End If
        End If

    End Sub

    Public Overrides Function ToAString() As String
        Return MyBase.ToAString()
    End Function


End Class
