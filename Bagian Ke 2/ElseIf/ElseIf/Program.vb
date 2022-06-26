Imports System

Module Program
    Sub Main(args As String())
        If (Now.Hour <= 9) Then
            Console.WriteLine("Masih ngantuk")
            Console.ReadLine()

        ElseIf (Now.Hour > 9) And (Now.Hour <= 15) Then
            Console.WriteLine("Selamat Siang")
            Console.ReadLine()
        Else
            Console.WriteLine("Selamat Malam")
            Console.ReadLine()

        End If
    End Sub
End Module
