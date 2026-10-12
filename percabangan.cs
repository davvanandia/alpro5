using System;

class percabangan
{
    static void Main()
    {
        Console.WriteLine("Masukkan nilai batre: ");
        int batre = int.Parse(Console.ReadLine());
        Console.WriteLine($"batre = {batre}");
        if (batre == 20)
        {
            Console.WriteLine("lowbat");
        } else
        {
            Console.WriteLine("batre aman");
        }
    }
}