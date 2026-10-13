using System;

class mobil
{
    static void Main()
    {
        Console.WriteLine("==Program Kasir Rental Mobil==");
        Console.WriteLine("Pilih Jenis Mobil: ");
        Console.WriteLine("1. City Car (Rp 250.000 )");
        Console.WriteLine("2. SUV (Rp 400.000)");
        Console.WriteLine("3. Van (Rp 500.000)");

        Console.Write("Masukkan pilihan (1-3): ");
        int pilihan = int.Parse(Console.ReadLine());

        int hargaPerHari = 0;

        switch (pilihan)
        {
            case 1:
            hargaPerHari = 250000;
            break;
            case 2:
            hargaPerHari = 400000;
            break;
            case 3:
            hargaPerHari = 500000;
            break;
            default: 
            Console.WriteLine("Pilihan tidak valid");
            break; 
        }

        Console.Write("Masukkan lama sewa (hari): ");
        int hariSewa = int.Parse(Console.ReadLine());

        Console.Write("Apa memakai sopir? (y/n): ");
        string sopir = Console.ReadLine();

        if (sopir == "y")
        {
            hargaPerHari += 100000;
        } else if (sopir == "n")
        {
            //
        } else
        {
            Console.WriteLine("Pilihan Tidak Valid");
        }


        int hargaTotal = hargaPerHari*hariSewa;



        int persenDiskon = 0;
        if (hariSewa >= 7)
        {
            persenDiskon = 15;
        } else if (hariSewa >= 3 && hariSewa <= 6)
        {
            persenDiskon = 8;
        } else if (hariSewa >= 1 && hariSewa <= 2)
        {
            //
        }
        else
        {
            Console.WriteLine("Diskon tidak valid");
        }

        int diskon = hargaTotal * persenDiskon / 100;
        int hargaAkhir = hargaTotal - diskon;
        

        Console.WriteLine();
        Console.WriteLine("==Rincian Penyewaan==");
        Console.WriteLine("Harga Per Hari: " + hargaPerHari);
        Console.WriteLine("Total Harga: " + hargaTotal);
        Console.WriteLine("Diskon: " + persenDiskon +" " + diskon);
        Console.WriteLine("Total Bayar: " + hargaAkhir);

        if (hargaAkhir > 2000000)
        {
            Console.WriteLine("Selamat anda dapat voucher bbm");
        } else
        {
            //
        }

    }
}