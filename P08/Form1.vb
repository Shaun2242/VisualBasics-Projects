' **************************************************************************************************
' Surname, Initials: Lekgothoane MS
' Student Number:223007245
' Practical: P2023-08
' **************************************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmBursary
    'Variable declaration
    Private nStudents As Integer
    Private Students() As cStudent
    Private HighSchool As cHighSchool
    Private University As cUniversity
    Private Choise As Integer
    Private FS As FileStream
    Private BF As BinaryFormatter
    Private Sub ResizeArrays()
        ReDim Students(nStudents)
    End Sub

    'Enumiration
    Private Enum Type
        HighSchool = 1
        University = 2
    End Enum

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        'Take in number of students 
        nStudents = CInt(InputBox("Enter number of students"))

        'Resize Array
        ResizeArrays()

        'Take in inputs from user 
        For s As Integer = 1 To nStudents

            Choise = CInt(InputBox("Choose Student Type (1) HighSchool , (2) University For Student " & s))

            Select Case Choise
                Case Type.HighSchool
                    'Take in inputs fro highschool student 
                    HighSchool = New cHighSchool(InputBox("Enter Full Name For HighSchool Student"))
                    For m As Integer = 1 To 3
                        HighSchool.Marks(m) = cStudent.ValidateMarks(CInt(InputBox("Enter Mark " & m & " for high school student")))
                    Next m
                    HighSchool.ExtraMural = CBool(InputBox("HighSchool student was involved in extramural activities, Enter True or False)"))
                    HighSchool.Prefect = CBool(InputBox("HighSchool student was a prefect, Enter True or False"))

                    Dim Average As Double

                    'Calculate Average 
                    Average = HighSchool.CalculateAverage()
                    HighSchool.EvaluateStudent(HighSchool.Qualifies)

                    Students(s) = HighSchool

                Case Type.University
                    'Take in inputs for university student
                    University = New cUniversity(InputBox("Enter Full Name For University Student"))
                    For m As Integer = 1 To 2
                        University.Marks(m) = cStudent.ValidateMarks(CInt(InputBox("Enter Mark " & m & " for university student")))
                    Next m
                    Dim Average As Double
                    'Calculate average 
                    Average = University.CalculateAverage()
                    University.EvaluateStudent(University.Qualifies)

                    Students(s) = University

            End Select
        Next s
    End Sub

    Private Sub btnHighSchStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        'Polymorphism
        For s As Integer = 1 To nStudents
            txtStudents.Text += CStr(Students(s).Display()) & Environment.NewLine & Environment.NewLine
        Next s
    End Sub

    Private Sub btnWriteFile_Click(sender As Object, e As EventArgs) Handles btnWriteFile.Click

        'Create and write to file
        FS = New FileStream("S223007245_P08_2023.ipb", FileMode.Create, FileAccess.Write)
        BF = New BinaryFormatter()

        For S As Integer = 2 To nStudents Step 2
            BF.Serialize(FS, Students(S))
        Next S
        FS.Close()
    End Sub

    Private Share As Double
    Private Max As Double
    Private MaxInd As Integer
    Private Sub btnReadFile_Click(sender As Object, e As EventArgs) Handles btnReadFile.Click

        'Open and read from file
        FS = New FileStream("S223007245_P08_2023.ipb", FileMode.Open, FileAccess.Read)
        BF = New BinaryFormatter()

        For s As Integer = 2 To nStudents Step 2
            While FS.Position < FS.Length
                Students(s) = DirectCast(BF.Deserialize(FS), cUniversity)
            End While
        Next s

        'Find top university student
        Share = 175000 / (nStudents / 2)
        Max = Students(2).Average
        MaxInd = 2

        For s As Integer = 4 To nStudents Step 2
            If Max < Students(s).Average Then
                Max = Students(s).Average
                MaxInd = s
            End If
        Next s

        Share += 10000
        FS.Close()

    End Sub

    Private Sub UniStudent_Click(sender As Object, e As EventArgs) Handles btnUniStudent.Click

        'Display top student information in single-line textbox

        txtUniStudent.Text = "FullName: (" & Students(MaxInd).FullName & ") " & " Average: (" & Students(MaxInd).Average & ") " & " Qualifies: (" & Students(MaxInd).Qualifies & ") " & " Bursary Income: (R" & Share & ")"
    End Sub
End Class
