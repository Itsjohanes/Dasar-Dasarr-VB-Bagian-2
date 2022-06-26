Imports System

Module Program
    Sub Main(args As String())
        Dim Nama, Sandi As String
        Console.WriteLine("Masukan nama pengguna")
        Nama = Console.ReadLine()
        Console.WriteLine("Masukan Sandi")
        Sandi = Console.ReadLine()
        If (Nama = "Doni" And Sandi = "Kevin") Then
            Console.WriteLine("Selamat Datang doni")
        Else
            Console.WriteLine("Kamu Bukan Doni")

        End If


    End Sub
End Module
