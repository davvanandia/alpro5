using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 5;

        //sama dengan
        bool hasilsama = a == b;
        Console.WriteLine($"apakah a sama dengan b? {hasilsama}");

        //tidak sama dengan
        bool hasiltidakSama = a != b;
        Console.WriteLine($"apakah a tidak sama dengan b? {hasiltidakSama}");
    }
}