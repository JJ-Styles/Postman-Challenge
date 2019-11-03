Imports System.IO
Module Module1

    Sub Main()
        Dim floor As Integer
        Dim file As String
        Dim i As Integer
        Dim FileReader As StreamReader = New StreamReader("Advent1.txt")
        file = FileReader.ReadToEnd
        For i = 1 To file.Length
            If Mid(file, i, 1) = "(" Then
                floor += 1
            ElseIf Mid(file, i, 1) = ")" Then
                floor -= 1
            End If
        Next
        Console.WriteLine("The postman will end up on floor " & floor)
        Console.ReadKey()
    End Sub

End Module
