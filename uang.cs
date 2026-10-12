using System;

class uang
{
    static void Main()
    {
        Console.WriteLine("uang gueh: ");
        double uang = double.Parse(Console.ReadLine());

        Console.WriteLine($"uang gueh = {uang}");
        Console.WriteLine();
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Eskrim : 15000");
        Console.WriteLine("2. Gelato : 35000");
        Console.WriteLine("3. Eskrim Roti : 25000");
        Console.WriteLine("Pilih menu: ");
        int menu = int.Parse(Console.ReadLine());
        if (menu == 1)
        {
            uang -= 15000;
            Console.WriteLine($"sisa uang gueh = {uang}");
        } else if (menu == 2)
        {
            uang -= 35000;
            Console.WriteLine($"sisa uang gueh = {uang}");
        } else if (menu == 3)
        {
            uang -= 25000;
            Console.WriteLine($"sisa uang gueh = {uang}");
        } else
        {
            Console.WriteLine("Menu tidak tersedia");
            return;
        } 
    }
}