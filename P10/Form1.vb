' **************************************************************************************************
' Surname, Initials: MS Lekgothoane
' Student Number: 223007245
' Practical: P2023-10
' **************************************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmHero
    'Variable declarations
    Private Heros() As cHero
    Private SkilledHero As cSkilledHero
    Private SpecialHero As cSpecialPowersHero
    Private HeroType As Integer
    Private FS As FileStream
    Private BF As BinaryFormatter

    'Enumiration
    Enum Type
        Skilled = 1
        Special = 2
    End Enum

    Private Sub ResizeArray()
        ReDim Heros(CInt(InputBox("Enter Number Of Heros")))
        'ReDim SpecialHeros(Heros.Length - 1)
    End Sub

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click

        'Resize Array
        ResizeArray()

        'Take in inputs from user
        For h As Integer = 1 To Heros.Length - 1
            Dim BirthYear As Integer = CInt(InputBox("Enter BirthYear For Hero " & h))
            Heros(h) = New cHero(BirthYear)

            'Exception handling 
            Try
                HeroType = CInt(InputBox("Enter Hero Type For Hero " & h & ": (1) SkilledHero, (2) SpecialPowersHero "))
                If HeroType <> 1 And HeroType <> 2 Then
                    Throw New OutOfMemoryException
                End If
            Catch ex As OutOfMemoryException
                MsgBox("Value Entered Is Out Of Range")
            End Try

            'Chosing type of hero
            Select Case HeroType
                Case Type.Skilled
                    SkilledHero = New cSkilledHero(BirthYear)
                    SkilledHero.Name = InputBox("Enter Name For Hero " & h)
                    SkilledHero.Skills = CInt(InputBox("Enter Number Of Skills for hero " & h))
                    Dim OpponentLevel As Integer
                    For f As Integer = 1 To 3
                        OpponentLevel = CInt(InputBox("Enter Opponent Level For Fight " & f))

                        'Polymorphism
                        SkilledHero.Fight(OpponentLevel)
                    Next f
                    Heros(h) = SkilledHero
                Case Type.Special
                    counter += 1
                    ReDim Remainder(counter)
                    SpecialHero = New cSpecialPowersHero(BirthYear)
                    SpecialHero.Name = InputBox("Enter Name For Hero " & h)
                    SpecialHero.Aliases = CInt(InputBox("Enter Number Of Alliases for hero " & h))
                    SpecialHero.Level = CInt(InputBox("Enter Level for hero " & h))
                    For r As Integer = 1 To Remainder.Length - 1
                        Remainder(r) = SpecialHero.Aliases Mod 2
                    Next r
                    Dim OpponentLevel As Integer
                    For f As Integer = 1 To 3
                        OpponentLevel = CInt(InputBox("Enter Opponent Level For Fight " & f))

                        'Polymorphism 
                        SpecialHero.Fight(OpponentLevel)

                    Next f
                    Heros(h) = SpecialHero
            End Select
        Next h
    End Sub

    Private Remainder() As Integer

    Private Sub btnDisHeroInf_Click(sender As Object, e As EventArgs) Handles btnDisHeroInf.Click

        'Display Information for each hero
        For h As Integer = 1 To Heros.Length - 1
            txtHeroInf.Text += Heros(h).ToAString() & vbCrLf
        Next h

    End Sub

    'Private SpecialHeros() As cHero
    Private counter As Integer = 0
    Private Sub btnWriteToFile_Click(sender As Object, e As EventArgs) Handles btnWriteToFile.Click

        'Write Infromation To File 
        FS = New FileStream("Retaliators.ifm", FileMode.Create, FileAccess.Write)
        BF = New BinaryFormatter()

        For h As Integer = 1 To Heros.Length - 1
            If TypeOf Heros(h) Is cSpecialPowersHero Then
                BF.Serialize(FS, Heros(h))
            End If

            'If Not IsNothing(SpecialHeros(h)) Then
            '    BF.Serialize(FS, SpecialHeros(h))
            'End If
        Next h

        'Clean up
        FS.Flush()
        FS.Close()
        BF = Nothing
        FS = Nothing

    End Sub

    Private Sub btnReadFromFile_Click(sender As Object, e As EventArgs) Handles btnReadFromFile.Click

        'Read Information From File


        FS = New FileStream("Retaliators.ifm", FileMode.Open, FileAccess.Read)
        BF = New BinaryFormatter()

        For h As Integer = 1 To Heros.Length - 1
            If TypeOf Heros(h) Is cSpecialPowersHero And Remainder(h) = 0 Then
                While FS.Position < FS.Length
                    'Dim DiserializedObject As Object = BF.Deserialize(FS)
                    'If TypeOf DiserializedObject Is cSpecialPowersHero Then
                    SpecialHero = DirectCast(Heros(h), cSpecialPowersHero)
                    'End If
                End While
                If Not IsNothing(SpecialHero) Then
                    txtRecInf.Text += SpecialHero.ToAString() & vbCrLf
                End If
            Else
                txtRecInf.Text += ""

            End If
        Next h
        FS.Close()

    End Sub
End Class
