using System;

class bulan
{
    static void Main()
    {
        Console.WriteLine("Masukkan bulan (1-12): ");
        int bulan = int.Parse(Console.ReadLine());
        switch (bulan)
        {
            case 1:
                Console.WriteLine("Januari");
                break;
            case 2:
                Console.WriteLine("Februari");
                break;
            case 3:
                Console.WriteLine("Maret");
                break;
            case 4:
                Console.WriteLine("April");
                break;
            case 5:
                Console.WriteLine("Mei");
                break;
            case 6:
                Console.WriteLine("Juni");
                break;
            case 7:
                Console.WriteLine("Juli");
                break;
            case 8:
                Console.WriteLine("Agustus");
                break;
            case 9:
                Console.WriteLine("September");
                break;
            case 10:
                Console.WriteLine("Oktober");
                break;
            case 11:
                Console.WriteLine("November");
                break;
            case 12:
                Console.WriteLine("Desember");
                break;
            default:
                Console.WriteLine("Bulan tidak valid");
                break;
        }
    }
}