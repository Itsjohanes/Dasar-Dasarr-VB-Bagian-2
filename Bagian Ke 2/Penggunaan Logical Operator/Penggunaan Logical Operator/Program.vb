Imports System

Module Program
    Sub Main(args As String())
        Dim NamaPengguna, KataSandi As String
        Console.WriteLine("Masukan nama Pengguna")
        NamaPengguna = Console.ReadLine()
        Console.WriteLine("Masukan Kata Sandi")
        KataSandi = Console.ReadLine()
        If (NamaPengguna = "Doni" And KataSandi = "SukaKevin") Then
            Console.WriteLine("Selamat Datang Doni")

        End If
        Console.ReadLine()






    End Sub
End Module
