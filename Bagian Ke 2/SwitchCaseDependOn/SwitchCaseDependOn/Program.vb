Imports System

Module Program
    Sub Main(args As String())
        Dim JangkaWaktu As Integer
        Dim Uang, Bunga, TotalUang, Persen As Decimal
        Console.Write("Masukan jumlah uang yang diinginkan")
        Uang = Console.ReadLine()
        Console.Write("Tentukan Lama Waktu (1,3,6,12,24) bulan :")
        JangkaWaktu = (Console.ReadLine)
        Select Case JangkaWaktu
            Case 1
                Persen = 5 / 100
            Case 3
                Persen = 7 / 100
            Case 6
                Persen = 8 / 100
            Case 12
                Persen = 10 / 100
            Case 24
                Persen = 24 / 100

        End Select
        Bunga = Persen * Uang
        TotalUang = Uang + Bunga


        Console.Write("Bunga Deposito Rp:")
        Console.WriteLine(Bunga)
        Console.Write("Total Uang Anda Rp: ")
        Console.WriteLine(TotalUang)
        Console.ReadLine()




    End Sub
End Module
