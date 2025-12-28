' **************************************************************************************************
' Surname, Initials: Lekgothoane MS
' Student Number: 223007245
' Practical: P2023-09
' **************************************************************************************************
Option Strict On
Option Explicit On
Option Infer Off

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmCUA

    Private Villain As VillainRec
    Private CUATeam() As cCUATeam
    Private Const FILE_NAME As String = "CUA.ifm"
    Private Const REC_SIZE As Integer = 56
    Private Const NUM_REC As Integer = 15
    Private Const PRIME_NUMBER As Integer = 13
    Private BlankRec As VillainRec
    Private FS As FileStream
    Private BW As BinaryWriter
    Private BR As BinaryReader

    Private Sub PIG(ByVal r As Integer, ByVal c As Integer, ByVal t As String)

        grdCUA.Row = r
        grdCUA.Col = c
        grdCUA.Text = t

    End Sub

    Private Sub frmCUA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReDim BLANKREC.Loot(2)
        BlankRec.VillainID = -1
        BlankRec.Name = "BLANK"
        BLANKREC.Loot(1) = 0
        BlankRec.Loot(2) = 0
        BlankRec.Caught = 0
        CreateBlankRecord()

        SetupGrid()
    End Sub

    Private Sub SetupGrid()

        'Set grid dimensions

        grdCUA.Rows = 16
        grdCUA.Cols = 7

        'Label grid

        PIG(0, 0, "VillainID")
        PIG(0, 1, "Name")
        PIG(0, 2, "Caught")
        PIG(0, 3, "Category")
        PIG(0, 4, "Loot 1")
        PIG(0, 5, "Loot 2")
        PIG(0, 6, "Villainry")

        PIG(1, 0, "1001")
        PIG(2, 0, "1002")
        PIG(3, 0, "1003")
        PIG(4, 0, "1004")
        PIG(5, 0, "1005")
        PIG(6, 0, "1006")
        PIG(7, 0, "1007")
        PIG(8, 0, "1008")
        PIG(9, 0, "1009")
        PIG(10, 0, "1010")
        PIG(11, 0, "1011")
        PIG(12, 0, "1012")
        PIG(13, 0, "1013")
        PIG(14, 0, "1014")
        PIG(15, 0, "1015")

    End Sub

    Private Structure VillainRec

        Public VillainID As Integer
        <VBFixedString(20)> Public Name As String
        Public Loot() As Integer
        Public Caught As Integer

    End Structure

    Private Sub ResizeArrays()

        ReDim CUATeam(3)
        ReDim Villain.Loot(2)

    End Sub

    Private Sub CreateBlankRecord()
        'Creating blank records 
        FS = New FileStream(FILE_NAME, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)

        FS.SetLength(NUM_REC * REC_SIZE)
        FS.Seek(Hash(Villain.VillainID) * 56, SeekOrigin.Begin)
        BW.Write(BlankRec.VillainID)
        BW.Write(BlankRec.Name)
        BW.Write(BlankRec.Loot(1))
        BW.Write(BlankRec.Loot(2))
        BW.Write(BlankRec.Caught)

        FS.Flush()
        FS.Close()
        FS = Nothing
        BW = Nothing

    End Sub

    'Hash function
    Private Function Hash(ByVal Key As Integer) As Integer

        Return Key Mod PRIME_NUMBER

    End Function

    Private Enum Type
        Team1ID = 100
        Team2ID = 200
        Team3ID = 300
    End Enum

    Private VillainID As Integer
    Private TeamMembers As Integer
    Private TeamID As Integer

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnCaptVal.Click
        'Resize arrays
        ResizeArrays()

        'Take in inputs from user 
        TeamID = CInt(InputBox("Enter ID For team (Options: 100,200,300)"))
        TeamMembers = CInt(InputBox("Enter number of team members for team (Each Team Consists Of 5 Members)"))
        VillainID = CInt(InputBox("Enter villain ID"))
        If VillainID >= 1001 And VillainID <= 1015 Then
            VillainIndex = VillainID - 1000
        Else
            VillainIndex = 1
        End If
        TeamIndex = TeamID \ 100
    End Sub

    Private Sub btnSaveToFile_Click(sender As Object, e As EventArgs) Handles btnSaveToFile.Click
        'Taking in information and writing to the file 
        For t As Integer = 1 To 3
            CUATeam(t) = New cCUATeam(5)
        Next t

        Select Case TeamID
            Case Type.Team1ID
                If VillainID = 1001 Then
                    Villain.VillainID = 1001
                    Villain.Name = "Villain 1"
                    Villain.Loot(1) = 100
                    Villain.Loot(2) = 10000
                    Villain.Caught = 2
                    SaveToFile()
                Else
                    If VillainID = 1002 Then
                        Villain.VillainID = 1002
                        Villain.Name = "Villain 2"
                        Villain.Loot(1) = 10052
                        Villain.Loot(2) = 12004
                        Villain.Caught = 5
                        SaveToFile()
                    Else
                        If VillainID = 1003 Then
                            Villain.VillainID = 1003
                            Villain.Name = "Villain 3"
                            Villain.Loot(1) = 147562
                            Villain.Loot(2) = 12000
                            Villain.Caught = 3
                            SaveToFile()
                        Else
                            If VillainID = 1004 Then
                                Villain.VillainID = 1004
                                Villain.Name = "Villain 4"
                                Villain.Loot(1) = 652
                                Villain.Loot(2) = 85296
                                Villain.Caught = 6
                                SaveToFile()
                            Else
                                If VillainID = 1005 Then
                                    Villain.VillainID = 1005
                                    Villain.Name = "Villain 5"
                                    Villain.Loot(1) = 965785
                                    Villain.Loot(2) = 45685
                                    Villain.Caught = 6
                                    SaveToFile()
                                End If
                            End If
                        End If
                    End If
                End If
            Case Type.Team2ID
                If VillainID = 1006 Then
                    Villain.VillainID = 1006
                    Villain.Name = "Villain 6"
                    Villain.Loot(1) = 85456
                    Villain.Loot(2) = 9674
                    Villain.Caught = 4
                    SaveToFile()
                Else
                    If VillainID = 1007 Then
                        Villain.VillainID = 1007
                        Villain.Name = "Villain 7"
                        Villain.Loot(1) = 741147
                        Villain.Loot(2) = 963369
                        Villain.Caught = 7
                        SaveToFile()
                    Else
                        If VillainID = 1008 Then
                            Villain.VillainID = 1008
                            Villain.Name = "Villain 8"
                            Villain.Loot(1) = 1789456
                            Villain.Loot(2) = 123456
                            Villain.Caught = 1
                            SaveToFile()
                        Else
                            If VillainID = 1009 Then
                                Villain.VillainID = 1009
                                Villain.Name = "Villain 9"
                                Villain.Loot(1) = 7523456
                                Villain.Loot(2) = 1741789
                                Villain.Caught = 1
                                SaveToFile()
                            Else
                                If VillainID = 1010 Then
                                    Villain.VillainID = 1010
                                    Villain.Name = "Villain 10"
                                    Villain.Loot(1) = 74185296
                                    Villain.Loot(2) = 178923
                                    Villain.Caught = 2
                                    SaveToFile()
                                End If
                            End If
                        End If
                    End If
                End If
            Case Type.Team3ID
                If VillainID = 1011 Then
                    Villain.VillainID = 1011
                    Villain.Name = "Villain 11"
                    Villain.Loot(1) = 10052
                    Villain.Loot(2) = 196575
                    Villain.Caught = 5
                    SaveToFile()
                Else
                    If VillainID = 1012 Then
                        Villain.VillainID = 1012
                        Villain.Name = "Villain 12"
                        Villain.Loot(1) = 10052856
                        Villain.Loot(2) = 10000000
                        Villain.Caught = 2
                        SaveToFile()
                    Else
                        If VillainID = 1013 Then
                            Villain.VillainID = 1013
                            Villain.Name = "Villain 13"
                            Villain.Loot(1) = 178945612
                            Villain.Loot(2) = 12058
                            Villain.Caught = 5
                            SaveToFile()
                        Else
                            If VillainID = 1014 Then
                                Villain.VillainID = 1014
                                Villain.Name = "Villain 14"
                                Villain.Loot(1) = 145696
                                Villain.Loot(2) = 12741
                                Villain.Caught = 10
                                SaveToFile()
                            Else
                                If VillainID = 1015 Then
                                    Villain.VillainID = 1015
                                    Villain.Name = "Villain 15"
                                    Villain.Loot(1) = 9875612
                                    Villain.Loot(2) = 9865
                                    Villain.Caught = 1
                                    SaveToFile()

                                Else
                                    CreateBlankRecord()
                                End If
                            End If
                        End If
                    End If
                End If
        End Select
    End Sub

    Private Sub SaveToFile()
        'Creating and saving to the file
        FS = New FileStream(FILE_NAME, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(FS)
        FS.SetLength(NUM_REC * REC_SIZE)

        For v As Integer = 0 To 14
            FS.Seek(Hash(v) * 56, SeekOrigin.Begin)
            BW.Write(Villain.VillainID)
            BW.Write(Villain.Name)
            BW.Write(Villain.Loot(1))
            BW.Write(Villain.Loot(2))
            BW.Write(Villain.Caught)
        Next v

        FS.Flush()
        FS.Close()
        FS = Nothing
        BW = Nothing
    End Sub

    Private Function ReadFromFile(ByVal Key As Integer) As VillainRec
        'Reading from the file
        FS = New FileStream(FILE_NAME, FileMode.Open, FileAccess.Read)
        BR = New BinaryReader(FS)
        If Villain.VillainID < 1000 Or Villain.VillainID > 7000 Then
            CreateBlankRecord()
        Else

            FS.Seek(Hash(Villain.VillainID) * 56, SeekOrigin.Begin)
                Villain.VillainID = BR.ReadInt32()
                Villain.Name = BR.ReadString()
                Villain.Loot(1) = BR.ReadInt32()
                Villain.Loot(2) = BR.ReadInt32()
                Villain.Caught = BR.ReadInt32()

        End If
        FS.Close()
        FS = Nothing
        BR = Nothing

        Return Villain

    End Function

    Private VillainIndex As Integer
    Private TeamIndex As Integer

    Private Sub btnReadFromFile_Click(sender As Object, e As EventArgs) Handles btnReadFromFile.Click
        'Reading information from file and storing in the object array 
        For t As Integer = 1 To 3
            CUATeam(t) = New cCUATeam(5)
        Next t

        Select Case TeamID
            Case Type.Team1ID
                If VillainID >= 1001 And VillainID <= 1005 Then
                    CUATeam(1).TeamID = 100
                    CUATeam(1).Villains(VillainIndex).IDNumber = Villain.VillainID
                    CUATeam(1).Villains(VillainIndex).Name = Villain.Name
                    CUATeam(1).Villains(VillainIndex).Loot(1) = Villain.Loot(1)
                    CUATeam(1).Villains(VillainIndex).Loot(2) = Villain.Loot(2)
                    CUATeam(1).Villains(VillainIndex).Caught = Villain.Caught
                    CUATeam(1).Villains(VillainIndex).AssignCategory()
                    CUATeam(1).Villains(VillainIndex).CalculateVillainry()
                    CUATeam(1).PowerValue = CUATeam(TeamIndex).DeterminePowerValue(CUATeam(TeamIndex).Villains(VillainIndex).Category)

                    'Display the content of the file in a grid 
                    PIG(VillainIndex, 1, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Name))
                    PIG(VillainIndex, 2, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Caught))
                    PIG(VillainIndex, 3, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Category))
                    PIG(VillainIndex, 4, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Loot(1)))
                    PIG(VillainIndex, 5, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Loot(2)))
                    PIG(VillainIndex, 6, CStr(CUATeam(TeamIndex).Villains(VillainIndex).CalculateVillainry()))
                Else
                    If VillainID >= 1006 And VillainID <= 10010 Then
                        CUATeam(2).TeamID = 200
                        CUATeam(2).Villains(VillainIndex).IDNumber = Villain.VillainID
                        CUATeam(2).Villains(VillainIndex).Name = Villain.Name
                        CUATeam(2).Villains(VillainIndex).Loot(1) = Villain.Loot(1)
                        CUATeam(2).Villains(VillainIndex).Loot(2) = Villain.Loot(2)
                        CUATeam(2).Villains(VillainIndex).Caught = Villain.Caught
                        CUATeam(2).Villains(VillainIndex).AssignCategory()
                        CUATeam(2).Villains(VillainIndex).CalculateVillainry()
                        CUATeam(2).PowerValue = CUATeam(TeamIndex).DeterminePowerValue(CUATeam(TeamIndex).Villains(VillainIndex).Category)

                        'Display the content of the file in a grid 
                        PIG(VillainIndex, 1, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Name))
                        PIG(VillainIndex, 2, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Caught))
                        PIG(VillainIndex, 3, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Category))
                        PIG(VillainIndex, 4, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Loot(1)))
                        PIG(VillainIndex, 5, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Loot(2)))
                        PIG(VillainIndex, 6, CStr(CUATeam(TeamIndex).Villains(VillainIndex).CalculateVillainry()))
                    Else
                        If VillainID >= 1011 And VillainID <= 1015 Then
                            CUATeam(3).TeamID = 300
                            CUATeam(3).Villains(VillainIndex).IDNumber = Villain.VillainID
                            CUATeam(3).Villains(VillainIndex).Name = Villain.Name
                            CUATeam(3).Villains(VillainIndex).Loot(1) = Villain.Loot(1)
                            CUATeam(3).Villains(VillainIndex).Loot(2) = Villain.Loot(2)
                            CUATeam(3).Villains(VillainIndex).Caught = Villain.Caught
                            CUATeam(3).Villains(VillainIndex).AssignCategory()
                            CUATeam(3).Villains(VillainIndex).CalculateVillainry()
                            CUATeam(3).PowerValue = CUATeam(TeamIndex).DeterminePowerValue(CUATeam(TeamIndex).Villains(VillainIndex).Category)

                            'Display the content of the file in a grid
                            PIG(VillainIndex, 1, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Name))
                            PIG(VillainIndex, 2, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Caught))
                            PIG(VillainIndex, 3, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Category))
                            PIG(VillainIndex, 4, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Loot(1)))
                            PIG(VillainIndex, 5, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Loot(2)))
                            PIG(VillainIndex, 6, CStr(CUATeam(TeamIndex).Villains(VillainIndex).CalculateVillainry()))
                        Else
                            CreateBlankRecord()
                            CUATeam(TeamIndex).Villains(VillainIndex).IDNumber = Villain.VillainID
                            CUATeam(TeamIndex).Villains(VillainIndex).Name = Villain.Name
                            CUATeam(TeamIndex).Villains(VillainIndex).Loot(1) = Villain.Loot(1)
                            CUATeam(TeamIndex).Villains(VillainIndex).Loot(2) = Villain.Loot(2)
                            CUATeam(TeamIndex).Villains(VillainIndex).Caught = Villain.Caught
                            CUATeam(TeamIndex).Villains(VillainIndex).AssignCategory()
                            CUATeam(TeamIndex).Villains(VillainIndex).CalculateVillainry()
                            CUATeam(TeamIndex).PowerValue = CUATeam(TeamIndex).DeterminePowerValue(CUATeam(TeamIndex).Villains(VillainIndex).Category)

                            'Display the content of the file in a grid
                            PIG(VillainIndex, 1, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Name))
                            PIG(VillainIndex, 2, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Caught))
                            PIG(VillainIndex, 3, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Category))
                            PIG(VillainIndex, 4, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Loot(1)))
                            PIG(VillainIndex, 5, CStr(CUATeam(TeamIndex).Villains(VillainIndex).Loot(2)))
                            PIG(VillainIndex, 6, CStr(CUATeam(TeamIndex).Villains(VillainIndex).CalculateVillainry()))
                        End If
                    End If
                End If
        End Select
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        'Text box
        txtTeamInfo.Text = CUATeam(TeamIndex).Display(VillainIndex)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnHighestPowerCUATeam.Click
        'Finding the highest powervalue team 
        Dim Max As Integer
        Dim MaxInd As Integer

        Max = CUATeam(1).PowerValue

        For t As Integer = 2 To 3
            If Max < CUATeam(t).PowerValue Then
                Max = CUATeam(t).PowerValue
                MaxInd = t
            End If
        Next t

        'Display
        txtHighestPowerCUATeam.Text = CStr(CUATeam(MaxInd).TeamID)

    End Sub
End Class
