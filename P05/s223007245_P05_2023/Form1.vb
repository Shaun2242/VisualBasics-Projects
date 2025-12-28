' **************************************************************************************************
' Surname, Initials: Lekgothoane MS
' Student Number:223007245
' Practical: P2023-05
' **************************************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmChaosInc

    'Variable declaration
    Private Race(3) As Race
    Private Humans As Human
    Private Orcs As Orc
    Private Elves As Elf

    Private Enum Type
        Human = 1
        Orc = 2
        Elf = 3
    End Enum

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim Choice As Integer
        Dim Name As String

        'Select race and take in data for selected race from user 
        Choice = CInt(InputBox("Please select the class you wish to test:" & Environment.NewLine + "1.Human" & Environment.NewLine + "2.Orc" & Environment.NewLine + "3.Elf"))
        Select Case Choice
            Case Type.Human
                'Take in inputs for human data
                Name = InputBox("Enter name for human ")
                Humans = New Human(Name)
                Race(1) = Humans

                Humans.Level = CInt(InputBox("Enter level for " & Race(1).Name))
                Humans.Attack = CDbl(InputBox("Enter attack status for " & Race(1).Name))
                Humans.Speed = CDbl(InputBox("Enter speed in km/h for " & Race(1).Name))
                Humans.Intelligence = CDbl(InputBox("Enter intelligence for " & Race(1).Name))

            Case Type.Orc
                'Take in inputs for Orc data
                Name = InputBox("Enter name for orc")
                Orcs = New Orc(Name)
                Race(2) = Orcs

                Orcs.Level = CInt(InputBox("Enter level for " & Orcs.Name))
                Orcs.Attack = CDbl(InputBox("Enter attack status for " & Orcs.Name))
                Orcs.Scariness = CDbl(InputBox("Enter scariness for " & Orcs.Name))
                Orcs.Strength = CDbl(InputBox("Enter strength for " & Orcs.Name))

            Case Type.Elf
                'Take in inputs for Elf data
                Name = InputBox("Enter name for elf ")
                Elves = New Elf(Name)
                Race(3) = Elves

                Elves.Level = CInt(InputBox("Enter level for " & Elves.Name))
                Elves.Attack = CDbl(InputBox("Enter attack status for " & Elves.Name))
                Elves.Accuracy = CDbl(InputBox("Enter accuracy in percentage for " & Elves.Name))
                Elves.Agility = CDbl(InputBox("Enter agility for " & Elves.Name))

        End Select
    End Sub

    Private Sub btnHuman_Click(sender As Object, e As EventArgs) Handles btnHuman.Click

        'Display information for Human
        txtHuman.Text = Humans.Display()

    End Sub

    Private Sub btnOrc_Click(sender As Object, e As EventArgs) Handles btnOrc.Click

        'Display information for Orc
        txtOrc.Text = Orcs.Display()

    End Sub

    Private Sub btnElf_Click(sender As Object, e As EventArgs) Handles btnElf.Click

        'Display information for Elf
        txtElf.Text = Elves.Display()

    End Sub

End Class


