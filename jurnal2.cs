using System;

public class jurnal2
{
    static void Main()
    {

        Console.WriteLine("== PROGRAM KASIR BIOSKOP RAMA BY DAPINSKUYY ==");

        Console.WriteLine("Pilih Kelas Studio: ");
        Console.WriteLine("1. Reguler (Rp 40.000)");
        Console.WriteLine("2. Premiere (Rp 60.000)");
        Console.WriteLine("3. IMAX (Rp 80.000)");

        Console.Write("Masukkan pilihan (1-3): ");

        int pilihan = int.Parse(Console.ReadLine());

        //variabel harga per tiket
        int hargaPerTiket;

        switch (pilihan)
        {
            case 1:
                hargaPerTiket = 40000;
                break;
            case 2:
                hargaPerTiket = 60000;
                break;
            case 3:
                hargaPerTiket = 80000;
                break;
            default:
                Console.WriteLine("Pilihan tidak valid");
                return;
        }

        //label dan variabel jumlah tiket yg dibeli
        Console.Write("Masukkan Jumlah ticket: ");
        int jumlahTiket = int.Parse(Console.ReadLine());

        //label dan variabel apakah weekend atau gak
        Console.Write("Apakah hari ini weekend? (y/n): ");
        string weekend = Console.ReadLine();

        //jika weekend maka
        if (weekend == "y")
        {
            hargaPerTiket += 10000;
        } else if (weekend == "n")
        {
            //
        } else
        {
            Console.WriteLine("pilihan tidak valid");
        }

        //variabel total harga yang harga pertiket sudah dikalikan jumlah tiket
        int totalHarga = hargaPerTiket*jumlahTiket;

        //deklarasi variabel persenan diskon
        int persenDiskon = 0;

        //jika jumlah tiket lebih sama dengan 7, maka
        if (jumlahTiket >= 7)
        {
            persenDiskon = 10;
        } else if (jumlahTiket >= 4 && jumlahTiket <= 6)
        {
            persenDiskon = 5;
        } else if (jumlahTiket >= 1 && jumlahTiket <= 3)
        {
            //
        } else
        {
            Console.WriteLine("Diskon Tidak Valid");
        }

        //hitung persenan diskonnya berapa
        int diskon = totalHarga * persenDiskon / 100;
        //harga akhir setelah diskon berapa
        int hargaAkhir = totalHarga - diskon;

        //labeling dan output
        Console.WriteLine();
        Console.WriteLine("==RINCIAN PEMBELIAN==");
        Console.WriteLine("Harga Per Tiket: " + hargaPerTiket);
        Console.WriteLine("Total Harga: " + totalHarga);
        Console.WriteLine("Diskon: " + persenDiskon+"%" + ": " + diskon);
        Console.WriteLine("Total Bayar: " + hargaAkhir);

        //jika harga akhir lebih dr tiga ratus ribu maka dapat voucher popcorn
        if (hargaAkhir > 300000)
        {
            Console.WriteLine("Selamat anda mendapat voucher popcorn");
            Console.WriteLine();
        } else
        {
            //
        }



        


    }
}