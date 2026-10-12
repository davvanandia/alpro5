using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Masukkan Nilai a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Masukkan Nilai b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"nilai a = {a}");
        Console.WriteLine($"nilai b = {b}");

        //sama dengan
        bool hasilsama = a == b;
        Console.WriteLine($"apakah a sama dengan b? {hasilsama}");

        //tidak sama dengan
        bool hasiltidakSama = a != b;
        Console.WriteLine($"apakah a tidak sama dengan b? {hasiltidakSama}");

        //lebih besar dari
        bool hasillebihBesar = a > b;
        Console.WriteLine($"apakah a lebih besar dari b? {hasillebihBesar}");

        //lebih kecil dari
        bool hasillebihKecil = a < b;
        Console.WriteLine($"apakah a lebih kecil dari b? {hasillebihKecil}");

        //lebih besar sama dengan
        bool hasillebihBesarSamaDengan = a >= b;
        Console.WriteLine($"apakah a lebih besar sama dengan b? {hasillebihBesarSamaDengan}");

        //lebih kecil sama dengan
        bool hasillebihKecilSamaDengan = a <= b;
        Console.WriteLine($"apakah a lebih kecil sama dengan b? {hasillebihKecilSamaDengan}");
    }
}