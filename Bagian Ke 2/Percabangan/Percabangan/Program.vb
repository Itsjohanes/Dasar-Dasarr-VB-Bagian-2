Imports System

Module Program
    Sub Main(args As String())
        If (Now.Hour < 12) Then
            Console.WriteLine("Kurang dari Jam 12")
        End If
        Console.ReadLine()
    End Sub
End Module
