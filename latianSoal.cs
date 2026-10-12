using System;

class latian
{
    static void Main()
    {
        Console.WriteLine("WARUNG KOPI DAPINSKUYY");
        Console.WriteLine("1. Kopi: 8000");
        Console.WriteLine("2. Teh: 5000");
        Console.WriteLine("3. Susu: 7000");

        Console.WriteLine("Masukkan pilihan menu (1-3): ");
        int menu = int.Parse(Console.ReadLine());

        switch (menu)
        {
            case 1:
                menu = 8000;
                break;
            case 2:
                menu = 5000;
                break;
            case 3:
                menu = 7000;
                break;
            default:
                Console.WriteLine("Menu tidak valid");
                return;
        }

        Console.WriteLine("Masukkan jumlah gelas: ");
        int gelas = int.Parse(Console.ReadLine());

        int totalBelanja = menu*gelas;
        Console.WriteLine();
        Console.WriteLine("STRUKK");
        Console.WriteLine("Total belanja: " + totalBelanja);

        if (totalBelanja >= 40000)
        {
            totalBelanja = totalBelanja - (totalBelanja * 20 / 100);
        } else if (totalBelanja >= 20000)
        {
            totalBelanja = totalBelanja - (totalBelanja * 10 / 100);
        } else
        {
            //
        }


        Console.WriteLine("Anda membeli " + gelas + " gelas");
        Console.WriteLine("Total belanja setelah diskon: " + totalBelanja);
    }
}