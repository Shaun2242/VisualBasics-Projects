Option Strict On
Option Explicit On
Option Infer Off

<Serializable> Public Class cSpecialPowersHero
    Inherits cHero
    Implements ICanHide



    Public Sub New(ByVal BirthYear As Integer)
        MyBase.New(BirthYear)
    End Sub
    Private _Aliases As Integer
    Private _Level As Integer

    Public Property Aliases As Integer Implements ICanHide.Aliases
        Get
            Return _Aliases
        End Get
        Set(value As Integer)
            _Aliases = value
        End Set
    End Property

    Public Property Level As Integer
        Get
            Return _Level
        End Get
        Set(value As Integer)
            _Level = value
        End Set
    End Property

    Public Sub Distract() Implements ICanHide.Distract
        If _Aliases > 0 Then
            _Aliases -= 1
            _Level += 15
        End If
    End Sub

    Public Overrides Sub Fight(ByVal OpponentLevel As Integer)
        If _Level > OpponentLevel Then
            WinLossDaw(1) += 1
        Else
            If _Level <= OpponentLevel And _Level >= OpponentLevel / 2 Then
                Distract()
                WinLossDaw(3) += 1
            Else
                If _Level < OpponentLevel Then
                    WinLossDaw(2) += 1
                End If
            End If
        End If

    End Sub

    Public Overrides Function ToAString() As String
        Return MyBase.ToAString()
    End Function

End Class
